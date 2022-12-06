using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TestApp.Models;

namespace TestApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Customer currentCustomer;

        public Customer CurrentCustomer
        {
            get
            {
                return currentCustomer;
            }
            set
            {
                currentCustomer = value;
            }
        }

        private ObservableCollection<IsFruitOrVegetable> itemsList;

        public ObservableCollection<IsFruitOrVegetable> ItemsList
        {
            get
            {
                return itemsList;
            }
            set
            {
                itemsList = value;
            }
        }

        private ObservableCollection<Item> custItems;

        public ObservableCollection<Item> CustItems
        {
            get
            {
                return custItems;
            }
            set
            {
                custItems = value;
            }
        }

        public MainViewModel()
        {
            ItemsList = new ObservableCollection<IsFruitOrVegetable>()
            {
                new Fruit("Apple1"),
                new Fruit("Apple2"),
                new Fruit("Apple3"),
                new Fruit("Apple4"),
                new Fruit("Apple5"),
                new Fruit("Apple6"),
                new Fruit("Apple7"),
                new Fruit("Apple8"),
                new Fruit("Apple9"),
                new Fruit("Apple10"),
                new Fruit("Banana1"),
                new Fruit("Banana2"),
                new Fruit("Banana3"),
                new Fruit("Banana4"),
                new Fruit("Banana5"),
                new Fruit("Banana6"),
                new Fruit("Banana7"),
                new Fruit("Banana8"),
                new Fruit("Banana9"),
                new Fruit("Banana10"),
                new Fruit("Avocado1!"),
                new Fruit("Avocado2!"),
                new Fruit("Avocado3!"),
                new Fruit("Avocado4!"),
                new Fruit("Avocado5!"),
                new Fruit("Avocado6!"),
                new Fruit("Avocado7!"),
                new Fruit("Avocado8!"),
                new Fruit("Avocado9!"),
                new Fruit("Avocado10!"),
                new Fruit("Blueberries=1"),
                new Fruit("Blueberries=2"),
                new Fruit("Blueberries=3"),
                new Fruit("Blueberries=4"),
                new Fruit("Blueberries=5"),
                new Fruit("Blueberries=6"),
                new Fruit("Blueberries=7"),
                new Fruit("Blueberries=8"),
                new Fruit("Blueberries=9"),
                new Fruit("Blueberries=10"),
                new Fruit("Watermelon-1"),
                new Fruit("Watermelon-2"),
                new Fruit("Watermelon-3"),
                new Fruit("Watermelon-4"),
                new Fruit("Watermelon-5"),
                new Fruit("Watermelon-6"),
                new Fruit("Watermelon-7"),
                new Fruit("Watermelon-8"),
                new Fruit("Watermelon-9"),
                new Fruit("Watermelon-10"),

                new Vegetable("Broccoli 1"),
                new Vegetable("Broccoli 2"),
                new Vegetable("Broccoli 3"),
                new Vegetable("Broccoli 4"),
                new Vegetable("Broccoli 5"),
                new Vegetable("Broccoli 6"),
                new Vegetable("Broccoli 7"),
                new Vegetable("Broccoli 8"),
                new Vegetable("Broccoli 9"),
                new Vegetable("Broccoli 10"),
                new Vegetable("Cabbage1"),
                new Vegetable("Cabbage2"),
                new Vegetable("Cabbage3"),
                new Vegetable("Cabbage4"),
                new Vegetable("Cabbage5"),
                new Vegetable("Cabbage6"),
                new Vegetable("Cabbage7"),
                new Vegetable("Cabbage8"),
                new Vegetable("Cabbage9"),
                new Vegetable("Cabbage10"),
                new Vegetable("Carrot1"),
                new Vegetable("Carrot2"),
                new Vegetable("Carrot3"),
                new Vegetable("Carrot4"),
                new Vegetable("Carrot5"),
                new Vegetable("Carrot6"),
                new Vegetable("Carrot7"),
                new Vegetable("Carrot8"),
                new Vegetable("Carrot9"),
                new Vegetable("Carrot10"),
                new Vegetable("Cauliflower1"),
                new Vegetable("Cauliflower2"),
                new Vegetable("Cauliflower3"),
                new Vegetable("Cauliflower4"),
                new Vegetable("Cauliflower5"),
                new Vegetable("Cauliflower6"),
                new Vegetable("Cauliflower7"),
                new Vegetable("Cauliflower8"),
                new Vegetable("Potato1"),
                new Vegetable("Potato2"),
                new Vegetable("Potato3"),
                new Vegetable("Potato4"),
                new Vegetable("Potato5"),
                new Vegetable("Potato6"),
                new Vegetable("Potato7"),
                new Vegetable("Cucumber8"),
                new Vegetable("Kale1111"),
                new Vegetable("Bellpepper1--11")
            };

            CurrentCustomer = new Customer("BoB");
            CurrentCustomer.Items.Add(new Item(ItemsList[0], 2));
            CurrentCustomer.Items.Add(new Item(ItemsList[1], 5));
            CurrentCustomer.Items.Add(new Item(ItemsList[2], 1));

            CustItems = CurrentCustomer.Items;

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
