using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Sol_App.UiModels
{
    public class UserUiModel : INotifyPropertyChanged
    {
        private Color _borderColor;
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BorderColor)));
            }
        }

        private Color _cardColor;
        public Color CardColor
        {
            get => _cardColor;
            set
            {
                _cardColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CardColor)));
            }
        }

        private Color _iconBackgroundColor;
        public Color IconBackgroundColor
        {
            get => _iconBackgroundColor;
            set
            {
                _iconBackgroundColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IconBackgroundColor)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
