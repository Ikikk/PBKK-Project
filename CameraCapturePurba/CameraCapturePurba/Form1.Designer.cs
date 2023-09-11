namespace CameraCapturePurba
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
            buttonStart = new Button();
            comboBoxCamera = new ComboBox();
            pictureBoxCam = new PictureBox();
            labelCamera = new Label();
            pictureBoxResult = new PictureBox();
            buttonCapture = new Button();
            buttonSaveImg = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(511, 32);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "&Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // comboBoxCamera
            // 
            comboBoxCamera.FormattingEnabled = true;
            comboBoxCamera.Location = new Point(104, 33);
            comboBoxCamera.Name = "comboBoxCamera";
            comboBoxCamera.Size = new Size(374, 28);
            comboBoxCamera.TabIndex = 1;
            // 
            // pictureBoxCam
            // 
            pictureBoxCam.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCam.Location = new Point(27, 91);
            pictureBoxCam.Name = "pictureBoxCam";
            pictureBoxCam.Size = new Size(475, 267);
            pictureBoxCam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCam.TabIndex = 3;
            pictureBoxCam.TabStop = false;
            // 
            // labelCamera
            // 
            labelCamera.AutoSize = true;
            labelCamera.Location = new Point(27, 36);
            labelCamera.Name = "labelCamera";
            labelCamera.Size = new Size(71, 20);
            labelCamera.TabIndex = 4;
            labelCamera.Text = "Camera : ";
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxResult.Location = new Point(511, 91);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(475, 267);
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.TabIndex = 5;
            pictureBoxResult.TabStop = false;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(611, 32);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(94, 29);
            buttonCapture.TabIndex = 6;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // buttonSaveImg
            // 
            buttonSaveImg.Location = new Point(892, 374);
            buttonSaveImg.Name = "buttonSaveImg";
            buttonSaveImg.Size = new Size(94, 29);
            buttonSaveImg.TabIndex = 7;
            buttonSaveImg.Text = "Save Image";
            buttonSaveImg.UseVisualStyleBackColor = true;
            buttonSaveImg.Click += buttonSaveImg_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(892, 36);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "&Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 423);
            Controls.Add(button1);
            Controls.Add(buttonSaveImg);
            Controls.Add(buttonCapture);
            Controls.Add(pictureBoxResult);
            Controls.Add(labelCamera);
            Controls.Add(pictureBoxCam);
            Controls.Add(comboBoxCamera);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Webcam Purba";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private ComboBox comboBoxCamera;
        private PictureBox pictureBoxCam;
        private Label labelCamera;
        private PictureBox pictureBoxResult;
        private Button buttonCapture;
        private Button buttonSaveImg;
        private Button button1;
    }
}