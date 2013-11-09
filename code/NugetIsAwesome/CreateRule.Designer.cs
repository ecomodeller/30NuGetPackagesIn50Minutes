namespace WindowsFormsApplication1
{
    partial class CreateRule
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateSchedule = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboActions = new System.Windows.Forms.ComboBox();
            this.tbActionValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbName.Location = new System.Drawing.Point(144, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(412, 39);
            this.tbName.TabIndex = 1;
            // 
            // tbRule
            // 
            this.tbRule.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbRule.Location = new System.Drawing.Point(144, 80);
            this.tbRule.Multiline = true;
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(412, 119);
            this.tbRule.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rule:";
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(144, 217);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(412, 39);
            this.comboLanguage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Language:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Schedule:";
            // 
            // dateSchedule
            // 
            this.dateSchedule.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateSchedule.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSchedule.Location = new System.Drawing.Point(144, 274);
            this.dateSchedule.Name = "dateSchedule";
            this.dateSchedule.Size = new System.Drawing.Size(412, 39);
            this.dateSchedule.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(248, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExport.Location = new System.Drawing.Point(359, 341);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 42);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnClone
            // 
            this.btnClone.AutoSize = true;
            this.btnClone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClone.Location = new System.Drawing.Point(598, 341);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(87, 42);
            this.btnClone.TabIndex = 10;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRun.Location = new System.Drawing.Point(487, 341);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 42);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(577, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Action:";
            // 
            // comboActions
            // 
            this.comboActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboActions.FormattingEnabled = true;
            this.comboActions.Location = new System.Drawing.Point(671, 18);
            this.comboActions.Name = "comboActions";
            this.comboActions.Size = new System.Drawing.Size(201, 39);
            this.comboActions.TabIndex = 13;
            // 
            // tbActionValue
            // 
            this.tbActionValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbActionValue.Location = new System.Drawing.Point(671, 83);
            this.tbActionValue.Multiline = true;
            this.tbActionValue.Name = "tbActionValue";
            this.tbActionValue.Size = new System.Drawing.Size(201, 188);
            this.tbActionValue.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(581, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 64);
            this.label6.TabIndex = 14;
            this.label6.Text = "Action \r\nValue:";
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Baby_Unicorn_Coloring_Pages4;
            this.pictureBox1.Location = new System.Drawing.Point(763, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnLol
            // 
            this.btnLol.AutoSize = true;
            this.btnLol.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLol.Location = new System.Drawing.Point(785, 277);
            this.btnLol.Name = "btnLol";
            this.btnLol.Size = new System.Drawing.Size(87, 42);
            this.btnLol.TabIndex = 17;
            this.btnLol.Text = "LOL";
            this.btnLol.UseVisualStyleBackColor = true;
            this.btnLol.Click += new System.EventHandler(this.btnLol_Click);
            // 
            // CreateRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 408);
            this.Controls.Add(this.btnLol);
            this.Controls.Add(this.tbActionValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboActions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.tbRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rule";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateSchedule;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboActions;
        private System.Windows.Forms.TextBox tbActionValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip menuExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLol;
    }
}