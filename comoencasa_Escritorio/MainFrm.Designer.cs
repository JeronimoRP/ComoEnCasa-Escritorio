namespace comoencasa_Escritorio
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pcbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblTitle.Location = new System.Drawing.Point(267, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hola";
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(12, 299);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.Size = new System.Drawing.Size(374, 328);
            this.dgvRecipes.TabIndex = 1;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblRecipe.Location = new System.Drawing.Point(141, 222);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(69, 20);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Recetas";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(406, 299);
            this.dgvIngredients.MultiSelect = false;
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.Size = new System.Drawing.Size(382, 328);
            this.dgvIngredients.TabIndex = 3;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblIngredients.Location = new System.Drawing.Point(568, 222);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(98, 20);
            this.lblIngredients.TabIndex = 4;
            this.lblIngredients.Text = "Ingredientes";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnAddRecipe.ForeColor = System.Drawing.Color.Black;
            this.btnAddRecipe.Location = new System.Drawing.Point(12, 270);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(127, 23);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Añadir receta";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.btnUpdateRecipe.Enabled = false;
            this.btnUpdateRecipe.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRecipe.Location = new System.Drawing.Point(145, 270);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateRecipe.TabIndex = 6;
            this.btnUpdateRecipe.Text = "Detalle receta";
            this.btnUpdateRecipe.UseVisualStyleBackColor = false;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(65)))), ((int)(((byte)(37)))));
            this.btnDeleteRecipe.Enabled = false;
            this.btnDeleteRecipe.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(272, 270);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteRecipe.TabIndex = 7;
            this.btnDeleteRecipe.Text = "Eliminar receta";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.Black;
            this.btnAddIngredient.Location = new System.Drawing.Point(406, 270);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(127, 23);
            this.btnAddIngredient.TabIndex = 8;
            this.btnAddIngredient.Text = "Añadir ingrediente";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.btnUpdateIngredient.Enabled = false;
            this.btnUpdateIngredient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateIngredient.Location = new System.Drawing.Point(539, 270);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateIngredient.TabIndex = 9;
            this.btnUpdateIngredient.Text = "Detalle ingrediente";
            this.btnUpdateIngredient.UseVisualStyleBackColor = false;
            this.btnUpdateIngredient.Click += new System.EventHandler(this.btnUpdateIngredient_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(65)))), ((int)(((byte)(37)))));
            this.btnDeleteIngredient.Enabled = false;
            this.btnDeleteIngredient.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(672, 270);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteIngredient.TabIndex = 10;
            this.btnDeleteIngredient.Text = "Eliminar ingrediente";
            this.btnDeleteIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_ClickAsync);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(342, 222);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(113, 42);
            this.btnUsers.TabIndex = 11;
            this.btnUsers.Text = "Ver usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pcbImg
            // 
            this.pcbImg.Image = ((System.Drawing.Image)(resources.GetObject("pcbImg.Image")));
            this.pcbImg.InitialImage = null;
            this.pcbImg.Location = new System.Drawing.Point(302, 37);
            this.pcbImg.Name = "pcbImg";
            this.pcbImg.Size = new System.Drawing.Size(192, 186);
            this.pcbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImg.TabIndex = 12;
            this.pcbImg.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.pcbImg);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnUpdateIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainFrm";
            this.Text = "Ventana Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnUpdateIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pcbImg;
    }
}

