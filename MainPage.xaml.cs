namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();


        }

        private void OnSaveChangesClicked(object sender, EventArgs e)
        {

            ConfirmationMessage.IsVisible = true; // confirmation message
        }

        private void OnChangedBgColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBackgroundColor"] = Colors.Pink;
        }
    }
}