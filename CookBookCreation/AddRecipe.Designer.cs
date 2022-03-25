
namespace CookBookCreation
{
    partial class AddRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipe));
            this.UserInputImage = new System.Windows.Forms.PictureBox();
            this.UserInputRecipe = new System.Windows.Forms.RichTextBox();
            this.UserInputTitle = new System.Windows.Forms.RichTextBox();
            this.SubmitRecipe = new System.Windows.Forms.Button();
            this.UserAddImageButton = new System.Windows.Forms.Button();
            this.CloseAddRecipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserInputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInputImage
            // 
            this.UserInputImage.BackColor = System.Drawing.SystemColors.Info;
            this.UserInputImage.Location = new System.Drawing.Point(1131, 118);
            this.UserInputImage.Name = "UserInputImage";
            this.UserInputImage.Size = new System.Drawing.Size(534, 674);
            this.UserInputImage.TabIndex = 22;
            this.UserInputImage.TabStop = false;
            // 
            // UserInputRecipe
            // 
            this.UserInputRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserInputRecipe.BackColor = System.Drawing.Color.Wheat;
            this.UserInputRecipe.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputRecipe.Location = new System.Drawing.Point(367, 232);
            this.UserInputRecipe.Name = "UserInputRecipe";
            this.UserInputRecipe.Size = new System.Drawing.Size(540, 595);
            this.UserInputRecipe.TabIndex = 23;
            this.UserInputRecipe.Text = resources.GetString("UserInputRecipe.Text");
            // 
            // UserInputTitle
            // 
            this.UserInputTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserInputTitle.BackColor = System.Drawing.Color.Wheat;
            this.UserInputTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.UserInputTitle.Location = new System.Drawing.Point(367, 150);
            this.UserInputTitle.Name = "UserInputTitle";
            this.UserInputTitle.Size = new System.Drawing.Size(540, 64);
            this.UserInputTitle.TabIndex = 26;
            this.UserInputTitle.Text = "Add your Recipe Title here!";
            // 
            // SubmitRecipe
            // 
            this.SubmitRecipe.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.SubmitRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitRecipe.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitRecipe.Location = new System.Drawing.Point(870, 833);
            this.SubmitRecipe.Name = "SubmitRecipe";
            this.SubmitRecipe.Size = new System.Drawing.Size(235, 95);
            this.SubmitRecipe.TabIndex = 27;
            this.SubmitRecipe.Text = "Submit Recipe";
            this.SubmitRecipe.UseVisualStyleBackColor = true;
            this.SubmitRecipe.Click += new System.EventHandler(this.SubmitRecipe_Click_1);
            // 
            // UserAddImageButton
            // 
            this.UserAddImageButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.UserAddImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserAddImageButton.Font = new System.Drawing.Font("Mistral", 27.75F);
            this.UserAddImageButton.Location = new System.Drawing.Point(1288, 798);
            this.UserAddImageButton.Name = "UserAddImageButton";
            this.UserAddImageButton.Size = new System.Drawing.Size(235, 95);
            this.UserAddImageButton.TabIndex = 29;
            this.UserAddImageButton.Text = "Add Image";
            this.UserAddImageButton.UseVisualStyleBackColor = true;
            this.UserAddImageButton.Click += new System.EventHandler(this.UserAddImageButton_Click_1);
            // 
            // CloseAddRecipeButton
            // 
            this.CloseAddRecipeButton.BackgroundImage = global::CookBookCreation.Properties.Resources.CookBook__2_;
            this.CloseAddRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAddRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseAddRecipeButton.Font = new System.Drawing.Font("Mistral", 27.75F);
            this.CloseAddRecipeButton.Location = new System.Drawing.Point(436, 833);
            this.CloseAddRecipeButton.Name = "CloseAddRecipeButton";
            this.CloseAddRecipeButton.Size = new System.Drawing.Size(235, 95);
            this.CloseAddRecipeButton.TabIndex = 30;
            this.CloseAddRecipeButton.Text = "Close";
            this.CloseAddRecipeButton.UseVisualStyleBackColor = true;
            this.CloseAddRecipeButton.Click += new System.EventHandler(this.CloseAddRecipeButton_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBookCreation.Properties.Resources.createrecipe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2009, 1063);
            this.ControlBox = false;
            this.Controls.Add(this.CloseAddRecipeButton);
            this.Controls.Add(this.UserAddImageButton);
            this.Controls.Add(this.SubmitRecipe);
            this.Controls.Add(this.UserInputTitle);
            this.Controls.Add(this.UserInputRecipe);
            this.Controls.Add(this.UserInputImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.UserInputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UserInputImage;
        private System.Windows.Forms.RichTextBox UserInputRecipe;
        private System.Windows.Forms.RichTextBox UserInputTitle;
        private System.Windows.Forms.Button SubmitRecipe;
        private System.Windows.Forms.Button UserAddImageButton;
        private System.Windows.Forms.Button CloseAddRecipeButton;
    }
}