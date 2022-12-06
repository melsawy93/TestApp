using System.ComponentModel;

namespace TestApp.Models
{
    public class Fruit : IsFruitOrVegetable, INotifyPropertyChanged
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

        public FoodType Type { get; set; }

        public Fruit()
        {
            this.Type = FoodType.Fruit;
        }

        public Fruit(string _Name)
        {
            this.Name = _Name;
            this.Type = FoodType.Fruit;
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
