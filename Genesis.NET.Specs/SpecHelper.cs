using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Specs.Mocks;
using System.IO;
using System.Reflection;

namespace Genesis.Net.Specs
{
    internal static class SpecHelper
    {
        public static Configuration ConfigStorage;

        public static T SerializeAndDeserialize<T>(T entity) where T : Entity
        {
            var serializedEntity = XmlSerializationHelpers.Serialize(entity);
            var deserializedEntity = XmlSerializationHelpers.Deserialize<T>(serializedEntity);
            return deserializedEntity;
        }

        public static string[] GetMemberNamesInAscendingOrder(IEnumerable<ValidationResult> validationErrors)
        {
            return validationErrors.Select(e => e.MemberNames.First()).OrderBy(m => m).ToArray();
        }

        public static string[] GetErrorMessagesInAscendingOrder(IEnumerable<ValidationResult> validationErrors)
        {
            return validationErrors.Select(e => e.ErrorMessage).OrderBy(m => m).ToArray();
        }

        public static IGenesisClient CreateGenesisClient(bool mockHttpWebRequests = true)
        {
            Configuration config;

            if (mockHttpWebRequests)
            {
                RegisterMockWebRequestCreator();
                config = CreateEmptyStagingConfiguration();
            }
            else
            {
                config = CreateCompleteStagingConfiguration();
            }

            ConfigStorage = config;

            return GenesisClientFactory.Create(config);
        }

        private static void RegisterMockWebRequestCreator()
        {
            var creator = new MockWebRequestCreate();

            WebRequest.RegisterPrefix("https://gate", creator);
            WebRequest.RegisterPrefix("https://staging.gate", creator);
            WebRequest.RegisterPrefix("https://wpf", creator);
            WebRequest.RegisterPrefix("https://staging.wpf", creator);
        }

        public static Configuration CreateEmptyStagingConfiguration()
        {
            var configuration = new Configuration(environment: Environments.Staging,
                terminalToken: string.Empty,
                apiLogin: string.Empty,
                apiPassword: string.Empty,
                endpoint: Endpoints.EComProcessing);
            return configuration;
        }

        public static Configuration CreateCompleteStagingConfiguration()
        {
            var configuration = new Configuration(environment: Environments.Staging,
                terminalToken: "terminal_token",
                apiLogin:      "merchant_username",
                apiPassword:   "merchant_password",
                endpoint:      Endpoints.EComProcessing);
            return configuration;
        }

        public static void RunSpecs(object specsContainerInstance)
        {
            var specs = specsContainerInstance.GetType().GetMethods().Where(m => m.Name.StartsWith("it"));
            foreach (var spec in specs)
            {
                try
                {
                    spec.Invoke(specsContainerInstance, new object[] { });
                }
                catch(Exception ex)
                {
                    throw ex.InnerException;
                }
            }
        }

        public static bool CheckForInternetConnection(string url)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead(url))
                {
                    stream.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}