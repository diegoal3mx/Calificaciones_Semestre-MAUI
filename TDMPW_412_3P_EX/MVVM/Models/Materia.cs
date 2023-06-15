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
        public ObservableCollection<Rubro> Rubros { get; set; } = new ObservableCollection<Rubro>();
        public float CalificacionFinal { get; set; }

        public Materia()
        {

        }
        public void CalcularCalificacionFinal()
        {
            float CalificacionPrimerRubro = (float)(Rubros[0].Valor / 100m) * Rubros[0].Calificacion;
            float CalificacionSegundoRubro = (float)(Rubros[1].Valor / 100m) * Rubros[1].Calificacion;
            float CalificacionTercerRubro = (float)(Rubros[2].Valor / 100m) * Rubros[2].Calificacion;

            float calificacionFinal = CalificacionPrimerRubro + CalificacionSegundoRubro + CalificacionTercerRubro;
            CalificacionFinal = calificacionFinal;
        }
    }
}
