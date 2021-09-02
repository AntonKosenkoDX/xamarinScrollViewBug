using Xamarin.Forms;

namespace ScrollViewLayoutBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            test1.IsVisible = true;
            test2.IsVisible = true;
            test3.IsVisible = true;
            test4.IsVisible = true;
            test5.IsVisible = true;
            test6.IsVisible = true;
            test7.IsVisible = true;
            test8.IsVisible = true;
            test9.IsVisible = true;
        }
    }
}
