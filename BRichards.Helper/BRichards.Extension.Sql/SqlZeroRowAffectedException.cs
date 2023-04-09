using System.Runtime.Serialization;

namespace BRichards.Extension.Sql;

/// <summary>
/// 
/// </summary>
public class SqlZeroRowAffectedException : SystemException
{
    /// <summary>
    /// 
    /// </summary>
    public SqlZeroRowAffectedException()
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    public SqlZeroRowAffectedException(string message)
        : base(message)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public SqlZeroRowAffectedException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected SqlZeroRowAffectedException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}