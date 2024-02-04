using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NotePadMinusMinus;
public static class ConfigManager
{
#if WINDOWS
	public static readonly FileInfo SaveFileLocation = new(Environment.ExpandEnvironmentVariables(@"%APPDATA%\NotePad--\Settings.json"));
#else
	public static readonly FileInfo SaveFileLocatione = new(Environment.ExpandEnvironmentVariables(@"%HOME%/.local/NotePad--/Settings.json"));
#endif
	public static bool IsFirstLaunch { get; private set; }
	public static Config Config { get; set; }

	static ConfigManager()
	{
		if (!SaveFileLocation.Directory!.Exists)
		{
			IsFirstLaunch = true;
			SaveFileLocation.Directory!.Create();
		}
		try
		{
			Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(SaveFileLocation.FullName))!;
		} catch
		{
			Config = new();
			WriteConfig();
		}
		AppDomain.CurrentDomain.ProcessExit += Dispose;
	}
	public static void Dispose(object? _, EventArgs _2)
	{
		WriteConfig();
	}
	public static void WriteConfig()
	{
		File.WriteAllText(SaveFileLocation.FullName, JsonConvert.SerializeObject(Config));
	}
    public static bool GetConfig()
	{
        if (SaveFileLocation.Directory!.Exists)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "JavaScript Object Notation Files (*.json)|*.json|All Files (*.*)|*.*",
                Title = "Save File"
            };

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter streamWriter = new(saveFileDialog.FileName))
				{
                    streamWriter.Write(File.ReadAllText(SaveFileLocation.FullName));
                    return true;
				}
			}
			else
			{
				return false;
			}
        }
		else
		{
			return false;
		}
	}
}
