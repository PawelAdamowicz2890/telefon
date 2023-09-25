namespace telefon
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "1";
        }
        private void btn2Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "2";
        }
        private void btn3Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "3";
        }
        private void btn4Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "4";
        }
        private void btn5Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "5";
        }
        private void btn6Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "6";
        }
        private void btn7Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "7";
        }
        private void btn8Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "8";
        }
        private void btn9Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "9";
        }
        private void btn0Clicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "0";
        }
        private void btnStrClicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "*";
        }
        private void btnHashClicked(object sender, EventArgs e)
        {
            numerTelLbl.Text += "#";
        }
        private async void btnCallClicked(object sender, EventArgs e)
        {
            string numer = numerTelLbl.Text;
            await DisplayAlert("Alert",$"Dzwonię pod numer {numer}", "OK");
        }
        private void btnDelClicked(object sender, EventArgs e)
        {
            if (numerTelLbl.Text.Length <= 1)
            {
                numerTelLbl.Text = "";
            }
            else
                numerTelLbl.Text = numerTelLbl.Text.Remove(numerTelLbl.Text.Length - 1);
        }
    }
}