using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EnviosExpress
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPresentacion());
        }
    }

    internal static class BordesRedondeados
    {
        private const int Radio = 4;

        public static void Aplicar(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox || control is Button)
                {
                    AplicarAControl(control);
                }

                DataGridView tabla = control as DataGridView;
                if (tabla != null)
                {
                    tabla.EnableHeadersVisualStyles = false;
                    tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    tabla.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                    tabla.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    tabla.DefaultCellStyle.BackColor = Color.White;
                    tabla.BackgroundColor = Color.White;
                    tabla.GridColor = Color.LightGray;
                    tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    tabla.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                    tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 238, 248);
                    tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                }

                Aplicar(control);
            }
        }

        private static void AplicarAControl(Control control)
        {
            Button boton = control as Button;
            if (boton != null)
            {
                bool esAzul = boton.BackColor == Color.DodgerBlue;
                boton.Font = new Font("Segoe UI", boton.Font.Size >= 14F ? 14F : 10F, FontStyle.Bold);
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 2;
                boton.FlatAppearance.BorderColor = esAzul
                    ? Color.FromArgb(0, 90, 180)
                    : Color.FromArgb(80, 80, 80);
                boton.BackColor = esAzul ? Color.DodgerBlue : Color.White;
                boton.ForeColor = esAzul ? Color.White : Color.Black;
                boton.FlatAppearance.MouseOverBackColor = esAzul
                    ? Color.FromArgb(24, 132, 220)
                    : Color.FromArgb(235, 242, 250);
                boton.FlatAppearance.MouseDownBackColor = esAzul
                    ? Color.FromArgb(20, 115, 195)
                    : Color.FromArgb(220, 232, 245);
                boton.UseVisualStyleBackColor = false;
            }

            ActualizarRegion(control);
            control.Resize += (sender, args) => ActualizarRegion(control);
        }

        private static void ActualizarRegion(Control control)
        {
            if (control.Width <= 0 || control.Height <= 0)
                return;

            int radio = Math.Min(Radio, Math.Min(control.Width, control.Height) / 2);
            using (GraphicsPath ruta = new GraphicsPath())
            {
                ruta.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
                ruta.AddArc(control.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
                ruta.AddArc(control.Width - radio * 2, control.Height - radio * 2, radio * 2, radio * 2, 0, 90);
                ruta.AddArc(0, control.Height - radio * 2, radio * 2, radio * 2, 90, 90);
                ruta.CloseFigure();
                control.Region = new Region(ruta);
            }
        }
    }
}
