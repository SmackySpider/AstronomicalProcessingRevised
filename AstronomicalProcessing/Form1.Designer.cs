namespace AstronomicalProcessing
{
    partial class frmAstronomicalProcessing
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
            this.components = new System.ComponentModel.Container();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBinSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnRandomise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeqSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvg = new System.Windows.Forms.Button();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMidExtr = new System.Windows.Forms.Button();
            this.txtMidExtr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRange = new System.Windows.Forms.Button();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(12, 25);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(148, 407);
            this.lstArray.TabIndex = 0;
            this.toolTip.SetToolTip(this.lstArray, "This is the list of data.");
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(12, 9);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(69, 13);
            this.lblArray.TabIndex = 1;
            this.lblArray.Text = "Array Output:";
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(272, 25);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Array";
            this.toolTip.SetToolTip(this.btnSort, "Sorts the array using a bubble sort algorithm.");
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BubbleSort);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(163, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtSearch, "Enter a value here then press one of the search\r\nbuttons below to perform a searc" +
        "h.");
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyCheck);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck);
            // 
            // btnBinSearch
            // 
            this.btnBinSearch.Enabled = false;
            this.btnBinSearch.Location = new System.Drawing.Point(163, 119);
            this.btnBinSearch.Name = "btnBinSearch";
            this.btnBinSearch.Size = new System.Drawing.Size(100, 23);
            this.btnBinSearch.TabIndex = 5;
            this.btnBinSearch.Text = "Binary";
            this.toolTip.SetToolTip(this.btnBinSearch, "Perform the search using a binary search method.\r\nThis method requires the list t" +
        "o be sorted.");
            this.btnBinSearch.UseVisualStyleBackColor = true;
            this.btnBinSearch.Click += new System.EventHandler(this.BinarySearch);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(163, 262);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Data";
            this.toolTip.SetToolTip(this.btnEdit, "Select an item from the list, enter the number\r\nto replace it with in the field a" +
        "bove.");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.EditData);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(163, 235);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtEdit, "Enter a value here");
            this.txtEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyCheck);
            this.txtEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerCheck);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(163, 218);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(28, 13);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "Edit:";
            // 
            // btnRandomise
            // 
            this.btnRandomise.Location = new System.Drawing.Point(166, 25);
            this.btnRandomise.Name = "btnRandomise";
            this.btnRandomise.Size = new System.Drawing.Size(100, 23);
            this.btnRandomise.TabIndex = 9;
            this.btnRandomise.Text = "Randomise";
            this.toolTip.SetToolTip(this.btnRandomise, "Fill the array with a random set of numbers,\r\nin an unsorted manner.");
            this.btnRandomise.UseVisualStyleBackColor = true;
            this.btnRandomise.Click += new System.EventHandler(this.RandomiseArray);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // btnSeqSearch
            // 
            this.btnSeqSearch.Enabled = false;
            this.btnSeqSearch.Location = new System.Drawing.Point(163, 148);
            this.btnSeqSearch.Name = "btnSeqSearch";
            this.btnSeqSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSeqSearch.TabIndex = 11;
            this.btnSeqSearch.Text = "Sequential";
            this.toolTip.SetToolTip(this.btnSeqSearch, "Perform the search using a sequential search method.\r\nThis search does not requir" +
        "e the list to be sorted.");
            this.btnSeqSearch.UseVisualStyleBackColor = true;
            this.btnSeqSearch.Click += new System.EventHandler(this.SequentialSearch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // btnAvg
            // 
            this.btnAvg.Enabled = false;
            this.btnAvg.Location = new System.Drawing.Point(166, 324);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(100, 23);
            this.btnAvg.TabIndex = 14;
            this.btnAvg.Text = "Average";
            this.toolTip.SetToolTip(this.btnAvg, "Get the average value from the list.");
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.Average);
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(272, 324);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtAvg, "Output for the button on the left. Read only.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // btnMidExtr
            // 
            this.btnMidExtr.Enabled = false;
            this.btnMidExtr.Location = new System.Drawing.Point(166, 351);
            this.btnMidExtr.Name = "btnMidExtr";
            this.btnMidExtr.Size = new System.Drawing.Size(100, 23);
            this.btnMidExtr.TabIndex = 17;
            this.btnMidExtr.Text = "Mid Extreme";
            this.toolTip.SetToolTip(this.btnMidExtr, "Calculate the mid-extreme of the set.\r\nThis is the average of the smallest \r\nand " +
        "largest numbers.");
            this.btnMidExtr.UseVisualStyleBackColor = true;
            this.btnMidExtr.Click += new System.EventHandler(this.MidExtreme);
            // 
            // txtMidExtr
            // 
            this.txtMidExtr.Location = new System.Drawing.Point(272, 353);
            this.txtMidExtr.Name = "txtMidExtr";
            this.txtMidExtr.ReadOnly = true;
            this.txtMidExtr.Size = new System.Drawing.Size(100, 20);
            this.txtMidExtr.TabIndex = 16;
            this.toolTip.SetToolTip(this.txtMidExtr, "Output for the button on the left. Read only.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 21;
            // 
            // btnMode
            // 
            this.btnMode.Enabled = false;
            this.btnMode.Location = new System.Drawing.Point(166, 380);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(100, 23);
            this.btnMode.TabIndex = 20;
            this.btnMode.Text = "Mode";
            this.toolTip.SetToolTip(this.btnMode, "Calculate the mode, the number that \r\nappears most frequently. Unimodal.");
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.Mode);
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(272, 382);
            this.txtMode.Name = "txtMode";
            this.txtMode.ReadOnly = true;
            this.txtMode.Size = new System.Drawing.Size(100, 20);
            this.txtMode.TabIndex = 19;
            this.toolTip.SetToolTip(this.txtMode, "Output for the button on the left. Read only.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 24;
            // 
            // btnRange
            // 
            this.btnRange.Enabled = false;
            this.btnRange.Location = new System.Drawing.Point(166, 409);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(100, 23);
            this.btnRange.TabIndex = 23;
            this.btnRange.Text = "Range";
            this.toolTip.SetToolTip(this.btnRange, "Calculate the difference between the \r\nsmallest and largest numbers.");
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.Range);
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(272, 411);
            this.txtRange.Name = "txtRange";
            this.txtRange.ReadOnly = true;
            this.txtRange.Size = new System.Drawing.Size(100, 20);
            this.txtRange.TabIndex = 22;
            this.toolTip.SetToolTip(this.txtRange, "Output for the button on the left. Read only.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(169, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 1);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmAstronomicalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMidExtr);
            this.Controls.Add(this.txtMidExtr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.btnSeqSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomise);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnBinSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.lstArray);
            this.Name = "frmAstronomicalProcessing";
            this.Text = "Astronomical Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBinSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnRandomise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeqSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMidExtr;
        private System.Windows.Forms.TextBox txtMidExtr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

