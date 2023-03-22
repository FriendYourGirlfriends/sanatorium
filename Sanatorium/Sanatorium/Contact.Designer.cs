
namespace Sanatorium
{
    partial class Contact
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
            this._type = new System.Windows.Forms.Label();
            this._header = new System.Windows.Forms.Panel();
            this._data = new MaterialSkin.Controls.MaterialListView();
            this._phoneNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._skypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._header.SuspendLayout();
            this.SuspendLayout();
            // 
            // _type
            // 
            this._type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._type.AutoSize = true;
            this._type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._type.ForeColor = System.Drawing.SystemColors.Info;
            this._type.Location = new System.Drawing.Point(217, 7);
            this._type.Name = "_type";
            this._type.Size = new System.Drawing.Size(122, 20);
            this._type.TabIndex = 9;
            this._type.Text = "Тип контакта";
            // 
            // _header
            // 
            this._header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this._header.Controls.Add(this._type);
            this._header.Dock = System.Windows.Forms.DockStyle.Top;
            this._header.Location = new System.Drawing.Point(0, 0);
            this._header.Name = "_header";
            this._header.Size = new System.Drawing.Size(558, 34);
            this._header.TabIndex = 15;
            // 
            // _data
            // 
            this._data.AutoSizeTable = false;
            this._data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._id,
            this._phoneNumbers,
            this._skypes,
            this._mail});
            this._data.Depth = 0;
            this._data.Dock = System.Windows.Forms.DockStyle.Fill;
            this._data.FullRowSelect = true;
            this._data.HideSelection = false;
            this._data.Location = new System.Drawing.Point(0, 34);
            this._data.MinimumSize = new System.Drawing.Size(200, 100);
            this._data.MouseLocation = new System.Drawing.Point(-1, -1);
            this._data.MouseState = MaterialSkin.MouseState.OUT;
            this._data.Name = "_data";
            this._data.OwnerDraw = true;
            this._data.Size = new System.Drawing.Size(558, 155);
            this._data.TabIndex = 16;
            this._data.UseCompatibleStateImageBehavior = false;
            this._data.View = System.Windows.Forms.View.Details;
            // 
            // _phoneNumbers
            // 
            this._phoneNumbers.DisplayIndex = 1;
            this._phoneNumbers.Text = "Телефон";
            this._phoneNumbers.Width = 140;
            // 
            // _skypes
            // 
            this._skypes.Text = "Скайп";
            this._skypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._skypes.Width = 180;
            // 
            // _mail
            // 
            this._mail.Text = "Почта";
            this._mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._mail.Width = 220;
            // 
            // _id
            // 
            this._id.DisplayIndex = 0;
            this._id.Text = "";
            this._id.Width = 15;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._data);
            this.Controls.Add(this._header);
            this.Name = "Contact";
            this.Size = new System.Drawing.Size(558, 189);
            this._header.ResumeLayout(false);
            this._header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _type;
        private System.Windows.Forms.Panel _header;
        private MaterialSkin.Controls.MaterialListView _data;
        private System.Windows.Forms.ColumnHeader _phoneNumbers;
        private System.Windows.Forms.ColumnHeader _skypes;
        private System.Windows.Forms.ColumnHeader _mail;
        private System.Windows.Forms.ColumnHeader _id;
    }
}
