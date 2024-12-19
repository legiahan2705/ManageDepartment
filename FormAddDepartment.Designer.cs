namespace CodeFirstLearn
{
    partial class FormAddDepartment
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
            label1 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 100);
            panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(135, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 51);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(13, 186);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 220);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 27);
            txtName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(14, 110);
            label2.Name = "label2";
            label2.Size = new Size(35, 31);
            label2.TabIndex = 10;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 144);
            txtId.Name = "txtId";
            txtId.Size = new Size(347, 27);
            txtId.TabIndex = 9;
            // 
            // FormAddDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 336);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Name = "FormAddDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Department";
            Load += FormAddDepartment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnSave;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtId;
    }
}