using System.Data.Entity.Infrastructure;

namespace CodeFirstLearn
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();

            //sự kiện click ccootjedit, delete
            dgv.CellClick += Dgv_CellClick;
        }

        //hàm load department
        private void LoadDepartment()
        {
            try
            {
                using (var db = new ManagementContext())
                {
                    var query = from dept in db.Departments
                                orderby dept.Id
                                select new
                                {
                                    Id = dept.Id,
                                    Name = dept.Name,
                                };
                    dgv.DataSource = query.ToList();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddDepartment formAddDepartment = new FormAddDepartment();
            formAddDepartment.ShowDialog();
            LoadDepartment();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            
            LoadDepartment();
            
            //THÊM CỘT EDIT, DELETE
            AddImageColumns();

        }


        //thêm cột
        private void AddImageColumns()
        {
            // Cột Edit
            DataGridViewImageColumn editColumn = new DataGridViewImageColumn
            {
                Image = Image.FromFile(@"D:\LTCSDL\Lab5_LINQ_ EntityFramework\CodeFirstLearn\Images\edit.png"),
                Name = "Edit",
                HeaderText = "Edit",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(editColumn);

            // Cột Delete
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Image = Image.FromFile(@"D:\LTCSDL\Lab5_LINQ_ EntityFramework\CodeFirstLearn\Images\delete.png"),
                Name = "Delete",
                HeaderText = "Delete",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(deleteColumn);
        }


        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgv.Columns[e.ColumnIndex].Name;

                // Xóa bộ phận
                if (columnName == "Delete")
                {
                    int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this department?",
                                                          "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        using (var db = new ManagementContext())
                        {
                            var dept = db.Departments.Find(id);
                            if (dept != null)
                            {
                                db.Departments.Remove(dept);
                                db.SaveChanges();
                                MessageBox.Show("Department deleted successfully.");
                                LoadDepartment();
                            }
                            else
                            {
                                MessageBox.Show("Department not found!");
                            }
                        }
                    }
                }
                // Chỉnh sửa bộ phận
                else if (columnName == "Edit")
                {
                    int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

                    using (var db = new ManagementContext())
                    {
                        var dept = db.Departments.Find(id);
                        if (dept != null)
                        {
                            FormAddDepartment form = new FormAddDepartment
                            {
                                DepartmentId = dept.Id,
                                DepartmentName = dept.Name
                            };

                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                dept.Name = form.DepartmentName;
                                db.SaveChanges();
                                MessageBox.Show("Department updated successfully.");
                                LoadDepartment();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Department not found!");
                        }
                    }
                }
            }
        }
    }
}
