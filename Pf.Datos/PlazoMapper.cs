using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pf.Datos;
using PF.Entidades.Dominio;
using PF.Entidades.Modelo;

namespace PF.Datos
{
    public class PlazoMapper
    {
        public List<PlazoFijo> _plazosF;

        public PlazoMapper()
        {
        }
        public List<PlazoFijo> GetplazoFijos()
        {
            string json = WebHelper.Get("plazofijo/890175");
            _plazosF = PfMap(json);
            return _plazosF;
        }

        private List<PlazoFijo> PfMap(string json)
        {
            List<PlazoFijo> lst = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return lst;
        }

        public TransactionResult AltaPlazo(PlazoFijo plazo)
        {
            NameValueCollection obj = new NameValueCollection();
            obj = reverseMap(plazo);
            string json = WebHelper.Post("PlazoFijo", obj);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection reverseMap(PlazoFijo plazo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", "0");
            n.Add("idCliente", "0");
            n.Add("Tipo", plazo.Tipo.ToString());
            n.Add("Dias", plazo.Dias.ToString());
            n.Add("CapitalInicial", plazo.CapitalInicial.ToString("0.00"));
            n.Add("Tasa", plazo.Tasa.ToString("0.00"));
            n.Add("Interes", plazo.Interes.ToString("0.00"));
            n.Add("Usuario", plazo.Usuario);
            return n;
        }
    }
}
