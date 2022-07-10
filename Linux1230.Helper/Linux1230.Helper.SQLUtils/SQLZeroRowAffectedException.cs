using System.Runtime.Serialization;

namespace Linux1230.Helper.SQLUtils;

public class SQLZeroRowAffectedException : SystemException
{
    public SQLZeroRowAffectedException()
        : base()
    {
    }

    public SQLZeroRowAffectedException(string message)
        : base(message)
    {
    }

    public SQLZeroRowAffectedException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected SQLZeroRowAffectedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}