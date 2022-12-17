namespace WinFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.setup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "下一文件名";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(410, 8);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 23);
            this.fileName.TabIndex = 9;
            this.fileName.Text = "1";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(270, 36);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.PlaceholderText = "输出";
            this.output.Size = new System.Drawing.Size(257, 407);
            this.output.TabIndex = 8;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(7, 36);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.PlaceholderText = "输入";
            this.input.Size = new System.Drawing.Size(257, 407);
            this.input.TabIndex = 7;
            // 
            // setup
            // 
            this.setup.Location = new System.Drawing.Point(193, 3);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(137, 32);
            this.setup.TabIndex = 6;
            this.setup.Text = "在当前目录下读取";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.setup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "读取窗口";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox fileName;
        private TextBox output;
        private TextBox input;
        private Button setup;
    }
}