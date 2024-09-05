using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    internal class ApplicationViewModel : INotifyPropertyChanged
    {
        private Client selectedClient;

        public ObservableCollection<Client> Clients { get; set; }
        public Client SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        public ApplicationViewModel()
        {
            Clients = new ObservableCollection<Client>
            {
                new Client("Попов", "Игорь", "Федорович", "+79453546678", "4017 206555"),
                new Client("Иванов", "Николай", "Юрьевич", "+79523446768", "4018 543446"),
                new Client("Морозов", "Михаил", "Александрович", "+79544446709", "4018 347898"),
                new Client("Смирнов", "Алексей", "Михайлович", "+79346678467", "4019 359878")
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
