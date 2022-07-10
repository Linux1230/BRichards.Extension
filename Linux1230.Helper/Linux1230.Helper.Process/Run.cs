namespace Linux1230.Helper.ProcessUtils;

public class Run
{
    public static void BatchScript(string filename)
    {
        System.Diagnostics.Process.Start($@"{filename}");
    }
}