using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UsersMvcApp.Models;
using UsersMvcApp.Views;


namespace UsersMvcApp.Controllers
{
    public class UserController
    {
        private readonly Frame _mainFrame;
        private readonly List<User> _users;

        public UserController(Frame mainFrame)
        {
            _mainFrame = mainFrame;

            _users = new List<User>
            {
                new User(1, "Артем", "Саблєв", 22),
                new User(2, "Віта", "Гурєєва", 22),
                new User(3, "Дар'я", "Паненко", 22)
            };
        }

        public void ShowHomeScreen()
        {
            HomeScreen homeScreen = new HomeScreen(this, _users);
            _mainFrame.Navigate(homeScreen);
        }

        public void ShowDetailsScreen(User user)
        {
            DetailsScreen detailsScreen = new DetailsScreen(this, user);
            _mainFrame.Navigate(detailsScreen);
        }

        public void ShowEditUserScreen(User user)
        {
            EditUserScreen editUserScreen = new EditUserScreen(this, user);
            _mainFrame.Navigate(editUserScreen);
        }

        public void UpdateUser(User updatedUser)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == updatedUser.Id)
                {
                    _users[i] = updatedUser;
                    break;
                }
            }

            ShowDetailsScreen(updatedUser);
        }

        public void DeleteUser(User user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == user.Id)
                {
                    _users.RemoveAt(i);
                    break;
                }
            }

            ShowHomeScreen();
        }
    }
}