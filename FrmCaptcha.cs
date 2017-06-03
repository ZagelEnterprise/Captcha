using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

//////////////
namespace Captcha
{
    public partial class FrmCaptcha : Form
    {         
        Random rand = new Random();
        string CaptchaCode,CaptchaPath;
        string CaptchaAlphabets;
        public FrmCaptcha()
        {
            InitializeComponent();
            CaptchaPath = "D:/CaptchaImage.bmp";
            CaptchaAlphabets = "abcdefghijklmnopqrstuvwxyz1234567890";
        }

        private void CreateImage()
        {
            string Code = GetRandomText();
            Bitmap bitmap = new Bitmap(200, 50, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);
            SolidBrush b = new SolidBrush(Color.Black);
            SolidBrush White = new SolidBrush(Color.White);
            int counter = 0;
            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);

            for (int i = 0; i < Code.Length; i++)
            {
                g.DrawString(Code[i].ToString(), new Font("Georgia", 10 + rand.Next(14, 18)), White, new PointF(10 + counter, 10));
                counter += 20;
            }
            DrawRandomLines(g);
            if (File.Exists(CaptchaPath))
            {
                try
                {
                    File.Delete(CaptchaPath);
                    bitmap.Save(CaptchaPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                bitmap.Save(CaptchaPath);
            }
            g.Dispose();
            bitmap.Dispose();
            CaptchaPathBox.Image = Image.FromFile(CaptchaPath);
        }

        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Green);
            for (int i = 0; i < 20; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }
        }

        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();
            if (String.IsNullOrEmpty(CaptchaCode))
            {
                Random r = new Random();
                for (int j = 0; j <= 5; j++)
                {
                    randomText.Append(CaptchaAlphabets[r.Next(CaptchaAlphabets.Length)]);
                }
                CaptchaCode = randomText.ToString();
            }
            return CaptchaCode;
        }

        private void FrmCaptcha_Load(object sender, EventArgs e)
        {
            CreateImage();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CaptchaPathBox.Image.Dispose();
            CaptchaCode = "";
            CreateImage();
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            if (TxtVerify.Text == CaptchaCode.ToString())
            {
                File.Delete(CaptchaPath);
                MessageBox.Show("تحقق ناجح ");
                Close();
            }
            else
            {
                MessageBox.Show("تحقق فاشل");
            }
        }


    }
}
