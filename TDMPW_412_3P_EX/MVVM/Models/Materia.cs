using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using TDMPW_412_3P_EX.MVVM.Models;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Materia
    {
        public string Nombre { get; set; }
        public float Tareas { get; set; }
        public float Proyecto { get; set; }
        public float Examen { get; set; }
        public ObservableCollection<Rubro> rubros = new ObservableCollection<Rubro>();
        public float CalificacionFinal { get; set; }

        public Materia()
        {

        }
    }
}
