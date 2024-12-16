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

        public void GetBateriInfo(object sender, EventArgs e)
        {
            var level = Battery.ChargeLevel;
            var State = Battery.State;
            var source = Battery.PowerSource;

            InfoBatery.Text = $"Nivel de bateria: {level}\n Estado: {State}\n Source: {source}";

        }

        private void GetPhoto(object sender, EventArgs e)
        {

        }
    }

}
