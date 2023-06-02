using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFamilyTree
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
            //---------panel------------
            Panelchandung1.Paint += Panelchandung1_Paint;
            Panelchandung2.Paint += Panelchandung2_Paint;
            Panelchandung3.Paint += Panelchandung3_Paint;
            Panelchandung4.Paint += Panelchandung4_Paint;
            Panelchandung5.Paint += Panelchandung5_Paint;
            //-----tableLayoutPanel-----
            Panelthanhvien1.Paint += Panelthanhvien1_Paint;
            Panelthanhvien2.Paint += Panelthanhvien2_Paint;
            Panelthanhvien3.Paint += Panelthanhvien3_Paint;
            Panelthanhvien4.Paint += Panelthanhvien4_Paint;
            Panelthanhvien5.Paint += Panelthanhvien5_Paint;
            Panelthem.Paint += Panelthem_Paint;
            //--------picturebox---------
            anhchandung1.Paint += anhchandung1_Paint;
            anhchandung2.Paint += anhchandung2_Paint;
            anhchandung3.Paint += anhchandung3_Paint;
            anhchandung4.Paint += anhchandung4_Paint;
            anhchandung5.Paint += anhchandung5_Paint;    
            //----------button-----------
            Buttonmo.Paint += Buttonmo_Paint;
            buttontat.Paint += Buttontat_Paint;
        }

       



        //-----------------code chỉnh sửa--------------

        private void botronpanel(Panel panel)
        {
            int radius = 30; // nơi chỉnh độ bo tròn
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel.ClientRectangle;
            path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void lamtronpanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(panel.ClientRectangle);
            panel.Region = new Region(path);
        }

        private void lamtronanh(PictureBox picturebox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(picturebox.ClientRectangle);
            picturebox.Region = new Region(path);
        }

        private void lamtronnut(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(button.ClientRectangle);
            button.Region = new Region(path);
        }

        //------------liên kết mối quan hệ-----------

        private void vochong(Panel panel1, Panel panel2)
        {
            // Get the graphics object of the parent control
            Graphics g = panel1.Parent.CreateGraphics();

            // Get the coordinates of the two panels
            Point p1 = panel1.Location;
            Point p2 = panel2.Location;

            // Calculate the center points of the two panels
            Point c1 = new Point(p1.X + panel1.Width / 2, p1.Y + panel1.Height / 2);
            Point c2 = new Point(p2.X + panel2.Width / 2, p2.Y + panel2.Height / 2);

            // Set the thickness of the line
            Pen pen = new Pen(Color.LightBlue, 5);

            // Draw the line
            g.DrawLine(pen, c1, c2);
        }
        private void concai(Panel panel1, Panel panel2, Panel panel3)
        {
            // Get the graphics object of the parent control
            Graphics g = panel1.Parent.CreateGraphics();

            // Get the coordinates of the two panels
            Point p1 = panel1.Location;
            Point p2 = panel2.Location;
            Point p3 = panel3.Location;

            // Calculate the center points of the two panels
            Point c1 = new Point(p1.X + panel1.Width / 2, p1.Y + panel1.Height / 2);
            Point c2 = new Point(p2.X + panel2.Width / 2, p2.Y + panel2.Height / 2);
            Point c3 = new Point(p3.X + panel3.Width / 2, p3.Y + panel3.Height / 2);
            Point c4 = new Point((c1.X + c2.X) / 2, (c1.Y + c2.Y) / 2);

            // Calculate the bend point
            int bendX = Math.Min(c3.X, c4.X) + Math.Abs(c3.X - c4.X) / 2;
            int bendY = Math.Min(c3.Y, c4.Y) + Math.Abs(c3.Y - c4.Y) / 2;

            // Set the thickness of the line
            Pen pen = new Pen(Color.LightBlue, 5);

            // Draw the line
            g.DrawLine(pen, new Point(c3.X, bendY), c3);
            g.DrawLine(pen, new Point(c3.X, bendY), new Point(c4.X, bendY));
            g.DrawLine(pen, new Point(c4.X, bendY), c4);
        }


        //-----------------sửa panel-----------------

        private void Panelchandung1_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelchandung1);
        }
        private void Panelchandung2_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelchandung2);
        }
        private void Panelchandung3_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelchandung3);
        }
        private void Panelchandung4_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelchandung4);        
        }
        private void Panelchandung5_Paint(object sender, PaintEventArgs e)
        {
            lamtronpanel(Panelchandung5);
        }


        //--------------------sửa tableLayoutPanel-----------------

        private void Panelthanhvien1_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthanhvien1);
            vochong(Panelthanhvien1, Panelthanhvien2);
        }
        private void Panelthanhvien2_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthanhvien2);
        }
        private void Panelthanhvien3_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthanhvien3);
            concai(Panelthanhvien1, Panelthanhvien2, Panelthanhvien3);
        }
        private void Panelthanhvien4_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthanhvien4);
            concai(Panelthanhvien1, Panelthanhvien2, Panelthanhvien4);
        }
        private void Panelthanhvien5_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthanhvien5);
            concai(Panelthanhvien1, Panelthanhvien2, Panelthanhvien5);
        }

        private void Panelthem_Paint(object sender, PaintEventArgs e)
        {
            botronpanel(Panelthem);
        }

        //-----------------sửa picturebox---------------------
        private void anhchandung1_Paint (object sender, PaintEventArgs e)
        {
            lamtronanh(anhchandung1);
        }
        private void anhchandung2_Paint (object sender, PaintEventArgs e)
        {
            lamtronanh(anhchandung2);
        }
        private void anhchandung3_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(anhchandung3);
        }
        private void anhchandung4_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(anhchandung4);
        }
        private void anhchandung5_Paint(object sender, PaintEventArgs e)
        {
            lamtronanh(anhchandung5);
        }

        //----------------------sửa nút------------------------

        private void Buttonmo_Paint(object sender, EventArgs e)
        {
            lamtronnut(Buttonmo);
        }
        private void Buttontat_Paint(object sender, PaintEventArgs e)
        {
            lamtronnut(buttontat);
        }

        //---------------------click----------------------------
        private void anhchandung1_Click(object sender, EventArgs e)
        {
            Buttonmo.Visible = true;
        }

        private void Buttonmo_Click(object sender, EventArgs e)
        {
            buttontat.Visible = true;
            Panelthem.Visible = true;
        }

        private void buttontat_Click(object sender, EventArgs e)
        {
            buttontat.Visible = false;
            Panelthem.Visible = false;
            Buttonmo.Visible = false;
        }

        
    }
}
