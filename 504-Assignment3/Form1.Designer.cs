//***************************************************************************
//
//  Troy DeClerck       - Z1877438
//  Brandon Anzalone    - Z1884778
//  CSCI 473/504        Assignment 3
//
//  We certify that this is our own work and where appropriate an extension
//  of the starter code provided for the assignment
//***************************************************************************
namespace Assignment3
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
            this.Query_Box = new System.Windows.Forms.RichTextBox();
            this.Query_Label = new System.Windows.Forms.Label();
            this.All_Class_Label = new System.Windows.Forms.Label();
            this.Class_Label = new System.Windows.Forms.Label();
            this.Server_Label = new System.Windows.Forms.Label();
            this.Class_Combobox = new System.Windows.Forms.ComboBox();
            this.Server_Combobox1 = new System.Windows.Forms.ComboBox();
            this.Show_Results_Button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Server_Combobox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Results_Button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_Results_Button3 = new System.Windows.Forms.Button();
            this.Server_Box3 = new System.Windows.Forms.ComboBox();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Min_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Max_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Show_Results4 = new System.Windows.Forms.Button();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Show_Results5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PlayerNotInRoles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DamageOpt = new System.Windows.Forms.RadioButton();
            this.HealerOpt = new System.Windows.Forms.RadioButton();
            this.TankOpt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Min_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_UpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Query_Box
            // 
            this.Query_Box.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query_Box.Location = new System.Drawing.Point(603, 33);
            this.Query_Box.Name = "Query_Box";
            this.Query_Box.Size = new System.Drawing.Size(677, 546);
            this.Query_Box.TabIndex = 0;
            this.Query_Box.Text = "";
            // 
            // Query_Label
            // 
            this.Query_Label.AutoSize = true;
            this.Query_Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Query_Label.Location = new System.Drawing.Point(600, 12);
            this.Query_Label.Name = "Query_Label";
            this.Query_Label.Size = new System.Drawing.Size(58, 18);
            this.Query_Label.TabIndex = 1;
            this.Query_Label.Text = "Query";
            // 
            // All_Class_Label
            // 
            this.All_Class_Label.AutoSize = true;
            this.All_Class_Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Class_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.All_Class_Label.Location = new System.Drawing.Point(12, 12);
            this.All_Class_Label.Name = "All_Class_Label";
            this.All_Class_Label.Size = new System.Drawing.Size(358, 18);
            this.All_Class_Label.TabIndex = 2;
            this.All_Class_Label.Text = "All Class Type from a Single Server";
            // 
            // Class_Label
            // 
            this.Class_Label.AutoSize = true;
            this.Class_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Class_Label.Location = new System.Drawing.Point(12, 36);
            this.Class_Label.Name = "Class_Label";
            this.Class_Label.Size = new System.Drawing.Size(32, 13);
            this.Class_Label.TabIndex = 3;
            this.Class_Label.Text = "Class";
            // 
            // Server_Label
            // 
            this.Server_Label.AutoSize = true;
            this.Server_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Server_Label.Location = new System.Drawing.Point(141, 36);
            this.Server_Label.Name = "Server_Label";
            this.Server_Label.Size = new System.Drawing.Size(38, 13);
            this.Server_Label.TabIndex = 4;
            this.Server_Label.Text = "Server";
            // 
            // Class_Combobox
            // 
            this.Class_Combobox.FormattingEnabled = true;
            this.Class_Combobox.Location = new System.Drawing.Point(15, 52);
            this.Class_Combobox.Name = "Class_Combobox";
            this.Class_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Class_Combobox.TabIndex = 5;
            // 
            // Server_Combobox1
            // 
            this.Server_Combobox1.FormattingEnabled = true;
            this.Server_Combobox1.Location = new System.Drawing.Point(142, 52);
            this.Server_Combobox1.Name = "Server_Combobox1";
            this.Server_Combobox1.Size = new System.Drawing.Size(121, 21);
            this.Server_Combobox1.TabIndex = 6;
            // 
            // Show_Results_Button1
            // 
            this.Show_Results_Button1.Location = new System.Drawing.Point(288, 52);
            this.Show_Results_Button1.Name = "Show_Results_Button1";
            this.Show_Results_Button1.Size = new System.Drawing.Size(91, 23);
            this.Show_Results_Button1.TabIndex = 7;
            this.Show_Results_Button1.Text = "Show Results";
            this.Show_Results_Button1.UseVisualStyleBackColor = true;
            this.Show_Results_Button1.Click += new System.EventHandler(this.SearchAllClassTypes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Percentage of Each Race From a Single Server";
            // 
            // Server_Combobox2
            // 
            this.Server_Combobox2.FormattingEnabled = true;
            this.Server_Combobox2.Location = new System.Drawing.Point(144, 133);
            this.Server_Combobox2.Name = "Server_Combobox2";
            this.Server_Combobox2.Size = new System.Drawing.Size(121, 21);
            this.Server_Combobox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(143, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server";
            // 
            // Show_Results_Button2
            // 
            this.Show_Results_Button2.Location = new System.Drawing.Point(288, 131);
            this.Show_Results_Button2.Name = "Show_Results_Button2";
            this.Show_Results_Button2.Size = new System.Drawing.Size(91, 23);
            this.Show_Results_Button2.TabIndex = 11;
            this.Show_Results_Button2.Text = "Show Results";
            this.Show_Results_Button2.UseVisualStyleBackColor = true;
            this.Show_Results_Button2.Click += new System.EventHandler(this.SearchPercentage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "All role Types from a Single Server Within a Level Range";
            // 
            // Show_Results_Button3
            // 
            this.Show_Results_Button3.Location = new System.Drawing.Point(288, 243);
            this.Show_Results_Button3.Name = "Show_Results_Button3";
            this.Show_Results_Button3.Size = new System.Drawing.Size(91, 23);
            this.Show_Results_Button3.TabIndex = 17;
            this.Show_Results_Button3.Text = "Show Results";
            this.Show_Results_Button3.UseVisualStyleBackColor = true;
            this.Show_Results_Button3.Click += new System.EventHandler(this.SelectLevelRange);
            // 
            // Server_Box3
            // 
            this.Server_Box3.FormattingEnabled = true;
            this.Server_Box3.Location = new System.Drawing.Point(142, 243);
            this.Server_Box3.Name = "Server_Box3";
            this.Server_Box3.Size = new System.Drawing.Size(121, 21);
            this.Server_Box3.TabIndex = 16;
            // 
            // RoleBox
            // 
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(15, 243);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(121, 21);
            this.RoleBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(141, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role";
            // 
            // Min_UpDown
            // 
            this.Min_UpDown.Location = new System.Drawing.Point(15, 293);
            this.Min_UpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Min_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Min_UpDown.Name = "Min_UpDown";
            this.Min_UpDown.Size = new System.Drawing.Size(48, 20);
            this.Min_UpDown.TabIndex = 18;
            this.Min_UpDown.Tag = "1";
            this.Min_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Min_UpDown.Click += new System.EventHandler(this.Min_UpDown_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(142, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Max";
            // 
            // Max_UpDown
            // 
            this.Max_UpDown.Location = new System.Drawing.Point(142, 293);
            this.Max_UpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Max_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Max_UpDown.Name = "Max_UpDown";
            this.Max_UpDown.Size = new System.Drawing.Size(48, 20);
            this.Max_UpDown.TabIndex = 20;
            this.Max_UpDown.Tag = "1";
            this.Max_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Max_UpDown.Click += new System.EventHandler(this.Max_UpDown_Click);
            // 
            // Show_Results4
            // 
            this.Show_Results4.Location = new System.Drawing.Point(288, 409);
            this.Show_Results4.Name = "Show_Results4";
            this.Show_Results4.Size = new System.Drawing.Size(91, 23);
            this.Show_Results4.TabIndex = 25;
            this.Show_Results4.Text = "Show Results";
            this.Show_Results4.UseVisualStyleBackColor = true;
            this.Show_Results4.Click += new System.EventHandler(this.ShowAllGuildsSingleType);
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(15, 409);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Type_ComboBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "All Guilds of a Single Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(15, 592);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(458, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // Show_Results5
            // 
            this.Show_Results5.Location = new System.Drawing.Point(288, 624);
            this.Show_Results5.Name = "Show_Results5";
            this.Show_Results5.Size = new System.Drawing.Size(91, 23);
            this.Show_Results5.TabIndex = 27;
            this.Show_Results5.Text = "Show Results";
            this.Show_Results5.UseVisualStyleBackColor = true;
            this.Show_Results5.Click += new System.EventHandler(this.MaxLevelPercent);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // PlayerNotInRoles
            // 
            this.PlayerNotInRoles.Location = new System.Drawing.Point(288, 517);
            this.PlayerNotInRoles.Name = "PlayerNotInRoles";
            this.PlayerNotInRoles.Size = new System.Drawing.Size(91, 23);
            this.PlayerNotInRoles.TabIndex = 29;
            this.PlayerNotInRoles.Text = "Show Results";
            this.PlayerNotInRoles.UseVisualStyleBackColor = true;
            this.PlayerNotInRoles.Click += new System.EventHandler(this.PlayerNotInRoles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DamageOpt);
            this.groupBox1.Controls.Add(this.HealerOpt);
            this.groupBox1.Controls.Add(this.TankOpt);
            this.groupBox1.Location = new System.Drawing.Point(22, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 65);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // DamageOpt
            // 
            this.DamageOpt.AutoSize = true;
            this.DamageOpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DamageOpt.Location = new System.Drawing.Point(162, 26);
            this.DamageOpt.Name = "DamageOpt";
            this.DamageOpt.Size = new System.Drawing.Size(65, 17);
            this.DamageOpt.TabIndex = 2;
            this.DamageOpt.TabStop = true;
            this.DamageOpt.Text = "Damage";
            this.DamageOpt.UseVisualStyleBackColor = true;
            this.DamageOpt.CheckedChanged += new System.EventHandler(this.DamageOpt_CheckedChanged);
            // 
            // HealerOpt
            // 
            this.HealerOpt.AutoSize = true;
            this.HealerOpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HealerOpt.Location = new System.Drawing.Point(91, 26);
            this.HealerOpt.Name = "HealerOpt";
            this.HealerOpt.Size = new System.Drawing.Size(56, 17);
            this.HealerOpt.TabIndex = 1;
            this.HealerOpt.TabStop = true;
            this.HealerOpt.Text = "Healer";
            this.HealerOpt.UseVisualStyleBackColor = true;
            this.HealerOpt.CheckedChanged += new System.EventHandler(this.HealerOpt_CheckedChanged);
            // 
            // TankOpt
            // 
            this.TankOpt.AutoSize = true;
            this.TankOpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TankOpt.Location = new System.Drawing.Point(28, 26);
            this.TankOpt.Name = "TankOpt";
            this.TankOpt.Size = new System.Drawing.Size(50, 17);
            this.TankOpt.TabIndex = 0;
            this.TankOpt.TabStop = true;
            this.TankOpt.Text = "Tank";
            this.TankOpt.UseVisualStyleBackColor = true;
            this.TankOpt.CheckedChanged += new System.EventHandler(this.TankOpt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1292, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayerNotInRoles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Show_Results5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Show_Results4);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Max_UpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Min_UpDown);
            this.Controls.Add(this.Show_Results_Button3);
            this.Controls.Add(this.Server_Box3);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show_Results_Button2);
            this.Controls.Add(this.Server_Combobox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Results_Button1);
            this.Controls.Add(this.Server_Combobox1);
            this.Controls.Add(this.Class_Combobox);
            this.Controls.Add(this.Server_Label);
            this.Controls.Add(this.Class_Label);
            this.Controls.Add(this.All_Class_Label);
            this.Controls.Add(this.Query_Label);
            this.Controls.Add(this.Query_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Min_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_UpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Query_Box;
        private System.Windows.Forms.Label Query_Label;
        private System.Windows.Forms.Label All_Class_Label;
        private System.Windows.Forms.Label Class_Label;
        private System.Windows.Forms.Label Server_Label;
        private System.Windows.Forms.ComboBox Class_Combobox;
        private System.Windows.Forms.ComboBox Server_Combobox1;
        private System.Windows.Forms.Button Show_Results_Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Server_Combobox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Show_Results_Button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Show_Results_Button3;
        private System.Windows.Forms.ComboBox Server_Box3;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Min_UpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Max_UpDown;
        private System.Windows.Forms.Button Show_Results4;
        private System.Windows.Forms.ComboBox Type_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Show_Results5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button PlayerNotInRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DamageOpt;
        private System.Windows.Forms.RadioButton HealerOpt;
        private System.Windows.Forms.RadioButton TankOpt;
    }
}

