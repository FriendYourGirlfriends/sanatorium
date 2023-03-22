
namespace Sanatorium
{
    partial class FormMain
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
            System.Windows.Forms.ColumnHeader price;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._menu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this._guestsLabel = new MaterialSkin.Controls.MaterialLabel();
            this._checkInLabel = new MaterialSkin.Controls.MaterialLabel();
            this._checkOutLabel = new MaterialSkin.Controls.MaterialLabel();
            this._roomReservation = new MaterialSkin.Controls.MaterialLabel();
            this._childrenLabel = new MaterialSkin.Controls.MaterialLabel();
            this._adultLabel = new MaterialSkin.Controls.MaterialLabel();
            this._amountChildren = new System.Windows.Forms.NumericUpDown();
            this._amountAdults = new System.Windows.Forms.NumericUpDown();
            this._findRoomButton = new MaterialSkin.Controls.MaterialButton();
            this._checkOutDateTime = new System.Windows.Forms.DateTimePicker();
            this._checkInDateTime = new System.Windows.Forms.DateTimePicker();
            this._date = new MaterialSkin.Controls.MaterialLabel();
            this._time = new MaterialSkin.Controls.MaterialLabel();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this._roomsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabVouchers = new System.Windows.Forms.TabPage();
            this._discountInfoPanel = new System.Windows.Forms.Panel();
            this._discount = new MaterialSkin.Controls.MaterialLabel();
            this._bookRoom = new MaterialSkin.Controls.MaterialButton();
            this._rooms = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._header = new System.Windows.Forms.Panel();
            this._checkOutComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this._checkInComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this._discountComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this._discountLabel = new MaterialSkin.Controls.MaterialLabel();
            this._toLabel = new MaterialSkin.Controls.MaterialLabel();
            this._fromLabel = new MaterialSkin.Controls.MaterialLabel();
            this._restDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabServices = new System.Windows.Forms.TabPage();
            this._servicesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this._bookingPanel = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this._priceLabel = new MaterialSkin.Controls.MaterialLabel();
            this._phoneNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this._addressLabel = new MaterialSkin.Controls.MaterialLabel();
            this._patronymicLabel = new MaterialSkin.Controls.MaterialLabel();
            this._firstNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this._lastNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this._phoneNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this._addressTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this._patronymicTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this._lastNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this._firstNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this._toBookButton = new MaterialSkin.Controls.MaterialButton();
            this._tours = new MaterialSkin.Controls.MaterialListView();
            this._id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._checkIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._checkOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._discountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._selectDateAndPeoplesPanel = new System.Windows.Forms.Panel();
            this._discountComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this._discountLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this._childrenLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this._amountChildren2 = new System.Windows.Forms.NumericUpDown();
            this._adultLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this._amountAdults2 = new System.Windows.Forms.NumericUpDown();
            this._searchTourButton = new MaterialSkin.Controls.MaterialButton();
            this._countPeopleLabel = new MaterialSkin.Controls.MaterialLabel();
            this._checkOutDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this._checkOutDateTime2 = new System.Windows.Forms.DateTimePicker();
            this._checkInDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this._checkInDateTime2 = new System.Windows.Forms.DateTimePicker();
            this._titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this._contactsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._услугаTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.УслугаTableAdapter();
            this.SanatoriumDataSet = new Sanatorium.SanatoriumDataSet();
            this._броньTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.БроньTableAdapter();
            this._данныеTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.ДанныеTableAdapter();
            this._путевкаTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.ПутевкаTableAdapter();
            this._номерTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.НомерTableAdapter();
            this._контактTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.КонтактTableAdapter();
            this._изображение_номераTableAdapter = new Sanatorium.SanatoriumDataSetTableAdapters.Изображение_номераTableAdapter();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plusLabel = new MaterialSkin.Controls.MaterialLabel();
            this._resetFilterButton = new MaterialSkin.Controls.MaterialButton();
            price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._menu.SuspendLayout();
            this.tabHome.SuspendLayout();
            this._roomReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._amountChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._amountAdults)).BeginInit();
            this.tabRooms.SuspendLayout();
            this.tabVouchers.SuspendLayout();
            this._discountInfoPanel.SuspendLayout();
            this._header.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this._bookingPanel.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this._selectDateAndPeoplesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._amountChildren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._amountAdults2)).BeginInit();
            this.tabContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SanatoriumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            price.Text = "Цена";
            price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            price.Width = 70;
            // 
            // _price
            // 
            this._price.Text = "Цена";
            this._price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._price.Width = 70;
            // 
            // _menu
            // 
            this._menu.Controls.Add(this.tabHome);
            this._menu.Controls.Add(this.tabRooms);
            this._menu.Controls.Add(this.tabVouchers);
            this._menu.Controls.Add(this.tabServices);
            this._menu.Controls.Add(this.tabBooking);
            this._menu.Controls.Add(this.tabContacts);
            this._menu.Depth = 0;
            this._menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menu.ItemSize = new System.Drawing.Size(100, 18);
            this._menu.Location = new System.Drawing.Point(3, 64);
            this._menu.MouseState = MaterialSkin.MouseState.HOVER;
            this._menu.Multiline = true;
            this._menu.Name = "_menu";
            this._menu.SelectedIndex = 0;
            this._menu.Size = new System.Drawing.Size(978, 533);
            this._menu.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.AutoScroll = true;
            this.tabHome.Controls.Add(this._guestsLabel);
            this.tabHome.Controls.Add(this._checkInLabel);
            this.tabHome.Controls.Add(this._checkOutLabel);
            this.tabHome.Controls.Add(this._roomReservation);
            this.tabHome.Controls.Add(this._date);
            this.tabHome.Controls.Add(this._time);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(970, 507);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Главная";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // _guestsLabel
            // 
            this._guestsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._guestsLabel.AutoSize = true;
            this._guestsLabel.Depth = 0;
            this._guestsLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._guestsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._guestsLabel.Location = new System.Drawing.Point(635, 30);
            this._guestsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._guestsLabel.Name = "_guestsLabel";
            this._guestsLabel.Size = new System.Drawing.Size(54, 24);
            this._guestsLabel.TabIndex = 6;
            this._guestsLabel.Text = "Гости";
            // 
            // _checkInLabel
            // 
            this._checkInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkInLabel.AutoSize = true;
            this._checkInLabel.Depth = 0;
            this._checkInLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._checkInLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._checkInLabel.Location = new System.Drawing.Point(61, 30);
            this._checkInLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._checkInLabel.Name = "_checkInLabel";
            this._checkInLabel.Size = new System.Drawing.Size(57, 24);
            this._checkInLabel.TabIndex = 1;
            this._checkInLabel.Text = "Заезд";
            // 
            // _checkOutLabel
            // 
            this._checkOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkOutLabel.AutoSize = true;
            this._checkOutLabel.Depth = 0;
            this._checkOutLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._checkOutLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._checkOutLabel.Location = new System.Drawing.Point(328, 30);
            this._checkOutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._checkOutLabel.Name = "_checkOutLabel";
            this._checkOutLabel.Size = new System.Drawing.Size(63, 24);
            this._checkOutLabel.TabIndex = 3;
            this._checkOutLabel.Text = "Выезд";
            // 
            // _roomReservation
            // 
            this._roomReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._roomReservation.Controls.Add(this._childrenLabel);
            this._roomReservation.Controls.Add(this._adultLabel);
            this._roomReservation.Controls.Add(this._amountChildren);
            this._roomReservation.Controls.Add(this._amountAdults);
            this._roomReservation.Controls.Add(this._findRoomButton);
            this._roomReservation.Controls.Add(this._checkOutDateTime);
            this._roomReservation.Controls.Add(this._checkInDateTime);
            this._roomReservation.Depth = 0;
            this._roomReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this._roomReservation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._roomReservation.Location = new System.Drawing.Point(0, 0);
            this._roomReservation.MouseState = MaterialSkin.MouseState.HOVER;
            this._roomReservation.Name = "_roomReservation";
            this._roomReservation.Size = new System.Drawing.Size(970, 125);
            this._roomReservation.TabIndex = 2;
            // 
            // _childrenLabel
            // 
            this._childrenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._childrenLabel.AutoSize = true;
            this._childrenLabel.Depth = 0;
            this._childrenLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._childrenLabel.Location = new System.Drawing.Point(675, 64);
            this._childrenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._childrenLabel.Name = "_childrenLabel";
            this._childrenLabel.Size = new System.Drawing.Size(38, 19);
            this._childrenLabel.TabIndex = 9;
            this._childrenLabel.Text = "Дети";
            // 
            // _adultLabel
            // 
            this._adultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._adultLabel.AutoSize = true;
            this._adultLabel.Depth = 0;
            this._adultLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._adultLabel.Location = new System.Drawing.Point(587, 64);
            this._adultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._adultLabel.Name = "_adultLabel";
            this._adultLabel.Size = new System.Drawing.Size(74, 19);
            this._adultLabel.TabIndex = 9;
            this._adultLabel.Text = "Взрослые";
            // 
            // _amountChildren
            // 
            this._amountChildren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._amountChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._amountChildren.Location = new System.Drawing.Point(678, 84);
            this._amountChildren.Name = "_amountChildren";
            this._amountChildren.Size = new System.Drawing.Size(70, 27);
            this._amountChildren.TabIndex = 8;
            // 
            // _amountAdults
            // 
            this._amountAdults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._amountAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._amountAdults.Location = new System.Drawing.Point(590, 84);
            this._amountAdults.Name = "_amountAdults";
            this._amountAdults.Size = new System.Drawing.Size(70, 27);
            this._amountAdults.TabIndex = 7;
            // 
            // _findRoomButton
            // 
            this._findRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._findRoomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._findRoomButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._findRoomButton.Depth = 0;
            this._findRoomButton.HighEmphasis = true;
            this._findRoomButton.Icon = null;
            this._findRoomButton.Location = new System.Drawing.Point(816, 46);
            this._findRoomButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._findRoomButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._findRoomButton.Name = "_findRoomButton";
            this._findRoomButton.Size = new System.Drawing.Size(127, 36);
            this._findRoomButton.TabIndex = 4;
            this._findRoomButton.Text = "Найти номер";
            this._findRoomButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._findRoomButton.UseAccentColor = false;
            this._findRoomButton.UseVisualStyleBackColor = true;
            this._findRoomButton.Click += new System.EventHandler(this.FindRoomButton_Click);
            // 
            // _checkOutDateTime
            // 
            this._checkOutDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkOutDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkOutDateTime.Location = new System.Drawing.Point(333, 84);
            this._checkOutDateTime.Name = "_checkOutDateTime";
            this._checkOutDateTime.Size = new System.Drawing.Size(196, 27);
            this._checkOutDateTime.TabIndex = 2;
            // 
            // _checkInDateTime
            // 
            this._checkInDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkInDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkInDateTime.Location = new System.Drawing.Point(66, 85);
            this._checkInDateTime.Name = "_checkInDateTime";
            this._checkInDateTime.Size = new System.Drawing.Size(196, 27);
            this._checkInDateTime.TabIndex = 0;
            // 
            // _date
            // 
            this._date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._date.AutoSize = true;
            this._date.Depth = 0;
            this._date.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._date.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this._date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(186)))));
            this._date.Location = new System.Drawing.Point(405, 374);
            this._date.MouseState = MaterialSkin.MouseState.HOVER;
            this._date.Name = "_date";
            this._date.Size = new System.Drawing.Size(119, 58);
            this._date.TabIndex = 1;
            this._date.Text = "DATE";
            // 
            // _time
            // 
            this._time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._time.AutoSize = true;
            this._time.Depth = 0;
            this._time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._time.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._time.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this._time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this._time.Location = new System.Drawing.Point(395, 236);
            this._time.MouseState = MaterialSkin.MouseState.HOVER;
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(222, 115);
            this._time.TabIndex = 0;
            this._time.Text = "TIME";
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this._roomsPanel);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Size = new System.Drawing.Size(970, 507);
            this.tabRooms.TabIndex = 5;
            this.tabRooms.Text = "Номера";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // _roomsPanel
            // 
            this._roomsPanel.AutoScroll = true;
            this._roomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._roomsPanel.Location = new System.Drawing.Point(0, 0);
            this._roomsPanel.Name = "_roomsPanel";
            this._roomsPanel.Size = new System.Drawing.Size(970, 507);
            this._roomsPanel.TabIndex = 0;
            // 
            // tabVouchers
            // 
            this.tabVouchers.Controls.Add(this._discountInfoPanel);
            this.tabVouchers.Controls.Add(this._bookRoom);
            this.tabVouchers.Controls.Add(this._rooms);
            this.tabVouchers.Controls.Add(this._header);
            this.tabVouchers.Location = new System.Drawing.Point(4, 22);
            this.tabVouchers.Name = "tabVouchers";
            this.tabVouchers.Size = new System.Drawing.Size(970, 507);
            this.tabVouchers.TabIndex = 2;
            this.tabVouchers.Text = "Путевки";
            this.tabVouchers.UseVisualStyleBackColor = true;
            // 
            // _discountInfoPanel
            // 
            this._discountInfoPanel.AutoScroll = true;
            this._discountInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._discountInfoPanel.Controls.Add(this._discount);
            this._discountInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._discountInfoPanel.Location = new System.Drawing.Point(621, 120);
            this._discountInfoPanel.Name = "_discountInfoPanel";
            this._discountInfoPanel.Size = new System.Drawing.Size(349, 387);
            this._discountInfoPanel.TabIndex = 2;
            // 
            // _discount
            // 
            this._discount.AutoEllipsis = true;
            this._discount.Depth = 0;
            this._discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this._discount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._discount.ForeColor = System.Drawing.Color.Black;
            this._discount.Location = new System.Drawing.Point(0, 0);
            this._discount.MouseState = MaterialSkin.MouseState.HOVER;
            this._discount.Name = "_discount";
            this._discount.Size = new System.Drawing.Size(347, 385);
            this._discount.TabIndex = 2;
            this._discount.Text = resources.GetString("_discount.Text");
            // 
            // _bookRoom
            // 
            this._bookRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._bookRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._bookRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._bookRoom.Depth = 0;
            this._bookRoom.HighEmphasis = true;
            this._bookRoom.Icon = null;
            this._bookRoom.Location = new System.Drawing.Point(486, 465);
            this._bookRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._bookRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this._bookRoom.Name = "_bookRoom";
            this._bookRoom.Size = new System.Drawing.Size(128, 36);
            this._bookRoom.TabIndex = 10;
            this._bookRoom.Text = "Бронировать";
            this._bookRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._bookRoom.UseAccentColor = false;
            this._bookRoom.UseVisualStyleBackColor = true;
            this._bookRoom.Click += new System.EventHandler(this.BookRoom_Click);
            // 
            // _rooms
            // 
            this._rooms.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this._rooms.AutoSizeTable = false;
            this._rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.numberOfPerson,
            price});
            this._rooms.Depth = 0;
            this._rooms.Dock = System.Windows.Forms.DockStyle.Left;
            this._rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._rooms.FullRowSelect = true;
            this._rooms.HideSelection = false;
            this._rooms.LabelEdit = true;
            this._rooms.Location = new System.Drawing.Point(0, 120);
            this._rooms.MinimumSize = new System.Drawing.Size(200, 100);
            this._rooms.MouseLocation = new System.Drawing.Point(-1, -1);
            this._rooms.MouseState = MaterialSkin.MouseState.OUT;
            this._rooms.MultiSelect = false;
            this._rooms.Name = "_rooms";
            this._rooms.OwnerDraw = true;
            this._rooms.Size = new System.Drawing.Size(621, 387);
            this._rooms.TabIndex = 1;
            this._rooms.UseCompatibleStateImageBehavior = false;
            this._rooms.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 434;
            // 
            // numberOfPerson
            // 
            this.numberOfPerson.Text = "Кол-во чел.";
            this.numberOfPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfPerson.Width = 110;
            // 
            // _header
            // 
            this._header.Controls.Add(this._resetFilterButton);
            this._header.Controls.Add(this._checkOutComboBox);
            this._header.Controls.Add(this._checkInComboBox);
            this._header.Controls.Add(this._discountComboBox);
            this._header.Controls.Add(this._discountLabel);
            this._header.Controls.Add(this._toLabel);
            this._header.Controls.Add(this._fromLabel);
            this._header.Controls.Add(this._restDateLabel);
            this._header.Dock = System.Windows.Forms.DockStyle.Top;
            this._header.Location = new System.Drawing.Point(0, 0);
            this._header.Name = "_header";
            this._header.Size = new System.Drawing.Size(970, 120);
            this._header.TabIndex = 0;
            // 
            // _checkOutComboBox
            // 
            this._checkOutComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkOutComboBox.AutoResize = false;
            this._checkOutComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._checkOutComboBox.Depth = 0;
            this._checkOutComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._checkOutComboBox.DropDownHeight = 174;
            this._checkOutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._checkOutComboBox.DropDownWidth = 121;
            this._checkOutComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._checkOutComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._checkOutComboBox.FormattingEnabled = true;
            this._checkOutComboBox.IntegralHeight = false;
            this._checkOutComboBox.ItemHeight = 43;
            this._checkOutComboBox.Location = new System.Drawing.Point(260, 65);
            this._checkOutComboBox.MaxDropDownItems = 4;
            this._checkOutComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this._checkOutComboBox.Name = "_checkOutComboBox";
            this._checkOutComboBox.Size = new System.Drawing.Size(180, 49);
            this._checkOutComboBox.StartIndex = 0;
            this._checkOutComboBox.TabIndex = 14;
            this._checkOutComboBox.SelectedIndexChanged += new System.EventHandler(this.CheckOutComboBox_SelectedIndexChanged);
            // 
            // _checkInComboBox
            // 
            this._checkInComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkInComboBox.AutoResize = false;
            this._checkInComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._checkInComboBox.Depth = 0;
            this._checkInComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._checkInComboBox.DropDownHeight = 174;
            this._checkInComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._checkInComboBox.DropDownWidth = 121;
            this._checkInComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._checkInComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._checkInComboBox.FormattingEnabled = true;
            this._checkInComboBox.IntegralHeight = false;
            this._checkInComboBox.ItemHeight = 43;
            this._checkInComboBox.Location = new System.Drawing.Point(41, 65);
            this._checkInComboBox.MaxDropDownItems = 4;
            this._checkInComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this._checkInComboBox.Name = "_checkInComboBox";
            this._checkInComboBox.Size = new System.Drawing.Size(180, 49);
            this._checkInComboBox.StartIndex = 0;
            this._checkInComboBox.TabIndex = 13;
            this._checkInComboBox.SelectedIndexChanged += new System.EventHandler(this.CheckInComboBox_SelectedIndexChanged);
            // 
            // _discountComboBox
            // 
            this._discountComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._discountComboBox.AutoResize = false;
            this._discountComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._discountComboBox.Depth = 0;
            this._discountComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._discountComboBox.DropDownHeight = 174;
            this._discountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._discountComboBox.DropDownWidth = 121;
            this._discountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._discountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._discountComboBox.FormattingEnabled = true;
            this._discountComboBox.IntegralHeight = false;
            this._discountComboBox.ItemHeight = 43;
            this._discountComboBox.Items.AddRange(new object[] {
            "0",
            "10",
            "25"});
            this._discountComboBox.Location = new System.Drawing.Point(509, 64);
            this._discountComboBox.MaxDropDownItems = 4;
            this._discountComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this._discountComboBox.Name = "_discountComboBox";
            this._discountComboBox.Size = new System.Drawing.Size(121, 49);
            this._discountComboBox.StartIndex = 0;
            this._discountComboBox.TabIndex = 12;
            // 
            // _discountLabel
            // 
            this._discountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._discountLabel.AutoSize = true;
            this._discountLabel.Depth = 0;
            this._discountLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._discountLabel.Location = new System.Drawing.Point(506, 27);
            this._discountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._discountLabel.Name = "_discountLabel";
            this._discountLabel.Size = new System.Drawing.Size(57, 19);
            this._discountLabel.TabIndex = 11;
            this._discountLabel.Text = "Скидка";
            // 
            // _toLabel
            // 
            this._toLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._toLabel.AutoSize = true;
            this._toLabel.Depth = 0;
            this._toLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._toLabel.Location = new System.Drawing.Point(235, 77);
            this._toLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._toLabel.Name = "_toLabel";
            this._toLabel.Size = new System.Drawing.Size(19, 19);
            this._toLabel.TabIndex = 10;
            this._toLabel.Text = "по";
            // 
            // _fromLabel
            // 
            this._fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._fromLabel.AutoSize = true;
            this._fromLabel.Depth = 0;
            this._fromLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._fromLabel.Location = new System.Drawing.Point(26, 77);
            this._fromLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._fromLabel.Name = "_fromLabel";
            this._fromLabel.Size = new System.Drawing.Size(9, 19);
            this._fromLabel.TabIndex = 8;
            this._fromLabel.Text = "с";
            // 
            // _restDateLabel
            // 
            this._restDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._restDateLabel.AutoSize = true;
            this._restDateLabel.Depth = 0;
            this._restDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._restDateLabel.Location = new System.Drawing.Point(46, 27);
            this._restDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._restDateLabel.Name = "_restDateLabel";
            this._restDateLabel.Size = new System.Drawing.Size(99, 19);
            this._restDateLabel.TabIndex = 6;
            this._restDateLabel.Text = "Дата отдыха";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this._servicesPanel);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(970, 507);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Услуги";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // _servicesPanel
            // 
            this._servicesPanel.AutoScroll = true;
            this._servicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._servicesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._servicesPanel.Location = new System.Drawing.Point(0, 0);
            this._servicesPanel.Name = "_servicesPanel";
            this._servicesPanel.Size = new System.Drawing.Size(970, 507);
            this._servicesPanel.TabIndex = 0;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this._bookingPanel);
            this.tabBooking.Location = new System.Drawing.Point(4, 22);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Size = new System.Drawing.Size(970, 507);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.Text = "Онлайн бронирование";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // _bookingPanel
            // 
            this._bookingPanel.AutoScroll = true;
            this._bookingPanel.Controls.Add(this.panelSearch);
            this._bookingPanel.Controls.Add(this._tours);
            this._bookingPanel.Controls.Add(this._selectDateAndPeoplesPanel);
            this._bookingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bookingPanel.Location = new System.Drawing.Point(0, 0);
            this._bookingPanel.Name = "_bookingPanel";
            this._bookingPanel.Size = new System.Drawing.Size(970, 507);
            this._bookingPanel.TabIndex = 12;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.plusLabel);
            this.panelSearch.Controls.Add(this._priceLabel);
            this.panelSearch.Controls.Add(this._phoneNumberLabel);
            this.panelSearch.Controls.Add(this._addressLabel);
            this.panelSearch.Controls.Add(this._patronymicLabel);
            this.panelSearch.Controls.Add(this._firstNameLabel);
            this.panelSearch.Controls.Add(this._lastNameLabel);
            this.panelSearch.Controls.Add(this._phoneNumberTextBox);
            this.panelSearch.Controls.Add(this._addressTextBox);
            this.panelSearch.Controls.Add(this._patronymicTextBox);
            this.panelSearch.Controls.Add(this._lastNameTextBox);
            this.panelSearch.Controls.Add(this._firstNameTextBox);
            this.panelSearch.Controls.Add(this._toBookButton);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 511);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(953, 347);
            this.panelSearch.TabIndex = 18;
            // 
            // _priceLabel
            // 
            this._priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._priceLabel.AutoSize = true;
            this._priceLabel.Depth = 0;
            this._priceLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._priceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this._priceLabel.Location = new System.Drawing.Point(251, 291);
            this._priceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._priceLabel.Name = "_priceLabel";
            this._priceLabel.Size = new System.Drawing.Size(38, 29);
            this._priceLabel.TabIndex = 19;
            this._priceLabel.Text = " 0,0";
            // 
            // _phoneNumberLabel
            // 
            this._phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._phoneNumberLabel.AutoSize = true;
            this._phoneNumberLabel.Depth = 0;
            this._phoneNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._phoneNumberLabel.Location = new System.Drawing.Point(516, 170);
            this._phoneNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._phoneNumberLabel.Name = "_phoneNumberLabel";
            this._phoneNumberLabel.Size = new System.Drawing.Size(126, 19);
            this._phoneNumberLabel.TabIndex = 27;
            this._phoneNumberLabel.Text = "Номер телефона";
            // 
            // _addressLabel
            // 
            this._addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._addressLabel.AutoSize = true;
            this._addressLabel.Depth = 0;
            this._addressLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._addressLabel.Location = new System.Drawing.Point(35, 170);
            this._addressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(46, 19);
            this._addressLabel.TabIndex = 26;
            this._addressLabel.Text = "Адрес";
            // 
            // _patronymicLabel
            // 
            this._patronymicLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._patronymicLabel.AutoSize = true;
            this._patronymicLabel.Depth = 0;
            this._patronymicLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._patronymicLabel.Location = new System.Drawing.Point(516, 33);
            this._patronymicLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._patronymicLabel.Name = "_patronymicLabel";
            this._patronymicLabel.Size = new System.Drawing.Size(71, 19);
            this._patronymicLabel.TabIndex = 25;
            this._patronymicLabel.Text = "Отчество";
            // 
            // _firstNameLabel
            // 
            this._firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._firstNameLabel.AutoSize = true;
            this._firstNameLabel.Depth = 0;
            this._firstNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._firstNameLabel.Location = new System.Drawing.Point(302, 33);
            this._firstNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._firstNameLabel.Name = "_firstNameLabel";
            this._firstNameLabel.Size = new System.Drawing.Size(33, 19);
            this._firstNameLabel.TabIndex = 24;
            this._firstNameLabel.Text = "Имя";
            // 
            // _lastNameLabel
            // 
            this._lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lastNameLabel.AutoSize = true;
            this._lastNameLabel.Depth = 0;
            this._lastNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._lastNameLabel.Location = new System.Drawing.Point(35, 33);
            this._lastNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._lastNameLabel.Name = "_lastNameLabel";
            this._lastNameLabel.Size = new System.Drawing.Size(70, 19);
            this._lastNameLabel.TabIndex = 23;
            this._lastNameLabel.Text = "Фамилия";
            // 
            // _phoneNumberTextBox
            // 
            this._phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._phoneNumberTextBox.Depth = 0;
            this._phoneNumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._phoneNumberTextBox.LeadingIcon = null;
            this._phoneNumberTextBox.Location = new System.Drawing.Point(552, 193);
            this._phoneNumberTextBox.MaxLength = 50;
            this._phoneNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this._phoneNumberTextBox.Multiline = false;
            this._phoneNumberTextBox.Name = "_phoneNumberTextBox";
            this._phoneNumberTextBox.Size = new System.Drawing.Size(244, 50);
            this._phoneNumberTextBox.TabIndex = 22;
            this._phoneNumberTextBox.Text = "";
            this._phoneNumberTextBox.TrailingIcon = null;
            // 
            // _addressTextBox
            // 
            this._addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._addressTextBox.Depth = 0;
            this._addressTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._addressTextBox.LeadingIcon = null;
            this._addressTextBox.Location = new System.Drawing.Point(39, 193);
            this._addressTextBox.MaxLength = 50;
            this._addressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this._addressTextBox.Multiline = false;
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(475, 50);
            this._addressTextBox.TabIndex = 21;
            this._addressTextBox.Text = "";
            this._addressTextBox.TrailingIcon = null;
            // 
            // _patronymicTextBox
            // 
            this._patronymicTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._patronymicTextBox.Depth = 0;
            this._patronymicTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._patronymicTextBox.LeadingIcon = null;
            this._patronymicTextBox.Location = new System.Drawing.Point(520, 68);
            this._patronymicTextBox.MaxLength = 50;
            this._patronymicTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this._patronymicTextBox.Multiline = false;
            this._patronymicTextBox.Name = "_patronymicTextBox";
            this._patronymicTextBox.Size = new System.Drawing.Size(244, 50);
            this._patronymicTextBox.TabIndex = 20;
            this._patronymicTextBox.Text = "";
            this._patronymicTextBox.TrailingIcon = null;
            // 
            // _lastNameTextBox
            // 
            this._lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._lastNameTextBox.Depth = 0;
            this._lastNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._lastNameTextBox.LeadingIcon = null;
            this._lastNameTextBox.Location = new System.Drawing.Point(306, 68);
            this._lastNameTextBox.MaxLength = 50;
            this._lastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this._lastNameTextBox.Multiline = false;
            this._lastNameTextBox.Name = "_lastNameTextBox";
            this._lastNameTextBox.Size = new System.Drawing.Size(208, 50);
            this._lastNameTextBox.TabIndex = 19;
            this._lastNameTextBox.Text = "";
            this._lastNameTextBox.TrailingIcon = null;
            // 
            // _firstNameTextBox
            // 
            this._firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._firstNameTextBox.Depth = 0;
            this._firstNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._firstNameTextBox.LeadingIcon = null;
            this._firstNameTextBox.Location = new System.Drawing.Point(39, 68);
            this._firstNameTextBox.MaxLength = 50;
            this._firstNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this._firstNameTextBox.Multiline = false;
            this._firstNameTextBox.Name = "_firstNameTextBox";
            this._firstNameTextBox.Size = new System.Drawing.Size(261, 50);
            this._firstNameTextBox.TabIndex = 18;
            this._firstNameTextBox.Text = "";
            this._firstNameTextBox.TrailingIcon = null;
            // 
            // _toBookButton
            // 
            this._toBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._toBookButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._toBookButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._toBookButton.Depth = 0;
            this._toBookButton.HighEmphasis = true;
            this._toBookButton.Icon = null;
            this._toBookButton.Location = new System.Drawing.Point(410, 284);
            this._toBookButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._toBookButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._toBookButton.Name = "_toBookButton";
            this._toBookButton.Size = new System.Drawing.Size(147, 36);
            this._toBookButton.TabIndex = 17;
            this._toBookButton.Text = "Забронировать";
            this._toBookButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._toBookButton.UseAccentColor = false;
            this._toBookButton.UseVisualStyleBackColor = true;
            this._toBookButton.Click += new System.EventHandler(this.ToBookButton_Click);
            // 
            // _tours
            // 
            this._tours.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this._tours.AutoSizeTable = false;
            this._tours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._id,
            this._name,
            this._price,
            this._checkIn,
            this._checkOut,
            this._discountHeader});
            this._tours.Depth = 0;
            this._tours.Dock = System.Windows.Forms.DockStyle.Top;
            this._tours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._tours.FullRowSelect = true;
            this._tours.HideSelection = false;
            this._tours.LabelEdit = true;
            this._tours.Location = new System.Drawing.Point(0, 272);
            this._tours.MinimumSize = new System.Drawing.Size(200, 100);
            this._tours.MouseLocation = new System.Drawing.Point(-1, -1);
            this._tours.MouseState = MaterialSkin.MouseState.OUT;
            this._tours.Name = "_tours";
            this._tours.OwnerDraw = true;
            this._tours.Size = new System.Drawing.Size(953, 239);
            this._tours.TabIndex = 2;
            this._tours.UseCompatibleStateImageBehavior = false;
            this._tours.View = System.Windows.Forms.View.Details;
            this._tours.SelectedIndexChanged += new System.EventHandler(this.Tours_SelectedIndexChanged);
            // 
            // _id
            // 
            this._id.Text = "id";
            this._id.Width = 0;
            // 
            // _name
            // 
            this._name.Text = "Название";
            this._name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._name.Width = 560;
            // 
            // _checkIn
            // 
            this._checkIn.Text = "Начало отдыха";
            this._checkIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._checkIn.Width = 135;
            // 
            // _checkOut
            // 
            this._checkOut.Text = "Конец отдыха";
            this._checkOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._checkOut.Width = 135;
            // 
            // _discountHeader
            // 
            this._discountHeader.Text = "Скидка";
            this._discountHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._discountHeader.Width = 0;
            // 
            // _selectDateAndPeoplesPanel
            // 
            this._selectDateAndPeoplesPanel.Controls.Add(this._discountComboBox2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._discountLabel2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._childrenLabel2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._amountChildren2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._adultLabel2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._amountAdults2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._searchTourButton);
            this._selectDateAndPeoplesPanel.Controls.Add(this._countPeopleLabel);
            this._selectDateAndPeoplesPanel.Controls.Add(this._checkOutDateLabel);
            this._selectDateAndPeoplesPanel.Controls.Add(this._checkOutDateTime2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._checkInDateLabel);
            this._selectDateAndPeoplesPanel.Controls.Add(this._checkInDateTime2);
            this._selectDateAndPeoplesPanel.Controls.Add(this._titleLabel);
            this._selectDateAndPeoplesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._selectDateAndPeoplesPanel.Location = new System.Drawing.Point(0, 0);
            this._selectDateAndPeoplesPanel.Name = "_selectDateAndPeoplesPanel";
            this._selectDateAndPeoplesPanel.Size = new System.Drawing.Size(953, 272);
            this._selectDateAndPeoplesPanel.TabIndex = 0;
            // 
            // _discountComboBox2
            // 
            this._discountComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._discountComboBox2.AutoResize = false;
            this._discountComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._discountComboBox2.Depth = 0;
            this._discountComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._discountComboBox2.DropDownHeight = 174;
            this._discountComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._discountComboBox2.DropDownWidth = 40;
            this._discountComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this._discountComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._discountComboBox2.FormattingEnabled = true;
            this._discountComboBox2.IntegralHeight = false;
            this._discountComboBox2.ItemHeight = 43;
            this._discountComboBox2.Items.AddRange(new object[] {
            "0",
            "10",
            "25"});
            this._discountComboBox2.Location = new System.Drawing.Point(808, 126);
            this._discountComboBox2.MaxDropDownItems = 4;
            this._discountComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this._discountComboBox2.Name = "_discountComboBox2";
            this._discountComboBox2.Size = new System.Drawing.Size(115, 49);
            this._discountComboBox2.StartIndex = 0;
            this._discountComboBox2.TabIndex = 18;
            this._discountComboBox2.SelectedIndexChanged += new System.EventHandler(this.DiscountComboBox2_SelectedIndexChanged);
            // 
            // _discountLabel2
            // 
            this._discountLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._discountLabel2.AutoSize = true;
            this._discountLabel2.Depth = 0;
            this._discountLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._discountLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._discountLabel2.Location = new System.Drawing.Point(804, 90);
            this._discountLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this._discountLabel2.Name = "_discountLabel2";
            this._discountLabel2.Size = new System.Drawing.Size(70, 24);
            this._discountLabel2.TabIndex = 17;
            this._discountLabel2.Text = "Скидка";
            // 
            // _childrenLabel2
            // 
            this._childrenLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._childrenLabel2.AutoSize = true;
            this._childrenLabel2.Depth = 0;
            this._childrenLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._childrenLabel2.Location = new System.Drawing.Point(672, 119);
            this._childrenLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this._childrenLabel2.Name = "_childrenLabel2";
            this._childrenLabel2.Size = new System.Drawing.Size(38, 19);
            this._childrenLabel2.TabIndex = 12;
            this._childrenLabel2.Text = "Дети";
            // 
            // _amountChildren2
            // 
            this._amountChildren2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._amountChildren2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._amountChildren2.Location = new System.Drawing.Point(675, 139);
            this._amountChildren2.Name = "_amountChildren2";
            this._amountChildren2.Size = new System.Drawing.Size(70, 27);
            this._amountChildren2.TabIndex = 16;
            // 
            // _adultLabel2
            // 
            this._adultLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._adultLabel2.AutoSize = true;
            this._adultLabel2.Depth = 0;
            this._adultLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._adultLabel2.Location = new System.Drawing.Point(549, 118);
            this._adultLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this._adultLabel2.Name = "_adultLabel2";
            this._adultLabel2.Size = new System.Drawing.Size(74, 19);
            this._adultLabel2.TabIndex = 11;
            this._adultLabel2.Text = "Взрослые";
            // 
            // _amountAdults2
            // 
            this._amountAdults2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._amountAdults2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._amountAdults2.Location = new System.Drawing.Point(552, 138);
            this._amountAdults2.Name = "_amountAdults2";
            this._amountAdults2.Size = new System.Drawing.Size(70, 27);
            this._amountAdults2.TabIndex = 15;
            // 
            // _searchTourButton
            // 
            this._searchTourButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._searchTourButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._searchTourButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._searchTourButton.Depth = 0;
            this._searchTourButton.HighEmphasis = true;
            this._searchTourButton.Icon = null;
            this._searchTourButton.Location = new System.Drawing.Point(453, 218);
            this._searchTourButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._searchTourButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._searchTourButton.Name = "_searchTourButton";
            this._searchTourButton.Size = new System.Drawing.Size(71, 36);
            this._searchTourButton.TabIndex = 10;
            this._searchTourButton.Text = "Найти";
            this._searchTourButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._searchTourButton.UseAccentColor = false;
            this._searchTourButton.UseVisualStyleBackColor = true;
            this._searchTourButton.Click += new System.EventHandler(this.SearchTourButton_Click);
            // 
            // _countPeopleLabel
            // 
            this._countPeopleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._countPeopleLabel.AutoSize = true;
            this._countPeopleLabel.Depth = 0;
            this._countPeopleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._countPeopleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._countPeopleLabel.Location = new System.Drawing.Point(548, 90);
            this._countPeopleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._countPeopleLabel.Name = "_countPeopleLabel";
            this._countPeopleLabel.Size = new System.Drawing.Size(213, 24);
            this._countPeopleLabel.TabIndex = 14;
            this._countPeopleLabel.Text = "Размещение в номере";
            // 
            // _checkOutDateLabel
            // 
            this._checkOutDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkOutDateLabel.AutoSize = true;
            this._checkOutDateLabel.Depth = 0;
            this._checkOutDateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._checkOutDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._checkOutDateLabel.Location = new System.Drawing.Point(302, 90);
            this._checkOutDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._checkOutDateLabel.Name = "_checkOutDateLabel";
            this._checkOutDateLabel.Size = new System.Drawing.Size(124, 24);
            this._checkOutDateLabel.TabIndex = 12;
            this._checkOutDateLabel.Text = "Дата выезда";
            // 
            // _checkOutDateTime2
            // 
            this._checkOutDateTime2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkOutDateTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkOutDateTime2.Location = new System.Drawing.Point(306, 138);
            this._checkOutDateTime2.Name = "_checkOutDateTime2";
            this._checkOutDateTime2.Size = new System.Drawing.Size(196, 27);
            this._checkOutDateTime2.TabIndex = 11;
            // 
            // _checkInDateLabel
            // 
            this._checkInDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkInDateLabel.AutoSize = true;
            this._checkInDateLabel.Depth = 0;
            this._checkInDateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._checkInDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this._checkInDateLabel.Location = new System.Drawing.Point(35, 90);
            this._checkInDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._checkInDateLabel.Name = "_checkInDateLabel";
            this._checkInDateLabel.Size = new System.Drawing.Size(118, 24);
            this._checkInDateLabel.TabIndex = 10;
            this._checkInDateLabel.Text = "Дата заезда";
            // 
            // _checkInDateTime2
            // 
            this._checkInDateTime2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._checkInDateTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._checkInDateTime2.Location = new System.Drawing.Point(39, 139);
            this._checkInDateTime2.Name = "_checkInDateTime2";
            this._checkInDateTime2.Size = new System.Drawing.Size(196, 27);
            this._checkInDateTime2.TabIndex = 9;
            // 
            // _titleLabel
            // 
            this._titleLabel.Depth = 0;
            this._titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._titleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this._titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this._titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this._titleLabel.Location = new System.Drawing.Point(0, 0);
            this._titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(953, 77);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = " Выберите даты заезда, выезда \r\nи количество гостей";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this._contactsPanel);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Size = new System.Drawing.Size(970, 507);
            this.tabContacts.TabIndex = 4;
            this.tabContacts.Text = "Контакты";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // _contactsPanel
            // 
            this._contactsPanel.AutoScroll = true;
            this._contactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contactsPanel.ForeColor = System.Drawing.SystemColors.Window;
            this._contactsPanel.Location = new System.Drawing.Point(0, 0);
            this._contactsPanel.Name = "_contactsPanel";
            this._contactsPanel.Size = new System.Drawing.Size(970, 507);
            this._contactsPanel.TabIndex = 0;
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // _услугаTableAdapter
            // 
            this._услугаTableAdapter.ClearBeforeFill = true;
            // 
            // SanatoriumDataSet
            // 
            this.SanatoriumDataSet.DataSetName = "SanatoriumDataSet";
            this.SanatoriumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _броньTableAdapter
            // 
            this._броньTableAdapter.ClearBeforeFill = true;
            // 
            // _данныеTableAdapter
            // 
            this._данныеTableAdapter.ClearBeforeFill = true;
            // 
            // _путевкаTableAdapter
            // 
            this._путевкаTableAdapter.ClearBeforeFill = true;
            // 
            // _номерTableAdapter
            // 
            this._номерTableAdapter.ClearBeforeFill = true;
            // 
            // _контактTableAdapter
            // 
            this._контактTableAdapter.ClearBeforeFill = true;
            // 
            // _изображение_номераTableAdapter
            // 
            this._изображение_номераTableAdapter.ClearBeforeFill = true;
            // 
            // plusLabel
            // 
            this.plusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.plusLabel.AutoSize = true;
            this.plusLabel.Depth = 0;
            this.plusLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.plusLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.plusLabel.Location = new System.Drawing.Point(534, 209);
            this.plusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(12, 24);
            this.plusLabel.TabIndex = 28;
            this.plusLabel.Text = "+";
            // 
            // _resetFilterButton
            // 
            this._resetFilterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._resetFilterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._resetFilterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this._resetFilterButton.Depth = 0;
            this._resetFilterButton.HighEmphasis = true;
            this._resetFilterButton.Icon = null;
            this._resetFilterButton.Location = new System.Drawing.Point(761, 47);
            this._resetFilterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._resetFilterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._resetFilterButton.Name = "_resetFilterButton";
            this._resetFilterButton.Size = new System.Drawing.Size(162, 36);
            this._resetFilterButton.TabIndex = 15;
            this._resetFilterButton.Text = "Сбросить фильтр";
            this._resetFilterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this._resetFilterButton.UseAccentColor = false;
            this._resetFilterButton.UseVisualStyleBackColor = true;
            this._resetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this._menu);
            this.DrawerTabControl = this._menu;
            this.DrawerWidth = 250;
            this.Name = "FormMain";
            this.Text = "Санаторий имени Ленина";
            this._menu.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this._roomReservation.ResumeLayout(false);
            this._roomReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._amountChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._amountAdults)).EndInit();
            this.tabRooms.ResumeLayout(false);
            this.tabVouchers.ResumeLayout(false);
            this.tabVouchers.PerformLayout();
            this._discountInfoPanel.ResumeLayout(false);
            this._header.ResumeLayout(false);
            this._header.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this._bookingPanel.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this._selectDateAndPeoplesPanel.ResumeLayout(false);
            this._selectDateAndPeoplesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._amountChildren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._amountAdults2)).EndInit();
            this.tabContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SanatoriumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl _menu;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabVouchers;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabContacts;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.FlowLayoutPanel _contactsPanel;
        private System.Windows.Forms.FlowLayoutPanel _servicesPanel;
        private System.Windows.Forms.Timer _timer;
        private MaterialSkin.Controls.MaterialLabel _date;
        private MaterialSkin.Controls.MaterialLabel _time;
        private SanatoriumDataSetTableAdapters.УслугаTableAdapter _услугаTableAdapter;
        public SanatoriumDataSet SanatoriumDataSet;
        private SanatoriumDataSetTableAdapters.БроньTableAdapter _броньTableAdapter;
        private SanatoriumDataSetTableAdapters.ДанныеTableAdapter _данныеTableAdapter;
        private SanatoriumDataSetTableAdapters.ПутевкаTableAdapter _путевкаTableAdapter;
        private SanatoriumDataSetTableAdapters.НомерTableAdapter _номерTableAdapter;
        private SanatoriumDataSetTableAdapters.КонтактTableAdapter _контактTableAdapter;
        private SanatoriumDataSetTableAdapters.Изображение_номераTableAdapter _изображение_номераTableAdapter;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.FlowLayoutPanel _roomsPanel;
        private System.Windows.Forms.Panel _header;
        private MaterialSkin.Controls.MaterialLabel _discountLabel;
        private MaterialSkin.Controls.MaterialLabel _toLabel;
        private MaterialSkin.Controls.MaterialLabel _fromLabel;
        private MaterialSkin.Controls.MaterialLabel _restDateLabel;
        private MaterialSkin.Controls.MaterialButton _bookRoom;
        private MaterialSkin.Controls.MaterialListView _rooms;
        private System.Windows.Forms.Panel _discountInfoPanel;
        private System.Windows.Forms.ColumnHeader numberOfPerson;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private MaterialSkin.Controls.MaterialComboBox _checkOutComboBox;
        private MaterialSkin.Controls.MaterialComboBox _checkInComboBox;
        private MaterialSkin.Controls.MaterialLabel _discount;
        private MaterialSkin.Controls.MaterialLabel _roomReservation;
        private MaterialSkin.Controls.MaterialLabel _childrenLabel;
        private MaterialSkin.Controls.MaterialLabel _adultLabel;
        private System.Windows.Forms.NumericUpDown _amountChildren;
        private System.Windows.Forms.NumericUpDown _amountAdults;
        private MaterialSkin.Controls.MaterialLabel _guestsLabel;
        private MaterialSkin.Controls.MaterialButton _findRoomButton;
        private MaterialSkin.Controls.MaterialLabel _checkOutLabel;
        private System.Windows.Forms.DateTimePicker _checkOutDateTime;
        private MaterialSkin.Controls.MaterialLabel _checkInLabel;
        private System.Windows.Forms.DateTimePicker _checkInDateTime;
        private System.Windows.Forms.Panel _selectDateAndPeoplesPanel;
        private MaterialSkin.Controls.MaterialLabel _titleLabel;
        private MaterialSkin.Controls.MaterialListView _tours;
        private System.Windows.Forms.ColumnHeader _id;
        private System.Windows.Forms.ColumnHeader _name;
        private System.Windows.Forms.ColumnHeader _checkIn;
        private MaterialSkin.Controls.MaterialLabel _childrenLabel2;
        private System.Windows.Forms.NumericUpDown _amountChildren2;
        private MaterialSkin.Controls.MaterialLabel _adultLabel2;
        private System.Windows.Forms.NumericUpDown _amountAdults2;
        private MaterialSkin.Controls.MaterialButton _searchTourButton;
        private MaterialSkin.Controls.MaterialLabel _countPeopleLabel;
        private MaterialSkin.Controls.MaterialLabel _checkOutDateLabel;
        private System.Windows.Forms.DateTimePicker _checkOutDateTime2;
        private MaterialSkin.Controls.MaterialLabel _checkInDateLabel;
        private System.Windows.Forms.DateTimePicker _checkInDateTime2;
        private System.Windows.Forms.ColumnHeader _price;
        private System.Windows.Forms.Panel _bookingPanel;
        private MaterialSkin.Controls.MaterialButton _toBookButton;
        private System.Windows.Forms.Panel panelSearch;
        private MaterialSkin.Controls.MaterialLabel _phoneNumberLabel;
        private MaterialSkin.Controls.MaterialLabel _addressLabel;
        private MaterialSkin.Controls.MaterialLabel _patronymicLabel;
        private MaterialSkin.Controls.MaterialLabel _firstNameLabel;
        private MaterialSkin.Controls.MaterialLabel _lastNameLabel;
        private MaterialSkin.Controls.MaterialTextBox _phoneNumberTextBox;
        private MaterialSkin.Controls.MaterialTextBox _addressTextBox;
        private MaterialSkin.Controls.MaterialTextBox _patronymicTextBox;
        private MaterialSkin.Controls.MaterialTextBox _lastNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox _firstNameTextBox;
        private MaterialSkin.Controls.MaterialLabel _priceLabel;
        private MaterialSkin.Controls.MaterialComboBox _discountComboBox2;
        private MaterialSkin.Controls.MaterialLabel _discountLabel2;
        private MaterialSkin.Controls.MaterialComboBox _discountComboBox;
        private System.Windows.Forms.ColumnHeader _discountHeader;
        private System.Windows.Forms.ColumnHeader _checkOut;
        private MaterialSkin.Controls.MaterialLabel plusLabel;
        private MaterialSkin.Controls.MaterialButton _resetFilterButton;
    }
}

