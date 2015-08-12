using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Specs.Mocks;

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
                certificate: null,
                endpoint: Endpoints.EComProcessing);
            return configuration;
        }

        public static Configuration CreateCompleteStagingConfiguration()
        {
            var configuration = new Configuration(environment: Environments.Staging,
                terminalToken: "a100f8ee52bb5e2605d4bfe0454cfc945125e8cf",
                apiLogin: "64d9863c9cc192685bc152923af5450aae8124ad",
                apiPassword: "fac7ee4dafcfbd3f677220bacca7a4d7ba578d7c",
                certificate: X509Certificate.CreateFromCertFile(@"Certificates/genesis_sandbox_comodo_ca.pem"),
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
                catch(Exception ex)
                {
                    throw ex.InnerException;
                }
            }
        }
    }
}