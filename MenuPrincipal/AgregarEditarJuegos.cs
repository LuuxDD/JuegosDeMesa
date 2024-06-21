using JuegosDeMesa.Models;
using JuegosDeMesa.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegosDeMesa.Views
{
    public partial class AgregarEditarJuegos : Form
    {
        private string idJuegoSeleccionado;

        JuegosRepository repo = new JuegosRepository();


        //Construsctor
        public AgregarEditarJuegos()
        {
            InitializeComponent();
        }

        //Constructor que recibe parametros
        public AgregarEditarJuegos(string idJuegoSeleccionado)
        {
            this.idJuegoSeleccionado = idJuegoSeleccionado;
            InitializeComponent();
            cargarJuegoDatosEnPantalla();
        }

        private async void cargarJuegoDatosEnPantalla()
        {

            Juegos? juego = await repo.ObtenerId(this.idJuegoSeleccionado);

            if (juego != null)
            {
                txtNombre.Text = juego.nombre;
                cantidadDeJugadores.Value = juego.CantidadDeJugadores;
                tiempoDeJuego.Value = juego.tiempodejuego;
                txtEditorial.Text = juego.editorial;
            }
            else
            {
                MessageBox.Show("Error no se encontroel libro");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bntGuardar_Click(object sender, EventArgs e)
        {
            if (this.idJuegoSeleccionado != null)

            {

                await repo.ActualizarAsync(txtNombre.Text,
                           (int)cantidadDeJugadores.Value,
                           (int)tiempoDeJuego.Value,
                           txtEditorial.Text,
                           this.idJuegoSeleccionado);
                this.Close();
            }

            else
            {


                await repo.AgregarAsync(txtNombre.Text,
                                (int)cantidadDeJugadores.Value,
                                (int)tiempoDeJuego.Value,
                               txtEditorial.Text);
                this.Close();

            }
        }


    }
}
