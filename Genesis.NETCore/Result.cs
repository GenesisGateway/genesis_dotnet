using Genesis.NetCore.Entities;
using Genesis.NetCore.Entities.Responses.Error;

namespace Genesis.NetCore
{
    /// <summary>
    /// Represents the result returned from Genesis. It can be either Success or Error but never both.
    /// </summary>
    /// <typeparam name="S">Success response type</typeparam>
    /// <typeparam name="E">Error response type</typeparam>
    public class Result<S, E>
        where S : IEntity
        where E : IEntity, IErrorResponse
    {
        public readonly S SuccessResponse;

        public readonly E ErrorResponse;

        public bool IsSuccessful
        {
            get { return SuccessResponse != null; }
        }

        internal Result(S successResponse)
        {
            SuccessResponse = successResponse;
        }

        internal Result(E errorResponse)
        {
            ErrorResponse = errorResponse;
        }
    }
}