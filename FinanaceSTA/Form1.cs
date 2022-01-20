using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanaceSTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            answerTb.Multiline = true;
            answerTb.ScrollBars = ScrollBars.Both;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = null;

            try
            {
                sqlCon = new SqlConnection("Server=DESKTOP-17VOE83;Database=FinanceSTA;Trusted_Connection=True;");
                sqlCon.Open(); // open a connection to the data base specified by sqlCon
                String symbol = tickerTb.Text;

                SqlCommand sqlCmd = new SqlCommand("spGetPrcForSymbol", sqlCon);  
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@StartDate", System.Data.SqlDbType.Date).Value = fromTb;
                sqlCmd.Parameters.Add("@EndDate", System.Data.SqlDbType.Date).Value = toTb;
                sqlCmd.Parameters.Add("@Ticker", System.Data.SqlDbType.VarChar).Value = symbol;
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "prices");
                chrtPrices.DataSource = dataset.Tables[0];
                var table = dataset.Tables[0];
                int nrPoints = table.Rows.Count;
                for (int ii = 0; ii < nrPoints; ++ii)
                {
                    chrtPrices.Series[0].Points.AddXY(table.Rows[ii][0], table.Rows[ii][1]);
                }
                Form1.ActiveForm.Text = symbol + " Closing Prices";
                dgvDump.DataSource = table;
            }

            catch (Exception ex)

            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally

            {

                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)

                    sqlCon.Close();

            }

        }
    }
}
