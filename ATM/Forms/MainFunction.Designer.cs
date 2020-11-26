﻿
namespace ATM.Forms
{
    partial class MainFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFunction));
            this.changePass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.accountView = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountView)).BeginInit();
            this.SuspendLayout();
            // 
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.Color.White;
            this.changePass.FlatAppearance.BorderSize = 0;
            this.changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePass.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changePass.Location = new System.Drawing.Point(179, 266);
            this.changePass.Margin = new System.Windows.Forms.Padding(0);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(75, 23);
            this.changePass.TabIndex = 0;
            this.changePass.Text = "密码修改";
            this.changePass.UseVisualStyleBackColor = false;
            this.changePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(312, 266);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "用户名修改";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackColor = System.Drawing.Color.White;
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddAccountButton.Location = new System.Drawing.Point(46, 266);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccountButton.TabIndex = 5;
            this.AddAccountButton.Text = "新增账户";
            this.AddAccountButton.UseVisualStyleBackColor = false;
            // 
            // accountView
            // 
            this.accountView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.accountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountView.Location = new System.Drawing.Point(12, 12);
            this.accountView.Name = "accountView";
            this.accountView.RowTemplate.Height = 23;
            this.accountView.Size = new System.Drawing.Size(561, 237);
            this.accountView.TabIndex = 6;
            this.accountView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountView_CellContentClick);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Crimson;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(457, 266);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 7;
            this.logout.Text = "退出登录";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MainFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.ControlBox = false;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.accountView);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.changePass);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主要功能分区";
            this.Load += new System.EventHandler(this.MainFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.DataGridView accountView;
        private System.Windows.Forms.Button logout;
    }
}