using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Pages;
using SmartControls;
using Menu = LivingSmartForms.Classes.Menu;
using SmartColor = LivingSmartForms.Classes.SmartColor;

namespace LivingSmartForms
{
    public partial class BaseForm : Form
    {
	    private Stack<BaseDropIn> DropIns = new Stack<BaseDropIn>(); 
		
	    private Control partnerView;

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
			Settings
		}

		#endregion


		public BaseForm()
        {
			AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
			
			pages = new Page[Enum.GetNames(typeof(PagesIndex)).Length];

			pages[GetPageIndex(PagesIndex.Overview)]		= new Page(typeof(Overview),		"Oversigt",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Cases)]			= new Page(typeof(Cases),			"Sager",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Customers)]		= new Page(typeof(Customers),		"Kunder",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.EstateAgents)]	= new Page(typeof(EstateAgents),	"Mægler",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Partners)]		= new Page(typeof(Partners),		"Partner",			Classes.Menu.MenuAnchor.Left);
            pages[GetPageIndex(PagesIndex.OpenHouse)]       = new Page(typeof(OpenHouse),       "Åbent hus",        Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Settings)]		= new Page(typeof(Cases),			"Indstillinger",	Classes.Menu.MenuAnchor.Right);
			
			InitializePages();

			InitializeMenu();

			InitTestData();

			DefaultEstateAgent = EstateAgentController.Instance.ReadEstateAgent(1);
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
				if(partnerView == null)
					partnerView = new PartnersDropIn(this);
				//F�r view'et til at fylde hele holderen
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
			DropIns.Push(view);

			//Tilføjet view'et til holderen
			dropInHolder.Controls.Add(view);
			//Før view'et til at fylde hele holderen
			view.Dock = DockStyle.Fill;

			//pnlDropInHolder.Width = viewWidth;

			//Flytter holderen så den sidder i højre side
			dropInHolder.Location = new Point(pnlMasterContent.Width - dropInHolder.Width, dropInHolder.Top);
			dropInHolder.BringToFront();
	    }

	    public void CloseDropIn()
	    {
			pnlMasterContent.Controls.Remove(DropIns.Pop().Parent);

		    foreach (var dropIn in DropIns)
			    dropIn.Parent.Location = new Point(dropIn.Parent.Location.X + 50, dropIn.Parent.Location.Y);

		    //Nustiller st�rrelsen
			//pnlDropInHolder.Size = new Size(0, pnlDropInHolder.Height);

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
		private void BaseForm_SizeChanged(object sender, EventArgs e)
		{
			//Gentegner hele formen for at sikre korrekt design
			Refresh();
		}
		
		#endregion
        

	    private void InitTestData()
	    {
			var customerController = CustomerController.Instance;

		    customerController.MakeNewCustomer("Anders And", new DateTime(1956, 6, 6), "Andeby", 2412, "Anders@andeby.dk", "19560606");
			customerController.SaveActiveCustomer();

			customerController.MakeNewCustomer("Rip", new DateTime(1992, 4, 28), "Andeby", 7100, "Rip@andeby.dk", "19920428");
			customerController.SaveActiveCustomer();

			customerController.MakeNewCustomer("Rap", new DateTime(1992, 4, 28), "Andeby", 7100, "Rap@andeby.dk", "19921428");
			customerController.SaveActiveCustomer();

			customerController.MakeNewCustomer("Rup", new DateTime(1992, 4, 28), "Andeby", 7100, "Rup@andeby.dk", "19922428");
			customerController.SaveActiveCustomer();

			customerController.MakeNewCustomer("Fedtmule", new DateTime(1932, 11, 12), "Mouseton", 5500, "Fedtmule@Mouseton.dk", "19321112");
			customerController.SaveActiveCustomer();


			var estateAgentController = EstateAgentController.Instance;

			var estateAgent = estateAgentController.MakeNewEstateAgent("Anders And", "19560606", "Anders@andeby.dk", DateTime.Today);
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent("Rip", "19920428", "Rip@andeby.dk", DateTime.Today);
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent("Rap", "19921428", "Rap@andeby.dk", DateTime.Today);
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent("Rup", "19922428", "Rup@andeby.dk", DateTime.Today);
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent("Fedtmule", "19321112", "Fedtmule@mouseton.dk", DateTime.Today);
			estateAgentController.AddEstateAgent(estateAgent);
	    }
	}
}
