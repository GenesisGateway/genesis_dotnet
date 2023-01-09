using Genesis.NetCore.Contracts;
using Genesis.NetCore.Entities.Responses.Successful;

namespace Genesis.NetCore.Entities.Requests.Initial.Threedsv2
{
    public class ContinueRequest : Request, IPutRequest, IUrlEncodedSignature
    {
        private readonly string apiPath = "threeds/threeds_method";

        public ContinueRequest()
        {
        }

        public ContinueRequest(CardTransactionSuccessResponse response, Configuration configuration)
            : base()
        {
            apiPath += string.Format("/{0}", response.UniqueId);
            Signature = response.GenerateSignature(configuration);
        }


        public string Signature { get; set; }

        public override string SubDomain
        {
            get
            {
                return "gate";
            }
        }

        public override string ApiPath
        {
            get
            {
                return apiPath;
            }
        }

        public override bool AppendTerminalToken
        {
            get
            {
                return false;
            }
        }
    }
}
