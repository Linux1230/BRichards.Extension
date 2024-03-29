﻿using System.Runtime.Serialization;

namespace BRichards.Helper.SqlExtension;

public class SqlZeroRowAffectedException : SystemException
{
    public SqlZeroRowAffectedException()
    {
    }

    public SqlZeroRowAffectedException(string message)
        : base(message)
    {
    }

    public SqlZeroRowAffectedException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected SqlZeroRowAffectedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}