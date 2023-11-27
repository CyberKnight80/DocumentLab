namespace ReflectionDLL
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonRandom = new Button();
            buttonSortInt = new Button();
            buttonSortString = new Button();
            buttonPrint = new Button();
            listViewContainer = new ListView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.603775F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3962269F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(listViewContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1060, 605);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonRandom, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonSortInt, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonSortString, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonPrint, 0, 5);
            tableLayoutPanel2.Location = new Point(815, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.61905F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.38095F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.Size = new Size(242, 599);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Location = new Point(3, 74);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(236, 73);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add DLL";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRandom.Location = new Point(3, 153);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(236, 111);
            buttonRandom.TabIndex = 1;
            buttonRandom.Text = "Randomize";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click;
            // 
            // buttonSortInt
            // 
            buttonSortInt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSortInt.Location = new Point(3, 270);
            buttonSortInt.Name = "buttonSortInt";
            buttonSortInt.Size = new Size(236, 77);
            buttonSortInt.TabIndex = 2;
            buttonSortInt.Text = "Sort Int";
            buttonSortInt.UseVisualStyleBackColor = true;
            buttonSortInt.Click += buttonSortInt_Click;
            // 
            // buttonSortString
            // 
            buttonSortString.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSortString.Location = new Point(3, 353);
            buttonSortString.Name = "buttonSortString";
            buttonSortString.Size = new Size(236, 103);
            buttonSortString.TabIndex = 3;
            buttonSortString.Text = "Sort String";
            buttonSortString.UseVisualStyleBackColor = true;
            buttonSortString.Click += buttonSortString_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPrint.Location = new Point(3, 462);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(236, 82);
            buttonPrint.TabIndex = 4;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // listViewContainer
            // 
            listViewContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewContainer.Location = new Point(3, 3);
            listViewContainer.Name = "listViewContainer";
            listViewContainer.Size = new Size(806, 599);
            listViewContainer.TabIndex = 1;
            listViewContainer.UseCompatibleStateImageBehavior = false;
            listViewContainer.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 605);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private Button buttonRandom;
        private Button buttonSortInt;
        private Button buttonSortString;
        private Button buttonPrint;
        private ListView listViewContainer;
    }
}
