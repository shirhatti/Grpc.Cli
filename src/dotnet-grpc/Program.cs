using Microsoft.Build.Evaluation;
using Microsoft.DotNet.Cli.Utils;
using Microsoft.DotNet.Tools;
using System;
using System.Linq;

namespace Grpc.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var projects = new ProjectCollection();
            MsbuildProject msbuildProj = MsbuildProject.FromFileOrDirectory(projects, @"D:\cli\src\dotnet\dotnet.csproj", true);
            foreach (var tfm in msbuildProj.GetTargetFrameworks())
            {
                Console.WriteLine(tfm.GetShortFolderName());
            }
        }
    }
}
