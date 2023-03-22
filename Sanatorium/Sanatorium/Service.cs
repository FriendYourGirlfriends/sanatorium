using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sanatorium
{
    public partial class Service : UserControl
    {
        public Service(string title, string description, string imageName)
        {
            InitializeComponent();

            _title.Text = title;
            _description.Text = description;

            AddPictureToPictureBox(imageName);
        }

        public Service(params object[] parameters)
        {
            InitializeComponent();

            _title.Text = parameters[1].ToString();
            _description.Text = parameters[2].ToString();

            AddPictureToPictureBox(parameters[3].ToString());
        }

        private void AddPictureToPictureBox(string imageName)
        {
            try 
            { 
                _pictureBox.Image = Image.FromFile(@"Services\Images\" + imageName);
            }
            catch(FileNotFoundException)
            {

            }
        }
    }
}
