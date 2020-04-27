using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sol_App.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        private String _userName;
        public String UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }

        private String _userDescription; 
        public String UserDescription
        {
            get => _userDescription;
            set
            {
                _userDescription = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserDescription)));
            }
        }

        private String _userIcon = null;
        public String UserIcon
        {
            get => _userIcon;
            set
            {
                _userIcon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserIcon)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
