namespace BRichards.Extension.Process;

public class Run
{
    public static void BatchScript(string filename) =>
        System.Diagnostics.Process.Start($@"{filename}");
}