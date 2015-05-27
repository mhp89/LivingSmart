using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Pages;
using LivingSmartForms.Views;
using SmartControls;
using Menu = LivingSmartForms.Classes.Menu;
using SmartColor = LivingSmartForms.Classes.SmartColor;

namespace LivingSmartForms
{
    public partial class BaseForm : Form
    {
	    private Stack<BaseDropIn> DropIns = new Stack<BaseDropIn>(); 

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

	    private Control partnerView;

		public BaseForm()
        {
			AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
			
			pages = new Page[Enum.GetNames(typeof(PagesIndex)).Length];

			pages[GetPageIndex(PagesIndex.Overview)]	= new Page(typeof(Overview),	"Oversigt",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Cases)]		= new Page(typeof(Cases),		"Sager",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Customers)]	= new Page(typeof(Customers),	"Kunder",			Classes.Menu.MenuAnchor.Left);
			pages[GetPageIndex(PagesIndex.Settings)]	= new Page(typeof(Cases),		"Indstillinger",	Classes.Menu.MenuAnchor.Right);
			
			InitializePages();

			InitializeMenu();

			InitTestData();
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

			/*foreach (var dropIn in DropIns)
				dropIn.Parent.Location = new Point(dropIn.Parent.Location.X - 50, dropIn.Parent.Location.Y);*/

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

		    /*foreach (var dropIn in DropIns)
			    dropIn.Parent.Location = new Point(dropIn.Parent.Location.X + 50, dropIn.Parent.Location.Y);*/

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
		
		#endregion
        
        private void BaseForm_SizeChanged(object sender, EventArgs e)
        {
            //Gentegner hele formen for at sikre korrekt design
            Refresh();
        }

	    private void InitTestData()
	    {
			var customerController = CustomerController.Instance;

			var customer = customerController.MakeNewCustomer();
			customerController.SetName(customer, "Anders And");
			customerController.SetTelephone(customer, "19560606");
			customerController.SetAddress(customer, "Andeby");
			customerController.SetDateOfBirth(customer, new DateTime(1956, 6, 6));
			customerController.SetCity(customer, 7100);
			customerController.SetEmail(customer, "Anders@andeby.dk");
			customerController.AddCustomer(customer);

			customer = customerController.MakeNewCustomer();
			customerController.SetName(customer, "Rip");
			customerController.SetTelephone(customer, "19920428");
			customerController.SetAddress(customer, "Andeby");
			customerController.SetDateOfBirth(customer, new DateTime(1992, 4, 28));
			customerController.SetCity(customer, 7100);
			customerController.SetEmail(customer, "Rip@andeby.dk");
			customerController.AddCustomer(customer);

			customer = customerController.MakeNewCustomer();
			customerController.SetName(customer, "Rap");
			customerController.SetTelephone(customer, "19921428");
			customerController.SetAddress(customer, "Andeby");
			customerController.SetDateOfBirth(customer, new DateTime(1992, 4, 28));
			customerController.SetCity(customer, 7100);
			customerController.SetEmail(customer, "Rap@andeby.dk");
			customerController.AddCustomer(customer);

			customer = customerController.MakeNewCustomer();
			customerController.SetName(customer, "Rup");
			customerController.SetTelephone(customer, "19922428");
			customerController.SetAddress(customer, "Andeby");
			customerController.SetDateOfBirth(customer, new DateTime(1992, 4, 28));
			customerController.SetCity(customer, 7100);
			customerController.SetEmail(customer, "Rup@andeby.dk");
			customerController.AddCustomer(customer);

			customer = customerController.MakeNewCustomer();
			customerController.SetName(customer, "Fedtmule");
			customerController.SetTelephone(customer, "19321112");
			customerController.SetAddress(customer, "Mouseton");
			customerController.SetDateOfBirth(customer, new DateTime(1932, 11, 12));
			customerController.SetCity(customer, 5500);
			customerController.SetEmail(customer, "Fedtmule@Mouseton.dk");
			customerController.AddCustomer(customer);



			var estateAgentController = EstateAgentController.Instance;

			var estateAgent = estateAgentController.MakeNewEstateAgent();
			estateAgentController.SetName(estateAgent, "Anders And");
			estateAgentController.SetTelephone(estateAgent, "19560606");
			estateAgentController.SetEmail(estateAgent, "Anders@andeby.dk");
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent();
			estateAgentController.SetName(estateAgent, "Rip");
			estateAgentController.SetTelephone(estateAgent, "19920428");
			estateAgentController.SetEmail(estateAgent, "Rip@andeby.dk");
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent();
			estateAgentController.SetName(estateAgent, "Rap");
			estateAgentController.SetTelephone(estateAgent, "19921428");
			estateAgentController.SetEmail(estateAgent, "Rap@andeby.dk");
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent();
			estateAgentController.SetName(estateAgent, "Rup");
			estateAgentController.SetTelephone(estateAgent, "19922428");
			estateAgentController.SetEmail(estateAgent, "Rup@andeby.dk");
			estateAgentController.AddEstateAgent(estateAgent);

			estateAgent = estateAgentController.MakeNewEstateAgent();
			estateAgentController.SetName(estateAgent, "Fedtmule");
			estateAgentController.SetTelephone(estateAgent, "19321112");
			estateAgentController.SetEmail(estateAgent, "Fedtmule@Mouseton.dk");
			estateAgentController.AddEstateAgent(estateAgent);
	    }
	}
}
