using System.Collections.ObjectModel;
using Avalonia.EnvironmentItemsControl.Models;

namespace Avalonia.EnvironmentItemsControl.ViewModels
{
    public class EnvironmentRowViewModel
    {
        public EnvironmentType EnvironmentType { get; }

        public ObservableCollection<Models.Environment> Environments { get; }

        public EnvironmentRowViewModel(EnvironmentType environmentType, ObservableCollection<Models.Environment> environments)
        {
            this.EnvironmentType = environmentType;
            this.Environments = environments;
        }
    }
}
