using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLocatorChangeConvention
{
    public class MainWindowViewmodel : BindableBase
    {
        public MainWindowViewmodel()
        {

        }
        private string _title = "Prism DryIOC Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


    }
}
