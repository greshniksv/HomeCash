using System.Configuration;

namespace HomeCash
{
	using System.Linq;

	static class AppSettings
	{
		private static Configuration _config;
		private static Configuration Config {
			get {
				if (_config == null) {
					var configFileMap = new ExeConfigurationFileMap {
						ExeConfigFilename = @".\App.config"
					};
					_config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
				}
				return _config;
			}
		}

		private static string GetValue(string param, string defvalue) {
			if (Config.AppSettings.Settings.AllKeys.All(x => x != param)) {
				Config.AppSettings.Settings.Add(new KeyValueConfigurationElement(param, defvalue));
				Config.Save(); 
			}
			return Config.AppSettings.Settings[param].Value;
		}

		private static void SetValue(string param, string value) {
			if (Config.AppSettings.Settings.AllKeys.All(x => x != param)) {
				Config.AppSettings.Settings.Add(new KeyValueConfigurationElement(param, value));
			} else {
				Config.AppSettings.Settings[param].Value = value;
			}
			Config.Save();
		}

		private static bool? _fullScreen;
		public static bool FullScreen {
			get {
				if (_fullScreen == null) {
					_fullScreen = GetValue("FullScreen", "false").ToLower() == "true";
				}
				return (bool)_fullScreen;
			}

			set {
				_fullScreen = value;
				SetValue("FullScreen", (bool)_fullScreen ? "True" : "False");
			}
		}

	}
}
