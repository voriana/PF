using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PF.Datos;
using PF.Entidades.Dominio;
using PF.Entidades.Modelo;

namespace PF.Negocio
{
    public class PlazoNegocio
    {
        private PlazoMapper _pFMapper;
        public PlazoNegocio()
        {
            _pFMapper = new PlazoMapper();
        }

        public  List<PlazoFijo> TraerPlazo()
        {
            List<PlazoFijo> _plazos = _pFMapper.GetplazoFijos();
            return _plazos;
        }

        public PlazoFijo Simular(TipoPlazo tipo, double tasa, double capital , int dias) 
        {
            PlazoFijo plazo = new PlazoFijo();
            plazo.Id = tipo.Id;
            plazo.Tasa = tasa;
            plazo.CapitalInicial = capital;
            plazo.Dias = dias;
            return plazo;
        }

        public TransactionResult EnviarPlazo(TipoPlazo tipo, double tasa, double capital, int dias, double montoFinal)
        {
            if(tipo.Descripcion== "Plazo Fijo Web"&& dias < 30)
            {
                throw new Exception("El plazo minimo de 30 dias");
            }
            if(tipo.Descripcion == "Plazo Fijo UVA" && dias < 180)
            {
                throw new Exception("El plazo minimo de 180 dias");
            }
            if((tipo.Descripcion == "Plazo Fijo Web"|| tipo.Descripcion == "Plazo Fijo UVA") && dias > 365)
            {
                throw new Exception("Ningun plazo fijo puede ser mayor a 365 dias");
            }

            PlazoFijo plazo = new PlazoFijo();
            plazo.Tipo = tipo.Id;
            plazo.Id = 0;
            plazo.IdCliente = 0;
            plazo.Dias = dias;
            plazo.CapitalInicial = capital;
            plazo.Usuario = "890175";

            TransactionResult resultAlta = _pFMapper.AltaPlazo(plazo);
            return resultAlta;

        }
    }
}
