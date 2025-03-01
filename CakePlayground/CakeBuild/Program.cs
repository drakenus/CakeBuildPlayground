using Cake.Frosting;

namespace CakeBuild;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .UseWorkingDirectory("../..")
            .Run(args);
    }
}
