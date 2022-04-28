namespace FinalProjectPart2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateArray = new System.Windows.Forms.Button();
            this.panelBubbleSortVisualizer = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSelectionSortVisualizer = new System.Windows.Forms.Panel();
            this.panelQuickSortVisualizer = new System.Windows.Forms.Panel();
            this.labelBubbleSortTime = new System.Windows.Forms.Label();
            this.labelSelectionSortTime = new System.Windows.Forms.Label();
            this.labelQuickSortTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorting Type:";
            // 
            // buttonGenerateArray
            // 
            this.buttonGenerateArray.Location = new System.Drawing.Point(16, 187);
            this.buttonGenerateArray.Name = "buttonGenerateArray";
            this.buttonGenerateArray.Size = new System.Drawing.Size(109, 23);
            this.buttonGenerateArray.TabIndex = 2;
            this.buttonGenerateArray.Text = "Generate Numbers";
            this.buttonGenerateArray.UseVisualStyleBackColor = true;
            this.buttonGenerateArray.Click += new System.EventHandler(this.buttonGenerateArray_Click);
            // 
            // panelBubbleSortVisualizer
            // 
            this.panelBubbleSortVisualizer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBubbleSortVisualizer.Location = new System.Drawing.Point(112, 31);
            this.panelBubbleSortVisualizer.Name = "panelBubbleSortVisualizer";
            this.panelBubbleSortVisualizer.Size = new System.Drawing.Size(100, 100);
            this.panelBubbleSortVisualizer.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(442, 187);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time elapsed:";
            // 
            // panelSelectionSortVisualizer
            // 
            this.panelSelectionSortVisualizer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSelectionSortVisualizer.Location = new System.Drawing.Point(264, 31);
            this.panelSelectionSortVisualizer.Name = "panelSelectionSortVisualizer";
            this.panelSelectionSortVisualizer.Size = new System.Drawing.Size(100, 100);
            this.panelSelectionSortVisualizer.TabIndex = 4;
            // 
            // panelQuickSortVisualizer
            // 
            this.panelQuickSortVisualizer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelQuickSortVisualizer.Location = new System.Drawing.Point(417, 31);
            this.panelQuickSortVisualizer.Name = "panelQuickSortVisualizer";
            this.panelQuickSortVisualizer.Size = new System.Drawing.Size(100, 100);
            this.panelQuickSortVisualizer.TabIndex = 5;
            // 
            // labelBubbleSortTime
            // 
            this.labelBubbleSortTime.AutoSize = true;
            this.labelBubbleSortTime.Location = new System.Drawing.Point(120, 149);
            this.labelBubbleSortTime.Name = "labelBubbleSortTime";
            this.labelBubbleSortTime.Size = new System.Drawing.Size(63, 13);
            this.labelBubbleSortTime.TabIndex = 6;
            this.labelBubbleSortTime.Text = "milliseconds";
            // 
            // labelSelectionSortTime
            // 
            this.labelSelectionSortTime.AutoSize = true;
            this.labelSelectionSortTime.Location = new System.Drawing.Point(274, 149);
            this.labelSelectionSortTime.Name = "labelSelectionSortTime";
            this.labelSelectionSortTime.Size = new System.Drawing.Size(63, 13);
            this.labelSelectionSortTime.TabIndex = 7;
            this.labelSelectionSortTime.Text = "milliseconds";
            // 
            // labelQuickSortTime
            // 
            this.labelQuickSortTime.AutoSize = true;
            this.labelQuickSortTime.Location = new System.Drawing.Point(426, 149);
            this.labelQuickSortTime.Name = "labelQuickSortTime";
            this.labelQuickSortTime.Size = new System.Drawing.Size(63, 13);
            this.labelQuickSortTime.TabIndex = 8;
            this.labelQuickSortTime.Text = "milliseconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bubble Sort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selection Sort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quick Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 223);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelQuickSortTime);
            this.Controls.Add(this.labelSelectionSortTime);
            this.Controls.Add(this.labelBubbleSortTime);
            this.Controls.Add(this.panelQuickSortVisualizer);
            this.Controls.Add(this.panelSelectionSortVisualizer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelBubbleSortVisualizer);
            this.Controls.Add(this.buttonGenerateArray);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mahan Moulaei - Simple Sorting Histogram Visualizor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateArray;
        private System.Windows.Forms.Panel panelBubbleSortVisualizer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSelectionSortVisualizer;
        private System.Windows.Forms.Panel panelQuickSortVisualizer;
        private System.Windows.Forms.Label labelBubbleSortTime;
        private System.Windows.Forms.Label labelSelectionSortTime;
        private System.Windows.Forms.Label labelQuickSortTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

