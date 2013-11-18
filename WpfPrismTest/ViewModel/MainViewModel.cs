using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Commands;
using WpfPrismTest.Base;
using WpfPrismTest.Model;

namespace WpfPrismTest.ViewModel
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
            TodoItems = new ObservableCollection<ItemTodo>();
            AddCommand = new DelegateCommand(OnAddExecute, OnAddCanExecute);
        }

        private bool OnAddCanExecute()
        {
            return !string.IsNullOrWhiteSpace(NewItemText);
        }

        private void OnAddExecute()
        {
            TodoItems.Add(new ItemTodo{ Name="New", Title = NewItemText});
            NewItemText = "";
        }

        private string _newItemText ;

        public DelegateCommand AddCommand { get; private set; }

        public void Load()
        {
            TodoItems.Add(new ItemTodo { Title = "Hello", Name = "Jan"});
            TodoItems.Add(new ItemTodo { Title = "Tom", Name = "Rim" });
        }

        public ObservableCollection<ItemTodo> TodoItems { get; private set; }

        public string NewItemText
        {
            get { return _newItemText; }
            set
            {
                _newItemText = value;
                OnPropertyChanged("NewItemText");
                AddCommand.RaiseCanExecuteChanged();
            }
        }
    }
}
