using HotelWpfApp.Models;
using HotelWpfApp.PagesEdit;
using Microsoft.EntityFrameworkCore;
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

namespace HotelWpfApp.DataPages
{
    /// <summary>
    /// Логика взаимодействия для RoomsPage.xaml
    /// </summary>
    public partial class RoomsPage : Page
    {
        public RoomsPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void AddRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoomEdit(-1));
        }

        private void EditRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = RoomsGrid.SelectedItem as Room;
            if (selectedRoom != null)
            {

            }
            else
            {
                MessageBox.Show("Выберите номер", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void DeleteRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = RoomsGrid.SelectedItem as Room;

            if (selectedRoom != null)
            {
                MessageBox.Show("Удалить?", "Удаление", MessageBoxButton.YesNo);
            }
            else
            {
                MessageBox.Show("Выберите номер", "Ошибка", MessageBoxButton.OK);
            }
        }

        void LoadData()
        {
            Db.Rooms.Load();
            Db.Bookings.Load();
            Db.Hotels.Load();
            Db.Categories.Load();
            RoomsGrid.ItemsSource = Db.Rooms.ToList();
        }
    }
}
