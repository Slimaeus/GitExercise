namespace GitExercise.Winform;
public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnlogin_Click(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string password = txtpassword.Text;

        if (IsCorrect(userName, password))
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
        }
        else
        {
            MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool IsCorrect(string userName, string password)
    {
        return userName == "admin" && password == "admin";
    }
}
