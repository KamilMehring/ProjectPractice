
namespace Workers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addWorker = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.addSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię pracownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // addWorker
            // 
            this.addWorker.Location = new System.Drawing.Point(31, 58);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(187, 23);
            this.addWorker.TabIndex = 3;
            this.addWorker.Text = "Dodaj pracownika";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(31, 87);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(187, 277);
            this.line.TabIndex = 4;
            // 
            // addSQL
            // 
            this.addSQL.Location = new System.Drawing.Point(31, 370);
            this.addSQL.Name = "addSQL";
            this.addSQL.Size = new System.Drawing.Size(187, 23);
            this.addSQL.TabIndex = 5;
            this.addSQL.Text = "Dodaj do SQLite";
            this.addSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.addSQL);
            this.Controls.Add(this.line);
            this.Controls.Add(this.addWorker);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Button addSQL;
    }
}

