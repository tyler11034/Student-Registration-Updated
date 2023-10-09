namespace StudentRegistrationFinal
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            TBFee = new TextBox();
            TBCourse = new TextBox();
            TBSTudentName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Save = new Button();
            Clear = new Button();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(464, 25);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dataGridView1.Location = new Point(464, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 255);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "StudentName";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fee";
            Column4.Name = "Column4";
            // 
            // Edit
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.DefaultCellStyle = dataGridViewCellStyle5;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.DefaultCellStyle = dataGridViewCellStyle6;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TBFee);
            groupBox1.Controls.Add(TBCourse);
            groupBox1.Controls.Add(TBSTudentName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(44, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 171);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // TBFee
            // 
            TBFee.Location = new Point(155, 120);
            TBFee.Name = "TBFee";
            TBFee.Size = new Size(227, 25);
            TBFee.TabIndex = 5;
            TBFee.TextChanged += textBox3_TextChanged;
            // 
            // TBCourse
            // 
            TBCourse.Location = new Point(155, 80);
            TBCourse.Name = "TBCourse";
            TBCourse.Size = new Size(227, 25);
            TBCourse.TabIndex = 4;
            // 
            // TBSTudentName
            // 
            TBSTudentName.Location = new Point(155, 41);
            TBSTudentName.Name = "TBSTudentName";
            TBSTudentName.Size = new Size(227, 25);
            TBSTudentName.TabIndex = 3;
            TBSTudentName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 120);
            label4.Name = "label4";
            label4.Size = new Size(28, 17);
            label4.TabIndex = 2;
            label4.Text = "Fee";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 80);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 1;
            label3.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 41);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // Save
            // 
            Save.Location = new Point(44, 329);
            Save.Name = "Save";
            Save.Size = new Size(122, 64);
            Save.TabIndex = 4;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button2_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(199, 329);
            Clear.Name = "Clear";
            Clear.Size = new Size(104, 64);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += button3_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(325, 329);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(120, 64);
            Refresh.TabIndex = 6;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 636);
            Controls.Add(Refresh);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox TBFee;
        private TextBox TBCourse;
        private TextBox TBSTudentName;
        private Label label4;
        private Label label3;
        private Button Save;
        private Button Clear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button Refresh;
    }
}