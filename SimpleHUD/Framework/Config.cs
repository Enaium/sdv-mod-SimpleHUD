using EnaiumToolKit.Framework.Utils;
using StardewModdingAPI;

namespace SimpleHUD.Framework
{
    public class Config
    {
        public SButton OpenSetting { get; set; } = SButton.H;
        public bool Enable { get; set; } = true;
        public string Title { get; set; } = "Simple HUD";
        
        public ColorUtils.NameType TextColor = ColorUtils.NameType.Aqua;
    }
}