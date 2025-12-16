using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Algoritmos
{
    partial class MainForm
    {
        private IContainer components = null;

        // Panels & Layout
        private Panel topPanel;
        private Panel bottomPanel;
        private Panel leftPanel;
        private Panel rightPanel;
        private SplitContainer splitContainer;

        // Controls (Top)
        private Label lblSize;
        private NumericUpDown nudSize;
        private Label lblAlgoTitle;
        private ComboBox cmbAlgorithm;
        private Button btnAlgorithm;

        // Controls (Center)
        private ListBox lbOriginal;
        private Label lblOriginalTitle;
        private ListBox lbSorted;
        private Label lblSortedTitle;

        // Controls (Bottom)
        private Label lblStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            topPanel = new Panel();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            lblAlgoTitle = new Label();
            cmbAlgorithm = new ComboBox();
            btnAlgorithm = new Button();
            bottomPanel = new Panel();
            lblStats = new Label();
            splitContainer = new SplitContainer();
            leftPanel = new Panel();
            lbOriginal = new ListBox();
            lblOriginalTitle = new Label();
            rightPanel = new Panel();
            lbSorted = new ListBox();
            lblSortedTitle = new Label();
            topPanel.SuspendLayout();
            ((ISupportInitialize)nudSize).BeginInit();
            bottomPanel.SuspendLayout();
            ((ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.Controls.Add(lblSize);
            topPanel.Controls.Add(nudSize);
            topPanel.Controls.Add(lblAlgoTitle);
            topPanel.Controls.Add(cmbAlgorithm);
            topPanel.Controls.Add(btnAlgorithm);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20);
            topPanel.Size = new Size(1036, 80);
            topPanel.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(20, 30);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(72, 19);
            lblSize.TabIndex = 0;
            lblSize.Text = "Array Size:";
            // 
            // nudSize
            // 
            nudSize.Location = new Point(120, 26);
            nudSize.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(120, 25);
            nudSize.TabIndex = 1;
            nudSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblAlgoTitle
            // 
            lblAlgoTitle.AutoSize = true;
            lblAlgoTitle.Location = new Point(293, 28);
            lblAlgoTitle.Name = "lblAlgoTitle";
            lblAlgoTitle.Size = new Size(73, 19);
            lblAlgoTitle.TabIndex = 2;
            lblAlgoTitle.Text = "Algorithm:";
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.Items.AddRange(new object[] { "Quick Sort", "Bubble Sort", "Cocktail Sort", "Insert Sort", "Selection Sort", "Merge Sort D", "Merge Sort N", "Gnome Sort", "Bucket Sort", "Counting Sort", "Radix Sort", "Heap Sort", "Shell Sort" });
            cmbAlgorithm.Location = new Point(389, 25);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(140, 25);
            cmbAlgorithm.TabIndex = 3;
            // 
            // btnAlgorithm
            // 
            btnAlgorithm.BackColor = Color.DodgerBlue;
            btnAlgorithm.FlatStyle = FlatStyle.Flat;
            btnAlgorithm.ForeColor = Color.White;
            btnAlgorithm.Location = new Point(544, 22);
            btnAlgorithm.Name = "btnAlgorithm";
            btnAlgorithm.Size = new Size(150, 35);
            btnAlgorithm.TabIndex = 4;
            btnAlgorithm.Text = "Generate & Sort";
            btnAlgorithm.UseVisualStyleBackColor = false;
            btnAlgorithm.Click += BtnAlgorithm_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.LightYellow;
            bottomPanel.Controls.Add(lblStats);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 474);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(10);
            bottomPanel.Size = new Size(1036, 200);
            bottomPanel.TabIndex = 1;
            // 
            // lblStats
            // 
            lblStats.Dock = DockStyle.Fill;
            lblStats.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblStats.Location = new Point(10, 10);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(1016, 180);
            lblStats.TabIndex = 0;
            lblStats.Text = "Statistics will appear here...";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 80);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(leftPanel);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(rightPanel);
            splitContainer.Size = new Size(1036, 394);
            splitContainer.SplitterDistance = 835;
            splitContainer.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(lbOriginal);
            leftPanel.Controls.Add(lblOriginalTitle);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(10);
            leftPanel.Size = new Size(835, 394);
            leftPanel.TabIndex = 0;
            // 
            // lbOriginal
            // 
            lbOriginal.Dock = DockStyle.Fill;
            lbOriginal.ItemHeight = 17;
            lbOriginal.Location = new Point(10, 40);
            lbOriginal.Name = "lbOriginal";
            lbOriginal.Size = new Size(815, 344);
            lbOriginal.TabIndex = 0;
            // 
            // lblOriginalTitle
            // 
            lblOriginalTitle.Dock = DockStyle.Top;
            lblOriginalTitle.Location = new Point(10, 10);
            lblOriginalTitle.Name = "lblOriginalTitle";
            lblOriginalTitle.Size = new Size(815, 30);
            lblOriginalTitle.TabIndex = 1;
            lblOriginalTitle.Text = "Original Array (Random)";
            lblOriginalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(lbSorted);
            rightPanel.Controls.Add(lblSortedTitle);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.Size = new Size(197, 394);
            rightPanel.TabIndex = 0;
            // 
            // lbSorted
            // 
            lbSorted.Dock = DockStyle.Fill;
            lbSorted.ItemHeight = 17;
            lbSorted.Location = new Point(10, 40);
            lbSorted.Name = "lbSorted";
            lbSorted.Size = new Size(177, 344);
            lbSorted.TabIndex = 0;
            // 
            // lblSortedTitle
            // 
            lblSortedTitle.Dock = DockStyle.Top;
            lblSortedTitle.Location = new Point(10, 10);
            lblSortedTitle.Name = "lblSortedTitle";
            lblSortedTitle.Size = new Size(177, 30);
            lblSortedTitle.TabIndex = 1;
            lblSortedTitle.Text = "Sorted Array";
            lblSortedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            ClientSize = new Size(1036, 674);
            Controls.Add(splitContainer);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sorting Algorithms Tester";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((ISupportInitialize)nudSize).EndInit();
            bottomPanel.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
