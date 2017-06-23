﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_kromka_last_v
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Width"));
            dt.Columns.Add(new DataColumn("Height"));
            dt.Columns.Add("Image", typeof(byte[]));
            dt.Columns.Add(new DataColumn("Length for clue"));

            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            InitializeComponent();

            

        }

        DataTable dt = new DataTable();
        
        public int width;
        public int height;
        internal Rect r1;
        public string ident;
   
        System.Drawing.Printing.PrintDocument pd = new PrintDocument();


        public string TextLabel
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        private void addElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "l_";
            TextLabel = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(textBox1.Text);
            height = Convert.ToInt32(textBox2.Text);
            ident = textBox3.Text;
            r1 = new Rect(ident, width, height, panel1, this);
            r1.Draw();

        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.panel1.BackgroundImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.panel1.BackgroundImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                  break;

              case 3:
                  this.panel1.BackgroundImage.Save(fs,
                     System.Drawing.Imaging.ImageFormat.Gif);
                  break;
          }

                fs.Close();
            }
        }

        private void saveToTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DataRow row = dt.NewRow();
            row["Name"] = r1.name;
            row["Width"] = r1.width;
            row["Height"] = r1.height;
            row["Image"] = imageToByteArray(r1.icone);
            row["Length for clue"] = r1.lenght_for_clue;
            dt.Rows.Add(row);
            dgv_test.DataSource = dt;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void printTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                pd.DocumentName = "Page Title";
                pd.Print();
            }

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int totalLength = 0;
            foreach (DataRow r in dt.Rows)
            {
                totalLength += Convert.ToInt32(r["Length for clue"]);
            }

            DataRow row = dt.NewRow();
            row["Name"] = "";
            row["Width"] = "";
            row["Height"] = "";
            row["Image"] = null;
            row["Length for clue"] = totalLength;
            dt.Rows.Add(row);
            dgv_test.DataSource = dt;
            dgv_test.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Page Print";
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int LeftMargin = e.MarginBounds.Left;
            bool MorePagesToPrint = false;
            int TmpWidth = e.MarginBounds.Width;
           int TopMargin = e.MarginBounds.Top;
            bool FirstPage = true;
            int TotalWidth = 600;
            int Row = 0;
            bool NewPage = false;
            List<int> AColumnLefts = new List<int>();
            List<int> AColumnWidths = new List<int>();
            int HeaderHeight = 25;

            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Near;
            strFormat.LineAlignment = StringAlignment.Center;
            strFormat.Trimming = StringTrimming.EllipsisCharacter;

            if (FirstPage)
            {
                //Draw Header
                e.Graphics.DrawString("Sumary tables", new Font(dgv_test.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left,
                    e.MarginBounds.Top - e.Graphics.MeasureString("Summary tables",
                    new Font(dgv_test.Font, FontStyle.Bold),
                    e.MarginBounds.Width).Height - 13);

                String strDate = DateTime.Now.ToLongDateString() + " " +
                    DateTime.Now.ToShortTimeString();
                //Draw Date
                e.Graphics.DrawString(strDate, new Font(dgv_test.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left +
                    (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                    new Font(dgv_test.Font, FontStyle.Bold),
                    e.MarginBounds.Width).Width),
                    e.MarginBounds.Top - e.Graphics.MeasureString("Summary tables",
                    new Font(new Font(dgv_test.Font, FontStyle.Bold),
                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                //
                int Count = 0;

                foreach (DataGridViewColumn GridCol in dgv_test.Columns)
                {
                  
                    AColumnLefts.Add(LeftMargin);
                    AColumnWidths.Add(TmpWidth);
                    TmpWidth = (int)(Math.Floor((double)((double)GridCol.Width / (double)TotalWidth * (double)TotalWidth * ((double)e.MarginBounds.Width / (double)TotalWidth))));

                    HeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, TmpWidth).Height) + 11;
                 
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                               new Rectangle((int)AColumnLefts[Count], TopMargin,
                               (int)AColumnWidths[Count], HeaderHeight));
                    e.Graphics.DrawRectangle(Pens.Black,
                           new Rectangle((int)AColumnLefts[Count], TopMargin,
                           (int)AColumnWidths[Count], HeaderHeight));

                    e.Graphics.DrawString(GridCol.HeaderText,
                        GridCol.InheritedStyle.Font,
                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                        new RectangleF((int)AColumnLefts[Count], TopMargin,
                        (int)AColumnWidths[Count], HeaderHeight), strFormat);

                    Count++;
                    LeftMargin += TmpWidth;
                }
                TopMargin += HeaderHeight;
            }
            MessageBox.Show(dgv_test.Rows.Count.ToString());
            int CellHeight;
            while (Row < dgv_test.Rows.Count)
            {
                //MessageBox.Show("Ok");
                DataGridViewRow GridRow = dgv_test.Rows[Row];
               CellHeight = GridRow.Height + 5;
                int Count = 0;

                //Check whether the current page settings allo more rows to print
                if (TopMargin + CellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    NewPage = true;
                    FirstPage = false;
                    MorePagesToPrint = true;
                    break;
                }

                else
                {
                    if (NewPage)
                    {
                        
                        //
                        foreach (DataGridViewColumn GridCol in dgv_test.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)AColumnLefts[Count], TopMargin,
                                (int)AColumnWidths[Count], HeaderHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)AColumnLefts[Count], TopMargin, (int)AColumnWidths[Count], HeaderHeight));

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                new RectangleF((int)AColumnLefts[Count], TopMargin,
                                (int)AColumnWidths[Count], HeaderHeight), strFormat);
                            Count++;
                        }
                        NewPage = false;
                        TopMargin += HeaderHeight;
                    }
                    Count = 0;
                    //Draw Columns Contents   

                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        if (Cel.Value != null)
                        {

                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)AColumnLefts[Count], (float)TopMargin,
                                        (int)AColumnWidths[Count], (float)CellHeight), strFormat);
                        }
                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)AColumnLefts[Count], TopMargin, (int)AColumnWidths[Count], CellHeight));

                        Count++;
                    }
                }
                Row++;
                TopMargin += CellHeight;
            }

            //If more lines exist, print another page.
            if (MorePagesToPrint)
            {
                e.HasMorePages = true;
                
            }
            else
                e.HasMorePages = false;

            
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }
    }
}
