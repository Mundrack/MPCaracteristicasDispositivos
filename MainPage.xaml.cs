namespace MPCaracteristicasDispositivos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void GetDeviceInfo(object sender, EventArgs e)
        {
            InfoDevice.Text = $"Fabricante: {DeviceInfo.Manufacturer} \n Modelo : {DeviceInfo.Model}\n Plataforma: {DeviceInfo.Platform}";

        }

        private void OnVibrateClicked(object sender, EventArgs e)
        {
            Vibration.Vibrate();

        }
    }

}
