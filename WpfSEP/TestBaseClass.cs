using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfSEP
{
    public class Student {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public partial class TestBaseClass: Window
    {
        public TestBaseClass(): base(){}
    }

    public partial class TestBaseClassGeneric<T> : TestBaseClass
    {
        public List<T> Datas { get; set; }

        private void SetupData(IEnumerable<T> sourceData)
        {
            this.Datas = sourceData.ToList();
        }
        
        public TestBaseClassGeneric(): base()
        {
            
        }
    }
}