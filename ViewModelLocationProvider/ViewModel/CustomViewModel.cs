using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLocationProvider.ViewModel
{
    class CustomViewModel : BindableBase
    {
        public CustomViewModel()
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
