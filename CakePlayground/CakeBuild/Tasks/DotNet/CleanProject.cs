using Cake.Common.Tools.DotNet;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace CakeBuild.Tasks.DotNet;

[TaskName("CleanProject")]
[TaskDescription("Cleans project")]
public class CleanProject : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Cleaning project with parameters {0}", context.DotNetParams);
        context.DotNetClean(context.DotNetParams.ProjectPath);
    }
}