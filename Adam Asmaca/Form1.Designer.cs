namespace Adam_Asmaca
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.kontrol = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.hint = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.hatalarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.input.Location = new System.Drawing.Point(399, 224);
            this.input.MaxLength = 1;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(286, 40);
            this.input.TabIndex = 0;
            // 
            // kontrol
            // 
            this.kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.kontrol.ForeColor = System.Drawing.Color.Indigo;
            this.kontrol.Location = new System.Drawing.Point(399, 291);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(286, 202);
            this.kontrol.TabIndex = 1;
            this.kontrol.Text = "Kontrol";
            this.kontrol.UseVisualStyleBackColor = true;
            this.kontrol.Click += new System.EventHandler(this.kontrol_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(445, 69);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 17);
            this.output.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.result.ForeColor = System.Drawing.Color.Indigo;
            this.result.Location = new System.Drawing.Point(436, 41);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(193, 67);
            this.result.TabIndex = 3;
            this.result.Text = "output";
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Left;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(315, 591);
            this.start.TabIndex = 4;
            this.start.Text = "Oyunu başlat";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(736, 5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(384, 574);
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(445, 108);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(0, 17);
            this.hint.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.timerLabel.Location = new System.Drawing.Point(321, 9);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(153, 29);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "Oyun sayacı";
            // 
            // hatalarLabel
            // 
            this.hatalarLabel.AutoSize = true;
            this.hatalarLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.hatalarLabel.Location = new System.Drawing.Point(399, 517);
            this.hatalarLabel.Name = "hatalarLabel";
            this.hatalarLabel.Size = new System.Drawing.Size(166, 17);
            this.hatalarLabel.TabIndex = 8;
            this.hatalarLabel.Text = "Hatalı girilen karakterler: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1115, 591);
            this.Controls.Add(this.hatalarLabel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.start);
            this.Controls.Add(this.result);
            this.Controls.Add(this.output);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Alphonso Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button kontrol;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button start;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label hint;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label hatalarLabel;
    }
}

