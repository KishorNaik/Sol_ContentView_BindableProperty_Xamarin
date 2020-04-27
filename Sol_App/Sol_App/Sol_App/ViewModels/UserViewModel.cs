using Sol_App.Helpers.Commands;
using Sol_App.Models;
using Sol_App.UiModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sol_App.ViewModels
{
    public class UserViewModel:ViewModelBase
    {

        public UserViewModel()
        {
            Users = new UserModel();

            UsersUi = new UserUiModel();

            BindUserData();

            Submit = new AsyncCommand(OnSubmit);
        }

        private UserModel _users = null;
        public UserModel Users
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        private UserUiModel _usersUi = null;
        public UserUiModel UsersUi
        {
            get => _usersUi;
            set => SetProperty(ref _usersUi, value);
        }

        #region Command
        public IAsyncCommand Submit { get; set; }
        #endregion 

        private void BindUserData()
        {
            Users.UserName = "Kishor Naik";
            Users.UserDescription = "I am .Net Developer and Solution Architect.";
            Users.UserIcon = "https://ideators.tech/assets/img/team/Kishor-Naik.jpeg";

            UsersUi.BorderColor = System.Drawing.Color.DarkGray;
            UsersUi.CardColor = System.Drawing.Color.LightSalmon;
            UsersUi.IconBackgroundColor = System.Drawing.Color.SlateGray;
        }

        private Task OnSubmit()
        {
            UsersUi.BorderColor = System.Drawing.Color.AliceBlue;
            UsersUi.CardColor = System.Drawing.Color.DarkOrange;
            UsersUi.IconBackgroundColor = System.Drawing.Color.LightCoral;

            return Task.CompletedTask;
        }
    }
}
