using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BRichards.Extension.MVVM;

/// <summary>
/// 
/// </summary>
public class ViewModelBase : INotifyPropertyChanged
{
    /*
     * Usage:
     *  private string name;
     *  public string Name
     *  {
     *      get => name;
     *      set => SetField(ref name, value);
     *  }
     */

    /// <summary>
    /// 
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyName"></param>
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="field"></param>
    /// <param name="value"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    public virtual void Dispose() { }
}