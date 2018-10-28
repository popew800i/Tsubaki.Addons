
namespace Tsubaki.Addons.Weather
{
    using Tsubaki.ModuleBlocks;
    using  Tsubaki.ModuleBlocks.Metadata;
    using Tsubaki.ModuleBlocks.Enums;
    using Ryis.Surround;


    using Newtonsoft.Json;
    using System.Net.Http;
    using System.IO;
    using System.Reflection;
    using System.Diagnostics;

    [Module("Weather")]
    public sealed class Weather : ModuleBase 
    { 
        public override ModuleScopes Scopes => ModuleScopes.None;
        
        protected override bool ExecuteImpl(string[] args, ref object callback)
        {
            var fetch = Surround.Service.FetchAsync().Result;

            callback = fetch.ToString();

            return true;
        }
    }   
}
