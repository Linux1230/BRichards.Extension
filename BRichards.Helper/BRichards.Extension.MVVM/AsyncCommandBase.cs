namespace BRichards.Extension.MVVM;

/// <summary>
/// 
/// </summary>
public abstract class AsyncCommandBase : CommandBase
{
    private bool _isExecuting;
    private bool IsExecuting
    {
        get => _isExecuting;
        set
        {
            _isExecuting = value;
            OnCanExecutedChanged();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public override bool CanExecute(object? parameter) =>
        !IsExecuting && base.CanExecute(parameter);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    public override async void Execute(object? parameter)
    {
        IsExecuting = true;

        try
        {
            if (parameter is null)
                return;

            await ExecuteAsync(parameter);
        }
        finally
        {
            IsExecuting = false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public abstract Task ExecuteAsync(object? parameter);
}
