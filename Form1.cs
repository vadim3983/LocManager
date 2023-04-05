using System.ComponentModel;
using System.IO.Compression;
using Newtonsoft.Json;

namespace LocManager;

public partial class Form1 : Form
{
    private const int FolderIcon = 1;
    private const int FileIcon = 0;
    private Graphics? _graphics;
    public Form1()
    {
        InitializeComponent();
        tabControlPanel2.SelectedIndex = 0;

        var node = new TreeNode("<ROOT>")
        {
            ImageIndex = FolderIcon,
            SelectedImageIndex = FolderIcon
        };

        treeViewPanel1.Nodes.Add(node);

        treeViewPanel1.SelectedNode = null;

        deleteEntryToolStripMenuItem.ShortcutKeys = Keys.Delete;
        deleteEntryToolStripMenuItem.ShowShortcutKeys = true;
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Environment.CurrentDirectory;
        openFileDialog.Filter = @"Zip Files(*.zip)|*.zip;*.zip;*.zip";
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        ReadZipFile(openFileDialog.FileName);
    }

    private void ReadZipFile(string zipPath)
    {
        treeViewPanel1.Nodes.Clear();
        var treeNodes = new Dictionary<string, TreeNode>();

        using var zipArchive = ZipFile.OpenRead(zipPath);
        foreach (var zipArchiveEntry in zipArchive.Entries)
        {
            if (Path.GetExtension(zipArchiveEntry.Name) != ".json")
            {
                continue;
            }

            using var streamReader = new StreamReader(zipArchiveEntry.Open());
            var readToEnd = streamReader.ReadToEnd();
            var deserializeObject = JsonConvert.DeserializeObject<LocEntry>(readToEnd);
            _locEntries.Add(deserializeObject ?? throw new InvalidOperationException());
            AddNodeToTree(deserializeObject, treeViewPanel1, treeNodes);
        }
    }


    private static void AddNodeToTree(LocEntry entry, TreeView treeView, IDictionary<string, TreeNode> pathNodes)
    {
        var parts = entry.HierarchyPath?.Split('-');
        TreeNode? treeNode = null;

        for (var i = 0; i < parts!.Length; i++)
        {
            var text = parts[i];

            var path = treeNode == null ? text : $"{treeNode.FullPath}-{text}";

            if (!pathNodes.ContainsKey(path))
            {
                var node = new TreeNode(text)
                {
                    ImageIndex = FolderIcon,
                    SelectedImageIndex = FolderIcon
                };

                if (treeNode != null)
                {
                    treeNode.Nodes.Add(node);
                }
                else
                {
                    treeView.Nodes.Add(node);
                }

                pathNodes.Add(path, node);
            }

            treeNode = pathNodes[path];
        }

        var entryNode = new TreeNode(entry.EntryName)
        {
            Name = entry.EntryName,
            ImageIndex = FileIcon,
            SelectedImageIndex = FileIcon
        };
        treeNode?.Nodes.Add(entryNode);
    }

    private readonly BindingList<LocEntry> _locEntries = new();

    private int _currLocEntryInd = -1;

    private void treeViewPanel1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        var selectedNode = treeViewPanel1.SelectedNode;
        if (selectedNode.Nodes.Count != 0)
        {
            return;
        }

        listViewLower.Items.Clear();
        _currLocEntryInd = -1;
        var text = selectedNode.FullPath.Replace('\\', '-');

        if (!_locEntries.Any()) return;
        var entry = _locEntries
            .FirstOrDefault(a => $"{a.HierarchyPath}-{a.EntryName}" == text);

