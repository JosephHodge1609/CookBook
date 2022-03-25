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
    [Serializable, XmlRoot(ElementName = "Root", Namespace = "CookBook Project")]
    public class RecipeData
    {
      public List<string> RecipeTitle = new List<string>();
      public List<string> recipedataRecipes = new List<string>();
      public List<string> Images = new List<string>();
        public string Monday;
        public string Tuesday;
        public string Wednesday;
        public string Thursday;
        public string Friday;
        public string Saturday;
        public string Sunday;
        


    }
}