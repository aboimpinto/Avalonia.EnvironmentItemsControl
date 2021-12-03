namespace Avalonia.EnvironmentItemsControl.Models
{
    public class Environment
    {
        public string Name { get; }

        public string Address { get; }

        public Environment(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
