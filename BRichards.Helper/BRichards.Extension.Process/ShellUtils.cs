using System.Runtime.InteropServices;

namespace BRichards.Extension.Process;

/// <summary>
/// 
/// </summary>
public static class ShellUtils
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static string GetShell()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "cmd.exe";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "/bin/zsh";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return "/bin/bash";
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
        {
            return "/bin/sh";
        }

        throw new InvalidOperationException("Unsupported operating system.");
    }
}