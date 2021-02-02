using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fim_Insura.Forms;

namespace Fim_Insura
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        
        int startProgress = 0;
        private void loadingPage_Tick(object sender, EventArgs e)
        {
            
            startProgress += 1;
            progressBar.Value = startProgress;

            if (progressBar.Value == 50)
            {
                progressBar.Value = 0;
                loadingPage.Stop();
                this.Hide();
                landing landPage = new landing();
                landPage.Show();

            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            loadingPage.Start();
        }

    }
}
