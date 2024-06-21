namespace MenuPrincipal
{
    partial class MenuPrincipalV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalV));
            dataGridJuegos = new DataGridView();
            bntAgregar = new Button();
            btnEditar = new Button();
            bntEliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridJuegos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridJuegos
            // 
            dataGridJuegos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJuegos.GridColor = SystemColors.InactiveCaption;
            dataGridJuegos.Location = new Point(49, 43);
            dataGridJuegos.Name = "dataGridJuegos";
            dataGridJuegos.ReadOnly = true;
            dataGridJuegos.RowHeadersVisible = false;
            dataGridJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridJuegos.Size = new Size(503, 200);
            dataGridJuegos.TabIndex = 1;
            // 
            // bntAgregar
            // 
            bntAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntAgregar.BackColor = SystemColors.ButtonFace;
            bntAgregar.Location = new Point(106, 258);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(75, 23);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "&Agregar";
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(271, 258);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntEliminar.BackColor = Color.Transparent;
            bntEliminar.Location = new Point(438, 258);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(75, 23);
            bntEliminar.TabIndex = 4;
            bntEliminar.Text = "&Eliminar";
            bntEliminar.UseVisualStyleBackColor = false;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cazadora2;
            pictureBox1.Location = new Point(569, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipalV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(714, 293);
            Controls.Add(pictureBox1);
            Controls.Add(bntEliminar);
            Controls.Add(btnEditar);
            Controls.Add(bntAgregar);
            Controls.Add(dataGridJuegos);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipalV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Juegos de Mesa 0.1";
            TransparencyKey = Color.PeachPuff;
            ((System.ComponentModel.ISupportInitialize)dataGridJuegos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridJuegos;
        private Button bntAgregar;
        private Button btnEditar;
        private Button bntEliminar;
        private PictureBox pictureBox1;
    }


}
