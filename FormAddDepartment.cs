using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstLearn
{
    public partial class FormAddDepartment : Form
    {
        // Thuộc tính để phân biệt thêm mới hoặc chỉnh sửa
        public int DepartmentId { get; set; } = 0;
        public string DepartmentName { get; set; } = string.Empty;

        public FormAddDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            try
            {
                using (var db = new ManagementContext())
                {
                    if (DepartmentId == 0)  // Thêm mới
                    {
                        var dept = new Department
                        {
                            Id = int.Parse(txtId.Text),
                            Name = txtName.Text
                        };

                        db.Departments.Add(dept);
                        MessageBox.Show("Department added successfully!");
                    }
                    else  // Cập nhật
                    {
                        var dept = db.Departments.Find(DepartmentId);
                        if (dept != null)
                        {
                            dept.Name = txtName.Text;
                            MessageBox.Show("Department updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Department not found!");
                        }
                    }

                    db.SaveChanges();
                    DialogResult = DialogResult.OK;  // Đặt kết quả thành công
                    Close();  // Đóng form
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddDepartment_Load(object sender, EventArgs e)
        {
            if (DepartmentId > 0)  // Chỉnh sửa
            {
                txtId.Text = DepartmentId.ToString();
                txtId.Enabled = false;  // Khóa chỉnh sửa Id
                txtName.Text = DepartmentName;
            }
        }
    }
}
