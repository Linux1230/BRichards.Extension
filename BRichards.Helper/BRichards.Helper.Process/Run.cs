﻿namespace BRichards.Helper.ProcessExtension;

public class Run
{
    public static void BatchScript(string filename) => 
        System.Diagnostics.Process.Start($@"{filename}");
}