using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sanatorium
{
    public partial class FormMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private ListViewItem _selectedTours = null;
        public FormMain()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            InitializeComponent();

            AppendRoomsToPanel();

            AppendRoomsToList();

            AddDateToComboBox();

            AppendServicesToPanel();
            
            AppendContactsToPanel();
        }

        private void AppendRoomsToPanel()
        {
            var rows = _номерTableAdapter.GetData().Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int roomId = i + 1;

                string title = rows[i].Field<string>("Название");
                string description = rows[i].Field<string>("Описание");
                List<string> imageNames = GetImagesNameOfRoom(roomId);

                _roomsPanel.Controls.Add(new Room(title, description, imageNames));
            }
        }

        private List<string> GetImagesNameOfRoom(int id)
        {
            return _изображение_номераTableAdapter.GetData()
                .Where(x => x.Код_номера == id)
                .Select(x => x.Картинка)
                .ToList();
        }

        private void AppendRoomsToList()
        {
            foreach (var row in _номерTableAdapter.GetData())
            {
                var item = CreateRoom(row);
                _rooms.Items.Add(item);
            }
        }

        private ListViewItem CreateRoom(SanatoriumDataSet.НомерRow row)
        {
            var item = new ListViewItem(row.Код.ToString());

            for (int i = 1; i < row.ItemArray.Length - 1; i++)
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, row.ItemArray[i].ToString()));
            }

            return item;
        }

        private void AddDateToComboBox()
        {
            var rows = _путевкаTableAdapter.GetData().Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                var item = rows[i].Field<DateTime>("Начало отдыха").ToShortDateString();
                _checkInComboBox.Items.Add(item);
            }
        }

        private void CheckInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _checkOutComboBox.Items.Clear();
            
            var items = _путевкаTableAdapter.GetData()
                .Where(x => x.Начало_отдыха == DateTime.Parse(_checkInComboBox.Text));

            AppendDateToCheckOutComboBox(items);
        }

        private void AppendDateToCheckOutComboBox(EnumerableRowCollection<SanatoriumDataSet.ПутевкаRow> items)
        {
            var onlyCheckOut = items.Select(x => x.Конец_отдыха);

            foreach (var item in onlyCheckOut)
            {
                _checkOutComboBox.Items.Add(item.ToShortDateString());
            }
        }

        private void CheckOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppendRoomsToList(_checkOutComboBox.Text);
        }

        private void AppendRoomsToList(string date)
        {
            var checkOutDate = DateTime.Parse(date);

            int[] ids = _путевкаTableAdapter.GetData()
                .Where(x => x.Конец_отдыха == checkOutDate)
                .Select(x => x.Код).ToArray();

            _rooms.Items.Clear();

            foreach (var id in ids)
            {
                var rows = _номерTableAdapter.GetData()
                    .Where(x => x.Код_путевки == id);
                CreateRoomsAndAddToList(rows);
            }
        }

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            _checkInComboBox.Items.Clear();
            _checkOutComboBox.Items.Clear();
            _rooms.Items.Clear();

            AddDateToComboBox();

            var rows = _номерTableAdapter.GetData().Where(x => !x.IsКод_путевкиNull());

            CreateRoomsAndAddToList(rows);
        }
        private void CreateRoomsAndAddToList(EnumerableRowCollection<SanatoriumDataSet.НомерRow> rows)
        {
            foreach (var row in rows)
            {
                var item = CreateRoom(row);
                _rooms.Items.Add(item);
            }
        }

        private void AppendServicesToPanel()
        {
            var rows = _услугаTableAdapter.GetData().Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                _servicesPanel.Controls.Add(new Service(rows[i].ItemArray));
            }
        }

        private void AppendContactsToPanel()
        {
            var rows = _контактTableAdapter.GetData().Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                string contactType = rows[i].Field<string>("Тип");
                int contactId = i + 1;

                _contactsPanel.Controls.Add(new Contact(contactType, GetData(contactId)));
            }
        }

        private EnumerableRowCollection<SanatoriumDataSet.ДанныеRow> GetData(int id)
        {
            return _данныеTableAdapter.GetData()
                .Where(x => x.Код_Контакта == id);
        }
               
        private void BookRoom_Click(object sender, EventArgs e)
        {
            _discountComboBox2.SelectedItem = _discountComboBox.SelectedItem;

            try
            { 
                int selectedRoomId = int.Parse(GetSelectedItem(_rooms).SubItems[0].Text);
                SelectTour(selectedRoomId);

                _menu.SelectTab(tabBooking);
            }
            catch(ArgumentNullException)
            {

            }
        }

        private ListViewItem GetSelectedItem(MaterialListView list)
        {
            ListViewItem selectedItem = null;

            foreach (ListViewItem item in list.SelectedItems)
            {
                selectedItem = item;
            }

            if (selectedItem == null)
            {
                MaterialMessageBox.Show("Выберите тур, который хотите посетить", "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                throw new ArgumentNullException();
            }

            return selectedItem;
        }

        private void SelectTour(int id)
        {
            _tours.Items.Clear();

            int tourId = _номерTableAdapter.GetData().FindByКод(id).Код_путевки;
            var row = _путевкаTableAdapter.GetData().FirstOrDefault(x => x.Код == tourId);
            var item = CreateTour(row);

            _tours.Items.Add(item);
        }

        private ListViewItem CreateTour(SanatoriumDataSet.ПутевкаRow row)
        {

            var item = new ListViewItem(row.Код.ToString());
            
            for (int i = 1; i < row.ItemArray.Length - 1; i++)
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, row.ItemArray[i].ToString()));
            }

            return item;
        }

        private void FindRoomButton_Click(object sender, EventArgs e)
        {
            _amountAdults2.Value = _amountAdults.Value;
            _amountChildren2.Value = _amountChildren.Value;
            _checkInDateTime2.Value = _checkInDateTime.Value;
            _checkOutDateTime2.Value = _checkOutDateTime.Value;

            bool isContains = FindTours();
            if (!isContains)
                MessageBox.Show("Путевок не найдено!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                _menu.SelectTab(tabVouchers);
        }

        private bool FindTours()
        {
            DateTime startDate = _checkInDateTime.Value;
            DateTime endDate = _checkOutDateTime.Value;
            DateTime[] startDates = _путевкаTableAdapter.GetData().Select(x => x.Начало_отдыха).ToArray();
            DateTime[] endDates = _путевкаTableAdapter.GetData().Select(x => x.Конец_отдыха).ToArray();

            for (int i = 0; i < startDates.Length; i++)
            {
                if (startDate >= startDates[i] || (endDate <= endDates[i] && endDate > startDates[i]))
                    return true;
            }

            return false;
        }

        private void DiscountComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDiscountedPrice();
        }

        private void CalculateDiscountedPrice()
        {
            if (_selectedTours == null)
                return;

            var first = decimal.Parse(_selectedTours.SubItems[2].Text);
            var discount = decimal.Parse("0," + _discountComboBox2.Text);

            if (_discountComboBox2.Text != "0")
                _priceLabel.Text = "~" + (first - first * discount).ToString();
            else
                _priceLabel.Text = "~" + first;
        }

        private void SearchTourButton_Click(object sender, EventArgs e)
        {
            bool isContains = FindTours();
            if (!isContains)
                MessageBox.Show("Путевок не найдено!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                AppendToursToList();
        }

        private void AppendToursToList()
        {
            var checkOutDate = _checkOutDateTime2.Value;

            _tours.Items.Clear();

            var rows = _путевкаTableAdapter.GetData().Where(x => x.Конец_отдыха < checkOutDate);
            foreach (var row in rows)
            {
                var item = CreateTour(row);
                _tours.Items.Add(item);
            }
        }

        private void Tours_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (ListViewItem item in _tours.SelectedItems)
            {
                _selectedTours = item;
            }

            CalculateDiscountedPrice();
        }

        private void ToBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = GetSelectedItem(_tours);


                MaterialTextBox[] validTextBox = 
                    { 
                    _firstNameTextBox, 
                    _lastNameTextBox,
                    _patronymicTextBox,
                    _addressTextBox, 
                    _phoneNumberTextBox
                };

                #region Проверка правильности номера телефона.
                bool isOnlyNumbers = false;
                isOnlyNumbers = CheckTextBoxForOnlyNumbers(_phoneNumberTextBox);
                if (!isOnlyNumbers)
                {
                    _phoneNumberTextBox.Focus();

                    MaterialMessageBox.Show("Номер должен быть заполнен только цифрами",
                        "Осторожнее",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                #endregion

                #region Проверка правильности на содержание только букв русского алфавита.
                bool isOnlyText = false;
                for (int i = 0; i < validTextBox.Length - 2; i++)
                {
                    isOnlyText = CheckTextForOnlyChart(validTextBox[i]);
                    if (!isOnlyText)
                    {
                        validTextBox[i].Focus();

                        MaterialMessageBox.Show("Данные должны быть заполнены только буквами",
                            "Осторожнее",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }
                #endregion

                #region Проверка данных на пустоту.
                bool isEmpty = false;
                foreach (var textBox in validTextBox)
                {
                    isEmpty = CheckTextForEmpty(textBox);
                    if (!isEmpty)
                    {
                        textBox.Focus();

                        MaterialMessageBox.Show("Данные должны быть заполнены",
                            "Осторожнее",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }  
                #endregion

                var book = _броньTableAdapter;

                book.Insert(Код: _броньTableAdapter.GetData().Count + 1,
                     Дата_заезда: DateTime.Parse(selectedItem.SubItems[3].Text),
                     Дата_выезда: DateTime.Parse(selectedItem.SubItems[4].Text),
                     Количество_детей: (int)_amountChildren2.Value,
                     Количество_взрослых: (int)_amountAdults2.Value,
                     Код_путевки: int.Parse(selectedItem.SubItems[0].Text),
                     Фамилия: _lastNameTextBox.Text,
                     Имя: _firstNameTextBox.Text,
                     Отчество: _patronymicTextBox.Text,
                     Адрес: _addressTextBox.Text,
                     Номер_телефона: _phoneNumberTextBox.Text,
                     Скидка: int.Parse(_discountComboBox2.Text));

                MaterialMessageBox.Show("Спасибо, что отдыхаете у нас\nС вами скоро свяжутся для уточнения информации:)",
                    "Благодарность",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            catch(ArgumentNullException)
            {
            }
        }
        private bool CheckTextBoxForOnlyNumbers(MaterialTextBox textBox)
        {

            if (!Regex.Match(textBox.Text, @"^[0-9]+$").Success)
                return false;

            return true;
        }
        private bool CheckTextForOnlyChart(MaterialTextBox textBox)
        {

            if (!Regex.Match(textBox.Text, @"^[а-яА-ЯЁё]+$").Success)
                    return false;

            return true;
        }

        private bool CheckTextForEmpty(MaterialTextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
                return true;
            return false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _date.Text = DateTime.Now.ToLongDateString();
            _time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
