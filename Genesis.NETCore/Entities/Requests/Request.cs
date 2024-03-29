﻿namespace Genesis.NetCore.Entities.Requests
{
    public abstract class Request : IEntity
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