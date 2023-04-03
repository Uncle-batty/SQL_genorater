namespace Sql_code_genorater
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Gb_Promptds = new System.Windows.Forms.GroupBox();
            this.Gb_insert = new System.Windows.Forms.GroupBox();
            this.btn_Genorate_Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_con = new System.Windows.Forms.TextBox();
            this.txt_conclo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.txt_ColumName = new System.Windows.Forms.TextBox();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.btn_gen_insert = new System.Windows.Forms.Button();
            this.Gb_Promptds.SuspendLayout();
            this.Gb_insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_insert.Location = new System.Drawing.Point(65, 75);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(106, 46);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Insert ";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create table";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(65, 271);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(106, 46);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(151, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sql Code genorater";
            // 
            // Gb_Promptds
            // 
            this.Gb_Promptds.Controls.Add(this.btn_Genorate_Update);
            this.Gb_Promptds.Controls.Add(this.label6);
            this.Gb_Promptds.Controls.Add(this.txt_con);
            this.Gb_Promptds.Controls.Add(this.txt_conclo);
            this.Gb_Promptds.Controls.Add(this.label5);
            this.Gb_Promptds.Controls.Add(this.label4);
            this.Gb_Promptds.Controls.Add(this.label3);
            this.Gb_Promptds.Controls.Add(this.label2);
            this.Gb_Promptds.Controls.Add(this.txt_Value);
            this.Gb_Promptds.Controls.Add(this.txt_ColumName);
            this.Gb_Promptds.Controls.Add(this.txt_TableName);
            this.Gb_Promptds.Location = new System.Drawing.Point(193, 59);
            this.Gb_Promptds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gb_Promptds.Name = "Gb_Promptds";
            this.Gb_Promptds.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gb_Promptds.Size = new System.Drawing.Size(315, 318);
            this.Gb_Promptds.TabIndex = 5;
            this.Gb_Promptds.TabStop = false;
            this.Gb_Promptds.Text = "Gb_Promptds";
            this.Gb_Promptds.Visible = false;
            // 
            // Gb_insert
            // 
            this.Gb_insert.Controls.Add(this.btn_gen_insert);
            this.Gb_insert.Location = new System.Drawing.Point(197, 55);
            this.Gb_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gb_insert.Name = "Gb_insert";
            this.Gb_insert.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gb_insert.Size = new System.Drawing.Size(315, 318);
            this.Gb_insert.TabIndex = 6;
            this.Gb_insert.TabStop = false;
            this.Gb_insert.Text = "insert";
            this.Gb_insert.Visible = false;
            // 
            // btn_Genorate_Update
            // 
            this.btn_Genorate_Update.Location = new System.Drawing.Point(69, 238);
            this.btn_Genorate_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Genorate_Update.Name = "btn_Genorate_Update";
            this.btn_Genorate_Update.Size = new System.Drawing.Size(175, 43);
            this.btn_Genorate_Update.TabIndex = 10;
            this.btn_Genorate_Update.Text = "Genorate";
            this.btn_Genorate_Update.UseVisualStyleBackColor = true;
            this.btn_Genorate_Update.Click += new System.EventHandler(this.btn_Genorate_Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(19, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Condition ";
            // 
            // txt_con
            // 
            this.txt_con.Location = new System.Drawing.Point(134, 176);
            this.txt_con.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_con.Name = "txt_con";
            this.txt_con.Size = new System.Drawing.Size(136, 20);
            this.txt_con.TabIndex = 8;
            // 
            // txt_conclo
            // 
            this.txt_conclo.Location = new System.Drawing.Point(134, 141);
            this.txt_conclo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_conclo.Name = "txt_conclo";
            this.txt_conclo.Size = new System.Drawing.Size(136, 20);
            this.txt_conclo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Colum name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Condition Colum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table name";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(134, 110);
            this.txt_Value.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(136, 20);
            this.txt_Value.TabIndex = 2;
            // 
            // txt_ColumName
            // 
            this.txt_ColumName.Location = new System.Drawing.Point(134, 76);
            this.txt_ColumName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ColumName.Name = "txt_ColumName";
            this.txt_ColumName.Size = new System.Drawing.Size(136, 20);
            this.txt_ColumName.TabIndex = 1;
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(134, 43);
            this.txt_TableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(136, 20);
            this.txt_TableName.TabIndex = 0;
            // 
            // btn_gen_insert
            // 
            this.btn_gen_insert.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_gen_insert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_gen_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gen_insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gen_insert.Location = new System.Drawing.Point(96, 236);
            this.btn_gen_insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gen_insert.Name = "btn_gen_insert";
            this.btn_gen_insert.Size = new System.Drawing.Size(106, 46);
            this.btn_gen_insert.TabIndex = 6;
            this.btn_gen_insert.Text = "Genorate";
            this.btn_gen_insert.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.Gb_insert);
            this.Controls.Add(this.Gb_Promptds);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gb_Promptds.ResumeLayout(false);
            this.Gb_Promptds.PerformLayout();
            this.Gb_insert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gb_Promptds;
        private System.Windows.Forms.Button btn_Genorate_Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_con;
        private System.Windows.Forms.TextBox txt_conclo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.TextBox txt_ColumName;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.GroupBox Gb_insert;
        private System.Windows.Forms.Button btn_gen_insert;
    }
}

