namespace Genesis.NetCore.Specs
{
    internal static class CardsNumbers
    {
        public const string VisaSuccessfulTransaction = "4200000000000000";
        public const string VisaDeclinedTransaction = "4111111111111111";
        public const string MasterCardSuccessfulTransaction = "5555555555554444";
        public const string MasterCardDeclinedTransaction = "5105105105105100";
        public const string Visa3dSecureEnrolled = "4711100000000000";
        public const string Visa3dsv2FrictionlessAuthenticated = "4012000000060085";
        public const string Visa3dsv2FrictionlessWith3dsMethodAuthenticated = "4066330000000004";
        public const string Visa3dsv2Challenge = "4918190000000002";
        public const string Visa3dsv2ChallengeWith3dsMethod = "4938730000000001";
        public const string Visa3dsv2FallbackTo3dv1 = "4901170000000003";
        public const string Visa3dsv2FallbackTo3dv1With3dsMethod = "4901164281364345";
    }
}
