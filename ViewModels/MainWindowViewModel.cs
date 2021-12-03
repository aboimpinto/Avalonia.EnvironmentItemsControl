using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Avalonia.EnvironmentItemsControl.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<EnvironmentRowViewModel> Envionments { get; }

        public MainWindowViewModel()
        {
            IEnumerable<Models.Environment> hyperVEnvironments = new List<Models.Environment>
            {
                new Models.Environment("BRUTICUS", ""),
                new Models.Environment("DEFENSOR", ""),
                new Models.Environment("DEVASTATOR", ""),
                new Models.Environment("SUPERION", "")
            };
            var hyperVRowViewModel = new EnvironmentRowViewModel(
                Models.EnvironmentType.HyperV, 
                new ObservableCollection<Models.Environment>(hyperVEnvironments));

            IEnumerable<Models.Environment> bruticusEnvironments = new List<Models.Environment>
            {
                new Models.Environment("Bluestrak", "192.168.1.1"),
                new Models.Environment("Bumblebee", "192.168.1.2"),
            };
            var bruticusRowViewModel = new EnvironmentRowViewModel(
                Models.EnvironmentType.Bruticus,
                new ObservableCollection<Models.Environment>(bruticusEnvironments)
            );

            IEnumerable<Models.Environment> defensorEnvironments = new List<Models.Environment>
            {
                new Models.Environment("Astrotrain", "192.168.1.3"),
                new Models.Environment("Broadside", "192.168.1.4"),
            };
            var defensorRowViewModel = new EnvironmentRowViewModel(
                Models.EnvironmentType.Defensor,
                new ObservableCollection<Models.Environment>(defensorEnvironments)
            );

            this.Envionments = new ObservableCollection<EnvironmentRowViewModel>(
                new List<EnvironmentRowViewModel>
                {
                    hyperVRowViewModel,
                    bruticusRowViewModel,
                    defensorRowViewModel
                }
            );
        }
    }
}
