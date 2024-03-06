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
        txtmatkhau = new TextBox();
        label2 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 55);
        label1.Name = "label1";
        label1.Size = new Size(78, 20);
        label1.TabIndex = 0;
        label1.Text = "UserName";
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(112, 51);
        txtUserName.Margin = new Padding(3, 4, 3, 4);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(270, 27);
        txtUserName.TabIndex = 1;
        // 
        // txtmatkhau
        // 
        txtmatkhau.Location = new Point(112, 86);
        txtmatkhau.Margin = new Padding(3, 4, 3, 4);
        txtmatkhau.Name = "txtmatkhau";
        txtmatkhau.Size = new Size(270, 27);
        txtmatkhau.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(34, 90);
        label2.Name = "label2";
        label2.Size = new Size(70, 20);
        label2.TabIndex = 2;
        label2.Text = "Mật khẩu";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(426, 236);
        Controls.Add(txtmatkhau);
        Controls.Add(label2);
        Controls.Add(txtUserName);
        Controls.Add(label1);
        Name = "FrmLogin";
        Text = "Đăng nhập";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtUserName;
    private TextBox txtmatkhau;
    private Label label2;
}