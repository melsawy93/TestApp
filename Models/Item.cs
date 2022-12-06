using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Item : INotifyPropertyChanged
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

        private IsFruitOrVegetable fruitorvegie;

        public IsFruitOrVegetable FruitorVegie
        {
            get
            {
                return fruitorvegie;
            }
            set
            {
                fruitorvegie = value;
                RaisePropertyChanged("FruitorVegie");
            }
        }

        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        public Item(IsFruitOrVegetable _fruitorvegie, int _quantity)
        {
            Name = _fruitorvegie.Name;
            FruitorVegie = _fruitorvegie;
            Quantity = _quantity;
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
