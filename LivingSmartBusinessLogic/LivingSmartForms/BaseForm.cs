using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Pages;
using SmartControls;
using Menu = LivingSmartForms.Classes.Menu;

namespace LivingSmartForms
{
	/// <summary>
	/// BaseForm der styre hele systemet
	/// </summary>
	/// <author>Mathias Petersen</author>
    public partial class BaseForm : Form
    {
		/// <summary>
		/// Indikerer om der skal ske et form skift, når vinduet lukkes
		/// </summary>
	    private bool formShift;

	    private FormWindowState lastState;

		/// <summary>
		/// En liste af de aktive DropIns
		/// </summary>
	    private List<BaseDropIn> DropIns = new List<BaseDropIn>(); 

	    private Control partnerView;

		/// <summary>
		/// Den mægler der er logget ind
		/// </summary>
		public EstateAgent DefaultEstateAgent { get; private set; }

		#region Menu

		private Page[] pages;
		private Page activePage;
		enum PagesIndex
		{
			Overview,
			Cases,
            OpenHouse,
			Customers,
			EstateAgents,
			Partners,
		}

		#endregion


		public BaseForm(EstateAgent estateAgent)
        {
			AutoScaleMode = AutoScaleMode.None;
			
            DefaultEstateAgent = estateAgent;

            InitializeComponent();

			InitializeSystem();
			
			pages = new Page[Enum.GetNames(typeof(PagesIndex)).Length];

			pages[GetPageIndex(PagesIndex.Overview)]		= new Page(typeof(Overview),		"Oversigt",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Cases)]			= new Page(typeof(Cases),			"Sager",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Customers)]		= new Page(typeof(Customers),		"Kunder",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.EstateAgents)]	= new Page(typeof(EstateAgents),	"Mæglere",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Partners)]		= new Page(typeof(Partners),		"Partnere",			Classes.Menu.MenuAnchor.Left);
            pages[GetPageIndex(PagesIndex.OpenHouse)]       = new Page(typeof(OpenHousePage),   "Åbent hus",        Classes.Menu.MenuAnchor.Left);
			
			InitializePages();

			InitializeMenu();
        }

	    private void InitializeSystem()
	    {
	    	if (RegistryWrapper.RegKey.GetValue("DatabaseConnection") == null)
				RegistryWrapper.RegKey.SetValue("DatabaseConnection", "Data Source=(local); Initial Catalog=LivingSmart; Integrated Security=SSPI; MultipleActiveResultSets=true");


	        if (RegistryWrapper.RegKey.GetValue("WindowState") != null)
	        {
	            WindowState =
					(FormWindowState)Enum.Parse(typeof(FormWindowState), RegistryWrapper.RegKey.GetValue("WindowState") as string);
	            lastState = WindowState;
	        }
	    }

		#region Menu

		/// <summary>
		/// Tilføjer sider til formen, og tilføjer knapper til menuen
		/// </summary>
	    private void InitializePages()
	    {
			foreach (Page page in pages)
			{
				page.PageView = Activator.CreateInstance(page.PageType, this) as BasePage;//Opretter en instance af en klasse ud fra en Type

				if (page.PageView == null) continue;
				
				pnlInnerContent.Controls.Add(page.PageView);
				page.PageView.Dock = DockStyle.Fill;

				page.Button = AddMenuButton(page.Title, page.Anchor, MenuPageButtonClick);
			}
	    }

		/// <summary>
		/// Finder indexet for en side ud fra enumen PagesIndex
		/// </summary>
	    private int GetPageIndex(PagesIndex page)
	    {
		    return (int) page;
	    }

		/// <summary>
		/// Opsætter resten af menuen, der ikke er forbundet til en side
		/// </summary>
	    private void InitializeMenu()
	    {
		    //Lav andre knapper
			AddMenuButton("Indstillinger", Classes.Menu.MenuAnchor.Right, null);
            AddMenuButton("Log af", Classes.Menu.MenuAnchor.Right, MenuLogoutButtonClick);
			AddMenuButton("<", Classes.Menu.MenuAnchor.Right, MenuPartnersButtonClick, new Size(30, 30), Padding.Empty);
	    }

		/// <summary>
		/// Tilføjer en knap til menuen
		/// </summary>
		/// <param name="content">Knappens tekst</param>
		/// <param name="anchor">Hvilken side knappen skal være i</param>
		/// <param name="clickEvent">Eventhandleren der skal tilføjes til knappen</param>
	    private MenuButton AddMenuButton(string content, Menu.MenuAnchor anchor, MouseEventHandler clickEvent)
	    {
		    return AddMenuButton(content, anchor, clickEvent, Size.Empty, Padding.Empty);
	    }

	    /// <summary>
	    /// Tilføjer en knap til menuen
	    /// </summary>
	    /// <param name="content">Knappens tekst</param>
	    /// <param name="anchor">Hvilken side knappen skal være i</param>
	    /// <param name="clickEvent">Eventhandleren der skal tilføjes til knappen</param>
	    /// <param name="fixedSize">Angiver en bestemt størrelse for knappen</param>
		/// <param name="padding">Angiver en bestemt padding for knappen</param>
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
            if (clickEvent != null)
			    button.MouseClick += clickEvent;

			if (anchor == Classes.Menu.MenuAnchor.Left)
				flpMenuLeft.Controls.Add(button);
			else
				flpMenuRight.Controls.Add(button);
			
			return button;
		}

		/// <summary>
		/// Eventhandler for knapper relateret til en side
		/// </summary>
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

		/// <summary>
		/// Logger ud og åbner Log Ind formen
		/// </summary>
		private void MenuLogoutButtonClick(object sender, EventArgs e)
		{
			formShift = true;
			Login.ClearAutomaticLogin();
			FormHandler.ShowLoginForm();
			Close();
		}

		/// <summary>
		/// Åbner eller lukker partner dropin'et
		/// </summary>
		private void MenuPartnersButtonClick(object sender, EventArgs e)
		{
			MenuButton btn = (MenuButton)sender;

			btn.Selected = !btn.Selected;

			if (btn.Selected)
			{
				btn.Text = ">";
				if(partnerView == null)
					partnerView = new PartnersDropIn(this);
				//Får view'et til at fylde hele holderen
				partnerView.Dock = DockStyle.Fill;
				pnlPartnersHolder.Controls.Add(partnerView);
			}
			else
			{
				btn.Text = "<";
				pnlPartnersHolder.Controls.Clear();
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

		/// <summary>
		/// Tilføjer et DropIn til vinduet, og placerer det foran alt andet
		/// </summary>
	    public void ShowDropIn(BaseDropIn view)
		{
			var viewWidth = view.Width;

		    foreach (var dropIn in DropIns)
		    {
			    if(dropIn.GetDropInId() == view.GetDropInId())
					return;
		    }

			foreach (var dropIn in DropIns)
				dropIn.Parent.Location = new Point(dropIn.Parent.Location.X - 50, dropIn.Parent.Location.Y);

			var dropInHolder = new Panel
			{
				BackColor = SmartColor.Light,
				Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right,
				Size = new Size(viewWidth, pnlMasterContent.Height)
			};

			pnlMasterContent.Controls.Add(dropInHolder);

			//Tilføjer dropin'et til stack'en
			DropIns.Add(view);

			//Tilføjet view'et til holderen
			dropInHolder.Controls.Add(view);
			//Før view'et til at fylde hele holderen
			view.Dock = DockStyle.Fill;
			
			//Flytter holderen så den sidder i højre side
			dropInHolder.Location = new Point(pnlMasterContent.Width - dropInHolder.Width, dropInHolder.Top);
			dropInHolder.BringToFront();
	    }

		/// <summary>
		/// Lukker et bestemt DropIn
		/// </summary>
	    public void CloseDropIn(BaseDropIn baseDropIn)
	    {
		    var dropInX = baseDropIn.Parent.Location.X;
			pnlMasterContent.Controls.Remove(baseDropIn.Parent);
		    DropIns.Remove(baseDropIn);

		    foreach (var dropIn in DropIns)
				if(dropIn.Parent.Location.X < dropInX)
					dropIn.Parent.Location = new Point(dropIn.Parent.Location.X + 50, dropIn.Parent.Location.Y);
			
			Refresh();
	    }

		#endregion


		#region Window

		private void BaseForm_Load(object sender, EventArgs e)
		{
			SetSelectedPage(PagesIndex.Overview);

            Activate();
		}

		private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!formShift)
				Environment.Exit(Environment.ExitCode);
		}
		private void BaseForm_SizeChanged(object sender, EventArgs e)
		{
			//Gentegner hele formen for at sikre korrekt design
			Refresh();
            if (WindowState != lastState)
		    {
				RegistryWrapper.RegKey.SetValue("WindowState", WindowState);
		        lastState = WindowState;
		    }
		    
		}
		
		#endregion
	}
}
