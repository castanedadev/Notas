using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bunifu;
using BunifuAnimatorNS;

namespace WindowsFormsApplication1.F_Splash
{
    class MN
    {
        public static System.Windows.Forms.Form padre;
        BunifuTransition n = new BunifuTransition();
        F1.Neg_General obj = new F1.Neg_General();
        Screen screen = Screen.PrimaryScreen;
        double aux;
        public MN()
        {

            aux = (int)screen.Bounds.Height * 0.035;

        }

        public void Maximizar(Form fh)
        {
            Form fn = fh as Form;
            F_Splash.MN.padre.Location = new Point(F_Splash.MN.padre.Location.X - 30, F_Splash.MN.padre.Location.Y - 30);
            obj.ResizeForm(fn, 728, 1346);


        }

        public void Restaurar(Form fh)
        {
            Form fn = fh as Form;
            F_Splash.MN.padre.Location = new Point(F_Splash.MN.padre.Location.X + 30, F_Splash.MN.padre.Location.Y + 30);

            obj.ResizeForm(fn, fn.Height * 2, fn.Width * 2);



        }
        public void MouseEnterPictureBox(PictureBox pb, int x, int y)
        {
            PictureBox b = pb as PictureBox;
            b.Width = b.Width + x;
            b.Height = b.Height + y;

        }
        public void MouseLeavePictureBox(PictureBox pb, int x, int y)
        {
            PictureBox b = pb as PictureBox;
            b.Width = b.Width - x;
            b.Height = b.Height - y;
        }


        public void AbrirPanel1(object pan, object panel)
        {
            Panel PanelPapa1 = panel as Panel;

            if (PanelPapa1 != null)
            {
                if (PanelPapa1.Controls.Count > 0)
                    PanelPapa1.Controls.RemoveAt(0);
            }
            Form fh = pan as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            //fh.Width = PanelPapa1.Width;
            //fh.Height = PanelPapa1.Height;
            fh.Location = new Point(PanelPapa1.Location.X, PanelPapa1.Location.Y);
            fh.Width = fh.Width;
            fh.Height = fh.Height;
            fh.FormBorderStyle = FormBorderStyle.None;
            PanelPapa1.Controls.Add(fh);
            PanelPapa1.Tag = fh;

            fh.Show();
        }

        public static void cerrar()
        {
            padre.Hide();
        
        }




    }
}
