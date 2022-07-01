using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Fire_Sploit
{
    public partial class ExecutorForm : Form
    {
        ExploitAPI WRD = new ExploitAPI();

        public ExecutorForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            Process[] Proc = Process.GetProcessesByName("RobloxPlayerBeta");
            if (Proc.Length >= 1)
            {
                if (WRD.isAPIAttached() == true)
                {
                    MessageBox.Show("Already Attached");
                }
                else if (WRD.isAPIAttached() == false)
                {
                    WRD.LegacyLaunchExploit();
                }
            }
            else if (Proc.Length == 0)
            {
                MessageBox.Show("Open Roblox Before Attaching.");
            }
        }

        private void ExecBtn_Click(object sender, EventArgs e)
        {
            WRD.SendLuaScript(Editor.Text);
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            Editor.Clear();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Text Files (.txt)|*.txt|Lua Files (.lua)|*.lua";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        Editor.Text = MainText;
                    };
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text Files|*.txt|Lua Files|*.lua|All Files|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;

                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    string EditorText = Editor.Text;

                    sw.Write(EditorText);
                }
            }
        }

        private void ExecFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Text Files (.txt)|*.txt|Lua Files (.lua)|*.lua";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        WRD.SendLuaScript(MainText);
                    };
                }

            }
        }

        private void ExecutorForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Directory.GetDirectories("./scripts/"))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(item);
                var node = ScriptBox.Nodes.Add(dirInfo.Name, dirInfo.Name, 0, 0);
                node.Tag = dirInfo;
            }

            foreach (var item in Directory.GetFiles("./scripts/"))
            {
                FileInfo fiInfo = new FileInfo(item);
                var node = ScriptBox.Nodes.Add(key: fiInfo.Name, text: fiInfo.Name, 1, 1);
                node.Tag = fiInfo;
            }
        }

        private void ScriptBox_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                e.Node.Nodes.Clear();

                foreach (var item in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    var node = e.Node.Nodes.Add(di.Name, di.Name, imageIndex: 0, 0);
                    node.Tag = di;
                }

                foreach (var item in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo fi = new FileInfo(item);
                    var node = e.Node.Nodes.Add(fi.Name, fi.Name, imageIndex: 1, 1);
                    node.Tag = fi;
                }
            }
            else
            {
                Editor.Text = File.ReadAllText(((FileInfo)e.Node.Tag).FullName);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ScriptBox.Nodes.Clear();
            foreach (var item in Directory.GetDirectories("./scripts/"))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(item);
                var node = ScriptBox.Nodes.Add(dirInfo.Name, dirInfo.Name, 0, 0);
                node.Tag = dirInfo;
            }

            foreach (var item in Directory.GetFiles("./scripts/"))
            {
                FileInfo fiInfo = new FileInfo(item);
                var node = ScriptBox.Nodes.Add(key: fiInfo.Name, text: fiInfo.Name, 1, 1);
                node.Tag = fiInfo;
            }
        }
    }
}
