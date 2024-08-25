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
    public partial class DetailIngredientFrm : Form
    {
        private Ingredient ingredient;
        public DetailIngredientFrm(Ingredient ing)
        {
            InitializeComponent();
            this.ingredient = ing;
            if(ingredient.id != 0)
            {
                txtId.Text=ingredient.id.ToString();
                txtName.Text=ingredient.name.ToString();
                cmbFrom.SelectedIndex = ingredient.fromMonth - 1;
                cmbTo.SelectedIndex = ingredient.toMonth - 1;
                txtType.Text=ingredient.type.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ingredient.name = txtName.Text;
            ingredient.type = txtType.Text;
            ingredient.fromMonth = cmbFrom.SelectedIndex+1;
            ingredient.toMonth = cmbTo.SelectedIndex+1;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
