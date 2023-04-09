namespace BRichards.Extension.Linq;

/// <summary>
/// 
/// </summary>
public static class MonadBuilder
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    /// <param name="this"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static TOutput Map<TInput, TOutput>(this TInput @this,
                                               Func<TInput, TOutput> func) =>
        func(@this);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="this"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static T Tee<T>(this T @this, Action<T> action)
    {
        action(@this);
        return @this;
    }
}
