using DocumentLibrary;

namespace DocumentGUI
{
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }

        private Document? _doc = null;
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


        private void buttonFind_Click(object sender, EventArgs e)
        {
            ContainerClass.refund = ContainerClass.mainList.FindAll(
                new PredicateElements().FormPredicateDoc(
                    comboBoxNameEq.SelectedIndex == 0 ? true : false,

                    comboBoxDescEq.SelectedIndex == 0 ? true : false,

                    comboBoxPriorityEq.SelectedIndex == 0 ? true : false,

                    comboBoxShelfTimeEq.SelectedIndex == 0 ? true : false,
                    comboBoxShelfTimeEq.SelectedIndex == 1 ? true : false,
                    comboBoxShelfTimeEq.SelectedIndex == 2 ? true : false,
                    comboBoxShelfTimeEq.SelectedIndex == 4 ? true : false,
                    comboBoxShelfTimeEq.SelectedIndex == 3 ? true : false,

                    comboBoxContentEq.SelectedIndex == 0 ? true : false,

                    comboBoxSignedByEq.SelectedIndex == 0 ? true : false,

                    comboBoxIsDoneEq.SelectedIndex == 0 ? true : false,

                    comboBoxIsAcceptedEq.SelectedIndex == 0 ? true : false,



                    textBoxName.Enabled,

                    richTextBoxDesc.Enabled,

                    comboBoxPriority.Enabled,

                    monthCalendarShelfTime.Enabled,

                    richTextBoxContent.Enabled,

                    textBoxSignedBy.Enabled,

                    comboBoxIsDone.Enabled,

                    comboBoxIsAccepted.Enabled,




                    textBoxName.Enabled ? textBoxName.Text : string.Empty,

                    richTextBoxDesc.Enabled ? richTextBoxDesc.Text : string.Empty,

                    comboBoxPriority.Enabled ? comboBoxPriority.Items[comboBoxPriority.SelectedIndex].ToString() : string.Empty,

                    monthCalendarShelfTime.Enabled ? new DateOnly(monthCalendarShelfTime.SelectionEnd.Year, monthCalendarShelfTime.SelectionEnd.Month, monthCalendarShelfTime.SelectionEnd.Day) : new DateOnly(),

                    richTextBoxContent.Enabled ? richTextBoxContent.Text : string.Empty,

                    textBoxSignedBy.Enabled ? textBoxSignedBy.Text : string.Empty,

                    comboBoxIsDone.Enabled ? comboBoxIsDone.Items[comboBoxIsDone.SelectedIndex].ToString() : string.Empty,

                    comboBoxIsAccepted.Enabled ? comboBoxIsAccepted.Items[comboBoxIsAccepted.SelectedIndex].ToString() : string.Empty


                ));
        }
        public Document? GetDocFromForm()
        {
            return _doc;
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

        private void comboBoxNameEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNameEnabled.SelectedIndex == 0)
            {
                this.textBoxName.Enabled = true;
            }
            else if (comboBoxNameEnabled.SelectedIndex == 1)
            {
                this.textBoxName.Enabled = false;
            }
        }

        private void comboBoxDescEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDescEnabled.SelectedIndex == 0)
            {
                this.richTextBoxDesc.Enabled = true;
            }
            else if (comboBoxDescEnabled.SelectedIndex == 1)
            {
                this.richTextBoxDesc.Enabled = false;
            }
        }

        private void comboBoxPriorityEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPriorityEnabled.SelectedIndex == 0)
            {
                this.comboBoxPriority.Enabled = true;
            }
            else if (comboBoxPriorityEnabled.SelectedIndex == 1)
            {
                this.comboBoxPriority.Enabled = false;
            }
        }

        private void comboBoxShelfTimeEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShelfTime.SelectedIndex == 0)
            {
                this.monthCalendarShelfTime.Enabled = true;
            }
            else if (comboBoxShelfTime.SelectedIndex == 1)
            {
                this.monthCalendarShelfTime.Enabled = false;
            }
        }

        private void comboBoxContentEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxContentEnabled.SelectedIndex == 0)
            {
                this.richTextBoxContent.Enabled = true;
            }
            else if (comboBoxContentEnabled.SelectedIndex == 1)
            {
                this.richTextBoxContent.Enabled = false;
            }
        }

        private void comboBoxSignedByEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSignedByEnabled.SelectedIndex == 0)
            {
                this.textBoxSignedBy.Enabled = true;
            }
            else if (comboBoxSignedByEnabled.SelectedIndex == 1)
            {
                this.textBoxSignedBy.Enabled = false;
            }
        }

        private void comboBoxIsDoneEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIsDoneEnabled.SelectedIndex == 0)
            {
                this.comboBoxIsDone.Enabled = true;
            }
            else if (comboBoxIsDoneEnabled.SelectedIndex == 1)
            {
                this.comboBoxIsDone.Enabled = false;
            }
        }

        private void comboBoxIsAcceptedEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIsAcceptedEnabled.SelectedIndex == 0)
            {
                this.comboBoxIsAccepted.Enabled = true;
            }
            else if (comboBoxIsAcceptedEnabled.SelectedIndex == 1)
            {
                this.comboBoxIsAccepted.Enabled = false;
            }
        }
    }
}