using Advanced_Combat_Tracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SkillRotationChecker.View;
using SkillRotationChecker.Util;
using System.Reflection;

namespace SkillRotationChecker
{
    public class PluginMain : IActPluginV1
    {
        public DataManager Settings { get; private set; }
        public ACTTabControl ACTTabControl { get; private set; }
        public SkillView SkillView { get; private set; }
        public IDictionary<string, string> skillMap;

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            skillMap = SkillLoader.load();

            SkillView = new SkillView(this);
            ACTTabControl = new ACTTabControl(this);
            pluginScreenSpace.Text = Assembly.GetExecutingAssembly().GetName().Name;
            pluginScreenSpace.Controls.Add(ACTTabControl);
            ACTTabControl.InitializeSettings();

            Settings = new DataManager(this);
            Settings.Load();

            ACTTabControl.Show();
            ACTTabControl.ReloadSkillRotation();

            ActGlobals.oFormActMain.OnCombatStart += CombatStarted;
            ActGlobals.oFormActMain.OnCombatEnd += CombatEnded;
            ActGlobals.oFormActMain.OnLogLineRead += OnLogLineRead;
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.OnCombatStart -= CombatStarted;
            ActGlobals.oFormActMain.OnCombatEnd -= CombatEnded;
            ActGlobals.oFormActMain.OnLogLineRead -= OnLogLineRead;

            if (Settings != null)
                Settings.Save();

            if (SkillView != null)
                SkillView.Close();

            if(ACTTabControl != null)
                ACTTabControl.Dispose();
        }


        private void CombatStarted(bool isImport, CombatToggleEventArgs encounterInfo)
        {
            if (!SkillView.IsRecording() && !SkillView.IsPlaying() && SkillView.Visible)
            {
                if(SkillView.GetSkillCount() > 0)
                {
                    SkillView.SetPlay(true);
                }
                else
                {
                    SkillView.SetRecord(true);
                }
            }
        }

        private void CombatEnded(bool isImport, CombatToggleEventArgs encounterInfo)
        {
            if (SkillView.IsRecording())
            {
                SkillView.SetRecord(false);
            }
            else if (SkillView.IsPlaying())
            {
                SkillView.SetPlay(false);
            }
        }

        private String beforeSkillTime = "";
        private String beforeSkillID = "";
        private void OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            if (!SkillView.IsRecording() && !SkillView.IsPlaying())
            {
                return;
            }

            String logLine = logInfo.logLine;

            // "[07:23:04.000] 15:FFFFFF"
            if (logLine.Length < 18)
            {
                return;
            }

            String logType = logLine.Substring(15, 3);
            if (!logType.Equals("15:") && !logType.Equals("16:"))
            {
                return;
            }
               

            string[] lineDatas = logLine.Split(':');

            if (lineDatas.Length < 6)
            {
                return;
            }

            if (!SkillView.txtPlayerName.Text.Equals(lineDatas[4])){
                return;
            }

            string skillID = lineDatas[5].ToUpper();
            string skillTime = logLine.Substring(1, 12);

            if(skillID.Equals(beforeSkillID) && skillTime.Equals(beforeSkillTime)){
                return;
            }

            if (skillMap.ContainsKey(skillID))
            {
                Skill skill = new Skill();
                skill.id = skillID;
                skill.imagePath = skillMap[skillID];
                skill.name = lineDatas[6];

                beforeSkillID = skillID;
                beforeSkillTime = skillTime;

                if (SkillView.IsRecording())
                {
                    SkillView.Add(skill);
                }
                else if (SkillView.IsPlaying())
                {
                    SkillView.SkillCompare(skill);
                }
            }
        }
    }
}
