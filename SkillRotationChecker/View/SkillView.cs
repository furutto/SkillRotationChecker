using SkillRotationChecker.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SkillRotationChecker.View
{
    public partial class SkillView : Form
    {
        private PluginMain plugin;
        private List<Skill> list = new List<Skill>();
        private int currentIndex = 0;
        private int showLineCount = 1;
        private string recordPlayerName = "";

        public SkillView(PluginMain _plugin)
        {
            InitializeComponent();

            this.plugin = _plugin;

            MoveByDrag = true;
            this.Move += SkillView_Move;
            this.MouseDown += SkillView_MouseDown;
            listView1.MouseDown += SkillView_MouseDown;

        }

        private bool moveByDrag;
        public bool MoveByDrag
        {
            get { return moveByDrag; }
            set
            {
                moveByDrag = value;
                Win32APIUtils.SetWS_EX_TRANSPARENT(Handle, !moveByDrag);
            }
        }

        void SkillView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MoveByDrag)
            {
                Win32APIUtils.DragMove(Handle);
            }
        }

        private void SkillView_Move(object sender, EventArgs e)
        {
            plugin.ACTTabControl.SkillView_Move(sender, e);
        }

        public void Reset()
        {
            listView1.Items.Clear();
            list.Clear();
            currentIndex = 0;
            recordPlayerName = "";
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            UpdateLayout(currentIndex);
        }

        private void UpdateLayout(int index)
        {
            if (listView1.Items.Count > 0)
            {
                if (index < 0)
                {
                    index = 0;
                }
                else if(listView1.Items.Count <= index)
                {
                    index = listView1.Items.Count - 1;
                }
                listView1.EnsureVisible(index);
            }
        }

        public void Add(Skill skill)
        {
            if (currentIndex == 0)
            {
                recordPlayerName = txtPlayerName.Text;
            }

            ListViewItem lvi = new ListViewItem();
            lvi.ImageKey = skill.imagePath;
            lvi.SubItems.Add(skill.name);
            lvi.SubItems.Add("");
            listView1.Items.Add(lvi);
            list.Add(skill);
            currentIndex++;
            UpdateLayout();
        }

        public void SkillCompare(Skill skill)
        {
            if(list.Count > 0 && list.Count > currentIndex)
            {
                Skill orgSkill = list[currentIndex];
                if(orgSkill.id == skill.id)
                {
                    listView1.Items[currentIndex].SubItems[2].Text = "OK";
                }
                else
                {
                    listView1.Items[currentIndex].SubItems[2].Text = "NG";
                }

                if(list.Count-1 == currentIndex)
                {
                    SetPlay(false);
                }
                else
                {
                    if(plugin.ACTTabControl.udViewLineCount.Value == 1)
                    {
                        UpdateLayout(currentIndex + 1);
                    }
                    else
                    {
                        UpdateLayout(list.Count - 1);
                        UpdateLayout(currentIndex);
                    }
                }
            }
            currentIndex++;
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            if (IsRecording())
            {
                SetRecord(true);
            }else if (IsPlaying())
            {
                SetPlay(true);
            }
        }

        private void chkPlay_Click(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (IsRecording())
            {
                SetRecord(false);
            }

            SetPlay(chkBox.Checked);
        }

        private void chkRecord_Click(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (IsPlaying())
            {
                SetPlay(false);
            }

            SetRecord(chkBox.Checked);
        }

        public Boolean IsRecording()
        {
            return chkRecord.Checked;
        }

        public Boolean IsPlaying()
        {
            return chkPlay.Checked;
        }

        public void SetPlay(Boolean play)
        {
            chkPlay.Checked = play;
            if (play)
            {
                chkPlay.BackgroundImage = Properties.Resources.skill_stop;

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].SubItems[2].Text = "";
                }
                currentIndex = 0;

                UpdateLayout();

            }
            else
            {
                chkPlay.BackgroundImage = Properties.Resources.skill_play;
            }
        }

        public void SetRecord(Boolean record)
        {
            chkRecord.Checked = record;
            if (record)
            {
                chkRecord.BackgroundImage = Properties.Resources.skill_record_stop;
                Reset();

            }
            else
            {
                chkRecord.BackgroundImage = Properties.Resources.skill_record_start;
            }
        }

        public int GetSkillCount()
        {
            return list.Count;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.DrawDefault = false;
                e.DrawBackground();
                Point location = e.SubItem.Bounds.Location;
                Bitmap bmpCheck = null;

                if (e.SubItem.Text.Equals("OK"))
                {
                    bmpCheck = Properties.Resources.skill_ok;
                }
                else if (e.SubItem.Text.Equals("NG"))
                {
                    bmpCheck = Properties.Resources.skill_ng;
                }

                if(bmpCheck != null)
                {
                    Point p = new Point(location.X, location.Y + (e.SubItem.Bounds.Height - bmpCheck.Height) / 2);
                    e.Graphics.DrawImage(bmpCheck, p);
                }
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        public void LoadSkill(List<Skill> list)
        {
            Reset();
            this.list = list;
            foreach (Skill skill in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = skill.imagePath;
                lvi.SubItems.Add(skill.name);
                lvi.SubItems.Add("");
                listView1.Items.Add(lvi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(list.Count > 0 && !"".Equals(recordPlayerName))
            {
                plugin.ACTTabControl.SaveSkillRotation(list, recordPlayerName);
            }
        }

        public void ResizeList(int showLines)
        {
            showLineCount = showLines;
            int height = listView1.SmallImageList.ImageSize.Height;
            listView1.Height = (height+1) * showLines +1;

            this.Height = listView1.Top + listView1.Height + txtPlayerName.Height;

        }

        private void chkRecord_CheckedChanged(object sender, EventArgs e)
        {
            chkRecord.BackColor = Color.Black;
        }

        private void chkPlay_CheckedChanged(object sender, EventArgs e)
        {
            chkPlay.BackColor = Color.Black;
        }
    }
}
