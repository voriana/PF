using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.Entidades.Dominio
{
    public class PlazoFijo
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private string _usuario;
        private TipoPlazo _tipoPlazo;

        public PlazoFijo()
        {
        }

        public PlazoFijo(int id, int idCliente, int tipo, double tasa, int dias, double capitalInicial, string usuario)
        {
            _id = id;
            _idCliente = idCliente;
            _tipo = tipo;
            _tasa = tasa;
            _dias = dias;
            _capitalInicial = capitalInicial;
            _usuario = usuario;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public int Dias { get => _dias; set => _dias = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        public TipoPlazo TipoPlazo { get => _tipoPlazo; set => _tipoPlazo = value; }

        //propiedades autoCalculables
        public double Interes
        {
            get
            {
                return ((this._tasa / 365 * this._dias) * CapitalInicial) / 100;
            }
        }

        public double MontoFinal
        {
            get
            {
                return  CapitalInicial + Interes;
            }
        }

        public string MostrarEnLista
        {
            get
            {
                return $"Id){this._id}-Dias:{this._dias} -ARS:$" +
                    $"{this.CapitalInicial}(Interes:{this.Interes.ToString("0.00")})Tipo:{this.TipoPlazo.Descripcion}";
            }
        }

       
    }
}
