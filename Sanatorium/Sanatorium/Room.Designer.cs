
namespace Sanatorium
{
    partial class Room
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
            this._description = new System.Windows.Forms.Label();
            this._title = new System.Windows.Forms.Label();
            this._nextButton = new MaterialSkin.Controls.MaterialButton();
            this._previousButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(674, 247);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _description
            // 
            this._description.Dock = System.Windows.Forms.DockStyle.Fill;
            this._description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._description.ForeColor = System.Drawing.Color.Black;
            this._description.Location = new System.Drawing.Point(0, 306);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(674, 219);
            this._description.TabIndex = 1;
            // 
            // _title
            // 
            this._title.AutoEllipsis = true;
            this._title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this._title.Dock = System.Windows.Forms.DockStyle.Top;
            this._title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(0, 247);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(674, 59);
            this._title.TabIndex = 2;
            this._title.Text = "Название";
            this._title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nextButton
            // 
            this._nextButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._nextButton.Depth = 0;
            this._nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._nextButton.HighEmphasis = true;
            this._nextButton.Icon = null;
            this._nextButton.Location = new System.Drawing.Point(606, 133);
            this._nextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(64, 36);
            this._nextButton.TabIndex = 3;
            this._nextButton.Text = "»";
            this._nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._nextButton.UseAccentColor = false;
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // _previousButton
            // 
            this._previousButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._previousButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._previousButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._previousButton.Depth = 0;
            this._previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._previousButton.HighEmphasis = true;
            this._previousButton.Icon = null;
            this._previousButton.Location = new System.Drawing.Point(5, 133);
            this._previousButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._previousButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(64, 36);
            this._previousButton.TabIndex = 4;
            this._previousButton.Text = "«";
            this._previousButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._previousButton.UseAccentColor = false;
            this._previousButton.UseVisualStyleBackColor = true;
            this._previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._description);
            this.Controls.Add(this._previousButton);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._title);
            this.Controls.Add(this._pictureBox);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(674, 525);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.Label _title;
        private MaterialSkin.Controls.MaterialButton _nextButton;
        private MaterialSkin.Controls.MaterialButton _previousButton;
    }
}
