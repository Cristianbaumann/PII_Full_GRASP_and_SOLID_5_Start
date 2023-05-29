using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextContetnt textContet)
        {
            File.WriteAllText("Recipe.txt", textContet.GetTextToPrint());
        }
    }
}