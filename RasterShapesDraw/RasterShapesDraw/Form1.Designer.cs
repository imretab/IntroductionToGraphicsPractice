namespace RasterShapesDraw
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.checkPatternLabel = new System.Windows.Forms.Label();
            this.checkPatternBox = new System.Windows.Forms.TextBox();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(12, 12);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(149, 49);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.Text = "Use me to pick a color";
            this.colorPicker.UseVisualStyleBackColor = true;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chosen color:";
            // 
            // chosenColor
            // 
            this.chosenColor.Location = new System.Drawing.Point(12, 88);
            this.chosenColor.Name = "chosenColor";
            this.chosenColor.Size = new System.Drawing.Size(149, 62);
            this.chosenColor.TabIndex = 2;
            this.chosenColor.UseVisualStyleBackColor = true;
            this.chosenColor.Click += new System.EventHandler(this.chosenColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose from the selection below:";
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.Items.AddRange(new object[] {
            "Fill",
            "Check",
            "Noisy"});
            this.listBoxOptions.Location = new System.Drawing.Point(12, 170);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.Size = new System.Drawing.Size(149, 43);
            this.listBoxOptions.TabIndex = 5;
            this.listBoxOptions.SelectedIndexChanged += new System.EventHandler(this.listBoxOptions_SelectedIndexChanged);
            // 
            // checkPatternLabel
            // 
            this.checkPatternLabel.Location = new System.Drawing.Point(13, 216);
            this.checkPatternLabel.Name = "checkPatternLabel";
            this.checkPatternLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkPatternLabel.Size = new System.Drawing.Size(148, 31);
            this.checkPatternLabel.TabIndex = 6;
            this.checkPatternLabel.Text = "Choose the two points for checked pattern (x,y)";
            this.checkPatternLabel.Visible = false;
            // 
            // checkPatternBox
            // 
            this.checkPatternBox.Location = new System.Drawing.Point(12, 251);
            this.checkPatternBox.Name = "checkPatternBox";
            this.checkPatternBox.Size = new System.Drawing.Size(149, 20);
            this.checkPatternBox.TabIndex = 7;
            this.checkPatternBox.Visible = false;
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(12, 277);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(149, 61);
            this.btn_Draw.TabIndex = 8;
            this.btn_Draw.Text = "Draw";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(178, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(340, 326);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.checkPatternBox);
            this.Controls.Add(this.checkPatternLabel);
            this.Controls.Add(this.listBoxOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chosenColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chosenColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxOptions;
        private System.Windows.Forms.Label checkPatternLabel;
        private System.Windows.Forms.TextBox checkPatternBox;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

