using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace CakeBuild.Tasks.DotNet;

[TaskName("Build")]
[TaskDescription("Builds project")]
[IsDependentOn(typeof(RestoreProject))]
public class BuildProject : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Building project with parameters {0}", context.DotNetParams);
        context.DotNetBuild(context.DotNetParams.ProjectPath, new DotNetBuildSettings
        {
            Configuration = context.DotNetParams.Configuration,
            NoRestore = true
        });
    }
}