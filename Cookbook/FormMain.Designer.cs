namespace Cookbook
{
    partial class FormMain
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
            this.cookbookDataSet = new Cookbook.CookbookDataSet();
            this.labelRecipies = new System.Windows.Forms.Label();
            this.listRecipies = new System.Windows.Forms.ListBox();
            this.listRecipeIngredients = new System.Windows.Forms.ListBox();
            this.labelRecipeIngredients = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.textRecipeName = new System.Windows.Forms.TextBox();
            this.buttonUpdateRecipeName = new System.Windows.Forms.Button();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.labelAllIngredients = new System.Windows.Forms.Label();
            this.buttonAddToRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "CookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelRecipies
            // 
            this.labelRecipies.AutoSize = true;
            this.labelRecipies.Location = new System.Drawing.Point(9, 89);
            this.labelRecipies.Name = "labelRecipies";
            this.labelRecipies.Size = new System.Drawing.Size(48, 13);
            this.labelRecipies.TabIndex = 0;
            this.labelRecipies.Text = "Recipies";
            // 
            // listRecipies
            // 
            this.listRecipies.FormattingEnabled = true;
            this.listRecipies.Location = new System.Drawing.Point(12, 105);
            this.listRecipies.Name = "listRecipies";
            this.listRecipies.Size = new System.Drawing.Size(120, 160);
            this.listRecipies.TabIndex = 1;
            this.listRecipies.SelectedIndexChanged += new System.EventHandler(this.listRecipies_SelectedIndexChanged);
            // 
            // listRecipeIngredients
            // 
            this.listRecipeIngredients.FormattingEnabled = true;
            this.listRecipeIngredients.Location = new System.Drawing.Point(17, 293);
            this.listRecipeIngredients.Name = "listRecipeIngredients";
            this.listRecipeIngredients.Size = new System.Drawing.Size(115, 238);
            this.listRecipeIngredients.TabIndex = 3;
            // 
            // labelRecipeIngredients
            // 
            this.labelRecipeIngredients.AutoSize = true;
            this.labelRecipeIngredients.Location = new System.Drawing.Point(14, 277);
            this.labelRecipeIngredients.Name = "labelRecipeIngredients";
            this.labelRecipeIngredients.Size = new System.Drawing.Size(98, 13);
            this.labelRecipeIngredients.TabIndex = 2;
            this.labelRecipeIngredients.Text = "Recipie Ingredients";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(12, 63);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecipe.TabIndex = 4;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // textRecipeName
            // 
            this.textRecipeName.Location = new System.Drawing.Point(12, 37);
            this.textRecipeName.Name = "textRecipeName";
            this.textRecipeName.Size = new System.Drawing.Size(170, 20);
            this.textRecipeName.TabIndex = 5;
            // 
            // buttonUpdateRecipeName
            // 
            this.buttonUpdateRecipeName.Location = new System.Drawing.Point(93, 63);
            this.buttonUpdateRecipeName.Name = "buttonUpdateRecipeName";
            this.buttonUpdateRecipeName.Size = new System.Drawing.Size(89, 23);
            this.buttonUpdateRecipeName.TabIndex = 6;
            this.buttonUpdateRecipeName.Text = "Update Name";
            this.buttonUpdateRecipeName.UseVisualStyleBackColor = true;
            this.buttonUpdateRecipeName.Click += new System.EventHandler(this.buttonUpdateRecipeName_Click);
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.Location = new System.Drawing.Point(196, 105);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(120, 160);
            this.listAllIngredients.TabIndex = 8;
            // 
            // labelAllIngredients
            // 
            this.labelAllIngredients.AutoSize = true;
            this.labelAllIngredients.Location = new System.Drawing.Point(193, 89);
            this.labelAllIngredients.Name = "labelAllIngredients";
            this.labelAllIngredients.Size = new System.Drawing.Size(73, 13);
            this.labelAllIngredients.TabIndex = 7;
            this.labelAllIngredients.Text = "All Ingredients";
            // 
            // buttonAddToRecipe
            // 
            this.buttonAddToRecipe.Location = new System.Drawing.Point(322, 173);
            this.buttonAddToRecipe.Name = "buttonAddToRecipe";
            this.buttonAddToRecipe.Size = new System.Drawing.Size(89, 23);
            this.buttonAddToRecipe.TabIndex = 9;
            this.buttonAddToRecipe.Text = "Add to Recipe";
            this.buttonAddToRecipe.UseVisualStyleBackColor = true;
            this.buttonAddToRecipe.Click += new System.EventHandler(this.buttonAddToRecipe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 548);
            this.Controls.Add(this.buttonAddToRecipe);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.labelAllIngredients);
            this.Controls.Add(this.buttonUpdateRecipeName);
            this.Controls.Add(this.textRecipeName);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.listRecipeIngredients);
            this.Controls.Add(this.labelRecipeIngredients);
            this.Controls.Add(this.listRecipies);
            this.Controls.Add(this.labelRecipies);
            this.Name = "FormMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label labelRecipies;
        private System.Windows.Forms.ListBox listRecipies;
        private System.Windows.Forms.ListBox listRecipeIngredients;
        private System.Windows.Forms.Label labelRecipeIngredients;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.TextBox textRecipeName;
        private System.Windows.Forms.Button buttonUpdateRecipeName;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Label labelAllIngredients;
        private System.Windows.Forms.Button buttonAddToRecipe;
    }
}

