using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Genesis.Net.Entities;
using Genesis.Net.Entities.Requests;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Specs.Mocks;
using NSpec;
using System.Reflection;

namespace Genesis.Net.Specs
{
    class describe_transaction_execution<T, S, E>
        where T : Request
        where S : Entity
        where E : Entity, IErrorResponse
    {
        private readonly IGenesisClient genesisClient;

        private T validRequest;
        private string successResponseXml;
        private string errorResponseXml;

        private T invalidRequest;

        public describe_transaction_execution(IGenesisClient genesisClient, T validRequest,
            string successResponseXml, string errorResponseXml, T invalidRequest = null)
        {
            this.genesisClient = genesisClient;

            this.validRequest = validRequest;
            this.successResponseXml = successResponseXml;
            this.errorResponseXml = errorResponseXml;

            this.invalidRequest = invalidRequest;
        }

        public void it_should_receive_success_response_upon_sync_execution_of_valid_transaction()
        {
            MockWebRequestCreate.SetResponseForNextMockHttpWebRequest(successResponseXml);
            Execute(validRequest).should_be_success();
        }

        public void it_should_receive_error_response_upon_sync_execution_of_valid_transaction()
        {
            MockWebRequestCreate.SetResponseForNextMockHttpWebRequest(errorResponseXml);
            Execute(validRequest).should_be_error();
        }

        public void it_should_receive_success_response_upon_async_execution_of_valid_transaction()
        {
            MockWebRequestCreate.SetResponseForNextMockHttpWebRequest(successResponseXml);

            var task = ExecuteAsync(validRequest);
            task.Wait();

            task.Result.should_be_success();
        }

        public void it_should_receive_error_response_upon_async_execution_of_valid_transaction()
        {
            MockWebRequestCreate.SetResponseForNextMockHttpWebRequest(errorResponseXml);

            var task = ExecuteAsync(validRequest);
            task.Wait();

            task.Result.should_be_error();
        }

        public void it_should_throw_validation_exception_upon_sync_execution_of_invalid_transaction()
        {
            if (invalidRequest == null)
                return;

            Exception exception = null;
            try
            {
                Execute(invalidRequest);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            exception.GetType().should_be(typeof(ValidationException));
        }

        public void it_should_throw_validation_exception_upon_async_execution_of_invalid_transaction()
        {
            if (invalidRequest == null)
                return;

            Exception exception = null;
            try
            {
                ExecuteAsync(invalidRequest).Wait();
            }
            catch (AggregateException ex)
            {
                exception = ex.InnerException;
            }
            exception.GetType().should_be(typeof(ValidationException));
        }

        private Result<S, E> Execute<T>(T request)
        {
            var method = GetExecuteMethod(sync: true, parameterType: typeof(T));

            try
            {
                return (Result<S, E>)method.Invoke(genesisClient, new object[] { request });
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        private Task<Result<S, E>> ExecuteAsync(T request)
        {
            var method = GetExecuteMethod(sync: false, parameterType: typeof(T));

            try
            {
                return (Task<Result<S, E>>)method.Invoke(genesisClient, new object[] { request });
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        private MethodInfo GetExecuteMethod(bool sync, Type parameterType)
        {
            string methodName;
            if (sync)
            {
                methodName = "Execute";
            }
            else
            {
                methodName = "ExecuteAsync";
            }

            var method = genesisClient.GetType()
                                      .GetMethods()
                                      .Where(m => m.Name == methodName)
                                      .First(m => m.GetParameters().Count() == 1 && m.GetParameters().First().ParameterType == parameterType);
            return method;
        }
    }
}