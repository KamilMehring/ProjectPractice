
namespace Hive_management_system
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 69);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(247, 23);
            this.assignJob.TabIndex = 3;
            this.assignJob.Text = "Przypisz tę pracę pszczole";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zmiany";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(133, 43);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 20);
            this.shifts.TabIndex = 2;
            this.shifts.ValueChanged += new System.EventHandler(this.shifts_ValueChanged);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęnacja jaj",
            "Naucznie pszczółek",
            "Utrzymywanie ula",
            "Patrol z żądzłami"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 42);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.workerBeeJob.TabIndex = 1;
            this.workerBeeJob.SelectedIndexChanged += new System.EventHandler(this.workerBeeJob_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextShift.Location = new System.Drawing.Point(310, 12);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(158, 105);
            this.nextShift.TabIndex = 4;
            this.nextShift.Text = "Przepracuj następną zmianę";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 123);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(457, 204);
            this.report.TabIndex = 5;
            this.report.TextChanged += new System.EventHandler(this.report_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 337);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hive management system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox report;
    }
}

