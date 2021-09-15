namespace AsyncSorts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertSortListBox = new System.Windows.Forms.ListBox();
            this.bubbleSortListBox = new System.Windows.Forms.ListBox();
            this.mergeSortListBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertSortListBox
            // 
            this.insertSortListBox.FormattingEnabled = true;
            this.insertSortListBox.Location = new System.Drawing.Point(198, 32);
            this.insertSortListBox.Name = "insertSortListBox";
            this.insertSortListBox.Size = new System.Drawing.Size(116, 160);
            this.insertSortListBox.TabIndex = 0;
            // 
            // bubbleSortListBox
            // 
            this.bubbleSortListBox.FormattingEnabled = true;
            this.bubbleSortListBox.Location = new System.Drawing.Point(12, 32);
            this.bubbleSortListBox.Name = "bubbleSortListBox";
            this.bubbleSortListBox.Size = new System.Drawing.Size(116, 160);
            this.bubbleSortListBox.TabIndex = 1;
            // 
            // mergeSortListBox
            // 
            this.mergeSortListBox.FormattingEnabled = true;
            this.mergeSortListBox.Location = new System.Drawing.Point(405, 32);
            this.mergeSortListBox.Name = "mergeSortListBox";
            this.mergeSortListBox.Size = new System.Drawing.Size(116, 160);
            this.mergeSortListBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(431, 224);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bubble Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert Sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Merge Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mergeSortListBox);
            this.Controls.Add(this.bubbleSortListBox);
            this.Controls.Add(this.insertSortListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox insertSortListBox;
        private System.Windows.Forms.ListBox bubbleSortListBox;
        private System.Windows.Forms.ListBox mergeSortListBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

