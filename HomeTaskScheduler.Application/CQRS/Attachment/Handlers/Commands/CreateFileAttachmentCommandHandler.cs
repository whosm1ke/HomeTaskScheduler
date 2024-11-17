using AutoMapper;
using HomeTaskScheduler.Application.Configs;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;
using HomeTaskScheduler.Application.Utils;
using HomeTaskScheduler.Domain.Entities.Attachments;
using Microsoft.Extensions.Options;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class CreateFileAttachmentCommandHandler : IRequestHandler<CreateFileAttachmentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly ThumbnailGeneratorFactory thumbnailGeneratorFactory;
    private readonly AttachmentSettings attachmentSettings;

    public CreateFileAttachmentCommandHandler(
        IUnitOfWork unitOfWork, 
        IMapper mapper, 
        ThumbnailGeneratorFactory thumbnailGeneratorFactory,
        IOptions<AttachmentSettings> attachmentSettings)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.thumbnailGeneratorFactory = thumbnailGeneratorFactory;
        this.attachmentSettings = attachmentSettings.Value;
    }

    public async Task<Unit> Handle(CreateFileAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Ensure directories exist
        Directory.CreateDirectory(attachmentSettings.AttachmentsPath);
        Directory.CreateDirectory(attachmentSettings.ThumbnailsPath);

        // Save the file
        string filePath = Path.Combine(attachmentSettings.AttachmentsPath, request.FileAttachment.AttachmentName);
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await request.FileAttachment.FileStream.CopyToAsync(fileStream, cancellationToken);
        }

        // Generate and save the thumbnail
        var thumbnailGenerator = thumbnailGeneratorFactory.GetThumbnailGenerator(ThumbnailType.Image);
        thumbnailGenerator.BasePath = attachmentSettings.ThumbnailsPath;
        string thumbnailFileName = Path.GetFileNameWithoutExtension(request.FileAttachment.AttachmentName) + ".png";
        string thumbnailPath = await thumbnailGenerator.GenerateThumbnailAsync(request.FileAttachment.FileStream, thumbnailFileName, 200, 200);

        // Save file and thumbnail info to the database
        var fileAttachment = mapper.Map<FileAttachment>(request.FileAttachment);
        fileAttachment.Path = filePath;
        fileAttachment.ThumbnailPath = thumbnailPath;
            
 
        await unitOfWork.AttachmentRepository.AddAsync(fileAttachment);
        await unitOfWork.SaveAsync();

        return Unit.Value;
    }
}