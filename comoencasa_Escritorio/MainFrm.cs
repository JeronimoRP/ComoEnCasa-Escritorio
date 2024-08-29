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
    public partial class MainFrm : Form
    {
        User user = LoginFrm.user;
        private Ingredient ing = null;
        private Recipe rec = null;
        public MainFrm()
        {
            InitializeComponent();
            lblTitle.Text = "Hola "+ user.name.ToUpper();
            dgvRecipes.SelectionChanged += CheckSelection;
            dgvIngredients.SelectionChanged += CheckSelection;
            this.Load += MainFrm_Load;

        }

        private void MainFrm_Load(object sender, EventArgs e)
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


        private async void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (rec != null)
            {
                await Functions.DeleteRecipe(rec.id);
                this.refreshData();
            }
        }

        private async void btnDeleteIngredient_ClickAsync(object sender, EventArgs e)
        {
            if (ing != null)
            {
                await Functions.DeleteIngredient(ing.id);
                this.refreshData();
            }
        }

        private void CheckSelection(object sender, EventArgs e)
        {

            bool recSelected = dgvRecipes.SelectedRows.Count > 0;
            bool ingSelected = dgvIngredients.SelectedRows.Count > 0;

            if (recSelected)
            {
                DataGridViewRow dr = dgvRecipes.SelectedRows[0];
                rec = dr.DataBoundItem as Recipe;
            }
            else
            {
                rec = null;
            }

            if (ingSelected)
            {
                DataGridViewRow dr = dgvIngredients.SelectedRows[0];
                ing = dr.DataBoundItem as Ingredient;
            }
            else
            {
                ing = null;
            }

            btnUpdateRecipe.Enabled = recSelected;
            btnDeleteRecipe.Enabled = recSelected;
            btnUpdateIngredient.Enabled = ingSelected;
            btnDeleteIngredient.Enabled = ingSelected;
        }

        private async void btnAddRecipe_Click(object sender, EventArgs e)
        {
            rec=new Recipe();
            DetailRecipeFrm frm = new DetailRecipeFrm(rec);
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(rec.name))
            {
                await Functions.CreateRecipe(rec);
                this.refreshData();
            }
            else
            {
                MessageBox.Show("No se ha podido guardar la receta porque es necesario especificar nombre");
            }


        }

        private async void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            if (rec != null)
            {
                DetailRecipeFrm frm = new DetailRecipeFrm(rec);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await Functions.UpdateRecipe(rec);
                    this.refreshData();
                }
                
            }
        }

        private void refreshData()
        {
            loadData();
            dgvRecipes.Refresh();
            dgvIngredients.Refresh();
        }
        private async void loadData()
        {
            List<Recipe> recipes = await Functions.GetAllRecipes();
            List<Ingredient> ingredients = await Functions.GetAllIngredients();
            var sortedRecipes = recipes.OrderBy(r => r.name).ToList();
            var sortedIngredients = ingredients.OrderBy(i => i.name).ToList();
            dgvRecipes.DataSource = sortedRecipes;
            dgvIngredients.DataSource = sortedIngredients;
            dgvRecipes.Columns["id"].HeaderText = "ID";
            dgvRecipes.Columns["name"].HeaderText = "Nombre";
            dgvRecipes.Columns["description"].HeaderText = "Descripción";
            dgvRecipes.Columns["photo"].Visible = false;
            dgvIngredients.Columns["id"].HeaderText="ID";
            dgvIngredients.Columns["name"].HeaderText = "Nombre";
            dgvIngredients.Columns["fromMonth"].HeaderText = "Desde";
            dgvIngredients.Columns["toMonth"].HeaderText = "Hasta";
            dgvIngredients.Columns["type"].HeaderText = "Tipo";
        }

        private async void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            if (ing != null)
            {
                DetailIngredientFrm frm = new DetailIngredientFrm(ing);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await Functions.UpdateIngredient(ing);
                    this.refreshData();
                }
                

            }
        }

        private async void btnAddIngredient_Click(object sender, EventArgs e)
        {
            ing = new Ingredient();
            DetailIngredientFrm frm = new DetailIngredientFrm(ing);
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(ing.name) && !string.IsNullOrEmpty(ing.type))
            {
                await Functions.CreateIngredient(ing);
                this.refreshData();
            }
            else
            {
                MessageBox.Show("No se ha podido guardar el ingrediente porque es necesario especificar nombre y tipo");
            }
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserFrm frm = new UserFrm();
            frm.ShowDialog();
        }
    }
}
