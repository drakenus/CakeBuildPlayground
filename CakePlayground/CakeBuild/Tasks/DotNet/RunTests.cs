using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Test;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace CakeBuild.Tasks.DotNet;

[IsDependentOn(typeof(BuildProject))]
public class RunTests : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Running tests with parameters {0}", context.DotNetParams);
        context.DotNetTest(context.DotNetParams.ProjectPath, new DotNetTestSettings
        {
            Configuration = context.DotNetParams.Configuration,
            NoRestore = true,
            NoBuild = true
        });
    }
}