        if (entry == null) return;
        directoryTextBox.Text = text;
        translationTextBox.Text = entry.Translations?[Language.Debug];
        tabControlPanel2.SelectedIndex = 1;
        var newItem =
            new ListViewItem(new[] { "debug", entry.Translations?[Language.Debug] });
        listViewLower.Items.Add(newItem);
        _currLocEntryInd = _locEntries.IndexOf(entry);
    }


    private void translationTextBox_TextChanged(object sender, EventArgs e)
    {
        if (_currLocEntryInd == -1) return;
        _locEntries[_currLocEntryInd].Translations![Language.Debug] = translationTextBox.Text;
        listViewLower.Items[0].SubItems[1].Text = translationTextBox.Text;
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var fileDialog = new SaveFileDialog();
        fileDialog.Filter = @"Zip files (*.zip)|*.zip";
        fileDialog.Title = @"Save as zip file";
        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            SaveLocEntriesToZip(fileDialog.FileName);
        }
    }

    private void SaveLocEntriesToZip(string zipPath)
    {
        using var memoryStream = new MemoryStream();
        using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
        {
            var jsonFiles = new HashSet<string>();

            for (var i = 0; i < _locEntries.Count; i++)
            {
                var entry = _locEntries[i];
                var name = $"LocKey#{entry.LocKey}.json";

                if (Path.GetExtension(name) != ".json")
                {
                    continue;
                }

                if (jsonFiles.Contains(name))
                {
                    continue;
                }

                var archiveEntry = archive.CreateEntry(name);

                using (var streamWriter = new StreamWriter(archiveEntry.Open()))
                {
                    var serializeObject = JsonConvert.SerializeObject(entry);
                    streamWriter.Write(serializeObject);
                }

                jsonFiles.Add(name);
            }
        }

        using (var destination = new FileStream(zipPath, FileMode.Create))
        {
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.CopyTo(destination);
        }
    }


    private void Searching()
    {
        searchListView.Items.Clear();
        foreach (var entry in _locEntries)
        {
            var s = $"{entry.HierarchyPath}-{entry.EntryName}";
            if (!s.ToLower().Contains(searchTextBox.Text.ToLower())) continue;
            var item = new ListViewItem(new[] { entry.LocKey, s, entry.EntryName });
            searchListView.Items.Add(item);
        }
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        Searching();
    }

    private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        Searching();
        e.Handled = true;
    }

    private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (treeViewPanel1.SelectedNode == null || treeViewPanel1.SelectedNode.ImageIndex == FileIcon)
        {
            MessageBox.Show(@"Please select a folder to add a new entry.", @"No Folder Selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        directoryTextBox.ReadOnly = false;
        directoryTextBox.Text = treeViewPanel1.SelectedNode.FullPath.Replace('\\', '-') + '-';
        tabControlPanel2.SelectedIndex = 1;
        directoryTextBox.Focus();
        directoryTextBox.SelectionStart = directoryTextBox.Text.Length;

    }


    private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (treeViewPanel1.SelectedNode == null || treeViewPanel1.SelectedNode.ImageIndex == FolderIcon)
        {
            MessageBox.Show(@"Please select an entry to delete.", @"No Entry Selected", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var s = treeViewPanel1.SelectedNode.FullPath.Replace('\\', '-');
        var toRemove =
            _locEntries.FirstOrDefault(a => $"{a.HierarchyPath}-{a.EntryName}" == s);
        if (toRemove != null)
        {
            _locEntries.Remove(toRemove);
        }

        treeViewPanel1.SelectedNode.Remove();
    }

    private void toolStripStatusLabel1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripDropDownButton1_Click(object sender, EventArgs e)
    {

    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void ShowErrorIcon()
    {
        _graphics = directoryTextBox.CreateGraphics();
        Image image = SystemIcons.Error.ToBitmap();

        var imageWidth = directoryTextBox.ClientSize.Width - image.Width - 5;
        var imageHeight = (directoryTextBox.ClientSize.Height - image.Height) / 2;
        _graphics.DrawImage(image, imageWidth, imageHeight);
    }
    private void RemoveErrorIcon()
    {
        _graphics?.Dispose();
    }
    private void directoryTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        switch (directoryTextBox.ReadOnly)
        {
            case true:
                ShowErrorIcon();
                return;
            case false when e.KeyCode == Keys.Enter:
                {
                    var s = directoryTextBox.Text;

                    var entryName = s.Substring(s.LastIndexOf('-') + 1);
                    if (_locEntries.Any(a => a.EntryName == entryName))
                    {
                        ShowErrorIcon();
                        return;
                    }
                    RemoveErrorIcon();
                    var path = treeViewPanel1.SelectedNode.FullPath.Replace('\\', '-');
                    var entry = new LocEntry(path, entryName)
                    {
                        Translations = new Dictionary<Language, string> { { Language.Debug, "" } }
                    };
                    _locEntries.Add(entry);

                    var treeNode = new TreeNode(entryName)
                    {
                        ImageIndex = 0,
                        SelectedImageIndex = 0
                    };
                    treeViewPanel1.SelectedNode.Nodes.Add(treeNode);
                    e.Handled = true;
                    directoryTextBox.ReadOnly = true;
                    break;
                }
        }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            deleteEntryToolStripMenuItem_Click(sender, e);
        }
    }

    private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var node = treeViewPanel1.SelectedNode;

        switch (node.Text)
        {
            case @"<ROOT>":
                treeViewPanel1.LabelEdit = true;
                node.BeginEdit();
                return;
        }

        const int folderIconIndex = 1;
        var treeNode = new TreeNode("New Folder", folderIconIndex, folderIconIndex);
        treeViewPanel1.LabelEdit = true;

        switch (node.Parent)
        {
            case null:
                treeViewPanel1.Nodes.Add(treeNode);
                treeViewPanel1.Nodes[^1].BeginEdit();
                break;
            default:
                node.Parent.Nodes.Add(treeNode);
                node.Parent.Nodes[^1].BeginEdit();
                break;
        }
    }

    private void newSubGroupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var node = treeViewPanel1.SelectedNode;
        if (node.Text == @"<ROOT>") return;

        const int folderIconIndex = 1;
        var treeNode = new TreeNode("New Subfolder", folderIconIndex, folderIconIndex);

        node.Nodes.Add(treeNode);
        node.Expand();

        treeViewPanel1.LabelEdit = true;
        node.Nodes[^1].BeginEdit();
    }


    private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var node = treeViewPanel1.SelectedNode;
        if (node.Parent != null || treeViewPanel1.Nodes.Count <= 1)
            node.Parent?.Nodes.Remove(node);
        else
        {
            treeViewPanel1.Nodes.Remove(node);
        }
        var remove = new BindingList<LocEntry>();
        foreach (var entry in _locEntries)
        {
            if (treeViewPanel1.Nodes.Find(entry.EntryName, true).FirstOrDefault() == null)
            {
                remove.Add(entry);
            }
        }
        foreach (var entry in remove)
            _locEntries.Remove(entry);
    }

    private void treeViewPanel1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right) return;
        treeViewPanel1.SelectedNode = treeViewPanel1.GetNodeAt(e.X, e.Y);

        if (treeViewPanel1.SelectedNode == null) return;
        var folder = treeViewPanel1.SelectedNode.ImageIndex != 0;

        newGroupToolStripMenuItem.Visible = folder;
        newSubGroupToolStripMenuItem.Visible = folder;
        deleteGroupToolStripMenuItem.Visible = folder;

        contextMenuStrip1.Show(treeViewPanel1, e.Location);
    }

    private void searchListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        var itemAt = searchListView.GetItemAt(e.X, e.Y);
        if (itemAt == null) return;
        listViewLower.Items.Clear();
        var text = itemAt.SubItems[1].Text;
        var entry = _locEntries
            .FirstOrDefault(a => $"{a.HierarchyPath}-{a.EntryName}" == text);

        if (entry == null) return;
        _currLocEntryInd = -1;
        treeViewPanel1.SelectedNode = treeViewPanel1.Nodes.Find(itemAt.SubItems[2].Text, true).FirstOrDefault();
        directoryTextBox.Text = text;
        translationTextBox.Text = entry.Translations?[Language.Debug];
        var item =
            new ListViewItem(new[] { "debug", entry.Translations?[Language.Debug] });
        listViewLower.Items.Clear();
        listViewLower.Items.Add(item);
        tabControlPanel2.SelectedIndex = 1;
        _currLocEntryInd = _locEntries.IndexOf(entry);
    }

    private void toolStripStatusLabel2_Click(object sender, EventArgs e)
    {

    }
}