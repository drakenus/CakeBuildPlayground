using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Frosting;
using CakeBuild.Tasks.Docker;
using CakeBuild.Tasks.DotNet;

namespace CakeBuild.Tasks;

[TaskName("Default")]
[IsDependentOn(typeof(PublishProject))]
[IsDependentOn(typeof(DockerBuild))]
public class DefaultTask : FrostingTask
{
    public override void Run(ICakeContext context)
    {
        context.Log.Information("Default task executed");
    }
}