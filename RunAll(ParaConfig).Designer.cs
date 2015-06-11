namespace SisulaGUI
{
    partial class Form2
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
            this.Finish = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.System = new System.Windows.Forms.TextBox();
            this.Source = new System.Windows.Forms.TextBox();
            this.TargetDatabase = new System.Windows.Forms.TextBox();
            this.SourceDatabase = new System.Windows.Forms.TextBox();
            this.MetaDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            //this.Help = new System.Windows.Forms.Button();
            this.InfoPara = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(197, 285);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 23);
            this.Finish.TabIndex = 0;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 285);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "System:";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TargetDatabase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SourceDatabase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MetaDatabase:";
            // 
            // System
            // 
            this.System.Location = new System.Drawing.Point(17, 50);
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(117, 20);
            this.System.TabIndex = 7;
            // 
            // Source
            // 
            this.Source.Location = new System.Drawing.Point(17, 94);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(117, 20);
            this.Source.TabIndex = 8;
            // 
            // TargetDatabase
            // 
            this.TargetDatabase.Location = new System.Drawing.Point(17, 139);
            this.TargetDatabase.Name = "TargetDatabase";
            this.TargetDatabase.Size = new System.Drawing.Size(117, 20);
            this.TargetDatabase.TabIndex = 9;
            // 
            // SourceDatabase
            // 
            this.SourceDatabase.Location = new System.Drawing.Point(17, 185);
            this.SourceDatabase.Name = "SourceDatabase";
            this.SourceDatabase.Size = new System.Drawing.Size(117, 20);
            this.SourceDatabase.TabIndex = 10;
            // 
            // MetaDatabase
            // 
            this.MetaDatabase.Location = new System.Drawing.Point(17, 229);
            this.MetaDatabase.Name = "MetaDatabase";
            this.MetaDatabase.Size = new System.Drawing.Size(117, 20);
            this.MetaDatabase.TabIndex = 11;
            //
            // Icon
            //
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.A_logo));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Font = new System.Drawing.Font(this.Font,global::System.Drawing.FontStyle.Bold);
            this.label6.Text = "Sisula parameters";
            // 
            // Help
            // 
            /*this.Help.Location = new System.Drawing.Point(105, 285);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 13;
            this.Help.Text = "Help!";
            this.Help.UseVisualStyleBackColor = true;
            */
            // 
            // InfoPara
            // 
            
            this.InfoPara.Location = new System.Drawing.Point(154, 50);
            this.InfoPara.Name = "InfoPara";
            this.InfoPara.ReadOnly = true;
            this.InfoPara.Size = new System.Drawing.Size(118, 175);
            this.InfoPara.TabIndex = 14;
            this.InfoPara.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
            this.InfoPara.Text = "Here you can configurate the parameters being sent in the \"RunAll\" batch file. Fo" +
    "r further information, please advance to the help section of this window.";

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(277, 321);
            this.Controls.Add(this.InfoPara);
            //this.Controls.Add(this.Help);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MetaDatabase);
            this.Controls.Add(this.SourceDatabase);
            this.Controls.Add(this.TargetDatabase);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.System);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Finish);
            this.Name = "Form2";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox System;
        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox TargetDatabase;
        private System.Windows.Forms.TextBox SourceDatabase;
        private System.Windows.Forms.TextBox MetaDatabase;
        private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Button Help;
        private System.Windows.Forms.RichTextBox InfoPara;
    }
}