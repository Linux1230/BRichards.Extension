using System.Runtime.Serialization;

namespace BRichards.Extension.Sql;

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