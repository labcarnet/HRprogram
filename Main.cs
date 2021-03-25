using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRprogram
{
    public partial class HRProgram : Form
    {
        private FileHelper<List<Worker>> _fileHelper =
            new FileHelper<List<Worker>>(Program.FilePath);
        private List<Group> _groups;
        public HRProgram()
        {
            InitializeComponent();
            _groups = GroupsHelper.GetGroups("Wszyscy");
            
            InitGroupsCombobox();
            SetColumnsSettings();

            RefreshDataTable();
        }

        private void InitGroupsCombobox()
        {
            cbxGroup.DataSource = _groups;
            cbxGroup.DisplayMember = "Name";
            cbxGroup.ValueMember = "Id";
        }

        private void SetColumnsSettings()
        {
            dgvDataTable.Columns[nameof(Worker.Id)].HeaderText = "Numer";
            dgvDataTable.Columns[1].HeaderText = "Imię";
            dgvDataTable.Columns[2].HeaderText = "Nazwisko";
            dgvDataTable.Columns[3].HeaderText = "Data rozpoczęcia pracy";
            dgvDataTable.Columns[4].HeaderText = "Data zakończenia pracy";
            dgvDataTable.Columns[5].HeaderText = "Wynagrodzenie";
            dgvDataTable.Columns[6].HeaderText = "Uwagi";
            dgvDataTable.Columns[7].Visible = false;
        }

        private void RefreshDataTable()
        {
            var workers = _fileHelper.DeserializerFormFile();
            //dgvDataTable.DataSource = workers;

            var selectedGroupId = (cbxGroup.SelectedItem as Group).Id;

            if (selectedGroupId != 0)
                workers = workers
                    .Where(x => x.IdGroup == selectedGroupId)
                    .ToList();

            dgvDataTable.DataSource = workers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditWorker = new AddEditWorker();
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();
        }

        private void AddEditWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDataTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDataTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz Pracownika, którego dane chcesz edytować.");
                return;
            }

            var addEditWorker = new AddEditWorker(Convert.ToInt32(dgvDataTable.SelectedRows[0].Cells[0].Value));
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();
        }

        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataTable();
        }
    }
}
