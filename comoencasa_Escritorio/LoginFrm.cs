using comoencasa_Escritorio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace comoencasa_Escritorio
{
    public partial class LoginFrm : Form
    {
        public static User user = null;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            var email=txtEmail.Text;
            var password=txtPassword.Text;
            if((email != null && email!= string.Empty) && (password != null  && password!=string.Empty)) 
            {
                try
                {
                    var response = await Functions.LoginAsync(email, password);
                    user = response;
                    if(user != null)
                    {
                        if (user.id == 252 || user.id == 253)
                        {
                            MessageBox.Show("Acceso autorizado");
                            MainFrm mainFrm = new MainFrm();
                            mainFrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no autorizado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed: " + ex.Message);
                }
            }

        }
    }
}
