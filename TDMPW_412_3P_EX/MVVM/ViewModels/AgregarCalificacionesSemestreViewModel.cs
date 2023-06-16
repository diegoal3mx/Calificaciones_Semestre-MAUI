using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class AgregarCalificacionesSemestreViewModel
    {
        public bool AgregarCalificacionesSemestre { get; set; }
        public bool ValoresDeParcialesCorrectos { get; set; }
        public bool CamposVacios { get; set; }

        public INavigation Navigation { get; set; }
        public ICommand CmdBtnSubmit_Clicked => new Command(() => {
            if (!TodosLosSemestres.Semestres[0].VerificarValoresPropiedades())
            {
                CamposVacios = true;
            }
            else if (TodosLosSemestres.Semestres[0].VerificarValoresParciales())
            {
                CamposVacios = false;
                AgregarCalificacionesSemestre = !AgregarCalificacionesSemestre;
                ValoresDeParcialesCorrectos = true;
            }
            else
            {
                CamposVacios = false;
                ValoresDeParcialesCorrectos = false;
            }
        });
        public ICommand CmdBtnSave_Clicked => new Command(async () => { TodosLosSemestres.Semestres[0].CalcularCalificacionFinal(); TodosLosSemestres.NumeroDeSemestres++; await Navigation.PopAsync(); });
        public SemestreViewModel TodosLosSemestres { get; set; }

        public AgregarCalificacionesSemestreViewModel(INavigation navigation, SemestreViewModel todosLosSemestres)
        {
            this.AgregarCalificacionesSemestre = true;
            this.Navigation = navigation;
            this.TodosLosSemestres = todosLosSemestres;
            this.ValoresDeParcialesCorrectos = true;
            this.CamposVacios = false;
        }
    }

}
