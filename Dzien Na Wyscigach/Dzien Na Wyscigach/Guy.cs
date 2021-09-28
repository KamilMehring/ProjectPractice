using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzien_Na_Wyscigach
{
    public class Guy
    {
        public string Name; 
        public Bet MyBet = new Bet();
        public int Cash;

        public RadioButton MyRadioButton; 
        public Label MyLabel;

        public Guy()
        {
            MyBet.Bettor = this;
        }

        public void UpdateLabels()
        {
           
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet() 
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
     
            if (Cash >= Amount)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = DogToWin;
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(Name + " nie ma wystarczająco pieniędzy by postawić taki zakład", "Brak funduszy");
                return false;
            }
        }

        public void Collect(int Winner)
        {
          
            Cash += MyBet.PayOut(Winner);
        }
    }
}