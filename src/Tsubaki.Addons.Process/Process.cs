
namespace Tsubaki.Addons.Process
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tsubaki.ModuleBlocks;
    using Tsubaki.ModuleBlocks.Enums;
    using Tsubaki.ModuleBlocks.Metadata;
    using System.Diagnostics;
    using CommandLine;

    [Module("Process")]
    public class Proc : ModuleBase
    {
        protected override bool ExecuteImpl(string[] args, ref object callback)
        {
            var result = Parser.Default.ParseArguments<Info>(args);
            try
            {
                result.WithParsed(info =>

                {
                    var pinfo = new ProcessStartInfo();
                    pinfo.FileName = info.Exe;
                    pinfo.Arguments = info.Target;
                    pinfo.WindowStyle = ProcessWindowStyle.Hidden;
                    
                    Process.Start(pinfo);

                });
                callback = "success";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            callback = "failure";
            return false;

        }

        public override ModuleScopes Scopes => throw new NotImplementedException();

        private class Info
        {
            [Option('t', "target", Required = true)]
            public string Target { get; private set; }

            [Option('x', "exe", Required = true)]
            public string Exe { get; private set; }
        }
    }
}
