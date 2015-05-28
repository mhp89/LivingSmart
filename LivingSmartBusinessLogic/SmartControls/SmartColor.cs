using System.Drawing;

namespace SmartControls
{
	public static class SmartColor
	{
		public static Color Light = Color.FromArgb(255, 208, 208, 208);
		public static Color LightA25 = Color.FromArgb(255, 243, 243, 243);

		public static Color Dark = Color.FromArgb(255, 52, 52, 52);
		public static Color DarkA75 = Color.FromArgb(255, 103, 103, 103);

		public enum ColorStyle
		{
			Light,
			Dark
		}
	}
}
