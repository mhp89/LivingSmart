using System.Drawing;

namespace LivingSmartForms.Classes
{
	public static class SmartColor
	{
		public static Color Light = Color.FromArgb(255, 208, 208, 208);
		public static Color LightA25 = Color.FromArgb(64, 208, 208, 208);

		public static Color Dark = Color.FromArgb(255, 52, 52, 52);
		public static Color DarkA25 = Color.FromArgb(64, 52, 52, 52);
		public static Color DarkA10 = Color.FromArgb(25, 52, 52, 52);

		public enum ColorStyle
		{
			Light,
			Dark
		}
	}
}
