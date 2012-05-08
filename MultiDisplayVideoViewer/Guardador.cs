using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDisplayVideoViewer
{
    public class Guardador : System.Windows.Forms.ApplicationContext
    {
        public static int code;

        public Guardador(int codigo)
        {
            code = codigo;
        }
    }
}
