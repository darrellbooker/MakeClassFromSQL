using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace MakeClassFromSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //load settings
            if (String.IsNullOrEmpty(Properties.Settings.Default.ip) == false) { txtIP.Text = Properties.Settings.Default.ip;}
            if (String.IsNullOrEmpty(Properties.Settings.Default.db) == false) {txtDB.Text = Properties.Settings.Default.db;}
            if (String.IsNullOrEmpty(Properties.Settings.Default.username) == false) {txtUserID.Text = Properties.Settings.Default.username;}
            if (String.IsNullOrEmpty(Properties.Settings.Default.password) == false) {txtPassword.Text = Properties.Settings.Default.password;}
        }
        private string MyProp;

        public string MyProp1
        {
            get { return MyProp; }
            set { MyProp = value; }
        }

        private void cmdGenerateClass_Click(object sender, EventArgs e)
        {

            //verify credentials
            if (String.IsNullOrEmpty(txtDB.Text)==true  || String.IsNullOrEmpty(txtIP.Text) ==true || String.IsNullOrEmpty(txtPassword.Text)==true || String.IsNullOrEmpty(txtUserID.Text)==true) {
                MessageBox.Show ("Please enter the database credentials");
                return;
            }

            //update user settings
            Properties.Settings.Default.ip = txtIP.Text;
            Properties.Settings.Default.db = txtDB.Text;
            Properties.Settings.Default.username = txtUserID.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.Save();

            StringBuilder sbClass = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            var strConnection = "Data Source=" + txtIP.Text + ";Initial Catalog=" + txtDB.Text + ";Persist Security Info=True;User ID=" + txtUserID.Text + ";Password=" + txtPassword.Text;
            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlDataAdapter da = new SqlDataAdapter(textBox2.Text, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (rbC.Checked)
                {
                    sbClass.Append("public class " + ds.Tables[0].TableName);
                    sbClass.Append("\r\n{");
                }
                else
                {    
                    sbClass.Append("Public Class " + ds.Tables[0].TableName);
                    sbClass.Append("\r\n");                
                }
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    if (rbC.Checked)
                    {
                        if (chkQuickProperties.Checked)
                            sb.Append("\r\npublic " + dc.DataType.ToString() + " " + dc.ColumnName + "{ get; set; }");
                        else
                        {
                            sb2.Append("\r\nprivate " + dc.DataType.ToString() + " _" + dc.ColumnName + ";");
                            sb.Append("\r\npublic " + dc.DataType.ToString() + " " + dc.ColumnName + "\r\n{ \r\nget { return _" + dc.ColumnName + "; }\r\nset { " + dc.ColumnName + " = value; }\r\n}");
                        }
                    }
                    else
                    {
                        //vb code
                        sb2.Append("\r\nPrivate _" + dc.ColumnName + " As " + dc.DataType.ToString());
                        sb.Append("\r\nPublic Property " + dc.ColumnName + "() As " + dc.DataType.ToString() + 
                            "\r\nGet\r\nReturn _" + dc.ColumnName + 
                            "\r\nEnd Get\r\nSet(ByVal value As " + dc.DataType.ToString() + ")" +
                            "\r\n_" + dc.ColumnName + " = value\r\nEnd Set\r\nEnd Property\r\n");
                    }
                }
                sb2.Append("\r\n");
                sb.Append("\r\n" + (rbC.Checked ? "}" : "End Class"));
            }
            textBox3.Text = sbClass.ToString() + sb2.ToString() + sb.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chkQuickProperties.Enabled = !rbVB.Checked;
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            chkQuickProperties.Enabled = !rbVB.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
            MessageBox.Show("Copied");
        }
    }
}
