namespace BRichards.Helper.DictionaryUtils;

public static class ToLookupDictionary
{
    public static Func<TK, TV> ToLookupWithDefault<TK, TV>(this IDictionary<TK, TV> @this,
                                                           TV defaultValue) =>
        x => @this.ContainsKey(x)
            ? @this[x]
            : defaultValue;

    public static Func<TK, TV> ToLookupWithDefault<TK, TV>(this IDictionary<TK, TV> @this) =>
        x => @this.ContainsKey(x)
            ? @this[x]
            : default;
}
