using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1

{
    class HabilitacionKeyPress
    {

        public void NoNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {

                e.Handled = true;

            }
        }
        public void NoSimbolos(object sender, KeyPressEventArgs e)
        {

            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;

            }

        }
        public void SoloTxt(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public void nopuntuacion(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void NoEs(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public void SoloPuntoyArroba(object sender, KeyPressEventArgs e)
        {
            for (int i = 33; i <= 255; i++)
            {
                if (i >= 1 && i <= 45)
                {
                    comparar(i, e);
                }

                if (i == 47)
                {
                    comparar(i, e);
                }
                if (i >= 58 && i <= 63)
                {
                    comparar(i, e);
                }

                if (i >= 91 && i <= 96)
                {
                    if (i != 95)
                    {
                        comparar(i, e);
                    }

                }
                if (i >= 123)
                {
                    comparar(i, e);

                }



            }

        }
        public void SoloPuntoY_Coma(object sender, KeyPressEventArgs e)
        {
            for (int i = 33; i <= 255; i++)
            {
                if (i >= 33 && i <= 34)
                {
                    comparar(i, e);
                }
                if (i >= 36 && i <= 45)
                {
                    if (i != 44)
                    {
                        comparar(i, e);
                    }

                }

                if (i == 47)
                {
                    comparar(i, e);
                }
                if (i >= 58 && i <= 64)
                {
                    comparar(i, e);
                }
                if (i >= 91 && i <= 96)
                {
                    if (i != 95)
                    {
                        comparar(i, e);
                    }

                }
                if (i >= 123)
                {
                    char letra = (char)i;
                    if (letra.Equals('á') || letra.Equals('é') || letra.Equals('í') || letra.Equals('ó') || letra.Equals('ú') || letra.Equals('Á') || letra.Equals('É') || letra.Equals('Í') || letra.Equals('Ó') || letra.Equals('Ú'))
                    {

                    }
                    else
                    {
                        comparar(i, e);
                    }
                }



            }

        }
        private void comparar(int i, KeyPressEventArgs e)
        {
            char letra = (char)i;
            if (Char.Equals(letra, e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
