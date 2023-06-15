﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Rubro
    {
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public float Calificacion { get; set; }

        public Rubro()
        {

        }
    }
}
