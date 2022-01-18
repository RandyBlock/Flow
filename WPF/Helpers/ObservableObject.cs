using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Helpers
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }

        }
        [Conditional("Debug")]

        [DebuggerStepThrough]

        public virtual void VerifyPropertyName(string propertyName)
        {
            if(TypeDescriptor.GetProperties(this) [propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;
                if (this.ThrowOnValidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }

        }
        protected virtual bool ThrowOnValidPropertyName { get; private set; }
    }
}
