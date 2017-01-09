using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace verbs2mvvm
{
    class viewmodel : INotifyPropertyChanged
    {
        private model selectedVerb;

        public ObservableCollection<model> Verbs { get; set; }
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      model verb = new model();
                      Verbs.Insert(0, verb);
                      SelectedVerb = verb;

                      //



                      XDocument xdoc = new XDocument();
                      // создаем первый элемент
                      XElement newverb = new XElement("verb");
                      // создаем атрибут
                      XElement verb1 = new XElement("verb1", verb.Verb1);
                      XElement verb2 = new XElement("verb2", verb.Verb2);
                      XElement verb3 = new XElement("verb3", verb.Verb3);
                      // добавляем атрибут и элементы в первый элемент
                      newverb.Add(verb1);
                      newverb.Add(verb2);
                      newverb.Add(verb3);
                      // создаем корневой элемент
                      XElement verbs = new XElement("verbs");
                      // добавляем в корневой элемент
                      verbs.Add(newverb);
                      // добавляем корневой элемент в документ
                      xdoc.Add(verbs);
                      //сохраняем документ
                      xdoc.Save("verbs.xml");
                  })
                  );
            }
        }
        public model SelectedVerb
        {
            get { return selectedVerb; }
            set
            {
                selectedVerb = value;
                OnPropertyChanged("SelectedVerb");
            }
        }

        public viewmodel()
        {
            Verbs = new ObservableCollection<model>(
                File.ReadLines(@"C:\Users\Рустем\Desktop\проекты\Verbs2\Verbs2\verbs.txt", System.Text.Encoding.GetEncoding(1251))
                .Select(x => x.Split('.'))
                .Select(x => new model { Verb1=x[0], Verb2=x[1],Verb3=x[2]}));
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
