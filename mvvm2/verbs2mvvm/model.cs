using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace verbs2mvvm
{
    class model : INotifyPropertyChanged
    {
        private string verb1;
        private string verb2;
        private string verb3;

        public string Verb1
        {
            get { return verb1; }
            set
            {
                verb1 = value;
                OnPropertyChanged("Title");
            }
        }
        public string Verb2
        {
            get { return verb2; }
            set
            {
                verb2 = value;
                OnPropertyChanged("Company");
            }
        }
        public string Verb3
        {
            get { return verb3; }
            set
            {
                verb3 = value;
                OnPropertyChanged("Price");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
