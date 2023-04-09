namespace BRichards.Extension.Validation;

/// <summary>
/// 
/// </summary>
public static class ValidationUtils
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IEnumerable<TSource?> EmptyIfNull<TSource>(this IEnumerable<TSource?>? source) =>
        source ?? Enumerable.Empty<TSource?>();

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="this"></param>
    /// <returns></returns>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? @this) =>
        @this?.Any() ?? false;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="this"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static T2? DoIfNotNull<T1, T2>(this T1 @this,
                                          Func<T1, T2> func) =>
        !EqualityComparer<T1>.Default.Equals(@this, default)
            ? func(@this)
            : default;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="this"></param>
    /// <param name="predicates"></param>
    /// <returns></returns>
    public static bool Validate<T>(this T @this,
                                   params Func<T, bool>[] predicates) =>
        predicates.All(x => x(@this));
}
