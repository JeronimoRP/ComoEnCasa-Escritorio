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
    public partial class AddIngredientFrm : Form
    {
        internal List<RecipeIngredient> SelectedRecipeIngredients { get; private set; }

        public AddIngredientFrm()
        {
            InitializeComponent();
            this.Load += AddIngredientsFrm_Load;

            // Enable multi-select for DataGridView
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.MultiSelect = true;

            SelectedRecipeIngredients = new List<RecipeIngredient>();
        }

        private async void AddIngredientsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<Ingredient> ingredientList= await Functions.GetAllIngredients();
                var sortedList=ingredientList.OrderBy(i=>i.name).ToList();
                dgvIngredients.DataSource = sortedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvIngredients.SelectedRows)
            {
                Ingredient ingredient = row.DataBoundItem as Ingredient;
                if (ingredient != null)
                {
                    RecipeIngredient recipeIngredient = new RecipeIngredient
                    {
                        ingredient = ingredient.name 
                    };
                    SelectedRecipeIngredients.Add(recipeIngredient);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
