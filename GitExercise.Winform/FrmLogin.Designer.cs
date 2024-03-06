namespace GitExercise.Winform;

partial class FrmLogin
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
        txtUserName = new TextBox();
        txtpassword = new TextBox();
        label2 = new Label();
        btnlogin = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(30, 41);
        label1.Name = "label1";
        label1.Size = new Size(84, 15);
        label1.TabIndex = 0;
        label1.Text = "tên đăng nhập";
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(127, 38);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(208, 23);
        txtUserName.TabIndex = 1;
        // 
        // txtpassword
        // 
        txtpassword.Location = new Point(127, 64);
        txtpassword.Name = "txtpassword";
        txtpassword.Size = new Size(208, 23);
        txtpassword.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(30, 68);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 2;
        label2.Text = "mật khẩu";
        // 
        // btnlogin
        // 
        btnlogin.Location = new Point(127, 104);
        btnlogin.Margin = new Padding(3, 2, 3, 2);
        btnlogin.Name = "btnlogin";
        btnlogin.Size = new Size(208, 24);
        btnlogin.TabIndex = 4;
        btnlogin.Text = "đăng nhập";
        btnlogin.UseVisualStyleBackColor = true;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(364, 148);
        Controls.Add(btnlogin);
        Controls.Add(txtpassword);
        Controls.Add(label2);
        Controls.Add(txtUserName);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "FrmLogin";
        Text = "Đăng nhập";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtUserName;
    private TextBox txtpassword;
    private Label label2;
    private Button btnlogin;
}