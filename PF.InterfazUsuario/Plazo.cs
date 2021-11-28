using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PF.Entidades;
using PF.Entidades.Dominio;
using PF.Entidades.Modelo;
using PF.Negocio;

namespace PF.InterfazUsuario
{
    public partial class Plazo : Form
    {
        private List<TipoPlazo> _tipos;
        private List<PlazoFijo> _plazos;
        private PlazoNegocio _plazoNegocio;
        

        public Plazo()
        {
            InitializeComponent();
            _tipos=new List<TipoPlazo>();
            _plazos=new List<PlazoFijo>();
            _plazoNegocio = new PlazoNegocio();
            
        }

        private void Plazo_Load(object sender, EventArgs e)
        {
            CargaCombo();
            CargaLista();
        }

        private void CargaLista()
        {
            _lstPlazos.DataSource = null;
            _plazos = _plazoNegocio.TraerPlazo();
            _lstPlazos.DataSource=_plazos;
            _lstPlazos.DisplayMember = "MostrarEnLista";
            ActualizarCalculos();
           

        }

        private void CargaCombo()
        {
            _tipos = TipoPfHelper.ListarTipos();
            _cbTipoPf.DataSource = _tipos;
            _cbTipoPf.DisplayMember = "MostrarEnCombo";
        }

        private void _cbTipoPf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TipoPlazo)_cbTipoPf.SelectedItem).Id != 0)
            {
                _txtTasa.Text = ((TipoPlazo)_cbTipoPf.SelectedItem).Tasa.ToString();
            }
          
        }

        private void  Validaciones()
        {
            if (_txtCapitalInv.Text != "")
            {
                if(!double.TryParse(_txtCapitalInv.Text,out double result)) 
                {
                    throw new Exception($"Capital debe ser un valor numerico");
                }
            }
            if (_txtDias.Text != "")
            {
                if (!int.TryParse(_txtCapitalInv.Text, out int result))
                {
                    throw new Exception($"dias debe ser un valor numerico");
                }
            }
        }

        private void _btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                TipoPlazo tipo = (TipoPlazo)_cbTipoPf.SelectedItem;
                double tasa = Convert.ToDouble(_txtTasa.Text);
                double capital= Convert.ToDouble(_txtCapitalInv.Text);
                int dias = Convert.ToInt32(_txtDias.Text);
                PlazoFijo plazo = _plazoNegocio.Simular(tipo, tasa, capital, dias);
                _txtInteresARecibir.Text = plazo.Interes.ToString("0.00");
                _txtMontoFinal.Text = plazo.MontoFinal.ToString("0.00");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();

                TipoPlazo tipo = ((TipoPlazo)_cbTipoPf.SelectedItem);
                double tasa = Convert.ToDouble(_txtTasa.Text);
                double capital = Convert.ToDouble(_txtCapitalInv.Text);
                int dias = Convert.ToInt32(_txtDias.Text);
                double montoFinal = Convert.ToDouble(_txtMontoFinal.Text);
                TransactionResult resultado = _plazoNegocio.EnviarPlazo(tipo, tasa, capital, dias, montoFinal);
                if (!resultado.IsOk)
                {
                    MessageBox.Show("Error en el alta del plazo fijo");
                }
                else
                {
                    MessageBox.Show($"Plazo dado de alta con id- {resultado.Id}");
                    CargaLista();
                    Limpiar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ActualizarCalculos()

        {
            OperacioModel _operaciones = new OperacioModel(_plazos);
            _txtMontoTotal.Text = _operaciones.MontoTotal.ToString("0.00");
            _txtComisonTotal.Text = _operaciones.ComisionTotal.ToString("0.00");
        }
        private void Limpiar()
        {
            ((TipoPlazo)_cbTipoPf.SelectedItem).Id = 0;
            _txtCapitalInv.Clear();
            _txtDias.Clear();
            _txtInteresARecibir.Clear();
            _txtMontoFinal.Clear();
            
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
