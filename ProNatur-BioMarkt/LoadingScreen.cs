using System.Windows.Forms;

namespace ProNatur_BioMarkt
{
    public partial class LoadingScreen : Form
    {

        private int loadingBarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, System.EventArgs e)
        {
            loadingBarTimer.Start();
        }

        private void loadingBarTimer_Tick(object sender, System.EventArgs e)
        {

            loadingBarValue += 1;
            loadingProgressBar.Value = loadingBarValue;
            lblLoadingProgress.Text = loadingProgressBar.Value.ToString() + "%";

            if (loadingBarValue >= loadingProgressBar.Maximum)
            {
                loadingBarTimer.Stop();
            }

        }
    }
}
