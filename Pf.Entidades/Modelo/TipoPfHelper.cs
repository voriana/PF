using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PF.Entidades.Dominio;

namespace PF.Entidades.Modelo
{
    public static class TipoPfHelper
    {
       private static List<TipoPlazo> _tipos;
       static TipoPfHelper()
       {
            _tipos = new List<TipoPlazo>();
            TipoPlazo tipo1 = new TipoPlazo(0,"SELECCIONE",0);
            TipoPlazo tipo2 = new TipoPlazo(1, "Plazo Fijo Web", 43);
            TipoPlazo tipo3 = new TipoPlazo(2, "Plazo Fijo UVA", 2);
            _tipos.Add(tipo1);
            _tipos.Add(tipo2);
            _tipos.Add(tipo3);
       }
        public static List<TipoPlazo> ListarTipos()
        {
            return _tipos;
        }

    }
}
