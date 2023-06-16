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
        public float CalificacionParaAprobar { get; set; }
        public float CalificacionParaSacarDiez { get; set; }
        public bool SePuedeAprobar { get; set; }
        public bool SePuedeSacarDiez { get; set;}

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
        public void CalcularCalificacionParaAprobar()
        {
            float CalificacionFinalPrimerParcial = (ValorPrimerParcial / 100) * CalificacionPrimerParcial;
            float CalificacionFinalSegundoParcial = (ValorSegundoParcial / 100) * CalificacionSegundoParcial;

            float CalificacionPrimerosDosParciales = CalificacionFinalPrimerParcial + CalificacionFinalSegundoParcial;
            float calificacionParaAprobar = (6 - CalificacionPrimerosDosParciales) / ValorTercerParcial * 100;
            if(calificacionParaAprobar < 0)
            {
                calificacionParaAprobar = 0;
            }
            CalificacionParaAprobar = calificacionParaAprobar;
        }
        public void CalcularCalificacionParaSacarDiez()
        {
            float CalificacionFinalPrimerParcial = (ValorPrimerParcial / 100) * CalificacionPrimerParcial;
            float CalificacionFinalSegundoParcial = (ValorSegundoParcial / 100) * CalificacionSegundoParcial;

            float CalificacionPrimerosDosParciales = CalificacionFinalPrimerParcial + CalificacionFinalSegundoParcial;
            float calificacionParaSacarDiez = (10 - CalificacionPrimerosDosParciales) / ValorTercerParcial * 100;
            CalificacionParaSacarDiez = calificacionParaSacarDiez;
        }
        public void VerificarSiSePuedeSacarDiez()
        {
            CalcularCalificacionParaSacarDiez();

            if (CalificacionParaSacarDiez>10)
            {
                SePuedeSacarDiez = false;
            }
            else
            {
                SePuedeSacarDiez = true;
            }
        }
        public void VerificarSiSePuedeAprobar()
        {
            CalcularCalificacionParaAprobar();

            if (CalificacionParaAprobar > 10)
            {
                SePuedeAprobar = false;
            }
            else
            {
                SePuedeAprobar = true;
            }
        }
        public bool VerificarValoresParciales()
        {
            float ValorTotalParciales = ValorPrimerParcial + ValorSegundoParcial + ValorTercerParcial;
            if (ValorTotalParciales == 100)
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
