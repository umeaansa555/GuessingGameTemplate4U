using System;
using System.Linq;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();

            //# of guesses
            numOfGuessesLabel.Text +=  Form1.guessList.Count.ToString();

            //original 
            for (int i = 0; i < Form1.guessList.Count(); i++)
            { originalGuessesLabel.Text += $" {Form1.guessList[i]}"; }

            //sorted order
            for (int i = 0; i < Form1.guessList.Count(); i++)
            {
                Form1.guessList.Sort();
                sortedGuessesLabel.Text += $" {Form1.guessList[i]}";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
