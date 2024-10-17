using System.Diagnostics;

namespace hedieuhanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            //tạo form duyệt chọn file khả thi cần chạy 
            OpenFileDialog dlg = new OpenFileDialog();
            //hiển thị form duyệt chọn file khả thi cần chạy 
            DialogResult ret = dlg.ShowDialog();
            //kiểm tra quyết ₫ịnh của người dùng, nếu người dùng chọn OK thì ghi nhận tên file 
            if (ret == DialogResult.OK)
                txtPath.Text = dlg.FileName;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            
            //tạo mới ₫ối tượng quản lý Process. 
            Process myProcess = new Process();
            try
            {
                //thiết lập ₫ường dẫn file cần chạy 
                myProcess.StartInfo.FileName = txtPath.Text;
                //kích hoạt process 
                myProcess.Start();
                //hiển thị danh sách các process ₫ang chạy 
                DisplayProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            //xác ₫ịnh tên, ID của process ₫ang ₫ược chọn ₫ể xóa 
            String[] param = IbOutput.SelectedItem.ToString().Split(',');
            //tìm ₫ối tượng quản lý process có ID xác ₫ịnh 
            Process proc = Process.GetProcessById(Int32.Parse(param[1]));
            //xóa process 
            proc.Kill();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            //hiển thị lại danh sách các process ₫ang chạy hiện hành 
            DisplayProcess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void DisplayProcess()
        {
            //xóa nội dung cũ của ListBox 
            IbOutput.Items.Clear();
            //tìm danh sách các process ₫ang chạy 
            Process[] plist = Process.GetProcesses();
            //hiển thị tên, ID của từng process 
            foreach (Process process in plist)
            {
                IbOutput.Items.Add(process.ProcessName + ", " + process.Id);
            }

        }
    }
}