using Genesis.Net.Common;
using Genesis.Net.Entities;
using Genesis.Net.Validations;
using NSpec;
using System;
using System.Linq;

namespace Genesis.Net.Specs.Entities
{
    class describe_mpi_params : nspec
    {
        private MpiParams mpiParams;

        void before_each()
        {
            mpiParams = new MpiParams()
            {
                Cavv = "test_cavv",
                Eci = "test_eci",
                Xid = "test_xid"
            };
        }

        void it_should_serialize_and_deserialize_correctly()
        {
            var actualMpiParams = SpecHelper.SerializeAndDeserialize<MpiParams>(mpiParams);
            actualMpiParams .should_be(mpiParams);
        }

        void it_should_report_missing_required_nullable_fields_on_validation()
        {
            mpiParams.Cavv = null;
            mpiParams.Eci = null;
            mpiParams.Xid = null;

            var validationErrors = EntitiesValidator.GetValidationErrors(mpiParams);
            validationErrors.Count().should_be(3);

            var expectedMembers = new string[] {
                "Cavv", "Eci", "Xid"
            }.OrderBy(m => m);

            var actualMembers = SpecHelper.GetMemberNamesInAscendingOrder(validationErrors);
            actualMembers.should_be(expectedMembers);

            var expectedErrorMessages = expectedMembers
                .Select(m => ValidationMessages.Required(m)).ToArray().OrderBy(m => m);

            var actualErrorMessages = SpecHelper.GetErrorMessagesInAscendingOrder(validationErrors);
            actualErrorMessages.should_be(expectedErrorMessages);
        }
    }
}
