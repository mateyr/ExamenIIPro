using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionExamenII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            dgvFinan.Columns.Clear();

            setData();

        }


        private void validaciones(int plazo)
        {

        }

        private void setFirstColum()
        {
            dgvFinan.Rows[0].Cells[0].Value = "Invertir";
            dgvFinan.Rows[1].Cells[0].Value = "Ingresos";
            dgvFinan.Rows[2].Cells[0].Value = "Egresos";
            dgvFinan.Rows[3].Cells[0].Value = "Depreciacion";
            dgvFinan.Rows[4].Cells[0].Value = "V.S";
            dgvFinan.Rows[5].Cells[0].Value = "UAI";
            dgvFinan.Rows[6].Cells[0].Value = "IR";
            dgvFinan.Rows[7].Cells[0].Value = "UDI";
            dgvFinan.Rows[8].Cells[0].Value = "Deprecacion";
            dgvFinan.Rows[9].Cells[0].Value = "FNG";
        }


        private void setData()
        {
            // Las hice double por que da muchos decimales "decimal"
            double.TryParse(txtInvertir.Text, out double invertir);
            int.TryParse(txtPlazo.Text, out int plazo);
            double.TryParse(txtTasa.Text, out double tasa);
            double.TryParse(txtInflacion.Text, out double inflacion);
            double.TryParse(txtValorS.Text, out double valorS);
            double.TryParse(txtIngresos.Text, out double ingresos);
            double.TryParse(txtEgresos.Text, out double egresos);
            double fsn = ingresos;


            for (int i = 0; i < plazo + 1; i++)
            {

                dgvFinan.Columns.Add($"{i}", $"{i}");

            }

            for (int i = 0; i < 9; i++)
            {
                dgvFinan.Rows.Add();
            }

            setFirstColum();


            dgvFinan.Rows[0].Cells[1].Value = ingresos;

            for (int i = 1; i < plazo; i++)
            {

                ingresos = ingresos + (ingresos * (tasa / 100));
                dgvFinan.Rows[1].Cells[i + 1].Value = ingresos;
            }

            for (int i = 1; i < plazo; i++)
            {

                egresos = egresos + (egresos * (inflacion / 100));
                dgvFinan.Rows[2].Cells[i + 1].Value = egresos;
            }


            for (int i = 1; i < plazo; i++)
            {
                double depreciacion = 0;
                depreciacion = depreciacion + (invertir - valorS / plazo);
                dgvFinan.Rows[3].Cells[i + 1].Value = depreciacion;
            }

            dgvFinan.Rows[4].Cells[dgvFinan.ColumnCount - 1].Value = valorS;

            for (int i= 2;i<plazo+1; i++)
            {
                //double uai = 0;
                double ingreso = (double)dgvFinan.Rows[1].Cells[i].Value;
                double egreso = (double)dgvFinan.Rows[2].Cells[i].Value;
                dgvFinan.Rows[5].Cells[i].Value =ingreso - egreso ;
            }

            for(int i = 2; i<plazo +1; i++)
            {
                double ir = 0;
                ir = ir + (((double)dgvFinan.Rows[5].Cells[i].Value)*0.30);
                dgvFinan.Rows[6].Cells[i].Value =ir;
            }

            for (int i = 2; i < plazo + 1; i++)
            {
                double udi = 0;
                udi = (double)dgvFinan.Rows[5].Cells[i].Value - (double)dgvFinan.Rows[6].Cells[i].Value;
                dgvFinan.Rows[7].Cells[i].Value = udi;
            }

            for (int i = 1; i < plazo; i++)
            {
                double depreciacion = 0;
                depreciacion = depreciacion + (invertir - valorS / plazo);
                dgvFinan.Rows[8].Cells[i + 1].Value = depreciacion;
            }

            dgvFinan.Rows[9].Cells[1].Value = fsn * -1;

            for (int i = 2; i < plazo + 1; i++)
            {
                double fne = 0;
                fne = (double)dgvFinan.Rows[7].Cells[i].Value + (double)dgvFinan.Rows[8].Cells[i].Value;
                dgvFinan.Rows[9].Cells[i].Value = fne;
            }

            double vpn = 0;

            for (int i = 2; i<plazo + 1; i++)
            {

               // vpn =+  (double)dgvFinan.Rows[9].Cells[i].Value;

            }

            lblVPN.Text += vpn;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
