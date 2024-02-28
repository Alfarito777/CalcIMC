namespace CalcIMC
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            var peso = Convert.ToDecimal(EntryPeso.Text);
            var estatura = Convert.ToDecimal(EntryEstatura.Text);

            var imc = peso / (estatura * estatura);

            EntryIMC.Text = imc.ToString();


        }
    }

}
