using System.Drawing.Imaging;

namespace project_main
{
    public partial class Form1 : Form
    {
        Bitmap img;
        Bitmap originalImg;
        Bitmap subImg;
        Bitmap resizedSubImg;

        Label labelThreshold;
        TextBox txtThreshold;
        Button btnStartBinarization;

        Label labelMultiThreshold;
        TextBox txtMultiThreshold;
        Button btnStartMultiThresholding;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG i JPG|*.png;*.jpg|PNG|*.png|JPG|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                originalImg = new Bitmap(pictureBox1.Image);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Zapisano plik");
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);
                    pxl = Color.FromArgb(0, 0, 0);
                    img.SetPixel(x, y, pxl);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = originalImg;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            labelThreshold.Visible = false;
            txtThreshold.Visible = false;
            btnStartBinarization.Visible = false;
            txtMultiThreshold.Visible = false;
            labelMultiThreshold.Visible = false;
            btnStartMultiThresholding.Visible = false;
            labelSubImg.Visible = false;
            loadSubImg.Visible = false;
            pictureBox3.Visible = false;
            btnStartSubImage.Visible = false;
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);
                    pxl = Color.FromArgb(pxl.R, 0, 0);
                    img.SetPixel(x, y, pxl);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);
                    pxl = Color.FromArgb(0, pxl.G, 0);
                    img.SetPixel(x, y, pxl);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);
                    pxl = Color.FromArgb(0, 0, pxl.B);
                    img.SetPixel(x, y, pxl);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //rgb to hsv conversion algorithm function
        public static void RgbToHsv(Color rgb, out double hue, out double saturation, out double value)
        {
            double r = rgb.R / 255.0;
            double g = rgb.G / 255.0;
            double b = rgb.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            value = max;

            if (delta == 0)
            {
                hue = 0;
                saturation = 0;
            }
            else
            {
                saturation = delta / max;

                if (r == max)
                {
                    hue = (g - b) / delta;
                }
                else if (g == max)
                {
                    hue = 2 + (b - r) / delta;
                }
                else
                {
                    hue = 4 + (r - g) / delta;
                }

                hue *= 60;
                if (hue < 0)
                {
                    hue += 360;
                }
            }
        }

        private void rgbToHsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);

                    double hue, saturation, value;
                    RgbToHsv(pxl, out hue, out saturation, out value);

                    //setting the hsv value in the rgb range (0-255)
                    int hInt = (int)Math.Round(hue / 360 * 255);
                    int sInt = (int)Math.Round(saturation * 255);
                    int vInt = (int)Math.Round(value * 255);

                    Color newColor = Color.FromArgb(pxl.A, hInt, sInt, vInt);
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void rgbToYuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x 

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);

                    double Y = 0.299 * pxl.R + 0.587 * pxl.G + 0.114 * pxl.B;
                    double U = 0.493 * (pxl.B - Y);
                    double V = 0.877 * (pxl.R - Y);

                    //setting the yub value in the rgb range (0-255)
                    int yInt = Math.Max(0, Math.Min(255, (int)Math.Round(Y)));
                    int uInt = Math.Max(0, Math.Min(255, (int)Math.Round(U + 128)));
                    int vInt = Math.Max(0, Math.Min(255, (int)Math.Round(V + 128)));

                    Color newColor = Color.FromArgb(pxl.A, yInt, uInt, vInt);
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void grayMeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);

                    int grayValue = (int)(pxl.R + pxl.G + pxl.B) / 3;

                    Color newColor = Color.FromArgb(pxl.A, grayValue, grayValue, grayValue);
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void grayYuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pxl = img.GetPixel(x, y);

                    double Y = 0.299 * pxl.R + 0.587 * pxl.G + 0.114 * pxl.B;

                    int grayValue = (int)Math.Round(Y);

                    Color newColor = Color.FromArgb(pxl.A, grayValue, grayValue, grayValue);
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //histogram calculating function
        private int[] calculateHistogram(Bitmap img)
        {
            int[] histogram = new int[256];
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pxl = img.GetPixel(x, y);
                    int grayValue = (pxl.R + pxl.G + pxl.B) / 3;
                    histogram[grayValue]++;
                }
            }
            return histogram;
        }
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int height = img.Height; //y
            int width = img.Width; //x

            int[] histogram = calculateHistogram(img);

            //histogram normalization
            int maxCount = histogram.Max();
            for (int i = 0; i < histogram.Length; i++)
            {
                histogram[i] = (int)((double)histogram[i] / maxCount * (pictureBox2.Height - 20));
            }

            Bitmap histogramImage = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            //drawing a chart
            using (Graphics g = Graphics.FromImage(histogramImage))
            {
                g.Clear(Color.White);

                g.DrawLine(Pens.Black, 10, pictureBox2.Height - 10, pictureBox2.Width - 10, pictureBox2.Height - 10);
                g.DrawLine(Pens.Black, 10, pictureBox2.Height - 10, 10, 10);

                for (int i = 0; i < histogram.Length; i++)
                {
                    int x = 10 + i * (pictureBox2.Width - 20) / 255;
                    int y = pictureBox2.Height - 10 - histogram[i];
                    g.FillRectangle(Brushes.Black, x, y, 2, histogram[i]);
                }

            }

            pictureBox2.Image = histogramImage;
        }

        private void setThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtThreshold.Visible && labelThreshold.Visible && btnStartBinarization.Visible)
            {
                txtThreshold.Visible = false;
                labelThreshold.Visible = false;
                btnStartBinarization.Visible = false;
            }
            else
            {
                txtThreshold.Visible = true;
                labelThreshold.Visible = true;
                btnStartBinarization.Visible = true;
                txtThreshold.Focus();
            }
        }

        //image binarization function
        private Bitmap binarizeImage(Bitmap image, int threshold)
        {
            Bitmap binarizedImage = new Bitmap(image);

            for (int y = 0; y < binarizedImage.Height; y++)
            {
                for (int x = 0; x < binarizedImage.Width; x++)
                {
                    Color pxl = binarizedImage.GetPixel(x, y);

                    int grayValue = (pxl.R + pxl.G + pxl.B) / 3;

                    Color newColor;
                    if (grayValue >= threshold)
                    {
                        newColor = Color.White;
                    }
                    else
                    {
                        newColor = Color.Black;
                    }
                    binarizedImage.SetPixel(x, y, newColor);
                }
            }

            return binarizedImage;
        }
        private void btnStartBinarization_Click(object sender, EventArgs e)
        {
            int threshold;

            if (!int.TryParse(txtThreshold.Text, out threshold) || threshold < 0 || threshold > 255)
            {
                MessageBox.Show("Podaj poprawny próg (0-255).");
                return;
            }

            img = new Bitmap(originalImg);

            img = binarizeImage(img, threshold);

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //labelThreshold.Visible = false;
            //txtThreshold.Visible = false;
            //btnStartBinarization.Visible = false;
        }

        private void histogramThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            int[] histogram = calculateHistogram(img);

            int threshold = Array.IndexOf(histogram, histogram.Max());

            img = new Bitmap(originalImg);

            img = binarizeImage(img, threshold);

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //labelThreshold.Visible = false;
            //txtThreshold.Visible = false;
            //btnStartBinarization.Visible = false;
        }

        private void setMultiThresholdingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtMultiThreshold.Visible && labelMultiThreshold.Visible && txtThreshold.Visible && labelThreshold.Visible && btnStartMultiThresholding.Visible)
            {
                txtMultiThreshold.Visible = false;
                labelMultiThreshold.Visible = false;
                txtThreshold.Visible = false;
                labelThreshold.Visible = false;
                btnStartMultiThresholding.Visible = false;
            }
            else
            {
                txtMultiThreshold.Visible = true;
                labelMultiThreshold.Visible = true;
                txtThreshold.Visible = true;
                labelThreshold.Visible = true;
                btnStartMultiThresholding.Visible = true;
            }
        }

        private void btnStartMultiThresholding_Click(object sender, EventArgs e)
        {
            int threshold1, threshold2;

            if (!int.TryParse(txtMultiThreshold.Text, out threshold1) || threshold1 < 0 || threshold1 > 255)
            {
                MessageBox.Show("Podaj poprawny próg 1 (0-255).");
                return;
            }
            if (!int.TryParse(txtThreshold.Text, out threshold2) || threshold2 < 0 || threshold2 > 255 || threshold2 <= threshold1)
            {
                MessageBox.Show("Podaj poprawny próg 2 (0-255, wiêkszy od progu 1).");
                return;
            }


            img = new Bitmap(originalImg);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pxl = img.GetPixel(x, y);

                    int grayValue = (pxl.R + pxl.G + pxl.B) / 3;

                    Color newColor;
                    if (grayValue >= threshold1 && grayValue <= threshold2)
                    {
                        newColor = Color.White;
                    }
                    else
                    {
                        newColor = Color.Black;
                    }
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            //txtMultiThreshold.Visible = false;
            //labelMultiThreshold.Visible = false;
            //txtThreshold.Visible = false;
            //labelThreshold.Visible = false;
            //btnStartMultiThresholding.Visible = false;
        }

        private void subImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelSubImg.Visible && loadSubImg.Visible && pictureBox3.Visible && btnStartSubImage.Visible)
            {
                labelSubImg.Visible = false;
                loadSubImg.Visible = false;
                pictureBox3.Visible = false;
                btnStartSubImage.Visible = false;
            }
            else
            {
                labelSubImg.Visible = true;
                loadSubImg.Visible = true;
                pictureBox3.Visible = true;
                btnStartSubImage.Visible = true;
            }
        }

        private void loadSubImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                subImg = new Bitmap(pictureBox3.Image);
            }
        }

        private void btnStartSubImage_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);
            subImg = new Bitmap(subImg);
            resizedSubImg = new Bitmap(subImg, img.Size);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color imgPxl = img.GetPixel(x, y);
                    Color resizedSubImgPxl = resizedSubImg.GetPixel(x, y);

                    int grayValueImg = (imgPxl.R + imgPxl.G + imgPxl.B) / 3;
                    int grayValueResizedSubImg = (resizedSubImgPxl.R + resizedSubImgPxl.G + resizedSubImgPxl.B) / 3;

                    int resultGray = Math.Max(grayValueImg - grayValueResizedSubImg, 0);

                    Color newColor = Color.FromArgb(resultGray, resultGray, resultGray);
                    resizedSubImg.SetPixel(x, y, newColor);

                }
            }

            pictureBox2.Image = resizedSubImg;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //horizontal edge detection fuction
        private Bitmap horizontalEdgeDetection(Bitmap image)
        {
            img = new Bitmap(image);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 1; x < img.Width; x++)
                {
                    Color currentPxl = img.GetPixel(x, y);
                    Color leftPxl = img.GetPixel(x - 1, y);

                    int grayCurrent = (currentPxl.R + currentPxl.G + currentPxl.B) / 3;
                    int grayLeft = (leftPxl.R + leftPxl.G + leftPxl.B) / 3;

                    int diff = Math.Abs(grayCurrent - grayLeft);
                    diff = Math.Max(diff, 0);

                    Color newColor = Color.FromArgb(diff, diff, diff);
                    img.SetPixel(x, y, newColor);
                }
            }

            return img;
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);
            img = horizontalEdgeDetection(img);

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //vertical edge detection fuction
        private Bitmap verticalEdgeDetection(Bitmap image)
        {
            img = new Bitmap(originalImg);

            for (int y = 1; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color currentPxl = img.GetPixel(x, y);
                    Color leftPxl = img.GetPixel(x, y - 1);

                    int grayCurrent = (currentPxl.R + currentPxl.G + currentPxl.B) / 3;
                    int grayTop = (leftPxl.R + leftPxl.G + leftPxl.B) / 3;

                    int diff = Math.Abs(grayCurrent - grayTop);
                    diff = Math.Max(diff, 0);

                    Color newColor = Color.FromArgb(diff, diff, diff);
                    img.SetPixel(x, y, newColor);
                }
            }

            return img;
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);
            img = verticalEdgeDetection(img);

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //oblique edge detection fuction
        private Bitmap obliqueEdgeDetection(Bitmap image)
        {
            img = new Bitmap(image);

            for (int y = 1; y < img.Height; y++)
            {
                for (int x = 1; x < img.Width; x++)
                {
                    Color currentPxl = img.GetPixel(x, y);
                    Color leftPxl = img.GetPixel(x - 1, y - 1);

                    int grayCurrent = (currentPxl.R + currentPxl.G + currentPxl.B) / 3;
                    int grayDiagonal = (leftPxl.R + leftPxl.G + leftPxl.B) / 3;

                    int diff = Math.Abs(grayCurrent - grayDiagonal);
                    diff = Math.Max(diff, 0);

                    Color newColor = Color.FromArgb(diff, diff, diff);
                    img.SetPixel(x, y, newColor);
                }
            }

            return img;
        }
        private void obliqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);
            img = obliqueEdgeDetection(img);

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void connectEdgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img = new Bitmap(originalImg);

            Bitmap horizontalEdgeDetectionImg = new Bitmap(img);
            horizontalEdgeDetectionImg = horizontalEdgeDetection(img);
            Bitmap verticalEdgeDetectionImg = new Bitmap(img);
            verticalEdgeDetectionImg = verticalEdgeDetection(img);
            Bitmap obliqueEdgeDetectionImg = new Bitmap(img);
            obliqueEdgeDetectionImg = obliqueEdgeDetection(img);

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    int combinedValue = horizontalEdgeDetectionImg.GetPixel(x, y).R + verticalEdgeDetectionImg.GetPixel(x, y).R + obliqueEdgeDetectionImg.GetPixel(x, y).R;
                    combinedValue = Math.Min(combinedValue, 255);

                    Color newColor = Color.FromArgb(combinedValue, combinedValue, combinedValue);
                    img.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}