using DocumentLibrary;

namespace DocumentGUI
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private Document _doc = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxName.Enabled = false;
            this.richTextBoxDesc.Enabled = false;
            this.comboBoxPriority.Enabled = false;
            this.monthCalendarShelfTime.Enabled = false;
            this.richTextBoxContent.Enabled = false;
            this.textBoxSignedBy.Enabled = false;
            this.comboBoxIsDone.Enabled = false;
            this.comboBoxIsAccepted.Enabled = false;
        }

        private void comboBoxChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseType.SelectedIndex == 0)
            {
                this.buttonAdd.Enabled = false;
                this.textBoxName.Enabled = false;
                this.richTextBoxDesc.Enabled = false;
                this.comboBoxPriority.Enabled = false;
                this.monthCalendarShelfTime.Enabled = false;

                this.richTextBoxContent.Enabled = false;
                this.textBoxSignedBy.Enabled = false;
                this.comboBoxIsDone.Enabled = false;
                this.comboBoxIsAccepted.Enabled = false;
            }
            else if (comboBoxChooseType.SelectedIndex == 1)
            {
                this.buttonAdd.Enabled = true;
                this.textBoxName.Enabled = true;
                this.richTextBoxDesc.Enabled = true;
                this.comboBoxPriority.Enabled = true;
                this.monthCalendarShelfTime.Enabled = true;

                this.richTextBoxContent.Enabled = true;

                this.textBoxSignedBy.Enabled = true;

                this.comboBoxIsDone.Enabled = false;

                this.comboBoxIsAccepted.Enabled = false;
            }
            else if (comboBoxChooseType.SelectedIndex == 2)
            {
                this.buttonAdd.Enabled = true;
                this.textBoxName.Enabled = true;
                this.richTextBoxDesc.Enabled = true;
                this.comboBoxPriority.Enabled = true;
                this.monthCalendarShelfTime.Enabled = true;

                this.richTextBoxContent.Enabled = true;

                this.textBoxSignedBy.Enabled = false;

                this.comboBoxIsDone.Enabled = true;

                this.comboBoxIsAccepted.Enabled = false;
            }
            else if (comboBoxChooseType.SelectedIndex == 3)
            {
                this.buttonAdd.Enabled = true;
                this.textBoxName.Enabled = true;
                this.richTextBoxDesc.Enabled = true;
                this.comboBoxPriority.Enabled = true;
                this.monthCalendarShelfTime.Enabled = true;

                this.richTextBoxContent.Enabled = true;

                this.textBoxSignedBy.Enabled = true;

                this.comboBoxIsDone.Enabled = false;

                this.comboBoxIsAccepted.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseType.SelectedIndex == 0)
            {

            }
            else if (comboBoxChooseType.SelectedIndex == 1)
            {
                this._doc = null;
                try
                {
                    DateTime dt = this.monthCalendarShelfTime.SelectionEnd;
                    this._doc = new Statement(
                        this.textBoxName.Text,
                        this.richTextBoxDesc.Text,
                        this.comboBoxPriority.SelectedItem.ToString(),
                        new DateOnly(dt.Year, dt.Month, dt.Day),
                        this.richTextBoxContent.Text,
                        this.textBoxName.Text
                        );
                }
                catch
                {
                    MessageBox.Show("Error!", "Fill All Fields");
                    this._doc = null;
                }
                finally
                {
                    GetDocFromForm();
                }

            }
            else if (comboBoxChooseType.SelectedIndex == 2)
            {
                this._doc = null;
                try
                {
                    DateTime dt = this.monthCalendarShelfTime.SelectionEnd;
                    this._doc = new Memo(
                        this.textBoxName.Text,
                        this.richTextBoxDesc.Text,
                        this.comboBoxPriority.SelectedItem.ToString(),
                        new DateOnly(dt.Year, dt.Month, dt.Day),
                        this.richTextBoxContent.Text,
                        this.comboBoxIsDone.SelectedItem.ToString() == "Yes" ? true : false
                        );
                }
                catch
                {
                    MessageBox.Show("Error!", "Fill All Fields");
                    this._doc = null;
                }
                finally
                {
                    GetDocFromForm();
                }
            }
            else if (comboBoxChooseType.SelectedIndex == 3)
            {
                this._doc = null;
                try
                {
                    DateTime dt = this.monthCalendarShelfTime.SelectionEnd;
                    this._doc = new Report(
                        this.textBoxName.Text,
                        this.richTextBoxDesc.Text,
                        this.comboBoxPriority.SelectedItem.ToString(),
                        new DateOnly(dt.Year, dt.Month, dt.Day),
                        this.richTextBoxContent.Text,
                        this.textBoxName.Text,
                        this.comboBoxIsAccepted.SelectedItem.ToString() == "Yes" ? true : false
                        );
                }
                catch
                {
                    MessageBox.Show("Error!", "Fill All Fields");
                    this._doc = null;
                }
                finally
                {
                    GetDocFromForm();
                }

            }
        }
        public void GetDocFromForm()
        {
            if (_doc is null) return;

            ContainerClass.mainList.Add(_doc);

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}