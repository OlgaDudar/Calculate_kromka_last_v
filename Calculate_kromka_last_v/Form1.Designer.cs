﻿namespace Calculate_kromka_last_v
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_width = new System.Windows.Forms.TextBox();
            this.txb_height = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.btn_draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Table = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Table.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
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
            // lbl_total
            // 
            resources.ApplyResources(this.lbl_total, "lbl_total");
            this.lbl_total.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total.Name = "lbl_total";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Table
            // 
            this.Table.Controls.Add(this.tabPage1);
            this.Table.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.Table, "Table");
            this.Table.Name = "Table";
            this.Table.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_test);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // dgv_test
            // 
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgv_test, "dgv_test");
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.RowTemplate.Height = 24;
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Table.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTableToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.TextBox txb_width;
        private System.Windows.Forms.TextBox txb_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TabControl Table;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem printTableToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_test;
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
    }
}

