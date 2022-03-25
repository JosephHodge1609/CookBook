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
    public partial class AddRecipe : Form
    {
        RecipeData Recipe = new RecipeData();
        public AddRecipe() {
            InitializeComponent();
        }
        public Image resizeImage(Image imgToResize, Size size) {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void UserAddImageButton_Click_1(object sender, EventArgs e) {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK) {
                Image image = Bitmap.FromFile(fileOpen.FileName);
                image = resizeImage(image, new Size(534, 674));
                UserInputImage.Image = image;
            }
            fileOpen.Dispose();
        }

        private void SubmitRecipe_Click_1(object sender, EventArgs e) {
            bool isNullOrEmpty = UserInputImage == null || UserInputImage.Image == null;
            if (isNullOrEmpty == true || UserInputRecipe.Text == "" || UserInputTitle.Text == "") {
                MessageBox.Show("You need to add an image, input recipe text, and input a recipe title if you want to submit a new recipe!");
                return;
            }
            SavingRecipe();
            UserInputRecipe.Text = "Enter your Recipe here! Once you're finished, click the" + "Add Image" + "button to add the Food image to your recipe. NOTE: You must add a recipe image otherwise you will not be able to submit your recipe. Once you're finished, simply click the" + "Add Recipe" + "button to submit your new recipe!";
            UserInputTitle.Text = "Enter your Recipe Title here!";  
            MessageBox.Show("Recipe saved and added!");
        }

        public void SavingRecipe() {
            RecipeLoadingRecipe();
            Recipe.RecipeTitle.Add(UserInputTitle.Text);
            Recipe.RecipeTitle.Sort();
            int index = Recipe.RecipeTitle.FindIndex(str => str.Contains(UserInputTitle.Text));
            Recipe.recipedataRecipes.Insert(index, UserInputRecipe.Text);
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Image));   
            Recipe.Images.Insert(index, (Convert.ToBase64String((Byte[])converter.ConvertTo(UserInputImage.Image, typeof(Byte[])))));
            UserInputImage.Image = null;
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Create)) {
                xs.Serialize(fs, Recipe);
            }
        }
        public void RecipeLoadingRecipe() {
            XmlSerializer xs = new XmlSerializer(typeof(RecipeData));
            using (FileStream fs = new FileStream("RecipeData.xml", FileMode.Open)) {
                Recipe = xs.Deserialize(fs) as RecipeData;
            }
        }
        private void CloseAddRecipeButton_Click(object sender, EventArgs e) {
            CookBook.instance.LoadingRecipe();
            this.Hide();
        }
    }
}
