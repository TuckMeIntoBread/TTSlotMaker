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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMakerForm));
            this.cBoxRace = new System.Windows.Forms.ComboBox();
            this.numType = new System.Windows.Forms.NumericUpDown();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.gBoxRace = new System.Windows.Forms.GroupBox();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.gBoxSlot = new System.Windows.Forms.GroupBox();
            this.labelBread = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.txtSlot.TextChanged += new System.EventHandler(this.txtSlot_TextChanged);
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(32, 200);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(168, 25);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Modpack";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // SlotMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 266);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelBread);
            this.Controls.Add(this.gBoxSlot);
            this.Controls.Add(this.gBoxType);
            this.Controls.Add(this.gBoxRace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlotMakerForm";
            this.Text = "TT Slot Maker";
            this.Load += new System.EventHandler(this.SlotMakerForm_Load);
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
        private System.Windows.Forms.Button btnCreate;
    }
}