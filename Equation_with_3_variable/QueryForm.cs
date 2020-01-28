using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csEquationSolver
{
    public partial class QueryForm : Form
    {
        public string[] Data;
        public DataTable table;
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Fname");
            table.Columns.Add("Lname");
            table.Columns.Add("Age");
            table.Columns.Add("City");
            table.Columns.Add("EQ1");
            table.Columns.Add("EQ2");
            table.Columns.Add("EQ3");
            table.Columns.Add("Res1");
            table.Columns.Add("Res2");
            table.Columns.Add("Res3");

            foreach (string s in Data)
            {
                string[] E = s.Split(',');
                table.Rows.Add(E);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           DataRow[] rows= RunQuery();
         DataTable   prop = table.Clone();
            prop.Clear();
            foreach(DataRow row in rows)
            {
                prop.Rows.Add(row.ItemArray);

            }
            dataGridView1.DataSource = prop;
            dataGridView1.Refresh();
        }
        private DataRow[] RunQuery()
        {
            string expression = "";
         
            foreach ( var s in cheklist.CheckedItems)
            {
                if(s.ToString()== "نام")
                {
                    expression += "Fname = '" + txtfname.Text + "'";
                }
                if (s.ToString() == "نام خانوادگی")
                {
                   if(expression!="") expression += " and Lname = '" + txtlname.Text + "'";else expression += "Lname = '" + txtlname.Text + "'";
                }
                if (s.ToString() == "شهر")
                {
                    if (expression != "") expression += " and City = '" + txtcity.Text + "'"; else expression += "City = '" + txtcity.Text + "'";
                }
                if (s.ToString() == "سن بالای یک مقدار")
                {
                    if (expression != "") expression += " and Age >= " + txtfrom.Text ; else expression += "Age >=" + txtfrom.Text ;
                }
                if (s.ToString() == "سن کمتر از یک مقدار")
                {
                    if (expression != "") expression += " and Age <= " + txtto.Text; else expression += "Age <=" + txtto.Text;
                }
                if (s.ToString() == "معادلات")
                {
                    if (expression != "") expression += " and (EQ1  = '" + txtmoadelet.Text + "' or EQ2  = '" + txtmoadelet.Text + "' or EQ3  = '" + txtmoadelet.Text + "')"; else expression += "(EQ1 = '" + txtmoadelet.Text + "' or EQ2 = '" + txtmoadelet.Text + "' or EQ3 = '" + txtmoadelet.Text + "')";
                }
                if (s.ToString() == "جواب معادلات")
                {
                    if (expression != "") expression += " and (Res1  = '" + txtresulte.Text + "' or Res2  = '" + txtresulte.Text + "' or Res3  = '" + txtresulte.Text + "')"; else expression += "(Res1 = '" + txtresulte.Text + "' or Res2 = '" + txtresulte.Text + "' or Res3 = '" + txtresulte.Text + "')";
                }
            }
            return table.Select(expression);

        }
    }
}
