﻿namespace JuegosDeMesa.Views
{
    partial class AgregarEditarJuegos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntNombre = new Label();
            txtNombre = new TextBox();
            btnTiempoDjuego = new Label();
            btnCantidadDeJugadores = new Label();
            bntEditorial = new Label();
            txtTiempoDeJuego = new TextBox();
            txtEditorial = new TextBox();
            bntGuardar = new Button();
            button2 = new Button();
            txtCantidadDeJugadores = new TextBox();
            SuspendLayout();
            // 
            // bntNombre
            // 
            bntNombre.AutoSize = true;
            bntNombre.Location = new Point(57, 66);
            bntNombre.Name = "bntNombre";
            bntNombre.Size = new Size(51, 15);
            bntNombre.TabIndex = 0;
            bntNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnTiempoDjuego
            // 
            btnTiempoDjuego.AutoSize = true;
            btnTiempoDjuego.Location = new Point(57, 118);
            btnTiempoDjuego.Name = "btnTiempoDjuego";
            btnTiempoDjuego.Size = new Size(97, 15);
            btnTiempoDjuego.TabIndex = 2;
            btnTiempoDjuego.Text = "Tiempo de Juego";
            // 
            // btnCantidadDeJugadores
            // 
            btnCantidadDeJugadores.AutoSize = true;
            btnCantidadDeJugadores.Location = new Point(57, 165);
            btnCantidadDeJugadores.Name = "btnCantidadDeJugadores";
            btnCantidadDeJugadores.Size = new Size(127, 15);
            btnCantidadDeJugadores.TabIndex = 3;
            btnCantidadDeJugadores.Text = "Cantidad de Jugadores";
            // 
            // bntEditorial
            // 
            bntEditorial.AutoSize = true;
            bntEditorial.Location = new Point(57, 213);
            bntEditorial.Name = "bntEditorial";
            bntEditorial.Size = new Size(50, 15);
            bntEditorial.TabIndex = 4;
            bntEditorial.Text = "Editorial";
            // 
            // txtTiempoDeJuego
            // 
            txtTiempoDeJuego.Location = new Point(160, 115);
            txtTiempoDeJuego.Name = "txtTiempoDeJuego";
            txtTiempoDeJuego.Size = new Size(296, 23);
            txtTiempoDeJuego.TabIndex = 5;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(111, 205);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(345, 23);
            txtEditorial.TabIndex = 7;
            // 
            // bntGuardar
            // 
            bntGuardar.Location = new Point(160, 258);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(81, 31);
            bntGuardar.TabIndex = 8;
            bntGuardar.Text = "&Guardar";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(308, 258);
            button2.Name = "button2";
            button2.Size = new Size(92, 31);
            button2.TabIndex = 9;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCantidadDeJugadores
            // 
            txtCantidadDeJugadores.Location = new Point(191, 162);
            txtCantidadDeJugadores.Name = "txtCantidadDeJugadores";
            txtCantidadDeJugadores.Size = new Size(265, 23);
            txtCantidadDeJugadores.TabIndex = 10;
            // 
            // AgregarEditarJuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 313);
            Controls.Add(txtCantidadDeJugadores);
            Controls.Add(button2);
            Controls.Add(bntGuardar);
            Controls.Add(txtEditorial);
            Controls.Add(txtTiempoDeJuego);
            Controls.Add(bntEditorial);
            Controls.Add(btnCantidadDeJugadores);
            Controls.Add(btnTiempoDjuego);
            Controls.Add(txtNombre);
            Controls.Add(bntNombre);
            Name = "AgregarEditarJuegos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Editar Juegos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bntNombre;
        private TextBox txtNombre;
        private Label btnTiempoDjuego;
        private Label btnCantidadDeJugadores;
        private Label bntEditorial;
        private TextBox txtTiempoDeJuego;
        private TextBox txtEditorial;
        private Button bntGuardar;
        private Button button2;
        private TextBox txtCantidadDeJugadores;
    }
}