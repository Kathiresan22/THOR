namespace thor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgselectbtn = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.convert = new System.Windows.Forms.Button();
            this.tesspath_textbox = new System.Windows.Forms.TextBox();
            this.tesspath_btn = new System.Windows.Forms.Button();
            this.outputPath_textbox = new System.Windows.Forms.TextBox();
            this.outputpath_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thor.Properties.Resources.imgnotavail;
            this.pictureBox1.InitialImage = global::thor.Properties.Resources.imgnotavail;
            this.pictureBox1.Location = new System.Drawing.Point(24, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 360);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imgselectbtn
            // 
            this.imgselectbtn.Location = new System.Drawing.Point(86, 457);
            this.imgselectbtn.Name = "imgselectbtn";
            this.imgselectbtn.Size = new System.Drawing.Size(137, 23);
            this.imgselectbtn.TabIndex = 2;
            this.imgselectbtn.Text = "Select Image";
            this.imgselectbtn.UseVisualStyleBackColor = true;
            this.imgselectbtn.Click += new System.EventHandler(this.imgselectbtn_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("ELCOT-Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(394, 74);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(345, 360);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(494, 457);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(136, 23);
            this.convert.TabIndex = 4;
            this.convert.Text = "OCR";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // tesspath_textbox
            // 
            this.tesspath_textbox.Location = new System.Drawing.Point(24, 48);
            this.tesspath_textbox.Name = "tesspath_textbox";
            this.tesspath_textbox.Size = new System.Drawing.Size(152, 20);
            this.tesspath_textbox.TabIndex = 5;
            // 
            // tesspath_btn
            // 
            this.tesspath_btn.Location = new System.Drawing.Point(182, 45);
            this.tesspath_btn.Name = "tesspath_btn";
            this.tesspath_btn.Size = new System.Drawing.Size(75, 23);
            this.tesspath_btn.TabIndex = 6;
            this.tesspath_btn.Text = "Path";
            this.tesspath_btn.UseVisualStyleBackColor = true;
            this.tesspath_btn.Click += new System.EventHandler(this.tesspath_btn_Click);
            // 
            // outputPath_textbox
            // 
            this.outputPath_textbox.Location = new System.Drawing.Point(394, 47);
            this.outputPath_textbox.Name = "outputPath_textbox";
            this.outputPath_textbox.Size = new System.Drawing.Size(164, 20);
            this.outputPath_textbox.TabIndex = 7;
            // 
            // outputpath_btn
            // 
            this.outputpath_btn.Location = new System.Drawing.Point(565, 45);
            this.outputpath_btn.Name = "outputpath_btn";
            this.outputpath_btn.Size = new System.Drawing.Size(99, 23);
            this.outputpath_btn.TabIndex = 8;
            this.outputpath_btn.Text = "Output Path";
            this.outputpath_btn.UseVisualStyleBackColor = true;
            this.outputpath_btn.Click += new System.EventHandler(this.outputpath_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 522);
            this.Controls.Add(this.outputpath_btn);
            this.Controls.Add(this.outputPath_textbox);
            this.Controls.Add(this.tesspath_btn);
            this.Controls.Add(this.tesspath_textbox);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.imgselectbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button imgselectbtn;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox tesspath_textbox;
        private System.Windows.Forms.Button tesspath_btn;
        private System.Windows.Forms.TextBox outputPath_textbox;
        private System.Windows.Forms.Button outputpath_btn;
    }
}

