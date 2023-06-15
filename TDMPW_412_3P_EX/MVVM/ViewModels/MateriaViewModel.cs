using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMPW_412_3P_EX.MVVM.Models;

namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MateriaViewModel
    {
       
        public ObservableCollection<Materia> materias { get; set; } = new();
        public ObservableCollection<Rubro> rubrosNuevaMateria { get; set; } = new();
        public Materia materia { get; set; }

        public MateriaViewModel() {

            Rubro rubro1 = new Rubro { Nombre = "Proyecto", Valor = 0, Calificacion = 0};
            Rubro rubro2 = new Rubro { Nombre = "Tareas", Valor = 0, Calificacion = 0 };
            Rubro rubro3 = new Rubro { Nombre = "Examen", Valor = 0, Calificacion = 0 };

            rubrosNuevaMateria.Add(rubro1);
            rubrosNuevaMateria.Add(rubro2);
            rubrosNuevaMateria.Add(rubro3);

            materia = new Materia {
                Nombre = "Nueva Materia",
                Tareas = 10,
                Proyecto = 0,
                Examen = 10,
                rubros = rubrosNuevaMateria,
                CalificacionFinal = 0
            };

            materias.Add(materia);

        }   
    }
}
