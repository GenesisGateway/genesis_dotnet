using System.Linq;
using Genesis.NetCore.Common;
using Genesis.NetCore.Entities;
using Genesis.NetCore.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Genesis.NetCore.Specs.Entities
{
    [TestClass]
    public class describe_mpi_params
    {
        private MpiParams mpiParams;

        [TestInitialize]
        public void before_each()
        {
            mpiParams = new MpiParams()
            {
                Cavv = "test_cavv",
                Eci = "test_eci",
                Xid = "test_xid"
            };
        }

        [TestMethod]
        public void it_should_serialize_and_deserialize_correctly()
        {
            mpiParams.should_serialize_and_deserialize();
        }

        [TestMethod]
        public void it_should_report_missing_required_nullable_fields_on_validation()
        {
            mpiParams.Cavv = null;
            mpiParams.Eci = null;
            mpiParams.Xid = null;

            var validationErrors = EntitiesValidator.GetValidationErrors(mpiParams);
            validationErrors.Count().should_be(3);

            var expectedMembers = new string[] {
                "Cavv", "Eci", "Xid"
            }.OrderBy(m => m).ToArray();

            var actualMembers = SpecHelper.GetMemberNamesInAscendingOrder(validationErrors);
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = expectedMembers
                .Select(m => ValidationMessages.Required(m)).OrderBy(m => m).ToArray();

            var actualErrorMessages = SpecHelper.GetErrorMessagesInAscendingOrder(validationErrors);
            actualErrorMessages.should_be(expectedErrorMessages);
        }
    }
}
