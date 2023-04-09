namespace BRichards.Extension.Process;

/// <summary>
/// 
/// </summary>
public class Run
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filename"></param>
    public static void BatchScript(string filename) =>
        System.Diagnostics.Process.Start($@"{filename}");
}