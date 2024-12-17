using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormMain : Form
    {
        private DatabaseHelper dbHelper;

        public FormMain()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("RepairRequest.db");
            LoadRequests();
        }

        private void LoadRequests()
        {
            listViewRequests.Items.Clear();
            var requests = dbHelper.GetAllRequests();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.Description);
                item.SubItems.Add(request.Status);
                listViewRequests.Items.Add(item);
            }
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                var request = new RepairRequest
                {
                    Description = textBoxDescription.Text,
                    Status = "В ожидании"
                };
                dbHelper.AddRequest(request);
                LoadRequests();
                textBoxDescription.Clear();
            }
            else
            {
                MessageBox.Show("Введите описание заявки.");
            }
        }

        private void buttonCompleteRequest_Click(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count > 0)
            {
                var selectedItem = listViewRequests.SelectedItems[0];
                int idToUpdate = listViewRequests.Items.IndexOf(selectedItem) + 1; // Предполагаем, что Id начинается с 1

                var requestToUpdate = new RepairRequest
                {
                    Id = idToUpdate,
                    Description = selectedItem.Text,
                    Status = "Завершено"
                };

                dbHelper.UpdateRequest(requestToUpdate);
                LoadRequests();
            }
            else
            {
                MessageBox.Show("Выберите заявку для завершения.");
            }
        }

        private void buttonDeleteRequest_Click(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count > 0)
            {
                var selectedItem = listViewRequests.SelectedItems[0];
                int idToDelete = listViewRequests.Items.IndexOf(selectedItem) + 1; // Предполагаем, что Id начинается с 1
                dbHelper.DeleteRequest(idToDelete);
                LoadRequests();
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.");
            }
        }

        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count > 0)
            {
                var selectedItem = listViewRequests.SelectedItems[0];
                int idToUpdate = listViewRequests.Items.IndexOf(selectedItem) + 1; // Предполагаем, что Id начинается с 1

                var requestToUpdate = new RepairRequest
                {
                    Id = idToUpdate,
                    Description = textBoxDescription.Text,
                    Status = "В ожидании" // сбрасываем статус
                };

                dbHelper.UpdateRequest(requestToUpdate);
                LoadRequests();
                textBoxDescription.Clear();
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования.");
            }
        }
    }
}
