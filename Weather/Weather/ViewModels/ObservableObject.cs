using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Weather.ViewModels
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        protected bool SetValue<T>(ref T storage, T value, [CallerMemberName] string prop = "")
        {

            if (storage != null && storage.Equals(value)) return false;

            storage = value;
            OnPropertyChanged(prop);
            return true;
        }
    }
}
