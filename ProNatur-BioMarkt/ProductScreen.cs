using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProNatur_BioMarkt
{
    public partial class ProductScreen : Form
    {
        // Erstellen einer Instanz der SqlConnection-Klasse für die Datenbankverbindung
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\domin\Documents\ProNatur Biomarkt.mdf; Integrated Security=True; Connect Timeout=30");

        public ProductScreen()
        {
            // Initialisieren des Windows Forms-Components
            InitializeComponent();

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

        private void ProductScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string productname = textBoxProductName.Text;
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
