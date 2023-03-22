
namespace Sanatorium
{
    partial class Service
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._title = new MaterialSkin.Controls.MaterialLabel();
            this._description = new MaterialSkin.Controls.MaterialLabel();
            this._header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this._header.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(266, 381);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _title
            // 
            this._title.Depth = 0;
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(0, 0);
            this._title.MouseState = MaterialSkin.MouseState.HOVER;
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(467, 61);
            this._title.TabIndex = 1;
            this._title.Text = "Name";
            this._title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _description
            // 
            this._description.BackColor = System.Drawing.Color.White;
            this._description.Depth = 0;
            this._description.Dock = System.Windows.Forms.DockStyle.Fill;
            this._description.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._description.Location = new System.Drawing.Point(266, 61);
            this._description.MouseState = MaterialSkin.MouseState.HOVER;
            this._description.Name = "_description";
            this._description.Padding = new System.Windows.Forms.Padding(10);
            this._description.Size = new System.Drawing.Size(467, 320);
            this._description.TabIndex = 2;
            this._description.Text = "Description";
            // 
            // _header
            // 
            this._header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this._header.Controls.Add(this._title);
            this._header.Dock = System.Windows.Forms.DockStyle.Top;
            this._header.Location = new System.Drawing.Point(266, 0);
            this._header.Name = "_header";
            this._header.Size = new System.Drawing.Size(467, 61);
            this._header.TabIndex = 3;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._description);
            this.Controls.Add(this._header);
            this.Controls.Add(this._pictureBox);
            this.Name = "Service";
            this.Size = new System.Drawing.Size(733, 381);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this._header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private MaterialSkin.Controls.MaterialLabel _title;
        private MaterialSkin.Controls.MaterialLabel _description;
        private System.Windows.Forms.Panel _header;
    }
}
