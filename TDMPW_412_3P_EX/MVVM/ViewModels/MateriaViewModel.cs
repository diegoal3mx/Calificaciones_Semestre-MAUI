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
    public partial class MateriaViewModel
    {
       
        public ObservableCollection<Materia> Materias { get; set; } = new();
        public ObservableCollection<Rubro> RubrosNuevaMateria { get; set; } = new();
        public Materia Materia { get; set; }
        public bool EditarMateria { get; set; }
        public int NumeroDeMaterias { get; set; }

        public INavigation Navigation { get; set; }
        public ICommand CmdBtnAdd_Clicked { get; set; }
        public ICommand CmdBtnEdit_Clicked => new Command(() => { Materias[0].CalcularCalificacionFinal(); EditarMateria = !EditarMateria; });

        

        public MateriaViewModel(INavigation navigation) {

            this.Navigation = navigation;
            this.CmdBtnAdd_Clicked = new Command(async () => await Navigation.PushAsync(new AgregarMateriaView(this)));

            EditarMateria = false;
            NumeroDeMaterias = 0;

            Rubro rubro1 = new() { Nombre = "", Valor = 0, Calificacion = 0};
            Rubro rubro2 = new() { Nombre = "", Valor = 0, Calificacion = 0 };
            Rubro rubro3 = new() { Nombre = "", Valor = 0, Calificacion = 0 };

            RubrosNuevaMateria.Add(rubro1);
            RubrosNuevaMateria.Add(rubro2);
            RubrosNuevaMateria.Add(rubro3);

            Materia = new Materia {
                Nombre = "",
                Rubros = RubrosNuevaMateria,
                CalificacionFinal = 0
            };

            Materias.Add(Materia);
        }   
    }
}
