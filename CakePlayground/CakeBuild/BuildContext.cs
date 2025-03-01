using CakeBuild.Extensions;
using Cake.Common.Tools.DotNet.Restore;
using Cake.Core;
using Cake.Frosting;

namespace CakeBuild;

public record DotNetParameters
{
    public string Configuration { get; }
    public string ProjectPath { get; }
    
    public DotNetParameters(ICakeArguments arguments)
    {
        Configuration = arguments.GetArgumentWithAliases(nameof(Configuration), "c") ?? "Release";
        ProjectPath = arguments.GetArgumentWithAliases(nameof(ProjectPath), "p");
    }
}

public record DockerParameters
{
    public string DockerfilePath { get; }
    public string ImageTag { get; }
    
    public DockerParameters(ICakeArguments arguments)
    {
        DockerfilePath = arguments.GetArgumentWithAliases(nameof(DockerfilePath), "d");
        ImageTag = arguments.GetArgumentWithAliases(nameof(ImageTag), "i");
    }
}

public class BuildContext(ICakeContext context) : FrostingContext(context)
{
    public DotNetParameters DotNetParams { get; } = new(context.Arguments);
    public DockerParameters DockerParams { get; } = new(context.Arguments);
}