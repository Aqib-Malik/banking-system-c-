
namespace Banking_Managment_System
{
    partial class credit
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
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_credit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_credit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(486, 85);
            this.guna2GradientButton1.TabIndex = 1;
            this.guna2GradientButton1.Text = "State Bank Of Pakistan";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txt_credit
            // 
            this.txt_credit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_credit.DefaultText = "";
            this.txt_credit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_credit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_credit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_credit.DisabledState.Parent = this.txt_credit;
            this.txt_credit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_credit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_credit.FocusedState.Parent = this.txt_credit;
            this.txt_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_credit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_credit.HoverState.Parent = this.txt_credit;
            this.txt_credit.Location = new System.Drawing.Point(112, 134);
            this.txt_credit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.PasswordChar = '\0';
            this.txt_credit.PlaceholderText = "Enter Amount to be Credit";
            this.txt_credit.SelectedText = "";
            this.txt_credit.ShadowDecoration.Parent = this.txt_credit;
            this.txt_credit.Size = new System.Drawing.Size(245, 40);
            this.txt_credit.TabIndex = 3;
            this.txt_credit.TextChanged += new System.EventHandler(this.txt_credit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Amount to be Credit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_credit
            // 
            this.btn_credit.BorderRadius = 12;
            this.btn_credit.CheckedState.Parent = this.btn_credit;
            this.btn_credit.CustomImages.Parent = this.btn_credit;
            this.btn_credit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_credit.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_credit.ForeColor = System.Drawing.Color.White;
            this.btn_credit.HoverState.Parent = this.btn_credit;
            this.btn_credit.Location = new System.Drawing.Point(177, 197);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.ShadowDecoration.Parent = this.btn_credit;
            this.btn_credit.Size = new System.Drawing.Size(84, 34);
            this.btn_credit.TabIndex = 7;
            this.btn_credit.Text = "credit";
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 281);
            this.Controls.Add(this.btn_credit);
            this.Controls.Add(this.txt_credit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Name = "credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "credit";
            this.Load += new System.EventHandler(this.credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txt_credit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_credit;
    }
}