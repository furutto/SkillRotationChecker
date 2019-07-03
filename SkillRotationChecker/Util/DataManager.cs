
namespace SkillRotationChecker.Util
{
    public class DataManager
    {
        private PluginMain plugin;
        private PluginSettings settings;

        public DataManager(PluginMain _plugin)
        {
            plugin = _plugin;
            settings = new PluginSettings(this);

            ACTTabControl ctl = plugin.ACTTabControl;
            settings.AddControlSetting("ViewVisible", ctl.checkViewVisible);
            settings.AddControlSetting("ViewMouseEnable", ctl.checkViewMouseEnable);
            settings.AddControlSetting("ViewLineCount", ctl.udViewLineCount);
            settings.AddControlSetting("ViewX", ctl.udViewX);
            settings.AddControlSetting("ViewY", ctl.udViewY);
            settings.AddControlSetting("FileDir", ctl.txtFileDir);
            settings.AddControlSetting("FileName", ctl.txtFileName);
            settings.AddControlSetting("Opacity", ctl.trackBarOpacity);
            settings.AddControlSetting("PlayerName", plugin.SkillView.txtPlayerName);

            settings.AddStringSetting("LastLoadFile");
        }

        public string LastLoadFile
        {
            get { return plugin.ACTTabControl.strLoadFile; }
            set { plugin.ACTTabControl.strLoadFile = value; }
        }

        public void Load()
        {
            settings.Load();
        }

        public void Save()
        {
            settings.Save();
        }
    }
}
