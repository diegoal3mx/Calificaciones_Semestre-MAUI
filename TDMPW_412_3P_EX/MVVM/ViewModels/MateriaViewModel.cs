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

        public INavigation Navigation { get; set; }
        public ICommand CmdBtnAdd_Clicked { get; set; }
        public ICommand CmdBtnEdit_Clicked => new Command(() => { EditarMateria=!EditarMateria; Materias[0].CalificacionFinal=new AgregarMateriaViewModel(Navigation, this).CalcularCalificacionFinal(); });

        

        public MateriaViewModel(INavigation navigation) {

            this.Navigation = navigation;
            this.CmdBtnAdd_Clicked = new Command(async () => await Navigation.PushAsync(new AgregarMateriaView(this)));

            EditarMateria = false;

            Rubro rubro1 = new() { Nombre = "Proyecto", Valor = 0, Calificacion = 0};
            Rubro rubro2 = new() { Nombre = "Tareas", Valor = 0, Calificacion = 0 };
            Rubro rubro3 = new() { Nombre = "Examen", Valor = 0, Calificacion = 0 };

            RubrosNuevaMateria.Add(rubro1);
            RubrosNuevaMateria.Add(rubro2);
            RubrosNuevaMateria.Add(rubro3);

            Materia = new Materia {
                Nombre = "Nueva Materia",
                Tareas = 10,
                Proyecto = 0,
                Examen = 10,
                Rubros = RubrosNuevaMateria,
                CalificacionFinal = 0
            };

            Materias.Add(Materia);
        }   
    }
}
