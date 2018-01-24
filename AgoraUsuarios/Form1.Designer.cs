namespace AgoraUsuarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChNameButton = new System.Windows.Forms.Button();
            this.ChPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(27, 29);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(153, 21);
            this.UsersComboBox.TabIndex = 0;
            this.UsersComboBox.SelectedIndexChanged += new System.EventHandler(this.UsersComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // NombreUsuarioTextBox
            // 
            this.NombreUsuarioTextBox.Location = new System.Drawing.Point(27, 94);
            this.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox";
            this.NombreUsuarioTextBox.Size = new System.Drawing.Size(153, 20);
            this.NombreUsuarioTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // PassUsuarioTextBox
            // 
            this.PassUsuarioTextBox.Location = new System.Drawing.Point(27, 139);
            this.PassUsuarioTextBox.Name = "PassUsuarioTextBox";
            this.PassUsuarioTextBox.Size = new System.Drawing.Size(153, 20);
            this.PassUsuarioTextBox.TabIndex = 5;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(199, 75);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 6;
            this.InsertButton.Text = "Crear";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(280, 75);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChNameButton
            // 
            this.ChNameButton.Location = new System.Drawing.Point(199, 107);
            this.ChNameButton.Name = "ChNameButton";
            this.ChNameButton.Size = new System.Drawing.Size(156, 23);
            this.ChNameButton.TabIndex = 8;
            this.ChNameButton.Text = "Cambiar nombre";
            this.ChNameButton.UseVisualStyleBackColor = true;
            this.ChNameButton.Click += new System.EventHandler(this.ChNameButton_Click);
            // 
            // ChPassButton
            // 
            this.ChPassButton.Location = new System.Drawing.Point(199, 137);
            this.ChPassButton.Name = "ChPassButton";
            this.ChPassButton.Size = new System.Drawing.Size(156, 23);
            this.ChPassButton.TabIndex = 9;
            this.ChPassButton.Text = "Cambiar contraseña";
            this.ChPassButton.UseVisualStyleBackColor = true;
            this.ChPassButton.Click += new System.EventHandler(this.ChPassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 191);
            this.Controls.Add(this.ChPassButton);
            this.Controls.Add(this.ChNameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.PassUsuarioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreUsuarioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreUsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassUsuarioTextBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChNameButton;
        private System.Windows.Forms.Button ChPassButton;
    }
}

