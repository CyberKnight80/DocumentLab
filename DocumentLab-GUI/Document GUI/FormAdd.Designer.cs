namespace DocumentGUI
{

    partial class FormAdd
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBoxName = new TextBox();
            monthCalendarShelfTime = new MonthCalendar();
            textBoxSignedBy = new TextBox();
            comboBoxIsAccepted = new ComboBox();
            buttonAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBoxIsDone = new ComboBox();
            comboBoxPriority = new ComboBox();
            comboBoxChooseType = new ComboBox();
            richTextBoxContent = new RichTextBox();
            richTextBoxDesc = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.4713669F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.5286331F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 2, 1);
            tableLayoutPanel1.Controls.Add(monthCalendarShelfTime, 2, 4);
            tableLayoutPanel1.Controls.Add(textBoxSignedBy, 2, 6);
            tableLayoutPanel1.Controls.Add(comboBoxIsAccepted, 2, 8);
            tableLayoutPanel1.Controls.Add(buttonAdd, 3, 9);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 1, 7);
            tableLayoutPanel1.Controls.Add(label10, 1, 8);
            tableLayoutPanel1.Controls.Add(comboBoxIsDone, 2, 7);
            tableLayoutPanel1.Controls.Add(comboBoxPriority, 2, 3);
            tableLayoutPanel1.Controls.Add(comboBoxChooseType, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBoxContent, 2, 5);
            tableLayoutPanel1.Controls.Add(richTextBoxDesc, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Size = new Size(1140, 792);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(364, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 47);
            label1.TabIndex = 12;
            label1.Text = "Fields";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(610, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(414, 23);
            textBoxName.TabIndex = 0;
            // 
            // monthCalendarShelfTime
            // 
            monthCalendarShelfTime.Location = new Point(616, 245);
            monthCalendarShelfTime.Name = "monthCalendarShelfTime";
            monthCalendarShelfTime.TabIndex = 3;
            // 
            // textBoxSignedBy
            // 
            textBoxSignedBy.Dock = DockStyle.Fill;
            textBoxSignedBy.Location = new Point(610, 577);
            textBoxSignedBy.Name = "textBoxSignedBy";
            textBoxSignedBy.Size = new Size(414, 23);
            textBoxSignedBy.TabIndex = 5;
            // 
            // comboBoxIsAccepted
            // 
            comboBoxIsAccepted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxIsAccepted.FormattingEnabled = true;
            comboBoxIsAccepted.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxIsAccepted.Location = new Point(610, 680);
            comboBoxIsAccepted.Name = "comboBoxIsAccepted";
            comboBoxIsAccepted.Size = new Size(414, 23);
            comboBoxIsAccepted.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Location = new Point(1030, 732);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(107, 57);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(355, 47);
            label2.TabIndex = 11;
            label2.Text = "Choose Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(364, 47);
            label3.Name = "label3";
            label3.Size = new Size(240, 33);
            label3.TabIndex = 13;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(364, 80);
            label4.Name = "label4";
            label4.Size = new Size(240, 111);
            label4.TabIndex = 14;
            label4.Text = "Description";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(364, 191);
            label5.Name = "label5";
            label5.Size = new Size(240, 45);
            label5.TabIndex = 15;
            label5.Text = "Priority";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(364, 236);
            label6.Name = "label6";
            label6.Size = new Size(240, 195);
            label6.TabIndex = 16;
            label6.Text = "Shelf Time";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(364, 431);
            label7.Name = "label7";
            label7.Size = new Size(240, 143);
            label7.TabIndex = 17;
            label7.Text = "Content";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(364, 574);
            label8.Name = "label8";
            label8.Size = new Size(240, 51);
            label8.TabIndex = 18;
            label8.Text = "SighedBy";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(364, 625);
            label9.Name = "label9";
            label9.Size = new Size(240, 52);
            label9.TabIndex = 19;
            label9.Text = "IsDone";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(364, 677);
            label10.Name = "label10";
            label10.Size = new Size(240, 52);
            label10.TabIndex = 20;
            label10.Text = "IsAccepted";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxIsDone
            // 
            comboBoxIsDone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxIsDone.FormattingEnabled = true;
            comboBoxIsDone.Items.AddRange(new object[] { "Yes", "No" });
            comboBoxIsDone.Location = new Point(610, 628);
            comboBoxIsDone.Name = "comboBoxIsDone";
            comboBoxIsDone.Size = new Size(414, 23);
            comboBoxIsDone.TabIndex = 21;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "non-priority", "most", "middle", "lowest" });
            comboBoxPriority.Location = new Point(610, 194);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(414, 23);
            comboBoxPriority.TabIndex = 22;
            // 
            // comboBoxChooseType
            // 
            comboBoxChooseType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxChooseType.FormattingEnabled = true;
            comboBoxChooseType.Items.AddRange(new object[] { "None", "Statement", "Memo", "Report" });
            comboBoxChooseType.Location = new Point(3, 50);
            comboBoxChooseType.Name = "comboBoxChooseType";
            comboBoxChooseType.Size = new Size(355, 23);
            comboBoxChooseType.TabIndex = 23;
            comboBoxChooseType.SelectedIndexChanged += comboBoxChooseType_SelectedIndexChanged;
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Dock = DockStyle.Fill;
            richTextBoxContent.Location = new Point(610, 434);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(414, 137);
            richTextBoxContent.TabIndex = 24;
            richTextBoxContent.Text = "";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Dock = DockStyle.Fill;
            richTextBoxDesc.Location = new Point(610, 83);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(414, 105);
            richTextBoxDesc.TabIndex = 25;
            richTextBoxDesc.Text = "";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 792);
            Controls.Add(tableLayoutPanel1);
            Name = "FormAdd";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxName;
        private MonthCalendar monthCalendarShelfTime;
        private TextBox textBoxSignedBy;
        private ComboBox comboBoxIsAccepted;
        private Label label1;
        private Button buttonAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBoxIsDone;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxChooseType;
        private RichTextBox richTextBoxContent;
        private RichTextBox richTextBoxDesc;
    }
}