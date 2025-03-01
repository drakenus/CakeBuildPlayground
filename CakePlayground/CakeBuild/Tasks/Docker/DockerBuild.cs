using System.IO;
using Cake.Core.Diagnostics;
using Cake.Docker;
using Cake.Frosting;

namespace CakeBuild.Tasks.Docker;

public class DockerBuild : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information($"Building image {context.DockerParams.ImageTag} from {context.DockerParams.DockerfilePath}");
        context.DockerBuild(new DockerImageBuildSettings
        {
            Pull = true,
            Tag = [context.DockerParams.ImageTag],
            File = context.DockerParams.DockerfilePath
        }, Path.GetDirectoryName(context.DockerParams.DockerfilePath));
    }
}