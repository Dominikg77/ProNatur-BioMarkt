using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ProNatur_BioMarkt
{
    public partial class ProductScreen : Form
    {
        IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-GB");
        // Erstellen einer Instanz der SqlConnection-Klasse für die Datenbankverbindung
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\domin\Documents\ProNatur Biomarkt.mdf; Integrated Security=True; Connect Timeout=30");
        private int lastSelectedProduct = 0;

        public ProductScreen()
        {
            InitializeComponent();
            // Show products in DataGridView on load
            ShowProducts();

        }

        private void ProductScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnProductSaveAndUpdate_Click(object sender, EventArgs e)
        {

            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            float productPrice = float.Parse(textBoxProductPrice.Text.Replace(",", "."), provider);

            if (productName == "" || productBrand == "" 
                || textBoxProductPrice.Text == "" || productCategory == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                return;
            }

            string query = "";

            if(lastSelectedProduct == 0)
            {
               query = string.Format("UPDATE PRODUCTS SET NAME='{0}', BRAND='{1}', CATEGORY='{2}', PRICE='{3}' WHERE ID={4};", productName, productBrand, productCategory, productPrice, lastSelectedProduct);
            } else
            {
                query = string.Format("INSERT INTO PRODUCTS VALUES ('{0}', '{1}', '{2}', '{3}')", productName, productBrand, productCategory, productPrice);
            }

            ExecuteQuery(query);

            ClearAllFields();
            lastSelectedProduct = 0;
            // Update DataGridView
            ShowProducts();

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

            if(lastSelectedProduct == 0)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt aus!");
                return;
            }   

            string query = string.Format("DELETE FROM PRODUCTS WHERE ID={0};", lastSelectedProduct);
            ExecuteQuery(query);

            ClearAllFields();

            // Update DataGridView
            ShowProducts();

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void productsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProduct = (int)productsDGV.SelectedRows[0].Cells[0].Value;

            btnProductSave.Text = "Update";

            Console.WriteLine(lastSelectedProduct);
        }

        /// <summary>
        /// Help Functions
        /// </summary>
        private void ShowProducts()
        {
            // Öffnen der Datenbankverbindung
            databaseConnection.Open();

            // SQL-Abfrage zum Auswählen aller Zeilen aus der Tabelle "Products"
            string query = "SELECT * FROM Products";

            // Erstellen eines SqlDataAdapter-Objekts zum Ausführen der Abfrage und Abrufen der Daten
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            // Erstellen eines DataSet-Objekts zum Speichern der abgerufenen Daten
            DataSet dataSet = new DataSet();

            // Füllen des DataSet mit den Daten aus der Datenbank mithilfe des SqlDataAdapter
            sqlDataAdapter.Fill(dataSet);

            // Setzen der DataSource für ein DataGridView-Steuerelement, um die Daten anzuzeigen
            productsDGV.DataSource = dataSet.Tables[0];

            // Id Spalte ausblenden
            productsDGV.Columns[0].Visible = false;

            // Schließen der Datenbankverbindung
            databaseConnection.Close();
        }

        private void ClearAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            textBoxProductPrice.Text = "";
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
            btnProductSave.Text = "Hinzufügen";

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
