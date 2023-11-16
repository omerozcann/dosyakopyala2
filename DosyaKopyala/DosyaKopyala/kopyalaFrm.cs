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

namespace DosyaKopyala
{
    public partial class kopyalaFrm : Form
    {
        public kopyalaFrm()
        {
            InitializeComponent();
            if (File.Exists("kaynak.txt") == true && File.Exists("hedef.txt") == true)
            {
                String k = File.ReadAllText("kaynak.txt");
                String h = File.ReadAllText("hedef.txt");
                kaynaktxt.Text = k;
                hedeftxt.Text = h;
            }

        }

        private void kaynaksecbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb=new FolderBrowserDialog();
            fb.ShowDialog();
            if(fb.SelectedPath!="")
            {
                kaynaktxt.Text= fb.SelectedPath;
            }
            File.WriteAllText("kaynak.txt",kaynaktxt.Text);
        }

        private void hedefsecbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            if (fb.SelectedPath != "")
            {
                hedeftxt.Text = fb.SelectedPath;
            }
            File.WriteAllText("hedef.txt", hedeftxt.Text);
        }

        private void kopyalabtn_Click(object sender, EventArgs e)
        {
            String[] dizi = Directory.GetFiles(kaynaktxt.Text,"*.*", SearchOption.AllDirectories);
            durumPb.Minimum = 0;
            durumPb.Maximum=dizi.Length-1;
            for(int i=0;i<dizi.Length;i++)
            {                
                String h = hedeftxt.Text + "\\" + Path.GetFileName(dizi[i]);
                File.Copy(dizi[i], h,true);
                durumPb.Value = i;
                durumlbl.Text = dizi[i].Substring(0,30);
            }
        }

        private void kaynaktxt_MouseClick(object sender, MouseEventArgs e)
        {
            kaynaktxt.Clear();
        }

        private void hedeftxt_MouseClick(object sender, MouseEventArgs e)
        {
            hedeftxt.Clear();
        }

        private void hakkindabtn_Click(object sender, EventArgs e)
        {
            HakkindaFrm h = new HakkindaFrm();
            h.Show();
        }
    }
}
