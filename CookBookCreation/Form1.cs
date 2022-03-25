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
    public partial class CookBook : Form {
        public static CookBook instance;
        public Button MondayButton;
        public Button TuesdayButton;
        public Button WednesdayButton;
        public Button ThursdayButton;
        public Button FridayButton;
        public Button SaturdayButton;
        public Button SundayButton;
        List<string> Recipes = new List<string>();
        List<Image> FoodImages = new List<Image>();
        List<string> RecipeTitles = new List<string>();
        List<string> FoodImagestring = new List<string>();
        RecipeData Recipe = new RecipeData();
        AddRecipe addrecipe = new AddRecipe();
        OpenBookForm OpenBook = new OpenBookForm();
        public CookBook() {
            InitializeComponent();
            instance = this;
            MondayButton = MondayMealButton;
            TuesdayButton = TuesdayMealButton;
            WednesdayButton = WednesdayMealButton;
            ThursdayButton = ThursdayMealButton;
            FridayButton = FridayMealButton;
            SaturdayButton = SaturdayMealButton;
            SundayButton = SundayMealButton;
            LoadingRecipe();
        }
        public void LoadingRecipe() {
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Open)) {
                Recipe = xs.Deserialize(fs) as RecipeData;
            }

            if (Recipe != null) {
                MondayMealButton.Text = Recipe.Monday;
                TuesdayMealButton.Text = Recipe.Tuesday;
                WednesdayMealButton.Text = Recipe.Wednesday;
                ThursdayMealButton.Text = Recipe.Thursday;
                FridayMealButton.Text = Recipe.Friday;
                SaturdayMealButton.Text = Recipe.Saturday;
                SundayMealButton.Text = Recipe.Sunday;
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
        }
        
        private void OpenCookBook_Click(object sender, EventArgs e) {
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
        }

        private void AddRecipe_Click(object sender, EventArgs e) {
            addrecipe.Show();
        }

        private void ExitProgramButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MondayMealButton_Click(object sender, EventArgs e) {
            if(MondayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            int index = RecipeTitles.FindIndex(str => str.Contains(MondayMealButton.Text));
            int i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
            OpenBook.i = index;
            OpenBook.Show();
        }

        private void TuesdayMealButton_Click(object sender, EventArgs e) {
            if (TuesdayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            int index = RecipeTitles.FindIndex(str => str.Contains(TuesdayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.BookLoadingRecipe();
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
            OpenBook.Show();
            
        }

        private void WednesdayMealButton_Click(object sender, EventArgs e) {
            if (WednesdayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
            int index = RecipeTitles.FindIndex(str => str.Contains(WednesdayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
        }

        private void ThursdayMealButton_Click(object sender, EventArgs e) {
            if (ThursdayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
            int index = RecipeTitles.FindIndex(str => str.Contains(ThursdayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
        }

        private void FridayMealButton_Click(object sender, EventArgs e) {
            if (FridayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
            int index = RecipeTitles.FindIndex(str => str.Contains(FridayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
        }

        private void SaturdayMealButton_Click(object sender, EventArgs e) {
            if (SaturdayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
            int index = RecipeTitles.FindIndex(str => str.Contains(SaturdayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
        }

        private void SundayMealButton_Click(object sender, EventArgs e) {
            if (SundayMealButton.Text == "Empty") {
                MessageBox.Show("Open your cook book to add food to your calendar!");
                return;
            }
            OpenBook.BookLoadingRecipe();
            OpenBook.Show();
            int index = RecipeTitles.FindIndex(str => str.Contains(SundayMealButton.Text));
            int i = index;
            OpenBook.i = index;
            OpenBook.ShowRecipeTitle.Text = RecipeTitles[i];
            OpenBook.RecipeShow.Text = Recipes[i];
            OpenBook.ShowFoodImage.Image = FoodImages[i];
        }
    }
    
}