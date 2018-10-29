using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsubaki.ModuleBlocks;
using Tsubaki.ModuleBlocks.Enums;

namespace WebSite
{
    public class WebSite : ModuleBase
    {
        public override ModuleScopes Scopes => throw new NotImplementedException();


        protected override bool ExecuteImpl(string[] args, ref object callback)
        {
            WebSiteBase website = new WebSiteBase();
            switch (args)
            {
                case "Facebook":
                    website.
            }              

        }
    }
}
