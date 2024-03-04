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
    /// Логика взаимодействия для EditHotel.xaml
    /// </summary>
    public partial class EditHotel : Page
    {
        private long _id;
        public EditHotel(long Id)
        {
            InitializeComponent();
            _id = Id;
            LoadData();
        }

        private void LoadData()
        {
            Db.Regions.Load();
            Db.Hotels.Load();
            RegionCb.ItemsSource = Db.Regions.ToList();

            if(_id != -1)
            {
                StackEdit.DataContext = Db.Hotels.FirstOrDefault(el => el.Id == _id);
            }
            else
            {
                StackEdit.DataContext = new Hotel();
            }
        }

        private void OkBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(NameTb.Text.Length <= 150)
            {

                if (_id == -1)
                {
                    Db.Hotels.Add(StackEdit.DataContext as Hotel);
                }
                Db.SaveChanges();
                NavigationService.Navigate(new DataHotel());
            }
            else
            {
                MessageBox.Show("Длина не должна быть больше 150 символов", "Ограничение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
