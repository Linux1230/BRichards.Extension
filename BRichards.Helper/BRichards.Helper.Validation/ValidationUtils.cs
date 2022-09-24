namespace BRichards.Helper.Validation;

public static class ValidationUtils
{
    public static IEnumerable<TSource?> EmptyIfNull<TSource>(this IEnumerable<TSource?>? source) =>
        source ?? Enumerable.Empty<TSource?>();

    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? @this) =>
        @this?.Any() ?? false;

    public static T2? DoIfNotNull<T1, T2>(this T1 @this,
                                          Func<T1, T2> func) =>
        !EqualityComparer<T1>.Default.Equals(@this, default) 
            ? func(@this) 
            : default;

    public static bool Validate<T>(this T @this,
                                   params Func<T, bool>[] predicates) =>
        predicates.All(x => x(@this));
}
