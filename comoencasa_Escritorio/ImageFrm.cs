using comoencasa_Escritorio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comoencasa_Escritorio
{
    public partial class ImageFrm : Form
    {
        private Recipe recipe=new Recipe();
        private static Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        public ImageFrm(Recipe rec)
        {
            InitializeComponent();
            this.recipe = rec;
            lblName.LinkClicked += lblName_LinkClicked;
            this.loadData();
            
        }

        private async void loadData()
        {
            if (!string.IsNullOrEmpty(recipe.photo))
            {
                try
                {
                    pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbImage.Image = await GetCachedImage(recipe.photo);
                    lblName.Text = recipe.name;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }
            }
        }

        private async Task<Image> GetCachedImage(string url)
        {
            if (imageCache.ContainsKey(url))
            {
                return imageCache[url];
            }
            else
            {
                using (var httpClient = new HttpClient())
                {
                    var imageStream = await httpClient.GetStreamAsync(url);
                    Image image = Image.FromStream(imageStream);
                    imageCache[url] = image; 
                    return image;
                }
            }
        }

        private void lblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(recipe.photo))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = recipe.photo,
                    UseShellExecute = true
                });
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
