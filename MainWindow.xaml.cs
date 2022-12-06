using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestApp.ViewModel;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _vm;
        public MainWindow()
        {
            SelectedFruitsOrVegie = new ObservableCollection<IsFruitOrVegetable>();
            InitializeComponent();
            _vm = (MainViewModel)DataContext;
        }

        private ObservableCollection<IsFruitOrVegetable> _selectedFruitsOrVegie;
        public ObservableCollection<IsFruitOrVegetable> SelectedFruitsOrVegie
        {
            get { return _selectedFruitsOrVegie; }
            set { _selectedFruitsOrVegie = value; }
        }
        private void ListViewLCombos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedFruitsOrVegie.Clear();

            System.Collections.IList items = ((System.Windows.Controls.ListView)sender).SelectedItems;
            var SelectedItemsArr = items.Cast<IsFruitOrVegetable>();

            foreach (object SelectedItem in SelectedItemsArr)
            {
                SelectedFruitsOrVegie.Add((IsFruitOrVegetable)SelectedItem);
            }
        }

        private void Buttonn_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            foreach (object fruitorvegie in SelectedFruitsOrVegie)
            {
                _vm.CurrentCustomer.Items.Add(new Models.Item((IsFruitOrVegetable)fruitorvegie, 1));
            }
        }
    }
}
