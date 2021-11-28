using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.Entidades.Dominio
{
    public class TipoPlazo
    {
        private int _id;
        private string _descripcion;
        private double _tasa;

        public TipoPlazo(int id, string descripcion, double tasa)
        {
            _id = id;
            _descripcion = descripcion;
            _tasa = tasa;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }

        public override string ToString()
        {
            return $"Descripcion {this._descripcion}-Tasa: {this._tasa}";
        }
        public string MostrarEnCombo
        {
            get
            {
                return $"{this._id}-{this._descripcion}";
            }
        }
    }
}
