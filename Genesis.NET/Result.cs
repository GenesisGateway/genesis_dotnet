using System;
using System.Linq;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Responses.Error;

namespace Genesis.Net
{
    /// <summary>
    /// Represents the result returned from Genesis. It can be either Success or Error but never both.
    /// </summary>
    /// <typeparam name="S">Success response type</typeparam>
    /// <typeparam name="E">Error response type</typeparam>
    public class Result<S, E>
        where S : Entity
        where E : Entity, IErrorResponse
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