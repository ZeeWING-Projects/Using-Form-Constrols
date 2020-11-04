namespace Using_From_Controls
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSortingChoice = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblNumberOFEntries = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbMultiSimple = new System.Windows.Forms.RadioButton();
            this.rbMultiSelection = new System.Windows.Forms.RadioButton();
            this.rbSingleSelection = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(42, 66);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(489, 344);
            this.listBox.TabIndex = 0;
            this.listBox.DoubleClick += new System.EventHandler(this.selectedItem);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(604, 310);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(604, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSortingChoice
            // 
            this.cbSortingChoice.FormattingEnabled = true;
            this.cbSortingChoice.Items.AddRange(new object[] {
            "Show Name",
            "Show Name+Gender",
            "Show All"});
            this.cbSortingChoice.Location = new System.Drawing.Point(650, 39);
            this.cbSortingChoice.Name = "cbSortingChoice";
            this.cbSortingChoice.Size = new System.Drawing.Size(121, 21);
            this.cbSortingChoice.TabIndex = 5;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(569, 39);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Show";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblNumberOFEntries
            // 
            this.lblNumberOFEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOFEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOFEntries.Location = new System.Drawing.Point(587, 114);
            this.lblNumberOFEntries.Name = "lblNumberOFEntries";
            this.lblNumberOFEntries.Size = new System.Drawing.Size(168, 79);
            this.lblNumberOFEntries.TabIndex = 7;
            this.lblNumberOFEntries.Text = "0";
            this.lblNumberOFEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNone);
            this.panel2.Controls.Add(this.rbMultiSimple);
            this.panel2.Controls.Add(this.rbMultiSelection);
            this.panel2.Controls.Add(this.rbSingleSelection);
            this.panel2.Location = new System.Drawing.Point(42, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 44);
            this.panel2.TabIndex = 5;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(302, 14);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 3;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbMultiSimple
            // 
            this.rbMultiSimple.AutoSize = true;
            this.rbMultiSimple.Location = new System.Drawing.Point(218, 14);
            this.rbMultiSimple.Name = "rbMultiSimple";
            this.rbMultiSimple.Size = new System.Drawing.Size(78, 17);
            this.rbMultiSimple.TabIndex = 2;
            this.rbMultiSimple.Text = "MultiSimple";
            this.rbMultiSimple.UseVisualStyleBackColor = true;
            this.rbMultiSimple.CheckedChanged += new System.EventHandler(this.rbMultiSimple_CheckedChanged);
            // 
            // rbMultiSelection
            // 
            this.rbMultiSelection.AutoSize = true;
            this.rbMultiSelection.Location = new System.Drawing.Point(110, 14);
            this.rbMultiSelection.Name = "rbMultiSelection";
            this.rbMultiSelection.Size = new System.Drawing.Size(89, 17);
            this.rbMultiSelection.TabIndex = 1;
            this.rbMultiSelection.Text = "MuliExtended";
            this.rbMultiSelection.UseVisualStyleBackColor = true;
            this.rbMultiSelection.CheckedChanged += new System.EventHandler(this.rbMultiSelection_CheckedChanged);
            // 
            // rbSingleSelection
            // 
            this.rbSingleSelection.AutoSize = true;
            this.rbSingleSelection.Checked = true;
            this.rbSingleSelection.Location = new System.Drawing.Point(3, 14);
            this.rbSingleSelection.Name = "rbSingleSelection";
            this.rbSingleSelection.Size = new System.Drawing.Size(101, 17);
            this.rbSingleSelection.TabIndex = 0;
            this.rbSingleSelection.TabStop = true;
            this.rbSingleSelection.Text = "Single Selection";
            this.rbSingleSelection.UseVisualStyleBackColor = true;
            this.rbSingleSelection.CheckedChanged += new System.EventHandler(this.rbSingleSelection_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNumberOFEntries);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbSortingChoice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbSortingChoice;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblNumberOFEntries;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMultiSelection;
        private System.Windows.Forms.RadioButton rbSingleSelection;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbMultiSimple;
    }
}

