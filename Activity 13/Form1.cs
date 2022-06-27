using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * The application should use a two-dimensional int array to simulate the game board in memory. When the user clicks the New Game button, the application should step through the array, storing a random number in the range of 0 through 1 in each element. The number 0 represents the letter O, and the number 1 represents the letter X. The form should then be updated to display the game board. The application should display a message indicating whether player X won, player Y won, or the game was a tie.
 * 
 * Chris Peterson: Since this is not the mechanics of how Tic-Tac-Toe works, I'll attempt to provide 2 solutions, commaing out the conventional mechanics and keeping how it is documented.
 */

namespace Activity_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Random random = new Random();

        private void NewGameBTN_Click(object sender, EventArgs e)
        {

            int[][] array = //Set up Array
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };

            for (int i = 0; i < array.Length; i++) //Fill array with random
                for (int j = 0; j < array[i].Length; j++)
                    array[i][j] = random.Next(2);

            TopLeft.Text = ToText(array[0][0]);
            TopCenter.Text = ToText(array[0][1]);
            TopRight.Text = ToText(array[0][2]);

            MiddleLeft.Text = ToText(array[1][0]);
            MiddleCenter.Text = ToText(array[1][1]);
            MiddleRight.Text = ToText(array[1][2]);

            BottomLeft.Text = ToText(array[2][0]);
            BottomCenter.Text = ToText(array[2][1]);
            BottomRight.Text = ToText(array[2][2]);
                       

            string win = ""; //Determining Connections

            if (array[0][0] == array[0][1] && array[0][1] == array[0][2])
                win += array[0][0].ToString();

            if (array[1][0] == array[1][1] && array[1][1] == array[1][2])
                win += array[1][0].ToString();

            if (array[2][0] == array[2][1] && array[2][1] == array[2][2])
                win += array[2][0].ToString();

            if (array[0][0] == array[1][0] && array[1][0] == array[2][0])
                win += array[0][0].ToString();

            if (array[0][1] == array[1][1] && array[1][1] == array[2][1])
                win += array[0][1].ToString();

            if (array[0][2] == array[1][2] && array[1][2] == array[2][2])
                win += array[0][2].ToString();

            if (array[0][0] == array[1][1] && array[1][1] == array[2][2])
                win += array[0][0].ToString();

            if (array[2][0] == array[1][1] && array[1][1] == array[0][2])
                win += array[2][0].ToString();

            int Xwin = 0;
            int Owin = 0;
            char[] winChar = win.ToCharArray();
            for (int i = 0; i < winChar.Length; i++)
                switch (int.Parse(winChar[i].ToString()))
                {
                    case 0:
                        Owin++;
                        break;
                    case 1:
                        Xwin++;
                        break;
                }

            if (Xwin == 0 && Owin == 0)
                ResultsTB.Text = "No Winner!";
            else if (Xwin > Owin)
                ResultsTB.Text = "X Wins!";
            else if (Owin > Xwin)
                ResultsTB.Text = "O Wins!";
            else if (Xwin == Owin)
                ResultsTB.Text = "It's a Draw!";

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string ToText(int input) //Ease of use for the conversion to X and O
        {
            if (input == 0)
                return "O";
            else if (input == 1)
                return "X";
            else
                return "";
        }


    }
}
