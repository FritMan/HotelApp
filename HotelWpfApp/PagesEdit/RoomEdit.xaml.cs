using HotelWpfApp.DataPages;
using HotelWpfApp.Models;
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

namespace HotelWpfApp.PagesEdit
{
    /// <summary>
    /// Логика взаимодействия для RoomEdit.xaml
    /// </summary>
    public partial class RoomEdit : Page
    {

        private long _id;

        public RoomEdit(long id)
        {
            InitializeComponent();
            _id = id;
            LoadData();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {

            if (((CategoryCb.SelectedItem as Category).Id == 2 || (CategoryCb.SelectedItem as Category).Id == 3) && (NumberTb.Text == "1" || NumberTb.Text == "2"))
            {
                var create_room = RoomsGrid.DataContext as Room;

                if (_id == -1)
                {
                    Db.Rooms.Add(create_room);
                }
                Db.SaveChanges();
                NavigationService.Navigate(new RoomsPage());
            }
            else if((CategoryCb.SelectedItem as Category).Id == 1 && (NumberTb.Text == "1" || NumberTb.Text == "2" || NumberTb.Text == "3" || NumberTb.Text == "4"))
            {
                var create_room = RoomsGrid.DataContext as Room;

                if (_id == -1)
                {
                    Db.Rooms.Add(create_room);
                }
                Db.SaveChanges();
                NavigationService.Navigate(new RoomsPage());
            }
            else
            {
                MessageBox.Show("LB YF[EQ", "Ошибка", MessageBoxButton.OK);
            }
        }

        void LoadData()
        {
            Db.Rooms.Load();
            Db.Hotels.Load();

            HotelCb.ItemsSource = Db.Hotels.ToList();
            CategoryCb.ItemsSource= Db.Categories.ToList();
            if (_id != -1)
            {
                RoomsGrid.DataContext = Db.Rooms.FirstOrDefault(el => el.Id == _id);
            }
            else
            {
                RoomsGrid.DataContext = new Room();
            }
        }
    }
}
