using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonData data;
        public MainWindow()
        {
            InitializeComponent();

            data = new PersonData("https://localhost:7036");
        }

        private void btnCallSync_Click(object sender, RoutedEventArgs e)
        {
            var people = data.GetAll();
            txbInfo.Text = people.Count.ToString(); 
        }

        private async void btnCallAsync_Click(object sender, RoutedEventArgs e)
        {
            var people = await data.GetAllAsync();
            txbInfo.Text = people.Count.ToString();

        }

        private async void btnCallProgress_Click(object sender, RoutedEventArgs e)
        {
            IProgress<int> progress = new Progress<int>(percent =>
            {
                progress1.Value = percent;
                txbInfo.Text = $"{percent}%";
            });

            await DownloadWithProgress(progress);

            txbInfo.Text += " HOTOVO";
        }

        private async Task DownloadWithProgress(IProgress<int> progress)
        {
            int totalItems = await data.GetPeopleCountAsync();
            int chunk = 100;
            int totalRequests = totalItems / chunk;

            for (int i = 0; i <= totalRequests; i++)
            {
                var newdata = await data.GetRangeAsync(i * chunk, chunk);
                var proc = i * 100 / totalRequests;
                progress.Report(proc);
            }
        }
    }
}