using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linux1230.Helper.EventUtils;

public class ObjectSenderEventArgs<T> : EventArgs
{
    public T SentObject { get; private set; }

    public ObjectSenderEventArgs(T item)
    {
        SentObject = item;
    }
}