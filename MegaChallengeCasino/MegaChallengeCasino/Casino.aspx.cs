using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Casino : System.Web.UI.Page
    {
        Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] reels = new string[] { spin(), spin(), spin() };
                displayImages(reels);
                ViewState.Add("PlayerMoney", 100);
                displayMoney();
            }
        }

        private void displayMoney()
        {
            int money = (int)ViewState["PlayerMoney"];
            moneyLabel.Text = String.Format("Player's Money: {0:C}", money);
        }

        protected void Lever_Click(object sender, EventArgs e)
        {
            if ((int)ViewState["PlayerMoney"] < 0) restart();
            int bet = 0;
            if (!int.TryParse(BetBox.Text, out bet)) return;
            int winnings = pullLever(bet);
            displayWinnings(bet, winnings);
        }

        private void restart()
        {
            Lever.Text = "Pull The Lever!";
            ViewState.Add("PlayerMoney", 100);
        }

        private void displayWinnings(int bet, int winnings)
        {
            if (winnings > 0)
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            else
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", bet);
            displayMoney(bet, winnings);
        }

        private void displayMoney(int bet, int winnings)
        {
            int currentMoney = (int)ViewState["PlayerMoney"];
            int money = currentMoney - bet + winnings;
            ViewState.Add("PlayerMoney", money);
            moneyLabel.Text = String.Format("Player's Money: {0:C}", money);
            if (money == 0) youLose();
        }

        private void youLose()
        {
            Lever.Text = "Try Again!";
            moneyLabel.Text = "You Lose!";
            ViewState.Add("PlayerMoney", -5);
        }

        private int pullLever(int bet)
        {
            string[] reels = new string[] { spin(), spin(), spin() };
            displayImages(reels);
            return bet*getMultiplier(reels);
        }

        private int getMultiplier(string[] reels)
        {
            if (reels[0]=="Bar"||reels[1]=="Bar"||reels[2]=="Bar") return 0;
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven") return 100;
            if(getCherries(reels)>0) return getCherries(reels)+1;
            return 0;
        }

        private int getCherries(string[] reels)
        {
            int cherries = 0;
            for(int i = 0; i <= 2; i++)
            {
                if (reels[i] == "Cherry") cherries++;
            }
            return cherries;
        }

        private void displayImages(string[] reels)
        {
            Image1.ImageUrl = "/Images/" + reels[0] + ".png";
            Image2.ImageUrl = "/Images/" + reels[1] + ".png";
            Image3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private string spin()
        {   
            string[] images = new string[] {"Bar", "Bell", "Cherry",
                "Clover", "Diamond", "Horseshoe", "Lemon", "Orange",
                "Plum", "Seven", "Strawberry", "Watermelon"};
            return images[rand.Next(11)];
        }
    }
}