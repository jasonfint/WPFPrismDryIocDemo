using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPModuleA
{
    public class PersonDetailViewModel : BindableBase, INavigationAware
    {
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

        public PersonDetailViewModel()
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var person = navigationContext.Parameters["person"] as Person;
            if (person != null)
                SelectedPerson = person;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            var person = navigationContext.Parameters["person"] as Person;
            if (person != null)
                return SelectedPerson != null && SelectedPerson.LastName == person.LastName;
            else
                return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
