using System;
using System.Numerics;
using Cake.Core;

namespace CakeBuild.Extensions;

public static class CakeArgumentsExtensions
{
    public static string? GetArgumentWithAliases(this ICakeArguments arguments, string argumentName,
        params string[] aliases)
    {
        var value = arguments.GetArgument(argumentName);
        if (value != null)
        {
            return value;
        }

        foreach (var alias in aliases)
        {
            value = arguments.GetArgument(alias);
            if (value != null)
            {
                return value;
            }
        }

        return null;
    }
}