using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePadMinusMinus;
public class Config
{
	public string DarkMode { get; set; } = "auto";
	public bool WordWrap {get; set;} = true;
	public bool Status { get; set; } = true;
	public bool ShowLinks { get; set; } = false;
	public bool AutoSave { get; set; } = false;
	public bool DiscordRPC { get; set; } = false;
	public bool RPCShowFileName { get; set; } = true;
	public bool RPCShowCharacters { get; set; } = true;
    // add more entries here
}
