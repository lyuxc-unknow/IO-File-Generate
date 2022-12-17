namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.setup = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setup
            // 
            this.setup.Location = new System.Drawing.Point(188, 2);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(137, 32);
            this.setup.TabIndex = 0;
            this.setup.Text = "在当前目录下生成";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(88, 17);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 22);
            this.clear.TabIndex = 1;
            this.clear.Text = "清空输入输出";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(2, 40);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.PlaceholderText = "输入";
            this.input.Size = new System.Drawing.Size(257, 407);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(265, 40);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.PlaceholderText = "输出";
            this.output.Size = new System.Drawing.Size(257, 407);
            this.output.TabIndex = 3;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(405, 7);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 23);
            this.fileName.TabIndex = 4;
            this.fileName.Text = "1";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "下一文件名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "读取测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(98, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "生成清空二合一";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 451);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.setup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "主窗口";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button setup;
        private Button clear;
        private TextBox input;
        private TextBox output;
        private TextBox fileName;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
    }
}