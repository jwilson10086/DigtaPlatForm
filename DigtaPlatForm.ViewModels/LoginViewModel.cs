using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DigtaPlatForm.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DigtaPlatForm.ViewModels
{
    // ViewModel for the login screen
    public class LoginViewModel : ViewModelBase
    {
        // Model representing the user
        public UserModel User { get; set; }

        // Command to handle login action
        public RelayCommand<object> LoginCommand { get; set; }

        // Private field to store error message
        public string errorMessage;
        // Public property to expose error message
        public string ErrorMessage
        {
            get { return errorMessage; }
            set { Set(ref errorMessage, value); }
        }

        // Constructor initializing the ViewModel
        public LoginViewModel()
        {
            // Check if the application is not in design mode
            if (!IsInDesignMode)
            {
                User = new UserModel();
                LoginCommand = new RelayCommand<object>(Login);
            }
        }

        // Method to handle the login logic
        private void Login(object obj)
        {
            // Validate user credentials against hardcoded values
            if (User.UserName == "admin" && User.Password == "123456")
            {
                // Set DialogResult to true if credentials are correct
                (obj as Window).DialogResult = true;
            }
            else
            {
                // Set error message if credentials are incorrect
                ErrorMessage = "用户名或密码错误";
            }
        }
    }
}
