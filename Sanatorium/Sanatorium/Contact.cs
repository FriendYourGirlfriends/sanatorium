using System.Data;
using System.Windows.Forms;

namespace Sanatorium
{
    public partial class Contact : UserControl
    {
        public Contact(string type, EnumerableRowCollection<SanatoriumDataSet.ДанныеRow> dataRow)
        {
            InitializeComponent();

            _type.Text = type;

            AppendToList(dataRow);
        }

        private void AppendToList(EnumerableRowCollection<SanatoriumDataSet.ДанныеRow> dataRow)
        {
            foreach (var row in dataRow)
            {
                var item = CreateItem(row);
                _data.Items.Add(item);
            }
        }

        private ListViewItem CreateItem(SanatoriumDataSet.ДанныеRow row)
        {           
            var item = new ListViewItem();
            
            for (int i = 1; i < row.ItemArray.Length - 1; i++)
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, row.ItemArray[i].ToString()));
            }

            return item;
        }
    }
}
