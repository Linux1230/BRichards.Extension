using System.Windows.Input;

namespace BRichards.Helper.MVVM;

public abstract class CommandBase : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public virtual bool CanExecute(object? parameter) => true;

    public abstract void Execute(object? parameter);

    protected void OnCanExecutedChanged() => 
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
