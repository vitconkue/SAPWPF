using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfSEP.Lib;

namespace WpfSEP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseSepGeneric<Student>
    {
        public MainWindow(): base()
        {
            InitializeComponent();
        }


        private void Setup()
        {
            List<Student> datas = new List<Student>();
            datas.Add(new Student{Name = "An", Id = "1"});
            datas.Add(new Student{Name = "Hoa", Id = "2"});
            SetupData(datas);
            this.StackPanel.Children.Add(SepUserControl); 
        }


        private void OpenButton_OnClick(object sender, RoutedEventArgs e)
        {
            Setup();
        }
    }
}