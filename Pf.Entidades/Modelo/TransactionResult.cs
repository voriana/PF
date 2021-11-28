using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.Entidades.Modelo
{
    public class TransactionResult
    {
        private int _id;
        private string _error;
        private bool _isOk;

        public int Id { get => _id; set => _id = value; }
        public string Error { get => _error; set => _error = value; }
        public bool IsOk { get => _isOk; set => _isOk = value; }
    }
}
