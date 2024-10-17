namespace hedieuhanh
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
            btnbrowse = new Button();
            btnstart = new Button();
            btnrefresh = new Button();
            btnstop = new Button();
            label1 = new Label();
            txtPath = new TextBox();
            IbOutput = new ListBox();
            SuspendLayout();
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new Point(42, 49);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(75, 23);
            btnbrowse.TabIndex = 0;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // btnstart
            // 
            btnstart.Location = new Point(649, 50);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(75, 23);
            btnstart.TabIndex = 1;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(50, 344);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(75, 23);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnstop
            // 
            btnstop.Location = new Point(649, 350);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(75, 23);
            btnstop.TabIndex = 3;
            btnstop.Text = "Stop";
            btnstop.UseVisualStyleBackColor = true;
            btnstop.Click += btnstop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 94);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 4;
            label1.Text = "Cac process dang chay";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(147, 50);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(478, 23);
            txtPath.TabIndex = 5;
            // 
            // IbOutput
            // 
            IbOutput.FormattingEnabled = true;
            IbOutput.ItemHeight = 15;
            IbOutput.Location = new Point(42, 125);
            IbOutput.Name = "IbOutput";
            IbOutput.Size = new Size(698, 199);
            IbOutput.TabIndex = 6;
            IbOutput.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IbOutput);
            Controls.Add(txtPath);
            Controls.Add(label1);
            Controls.Add(btnstop);
            Controls.Add(btnrefresh);
            Controls.Add(btnstart);
            Controls.Add(btnbrowse);
            Name = "Form1";
            Text = "Quan li process";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbrowse;
        private Button btnstart;
        private Button btnrefresh;
        private Button btnstop;
        private Label label1;
        private TextBox txtPath;
        private ListBox IbOutput;
    }
}