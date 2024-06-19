using JuegosDeMesa.Repositories;
using JuegosDeMesa.Views;
using System.Runtime.InteropServices;

namespace MenuPrincipal
{
    public partial class MenuPrincipalV : Form

    {
        JuegosRepository repo = new JuegosRepository();

        public MenuPrincipalV()

        {
            InitializeComponent();
            cargarJuegos();
        }

        private async void cargarJuegos()

        {
            dataGridJuegos.DataSource = await repo.ObtenerAsync();

        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarJuegos agregarEditarJuegos = new AgregarEditarJuegos();
            agregarEditarJuegos.ShowDialog();
            cargarJuegos();
        }

        private async void bntEliminar_Click(object sender, EventArgs e)
        {
            //obtener el Id del libro seleccionado y su nombre 
            string? idJuegoSeleccionado = (string)dataGridJuegos.CurrentRow.Cells[0].Value;
            string? nombreDeJuegoSeleccionado = (string)dataGridJuegos.CurrentRow.Cells[1].Value;


            //mostramos un mensaje box que pregunta si esta seguro que desea borrar 
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere borrar el juego {nombreDeJuegoSeleccionado}?", "Eliminar Juego",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);


            //si el usuario selecciono que quiere borrar, enviamos a borrar el libro utilizando el id y el objeto de la repo
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idJuegoSeleccionado);
                cargarJuegos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //obtener el id del libro seleccionado
            string? idJuegoSeleccionado = (string)dataGridJuegos.CurrentRow.Cells[0].Value;
           
            //instanciar la ventana agregarEditarJuegos
            //(vamos a teer que crear un nuevo constuctor en ese formulario que este preparado para recibir al Id)
            AgregarEditarJuegos agregarEditarJuegos = new AgregarEditarJuegos(idJuegoSeleccionado);

            //llamamos a la ventada con el metodo shoemodal que la pone por encima 
            agregarEditarJuegos.ShowDialog();

            //Cargar juegos
            cargarJuegos();
        }   
    }
}
