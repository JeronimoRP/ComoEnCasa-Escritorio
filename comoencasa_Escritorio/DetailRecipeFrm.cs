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
    public partial class DetailRecipeFrm : Form
    {
        private Recipe rec;
        private List<RecipeIngredient> recipeIngredients = new List<RecipeIngredient>();
        public DetailRecipeFrm(Recipe rec)
        {
            InitializeComponent();
            this.rec = rec;
            if (rec.id != 0)
            {
                txtId.Text = rec.id.ToString();
                txtName.Text = rec.name.ToString();
                txtDesc.Text = rec.description.ToString();
                txtUrl.Text=rec.photo.ToString();
                this.recipeIngredients = rec.ingredientsList.ToList();
                LoadIngredientData();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                this.rec.name = txtName.Text;
            }
            this.rec.description = txtDesc.Text;
            this.rec.photo = txtUrl.Text;
            this.rec.ingredientsList = this.recipeIngredients;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            AddIngredientFrm frm = new AddIngredientFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                recipeIngredients = frm.SelectedRecipeIngredients;
                LoadIngredientData();
            }
            else
            {
                MessageBox.Show("No se ha podido guardar la lista de ingredientes");
            }
        }
        private void LoadIngredientData()
        {
            dgvRecIng.Columns.Clear();
            dgvRecIng.DataSource = null;
            dgvRecIng.DataSource = recipeIngredients;
            dgvRecIng.Columns["ingredient"].HeaderText = "Ingrediente";
            dgvRecIng.Columns["quantity"].HeaderText = "Cantidad";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            ImageFrm frm = new ImageFrm(rec);
            frm.ShowDialog();
        }
    }
}
