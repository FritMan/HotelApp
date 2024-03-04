using System;
using System.Collections.Generic;
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
using static HotelWpfApp.Classes.Helper;

namespace HotelWpfApp.PagesEdit
{
    /// <summary>
    /// Логика взаимодействия для RoomEdit.xaml
    /// </summary>
    public partial class RoomEdit : Page
    {

        private long _id;
        public RoomEdit(int id)
        {
            InitializeComponent();
            _id = id;
            LoadData();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        void LoadData()
        {

        }
    }
}
