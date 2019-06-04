using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicatedFileFinder
{
    public partial class MainForm : Form
    {
        private Dictionary<string, DirectoryInfo> _directories = new Dictionary<string, DirectoryInfo>();
        private FileSearchFilter _searchFilter = new FileSearchFilter();
        private DuplicatedCriteria _duplicatedCriteria = new DuplicatedCriteria(true);
        private bool _internalCheckEvent = false;
        private void OnDirectoriesChanged()
        {
            btnStart.Enabled=lvwSourceFolders.Items.Count>0;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void TxtSizeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false)
                e.Handled = true;
        }

        private void BtnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            if (_directories.ContainsKey(folderBrowserDialog.SelectedPath))
            {
                MessageBox.Show("Directory \"" + folderBrowserDialog.SelectedPath + "\" is already in the list.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath);
            _directories.Add(folderBrowserDialog.SelectedPath, di);
            ListViewItem item = lvwSourceFolders.Items.Add((lvwSourceFolders.Items.Count + 1).ToString());
            item.SubItems.Add(folderBrowserDialog.SelectedPath);
            item.Tag = di;
            OnDirectoriesChanged();
        }

        private void LvwSourceFolders_KeyDown(object sender, KeyEventArgs e)
        {
            if (null == lvwSourceFolders.SelectedItems)
                return;

            foreach(ListViewItem item in lvwSourceFolders.SelectedItems)
            {
                lvwSourceFolders.Items.Remove(item);
            }
            OnDirectoriesChanged();
        }

        private void LvwSourceFolders_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] items = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                FileAttributes fileAttributes = 0;
                foreach (string s in items)
                {
                    fileAttributes = File.GetAttributes(s);
                    if ((fileAttributes & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }
                }

                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void LvwSourceFolders_DragDrop(object sender, DragEventArgs e)
        {
            string[] directories = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string dir in directories)
            {
                if (_directories.ContainsKey(dir))
                {
                    MessageBox.Show("Directory \"" + dir + "\" is already in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                DirectoryInfo di = new DirectoryInfo(dir);
                _directories.Add(dir, di);
                ListViewItem item = lvwSourceFolders.Items.Add((lvwSourceFolders.Items.Count + 1).ToString());
                item.SubItems.Add(dir);
                item.Tag = di;
                OnDirectoriesChanged();
            }
        }

        private void SetDefaults()
        {
            _internalCheckEvent = true;
            txtExtensions.Text = _searchFilter.Extensions;
            //
            chbAttrArchive.Checked = (_searchFilter.Attributes & FileAttributes.Archive) != 0;
            chbAttrHidden.Checked = (_searchFilter.Attributes & FileAttributes.Hidden) != 0; ;
            chbAttrNormal.Checked = (_searchFilter.Attributes & FileAttributes.Normal) != 0; ;
            chbAttrReadonnly.Checked = (_searchFilter.Attributes & FileAttributes.ReadOnly) != 0; ;
            chbAttrTemp.Checked = (_searchFilter.Attributes & FileAttributes.Temporary) != 0; ;
            chbAttrSystem.Checked = (_searchFilter.Attributes & FileAttributes.System) != 0; ;
            //
            chbContent.Checked = _duplicatedCriteria.Content;
            chbName.Checked = _duplicatedCriteria.Name;
            chbSize.Checked = _duplicatedCriteria.Size;
            chbAttributes.Checked = _duplicatedCriteria.Attributes;
            //
            chbSizeFilter.Checked = _searchFilter.Size != null;
            if (_searchFilter.Size != null)
            {
                cbbSizeCondition.SelectedIndex = (int)_searchFilter.Size.Condition;
                txtSizeValue.Text = _searchFilter.Size.Value.ToString();
                cbbSizeUnits.SelectedIndex = (int)_searchFilter.Size.Unit;
            }

            _internalCheckEvent = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void LvwSourceFolders_DoubleClick(object sender, EventArgs e)
        {
            if (null == lvwSourceFolders.SelectedItems)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;

                if (_directories.ContainsKey(folderBrowserDialog.SelectedPath))
                {
                    MessageBox.Show("Directory \"" + folderBrowserDialog.SelectedPath + "\" is already in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                _directories.Add(folderBrowserDialog.SelectedPath, di);
                ListViewItem item = lvwSourceFolders.Items.Add((lvwSourceFolders.Items.Count + 1).ToString());
                item.SubItems.Add(folderBrowserDialog.SelectedPath);
                item.Tag = di;
                OnDirectoriesChanged();
            }
            else
            {
                ListViewItem selItem = lvwSourceFolders.SelectedItems[0];
                if (null == selItem)
                    return;

                DirectoryInfo di = selItem.Tag as DirectoryInfo;
                if (null == di)
                    return;
                Process.Start(di.FullName);
            }
        }

        private bool Prepare()
        {
            return false;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!Prepare())
                return;
        }

        private void ChbSizeFilter_CheckedChanged(object sender, EventArgs e)
        {
            cbbSizeCondition.Enabled = txtSizeValue.Enabled = cbbSizeUnits.Enabled = chbSizeFilter.Checked;
            if (!_internalCheckEvent)
            {
                if (chbSizeFilter.Checked)
                {
                    if (null == _searchFilter.Size)
                        _searchFilter.Size = new FileSizeFilter();

                    if (cbbSizeCondition.SelectedIndex == -1)
                        cbbSizeCondition.SelectedIndex = 0;
                    _searchFilter.Size.Condition = (SizeCondition)cbbSizeCondition.SelectedIndex;

                    if (txtSizeValue.Text == string.Empty)
                        txtSizeValue.Text = 0.ToString();
                    _searchFilter.Size.Value = long.Parse(txtSizeValue.Text);

                    if (cbbSizeUnits.SelectedIndex == -1)
                        cbbSizeUnits.SelectedIndex = 0;
                    _searchFilter.Size.Unit = (SizeUnit)cbbSizeUnits.SelectedIndex;
                }
                else
                {
                    _searchFilter.Size = null;
                }
            }
        }

        private void TxtExtensions_TextChanged(object sender, EventArgs e)
        {
            if(!_internalCheckEvent)
            {
                _searchFilter.Extensions = txtExtensions.Text;
            }
        }

        private void ChbAttrNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrNormal.Checked)
                _searchFilter.Attributes |= FileAttributes.Normal;
            else
                _searchFilter.Attributes &= (~FileAttributes.Normal);
        }

        private void ChbAttrArchive_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrArchive.Checked)
                _searchFilter.Attributes |= FileAttributes.Archive;
            else
                _searchFilter.Attributes &= (~FileAttributes.Archive);
        }

        private void ChbAttrTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrTemp.Checked)
                _searchFilter.Attributes |= FileAttributes.Temporary;
            else
                _searchFilter.Attributes &= (~FileAttributes.Temporary);
        }

        private void ChbAttrReadonnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrReadonnly.Checked)
                _searchFilter.Attributes |= FileAttributes.ReadOnly;
            else
                _searchFilter.Attributes &= (~FileAttributes.ReadOnly);
        }

        private void ChbAttrHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrHidden.Checked)
                _searchFilter.Attributes |= FileAttributes.Hidden;
            else
                _searchFilter.Attributes &= (~FileAttributes.Hidden);
        }

        private void ChbAttrSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAttrSystem.Checked)
                _searchFilter.Attributes |= FileAttributes.System;
            else
                _searchFilter.Attributes &= (~FileAttributes.System);
        }

        private void CbbSizeCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchFilter.Size.Condition = (SizeCondition)cbbSizeCondition.SelectedIndex;
        }

        private void TxtSizeValue_TextChanged(object sender, EventArgs e)
        {
            _searchFilter.Size.Value = long.Parse(txtSizeValue.Text);
        }

        private void CbbSizeUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchFilter.Size.Unit = (SizeUnit)cbbSizeCondition.SelectedIndex;
        }

        private void ChbContent_CheckedChanged(object sender, EventArgs e)
        {
            _duplicatedCriteria.Content = chbContent.Checked;
        }

        private void ChbName_CheckedChanged(object sender, EventArgs e)
        {
            _duplicatedCriteria.Name = chbName.Checked;
        }

        private void ChbSize_CheckedChanged(object sender, EventArgs e)
        {
            _duplicatedCriteria.Size = chbSize.Checked;
        }

        private void ChbAttributes_CheckedChanged(object sender, EventArgs e)
        {
            _duplicatedCriteria.Attributes = chbAttributes.Checked;
        }

        private void ChbModifyDate_CheckedChanged(object sender, EventArgs e)
        {
            _duplicatedCriteria.ModifiedDate = chbModifyDate.Checked;
        }
    }
}
