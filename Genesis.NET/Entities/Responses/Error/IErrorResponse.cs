using Genesis.Net.Errors;
namespace Genesis.Net.Entities.Responses.Error
{
    public interface IErrorResponse
    {
        ErrorCodes Code { get; }

        string TechnicalMessage { get; }

        string Message { get; }
    }
}