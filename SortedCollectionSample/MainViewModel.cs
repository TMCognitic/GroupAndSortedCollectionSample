using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SortedCollectionSample
{
    public class MainViewModel : ObservableObject
    {
        private int _value;
        private string? _text;

        private ICommand? _addCommand;

        private ObservableCollection<DataViewModel>? _items;

        public ObservableCollection<DataViewModel> Items
        {
            get
            {
                return _items ??= new ObservableCollection<DataViewModel>();
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                SetProperty(ref _value, value);
            }
        }

        public string? Text
        {
            get
            {
                return _text;
            }

            set
            {
                SetProperty(ref _text, value);
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return _addCommand ??= new RelayCommand(() => Items.Add(new DataViewModel(Text!, Value)), () => Text is not null);
            }
        }

        public MainViewModel()
        {
            Items.Add(new DataViewModel("Toto", 1));
            Items.Add(new DataViewModel("Ben", 1));
            Items.Add(new DataViewModel("Alphonse", 2));
        }

        
    }
}
