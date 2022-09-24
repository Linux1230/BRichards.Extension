namespace BRichards.Helper.FileUtils;

public static class FileUtils
{
    public static List<string> ReadFile(string name) => 
        File.ReadAllLines(name).ToList();

    public static void WriteFile(string name, IEnumerable<string> file) => 
        File.WriteAllLines(name, file);

    public static void DeleteFile(string name) => 
        File.Delete(name);

    public static List<string> ReadAndDeleteFile(string name)
    {
        var temp = ReadFile(name);
        DeleteFile(name);
        return temp;
    }

    public static List<string> GetFileNamesFromFolder(string path)
    {
        var skipDirectory = path.Length;
        if (!path.EndsWith(Path.DirectorySeparatorChar))
        { 
            skipDirectory++;
        }

        return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
            .Select(f =>
            {
                if (skipDirectory >= 0 && skipDirectory <= f.Length)
                {
                    return f[skipDirectory..];
                }

                return null;
            })!.ToList<string>();
    }
}
