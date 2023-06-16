using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDMPW_412_3P_EX.MVVM.Models;
using TDMPW_412_3P_EX.MVVM.Views;

namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class SemestreViewModel
    {
        public ObservableCollection<Semestre> Semestres { get; set; } = new();
      
        public Semestre Semestre { get; set; }
        public bool EditarSemestre { get; set; }
        public int NumeroDeSemestres { get; set; }

        public INavigation Navigation { get; set; }
        public ICommand CmdBtnAdd_Clicked { get; set; }
        public ICommand CmdBtnEdit_Clicked => new Command(() => { Semestres[0].CalcularCalificacionFinal(); EditarSemestre = !EditarSemestre; });



        public SemestreViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.CmdBtnAdd_Clicked = new Command(async () => await Navigation.PushAsync(new AgregarCalificacionesSemestreView(this)));

            EditarSemestre = false;
            NumeroDeSemestres = 0;

            Semestre = new Semestre
            {
                NombreMateria = "",
                ValorPrimerParcial = 0,
                CalificacionPrimerParcial = 0,
                ValorSegundoParcial = 0,
                CalificacionSegundoParcial = 0,
                ValorTercerParcial = 0,
                CalificacionTercerParcial = 0,
                CalificacionFinal = 0
            };

            Semestres.Add(Semestre);
        }
    }
}
