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
using UsersMvcApp.Controllers;
using UsersMvcApp.Models;

namespace UsersMvcApp.Views
{
    /// <summary>
    /// Interaction logic for DetailsScreen.xaml
    /// </summary>
    public partial class DetailsScreen : Page
    {
        private readonly UserController _controller;
        private readonly User _user;

        public DetailsScreen(UserController controller, User user)
        {
            InitializeComponent();

            _controller = controller;
            _user = user;

            IdTextBlock.Text = $"ID: {_user.Id}";
            NameTextBlock.Text = $"Ім'я: {_user.Name}";
            LastNameTextBlock.Text = $"Прізвище: {_user.LastName}";
            AgeTextBlock.Text = $"Вік: {_user.Age}";

            EditButton.Click += EditButton_Click;
            DeleteButton.Click += DeleteButton_Click;
            BackButton.Click += BackButton_Click;
        }

        private void EditButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _controller.ShowEditUserScreen(_user);
        }

        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _controller.DeleteUser(_user);
        }

        private void BackButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _controller.ShowHomeScreen();
        }
    }
}
