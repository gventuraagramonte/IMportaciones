using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Data.SqlClient;


namespace IMportaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;
        }

        string nombre_ext = " ";

        private void button1_Click(object sender, EventArgs e)
        {
            Persiana_Abierta();
        }

        private void Persiana_Abierta()
        {
            panel1.Visible = true;
            //panel1.Height = 0;
            
        }

        private void Persiana_Cerrada()
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_panel_Click(object sender, EventArgs e)
        {
            Persiana_Cerrada();
        }

        private void btn_file_veritrade_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivo Excel|*.xls;*xlsx;*xlsm";

            if(backgroundWorker1.IsBusy != true)
            {

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("Exito");

                    nombre_ext = System.Environment.MachineName + (DateTime.Now.ToString("_ddMMyyy_hhmmss_")) + openFileDialog1.SafeFileName;
                    System.IO.File.Copy(openFileDialog1.FileName, @"\\srv0005\Veritrade\" + nombre_ext, true);

                    label1.Text = openFileDialog1.FileName;

                    backgroundWorker1.RunWorkerAsync();

                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Subir_ExcelVeritrade_a_Tb_Temporal();
        }



        private void Subir_ExcelVeritrade_a_Tb_Temporal()
        {
            Class1 servidor = new Class1();
            string dor = servidor.servidor();
            string db = servidor.Database();
            string username = servidor.UID();
            string pwd = servidor.PWD();

            Console.WriteLine(dor);
            SqlConnection sqlConn = new SqlConnection("Data Source ="+dor+"; Initial Catalog="+db+"; UID="+username+"; PWD="+pwd);

        }
    }
}
