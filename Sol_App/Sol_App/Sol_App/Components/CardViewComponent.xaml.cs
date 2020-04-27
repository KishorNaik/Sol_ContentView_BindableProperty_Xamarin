using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_App.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class CardViewComponent : ContentView
    {
        public CardViewComponent()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty CardTitleProperty =
            BindableProperty.Create
                (nameof(CardTitle), 
                    typeof(string), 
                    typeof(CardViewComponent), 
                    string.Empty);

        public string CardTitle
        {
            get => (string)GetValue(CardViewComponent.CardTitleProperty);
            set => SetValue(CardViewComponent.CardTitleProperty, value);
        }

        public static readonly BindableProperty CardDescriptionProperty = 
            BindableProperty.Create(
                nameof(CardDescription), 
                typeof(string), 
                typeof(CardViewComponent), string.Empty);

        public string CardDescription
        {
            get => (string)GetValue(CardViewComponent.CardDescriptionProperty);
            set => SetValue(CardViewComponent.CardDescriptionProperty, value);
        }


        public static readonly BindableProperty BorderColorProperty = 
            BindableProperty.Create
                (nameof(BorderColor), 
                typeof(Color), 
                typeof(CardViewComponent), 
                Color.DarkGray);

        public Color BorderColor
        {
            get => (Color)GetValue(CardViewComponent.BorderColorProperty);
            set => SetValue(CardViewComponent.BorderColorProperty, value);
        }

        public static readonly BindableProperty IconImageSourceProperty = 
            BindableProperty.Create
                (nameof(IconImageSource),
                    typeof(ImageSource), 
                    typeof(CardViewComponent), 
                    default(ImageSource));

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(CardViewComponent.IconImageSourceProperty);
            set => SetValue(CardViewComponent.IconImageSourceProperty, value);
        }

        public static readonly BindableProperty CardColorProperty = 
                BindableProperty.Create(
                        nameof(CardColor), 
                        typeof(Color), 
                        typeof(CardViewComponent), 
                        Color.White);

        public Color CardColor
        {
            get => (Color)GetValue(CardViewComponent.CardColorProperty);
            set => SetValue(CardViewComponent.CardColorProperty, value);
        }

        public static readonly BindableProperty IconBackgroundColorProperty = 
            BindableProperty.Create(
                nameof(IconBackgroundColor), 
                typeof(Color), 
                typeof(CardViewComponent), 
                Color.LightGray);


        public Color IconBackgroundColor
        {
            get => (Color)GetValue(CardViewComponent.IconBackgroundColorProperty);
            set => SetValue(CardViewComponent.IconBackgroundColorProperty, value);
        }

        public static readonly BindableProperty ChangeColorCommandProperty =
            BindableProperty.Create(
                nameof(ChangeColorCommand),
                typeof(Object),
                typeof(CardViewComponent),
                String.Empty);


        public Object ChangeColorCommand
        {
            get => (Object)GetValue(CardViewComponent.ChangeColorCommandProperty);
            set => SetValue(CardViewComponent.ChangeColorCommandProperty, value);
        }
    }
}