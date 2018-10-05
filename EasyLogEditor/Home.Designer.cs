namespace EasyLogEditor
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LoadLogFilebtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.matchingLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LoadLogFilebtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 456);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // LoadLogFilebtn
            // 
            this.LoadLogFilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadLogFilebtn.BackColor = System.Drawing.Color.Green;
            this.LoadLogFilebtn.Location = new System.Drawing.Point(1046, 8);
            this.LoadLogFilebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadLogFilebtn.Name = "LoadLogFilebtn";
            this.LoadLogFilebtn.Size = new System.Drawing.Size(111, 28);
            this.LoadLogFilebtn.TabIndex = 0;
            this.LoadLogFilebtn.Text = "Load Log File";
            this.LoadLogFilebtn.UseVisualStyleBackColor = false;
            this.LoadLogFilebtn.Click += new System.EventHandler(this.LoadLogFilebtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matchingLine,
            this.group1,
            this.group2,
            this.group3,
            this.group4,
            this.group5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1165, 400);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // matchingLine
            // 
            this.matchingLine.Text = "matching line";
            this.matchingLine.Width = 300;
            // 
            // group1
            // 
            this.group1.Text = "first group";
            this.group1.Width = 122;
            // 
            // group2
            // 
            this.group2.Text = "second group";
            this.group2.Width = 110;
            // 
            // group3
            // 
            this.group3.Text = "third group";
            this.group3.Width = 136;
            // 
            // group4
            // 
            this.group4.Text = "fourth group";
            this.group4.Width = 103;
            // 
            // group5
            // 
            this.group5.Text = "fifth group";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 456);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LoadLogFilebtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader matchingLine;
        private System.Windows.Forms.ColumnHeader group2;
        private System.Windows.Forms.ColumnHeader group1;
        private System.Windows.Forms.ColumnHeader group3;
        private System.Windows.Forms.ColumnHeader group4;
        private System.Windows.Forms.ColumnHeader group5;
    }
}