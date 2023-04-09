using BRichards.Extension.Dictionary;

namespace BRichards.Extension.Dictionary;

/// <summary>
/// 
/// </summary>
public static class ToDictionaryUtils
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static IDictionary<TK, TV> ToDictionary<TK, TV>(this IEnumerable<(TK, TV)> @this) =>
        @this.ToDictionary(x => x.Item1, x => x.Item2);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static IDictionary<TK, TV> ToDictionary<TK, TV>(this IEnumerable<KeyValuePair<TK, TV>> @this) =>
        @this.ToDictionary(x => x.Key, x => x.Value);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static IDictionary<TK, int> ToCountDictionary<TK>(this IEnumerable<TK> @this) =>
        @this.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
}
