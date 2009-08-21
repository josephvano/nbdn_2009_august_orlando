namespace nothinbutdotnetstore.win {
    partial class DriveBrowser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ux_open_file_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(104, 386);
            this.treeView1.TabIndex = 0;
            // 
            // uxopen_file
            // 
            this.ux_open_file_button.Location = new System.Drawing.Point(122, 61);
            this.ux_open_file_button.Name = "ux_open_file_button";
            this.ux_open_file_button.Size = new System.Drawing.Size(147, 23);
            this.ux_open_file_button.TabIndex = 1;
            this.ux_open_file_button.Text = "Open Text File";
            this.ux_open_file_button.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(122, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 268);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // DriveBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 386);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ux_open_file_button);
            this.Controls.Add(this.treeView1);
            this.Name = "DriveBrowser";
            this.Text = "DriveBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button ux_open_file_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}