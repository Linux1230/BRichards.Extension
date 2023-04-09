namespace BRichards.Extension.Dictionary;

/// <summary>
/// 
/// </summary>
public static class ToLookupDictionary
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="this"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public static Func<TK, TV> ToLookupWithDefault<TK, TV>(this IDictionary<TK, TV> @this,
                                                           TV defaultValue) =>
        x => @this.ContainsKey(x)
            ? @this[x]
            : defaultValue;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static Func<TK, TV> ToLookupWithDefault<TK, TV>(this IDictionary<TK, TV> @this) =>
        x => @this.ContainsKey(x)
            ? @this[x]
            : default;
}
