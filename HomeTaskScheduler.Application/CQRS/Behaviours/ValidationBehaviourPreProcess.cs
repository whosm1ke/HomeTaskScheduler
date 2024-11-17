using FluentValidation;
using MediatR.Pipeline;
using ValidationException = HomeTaskScheduler.Application.Exceptions.ValidationException;

namespace HomeTaskScheduler.Application.CQRS.Behaviours;

public class ValidationBehaviourPreProcess<TRequest> : IRequestPreProcessor<TRequest>
{
    private readonly IEnumerable<IValidator<TRequest>> validators;

    public ValidationBehaviourPreProcess(IEnumerable<IValidator<TRequest>> validators)
    {
        this.validators = validators;
    }

    public async Task Process(TRequest request, CancellationToken cancellationToken)
    {
        if (validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults =
                await Task.WhenAll(validators.Select(x => x.ValidateAsync(context, cancellationToken)));
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failures.Count != 0)
            {
                var errorDictionary = failures
                    .GroupBy(f => f.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(f => f.ErrorMessage).ToArray()
                    );

                throw new ValidationException(errorDictionary);
            }
        }
    }
}