using EnterandExit;
using static EnterandExit.Enterandexit;

namespace DJES
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //Configuramos el botón para que nos redireccione a otro formulario
        private void frmEntradas_Click(object sender, EventArgs e)
        {
            //Creamos una instancia del segundo formulario
           Enterandexit form2 = new Enterandexit();

            form2.Show();
        }
    }
}
