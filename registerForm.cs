using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            secondNameBoxRegister.Text = "Фамилия";
            secondNameBoxRegister.ForeColor = Color.Gray;
            nameBoxRegister.Text = "Имя";
            nameBoxRegister.ForeColor = Color.Gray;
            numberBoxRegister.Text = "Номер телефона";
            numberBoxRegister.ForeColor = Color.Gray;
            passwordBoxRegister.Text = "Пароль";
            passwordBoxRegister.ForeColor = Color.Gray;

            this.passwordBoxRegister.Size = new Size(this.passwordBoxRegister.Size.Width, 28);

        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            enterForm ent = new enterForm();
            this.Hide();
            ent.ShowDialog();
        }

        private void secondNameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (secondNameBoxRegister.Text == "Фамилия")
            {
                secondNameBoxRegister.Text = "";
                secondNameBoxRegister.ForeColor = Color.Black;
            }
        }

        private void secondNameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (secondNameBoxRegister.Text == "")
            {
                secondNameBoxRegister.Text = "Фамилия";
                secondNameBoxRegister.ForeColor = Color.Gray;
            }

        }

        private void nameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (nameBoxRegister.Text == "Имя")
            {
                nameBoxRegister.Text = "";
                nameBoxRegister.ForeColor = Color.Black;
            }
        }

        private void nameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (nameBoxRegister.Text == "")
            {
                nameBoxRegister.Text = "Имя";
                nameBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void numberBoxRegister_Enter(object sender, EventArgs e)
        {
            if (numberBoxRegister.Text == "Номер телефона")
            {
                numberBoxRegister.Text = "";
                numberBoxRegister.ForeColor = Color.Black;
            }
        }

        private void numberBoxRegister_Leave(object sender, EventArgs e)
        {
            if (numberBoxRegister.Text == "")
            {
                numberBoxRegister.Text = "Номер телефона";
                numberBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void passwordBoxRegister_Enter(object sender, EventArgs e)
        {
            passwordBoxRegister.UseSystemPasswordChar = true;
            if (passwordBoxRegister.Text == "Пароль")
            {
                passwordBoxRegister.Text = "";
                passwordBoxRegister.ForeColor = Color.Black;
            }    
        }

        private void passwordBoxRegister_Leave(object sender, EventArgs e)
        {
            if (passwordBoxRegister.Text == "")
            {
                passwordBoxRegister.UseSystemPasswordChar = false;
                passwordBoxRegister.Text = "Пароль";
                passwordBoxRegister.ForeColor = Color.Gray;
            }
        }


    }
}
