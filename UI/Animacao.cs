using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Animacao
    {
        static int intMouse_x, intMouse_y;
        static Point pointNovo;
        static bool booMouseDown = false;
        private static void MouseDown(Object sender, MouseEventArgs e)
        {

            booMouseDown = true;
            intMouse_x = Control.MousePosition.X - FrmInventario.ActiveForm.Location.X;
            intMouse_y = Control.MousePosition.Y - FrmInventario.ActiveForm.Location.Y;
        }

        private static void MouseUp(Object sender, MouseEventArgs e)
        {
            booMouseDown = false;
        }

        private static void MouseMove(Object sender, MouseEventArgs e)
        {

            if (booMouseDown)
            {
                pointNovo = Control.MousePosition;
                pointNovo.X -= intMouse_x;
                pointNovo.Y -= intMouse_y;
                FrmInventario.ActiveForm.Location = pointNovo;
                Application.DoEvents();
            }
        }

        public static void Arrastar(Control conteiner)
        {
            foreach (Control c in conteiner.Controls)
            {
                Type tipo = c.GetType();
                if (tipo != typeof(Button) && tipo != typeof(TextBox) && tipo != typeof(Label) && tipo != typeof(ComboBox))
                {
                    c.MouseDown += MouseDown;
                    c.MouseUp += MouseUp;
                    c.MouseMove += MouseMove;
                }
                if (c.Controls.Count != 0)
                {
                    Arrastar(c);
                }
            }
        }
    }
}
