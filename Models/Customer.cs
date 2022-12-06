using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using TestApp.ViewModel;

namespace TestApp.Models
{
    public class Customer : INotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        private ObservableCollection<Item> items;

        public ObservableCollection<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                RaisePropertyChanged("Items");
            }
        }


        private int totalQuantity;

        public int TotalQuantity
        {
            get
            {
                return totalQuantity;
            }
            set
            {
                totalQuantity = value;
                RaisePropertyChanged("TotalQuantity");
            }
        }

        public Customer()
        {

        }

        public Customer(string _Name)
        {
            this.Name = _Name;
            Items = new ObservableCollection<Item>();
            TotalQuantity = 1;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            var property = PropertyChanged;
            if (property != null)
                property(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
