
namespace AutoWatermark
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
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pthumb = new System.Windows.Forms.PictureBox();
            this.pwater = new System.Windows.Forms.PictureBox();
            this.ptotal = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pthumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptotal)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(93, 68);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.start);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 68);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thumbnails";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Watermarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(300, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "0/0";
            // 
            // pthumb
            // 
            this.pthumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pthumb.Location = new System.Drawing.Point(178, 18);
            this.pthumb.Name = "pthumb";
            this.pthumb.Size = new System.Drawing.Size(106, 13);
            this.pthumb.TabIndex = 16;
            this.pthumb.TabStop = false;
            // 
            // pwater
            // 
            this.pwater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwater.Location = new System.Drawing.Point(178, 39);
            this.pwater.Name = "pwater";
            this.pwater.Size = new System.Drawing.Size(106, 13);
            this.pwater.TabIndex = 17;
            this.pwater.TabStop = false;
            // 
            // ptotal
            // 
            this.ptotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptotal.Location = new System.Drawing.Point(178, 58);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(106, 13);
            this.ptotal.TabIndex = 18;
            this.ptotal.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Location = new System.Drawing.Point(12, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(395, 183);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 281);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ptotal);
            this.Controls.Add(this.pwater);
            this.Controls.Add(this.pthumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "AutoWatermark";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pthumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pthumb;
        private System.Windows.Forms.PictureBox pwater;
        private System.Windows.Forms.PictureBox ptotal;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

