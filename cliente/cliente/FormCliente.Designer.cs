namespace cliente
{
    partial class FormCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chat = new System.Windows.Forms.RichTextBox();
            this.mensaje = new System.Windows.Forms.TextBox();
            this.enviarBoton = new System.Windows.Forms.Button();
            this.participantes = new System.Windows.Forms.RichTextBox();
            this.salirBoton = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.botonConectar = new System.Windows.Forms.Button();
            this.desconectarBoton = new System.Windows.Forms.Button();
            this.cambioSala = new System.Windows.Forms.Label();
            this.ayudanteSalaBoton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.BackColor = System.Drawing.SystemColors.Window;
            this.chat.Enabled = false;
            this.chat.Location = new System.Drawing.Point(12, 40);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(233, 153);
            this.chat.TabIndex = 0;
            this.chat.Text = "";
            // 
            // mensaje
            // 
            this.mensaje.Enabled = false;
            this.mensaje.Location = new System.Drawing.Point(12, 211);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(233, 20);
            this.mensaje.TabIndex = 1;
            // 
            // enviarBoton
            // 
            this.enviarBoton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enviarBoton.Enabled = false;
            this.enviarBoton.Location = new System.Drawing.Point(265, 208);
            this.enviarBoton.Name = "enviarBoton";
            this.enviarBoton.Size = new System.Drawing.Size(75, 23);
            this.enviarBoton.TabIndex = 2;
            this.enviarBoton.Text = "Enviar";
            this.enviarBoton.UseVisualStyleBackColor = false;
            // 
            // participantes
            // 
            this.participantes.Enabled = false;
            this.participantes.Location = new System.Drawing.Point(265, 40);
            this.participantes.Name = "participantes";
            this.participantes.Size = new System.Drawing.Size(108, 153);
            this.participantes.TabIndex = 3;
            this.participantes.Text = "";
            // 
            // salirBoton
            // 
            this.salirBoton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.salirBoton.Location = new System.Drawing.Point(450, 244);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(75, 23);
            this.salirBoton.TabIndex = 4;
            this.salirBoton.Text = "Salir";
            this.salirBoton.UseVisualStyleBackColor = false;
            // 
            // nombre
            // 
            this.nombre.Text = "";
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(12, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(98, 17);
            this.nombre.TabIndex = 5;
            this.nombre.Text = "Chat del DIINF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Participantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conectarse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario:";
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(480, 40);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(107, 20);
            this.nickName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(481, 73);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(106, 20);
            this.password.TabIndex = 11;
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(400, 112);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(75, 23);
            this.botonConectar.TabIndex = 12;
            this.botonConectar.Text = "Conectarse";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.conectarBoton_Click);
            // 
            // desconectarBoton
            // 
            this.desconectarBoton.Enabled = false;
            this.desconectarBoton.Location = new System.Drawing.Point(495, 112);
            this.desconectarBoton.Name = "desconectarBoton";
            this.desconectarBoton.Size = new System.Drawing.Size(92, 23);
            this.desconectarBoton.TabIndex = 13;
            this.desconectarBoton.Text = "Desconectarse";
            this.desconectarBoton.UseVisualStyleBackColor = true;
            // 
            // cambioSala
            // 
            this.cambioSala.AutoSize = true;
            this.cambioSala.Location = new System.Drawing.Point(397, 214);
            this.cambioSala.Name = "cambioSala";
            this.cambioSala.Size = new System.Drawing.Size(85, 13);
            this.cambioSala.TabIndex = 14;
            this.cambioSala.Text = "Cambiar de sala:";
            // 
            // ayudanteSalaBoton
            // 
            this.ayudanteSalaBoton.Enabled = false;
            this.ayudanteSalaBoton.Location = new System.Drawing.Point(495, 203);
            this.ayudanteSalaBoton.Name = "ayudanteSalaBoton";
            this.ayudanteSalaBoton.Size = new System.Drawing.Size(92, 35);
            this.ayudanteSalaBoton.TabIndex = 15;
            this.ayudanteSalaBoton.Text = "Sala de Ayudantes";
            this.ayudanteSalaBoton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Si no eres usuario,";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(495, 161);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(92, 23);
            this.botonRegistrar.TabIndex = 17;
            this.botonRegistrar.Text = "Registrate";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 278);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ayudanteSalaBoton);
            this.Controls.Add(this.cambioSala);
            this.Controls.Add(this.desconectarBoton);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.participantes);
            this.Controls.Add(this.enviarBoton);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.chat);
            this.Name = "FormCliente";
            this.Text = "Sala del DIINF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chat;
        private System.Windows.Forms.TextBox mensaje;
        private System.Windows.Forms.Button enviarBoton;
        private System.Windows.Forms.RichTextBox participantes;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Button conectarBoton;
        private System.Windows.Forms.Button desconectarBoton;
        private System.Windows.Forms.Label cambioSala;
        private System.Windows.Forms.Button ayudanteSalaBoton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonRegistrar;
    }
}

