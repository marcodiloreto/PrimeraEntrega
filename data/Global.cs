using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraEntrega.Vista;

namespace PrimeraEntrega.data
{
    static class Global
    {
        public static Form1 principal;

        public static void setPrincipal(Form1 form) {
            if (principal == null)
            {
                principal = form;
            }
        }

        public static void killApp() {
            principal.Dispose();
        }

    }
}
