using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace CookBookCreation
{
    public partial class OpenBookForm : Form
    {
        public static OpenBookForm instance;
        public RichTextBox ShowTitle;
       public int i = 0;
        List<string> Recipes = new List<string>();
        List<Image> FoodImages = new List<Image>();
        List<string> RecipeTitles = new List<string>();
        List<string> FoodImagestring = new List<string>();
        RecipeData Recipe = new RecipeData();
        SelectCalendarDay calendar = new SelectCalendarDay();
        public OpenBookForm() {
            InitializeComponent();
            instance = this;
            ShowTitle = ShowRecipeTitle;
            BookLoadingRecipe();
            if (RecipeTitles.Count == 0 || FoodImages.Count == 0 || Recipes.Count == 0) {
                AddToCalendarButton.Visible = false;
                RecipeListJump.Visible = false;
                PreviousFoodRecipeButton.Visible = false;
                NextFoodRecipeButton.Visible = false;
                DeleteRecipeButton.Visible = false;
                SaveRecipeEditButton.Visible = false;
                ChangeImageButton.Visible = false;
                RecipeShow.Text = "Your cook book is empty! Go to Add Recipes menu to add some recipes!";
                ShowRecipeTitle.Text = "no food :(";
                return;
            }
            i = 0;
            ShowRecipeTitle.Text = RecipeTitles[i];
            RecipeShow.Text = Recipes[i];
            ShowFoodImage.Image = FoodImages[i];
        }
        public Image resizeImage(Image imgToResize, Size size) {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public void SavingRecipe() {
            Recipe.Monday = CookBook.instance.MondayButton.Text;
            Recipe.Tuesday = CookBook.instance.TuesdayButton.Text;
            Recipe.Wednesday = CookBook.instance.WednesdayButton.Text;
            Recipe.Thursday = CookBook.instance.ThursdayButton.Text;
            Recipe.Friday = CookBook.instance.FridayButton.Text;
            Recipe.Saturday = CookBook.instance.SaturdayButton.Text;
            Recipe.Sunday = CookBook.instance.SundayButton.Text;
            Recipe.RecipeTitle.Clear();
            Recipe.recipedataRecipes.Clear();
            Recipe.Images.Clear();
            Recipe.RecipeTitle.AddRange(RecipeTitles);
            Recipe.recipedataRecipes.AddRange(Recipes);
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Image));
            foreach (Image Picture in FoodImages) {
                FoodImagestring.Add(Convert.ToBase64String((Byte[])converter.ConvertTo(Picture, typeof(Byte[]))));
            }
            Recipe.Images.AddRange(FoodImagestring);
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Create)) {
                xs.Serialize(fs, Recipe);
            }
            FoodImagestring.Clear();
            CookBook.instance.LoadingRecipe();
        }
        public void BookLoadingRecipe() {
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Open)) {
                Recipe = xs.Deserialize(fs) as RecipeData;
            }

            if (Recipe != null) {
                RecipeTitles.Clear();
                Recipes.Clear();
                RecipeTitles.AddRange(Recipe.RecipeTitle);
                Recipes.AddRange(Recipe.recipedataRecipes);
                FoodImages.Clear();
                foreach (string PictureString in Recipe.Images) {
                    Byte[] TheImageAsBytes = Convert.FromBase64String(PictureString);
                    MemoryStream MemStr = new MemoryStream(TheImageAsBytes);
                    Image I = Image.FromStream(MemStr);
                    FoodImages.Add(I);
                }
            }
            if (FoodImages.Count > 0 && Recipes.Count > 0) {
                RecipeListJump.Items.Clear();
                AddToCalendarButton.Visible = true;
                RecipeListJump.Visible = true;
                PreviousFoodRecipeButton.Visible = true;
                NextFoodRecipeButton.Visible = true;
                DeleteRecipeButton.Visible = true;
                SaveRecipeEditButton.Visible = true;
                ChangeImageButton.Visible = true;
                ShowRecipeTitle.Text = RecipeTitles[i];
                RecipeShow.Text = Recipes[i];
                ShowFoodImage.Image = FoodImages[i];
                int length = RecipeTitles.Count;
                System.Object[] ItemObject = new System.Object[length];
                for (int l = 0; l < length; l++) {
                    ItemObject[l] = RecipeTitles[l];
                }
                RecipeListJump.Items.AddRange(ItemObject);

            }
        }

        private void PreviousFoodRecipeButton_Click(object sender, EventArgs e) {
            if (i == 0) {
                return;
            }
            i--;
            ShowRecipeTitle.Text = RecipeTitles[i];
            RecipeShow.Text = Recipes[i];
            ShowFoodImage.Image = FoodImages[i];
        }

        private void NextFoodRecipeButton_Click(object sender, EventArgs e) {
            if (i == FoodImages.Count - 1) {
                return;
            }
            i++;
            ShowRecipeTitle.Text = RecipeTitles[i];
            RecipeShow.Text = Recipes[i];
            ShowFoodImage.Image = FoodImages[i];
        }

        private void SaveRecipeEditButton_Click(object sender, EventArgs e) {
            if (Recipes.Count == 0) {
                MessageBox.Show("There is nothing to save!");
                return;
            }
            if(CookBook.instance.MondayButton.Text == RecipeTitles[i]) { CookBook.instance.MondayButton.Text = ShowRecipeTitle.Text; }
            if(CookBook.instance.TuesdayButton.Text == RecipeTitles[i]) { CookBook.instance.TuesdayButton.Text = ShowRecipeTitle.Text; }
            if(CookBook.instance.WednesdayButton.Text == RecipeTitles[i]) { CookBook.instance.WednesdayButton.Text = ShowRecipeTitle.Text; }
            if (CookBook.instance.ThursdayButton.Text == RecipeTitles[i]) { CookBook.instance.ThursdayButton.Text = ShowRecipeTitle.Text; }
            if (CookBook.instance.FridayButton.Text == RecipeTitles[i]) { CookBook.instance.FridayButton.Text = ShowRecipeTitle.Text; }
            if (CookBook.instance.SaturdayButton.Text == RecipeTitles[i]) { CookBook.instance.SaturdayButton.Text = ShowRecipeTitle.Text; }
            if (CookBook.instance.SundayButton.Text == RecipeTitles[i]) { CookBook.instance.SundayButton.Text = ShowRecipeTitle.Text; }
            RecipeTitles.RemoveAt(i);
            Recipes.RemoveAt(i);
            FoodImages.RemoveAt(i);
            RecipeTitles.Add(ShowRecipeTitle.Text);
            RecipeTitles.Sort();
            int index = RecipeTitles.FindIndex(str => str.Contains(ShowRecipeTitle.Text));
            Recipes.Insert(index, RecipeShow.Text);
            FoodImages.Insert(index, ShowFoodImage.Image);
            SavingRecipe();
            BookLoadingRecipe();
            MessageBox.Show("Recipe succesfully changed and saved!");
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e) {
            if (Recipes.Count == 0) {
                MessageBox.Show("There is nothing to delete!");
                return;
            }
            if (CookBook.instance.MondayButton.Text == RecipeTitles[i]) { CookBook.instance.MondayButton.Text = "Empty"; }
            if (CookBook.instance.TuesdayButton.Text == RecipeTitles[i]) { CookBook.instance.TuesdayButton.Text = "Empty"; }
            if (CookBook.instance.WednesdayButton.Text == RecipeTitles[i]) { CookBook.instance.WednesdayButton.Text = "Empty"; }
            if (CookBook.instance.ThursdayButton.Text == RecipeTitles[i]) { CookBook.instance.ThursdayButton.Text = "Empty"; }
            if (CookBook.instance.FridayButton.Text == RecipeTitles[i]) { CookBook.instance.FridayButton.Text = "Empty"; }
            if (CookBook.instance.SaturdayButton.Text == RecipeTitles[i]) { CookBook.instance.SaturdayButton.Text = "Empty"; }
            if (CookBook.instance.SundayButton.Text == RecipeTitles[i]) { CookBook.instance.SundayButton.Text = "Empty"; }
            Recipes.RemoveAt(i);
            FoodImages.RemoveAt(i);
            RecipeTitles.RemoveAt(i);
            if (i > FoodImages.Count - 1) {
                i--;
            }
            SavingRecipe();
            BookLoadingRecipe();       
            if (FoodImages.Count == 0 || Recipes.Count == 0) {
                RecipeListJump.Visible = false;
                AddToCalendarButton.Visible = false;
                PreviousFoodRecipeButton.Visible = false;
                NextFoodRecipeButton.Visible = false;
                DeleteRecipeButton.Visible = false;
                SaveRecipeEditButton.Visible = false;
                ChangeImageButton.Visible = false;
                SavingRecipe();
                BookLoadingRecipe();
                ShowRecipeTitle.Text = "No Food :(";
                RecipeShow.Text = "Your cook book is empty! Go to Add Recipes menu to add some recipes!";
                ShowFoodImage.Image = null;
                i = 0;
                return;
            }
            ShowFoodImage.Image = FoodImages[i];
            RecipeShow.Text = Recipes[i];
        }

        private void ChangeImageButton_Click(object sender, EventArgs e) {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK) {
                Image image = Bitmap.FromFile(fileOpen.FileName);
                image = resizeImage(image, new Size(534, 674));
                ShowFoodImage.Image = image;
            }
            fileOpen.Dispose();
        }

        private void CloseAddRecipeButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void RecipeListJump_SelectedIndexChanged(object sender, EventArgs e) {
                int index = RecipeTitles.FindIndex(str => str.Contains(RecipeListJump.Text));
                i = index;
                ShowRecipeTitle.Text = RecipeTitles[i];
                RecipeShow.Text = Recipes[i];
                ShowFoodImage.Image = FoodImages[i];
            
        }

        private void AddToCalendarButton_Click(object sender, EventArgs e) {
            calendar.LoadingCalendar();
            calendar.Show();
        }
    }
}
