namespace comoencasa_Escritorio
{
    partial class DetailRecipeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblIng = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.dgvRecIng = new System.Windows.Forms.DataGridView();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecIng)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblId.Location = new System.Drawing.Point(29, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblName.Location = new System.Drawing.Point(29, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblImg.Location = new System.Drawing.Point(29, 110);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(42, 13);
            this.lblImg.TabIndex = 2;
            this.lblImg.Text = "Imagen";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblDesc.Location = new System.Drawing.Point(28, 180);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descripción";
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(98)))));
            this.lblIng.Location = new System.Drawing.Point(29, 378);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(65, 13);
            this.lblIng.TabIndex = 4;
            this.lblIng.Text = "Ingredientes";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(238, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(129, 177);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(238, 189);
            this.txtDesc.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(162)))));
            this.btnSave.Location = new System.Drawing.Point(430, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(65)))), ((int)(((byte)(37)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(430, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(129, 110);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(238, 20);
            this.txtUrl.TabIndex = 10;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.btnAddIngredients.Location = new System.Drawing.Point(393, 159);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(133, 23);
            this.btnAddIngredients.TabIndex = 12;
            this.btnAddIngredients.Text = "Añadir ingredientes";
            this.btnAddIngredients.UseVisualStyleBackColor = false;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // dgvRecIng
            // 
            this.dgvRecIng.AllowUserToAddRows = false;
            this.dgvRecIng.AllowUserToDeleteRows = false;
            this.dgvRecIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecIng.Location = new System.Drawing.Point(129, 378);
            this.dgvRecIng.Name = "dgvRecIng";
            this.dgvRecIng.Size = new System.Drawing.Size(240, 150);
            this.dgvRecIng.TabIndex = 13;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.btnImage.Location = new System.Drawing.Point(129, 137);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(127, 23);
            this.btnImage.TabIndex = 14;
            this.btnImage.Text = "Ver imagen";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // DetailRecipeFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(538, 551);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.dgvRecIng);
            this.Controls.Add(this.btnAddIngredients);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "DetailRecipeFrm";
            this.Text = "Detalle receta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecIng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.DataGridView dgvRecIng;
        private System.Windows.Forms.Button btnImage;
    }
}