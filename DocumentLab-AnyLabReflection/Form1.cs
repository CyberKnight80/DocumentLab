using System.ComponentModel.Design.Serialization;
using System.Reflection;

namespace ReflectionDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = string.Empty;

        Type mainTypeOfCollecton = null;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "DLL files (*.dll)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                }
            }

            Assembly assembly = Assembly.LoadFile(filePath);

            bool flag = false;

            List<Type> types = assembly.GetTypes().Where(x => x.GetInterface("IVelosiped") != null).ToList();

            if (types.Count != 0)
                flag = true;

            if (flag)
            {
                Containers.UserContainer = Activator.CreateInstance(types[0]);
                this.mainTypeOfCollecton = types[0];
                MessageBox.Show("Path gotten!", "OK");
            }
            else
            {
                MessageBox.Show("Can`t create an object", "NE OK");
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (Containers.UserContainer.GetType() == mainTypeOfCollecton)
            {
                Assembly asm = Assembly.LoadFrom(filePath);
                MethodInfo method = mainTypeOfCollecton.GetMethod("Randomize");
                method.Invoke(Containers.UserContainer, null);
            }
            else
            {
                MessageBox.Show("Different Types", "NE OK");
            }
        }

        private void buttonSortInt_Click(object sender, EventArgs e)
        {
            if (Containers.UserContainer.GetType() == mainTypeOfCollecton)
            {
                Assembly asm = Assembly.LoadFrom(filePath);
                MethodInfo method = mainTypeOfCollecton.GetMethod("SortInt");
                method.Invoke(Containers.UserContainer, null);
            }
            else
            {
                MessageBox.Show("Can`t do this", "NE OK");
            }
        }

        private void buttonSortString_Click(object sender, EventArgs e)
        {
            if (Containers.UserContainer.GetType() == mainTypeOfCollecton)
            {
                Assembly asm = Assembly.LoadFrom(filePath);
                MethodInfo method = mainTypeOfCollecton.GetMethod("SortString");
                method.Invoke(Containers.UserContainer, null);
            }
            else
            {
                MessageBox.Show("Can`t do this", "NE OK");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.listViewContainer.Clear();

            if (Containers.UserContainer.GetType() == mainTypeOfCollecton)
            {
                Assembly asm = Assembly.LoadFrom(filePath);
                MethodInfo method = mainTypeOfCollecton.GetMethod("Print");

                string[] data = method.Invoke(Containers.UserContainer, null) as string[];

                foreach(string str in data)
                {
                    if(str is not null)
                    {
                        this.listViewContainer.Items.Add(str);
                    }
                }
            }
            else
            {
                MessageBox.Show("Can`t do this", "NE OK");
            }
        }
    }

    public interface IVelosiped
    {
        public string[] Print();

        public void SortInt();

        public void SortString();

        public void Randomize();
    }

    public static class Containers
    {
        public static object UserContainer = new object();
    }
}
