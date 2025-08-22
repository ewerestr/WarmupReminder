namespace WarmupReminder
{
    partial class WarmupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarmupForm));
            this.header_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.later_button = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.theme_picture = new System.Windows.Forms.PictureBox();
            this.header_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header_label.ForeColor = System.Drawing.Color.Black;
            this.header_label.Location = new System.Drawing.Point(119, 9);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(186, 20);
            this.header_label.TabIndex = 1;
            this.header_label.Text = "Время для зарядки?";
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit_button.ForeColor = System.Drawing.Color.Black;
            this.submit_button.Location = new System.Drawing.Point(13, 312);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(195, 53);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Да";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.sumbit_button_Click);
            // 
            // later_button
            // 
            this.later_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.later_button.ForeColor = System.Drawing.Color.Black;
            this.later_button.Location = new System.Drawing.Point(219, 312);
            this.later_button.Name = "later_button";
            this.later_button.Size = new System.Drawing.Size(195, 53);
            this.later_button.TabIndex = 2;
            this.later_button.Text = "Чуть-чуть попозже";
            this.later_button.UseVisualStyleBackColor = true;
            this.later_button.Click += new System.EventHandler(this.later_button_Click);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(341, 9);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(75, 23);
            this.wmp.TabIndex = 3;
            this.wmp.Visible = false;
            this.wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_PlayStateChange);
            // 
            // theme_picture
            // 
            this.theme_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme_picture.Image = ((System.Drawing.Image)(resources.GetObject("theme_picture.Image")));
            this.theme_picture.Location = new System.Drawing.Point(7, 7);
            this.theme_picture.Name = "theme_picture";
            this.theme_picture.Size = new System.Drawing.Size(30, 30);
            this.theme_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theme_picture.TabIndex = 4;
            this.theme_picture.TabStop = false;
            this.theme_picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.theme_picture_Click);
            // 
            // header_picture
            // 
            this.header_picture.Image = global::WarmupReminder.Properties.Resources.header;
            this.header_picture.Location = new System.Drawing.Point(12, 38);
            this.header_picture.Name = "header_picture";
            this.header_picture.Size = new System.Drawing.Size(402, 270);
            this.header_picture.TabIndex = 0;
            this.header_picture.TabStop = false;
            this.header_picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(428, 375);
            this.ControlBox = false;
            this.Controls.Add(this.theme_picture);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.later_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.header_label);
            this.Controls.Add(this.header_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пора бы уже подразмяться";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox header_picture;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button later_button;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.PictureBox theme_picture;
    }
}

