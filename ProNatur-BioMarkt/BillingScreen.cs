using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_BioMarkt
{
    public partial class BillingScreen : Form
    {

        IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-GB");
        // Erstellen einer Instanz der SqlConnection-Klasse für die Datenbankverbindung
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\domin\Documents\ProNatur Biomarkt.mdf; Integrated Security=True; Connect Timeout=30");
        private int lastSelectedProduct = 0;

        public BillingScreen()
        {
            InitializeComponent();
            ShowProducts();
        }

        private void btnBillingSave_Click(object sender, EventArgs e)
        {


            string billingFirstname = textBoxBillingFirstname.Text;
            string billingProducts = comboBoxBillingProducts.Text;
            float billingPrice = float.Parse(textBoxBillingPrice.Text.Replace(",", "."), provider);

            if (billingFirstname == "" || textBoxBillingPrice.Text == "" || billingPrice == null)
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                return;
            }

            string query = "";

            if (lastSelectedProduct != 0)
            {
                query = string.Format("UPDATE BILLING SET FIRSTNAME='{0}', PRODUCT='{1}', PRICE='{2}' WHERE ID={3}", billingFirstname, billingProducts, billingPrice, lastSelectedProduct);
            }
            else
            {
                query = string.Format("INSERT INTO BILLING VALUES ('{0}', '{1}', '{2}')", billingFirstname, billingProducts, billingPrice);

            }

            ExecuteQuery(query);

            ClearAllFields();
            lastSelectedProduct = 0;
            // Update DataGridView
            ShowProducts();

        }

        private void btnBillingDelete_Click(object sender, EventArgs e)
        {

            if (lastSelectedProduct == 0)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt aus!");
                return;
            }

            string query = string.Format("DELETE FROM BILLING WHERE ID={0};", lastSelectedProduct);
            ExecuteQuery(query);

            ClearAllFields();

            // Update DataGridView
            ShowProducts();

        }

        private void btnBillingClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void billingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBillingFirstname.Text = billingDGV.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxBillingProducts.Text = billingDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBillingPrice.Text = billingDGV.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedProduct = (int)billingDGV.SelectedRows[0].Cells[0].Value;

            btnBillingSave.Text = "Update";

            Console.WriteLine(lastSelectedProduct);
        }

        private void ShowProducts()
        {
            databaseConnection.Open();

            string query = "SELECT * FROM BILLING";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            billingDGV.DataSource = dataSet.Tables[0];

            billingDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ClearAllFields()
        {

            textBoxBillingFirstname.Text = "";
            comboBoxBillingProducts.Text = "";
            textBoxBillingPrice.Text = "";
            btnBillingSave.Text = "Hinzufügen";
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.ShowDialog();
        }
    }
}
