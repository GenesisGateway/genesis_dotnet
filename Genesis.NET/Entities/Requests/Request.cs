using System;
using System.Linq;

namespace Genesis.Net.Entities.Requests
{
    public abstract class Request : Entity
    {
        public virtual string SubDomain
        {
            get { return "gate"; }
        }

        public virtual string ApiPath
        {
            get { return string.Empty; }
        }

        public virtual bool AppendTerminalToken
        {
            get { return true; }
        }
    }
}