using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class label_KetQua : Form
    {
        public label_KetQua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "show image")
            {
                pictureBox1.Visible = true;
                button1.Text = "hide image";
            }
            else
            {
                pictureBox1.Visible = false;
                button1.Text = "show image";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
