using System.Drawing;
using System.Windows.Forms;

namespace ImgFinder
{
    static class Import
    {
        public static Image importFunc() 
        { 
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                fileOpen.Dispose();
                return Image.FromFile(fileOpen.FileName);
            }
            return null;
        }
    }
}
