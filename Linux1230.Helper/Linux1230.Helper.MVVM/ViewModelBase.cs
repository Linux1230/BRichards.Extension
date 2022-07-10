using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Linux1230.Helper.MVVM;

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

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) => 
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) 
            return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    public virtual void Dispose() { }
}