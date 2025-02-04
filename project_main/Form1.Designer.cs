namespace project_main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMultiThreshold = new Label();
            txtMultiThreshold = new TextBox();
            labelThreshold = new Label();
            txtThreshold = new TextBox();
            menuStrip1 = new MenuStrip();
            rGBToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            gToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            operationToolStripMenuItem = new ToolStripMenuItem();
            rgbToHsvToolStripMenuItem = new ToolStripMenuItem();
            rgbToYuvToolStripMenuItem = new ToolStripMenuItem();
            grayMeanToolStripMenuItem = new ToolStripMenuItem();
            grayYuvToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            binarizationToolStripMenuItem = new ToolStripMenuItem();
            thresholdingToolStripMenuItem = new ToolStripMenuItem();
            setThresholdToolStripMenuItem = new ToolStripMenuItem();
            histogramThresholdToolStripMenuItem = new ToolStripMenuItem();
            setMultiThresholdingToolStripMenuItem = new ToolStripMenuItem();
            subImagesToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            obliqueToolStripMenuItem = new ToolStripMenuItem();
            connectEdgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonZero = new Button();
            buttonReset = new Button();
            btnStartBinarization = new Button();
            btnStartMultiThresholding = new Button();
            labelSubImg = new Label();
            loadSubImg = new Button();
            pictureBox3 = new PictureBox();
            btnStartSubImage = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelMultiThreshold
            // 
            labelMultiThreshold.Location = new Point(350, 80);
            labelMultiThreshold.Name = "labelMultiThreshold";
            labelMultiThreshold.Size = new Size(100, 24);
            labelMultiThreshold.TabIndex = 13;
            labelMultiThreshold.Text = "Próg:";
            labelMultiThreshold.TextAlign = ContentAlignment.MiddleCenter;
            labelMultiThreshold.Visible = false;
            // 
            // txtMultiThreshold
            // 
            txtMultiThreshold.Location = new Point(350, 110);
            txtMultiThreshold.Name = "txtMultiThreshold";
            txtMultiThreshold.Size = new Size(100, 23);
            txtMultiThreshold.TabIndex = 14;
            txtMultiThreshold.Visible = false;
            // 
            // labelThreshold
            // 
            labelThreshold.Location = new Point(350, 140);
            labelThreshold.Name = "labelThreshold";
            labelThreshold.Size = new Size(100, 24);
            labelThreshold.TabIndex = 15;
            labelThreshold.Text = "Próg:";
            labelThreshold.TextAlign = ContentAlignment.MiddleCenter;
            labelThreshold.Visible = false;
            // 
            // txtThreshold
            // 
            txtThreshold.Location = new Point(350, 170);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(100, 23);
            txtThreshold.TabIndex = 0;
            txtThreshold.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rGBToolStripMenuItem, operationToolStripMenuItem, binarizationToolStripMenuItem, subImagesToolStripMenuItem, edgeDetectionToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // rGBToolStripMenuItem
            // 
            rGBToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rToolStripMenuItem, gToolStripMenuItem, bToolStripMenuItem });
            rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            rGBToolStripMenuItem.Size = new Size(41, 20);
            rGBToolStripMenuItem.Text = "RGB";
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(82, 22);
            rToolStripMenuItem.Text = "R";
            rToolStripMenuItem.Click += rToolStripMenuItem_Click;
            // 
            // gToolStripMenuItem
            // 
            gToolStripMenuItem.Name = "gToolStripMenuItem";
            gToolStripMenuItem.Size = new Size(82, 22);
            gToolStripMenuItem.Text = "G";
            gToolStripMenuItem.Click += gToolStripMenuItem_Click;
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(82, 22);
            bToolStripMenuItem.Text = "B";
            bToolStripMenuItem.Click += bToolStripMenuItem_Click;
            // 
            // operationToolStripMenuItem
            // 
            operationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rgbToHsvToolStripMenuItem, rgbToYuvToolStripMenuItem, grayMeanToolStripMenuItem, grayYuvToolStripMenuItem, histogramToolStripMenuItem });
            operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            operationToolStripMenuItem.Size = new Size(123, 20);
            operationToolStripMenuItem.Text = "Operacje na obrazie";
            // 
            // rgbToHsvToolStripMenuItem
            // 
            rgbToHsvToolStripMenuItem.Name = "rgbToHsvToolStripMenuItem";
            rgbToHsvToolStripMenuItem.Size = new Size(209, 22);
            rgbToHsvToolStripMenuItem.Text = "RGB -> HSV";
            rgbToHsvToolStripMenuItem.Click += rgbToHsvToolStripMenuItem_Click;
            // 
            // rgbToYuvToolStripMenuItem
            // 
            rgbToYuvToolStripMenuItem.Name = "rgbToYuvToolStripMenuItem";
            rgbToYuvToolStripMenuItem.Size = new Size(209, 22);
            rgbToYuvToolStripMenuItem.Text = "RGB -> YUV";
            rgbToYuvToolStripMenuItem.Click += rgbToYuvToolStripMenuItem_Click;
            // 
            // grayMeanToolStripMenuItem
            // 
            grayMeanToolStripMenuItem.Name = "grayMeanToolStripMenuItem";
            grayMeanToolStripMenuItem.Size = new Size(209, 22);
            grayMeanToolStripMenuItem.Text = "Szarość (metoda średniej)";
            grayMeanToolStripMenuItem.Click += grayMeanToolStripMenuItem_Click;
            // 
            // grayYuvToolStripMenuItem
            // 
            grayYuvToolStripMenuItem.Name = "grayYuvToolStripMenuItem";
            grayYuvToolStripMenuItem.Size = new Size(209, 22);
            grayYuvToolStripMenuItem.Text = "Szarość (z modelu YUV)";
            grayYuvToolStripMenuItem.Click += grayYuvToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(209, 22);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // binarizationToolStripMenuItem
            // 
            binarizationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thresholdingToolStripMenuItem, setMultiThresholdingToolStripMenuItem });
            binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            binarizationToolStripMenuItem.Size = new Size(78, 20);
            binarizationToolStripMenuItem.Text = "Binaryzacja";
            // 
            // thresholdingToolStripMenuItem
            // 
            thresholdingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setThresholdToolStripMenuItem, histogramThresholdToolStripMenuItem });
            thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            thresholdingToolStripMenuItem.Size = new Size(165, 22);
            thresholdingToolStripMenuItem.Text = "Progowanie";
            // 
            // setThresholdToolStripMenuItem
            // 
            setThresholdToolStripMenuItem.Name = "setThresholdToolStripMenuItem";
            setThresholdToolStripMenuItem.Size = new Size(164, 22);
            setThresholdToolStripMenuItem.Text = "Ustaw próg";
            setThresholdToolStripMenuItem.Click += setThresholdToolStripMenuItem_Click;
            // 
            // histogramThresholdToolStripMenuItem
            // 
            histogramThresholdToolStripMenuItem.Name = "histogramThresholdToolStripMenuItem";
            histogramThresholdToolStripMenuItem.Size = new Size(164, 22);
            histogramThresholdToolStripMenuItem.Text = "Próg (histogram)";
            histogramThresholdToolStripMenuItem.Click += histogramThresholdToolStripMenuItem_Click;
            // 
            // setMultiThresholdingToolStripMenuItem
            // 
            setMultiThresholdingToolStripMenuItem.Name = "setMultiThresholdingToolStripMenuItem";
            setMultiThresholdingToolStripMenuItem.Size = new Size(165, 22);
            setMultiThresholdingToolStripMenuItem.Text = "Multiprogowanie";
            setMultiThresholdingToolStripMenuItem.Click += setMultiThresholdingToolStripMenuItem_Click;
            // 
            // subImagesToolStripMenuItem
            // 
            subImagesToolStripMenuItem.Name = "subImagesToolStripMenuItem";
            subImagesToolStripMenuItem.Size = new Size(141, 20);
            subImagesToolStripMenuItem.Text = "Odejmowanie obrazów";
            subImagesToolStripMenuItem.Click += subImagesToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horizontalToolStripMenuItem, verticalToolStripMenuItem, obliqueToolStripMenuItem, connectEdgeDetectionToolStripMenuItem });
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(132, 20);
            edgeDetectionToolStripMenuItem.Text = "Wykrywanie krawędzi";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(180, 22);
            horizontalToolStripMenuItem.Text = "Poziome";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(180, 22);
            verticalToolStripMenuItem.Text = "Pionowe";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // obliqueToolStripMenuItem
            // 
            obliqueToolStripMenuItem.Name = "obliqueToolStripMenuItem";
            obliqueToolStripMenuItem.Size = new Size(180, 22);
            obliqueToolStripMenuItem.Text = "Ukośne";
            obliqueToolStripMenuItem.Click += obliqueToolStripMenuItem_Click;
            // 
            // connectEdgeDetectionToolStripMenuItem
            // 
            connectEdgeDetectionToolStripMenuItem.Name = "connectEdgeDetectionToolStripMenuItem";
            connectEdgeDetectionToolStripMenuItem.Size = new Size(180, 22);
            connectEdgeDetectionToolStripMenuItem.Text = "Połączone operacje";
            connectEdgeDetectionToolStripMenuItem.Click += connectEdgeDetectionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Obraz bazowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 39);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Obraz wynikowy";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 270);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(457, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 270);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(44, 364);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "Wgraj";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(44, 397);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(141, 364);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(75, 23);
            buttonZero.TabIndex = 6;
            buttonZero.Text = "Zeruj";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(141, 397);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // btnStartBinarization
            // 
            btnStartBinarization.Location = new Point(360, 210);
            btnStartBinarization.Name = "btnStartBinarization";
            btnStartBinarization.Size = new Size(80, 24);
            btnStartBinarization.TabIndex = 1;
            btnStartBinarization.Text = "Start";
            btnStartBinarization.Visible = false;
            btnStartBinarization.Click += btnStartBinarization_Click;
            // 
            // btnStartMultiThresholding
            // 
            btnStartMultiThresholding.Location = new Point(360, 210);
            btnStartMultiThresholding.Name = "btnStartMultiThresholding";
            btnStartMultiThresholding.Size = new Size(80, 24);
            btnStartMultiThresholding.TabIndex = 1;
            btnStartMultiThresholding.Text = "Start";
            btnStartMultiThresholding.Visible = false;
            btnStartMultiThresholding.Click += btnStartMultiThresholding_Click;
            // 
            // labelSubImg
            // 
            labelSubImg.AutoSize = true;
            labelSubImg.Location = new Point(341, 237);
            labelSubImg.Name = "labelSubImg";
            labelSubImg.Size = new Size(110, 15);
            labelSubImg.TabIndex = 9;
            labelSubImg.Text = "Obraz odejmowany";
            labelSubImg.Visible = false;
            // 
            // loadSubImg
            // 
            loadSubImg.Location = new Point(360, 269);
            loadSubImg.Name = "loadSubImg";
            loadSubImg.Size = new Size(75, 23);
            loadSubImg.TabIndex = 10;
            loadSubImg.Text = "Wgraj";
            loadSubImg.UseVisualStyleBackColor = true;
            loadSubImg.Visible = false;
            loadSubImg.Click += loadSubImg_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(349, 305);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 99);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // btnStartSubImage
            // 
            btnStartSubImage.Location = new Point(360, 415);
            btnStartSubImage.Name = "btnStartSubImage";
            btnStartSubImage.Size = new Size(75, 23);
            btnStartSubImage.TabIndex = 12;
            btnStartSubImage.Text = "Start";
            btnStartSubImage.UseVisualStyleBackColor = true;
            btnStartSubImage.Visible = false;
            btnStartSubImage.Click += btnStartSubImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSubImg);
            Controls.Add(btnStartSubImage);
            Controls.Add(pictureBox3);
            Controls.Add(loadSubImg);
            Controls.Add(labelMultiThreshold);
            Controls.Add(txtMultiThreshold);
            Controls.Add(btnStartMultiThresholding);
            Controls.Add(labelThreshold);
            Controls.Add(txtThreshold);
            Controls.Add(btnStartBinarization);
            Controls.Add(buttonReset);
            Controls.Add(buttonZero);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem rGBToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ToolStripMenuItem gToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonZero;
        private Button buttonReset;
        private ToolStripMenuItem operationToolStripMenuItem;
        private ToolStripMenuItem rgbToHsvToolStripMenuItem;
        private ToolStripMenuItem rgbToYuvToolStripMenuItem;
        private ToolStripMenuItem grayMeanToolStripMenuItem;
        private ToolStripMenuItem grayYuvToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem binarizationToolStripMenuItem;
        private ToolStripMenuItem thresholdingToolStripMenuItem;
        private ToolStripMenuItem setThresholdToolStripMenuItem;
        private ToolStripMenuItem histogramThresholdToolStripMenuItem;
        private ToolStripMenuItem setMultiThresholdingToolStripMenuItem;
        private ToolStripMenuItem subImagesToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label labelSubImg;
        private Button loadSubImg;
        private PictureBox pictureBox3;
        private Button btnStartSubImage;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem obliqueToolStripMenuItem;
        private ToolStripMenuItem connectEdgeDetectionToolStripMenuItem;
    }
}