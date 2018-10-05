using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLogEditor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadLogFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LOG files|*.log";
            ofd.Title = "Load Log File";
            var dialogResult = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                foreach (var line in File.ReadAllLines(ofd.FileName))               
                {
                    if (line.Contains("JLTx"))
                    {




                        string[] JLTx = line.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        listView1.Items.Add(JLTx[0]);
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(JLTx[1]);    
                        
                    }
                }
                //MakeReadable();
            }
        }
        private void MakeReadable()
        {
            
        }
    }
}

