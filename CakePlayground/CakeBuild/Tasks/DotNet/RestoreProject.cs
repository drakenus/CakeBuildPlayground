using Cake.Common.Tools.DotNet;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace CakeBuild.Tasks.DotNet;

[TaskName("Restore")]
[TaskDescription("Restores project")]
public class RestoreProject : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Restoring project with parameters {0}", context.DotNetParams);
        context.DotNetRestore(context.DotNetParams.ProjectPath);
    }
}