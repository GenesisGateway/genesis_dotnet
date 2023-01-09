using System.Resources;

namespace Genesis.NetCore.Errors
{
    public static class ErrorsService
    {
        public static string GetName(ErrorCodes errorCode)
        {
            return errorCode.ToString();
        }

        public static string GetDescription(ErrorCodes errorCode)
        {
            return GetResourceValue(GetName(errorCode));
        }

        private static string GetResourceValue(string name)
        {
            var resourceManager = new ResourceManager("Resources", typeof(ErrorsService).Assembly);
            return resourceManager.GetString(name);
        }
    }
}
