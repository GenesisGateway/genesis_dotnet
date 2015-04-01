using System;

namespace Genesis.Net.Errors
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
            var resourceManager = Genesis.Net.Properties.Resources.ResourceManager;
            return resourceManager.GetString(name);
        }
    }
}
