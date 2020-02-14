using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryButtonView : ContentView
    {
        public DiscoveryButtonView()
        {
            InitializeComponent();
            BindingContext = discoveryButtonView;

        }

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(ImageSource), default(ImageSource));
        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(DiscoveryButtonView.ImageSourceProperty);
            set => SetValue(DiscoveryButtonView.ImageSourceProperty, value);
        }

        public static readonly BindableProperty Label1_TextProperty = BindableProperty.Create(nameof(Label1_Text), typeof(string), typeof(DiscoveryButtonView), string.Empty);
        public string Label1_Text
        {
            get => (string)GetValue(DiscoveryButtonView.Label1_TextProperty);
            set => SetValue(DiscoveryButtonView.Label1_TextProperty, value);
        }

        public static readonly BindableProperty Label2_TextProperty = BindableProperty.Create(nameof(Label2_Text), typeof(string), typeof(DiscoveryButtonView), string.Empty);
        public string Label2_Text
        {
            get => (string)GetValue(DiscoveryButtonView.Label2_TextProperty);
            set => SetValue(DiscoveryButtonView.Label2_TextProperty, value);
        }

    }
}