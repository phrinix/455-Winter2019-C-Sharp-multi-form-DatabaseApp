using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Prateek_Project
{
    public partial class DatabaseAppF : Form
    {

        static string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb;Persist Security Info=False";
        OleDbConnection conn = new OleDbConnection(constr);
        OleDbCommand cmd = new OleDbCommand();

        public DatabaseAppF()
        {
            InitializeComponent();
            runqueryMSI.ShortcutKeys = Keys.F5;
            runqueryMSI.ShowShortcutKeys = true;
            readfileMSI.ShortcutKeys = Keys.F9;
            readfileMSI.ShowShortcutKeys = true;
        }

        private void exitMSI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectMSI_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                connectMSI.Enabled = false;
                disconnectMSI.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Connection Failed!!");
            }
        }

        private void disconnectMSI_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                disconnectMSI.Enabled = false;
                connectMSI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Disconnection Failed!!");
            }
        }

        private void runqueryMSI_Click(object sender, EventArgs e)
        {
            try
            {
                if (disconnectMSI.Enabled == true)
                {
                    DataTable dataT = new DataTable();
                    cmd.CommandText = inputRTB.Text;
                    OleDbDataAdapter data = new OleDbDataAdapter(cmd);
                    data.Fill(dataT);
                    data.Dispose();
                    resultDG.DataSource = dataT;
                    StreamWriter sqlFile = File.AppendText("sqlFile.txt");
                    DateTime now = DateTime.Now;
                    sqlFile.Write(now.ToString("F") + "      " + inputRTB.Text + "\n");
                    sqlFile.Close();
                }
                else
                {
                    MessageBox.Show("Connect to database");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readfileMSI_Click(object sender, EventArgs e)
        {
            ReadFileF readform = new ReadFileF();
            readform.ShowDialog();
        }
    }
}
