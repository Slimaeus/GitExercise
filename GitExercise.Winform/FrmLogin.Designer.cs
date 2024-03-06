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
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(30, 41);
        label1.Name = "label1";
        label1.Size = new Size(62, 15);
        label1.TabIndex = 0;
        label1.Text = "UserName";
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(98, 38);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(237, 23);
        txtUserName.TabIndex = 1;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(373, 177);
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
}