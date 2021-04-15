using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crypto_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            KeyGenerator keyGen = new KeyGenerator();
            txtKey.Text = keyGen.generateKey();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Please enter or generate key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEncrypt.Checked)
            {
                rbDecrypt.Checked = false;
            }
        
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDecrypt.Checked)
            {
                rbEncrypt.Checked = false;
            }
           
        }

    }
}
