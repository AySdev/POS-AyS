using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace POS_AyS
{
    public partial class frmAcerca : Form
    {

        //clsCaracteristicas caracteristicas = new clsCaracteristicas();
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void Acerca_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            clsCaracteristicas caracteristicas = new clsCaracteristicas();

            //txtInfoCpu = null;
            //txtInfoOs = null;
            //txtInfoVid = null;

            caracteristicas.video();

            caracteristicas.cpu();

            caracteristicas.os();
        }
    }
}
