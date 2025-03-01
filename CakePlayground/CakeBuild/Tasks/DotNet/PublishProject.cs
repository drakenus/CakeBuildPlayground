using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Publish;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace CakeBuild.Tasks.DotNet;

[TaskName("Publish")]
[TaskDescription("Publishes project")]
[IsDependentOn(typeof(BuildProject))]
[IsDependentOn(typeof(RunTests))]
public class PublishProject : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Publishing project with parameters {0}", context.DotNetParams);
        context.DotNetPublish(context.DotNetParams.ProjectPath, new DotNetPublishSettings
        {
            Configuration = context.DotNetParams.Configuration,
            NoRestore = true,
            NoBuild = true
        });
    }
}