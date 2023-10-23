using FluentValidation.Results;

namespace CarCatalog.Application.Common.Exceptions;

public class ValidationException : Exception
{
    private IDictionary<string, string[]> Errors { get; set; }
    
    public ValidationException(string message)
        : base(message)
    {
    }

    public ValidationException(IEnumerable<ValidationFailure> failures)
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}