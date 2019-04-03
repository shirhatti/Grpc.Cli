using Microsoft.Build.Evaluation;
using Grpc.Cli.Utils;
using Microsoft.DotNet.Tools;
using System;
using System.Linq;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.Build.Logging;
using Microsoft.Build.Framework;
using System.IO;

namespace Grpc.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            SetMsBuildExePath();
            var collection = new ProjectCollection();
            collection.RegisterLogger(new ConsoleLogger(LoggerVerbosity.Minimal));

            collection.LoadProject(@"D:\temp\sample\sample.csproj");
        }

        private static void SetMsBuildExePath()
        {
            var dotnetSdkVersion = "2.2.100";
            var extensionsPath = $@"C:\Program Files\dotnet\sdk\{dotnetSdkVersion}";
            var msbuildSdkPath = $@"{extensionsPath}\Sdks";
            Environment.SetEnvironmentVariable("VisualStudioVersion", "15.0");
            Environment.SetEnvironmentVariable("MSBuildExtensionsPath", extensionsPath);
            Environment.SetEnvironmentVariable("MSBuildSDKsPath", msbuildSdkPath);
            Environment.SetEnvironmentVariable("VSINSTALLDIR", @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\");
        }
    }
}
