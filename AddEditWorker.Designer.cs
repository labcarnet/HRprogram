
namespace HRprogram
{
    partial class AddEditWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReward = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStopDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReleased = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // tbFirstName
            // 
            this.tbFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFirstName.Location = new System.Drawing.Point(145, 46);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLastName.Location = new System.Drawing.Point(145, 72);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // tbReward
            // 
            this.tbReward.Location = new System.Drawing.Point(145, 125);
            this.tbReward.Name = "tbReward";
            this.tbReward.Size = new System.Drawing.Size(200, 20);
            this.tbReward.TabIndex = 5;
            this.tbReward.TextChanged += new System.EventHandler(this.tbReward_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data rozpoczęcia prcy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data zakończenia pracy:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(145, 98);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 8;
            // 
            // dtpStopDate
            // 
            this.dtpStopDate.Location = new System.Drawing.Point(145, 323);
            this.dtpStopDate.Name = "dtpStopDate";
            this.dtpStopDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStopDate.TabIndex = 9;
            this.dtpStopDate.Visible = false;
            this.dtpStopDate.ValueChanged += new System.EventHandler(this.dtpStopDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wynagrodzenie";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(145, 151);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(200, 118);
            this.rtbComments.TabIndex = 12;
            this.rtbComments.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Uwagi";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(145, 20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(200, 20);
            this.tbId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numer Pracownika";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 357);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReleased
            // 
            this.btnReleased.Location = new System.Drawing.Point(145, 285);
            this.btnReleased.Name = "btnReleased";
            this.btnReleased.Size = new System.Drawing.Size(200, 23);
            this.btnReleased.TabIndex = 18;
            this.btnReleased.Text = "Zakończ współpracę";
            this.btnReleased.UseVisualStyleBackColor = true;
            this.btnReleased.Click += new System.EventHandler(this.btnReleased_Click);
            // 
            // AddEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 395);
            this.Controls.Add(this.btnReleased);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStopDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbReward);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Name = "AddEditWorker";
            this.Text = "Dodawanie / edycja pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpStopDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReleased;
    }
}