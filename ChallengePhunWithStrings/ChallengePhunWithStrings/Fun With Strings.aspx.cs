using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Fun_With_Strings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Challenge 1
            string name = "Austin Chang";
            string backwards = "";
            for(int i = 0; i < name.Length; i++)
            {
                backwards += name[name.Length - i - 1];
            }
            BackwardsName.Text = backwards;
            //Challenge 2
            string list = "Luke,Leia,Han,Chewbacca";
            string[] separatedNames = list.Split(',');
            int length = separatedNames.Length;
            string[] reversedNames = new string[length];
            for(int j = 0; j < length; j++)
            {
                reversedNames[j] = separatedNames[length - j - 1];
            }
            string reverse = reversedNames[0];
            for(int k = 1; k < length; k++)
            {
                reverse = reverse + "," + reversedNames[k];
            }
            ReverseOrder.Text = reverse;
            //Challenge 3 (uses same list from challenge 2)
            string result = "";
            for(int l = 0; l < separatedNames.Length; l++)
            {
                int leftPad = (14 - separatedNames[l].Length) / 2;
                string temporary = separatedNames[l].PadLeft(leftPad+separatedNames[l].Length, '*');
                temporary = temporary.PadRight(14, '*');
                result += temporary;
                result += "<br />";
            }
            Label1.Text = result;
            //Challenge 4
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
            puzzle = puzzle.ToLower().Remove(10, 9);
            string[] puzzleArray = new string[puzzle.Length];
            for(int m = 0; m < puzzle.Length; m++)
            {
                puzzleArray[m] = puzzle[m].ToString();
                if (puzzleArray[m] == "z") puzzleArray[m] = "t";
            }
            puzzleArray[0] = puzzleArray[0].ToUpper();
            string puzzle2 = "";
            for (int n = 0; n < puzzle.Length; n++)
            {
                puzzle2 += puzzleArray[n];
            }
            Label2.Text = puzzle2;

        }
    }
}