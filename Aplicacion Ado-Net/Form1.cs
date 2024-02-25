using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Ado_Net
{
    public partial class FistApp : Form
    {
        private List<Disco> ListaDisquetes; 
        public FistApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JugadorNegocio disc = new JugadorNegocio();
            ListaDisquetes = disc.Discoss();
            dgbDiscos.DataSource = ListaDisquetes;
            dgbDiscos.Columns["UrlImagen"].Visible = false; 
            cargarImagen(ListaDisquetes[0].UrlImagen); 

        }

        private void dgbDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgbDiscos.CurrentRow.DataBoundItem;
           cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxAutor.Load(imagen);
            }
            catch (Exception ex)
            {

                pBoxAutor.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            } 
            
            
        }
    }
}
