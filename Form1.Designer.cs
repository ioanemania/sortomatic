using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sort_O_Matic
{
    partial class SortOMaticForm
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
            this.randomArrayButton = new System.Windows.Forms.Button();
            this.ascendingArrayButton = new System.Windows.Forms.Button();
            this.descendingArrayButton = new System.Windows.Forms.Button();
            this.sortToggleButton = new System.Windows.Forms.Button();
            this.sortListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sorterTimeListBox = new System.Windows.Forms.ListBox();
            this.interactionPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.AutoSize = true;
            this.graphicsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(3, 3);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(586, 444);
            this.graphicsPanel.TabIndex = 0;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            // 
            // interactionPanel
            // 
            this.interactionPanel.Controls.Add(this.sorterTimeListBox);
            this.interactionPanel.Controls.Add(this.randomArrayButton);
            this.interactionPanel.Controls.Add(this.ascendingArrayButton);
            this.interactionPanel.Controls.Add(this.descendingArrayButton);
            this.interactionPanel.Controls.Add(this.sortToggleButton);
            this.interactionPanel.Controls.Add(this.sortListBox);
            this.interactionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interactionPanel.Location = new System.Drawing.Point(595, 3);
            this.interactionPanel.Name = "interactionPanel";
            this.interactionPanel.Size = new System.Drawing.Size(202, 444);
            this.interactionPanel.TabIndex = 0;
            // 
            // randomArrayButton
            // 
            this.randomArrayButton.Location = new System.Drawing.Point(18, 17);
            this.randomArrayButton.Name = "randomArrayButton";
            this.randomArrayButton.Size = new System.Drawing.Size(75, 23);
            this.randomArrayButton.TabIndex = 4;
            this.randomArrayButton.Text = "Random";
            this.randomArrayButton.UseVisualStyleBackColor = true;
            this.randomArrayButton.Click += new System.EventHandler(this.randomArrayButton_Click);
            // 
            // ascendingArrayButton
            // 
            this.ascendingArrayButton.Location = new System.Drawing.Point(18, 46);
            this.ascendingArrayButton.Name = "ascendingArrayButton";
            this.ascendingArrayButton.Size = new System.Drawing.Size(75, 23);
            this.ascendingArrayButton.TabIndex = 3;
            this.ascendingArrayButton.Text = "Ascending";
            this.ascendingArrayButton.UseVisualStyleBackColor = true;
            this.ascendingArrayButton.Click += new System.EventHandler(this.ascendingArrayButton_Click);
            // 
            // descendingArrayButton
            // 
            this.descendingArrayButton.Location = new System.Drawing.Point(18, 79);
            this.descendingArrayButton.Name = "descendingArrayButton";
            this.descendingArrayButton.Size = new System.Drawing.Size(75, 23);
            this.descendingArrayButton.TabIndex = 2;
            this.descendingArrayButton.Text = "Descending";
            this.descendingArrayButton.UseVisualStyleBackColor = true;
            this.descendingArrayButton.Click += new System.EventHandler(this.descendingArrayButton_Click);
            // 
            // sortToggleButton
            // 
            this.sortToggleButton.Location = new System.Drawing.Point(99, 12);
            this.sortToggleButton.Name = "sortToggleButton";
            this.sortToggleButton.Size = new System.Drawing.Size(75, 90);
            this.sortToggleButton.TabIndex = 1;
            this.sortToggleButton.Text = "Start";
            this.sortToggleButton.UseVisualStyleBackColor = true;
            this.sortToggleButton.Click += new System.EventHandler(this.sortToggleButton_Click);
            // 
            // sortListBox
            // 
            this.sortListBox.Location = new System.Drawing.Point(0, 115);
            this.sortListBox.Name = "sortListBox";
            this.sortListBox.Size = new System.Drawing.Size(101, 329);
            this.sortListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.Controls.Add(this.interactionPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.graphicsPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // sorterTimeListBox
            // 
            this.sorterTimeListBox.Enabled = false;
            this.sorterTimeListBox.FormattingEnabled = true;
            this.sorterTimeListBox.Location = new System.Drawing.Point(98, 115);
            this.sorterTimeListBox.Name = "sorterTimeListBox";
            this.sorterTimeListBox.Size = new System.Drawing.Size(101, 329);
            this.sorterTimeListBox.TabIndex = 5;
            // 
            // SortOMaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SortOMaticForm";
            this.Text = "Sort\'O Matic";
            this.interactionPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox sorterTimeListBox;
    }
}

