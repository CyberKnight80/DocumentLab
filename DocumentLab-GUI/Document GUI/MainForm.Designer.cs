namespace DocumentGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            listViewContainer = new ListView();
            buttonPanel = new TableLayoutPanel();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            tableLayoutPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.1818161F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.818182F));
            tableLayoutPanel.Controls.Add(listViewContainer, 0, 0);
            tableLayoutPanel.Controls.Add(buttonPanel, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1099, 833);
            tableLayoutPanel.TabIndex = 0;
            // 
            // listView1
            // 
            listViewContainer.Dock = DockStyle.Fill;
            listViewContainer.Location = new Point(3, 2);
            listViewContainer.Margin = new Padding(3, 2, 3, 2);
            listViewContainer.Name = "listView1";
            listViewContainer.Size = new Size(875, 829);
            listViewContainer.TabIndex = 0;
            listViewContainer.UseCompatibleStateImageBehavior = false;
            listViewContainer.View = View.List;
            listViewContainer.SelectedIndexChanged += listViewContainer_SelectedIndexChanged;
            // 
            // buttonPanel
            // 
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonPanel.Controls.Add(button5, 0, 2);
            buttonPanel.Controls.Add(button1, 0, 1);
            buttonPanel.Controls.Add(button3, 0, 3);
            buttonPanel.Controls.Add(button2, 0, 6);
            buttonPanel.Controls.Add(button4, 0, 4);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(884, 2);
            buttonPanel.Margin = new Padding(3, 2, 3, 2);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.RowCount = 7;
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.73646F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.26354F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonPanel.Size = new Size(212, 829);
            buttonPanel.TabIndex = 1;
            buttonPanel.Paint += buttonPanel_Paint;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(3, 279);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(206, 135);
            button5.TabIndex = 5;
            button5.Text = "Find";
            button5.Click += ButtonFind;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 137);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(206, 138);
            button1.TabIndex = 0;
            button1.Text = "Add New Elements";
            button1.Click += ButtonAddNew;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 419);
            button3.Name = "button3";
            button3.Size = new Size(206, 147);
            button3.TabIndex = 7;
            button3.Text = "Print Full List";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonPrintAllList_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(3, 811);
            button2.Name = "button2";
            button2.Size = new Size(206, 15);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSecret_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(3, 572);
            button4.Name = "button4";
            button4.Size = new Size(206, 145);
            button4.TabIndex = 8;
            button4.Text = "Print Finded Elements";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonPrintRefundList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 833);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Your Form Title";
            tableLayoutPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel;
        private ListView listViewContainer;
        private TableLayoutPanel buttonPanel;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}