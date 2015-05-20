using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Pages;
using LivingSmartForms.Views;
using SmartControls;
using Menu = LivingSmartForms.Classes.Menu;

namespace LivingSmartForms
{
    public partial class BaseForm : Form
	{
		#region Menu
		
	    private Page[] pages;
	    private Page activePage;
	    enum PagesIndex
	    {
		    Overview,
			Cases,
			Customers,
			Settings
	    }

		#endregion

		public BaseForm()
        {
			AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
			
			pages = new Page[Enum.GetNames(typeof(PagesIndex)).Length];

			pages[GetPageIndex(PagesIndex.Overview)]	= new Page(typeof(Overview),	"Oversigt",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Cases)]		= new Page(typeof(Cases),		"Sager",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Customers)]	= new Page(typeof(Overview),	"Kunder",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Settings)]	= new Page(typeof(Cases),		"Indstillinger",	Classes.Menu.MenuAnchor.Right);
			
			InitializePages();

			InitializeMenu();
		}


		#region Menu

	    private void InitializePages()
	    {
			foreach (Page page in pages)
			{
				page.PageView = Activator.CreateInstance(page.PageType, this) as BasePage;//Opretter en instance af en klasse udfra en Type

				if (page.PageView == null) continue;
				
				pnlInnerContent.Controls.Add(page.PageView);
				page.PageView.Dock = DockStyle.Fill;

				page.Button = AddMenuButton(page.Title, page.Anchor, MenuPageButtonClick);
			}
	    }

	    private int GetPageIndex(PagesIndex page)
	    {
		    return (int) page;
	    }
	    private void InitializeMenu()
	    {
		    //Lav andre knapper
			AddMenuButton("Log af", Classes.Menu.MenuAnchor.Right, MenuLogoutButtonClick);
			AddMenuButton("<", Classes.Menu.MenuAnchor.Right, MenuPartnersButtonClick, new Size(30, 30), Padding.Empty);
	    }

	    private MenuButton AddMenuButton(string content, Menu.MenuAnchor anchor, MouseEventHandler clickEvent)
	    {
		    return AddMenuButton(content, anchor, clickEvent, Size.Empty, Padding.Empty);
	    }
		private MenuButton AddMenuButton(string content, Menu.MenuAnchor anchor, MouseEventHandler clickEvent, Size fixedSize, Padding padding)
		{
			MenuButton button = new MenuButton();
			
			button.AutoSize = fixedSize == Size.Empty;
			if (fixedSize != Size.Empty)
			{
				button.Size = fixedSize;
				button.Padding = padding;
			}

			button.Text = content;
			button.MouseClick += clickEvent;

			if (anchor == Classes.Menu.MenuAnchor.Left)
				flpMenuLeft.Controls.Add(button);
			else
				flpMenuRight.Controls.Add(button);
			
			return button;
		}

		private void MenuPageButtonClick(object sender, EventArgs e)
		{
			MenuButton btn = (MenuButton)sender;

			DeselectButtons();

			foreach (Page page in pages)
			{
				if (page.Button == btn)
				{
					SetSelectedPage(page);
					break;
				}
			}
		}

		private void MenuLogoutButtonClick(object sender, EventArgs e)
		{
			MenuButton btn = (MenuButton)sender;

			//TODO: Log out
		}
		private void MenuPartnersButtonClick(object sender, EventArgs e)
		{
			MenuButton btn = (MenuButton)sender;

			btn.Selected = !btn.Selected;

			if (btn.Selected)
			{
				btn.Text = ">";
				var view = new PartnersDropIn(this);
				//F�r view'et til at fylde hele holderen
				view.Dock = DockStyle.Fill;
				pnlPartnersHolder.Controls.Add(view);
				//pnlPartnersHolder.BringToFront();

				/*//Flytter holderen s� den sidder i h�jre side
				pnlPartnersHolder.Location = new Point(Width - pnlPartnersHolder.Width, pnlPartnersHolder.Top);*/

			}
			else
			{
				btn.Text = "<";
				pnlPartnersHolder.Controls.Clear();
				//Nustiller st�rrelsen
				//pnlPartnersHolder.Size = new Size(0, pnlPartnersHolder.Height);
			}

			//Gentegner hele formen for at sikre korrekt design
			Refresh();
		}

		private void SetSelectedPage(PagesIndex page)
		{
			SetSelectedPage((int) page);
		}
		public void SetSelectedPage(int pageIndex)
		{
			SetSelectedPage(pages[pageIndex]);
		}
	    public void SetSelectedPage(Page page)
		{
			if (activePage != null)
				activePage.PageView.OnHide();

			HidePages();
			DeselectButtons();
			Text = "LivingSmart - " + page.Title;
			page.Button.Selected = true;
			page.PageView.BringToFront();
			page.PageView.Visible = true;
			page.PageView.OnShow();
			activePage = page;
	    }
		private void DeselectButtons()
		{
			foreach (Page page in pages)
				page.Button.Selected = false;
		}
		private void HidePages()
		{
			foreach (Page page in pages)
				page.PageView.Visible = false;
		}

		#endregion


		#region DropIn

	    public void ShowDropIn(UserControl view)
	    {
		    if (pnlDropInHolder.Controls.Count == 0)
		    {
				CloseDropIn();

			    var viewWidth = view.Width;

				//Tilf�jet view'et til holderen
				pnlDropInHolder.Controls.Add(view);
				//F�r view'et til at fylde hele holderen
				view.Dock = DockStyle.Fill;

				pnlDropInHolder.Width = viewWidth;

				//Flytter holderen s� den sidder i h�jre side
				pnlDropInHolder.Location = new Point(pnlMasterContent.Width - pnlDropInHolder.Width, pnlDropInHolder.Top);
		    }
		    else
		    {
				CloseDropIn();			    
		    }
	    }

	    public void CloseDropIn()
		{
			pnlDropInHolder.Controls.Clear();
			//Nustiller st�rrelsen
			pnlDropInHolder.Size = new Size(0, pnlDropInHolder.Height);

			Refresh();
	    }

		#endregion


		#region Window

		private void BaseForm_Load(object sender, EventArgs e)
		{
			SetSelectedPage(PagesIndex.Overview);

			pnlDropInHolder.BringToFront();
		}

		private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}
		
		private void BaseForm_ResizeEnd(object sender, EventArgs e)
		{
			//Gentegner hele formen for at sikre korrekt design
			Refresh();
		}
		
		#endregion
	}
}
