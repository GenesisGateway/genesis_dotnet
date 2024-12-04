using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Specs.Mocks;

namespace Genesis.NetCore.Specs
{
    internal static class SpecHelper
    {
        public static Configuration ConfigStorage;

        public static T SerializeAndDeserialize<T>(T entity) where T : IEntity
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
                config = CreateEmptyStagingConfiguration();
            }
            else
            {
                config = CreateCompleteStagingConfiguration();
            }

            return CreateGenesisClient(config, mockHttpWebRequests);
        }

        public static IGenesisClient CreateGenesisClient(Configuration config, bool mockHttpWebRequests = true)
        {
            if (mockHttpWebRequests)
            {
                RegisterMockWebRequestCreator();
            }
            else
            {
                ClearWebRequestPrefixList();
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

        /// <summary>
        /// Used to undo RegisterMockWebRequestCreator method.
        /// </summary>
        /// <param name="webRequest"></param>
        public static void ClearWebRequestPrefixList()
        {
            var propertyInfo = typeof(WebRequest)
                .GetProperty("PrefixList", BindingFlags.NonPublic | BindingFlags.Static);

            var prefixes = (IList)propertyInfo.GetValue(null);
            var prefixesToRemove = new List<dynamic>();
            foreach (var prefix in prefixes)
            {
                var prefixType = prefix.GetType();
                var prefixField = prefixType.GetField("Prefix");
                var prefixValue = prefixField.GetValue(prefix) as string;
                if (prefixValue.StartsWith("https://"))
                {
                    prefixesToRemove.Add(prefix);
                }
            }

            foreach (var prefix in prefixesToRemove)
            {
                prefixes.Remove(prefix);
            }

            var prefixesCount = prefixes.Count;
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
                apiLogin: "merchant_username",
                apiPassword: "merchant_password",
                endpoint: Endpoints.EComProcessing);
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
                catch (Exception ex)
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