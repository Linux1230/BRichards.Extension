using System.Windows.Input;

namespace BRichards.Extension.MVVM;

/// <summary>
/// 
/// </summary>
public abstract class CommandBase : ICommand
{
    /// <summary>
    /// 
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public virtual bool CanExecute(object? parameter) => true;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    public abstract void Execute(object? parameter);

    /// <summary>
    /// 
    /// </summary>
    protected void OnCanExecutedChanged() =>
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
