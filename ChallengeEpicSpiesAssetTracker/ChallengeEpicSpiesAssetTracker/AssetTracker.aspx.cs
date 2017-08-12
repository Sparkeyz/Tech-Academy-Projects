using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class AssetTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetNames = new string[0];
                int[] riggedElections = new int[0];
                int[] actsOfSubterfuge = new int[0];
                ViewState.Add("Assets", assetNames);
                ViewState.Add("Elections", riggedElections);
                ViewState.Add("Subterfuge", actsOfSubterfuge);
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] subterfuge = (int[])ViewState["Subterfuge"];
            int length = assets.Length + 1;

            Array.Resize(ref assets, length);
            Array.Resize(ref elections, length);
            Array.Resize(ref subterfuge, length);

            int index = assets.GetUpperBound(0);
            assets[index] = Name.Text;
            elections[index] = int.Parse(Rigs.Text);
            subterfuge[index] = int.Parse(Subterfuges.Text);

            Label1.Text = String.Format("Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge Per Asset: {1:N2}<br />" +
                "Last Asset You Added: {2}", elections.Sum(), subterfuge.Average(), assets[index]);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;

            Name.Text = "";
            Rigs.Text = "";
            Subterfuges.Text = "";
        }
    }
}