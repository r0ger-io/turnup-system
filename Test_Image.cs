using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCM_4_FUN
{
    public partial class Test_Image : Form
    {
        string fileName;
        /*List<TB_IMAGEM> list;*/
        public Test_Image()
        {
            InitializeComponent();
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            /*using (PicEntities db = new PicEntities())
            {
                TB_IMAGEM pic = new TB_IMAGEM()
                {
                    NOME_IMG = fileName,
                    IMG = ConvertImageToBinary(picTest.Image)
                };
                db.TB_IMAGEM.Add(pic);
                await db.SaveChangesAsync();
                MessageBox.Show("Você teve sucesso no salvamento!", "Mensagem de Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPG|*.jpg;*.jpeg|PNG|*.png",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    lblName.Text = fileName;
                    picTest.Image = Image.FromFile(fileName);
                }
            }
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream a = new MemoryStream(data))
            {
                return Image.FromStream(a);
            }
        }



        private void Test_Image_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listView1.FocusedItem != null)
            {
                picTest.Image = ConvertBinaryToImage(list[listView1.FocusedItem.Index].IMG);
                lblName.Text = listView1.FocusedItem.SubItems[0].Text;
            }*/
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*listView1.Items.Clear();
            using (PicEntities db = new PicEntities())
            {
                list = db.TB_IMAGEM.ToList();
                foreach (TB_IMAGEM pic in list)
                {
                    ListViewItem item = new ListViewItem(pic.NOME_IMG);
                    listView1.Items.Add(item);
                    }
            }*/
        }
    }
}
