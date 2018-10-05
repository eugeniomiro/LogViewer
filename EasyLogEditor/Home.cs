using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    // https://docs.microsoft.com/en-us/dotnet/standard/base-types/grouping-constructs-in-regular-expressions#matched_subexpression
                    Regex regex = new Regex("(.*)JLTx\\((.*)\\):(JL_[(A-Z)_]*)\\((.*)\\)");

                    var match = regex.Match(line);

                    //if (line.Contains("JLTx"))
                    //{
                    //    string[] JLTx = line.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    //    listView1.Items.Add(JLTx[0]);
                    //    listView1.Items[listView1.Items.Count - 1].SubItems.Add(JLTx[1]);                            
                    //}
                    if (match.Success)
                    {
                        var row = listView1.Items.Add(line);
                        foreach (var item in match.Groups)
                        {
                            row.SubItems.Add(item.ToString());
                        }
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

