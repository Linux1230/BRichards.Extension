namespace BRichards.Extension.Files;

/// <summary>
/// 
/// </summary>
public static class FileOperationExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static List<string> ReadFile(string name) =>
        File.ReadAllLines(name).ToList();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <param name="name"></param>
    public static void WriteFile(this IEnumerable<string> file, string name) =>
        File.WriteAllLines(name, file);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public static void DeleteFile(string name) =>
        File.Delete(name);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static List<string> ReadAndDeleteFile(string name)
    {
        var temp = ReadFile(name);
        DeleteFile(name);
        return temp;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static List<string?> GetFileNamesFromFolder(string path)
    {
        var skipDirectory = path.Length;
        if (!path.EndsWith(Path.DirectorySeparatorChar))
        {
            skipDirectory++;
        }

        return Directory.EnumerateFiles(path,
                                        "*",
                                        SearchOption.AllDirectories)
                        .Select(f => 
                            skipDirectory >= 0 
                            && skipDirectory <= f.Length
                                ? f[skipDirectory..]
                                : null
                        )!
                        .ToList();
    }
}
