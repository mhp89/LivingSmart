using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartControls;

namespace LivingSmartForms.Classes
{
	public class Page
	{
		/// <summary>
		/// Sidens klassetype
		/// </summary>
		public Type PageType { get; private set; }
		/// <summary>
		/// Sidens UI view
		/// </summary>
		public BasePage PageView { get; set; }
		/// <summary>
		/// Titlen p� siden
		/// </summary>
		public String Title { get; private set; }
		/// <summary>
		/// Angiver hvilken side knappen er placeret i
		/// </summary>
		public Menu.MenuAnchor Anchor { get; private set; }
		/// <summary>
		/// Menuknappen til siden
		/// </summary>
		public MenuButton Button { get; set; }

		public Page(Type pageType, string title, Menu.MenuAnchor anchor)
		{
			PageType = pageType;
			Title = title;
			Anchor = anchor;
		}
	}
}
