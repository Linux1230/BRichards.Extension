using Microsoft.Extensions.Configuration;

namespace BRichards.Extension.Configuration;

/// <summary>
/// Defines a writable option, which can be used to update a value in a configuration file.
/// </summary>
public interface IWritableOption<T>
{
    /// <summary>
    /// Gets the current value of the option.
    /// </summary>
    T Value { get; }

    /// <summary>
    /// Sets the value of the option.
    /// </summary>
    /// <param name="value">The new value to set.</param>
    void SetValue(T value);
}

/// <summary>
/// A writable option, which can be used to update a value in a configuration file.
/// </summary>
public class WritableOption<T> : IWritableOption<T>
{
    private readonly IConfiguration _configuration;
    private readonly string _key;
    private readonly T _defaultValue;

    /// <summary>
    /// Creates a new instance of the <see cref="WritableOption{T}"/> class.
    /// </summary>
    /// <param name="configuration">The configuration instance to update.</param>
    /// <param name="key">The key of the option.</param>
    /// <param name="defaultValue">The default value of the option.</param>
    public WritableOption(IConfiguration configuration, string key, T defaultValue)
    {
        _configuration = configuration;
        _key = key;
        _defaultValue = defaultValue;
    }

    /// <inheritdoc />
    public T Value => _configuration.GetValue(_key, _defaultValue);

    /// <inheritdoc />
    public void SetValue(T value)
    {
        _configuration[_key] = value?.ToString();
    }
}

/// <summary>
/// A factory which can be used to create instances of <see cref="IWritableOption{T}"/>.
/// </summary>
public static class WritableOptionFactory
{

}