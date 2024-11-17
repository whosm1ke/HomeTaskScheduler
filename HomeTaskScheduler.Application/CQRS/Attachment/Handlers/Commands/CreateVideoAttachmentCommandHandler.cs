using AutoMapper;
using HomeTaskScheduler.Application.Configs;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;
using HomeTaskScheduler.Application.Utils;
using HomeTaskScheduler.Domain.Entities.Attachments;
using MediatR;
using Microsoft.Extensions.Options;
using Xabe.FFmpeg;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class CreateVideoAttachmentCommandHandler : IRequestHandler<CreateVideoAttachmentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly ThumbnailGeneratorFactory thumbnailGeneratorFactory;
    private readonly AttachmentSettings attachmentSettings;

    public CreateVideoAttachmentCommandHandler(
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

    public async Task<Unit> Handle(CreateVideoAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Ensure directories exist
        Directory.CreateDirectory(attachmentSettings.AttachmentsPath);
        Directory.CreateDirectory(attachmentSettings.ThumbnailsPath);

        // Save the file
        string filePath = Path.Combine(attachmentSettings.AttachmentsPath, request.VideoAttachment.AttachmentName);
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await request.VideoAttachment.FileStream.CopyToAsync(fileStream, cancellationToken);
        }

        // Generate and save the thumbnail
        var thumbnailGenerator = thumbnailGeneratorFactory.GetThumbnailGenerator(ThumbnailType.Video);
        thumbnailGenerator.BasePath = attachmentSettings.ThumbnailsPath;
        string thumbnailFileName = Path.GetFileNameWithoutExtension(request.VideoAttachment.AttachmentName) + ".png";
        string thumbnailPath = await thumbnailGenerator.GenerateThumbnailAsync(request.VideoAttachment.FileStream, thumbnailFileName, 200, 200);

        // Save file and thumbnail info to the database
        var videoAttachment = mapper.Map<VideoAttachment>(request.VideoAttachment);
        videoAttachment.Path = filePath;
        videoAttachment.ThumbnailPath = thumbnailPath;
        videoAttachment.DurationInSeconds = (await FFmpeg.GetMediaInfo(filePath)).Duration.TotalSeconds;
        
            
 
        await unitOfWork.AttachmentRepository.AddAsync(videoAttachment);
        await unitOfWork.SaveAsync();

        return Unit.Value;
    }
}