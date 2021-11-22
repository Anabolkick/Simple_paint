
namespace _7_lab_opi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.rect_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.line_btn = new System.Windows.Forms.Button();
            this.text_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.color_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // pencil_btn
            // 
            this.pencil_btn.Image = global::_7_lab_opi.Properties.Resources._600px_Black_pencil_svg;
            this.pencil_btn.Location = new System.Drawing.Point(74, 391);
            this.pencil_btn.MaximumSize = new System.Drawing.Size(60, 60);
            this.pencil_btn.MinimumSize = new System.Drawing.Size(60, 60);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(60, 60);
            this.pencil_btn.TabIndex = 6;
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // rect_btn
            // 
            this.rect_btn.Image = ((System.Drawing.Image)(resources.GetObject("rect_btn.Image")));
            this.rect_btn.Location = new System.Drawing.Point(74, 306);
            this.rect_btn.MaximumSize = new System.Drawing.Size(60, 60);
            this.rect_btn.MinimumSize = new System.Drawing.Size(60, 60);
            this.rect_btn.Name = "rect_btn";
            this.rect_btn.Size = new System.Drawing.Size(60, 60);
            this.rect_btn.TabIndex = 5;
            this.rect_btn.UseVisualStyleBackColor = true;
            this.rect_btn.Click += new System.EventHandler(this.rect_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.Image = ((System.Drawing.Image)(resources.GetObject("circle_btn.Image")));
            this.circle_btn.Location = new System.Drawing.Point(74, 220);
            this.circle_btn.MaximumSize = new System.Drawing.Size(60, 60);
            this.circle_btn.MinimumSize = new System.Drawing.Size(60, 60);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(60, 60);
            this.circle_btn.TabIndex = 4;
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // line_btn
            // 
            this.line_btn.Image = ((System.Drawing.Image)(resources.GetObject("line_btn.Image")));
            this.line_btn.Location = new System.Drawing.Point(74, 138);
            this.line_btn.MaximumSize = new System.Drawing.Size(60, 60);
            this.line_btn.MinimumSize = new System.Drawing.Size(60, 60);
            this.line_btn.Name = "line_btn";
            this.line_btn.Size = new System.Drawing.Size(60, 60);
            this.line_btn.TabIndex = 3;
            this.line_btn.UseVisualStyleBackColor = true;
            this.line_btn.Click += new System.EventHandler(this.line_btn_Click);
            // 
            // text_btn
            // 
            this.text_btn.Image = ((System.Drawing.Image)(resources.GetObject("text_btn.Image")));
            this.text_btn.Location = new System.Drawing.Point(74, 57);
            this.text_btn.MaximumSize = new System.Drawing.Size(60, 60);
            this.text_btn.MinimumSize = new System.Drawing.Size(60, 60);
            this.text_btn.Name = "text_btn";
            this.text_btn.Size = new System.Drawing.Size(60, 60);
            this.text_btn.TabIndex = 2;
            this.text_btn.UseVisualStyleBackColor = true;
            this.text_btn.Click += new System.EventHandler(this.text_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 544);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // color_btn
            // 
            this.color_btn.BackColor = System.Drawing.Color.White;
            this.color_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_btn.ForeColor = System.Drawing.Color.Black;
            this.color_btn.Image = global::_7_lab_opi.Properties.Resources.kisspng_color_wheel_rgb_color_model_color_gradient_complem_5b10870fdcaec1_4397657415278098079039;
            this.color_btn.Location = new System.Drawing.Point(69, 468);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(75, 65);
            this.color_btn.TabIndex = 0;
            this.color_btn.UseVisualStyleBackColor = false;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(40, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pencil_btn);
            this.Controls.Add(this.rect_btn);
            this.Controls.Add(this.circle_btn);
            this.Controls.Add(this.line_btn);
            this.Controls.Add(this.text_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.color_btn);
            this.Name = "Form1";
            this.Text = "Paint_2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button text_btn;
        private System.Windows.Forms.Button line_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Button rect_btn;
        private System.Windows.Forms.Button pencil_btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

