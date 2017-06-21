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

            InitializeComponent();

            

        }

        DataTable dt = new DataTable();
        
        public int width;
        public int height;
        internal Rect r1;
        public string ident;
        int count_tb = 0;
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
            printDialog1.ShowDialog();
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

    }
}
