using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.Pages
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Maja Olesen</author>
	public partial class OpenHousePage : BasePage
	{
        public List<EstateAgent> agents = new List<EstateAgent>();
        public List<Case> properties = new List<Case>();
        public List<KeyValuePair<decimal, Case>> priceCasePair = 
            new List<KeyValuePair<decimal, Case>>();
        public Dictionary<EstateAgent, List<Case>> openHousePairs =
            new Dictionary<EstateAgent, List<Case>>();

		public OpenHousePage(BaseForm baseForm) : base(baseForm)
		{
			InitializeComponent();
		}

		private void btnSelectEstateAgents_Click(object sender, EventArgs e)
		{
			baseForm.ShowDropIn(new SelectEstateAgentDropIn(baseForm, EstateAgentList));
        }

        private void btnSelectProperties_Click(object sender, EventArgs e)
        {
            baseForm.ShowDropIn(new SelectPropertyDropIn(baseForm, PropertyList));
        }

        /// <summary>
        /// Får en liste med valgte mæglere fra drop in menuen for valg af mæglere
        /// </summary>
        /// <param name="agents"></param>
        private void EstateAgentList(List<EstateAgent> agents)
        {
            this.agents = agents;
        }
        /// <summary>
        /// Får en liste med valgte ejendomme fra drop in menuen for valg af ejendomme
        /// </summary>
        /// <param name="properties"></param>
        private void PropertyList(List<Case> properties)
        {
            this.properties = properties;
        }

        /// <summary>
        /// Knappen opretter en instans af OpenHouse klassen og kalder metoden
        /// ReturnOpenHouseEvenly. Information herfra indsættes i openHousePairs variablen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeSelection_Click(object sender, EventArgs e)
        {
            foreach (Case cases in properties)
                priceCasePair.Add(new KeyValuePair<decimal, Case>(1200000, cases));
                //priceCasePair.Add(new KeyValuePair<decimal, Case>(Convert.ToDecimal(cases.NewestAskingPrice), cases));        

            OpenHouse openHouse = new OpenHouse(agents, priceCasePair);

            openHousePairs = openHouse.ReturnOpenHouseEvenly();
            UpdateList();
        }

        /// <summary>
        /// Opdaterer control OpenHousePair med information om mægler og ejendomme
        /// </summary>
        private void UpdateList()
        {
            ctcOpenHouse.SuspendLayout();

            ctcOpenHouse.ClearList();
            foreach (var pair in openHousePairs)
            {
                var control = new OpenHousePair(pair.Key, pair.Value);
                control.Margin = Padding.Empty;
                ctcOpenHouse.AddControl(control, true);
            }

            ctcOpenHouse.ResumeLayout();
        }
	}
}
