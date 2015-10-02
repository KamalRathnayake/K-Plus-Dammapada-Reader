using DammapadaReader.Model.Domain;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace DammapadaReader.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string chapterName;
        public string ChapterName
        {
            get
            {
                return chapterName;
            }
            set
            {
                chapterName = value;
                OnPropertyChanged("ChapterName");
            }
        }

        public ObservableCollection<Vagga> Vaggas { get; set; }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}