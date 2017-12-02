using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_kromka_last_v
{
    class Rect
    {
        Button B1;
        Button B2;
        Button B3;
        Button B4;
        Boolean s1, s2, s3, s4;
        public string name;
        public string material;
        public double width;
        public double height;
        public int count;
        double width_sc;
        double height_sc;
        public double lenght_for_clue = 0;
        public double tot_lenght_for_clue = 0;

        private Panel panell;
        private Form1 drawForm;
        public System.Drawing.Bitmap icone;




        public Rect(string name_p, string mat, int cnt, double w, double h, Panel p1, Form1 f1)
        {
            name = name_p;
            material = mat;
            count = cnt;
            B1 = new Button();
            B1.Click += this.B1_Click_1;
            p1.Controls.Add(B1);
            B2 = new Button();
            B2.Click += this.B2_Click_1;
            p1.Controls.Add(B2);
            B3 = new Button();
            B3.Click += this.B3_Click_1;
            p1.Controls.Add(B3);
            B4 = new Button();
            B4.Click += this.B4_Click_1;
            p1.Controls.Add(B4);
            width = w;
            height = h;
            s1 = s2 = s3 = s4 = false;
            drawForm = f1;
            panell = p1;

            // drawing image
            icone = new System.Drawing.Bitmap(20, 20);
            for (int x = 0; x < icone.Height; ++x)
                for (int y = 0; y < icone.Width; ++y)
                    icone.SetPixel(x, y, Color.White);

            for (int x = 0; x < icone.Width; ++x)
            {
                icone.SetPixel(x, 0, Color.Black);
                icone.SetPixel(x, icone.Height - 1, Color.Black);
            }
            for (int y = 0; y < icone.Height; ++y)
            { 
                icone.SetPixel(0, y, Color.Black);
                icone.SetPixel(icone.Width - 1, y, Color.Black);
            }

        }

        private void B4_Click_1(object sender, EventArgs e)
        {
            if (B4.BackColor == Color.Black)
            {
                B4.BackColor = Color.Red;
                s4 = true;
                lenght_for_clue += width;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int x = 0; x < icone.Width; ++x)
                    icone.SetPixel(x, icone.Height - 1, Color.Red);
            }
            else
            {
                B4.BackColor = Color.Black;
                s4 = false;
                lenght_for_clue -= width;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int x = 0; x < icone.Width; ++x)
                    icone.SetPixel(x, icone.Height - 1, Color.Black);
            }

        }

        private void B3_Click_1(object sender, EventArgs e)
        {
            if (B3.BackColor == Color.Black)
            {
                B3.BackColor = Color.Red;
                s3 = true;
                lenght_for_clue += height;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int y = 0; y < icone.Height; ++y)
                    icone.SetPixel(icone.Width - 1, y, Color.Red);
            }
            else
            {
                B3.BackColor = Color.Black;
                s3 = false;
                lenght_for_clue -= height;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int y = 0; y < icone.Height; ++y)
                    icone.SetPixel(icone.Width - 1, y, Color.Black);
            }
        }

        private void B2_Click_1(object sender, EventArgs e)
        {
            if (B2.BackColor == Color.Black)
            {
                B2.BackColor = Color.Red;
                s2 = true;
                lenght_for_clue += height;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int y = 0; y < icone.Height; ++y)
                    icone.SetPixel(0, y, Color.Red);
            }
            else

            {
                B2.BackColor = Color.Black;
                s2 = false;
                lenght_for_clue -= height;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int y = 0; y < icone.Height; ++y)
                    icone.SetPixel(0, y, Color.Black);
            }
        }

        private void B1_Click_1(object sender, EventArgs e)
        {

            if (B1.BackColor == Color.Black)
            {
                B1.BackColor = Color.Red;
                s1 = true;
                lenght_for_clue += width;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int x = 0; x < icone.Width; ++x)
                    icone.SetPixel(x, 0, Color.Red);
            }
            else
            {
                B1.BackColor = Color.Black;
                s1 = false;
                lenght_for_clue -= width;
                drawForm.TextLabel = Convert.ToString(lenght_for_clue);
                for (int x = 0; x < icone.Width; ++x)
                    icone.SetPixel(x, 0, Color.Black);
            }


        }


        public void Draw()
        {
            try
            {
                scale();
                B1.BackColor = Color.Black;
                B1.Location = new System.Drawing.Point(30, 30);
                B1.Width = Convert.ToInt32(this.width_sc);
                B1.Height = 10;
                B2.BackColor = Color.Black;
                B2.Location = new System.Drawing.Point(30, 30);
                B2.Height = Convert.ToInt32(this.height_sc);
                B2.Width = 10;
                B3.BackColor = Color.Black;
                B3.Location = new System.Drawing.Point(Convert.ToInt32(this.width_sc) + 20, 30);
                B3.Height = Convert.ToInt32(this.height_sc);
                B3.Width = 10;
                B4.BackColor = Color.Black;
                B4.Location = new System.Drawing.Point(30, Convert.ToInt32(this.height_sc) + 20);
                B4.Height = 10;
                B4.Width = Convert.ToInt32(this.width_sc);
            }
            catch (Exception e) {
                MessageBox.Show("Bad parametres");
            }

        }
        public void clear(Panel p1)
        {

            p1.Controls.Remove(B1);
            p1.Controls.Remove(B2);
            p1.Controls.Remove(B3);
            p1.Controls.Remove(B4);
            p1.Refresh();
        }

        public void  scale()
        {
            double a;
            if (height < width)
            {
                a = width/380;
            }
            else {
                a = height/380;
            }
            
                width_sc = width /a;
                height_sc = height/a;
                    
        }
}
}
