using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
using System.Media;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

namespace LAB_3
{
    public partial class Form1 : Form
    {

        string[] games = new string[] { "Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey" };
        string[] publisher = new string[] { "Bluehole", "Riotgames", "Activision", "Electronic Arts (EA)", "Nintendo" };
        int[] prices = new int[] { 35, 0, 60, 20, 60 };

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string userInput = txtUserInput.Text.ToLower();
            bool found = false;
            
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].ToLower().Contains(userInput) || publisher[i].ToLower().Contains(userInput))
                {
                    lblName.Text = games[i];
                    lblPublisher.Text = publisher[i];
                    lblPrice.Text = $"{prices[i]:C}";
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblName.Text = "Game not found";
                    lblPublisher.Text = "Game not found";
                    lblPrice.Text = "Game not found";
                }
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPublisher_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
