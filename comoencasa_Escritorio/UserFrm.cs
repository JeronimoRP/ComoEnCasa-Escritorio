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

namespace comoencasa_Escritorio
{
    public partial class UserFrm : Form
    {
        User user = null;
        public UserFrm()
        {
            InitializeComponent();
            dgvUsers.SelectionChanged += CheckSelection;
            this.Load += UserFrm_Load;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar al usuario seleccionado?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                
                if (result == DialogResult.Yes)
                {  
                    await Functions.DeleteUser(user.id);
                    this.refreshData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refreshData()
        {
            loadData();
            dgvUsers.Refresh();
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void loadData()
        {
            List<User> users = await Functions.GetAllUsers();
            dgvUsers.DataSource = users;
            dgvUsers.Columns["id"].HeaderText = "ID";
            dgvUsers.Columns["name"].HeaderText = "Nombre";
            dgvUsers.Columns["email"].HeaderText = "Email";
            dgvUsers.Columns["password"].Visible = false;
        }

        private void CheckSelection(object sender, EventArgs e)
        {
            bool userSelected = dgvUsers.SelectedRows.Count > 0;
            if (userSelected)
            {
                DataGridViewRow dr = dgvUsers.SelectedRows[0];
                user = dr.DataBoundItem as User;
            }
            else
            {
                user = null;
            }
            btnDelete.Enabled = userSelected;
        }


    }
}
