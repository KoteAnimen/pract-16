namespace pract_16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Background = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.ast5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.explosion = new System.Windows.Forms.PictureBox();
            this.ast4 = new System.Windows.Forms.PictureBox();
            this.ast1 = new System.Windows.Forms.PictureBox();
            this.ast2 = new System.Windows.Forms.PictureBox();
            this.ast3 = new System.Windows.Forms.PictureBox();
            this.ast6 = new System.Windows.Forms.PictureBox();
            this.ast7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast7)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.InitialImage = null;
            this.Background.Location = new System.Drawing.Point(-5, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(895, 644);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.Image = ((System.Drawing.Image)(resources.GetObject("rocket.Image")));
            this.rocket.Location = new System.Drawing.Point(414, 564);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(70, 67);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket.TabIndex = 1;
            this.rocket.TabStop = false;
            // 
            // ast5
            // 
            this.ast5.Image = ((System.Drawing.Image)(resources.GetObject("ast5.Image")));
            this.ast5.Location = new System.Drawing.Point(50, 13);
            this.ast5.Name = "ast5";
            this.ast5.Size = new System.Drawing.Size(79, 74);
            this.ast5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast5.TabIndex = 6;
            this.ast5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.ObjectsMove);
            // 
            // explosion
            // 
            this.explosion.Location = new System.Drawing.Point(381, 255);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(100, 90);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.explosion.TabIndex = 10;
            this.explosion.TabStop = false;
            // 
            // ast4
            // 
            this.ast4.Image = ((System.Drawing.Image)(resources.GetObject("ast4.Image")));
            this.ast4.Location = new System.Drawing.Point(164, 13);
            this.ast4.Name = "ast4";
            this.ast4.Size = new System.Drawing.Size(79, 73);
            this.ast4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast4.TabIndex = 7;
            this.ast4.TabStop = false;
            // 
            // ast1
            // 
            this.ast1.Image = ((System.Drawing.Image)(resources.GetObject("ast1.Image")));
            this.ast1.Location = new System.Drawing.Point(271, 12);
            this.ast1.Name = "ast1";
            this.ast1.Size = new System.Drawing.Size(79, 73);
            this.ast1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast1.TabIndex = 2;
            this.ast1.TabStop = false;
            // 
            // ast2
            // 
            this.ast2.Image = ((System.Drawing.Image)(resources.GetObject("ast2.Image")));
            this.ast2.Location = new System.Drawing.Point(388, 12);
            this.ast2.Name = "ast2";
            this.ast2.Size = new System.Drawing.Size(79, 74);
            this.ast2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast2.TabIndex = 3;
            this.ast2.TabStop = false;
            // 
            // ast3
            // 
            this.ast3.Image = ((System.Drawing.Image)(resources.GetObject("ast3.Image")));
            this.ast3.Location = new System.Drawing.Point(508, 12);
            this.ast3.Name = "ast3";
            this.ast3.Size = new System.Drawing.Size(79, 74);
            this.ast3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast3.TabIndex = 4;
            this.ast3.TabStop = false;
            // 
            // ast6
            // 
            this.ast6.Image = ((System.Drawing.Image)(resources.GetObject("ast6.Image")));
            this.ast6.Location = new System.Drawing.Point(616, 11);
            this.ast6.Name = "ast6";
            this.ast6.Size = new System.Drawing.Size(79, 74);
            this.ast6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast6.TabIndex = 8;
            this.ast6.TabStop = false;
            // 
            // ast7
            // 
            this.ast7.Image = ((System.Drawing.Image)(resources.GetObject("ast7.Image")));
            this.ast7.Location = new System.Drawing.Point(726, 11);
            this.ast7.Name = "ast7";
            this.ast7.Size = new System.Drawing.Size(79, 74);
            this.ast7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ast7.TabIndex = 9;
            this.ast7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 643);
            this.ControlBox = false;
            this.Controls.Add(this.explosion);
            this.Controls.Add(this.ast7);
            this.Controls.Add(this.ast6);
            this.Controls.Add(this.ast4);
            this.Controls.Add(this.ast5);
            this.Controls.Add(this.ast3);
            this.Controls.Add(this.ast2);
            this.Controls.Add(this.ast1);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket";
            this.Load += new System.EventHandler(this.LoadMainMenu);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rocket_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rocket_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ast7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.PictureBox ast5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox ast4;
        private System.Windows.Forms.PictureBox ast1;
        private System.Windows.Forms.PictureBox ast2;
        private System.Windows.Forms.PictureBox ast3;
        private System.Windows.Forms.PictureBox ast6;
        private System.Windows.Forms.PictureBox ast7;
    }
}

