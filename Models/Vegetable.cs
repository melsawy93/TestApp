using System.ComponentModel;

namespace TestApp.Models
{
    public class Vegetable : IsFruitOrVegetable, INotifyPropertyChanged
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

        public Vegetable()
        {

            this.Type = FoodType.Vegetable;
        }

        public Vegetable(string _Name)
        {
            this.Name = _Name;
            this.Type = FoodType.Vegetable;
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
