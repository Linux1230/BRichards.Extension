namespace BRichards.Helper.LinqExtension;

public static class MonadBuilder
{
    public static TOutput Map<TInput, TOutput>(this TInput @this,
                                               Func<TInput, TOutput> func) =>
        func(@this);

    public static T Tee<T>(this T @this, Action<T> action)
    {
        action(@this);
        return @this;
    }
}
