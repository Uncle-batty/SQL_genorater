using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_code_genorater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Genorate_Update_Click(object sender, EventArgs e)
        {
            string sql_statment = "Update table " + txt_TableName.Text + "\n SET " + txt_ColumName.Text + " = '" + txt_Value.Text + "'\n WHERE " + txt_conclo.Text + " = '" + txt_con.Text + "';";
            MessageBox.Show(sql_statment);
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Gb_Promptds.Visible= true;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Gb_insert.Visible= true;
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_gen_insert_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            string filepath = openFileDialog1.FileName;
            StreamReader reader = new StreamReader(File.OpenRead(filepath));
            string table_name = "";
            string SQL = "INSERT INTO " + table_name + "\n VALUES";
            List<string> listA = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                foreach (var item in values)
                {
                    listA.Add(item);
                }
                foreach (var coloumn1 in listA)
                {
                    SQL = SQL + "('" + coloumn1.Trim() + "',";
                }
                SQL = SQL + "),";
            }
            
        }
    }
}
