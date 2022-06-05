namespace WF_Image
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
            this._start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._prev = new System.Windows.Forms.Button();
            this._openf = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _start
            // 
            this._start.Image = ((System.Drawing.Image)(resources.GetObject("_start.Image")));
            this._start.Location = new System.Drawing.Point(374, 408);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(143, 75);
            this._start.TabIndex = 0;
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this._start_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(785, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 75);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _prev
            // 
            this._prev.Image = ((System.Drawing.Image)(resources.GetObject("_prev.Image")));
            this._prev.Location = new System.Drawing.Point(261, 408);
            this._prev.Name = "_prev";
            this._prev.Size = new System.Drawing.Size(107, 75);
            this._prev.TabIndex = 2;
            this._prev.UseVisualStyleBackColor = true;
            this._prev.Click += new System.EventHandler(this._prev_Click);
            // 
            // _openf
            // 
            this._openf.Location = new System.Drawing.Point(330, 507);
            this._openf.Name = "_openf";
            this._openf.Size = new System.Drawing.Size(246, 55);
            this._openf.TabIndex = 3;
            this._openf.Text = "Открыть папку";
            this._openf.UseVisualStyleBackColor = true;
            this._openf.Click += new System.EventHandler(this._openf_Click);
            // 
            // _next
            // 
            this._next.Image = ((System.Drawing.Image)(resources.GetObject("_next.Image")));
            this._next.Location = new System.Drawing.Point(523, 408);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(107, 75);
            this._next.TabIndex = 4;
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this._next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._next);
            this.Controls.Add(this._openf);
            this.Controls.Add(this._prev);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _prev;
        private System.Windows.Forms.Button _openf;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
    }
}

