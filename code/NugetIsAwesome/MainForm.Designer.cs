namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.lvRules = new System.Windows.Forms.ListView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbCalc = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblRuleCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules";
            // 
            // lvRules
            // 
            this.lvRules.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lvRules.Location = new System.Drawing.Point(12, 130);
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(778, 343);
            this.lvRules.TabIndex = 1;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.List;
            this.lvRules.DoubleClick += new System.EventHandler(this.lvRules_DoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExport.Location = new System.Drawing.Point(12, 479);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(156, 47);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Rules";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.Location = new System.Drawing.Point(174, 479);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 47);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Add New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.unicorn;
            this.pictureBox1.Location = new System.Drawing.Point(606, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Christian_Rainbow;
            this.pictureBox2.Location = new System.Drawing.Point(136, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tbCalc
            // 
            this.tbCalc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbCalc.Location = new System.Drawing.Point(346, 487);
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.Size = new System.Drawing.Size(330, 38);
            this.tbCalc.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCalc.Location = new System.Drawing.Point(682, 484);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 42);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblRuleCount
            // 
            this.lblRuleCount.AutoSize = true;
            this.lblRuleCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRuleCount.Location = new System.Drawing.Point(700, 432);
            this.lblRuleCount.Name = "lblRuleCount";
            this.lblRuleCount.Size = new System.Drawing.Size(86, 32);
            this.lblRuleCount.TabIndex = 8;
            this.lblRuleCount.Text = "0 rules";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 552);
            this.Controls.Add(this.lblRuleCount);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbCalc);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lvRules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Awesome Rule Engine!!!!!!1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ContextMenuStrip menuExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbCalc;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblRuleCount;
    }
}

