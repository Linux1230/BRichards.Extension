namespace BRichards.Helper.MVVM;

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

    public override bool CanExecute(object? parameter) => 
        !IsExecuting && base.CanExecute(parameter);

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

    public abstract Task ExecuteAsync(object? parameter);
}
