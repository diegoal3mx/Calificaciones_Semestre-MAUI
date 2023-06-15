using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDMPW_412_3P_EX.MVVM.Models;
using TDMPW_412_3P_EX.MVVM.Views;

namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class AgregarMateriaViewModel
    {
        public bool AgregarMateria { get; set; }

        public INavigation Navigation { get; set; }
        public ICommand CmdBtnSubmit_Clicked => new Command(() => { AgregarMateria = !AgregarMateria; });
        public ICommand CmdBtnSave_Clicked => new Command(async () => { TodasLasMaterias.Materias[0].CalcularCalificacionFinal(); TodasLasMaterias.NumeroDeMaterias++; await Navigation.PopAsync(); });
        public MateriaViewModel TodasLasMaterias { get; set; }

        public AgregarMateriaViewModel(INavigation navigation, MateriaViewModel todasLasMaterias)
        {
            this.AgregarMateria = true;
            this.Navigation = navigation;
            this.TodasLasMaterias = todasLasMaterias;

        }
    }

}
