using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridStyle
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<People> Names { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Names = new ObservableCollection<People>
        {
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
            new People(){FirstName = "Name", LastName="Alba", Age= "123", Nationality="Korea", Club ="Club"},
        };

            LoadData();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void LoadData()
        {
            MyGrid.ItemsSource = Names;
        }
    }


    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Nationality { get; set; }
        public string Club { get; set; }
    }
}
