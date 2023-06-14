using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Materia
    {
        public string Nombre { get; set; }
        public float Tareas { get; set; }
        public float Proyecto { get; set; }
        public float Examen { get; set; }
        public float CalificacionFinal { get; set; }

        public Materia()
        {

        }
    }
}
