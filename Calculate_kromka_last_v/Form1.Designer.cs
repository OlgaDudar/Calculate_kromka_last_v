namespace Calculate_kromka_last_v
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uKRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_push = new System.Windows.Forms.Button();
            this.cmb_material = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_width = new System.Windows.Forms.TextBox();
            this.txb_height = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.btn_draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElementToolStripMenuItem,
            this.saveToTableToolStripMenuItem,
            this.printTableToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // addElementToolStripMenuItem
            // 
            this.addElementToolStripMenuItem.Name = "addElementToolStripMenuItem";
            resources.ApplyResources(this.addElementToolStripMenuItem, "addElementToolStripMenuItem");
            this.addElementToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // saveToTableToolStripMenuItem
            // 
            this.saveToTableToolStripMenuItem.Name = "saveToTableToolStripMenuItem";
            resources.ApplyResources(this.saveToTableToolStripMenuItem, "saveToTableToolStripMenuItem");
            this.saveToTableToolStripMenuItem.Click += new System.EventHandler(this.saveToTableToolStripMenuItem_Click);
            // 
            // printTableToolStripMenuItem
            // 
            this.printTableToolStripMenuItem.Name = "printTableToolStripMenuItem";
            resources.ApplyResources(this.printTableToolStripMenuItem, "printTableToolStripMenuItem");
            this.printTableToolStripMenuItem.Click += new System.EventHandler(this.printTableToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uKRToolStripMenuItem,
            this.eNGToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // uKRToolStripMenuItem
            // 
            this.uKRToolStripMenuItem.Name = "uKRToolStripMenuItem";
            resources.ApplyResources(this.uKRToolStripMenuItem, "uKRToolStripMenuItem");
            this.uKRToolStripMenuItem.Click += new System.EventHandler(this.uKRToolStripMenuItem_Click);
            // 
            // eNGToolStripMenuItem
            // 
            this.eNGToolStripMenuItem.Name = "eNGToolStripMenuItem";
            resources.ApplyResources(this.eNGToolStripMenuItem, "eNGToolStripMenuItem");
            this.eNGToolStripMenuItem.Click += new System.EventHandler(this.eNGToolStripMenuItem_Click);
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.drawArea, "drawArea");
            this.drawArea.Name = "drawArea";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_push);
            this.panel2.Controls.Add(this.cmb_material);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_count);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txb_width);
            this.panel2.Controls.Add(this.txb_height);
            this.panel2.Controls.Add(this.txb_Name);
            this.panel2.Controls.Add(this.btn_draw);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_push
            // 
            this.btn_push.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.btn_push, "btn_push");
            this.btn_push.Name = "btn_push";
            this.btn_push.UseVisualStyleBackColor = false;
            this.btn_push.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_material
            // 
            this.cmb_material.FormattingEnabled = true;
            this.cmb_material.Items.AddRange(new object[] {
            resources.GetString("cmb_material.Items"),
            resources.GetString("cmb_material.Items1")});
            resources.ApplyResources(this.cmb_material, "cmb_material");
            this.cmb_material.Name = "cmb_material";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_count
            // 
            resources.ApplyResources(this.txt_count, "txt_count");
            this.txt_count.Name = "txt_count";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txb_width
            // 
            resources.ApplyResources(this.txb_width, "txb_width");
            this.txb_width.Name = "txb_width";
            this.txb_width.Enter += new System.EventHandler(this.txb_width_Enter);
            // 
            // txb_height
            // 
            resources.ApplyResources(this.txb_height, "txb_height");
            this.txb_height.Name = "txb_height";
            this.txb_height.Enter += new System.EventHandler(this.txb_height_Enter);
            // 
            // txb_Name
            // 
            resources.ApplyResources(this.txb_Name, "txb_Name");
            this.txb_Name.Name = "txb_Name";
            // 
            // btn_draw
            // 
            this.btn_draw.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btn_draw, "btn_draw");
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.UseVisualStyleBackColor = false;
            this.btn_draw.Click += new System.EventHandler(this.DrawElement);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            resources.ApplyResources(this.previewToolStripMenuItem, "previewToolStripMenuItem");
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // lbl_total
            // 
            resources.ApplyResources(this.lbl_total, "lbl_total");
            this.lbl_total.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total.Name = "lbl_total";
            // 
            // lb_total
            // 
            resources.ApplyResources(this.lb_total, "lb_total");
            this.lb_total.Name = "lb_total";
            // 
            // dgv_test
            // 
            this.dgv_test.AllowUserToResizeColumns = false;
            this.dgv_test.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgv_test, "dgv_test");
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.RowTemplate.Height = 24;
            this.dgv_test.TabStop = false;
            this.dgv_test.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_test_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_test);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTableToolStripMenuItem;
        private System.Windows.Forms.Panel drawArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.TextBox txb_width;
        private System.Windows.Forms.TextBox txb_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.ToolStripMenuItem printTableToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNGToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_material;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.DataGridView dgv_test;
        private System.Windows.Forms.Button btn_push;
    }
}

