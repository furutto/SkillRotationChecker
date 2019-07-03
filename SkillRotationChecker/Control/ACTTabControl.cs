using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SkillRotationChecker.Util;
using System.IO;
using Advanced_Combat_Tracker;

namespace SkillRotationChecker
{
    public partial class ACTTabControl: UserControl
    {
        private PluginMain plugin;
        private bool updateFromOverlayMove;
        public string strLoadFile;

        public ACTTabControl(PluginMain _plugin)
        {
            InitializeComponent();

            plugin = _plugin;
            updateFromOverlayMove = false;
        }

        public void RefleshList()
        {
            listFile.Items.Clear();
            string dir = GetResourceFileDir();
            if (Directory.Exists(dir))
            {
                String[] files = Directory.GetFiles(dir, "*.csv", SearchOption.TopDirectoryOnly);
                foreach(String file in files)
                {
                    listFile.Items.Add(Path.GetFileName(file));
                }
            }
        }

        public void SkillView_Move(object sender, EventArgs e)
        {
            updateFromOverlayMove = true;
            udViewX.Value = plugin.SkillView.Left;
            udViewY.Value = plugin.SkillView.Top;
            updateFromOverlayMove = false;
        }

        private void checkViewVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewVisible.Checked)
            {
                plugin.SkillView.Show();
            }
            else
            {
                plugin.SkillView.SetPlay(false);
                plugin.SkillView.SetRecord(false);
                plugin.SkillView.Hide();
            }
        }

        private void checkViewMouseEnable_CheckedChanged(object sender, EventArgs e)
        {
            plugin.SkillView.MoveByDrag = checkViewMouseEnable.Checked;
        }

        private void udViewX_ValueChanged(object sender, EventArgs e)
        {
            if (!updateFromOverlayMove)
                plugin.SkillView.Left = (int)udViewX.Value;
        }

        private void udViewY_ValueChanged(object sender, EventArgs e)
        {
            if (!updateFromOverlayMove)
                plugin.SkillView.Top = (int)udViewY.Value;
        }

        private void trackBarOpacity_ValueChanged(object sender, EventArgs e)
        {
            plugin.SkillView.Opacity = ((double)trackBarOpacity.Value) / 100;
            labelCurrOpacity.Text = String.Format("{0}%", trackBarOpacity.Value);
        }

        private void udViewLineCount_ValueChanged(object sender, EventArgs e)
        {
            plugin.SkillView.ResizeList((int)udViewLineCount.Value);
        }

        private void btnFileDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if (Directory.Exists(txtFileDir.Text)){
                fbDialog.SelectedPath = txtFileDir.Text;
            }
            else
            {
                fbDialog.SelectedPath = ".";
            }

            fbDialog.ShowNewFolderButton = true;

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileDir.Text = fbDialog.SelectedPath;
                RefleshList();
            }

            fbDialog.Dispose();
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            if (listFile.SelectedIndex < 0)
                return;

            String targetFile = GetResourceFileDir() + Path.DirectorySeparatorChar + listFile.Text;
            if (!File.Exists(targetFile)){
                MessageBox.Show(
                    "No such file or directory (" + targetFile + ")",
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            plugin.SkillView.LoadSkill(SkillLoader.load(targetFile));
            strLoadFile = listFile.Text;
        }

        public void SaveSkillRotation(List<Skill> list, string playerName)
        {
            DateTime now = DateTime.Now;
            String fileName = txtFileName.Text.Trim();
            if (fileName.Length == 0)
            {
                fileName = "(<yyyyMMdd_HHmmss>)<name>";
            }

            StringBuilder buf = new StringBuilder();
            StringBuilder convBuf = new StringBuilder();
            bool conv = false;
            foreach (char c in fileName)
            {

                if(c == '<')
                {
                    conv = true;
                    convBuf.Clear();
                }
                else if(c == '>')
                {
                    conv = false;
                    String strConv = convBuf.ToString();
                    switch (strConv.ToUpper())
                    {
                        // TODO
                        //case "JOB":
                        //    strConv = list[0].job;
                        //    break;
                        case "NAME":
                            strConv = playerName;
                            break;
                        default:
                            strConv = now.ToString(strConv);
                            break;
                    }
                    buf.Append(strConv);
                }
                else
                {
                    if (conv)
                        convBuf.Append(c);
                    else
                        buf.Append(c);
                }
            }

            strLoadFile = buf.ToString() + ".csv";
            String savePath = GetResourceFileDir() + Path.DirectorySeparatorChar + strLoadFile;
            SkillLoader.save(list, savePath);
            RefleshList();
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            RefleshList();
        }

        public void ReloadSkillRotation()
        {
            RefleshList();
            String targetFile = GetResourceFileDir() + Path.DirectorySeparatorChar + strLoadFile;
            if (File.Exists(targetFile))
            {
                plugin.SkillView.LoadSkill(SkillLoader.load(targetFile));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            linkUpdate.Text = UpdateChecker.DoCheck();
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(UpdateChecker.GetReleaseFileUrl());
        }

        private string GetResourceFileDir()
        {
            string path = txtFileDir.Text.Trim();
            if (path.Length == 0)
            {
                path = ActGlobals.oFormActMain.AppDataFolder.FullName;
            }
            return path;
        }

        public void InitializeSettings()
        {
            linkUpdate.Text = "";
            txtFileDir.Text = ActGlobals.oFormActMain.AppDataFolder.FullName;
            txtFileName.Text = "(<yyyyMMdd_HHmmss>)<name>";

            udViewLineCount.Value = 10;
            udViewLineCount_ValueChanged(this, null);

            udViewX.Value = 100;
            udViewX_ValueChanged(this, null);

            udViewY.Value = 100;
            udViewY_ValueChanged(this, null);

            trackBarOpacity.Value = 70;
            trackBarOpacity_ValueChanged(this, null);

            checkViewMouseEnable.Checked = true;
            checkViewMouseEnable_CheckedChanged(this, null);

            checkViewVisible.Checked = true;
            checkViewVisible_CheckedChanged(this, null);
        }
    }
}
