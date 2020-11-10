using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            Utility.DATABASECONNECTION = new DatabaseConnection();
            if (Utility.DATABASECONNECTION.verifyConnection())
                MessageBox.Show("Kết nối thành công tới database", "Thông báo");
            else MessageBox.Show("Không thể kết nối database", "Thông báo");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SysAccount.LoginAccount(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Tài khoản " + Utility.ACCOUNT + " đăng nhập thành công", "Thông báo");
                this.Hide();
                RouterForm router = new RouterForm();
                router.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void VerifyInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            for (int i = 0; i < textBox.TextLength; i++)
            {
                if (char.IsLetterOrDigit(textBox.Text[i]) == false)
                {
                    textBox.Text = textBox.Text.Remove(i, 1);
                    textBox.SelectionStart = i;
                    textBox.SelectionLength = 0;
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
            ShowInTaskbar = false;
            //this.Close();
            //thread = new Thread(Utility.OpenNewForm);
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
            //this.Hide();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //LogonForm logon = new LogonForm();

            //Application.Run(logon);

            //if (logon.LogonSuccessful)
            //{
            //    Application.Run(new MainForm());
            //}
        }
    }
}
