using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PF.Entidades.Dominio;

namespace PF.Entidades.Modelo
{
    public class OperacioModel
    {
        private List<PlazoFijo> _plazos;
        private double _montoTotal=0;
        private double _comisionTotal=0;

        public OperacioModel(List<PlazoFijo> lstPlazos)
        {
            _plazos = new List<PlazoFijo>();
            _plazos = lstPlazos;
        }

        public double MontoTotal
        {
            get
            {
                if (_plazos != null)
                {
                    foreach (PlazoFijo plazo in _plazos)
                    {
                        _montoTotal += plazo.MontoFinal;
                    }
                    return _montoTotal;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double ComisionTotal
        {
            get
            {
                if (_plazos != null)
                {
                    foreach (PlazoFijo plazo in _plazos)
                    {
                        _comisionTotal += (15 + plazo.Interes * 0.01);
                    }
                    return _comisionTotal;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
