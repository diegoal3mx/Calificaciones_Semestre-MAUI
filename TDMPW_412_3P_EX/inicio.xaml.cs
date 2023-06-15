using TDMPW_412_3P_EX.MVVM.Views;
namespace TDMPW_412_3P_EX;

public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private async void IrAMateria(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MateriaView());
        }

        private async void IrASemestre(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SemestreView());
        }
    }