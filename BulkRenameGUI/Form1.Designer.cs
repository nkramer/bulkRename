namespace BulkRenameGUI {
    partial class Form1 {
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pickDir = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickDir
            // 
            this.pickDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDir.Location = new System.Drawing.Point(22, 22);
            this.pickDir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pickDir.Name = "pickDir";
            this.pickDir.Size = new System.Drawing.Size(249, 79);
            this.pickDir.TabIndex = 0;
            this.pickDir.Text = "Pick directory";
            this.pickDir.UseVisualStyleBackColor = true;
            this.pickDir.Click += new System.EventHandler(this.pickDir_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(282, 42);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(91, 38);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(290, 113);
            this.searchBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1082, 45);
            this.searchBox.TabIndex = 3;
            // 
            // replaceBox
            // 
            this.replaceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceBox.Location = new System.Drawing.Point(290, 192);
            this.replaceBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(1082, 45);
            this.replaceBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Replace text";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewButton.Location = new System.Drawing.Point(22, 277);
            this.previewButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(249, 79);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.Location = new System.Drawing.Point(22, 373);
            this.resultsBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsBox.Size = new System.Drawing.Size(1350, 499);
            this.resultsBox.TabIndex = 7;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(22, 886);
            this.goButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(249, 79);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 988);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pickDir);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pickDir;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Button goButton;
    }
}

