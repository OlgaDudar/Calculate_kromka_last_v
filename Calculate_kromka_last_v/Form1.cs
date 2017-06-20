using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            

            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

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
            TextLabel = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(textBox1.Text);
            height = Convert.ToInt32(textBox2.Text);
            ident = textBox3.Text;
            panel2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
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
            /*int rows = dataGridView1.RowCount-1;




            if (count_tb > 0) {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells[0].Value = r1.name;
            dataGridView1.Rows[0].Cells[1].Value = r1.width;
            dataGridView1.Rows[0].Cells[2].Value = r1.height;
            dataGridView1.Rows[0].Cells[3].Value = r1.icone;
            dataGridView1.Rows[0].Cells[4].Value = r1.lenght_for_clue;
            //dataGridView1.Rows.Add();
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.Rows.Add();

            dataGridView1.

            //count_tb++;
            */
            string[] row = new string[] { r1.name, r1.width.ToString(), r1.height.ToString() };
            dataGridView1.Rows.Add(row);

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = r1.icone;
            img.Image = image;
            dataGridView1.Columns.Add(img);
            img.HeaderText = "Image";
            img.Name = "img";


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void printTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
