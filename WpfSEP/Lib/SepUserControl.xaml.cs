using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfSEP.Lib
{
    public partial class SepUserControl : UserControl
    {

        public SepUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class SepUserControlGeneric<T> : SepUserControl
    {
        public List<T> Datas { get; set; }
        public ObservableCollection<T> ObservableCollection { get; set; } = new ObservableCollection<T>();

        public SepUserControlGeneric()
        {
            DataGrid.ItemsSource = ObservableCollection;
        }

        public void SetupData(List<T> source)
        {
            Datas = source;
            foreach (var data in Datas)
            {
                ObservableCollection.Add(data);
            }
        }
    }
}