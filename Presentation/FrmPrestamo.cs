using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmPrestamo : Form
    {
        public ICalendarioRepository calendarioModel;
        public FrmPrestamo(ICalendarioRepository calendario)
        {
            calendarioModel = calendario;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CalendarioPrestamo cal = new CalendarioPrestamo()
            {
                Id = calendarioModel.GetLastIndex(),
                FechaPago = dtpPago.Value,
                FechaVencimiento = dtpVencimiento.Value,
                Principal = (nudPrestamo.Value + (nudPrestamo.Value * (nudInteres.Value / 100))) / (nudTerminos.Value * 12),
                PrincipalPagado = nudCPagada.Value,
                Interes = nudInteres.Value,
                InteresPagado = 0,
                Cuota = (nudPrestamo.Value + (nudPrestamo.Value * (nudInteres.Value / 100))) / (nudTerminos.Value * 12),
                CuotaPagado = nudCPagada.Value,
                Estado = Domain.Enums.Estado.Pendiente
            };

            calendarioModel.Create(cal);

            dgvPrestamo.DataSource = calendarioModel.GetAll();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (cmbSelect.SelectedIndex)
            {
                case 0:
                    dgvPrestamo.DataSource = calendarioModel.GetBy(a => a.Estado == Domain.Enums.Estado.Eliminado);
                    break;

                case 1:
                    dgvPrestamo.DataSource = calendarioModel.GetBy(a => a.Estado == Domain.Enums.Estado.Pagado);
                    break;

                case 2:
                    dgvPrestamo.DataSource = calendarioModel.GetBy(a => a.Estado == Domain.Enums.Estado.Pendiente);
                    break;

                default:
                    MessageBox.Show("No se ha seleccionado una opcion.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
