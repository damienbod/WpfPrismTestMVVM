using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPrismTest.Base;

namespace WpfPrismTest.Model
{
    public class ItemTodo : Observable
    {
        private string _title;
        private string _name;

        public string Title
        {
            get { return _title; }
            set { _title = value; 
                OnPropertyChanged("Title"); 
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;
            OnPropertyChanged("Name"); 
            }
        }
    }
}
