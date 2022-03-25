
namespace CookBookCreation
{
    partial class OpenBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ShowRecipeTitle = new System.Windows.Forms.RichTextBox();
            this.ShowFoodImage = new System.Windows.Forms.PictureBox();
            this.PreviousFoodRecipeButton = new System.Windows.Forms.Button();
            this.NextFoodRecipeButton = new System.Windows.Forms.Button();
            this.SaveRecipeEditButton = new System.Windows.Forms.Button();
            this.DeleteRecipeButton = new System.Windows.Forms.Button();
            this.ChangeImageButton = new System.Windows.Forms.Button();
            this.CloseAddRecipeButton = new System.Windows.Forms.Button();
            this.RecipeShow = new System.Windows.Forms.RichTextBox();
            this.RecipeListJump = new System.Windows.Forms.ComboBox();
            this.AddToCalendarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowRecipeTitle
            // 
            this.ShowRecipeTitle.BackColor = System.Drawing.Color.Wheat;
            this.ShowRecipeTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRecipeTitle.Location = new System.Drawing.Point(350, 207);
            this.ShowRecipeTitle.Multiline = false;
            this.ShowRecipeTitle.Name = "ShowRecipeTitle";
            this.ShowRecipeTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ShowRecipeTitle.Size = new System.Drawing.Size(540, 64);
            this.ShowRecipeTitle.TabIndex = 29;
            this.ShowRecipeTitle.Text = "";
            this.ShowRecipeTitle.WordWrap = false;
            // 
            // ShowFoodImage
            // 
            this.ShowFoodImage.BackColor = System.Drawing.SystemColors.Info;
            this.ShowFoodImage.Location = new System.Drawing.Point(1105, 207);
            this.ShowFoodImage.Name = "ShowFoodImage";
            this.ShowFoodImage.Size = new System.Drawing.Size(534, 674);
            this.ShowFoodImage.TabIndex = 31;
            this.ShowFoodImage.TabStop = false;
            // 
            // PreviousFoodRecipeButton
            // 
            this.PreviousFoodRecipeButton.BackColor = System.Drawing.SystemColors.Control;
            this.PreviousFoodRecipeButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.PreviousFoodRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousFoodRecipeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousFoodRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousFoodRecipeButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousFoodRecipeButton.Location = new System.Drawing.Point(515, 887);
            this.PreviousFoodRecipeButton.Name = "PreviousFoodRecipeButton";
            this.PreviousFoodRecipeButton.Size = new System.Drawing.Size(210, 80);
            this.PreviousFoodRecipeButton.TabIndex = 32;
            this.PreviousFoodRecipeButton.Text = "Previous Recipe";
            this.PreviousFoodRecipeButton.UseVisualStyleBackColor = false;
            this.PreviousFoodRecipeButton.Click += new System.EventHandler(this.PreviousFoodRecipeButton_Click);
            // 
            // NextFoodRecipeButton
            // 
            this.NextFoodRecipeButton.BackColor = System.Drawing.Color.Yellow;
            this.NextFoodRecipeButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.NextFoodRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextFoodRecipeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextFoodRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextFoodRecipeButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextFoodRecipeButton.Location = new System.Drawing.Point(1279, 887);
            this.NextFoodRecipeButton.Name = "NextFoodRecipeButton";
            this.NextFoodRecipeButton.Size = new System.Drawing.Size(210, 80);
            this.NextFoodRecipeButton.TabIndex = 33;
            this.NextFoodRecipeButton.Text = "Next Recipe";
            this.NextFoodRecipeButton.UseVisualStyleBackColor = false;
            this.NextFoodRecipeButton.Click += new System.EventHandler(this.NextFoodRecipeButton_Click);
            // 
            // SaveRecipeEditButton
            // 
            this.SaveRecipeEditButton.BackColor = System.Drawing.Color.Yellow;
            this.SaveRecipeEditButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.SaveRecipeEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveRecipeEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveRecipeEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveRecipeEditButton.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRecipeEditButton.Location = new System.Drawing.Point(749, 887);
            this.SaveRecipeEditButton.Name = "SaveRecipeEditButton";
            this.SaveRecipeEditButton.Size = new System.Drawing.Size(210, 80);
            this.SaveRecipeEditButton.TabIndex = 34;
            this.SaveRecipeEditButton.Text = "Save Recipe Edit";
            this.SaveRecipeEditButton.UseVisualStyleBackColor = false;
            this.SaveRecipeEditButton.Click += new System.EventHandler(this.SaveRecipeEditButton_Click);
            // 
            // DeleteRecipeButton
            // 
            this.DeleteRecipeButton.BackColor = System.Drawing.Color.Yellow;
            this.DeleteRecipeButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.DeleteRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRecipeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteRecipeButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecipeButton.Location = new System.Drawing.Point(1517, 887);
            this.DeleteRecipeButton.Name = "DeleteRecipeButton";
            this.DeleteRecipeButton.Size = new System.Drawing.Size(210, 80);
            this.DeleteRecipeButton.TabIndex = 35;
            this.DeleteRecipeButton.Text = "Delete Recipe";
            this.DeleteRecipeButton.UseVisualStyleBackColor = false;
            this.DeleteRecipeButton.Click += new System.EventHandler(this.DeleteRecipeButton_Click);
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.ChangeImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeImageButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold);
            this.ChangeImageButton.Location = new System.Drawing.Point(1048, 888);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(210, 80);
            this.ChangeImageButton.TabIndex = 36;
            this.ChangeImageButton.Text = "Change Image";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // CloseAddRecipeButton
            // 
            this.CloseAddRecipeButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.CloseAddRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAddRecipeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAddRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseAddRecipeButton.Font = new System.Drawing.Font("Mistral", 27.75F);
            this.CloseAddRecipeButton.Location = new System.Drawing.Point(281, 887);
            this.CloseAddRecipeButton.Name = "CloseAddRecipeButton";
            this.CloseAddRecipeButton.Size = new System.Drawing.Size(210, 80);
            this.CloseAddRecipeButton.TabIndex = 37;
            this.CloseAddRecipeButton.Text = "Close";
            this.CloseAddRecipeButton.UseVisualStyleBackColor = true;
            this.CloseAddRecipeButton.Click += new System.EventHandler(this.CloseAddRecipeButton_Click);
            // 
            // RecipeShow
            // 
            this.RecipeShow.BackColor = System.Drawing.Color.Wheat;
            this.RecipeShow.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeShow.Location = new System.Drawing.Point(350, 286);
            this.RecipeShow.Name = "RecipeShow";
            this.RecipeShow.Size = new System.Drawing.Size(540, 595);
            this.RecipeShow.TabIndex = 38;
            this.RecipeShow.Text = "";
            // 
            // RecipeListJump
            // 
            this.RecipeListJump.BackColor = System.Drawing.Color.Wheat;
            this.RecipeListJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecipeListJump.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecipeListJump.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecipeListJump.FormattingEnabled = true;
            this.RecipeListJump.Location = new System.Drawing.Point(210, 286);
            this.RecipeListJump.Name = "RecipeListJump";
            this.RecipeListJump.Size = new System.Drawing.Size(121, 21);
            this.RecipeListJump.Sorted = true;
            this.RecipeListJump.TabIndex = 39;
            this.RecipeListJump.SelectedIndexChanged += new System.EventHandler(this.RecipeListJump_SelectedIndexChanged);
            // 
            // AddToCalendarButton
            // 
            this.AddToCalendarButton.BackColor = System.Drawing.Color.Yellow;
            this.AddToCalendarButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.AddToCalendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddToCalendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToCalendarButton.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCalendarButton.Location = new System.Drawing.Point(1645, 801);
            this.AddToCalendarButton.Name = "AddToCalendarButton";
            this.AddToCalendarButton.Size = new System.Drawing.Size(210, 80);
            this.AddToCalendarButton.TabIndex = 40;
            this.AddToCalendarButton.Text = "Add to Calendar";
            this.AddToCalendarButton.UseVisualStyleBackColor = false;
            this.AddToCalendarButton.Click += new System.EventHandler(this.AddToCalendarButton_Click);
            // 
            // OpenBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBookCreation.Properties.Resources.Adobe_20220317_221910;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2009, 1063);
            this.ControlBox = false;
            this.Controls.Add(this.AddToCalendarButton);
            this.Controls.Add(this.RecipeListJump);
            this.Controls.Add(this.RecipeShow);
            this.Controls.Add(this.CloseAddRecipeButton);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.DeleteRecipeButton);
            this.Controls.Add(this.SaveRecipeEditButton);
            this.Controls.Add(this.NextFoodRecipeButton);
            this.Controls.Add(this.PreviousFoodRecipeButton);
            this.Controls.Add(this.ShowFoodImage);
            this.Controls.Add(this.ShowRecipeTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "OpenBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cook Book";
            ((System.ComponentModel.ISupportInitialize)(this.ShowFoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PreviousFoodRecipeButton;
        private System.Windows.Forms.Button NextFoodRecipeButton;
        private System.Windows.Forms.Button SaveRecipeEditButton;
        private System.Windows.Forms.Button DeleteRecipeButton;
        private System.Windows.Forms.Button ChangeImageButton;
        private System.Windows.Forms.Button CloseAddRecipeButton;
        private System.Windows.Forms.ComboBox RecipeListJump;
        private System.Windows.Forms.Button AddToCalendarButton;
        public System.Windows.Forms.RichTextBox ShowRecipeTitle;
        public System.Windows.Forms.PictureBox ShowFoodImage;
        public System.Windows.Forms.RichTextBox RecipeShow;
    }
}