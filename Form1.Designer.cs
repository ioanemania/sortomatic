namespace Sort_O_Matic
{
    partial class Form1
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
            this.graphicsPanel = new System.Windows.Forms.Panel();
            this.interactionPanel = new System.Windows.Forms.Panel();
            this.sortListBox = new System.Windows.Forms.ListBox();
            this.sortToggleButton = new System.Windows.Forms.Button();
            this.descendingArrayButton = new System.Windows.Forms.Button();
            this.ascendingArrayButton = new System.Windows.Forms.Button();
            this.randomArrayButton = new System.Windows.Forms.Button();
            this.graphicsPanel.SuspendLayout();
            this.interactionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.Controls.Add(this.interactionPanel);
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(0, 0);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(800, 450);
            this.graphicsPanel.TabIndex = 0;
            // 
            // interactionPanel
            // 
            this.interactionPanel.Controls.Add(this.randomArrayButton);
            this.interactionPanel.Controls.Add(this.ascendingArrayButton);
            this.interactionPanel.Controls.Add(this.descendingArrayButton);
            this.interactionPanel.Controls.Add(this.sortToggleButton);
            this.interactionPanel.Controls.Add(this.sortListBox);
            this.interactionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.interactionPanel.Location = new System.Drawing.Point(609, 0);
            this.interactionPanel.Name = "interactionPanel";
            this.interactionPanel.Size = new System.Drawing.Size(191, 450);
            this.interactionPanel.TabIndex = 0;
            // 
            // sortListBox
            // 
            this.sortListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortListBox.FormattingEnabled = true;
            this.sortListBox.Location = new System.Drawing.Point(0, 121);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(191, 329);
            this.sortListBox.TabIndex = 0;
            // 
            // sortToggleButton
            // 
            this.sortToggleButton.Location = new System.Drawing.Point(99, 12);
            this.sortToggleButton.Name = "sortToggleButton";
            this.sortToggleButton.Size = new System.Drawing.Size(75, 90);
            this.sortToggleButton.TabIndex = 1;
            this.sortToggleButton.Text = "Start";
            this.sortToggleButton.UseVisualStyleBackColor = true;
            // 
            // descendingArrayButton
            // 
            this.descendingArrayButton.Location = new System.Drawing.Point(18, 79);
            this.descendingArrayButton.Name = "descendingArrayButton";
            this.descendingArrayButton.Size = new System.Drawing.Size(75, 23);
            this.descendingArrayButton.TabIndex = 2;
            this.descendingArrayButton.Text = "Descending";
            this.descendingArrayButton.UseVisualStyleBackColor = true;
            this.descendingArrayButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ascendingArrayButton
            // 
            this.ascendingArrayButton.Location = new System.Drawing.Point(18, 46);
            this.ascendingArrayButton.Name = "ascendingArrayButton";
            this.ascendingArrayButton.Size = new System.Drawing.Size(75, 23);
            this.ascendingArrayButton.TabIndex = 3;
            this.ascendingArrayButton.Text = "Ascending";
            this.ascendingArrayButton.UseVisualStyleBackColor = true;
            // 
            // randomArrayButton
            // 
            this.randomArrayButton.Location = new System.Drawing.Point(18, 17);
            this.randomArrayButton.Name = "randomArrayButton";
            this.randomArrayButton.Size = new System.Drawing.Size(75, 23);
            this.randomArrayButton.TabIndex = 4;
            this.randomArrayButton.Text = "Random";
            this.randomArrayButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphicsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.graphicsPanel.ResumeLayout(false);
            this.interactionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel graphicsPanel;
        private System.Windows.Forms.Panel interactionPanel;
        private System.Windows.Forms.Button descendingArrayButton;
        private System.Windows.Forms.Button sortToggleButton;
        private System.Windows.Forms.ListBox sortListBox;
        private System.Windows.Forms.Button randomArrayButton;
        private System.Windows.Forms.Button ascendingArrayButton;
    }
}

