using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPDS
{
    internal class Erros
    {
        public partial class CadastroE: Form
        {
            private ErrorProvider errorProvider;
            public CadastroE()
            {
              //  InitializeComponent();

                errorProvider = new ErrorProvider();
            }

           
        }
    }
}
