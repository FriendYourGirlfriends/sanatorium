using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Sanatorium
{
    public partial class Room : UserControl
    {
        private const string PATH = @"Rooms\Images\";
        private readonly List<string> _imageNames = new List<string>();
        private int _imageId = 0;
        
        public Room(string title, string description, List<string> imageName)
        {
            InitializeComponent();

            _title.Text = title;
            _description.Text = description;
            _imageNames = imageName;

            AddImageToPictureBox();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_imageId < _imageNames.Count - 1)
                _imageId++;
            else
                _imageId = 0;

            AddImageToPictureBox();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (_imageId > 0)
                _imageId--;
            else
                _imageId = _imageNames.Count - 1;

            AddImageToPictureBox();
        }

        private void AddImageToPictureBox()
        {
            try
            {
                if (_imageNames.Count > 0)
                    _pictureBox.Image = Image.FromFile(PATH + _imageNames[_imageId]);
            }
            catch(ArgumentOutOfRangeException)
            {

            }
            catch(FileNotFoundException)
            {

            }
        }
    }
}
