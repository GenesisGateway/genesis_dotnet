using System.Collections.Specialized;

namespace Genesis.Net.Entities.Notifications
{
    public class KYCNotification : Notification
    {
        public KYCNotification(NameValueCollection notificationParameters)
        {
            ReferenceId = notificationParameters.Get("reference_id");
            FillStandardParameters(this, notificationParameters);
        }

        public string ReferenceId { get; set; }

        public string KycSource { get; set; }

        public string Risk_score { get; set; }

        public string ExternalUniqueId { get; set; }

        public string AnalysisReferenceId { get; set; }

        public string ControlsIdentifier { get; set; }

        #region Additional information related to verification process
        public string ControlsTitleMsg { get; set; }

        public string ControlsResultMsg { get; set; }

        public string ControlsResult { get; set; }

        public string ControlsControlIdentifier { get; set; }

        public string ControlsControlTitleMsg { get; set; }

        public string ControlsControlResultMsg { get; set; }

        public string ControlsControlResult { get; set; }

        public string DocumentClassificationIdType { get; set; }

        public string DocumentDetailEmitCountry { get; set; }

        public string DocumentDetailExpirationDateDay { get; set; }

        public string DocumentDetailExpirationDateMonth { get; set; }

        public string DocumentDetailExpirationDateYear { get; set; }

        public string DocumentDetailDocumentNumber { get; set; }

        public string DocumentDetailExtraInfosDataKey { get; set; }

        public string DocumentDetailExtraInfosDataValue { get; set; }

        public string DocumentDetailExtraInfosTitle { get; set; }

        public string HolderDetailLastName { get; set; }

        public string HolderDetailFirstName { get; set; }

        public string HolderDetailNationality { get; set; }

        public string HolderDetailGender { get; set; }

        public string HolderDetailBirthDateDay { get; set; }

        public string HolderDetailBirthDateMonth { get; set; }

        public string HolderDetailBirthDateYear { get; set; }

        public string MrzLine1 { get; set; }

        public string MrzLine { get; set; }

        public string CheckReportSummaryCheckIdentifier { get; set; }

        public string CheckReportSummaryCheckTitleMsg { get; set; }

        public string CheckReportSummaryCheckResultMsg { get; set; }

        public string CheckReportSummaryCheckResult { get; set; }
        #endregion

        public string Notification_type { get; set; }

        public string Status { get; set; }

        public string VerificationUrl { get; set; }

        public string Email { get; set; }

        public string DeclinedReason { get; set; }

        public string AdditionalData { get; set; }


        protected override string GetUniqueId()
        {
            return ReferenceId;
        }
    }
}
