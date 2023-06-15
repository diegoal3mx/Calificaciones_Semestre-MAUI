using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Semestre
    {
        public string NombreMateria { get; set; }
        public float ValorPrimerParcial { get; set; }
        public float CalificacionPrimerParcial { get; set; }
        public float ValorSegundoParcial { get; set; }
        public float CalificacionSegundoParcial { get; set; }
        public float ValorTercerParcial { get; set; }
        public float CalificacionTercerParcial { get; set; }
        public float CalificacionFinal { get; set; }

        public Semestre()
        {

        }
    }
}
