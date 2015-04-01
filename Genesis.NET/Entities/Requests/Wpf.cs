using System;
using System.Linq;

namespace Genesis.Net.Entities.Requests
{
    public class Wpf : Request
    {
        public override string SubDomain
        {
            get
            {
                return "wpf";
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