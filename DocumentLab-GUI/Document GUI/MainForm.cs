using System.Media;
using DocumentLibrary;

namespace DocumentGUI
{

    public partial class MainForm : Form
    {
        public bool low = false;
        public bool eq = false;
        public bool high = false;

        private bool flag = false;

        SoundPlayer soundPlayer = new SoundPlayer(@"123.wav");
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {
            //null
        }

        private void ButtonAddNew(object sender, EventArgs e)
        {
            FormAdd newForm = new FormAdd();
            newForm.Show();
        }

        private void ButtonFind(object sender, EventArgs e)
        {
            FormFind newForm = new FormFind();
            newForm.Show();
        }

        private void buttonSecret_Click(object sender, EventArgs e)
        {
            if (!flag) flag = true;
            else flag = false;

            if (flag)
                soundPlayer.Play();
            else
                soundPlayer.Stop();
        }

        private void listViewContainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddNewEl(Document? doc)
        {
            if (doc is null) return;

            ContainerClass.mainList.Add(doc);

        }

        private void buttonPrintAllList_Click(object sender, EventArgs e)
        {
            listViewContainer.Clear();

            foreach (Document doc in ContainerClass.mainList)
            {
                listViewContainer.Items.Add(doc.ToString());
            }
        }

        private void buttonPrintRefundList_Click(object sender, EventArgs e)
        {
            listViewContainer.Clear();

            foreach (Document doc in ContainerClass.refund)
            {
                listViewContainer.Items.Add(doc.ToString());
            }
        }
    }
    public static class ContainerClass
    {
        public static DocumentList<Document> mainList = new DocumentList<Document>();

        public static DocumentList<Document> refund = new DocumentList<Document>();
    }

}