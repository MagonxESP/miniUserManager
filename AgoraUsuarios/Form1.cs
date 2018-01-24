using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgoraUsuarios
{
    public partial class Form1 : Form
    {
        private Usuario u;
        private List<Usuario> users;
        private int actualIndex;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private bool Connect()
        {
            string[] ConnectionStrings = { Agora.Restauracion, Agora.Retail };

            for(int i = 0; i < ConnectionStrings.Length; i++)
            {
                this.u.Prepare(ConnectionStrings[i]);
                if(this.u.TestConnection())
                {
                    this.connectionString = ConnectionStrings[i];
                    return true;
                }
            }

            MessageBox.Show("No se ha podido conectar a una base de datos de agora (Restauracion o Retail) en este PC. El programa se va a cerrar.");
            return false;
        }

        private void loadComboBox()
        {
            users = this.u.GetUsers();

            for(int i = 0; i < users.Count; i++)
            {
                this.UsersComboBox.Items.Add(users[i].Nombre);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.u = new Usuario();

            if (this.Connect())
            {
                this.loadComboBox();
            }
            else
            {
                Application.Exit();
            }
        }

        private int FindByName(string Nombre)
        {
            for(int i = 0; i < this.users.Count; i++)
            {
                if(this.users[i].Nombre == Nombre)
                {
                    return i;
                }
            }

            return -1;
        }

        private void UsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = (string) this.UsersComboBox.SelectedItem;
            this.actualIndex = this.FindByName(nombre);

            if(this.actualIndex >= 0 && this.actualIndex <= this.users.Count)
            {
                this.u = users[actualIndex];
            }
            
            // preparamos el usuario seleccionado para poder ejecutar sentencias sobre el
            this.u.Prepare(this.connectionString);

            this.NombreUsuarioTextBox.Text = this.u.Nombre;
            this.PassUsuarioTextBox.Text = this.u.Password;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario();
     
            newUser.Nombre = this.NombreUsuarioTextBox.Text;
            newUser.Password = this.PassUsuarioTextBox.Text;

            newUser.Prepare(this.connectionString);

            if(newUser.Create())
            {
                this.users.Add(newUser);
                this.UsersComboBox.Items.Add(newUser.Nombre);

                MessageBox.Show("¡Se ha creado un usuario nuevo!");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error durante la creacion del usuario");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.u.Delete())
            {
                this.users.RemoveAt(this.FindByName(this.u.Nombre)); // eliminamos el usuario de nuestra lista
                this.UsersComboBox.Items.RemoveAt(this.UsersComboBox.SelectedIndex); // y tambien del desplegable
                
                // limpiamos los campos
                this.NombreUsuarioTextBox.Text = ""; 
                this.PassUsuarioTextBox.Text = "";

                MessageBox.Show("Se ha eliminado el usuario");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error mientras se eliminaba el usuario");
            }
        }

        private void ChNameButton_Click(object sender, EventArgs e)
        {
            string newNombre = this.NombreUsuarioTextBox.Text;

            if (this.u.UpdateNombre(newNombre))
            {
                this.users.Insert(this.actualIndex, this.u);
                this.UsersComboBox.Items.Insert(this.UsersComboBox.SelectedIndex, this.u.Nombre);

                MessageBox.Show("Se ha cambiado el nombre del usuario");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error mientras se cambiaba el nombre al usuario");
            }
        }

        private void ChPassButton_Click(object sender, EventArgs e)
        {
            string newPassword = this.PassUsuarioTextBox.Text;

            if (this.u.UpdatePassword(newPassword))
            {
                this.users.Insert(this.actualIndex, this.u);
                MessageBox.Show("Se ha cambiado la contraseña al usuario");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error mientras de cambiaba la contraseña del usuario");
            }
        }
    }
}
