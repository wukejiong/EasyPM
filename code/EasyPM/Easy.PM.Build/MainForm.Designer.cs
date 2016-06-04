namespace Easy.PM.Build
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuildDao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuildDao
            // 
            this.btnBuildDao.Location = new System.Drawing.Point(185, 20);
            this.btnBuildDao.Name = "btnBuildDao";
            this.btnBuildDao.Size = new System.Drawing.Size(75, 23);
            this.btnBuildDao.TabIndex = 0;
            this.btnBuildDao.Text = "生成";
            this.btnBuildDao.UseVisualStyleBackColor = true;
            this.btnBuildDao.Click += new System.EventHandler(this.btnBuildDao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "生成Dao和IDao";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuildDao);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuildDao;
        private System.Windows.Forms.Label label1;
    }
}

