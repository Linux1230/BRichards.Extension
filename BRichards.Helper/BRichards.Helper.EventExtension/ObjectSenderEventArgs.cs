﻿namespace BRichards.Helper.EventExtension;

public class ObjectSenderEventArgs<T> : EventArgs
{
    public T SentObject { get; protected set; }

    public ObjectSenderEventArgs(T item)
    {
        SentObject = item;
    }
}