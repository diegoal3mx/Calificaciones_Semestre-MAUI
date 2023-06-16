using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public void CalcularCalificacionFinal()
        {
            float CalificacionFinalPrimerParcial = (ValorPrimerParcial / 100) * CalificacionPrimerParcial;
            float CalificacionFinalSegundoParcial = (ValorSegundoParcial/ 100) * CalificacionSegundoParcial;
            float CalificacionFinalTercerParcial = (ValorTercerParcial / 100) * CalificacionTercerParcial;

            float calificacionFinal = CalificacionFinalPrimerParcial + CalificacionFinalSegundoParcial + CalificacionFinalTercerParcial;
            CalificacionFinal = calificacionFinal;
        }
        public bool VerificarValoresParciales()
        {
            float ValorTotalParciales = ValorPrimerParcial + ValorSegundoParcial + ValorTercerParcial;
            if (ValorTotalParciales > 99.9 && ValorTotalParciales<100.1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarValoresPropiedades()
        {
            if (String.IsNullOrWhiteSpace(NombreMateria))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
