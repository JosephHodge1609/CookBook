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
    public partial class SelectCalendarDay : Form
    {
        List<string> Recipes = new List<string>();
        List<Image> FoodImages = new List<Image>();
        List<string> RecipeTitles = new List<string>();
        List<string> FoodImagestring = new List<string>();
        RecipeData Recipe = new RecipeData();
        public SelectCalendarDay() {
            InitializeComponent();
        }

        public void LoadingCalendar() {
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
                MondayMealButton.Text = Recipe.Monday;
                TuesdayMealButton.Text = Recipe.Tuesday;
                WednesdayMealButton.Text = Recipe.Wednesday;
                ThursdayMealButton.Text = Recipe.Thursday;
                FridayMealButton.Text = Recipe.Friday;
                SaturdayMealButton.Text = Recipe.Saturday;
                SundayMealButton.Text = Recipe.Sunday;

            }
        }

        public void SavingCalendar() {

            Recipe.Monday = MondayMealButton.Text;
            Recipe.Tuesday = TuesdayMealButton.Text;
            Recipe.Wednesday = WednesdayMealButton.Text;
            Recipe.Thursday = ThursdayMealButton.Text;
            Recipe.Friday = FridayMealButton.Text;
            Recipe.Saturday = SaturdayMealButton.Text;
            Recipe.Sunday = SundayMealButton.Text;
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Create)) {
                xs.Serialize(fs, Recipe);
            }
        }
        private void SaveCalendarButton_Click(object sender, EventArgs e) {
            SavingCalendar();
            MessageBox.Show("Calendar saved!");
        }

        private void CloseCalendarButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ClearCalendarButton_Click(object sender, EventArgs e) {
            MondayMealButton.Text = "Empty";
            TuesdayMealButton.Text = "Empty";
            WednesdayMealButton.Text = "Empty";
            ThursdayMealButton.Text = "Empty";
            FridayMealButton.Text = "Empty";
            SaturdayMealButton.Text = "Empty";
            SundayMealButton.Text = "Empty";
            CookBook.instance.MondayButton.Text = "Empty";
            CookBook.instance.TuesdayButton.Text = "Empty";
            CookBook.instance.WednesdayButton.Text = "Empty";
            CookBook.instance.ThursdayButton.Text = "Empty";
            CookBook.instance.FridayButton.Text = "Empty";
            CookBook.instance.SaturdayButton.Text = "Empty";
            CookBook.instance.SundayButton.Text = "Empty";
        }

        private void MondayMealButton_Click(object sender, EventArgs e) {
            MondayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.MondayButton.Text = MondayMealButton.Text;
        }

        private void TuesdayMealButton_Click(object sender, EventArgs e) {
            TuesdayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.TuesdayButton.Text = TuesdayMealButton.Text;
        }

        private void WednesdayMealButton_Click(object sender, EventArgs e) {
            WednesdayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.WednesdayButton.Text = WednesdayMealButton.Text;
        }

        private void ThursdayMealButton_Click(object sender, EventArgs e) {
            ThursdayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.ThursdayButton.Text = ThursdayMealButton.Text;
        }

        private void FridayMealButton_Click(object sender, EventArgs e) {
            FridayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.FridayButton.Text = FridayMealButton.Text;
        }

        private void SaturdayMealButton_Click(object sender, EventArgs e) {
            SaturdayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.SaturdayButton.Text = SaturdayMealButton.Text;
        }

        private void SundayMealButton_Click(object sender, EventArgs e) {
            SundayMealButton.Text = OpenBookForm.instance.ShowTitle.Text;
            CookBook.instance.SundayButton.Text = SundayMealButton.Text;
        }
    }
}
