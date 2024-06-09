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
/*SEMANUR ÜÇDAĞ 21430070045 GÖRSEL PROGRAMLAMA UYGULAMALARI FİNAL PROJESİ 3. SINIF*/
namespace Klasordosya_SemanurUcdag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FileInfo[] dosyalar;
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                dosyalar = di.GetFiles("*.txt");
                foreach(FileInfo file in dosyalar)
                {
                    listBox1.Items.Add(file.FullName);
                }
            }
        }
    }
}
