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
    /// Логика взаимодействия для DataHotel.xaml
    /// </summary>
    public partial class DataHotel : Page
    {
        public DataHotel()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Db.Regions.Load();
            Db.Hotels.Load();
            HotelGrid.ItemsSource = Db.Hotels.ToList();
        }

        private void AddHotelBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditHotel(-1));
        }

        private void EditHotelBtn_Click(object sender, RoutedEventArgs e)
        {
            var selected_hotel = HotelGrid.SelectedItem as Hotel;

            if (selected_hotel != null)
            {
                NavigationService.Navigate(new EditHotel(selected_hotel.Id));
            }
            else
            {
                MessageBox.Show("Выберите отель", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteHotelBtn_Click(object sender, RoutedEventArgs e)
        {
            var selected_hotel = HotelGrid.SelectedItem as Hotel;

            if (selected_hotel != null)
            {
                if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Db.Hotels.Remove(selected_hotel);
                    Db.SaveChanges();
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите отель", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
