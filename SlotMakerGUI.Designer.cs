namespace TTSlotMaker
{
    partial class SlotMakerForm
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
            this.cBoxRace = new System.Windows.Forms.ComboBox();
            this.numType = new System.Windows.Forms.NumericUpDown();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.gBoxRace = new System.Windows.Forms.GroupBox();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.gBoxSlot = new System.Windows.Forms.GroupBox();
            this.labelBread = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).BeginInit();
            this.gBoxRace.SuspendLayout();
            this.gBoxType.SuspendLayout();
            this.gBoxSlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxRace
            // 
            this.cBoxRace.FormattingEnabled = true;
            this.cBoxRace.Location = new System.Drawing.Point(6, 22);
            this.cBoxRace.Name = "cBoxRace";
            this.cBoxRace.Size = new System.Drawing.Size(195, 23);
            this.cBoxRace.TabIndex = 0;
            // 
            // numType
            // 
            this.numType.Location = new System.Drawing.Point(6, 22);
            this.numType.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numType.Name = "numType";
            this.numType.Size = new System.Drawing.Size(195, 23);
            this.numType.TabIndex = 1;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(6, 22);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(195, 23);
            this.txtSlot.TabIndex = 2;
            // 
            // gBoxRace
            // 
            this.gBoxRace.Controls.Add(this.cBoxRace);
            this.gBoxRace.Location = new System.Drawing.Point(12, 12);
            this.gBoxRace.Name = "gBoxRace";
            this.gBoxRace.Size = new System.Drawing.Size(207, 56);
            this.gBoxRace.TabIndex = 3;
            this.gBoxRace.TabStop = false;
            this.gBoxRace.Text = "Race";
            // 
            // gBoxType
            // 
            this.gBoxType.Controls.Add(this.numType);
            this.gBoxType.Location = new System.Drawing.Point(12, 74);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Size = new System.Drawing.Size(207, 56);
            this.gBoxType.TabIndex = 4;
            this.gBoxType.TabStop = false;
            this.gBoxType.Text = "Sub-Type";
            // 
            // gBoxSlot
            // 
            this.gBoxSlot.Controls.Add(this.txtSlot);
            this.gBoxSlot.Location = new System.Drawing.Point(12, 136);
            this.gBoxSlot.Name = "gBoxSlot";
            this.gBoxSlot.Size = new System.Drawing.Size(207, 56);
            this.gBoxSlot.TabIndex = 5;
            this.gBoxSlot.TabStop = false;
            this.gBoxSlot.Text = "Slot Name";
            // 
            // labelBread
            // 
            this.labelBread.AutoSize = true;
            this.labelBread.Location = new System.Drawing.Point(140, 242);
            this.labelBread.Name = "labelBread";
            this.labelBread.Size = new System.Drawing.Size(86, 15);
            this.labelBread.TabIndex = 6;
            this.labelBread.Text = "Made by Bread";
            // 
            // SlotMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 266);
            this.Controls.Add(this.labelBread);
            this.Controls.Add(this.gBoxSlot);
            this.Controls.Add(this.gBoxType);
            this.Controls.Add(this.gBoxRace);
            this.Name = "SlotMakerForm";
            this.Text = "TT Slot Maker";
            ((System.ComponentModel.ISupportInitialize)(this.numType)).EndInit();
            this.gBoxRace.ResumeLayout(false);
            this.gBoxType.ResumeLayout(false);
            this.gBoxSlot.ResumeLayout(false);
            this.gBoxSlot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxRace;
        private System.Windows.Forms.NumericUpDown numType;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.GroupBox gBoxRace;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.GroupBox gBoxSlot;
        private System.Windows.Forms.Label labelBread;
    }
}