using System;
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
using System.Globalization;
using System.Threading;

namespace Calculate_kromka_last_v
{
    public partial class Form1 : Form
    {
        int current_row;
        bool FirstPage = true;
        bool NewPage;
        bool MorePagesToPrint;
        DataTable dt;
        public int width;
        public int height;
        internal Rect r1;
        public string ident;
        PrintDocument pd = new PrintDocument();

        public Form1()
        {
            InitializeTable();
            InitializeComponent();
            InitializeValues();
        }

        public string TextLabel
        {
            get { return lbl_total.Text; }
            set { lbl_total.Text = value; }
        }

        private void AddElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Visible = true;
            InitializeValues();
            btn_draw.Enabled = true;
        }

        private void InitializeTable()
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Width"));
            dt.Columns.Add(new DataColumn("Height"));
            dt.Columns.Add("Image", typeof(byte[]));
            dt.Columns.Add(new DataColumn("Length for clue"));
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void InitializeValues()
        {
            txb_width.Text = "1";
            txb_height.Text = "1";
            txb_Name.Text = "Name";
            TextLabel = "0";
            txb_height.BackColor = Color.White;
            txb_width.BackColor = Color.White;
        }

        private void DestroyValues()
        {
            dt.Clear();
            dt = null;
            pd.PrintPage -= new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckValues())
            {
                width = Convert.ToInt32(txb_width.Text);
                height = Convert.ToInt32(txb_height.Text);
                ident = txb_Name.Text;
                r1 = new Rect(ident, width, height, panel1, this);
                r1.Draw();
                btn_draw.Enabled = false;
            }
        }

        //return true if any inconsisten values
        private bool CheckValues()
        {
            List<string> errorMessage = new List<string>();
            try
            {
                int width = Convert.ToInt32(txb_width.Text);
                if (width <= 0)
                {
                    txb_width.BackColor = System.Drawing.Color.Red;
                    errorMessage.Add("Width should be greater than 0");
                }
            }
            catch(Exception e)
            {
                txb_width.BackColor = System.Drawing.Color.Red;
                errorMessage.Add("Width incorrect value");
            }
            try
            {
                int height = Convert.ToInt32(txb_height.Text);
                if (height <= 0)
                {
                    txb_height.BackColor = System.Drawing.Color.Red;
                    errorMessage.Add("Height should be greater than 0");
                }
            }
            catch (Exception e)
            {
                txb_height.BackColor = System.Drawing.Color.Red;
                errorMessage.Add("Height incorrect value");
            }
            if(errorMessage.Count > 0)
            {
                String message = string.Join(", ", errorMessage.ToArray());
                MessageBox.Show(message);
            }
            return (errorMessage.Count > 0) ? true : false;
        }

        private void txb_width_MouseEnter(object sender, EventArgs e)
        {
            txb_width.BackColor = System.Drawing.Color.White;
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
            row["Name"] = "Total";
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
                current_row = 0;
                FirstPage = true;
                NewPage = false;
                MorePagesToPrint = false;

                printDocument1.DocumentName = "Page Print";
                printDocument1.Print();

                current_row = 0;
                FirstPage = true;
                NewPage = false;

                MorePagesToPrint = false;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int LeftMargin = e.MarginBounds.Left;
            int TmpWidth = e.MarginBounds.Width;
            int TopMargin = e.MarginBounds.Top;
            int TotalWidth = 600;
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
                string strDate = PrintTableHeaderText(e, "Sumary tables");
                //Draw Date
                PrintCurrentDateAtThePageHeader(e, strDate);
                DrawFirstPageHeader(e, ref LeftMargin, ref TmpWidth, TopMargin, TotalWidth, AColumnLefts, AColumnWidths, ref HeaderHeight, strFormat);
                TopMargin += HeaderHeight;
            }
            //MessageBox.Show(dgv_test.Rows.Count.ToString());
            int CellHeight;
            while (current_row < dgv_test.Rows.Count)
            {
                //MessageBox.Show("Ok");
                DataGridViewRow GridRow = dgv_test.Rows[current_row];
                //Control cell height
                CellHeight = GridRow.Height + 25;
                //Check whether the current page settings allo more rows to print
                int a = TopMargin + CellHeight;
                int b = e.MarginBounds.Height + e.MarginBounds.Top;
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
                        DrawFirstPageHeader(e, ref LeftMargin, ref TmpWidth, TopMargin, TotalWidth, AColumnLefts, AColumnWidths, ref HeaderHeight, strFormat);
                        NewPage = false;
                        TopMargin += HeaderHeight;
                    }
                    //Draw Columns Contents   
                    DrawTableRowWithCells(e, ref LeftMargin, ref TmpWidth, TopMargin, AColumnLefts, AColumnWidths, strFormat, CellHeight, GridRow);
                }
                current_row++;
                TopMargin += CellHeight;
            }

            //If more lines exist, print another page.
            if (MorePagesToPrint)
            {
                MorePagesToPrint = false;
                e.HasMorePages = true;
                
            }
            else
                e.HasMorePages = false;
        }

        private void DrawFirstPageHeader(PrintPageEventArgs e, ref int LeftMargin, ref int TmpWidth, int TopMargin, int TotalWidth, List<int> AColumnLefts, List<int> AColumnWidths, ref int HeaderHeight, StringFormat strFormat)
        {
            int column_count = 0;
            foreach (DataGridViewColumn GridCol in dgv_test.Columns)
            {

                AColumnLefts.Add(LeftMargin);
                AColumnWidths.Add(TmpWidth);
                TmpWidth = (int)(Math.Floor((double)((double)GridCol.Width / (double)TotalWidth * (double)TotalWidth * ((double)e.MarginBounds.Width / (double)TotalWidth))));

                HeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, TmpWidth).Height) + 11;

                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                           new Rectangle((int)AColumnLefts[column_count], TopMargin,
                           (int)AColumnWidths[column_count], HeaderHeight));
                e.Graphics.DrawRectangle(Pens.Black,
                       new Rectangle((int)AColumnLefts[column_count], TopMargin,
                       (int)AColumnWidths[column_count], HeaderHeight));

                e.Graphics.DrawString(GridCol.HeaderText,
                    GridCol.InheritedStyle.Font,
                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                    new RectangleF((int)AColumnLefts[column_count], TopMargin,
                    (int)AColumnWidths[column_count], HeaderHeight), strFormat);

                column_count++;
                LeftMargin += TmpWidth;
            }
        }

        private static void DrawTableRowWithCells(PrintPageEventArgs e, ref int LeftMargin, ref int TmpWidth, int TopMargin, List<int> AColumnLefts, List<int> AColumnWidths, StringFormat strFormat, int CellHeight, DataGridViewRow GridRow)
        {
            int cellCounter = 0;
            foreach (DataGridViewCell Cel in GridRow.Cells)
            {
                if (Cel.Value != null)
                {
                    if (Cel.Value.GetType().ToString().Equals("System.Byte[]"))
                    {
                        byte[] asd = (byte[])Cel.Value;

                        MemoryStream ms = new MemoryStream(asd);
                        Image returnImage = Image.FromStream(ms);

                        e.Graphics.DrawImage(returnImage, new Point(AColumnLefts[cellCounter]+5, TopMargin+5));
                    }
                    else
                    {
                        e.Graphics.DrawString((Cel.Value.GetType().ToString().Equals("System.Drawing.Bitmap")) ? "" : Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)AColumnLefts[cellCounter], (float)TopMargin,
                                    (int)AColumnWidths[cellCounter], (float)CellHeight), strFormat);
                    }
                }
                //Drawing Cells Borders 
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)AColumnLefts[cellCounter], TopMargin, (int)AColumnWidths[cellCounter], CellHeight));

                cellCounter++;
            }
        }

        private void PrintCurrentDateAtThePageHeader(PrintPageEventArgs e, string strDate)
        {
            e.Graphics.DrawString(strDate, new Font(dgv_test.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgv_test.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Summary tables",
                                new Font(new Font(dgv_test.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);
        }

        private string PrintTableHeaderText(PrintPageEventArgs e, String caption)
        {
            e.Graphics.DrawString(caption, new Font(dgv_test.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString(caption,
                                new Font(dgv_test.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);

            String strDate = DateTime.Now.ToLongDateString() + " " +
                DateTime.Now.ToShortTimeString();
            return strDate;
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void txb_width_Enter(object sender, EventArgs e)
        {
            txb_width.BackColor = System.Drawing.Color.White;
        }

        private void txb_height_Enter(object sender, EventArgs e)
        {
            txb_height.BackColor = System.Drawing.Color.White;
        }

        private void uKRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            FormRefresh();
        }

        private void eNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            FormRefresh();
        }

        private void FormRefresh()
        {
            DestroyValues();
            this.Controls.Clear();
            this.InitializeComponent();
            InitializeTable();
            InitializeValues();
        }
    }
}
