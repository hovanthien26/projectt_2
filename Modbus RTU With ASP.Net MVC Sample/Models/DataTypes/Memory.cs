using System;
using System.ComponentModel;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample.Models.Cores
{
    public class Memory : IComparable<Memory>, INotifyPropertyChanged   
    {
        private ushort _Address;
        private ushort _Value;

        public ushort Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public ushort Value
        {
            get { return _Value; }
            set
            {
                if (_Value == value) return;
                _Value = value;
                OnPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        public int CompareTo(Memory obj)
        {
            return this.Address.CompareTo(obj.Address);
        }
    }
}
