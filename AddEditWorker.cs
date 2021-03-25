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
    public partial class AddEditWorker : Form
    {
        private FileHelper<List<Worker>> _fileHelper =
            new FileHelper<List<Worker>>(Program.FilePath);

        private int _workerId;
        private int _workerIdGroup;
        private double _workerReward;
        private DateTime _workerEndDate;
        private Worker _worker;
        public AddEditWorker(int id = 0, int idGroup = 0)
        {
            InitializeComponent();
            tbReward.Text = "0";
            _workerId = id;
            _workerIdGroup = idGroup;
            GetWorkerData();
            tbFirstName.Select();
        }

        private void GetWorkerData()
        {
            if (_workerId != 0)
            {
                Text = "Edytowanie danych pracownika";
                var workers = _fileHelper.DeserializerFormFile();
                _worker = workers.FirstOrDefault(x => x.Id == _workerId);

                if (_worker == null) throw new Exception("Brak użytkownika o podanym ID");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _worker.Id.ToString();
            tbFirstName.Text = _worker.FirstName;
            tbLastName.Text = _worker.LastName;
            dtpStartDate.Value = _worker.StartDate;
            tbReward.Text = _worker.Reward.ToString();
            rtbComments.Text = _worker.Comments;
            _workerIdGroup = _worker.IdGroup;

            if (_worker.IdGroup != 2)
            {
                dtpStopDate.Visible = false;
            }
            else
            {
                _workerEndDate = _worker.EndDate;
                dtpStopDate.Value = _worker.EndDate;
                btnReleased.Enabled = false;
            }
        }
        private void AddNewUserToList(List<Worker> workers)
        {
            if (_workerIdGroup == 0) _workerIdGroup = 1;
            var worker = new Worker
            {
                Id = _workerId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                StartDate = dtpStartDate.Value.Date,
                EndDate = _workerEndDate,
                Reward = _workerReward,
                Comments = rtbComments.Text,
                IdGroup = _workerIdGroup,
            };
            workers.Add(worker);
        }
        private void AssignIdToNewWorker(List<Worker> workers)
        {
            var workerWithHigestId = workers.OrderByDescending(x => x.Id).FirstOrDefault();
            _workerId = workerWithHigestId == null ? 1 : workerWithHigestId.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var workers = _fileHelper.DeserializerFormFile();

            if (_workerId != 0) workers.RemoveAll(x => x.Id == _workerId);

            else AssignIdToNewWorker(workers);

            AddNewUserToList(workers);

            _fileHelper.SerializeToFile(workers);
            Close();
        }

        private void dtpStopDate_ValueChanged(object sender, EventArgs e)
        {
            _workerEndDate = dtpStopDate.Value.Date;
        }

        private void btnReleased_Click(object sender, EventArgs e)
        {
            dtpStopDate.Visible = true;
            _workerIdGroup = 2;
            _workerEndDate = dtpStopDate.Value.Date;
        }

        private void tbReward_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _workerReward = Convert.ToDouble(tbReward.Text);
            }
            catch
            {
                MessageBox.Show("Wprowadzono nieporawne dane. Dozwolone znaki 0-9 oraz ,");
                tbReward.Text = "0";
            }
        }
    }
}
