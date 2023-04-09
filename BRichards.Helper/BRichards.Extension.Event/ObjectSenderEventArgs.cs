namespace BRichards.Extension.Event;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class ObjectSenderEventArgs<T> : EventArgs
{
    /// <summary>
    /// 
    /// </summary>
    public T SentObject { get; protected set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    public ObjectSenderEventArgs(T item)
    {
        SentObject = item;
    }
}