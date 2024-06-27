using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int indice = 100;
        public int[] CodigoPostal = new int[indice];
        public double[] PesoG = new double[indice];
        public int[] EmpresaDist = new int[indice];
        public double[] Pago = new double[indice];
        public bool[] Certif = new bool[indice];
        public int Cont = 0;
        public void Despachar(int codigoPostal, double pesoG, int empresaDist, bool certif, ref double costBase, ref double IVA, ref double costFinal)
        {
            CodigoPostal[Cont] = codigoPostal;
            PesoG[Cont] = pesoG;
            EmpresaDist[Cont] = empresaDist;
            Certif[Cont] = certif;
            Pago[Cont] = costFinal;
            Cont++;

        }
        private void AtencionCliente_Click(object sender, EventArgs e)
        {
            FormDespacho Nacho = new FormDespacho();
            int codp, idemp;
            double pesog, costobase, iva, costfinal;
            bool certif = false;
            while (Nacho.ShowDialog() == DialogResult.OK)
            {
                codp = Convert.ToInt32(Nacho.textpostal.Text);
                pesog = Convert.ToDouble(Nacho.textPeso.Text);
                idemp = Convert.ToInt32(Nacho.NumEmp.Text);
                certif = Nacho.Chbcertificada.Checked;

                if (certif == true)
                {
                    costobase = pesog * 1;
                }
                else
                {
                    costobase = pesog * 0.5;
                }
                iva = costobase * 0.21;
                costfinal = iva + costobase;
                Despachar(codp, pesog, idemp, certif, ref costobase, ref iva, ref costfinal);

                MessageBox.Show($"base: {costobase}, iva: {iva}, final: {costfinal}");




            }
        }
    }
}