namespace E_F
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.cd_author = new System.Windows.Forms.ComboBox();
            this.cd_category = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITLE";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "TITLE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "DSCRIPTION :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "CATEGORY :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "AUTHOR :";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Location = new System.Drawing.Point(42, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 27);
            this.title.TabIndex = 4;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Location = new System.Drawing.Point(42, 104);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(326, 60);
            this.description.TabIndex = 7;
            this.description.Text = "";
            // 
            // cd_author
            // 
            this.cd_author.FormattingEnabled = true;
            this.cd_author.Location = new System.Drawing.Point(42, 200);
            this.cd_author.Name = "cd_author";
            this.cd_author.Size = new System.Drawing.Size(326, 36);
            this.cd_author.TabIndex = 8;
            // 
            // cd_category
            // 
            this.cd_category.FormattingEnabled = true;
            this.cd_category.Location = new System.Drawing.Point(42, 270);
            this.cd_category.Name = "cd_category";
            this.cd_category.Size = new System.Drawing.Size(326, 36);
            this.cd_category.TabIndex = 9;
            // 
            // details
            // 
            this.details.BackgroundColor = System.Drawing.SystemColors.Info;
            this.details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details.GridColor = System.Drawing.Color.AntiqueWhite;
            this.details.Location = new System.Drawing.Point(-4, 412);
            this.details.Name = "details";
            this.details.RowHeadersWidth = 51;
            this.details.RowTemplate.Height = 29;
            this.details.Size = new System.Drawing.Size(544, 191);
            this.details.TabIndex = 10;
            this.details.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.details_RowHeaderMouseDoubleClick);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_add.Location = new System.Drawing.Point(433, 51);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(94, 50);
            this.bt_add.TabIndex = 11;
            this.bt_add.Text = "ADD";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_edit.Location = new System.Drawing.Point(433, 117);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(94, 47);
            this.bt_edit.TabIndex = 12;
            this.bt_edit.Text = "EDIT";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click_1);
            // 
            // bt_del
            // 
            this.bt_del.BackColor = System.Drawing.Color.LightCoral;
            this.bt_del.Location = new System.Drawing.Point(433, 183);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(94, 53);
            this.bt_del.TabIndex = 13;
            this.bt_del.Text = "DELETE";
            this.bt_del.UseVisualStyleBackColor = false;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(539, 601);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.details);
            this.Controls.Add(this.cd_category);
            this.Controls.Add(this.cd_author);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "CATEGORY :";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox title;
        private RichTextBox description;
        private ComboBox cd_author;
        private ComboBox cd_category;
        private DataGridView details;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_del;
    }
}