using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfSEP.Lib
{
    public class Student {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class BaseSep: Window
    {
        protected BaseSep() : base()
        {
        }
    }

    public class BaseSepGeneric<T> : BaseSep
    {
        public SepUserControlGeneric<T> SepUserControl = new SepUserControlGeneric<T>();
        public List<T> Datas { get; set; } = new List<T>();

        protected void SetupData(IEnumerable<T> sourceData)
        {
            this.Datas = sourceData.ToList();
            this.SepUserControl.SetupData(this.Datas);
        }
        
        public BaseSepGeneric()
        {
            
        }
        
    }
}