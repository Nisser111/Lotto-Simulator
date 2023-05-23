namespace Lotto_simulation
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void WelcomeTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // clear every TextBox
                FirstNum.Text = String.Empty;
                SecoundNum.Text = String.Empty;
                ThirdNum.Text = String.Empty;
                FourthNum.Text = String.Empty;
                FivethNum.Text = String.Empty;
                SixthNum.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RandomNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // generate random numbers
                int[] tempGeneratedNum = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    int tempRandom = random.Next(1, 50);
                    while (tempGeneratedNum.Contains(tempRandom) == true)
                    {
                        tempRandom = random.Next(1, 50);
                    }
                    tempGeneratedNum[i] = tempRandom;
                }

                // assign numbers to textBox
                FirstNum.Text = tempGeneratedNum[0].ToString();
                SecoundNum.Text = tempGeneratedNum[1].ToString();
                ThirdNum.Text = tempGeneratedNum[2].ToString();
                FourthNum.Text = tempGeneratedNum[3].ToString();
                FivethNum.Text = tempGeneratedNum[4].ToString();
                SixthNum.Text = tempGeneratedNum[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JoinGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // clear all error statement
                ErrorLabel.Text = String.Empty;

                // load numbers from player
                int[] playerNumbers = new int[6];
                playerNumbers[0] = int.Parse(FirstNum.Text);
                playerNumbers[1] = int.Parse(SecoundNum.Text);
                playerNumbers[2] = int.Parse(ThirdNum.Text);
                playerNumbers[3] = int.Parse(FourthNum.Text);
                playerNumbers[4] = int.Parse(FivethNum.Text);
                playerNumbers[5] = int.Parse(SixthNum.Text);

                // check uniqueness numbers
                bool duplicateFlag = playerNumbers.Length != playerNumbers.Distinct().Count();
                if (duplicateFlag)
                {
                    ErrorLabel.Text = "Liczby nie mog¹ siê powtarzaæ.";
                    return;
                }

                // check numbers in range
                for (int i = 0; i < playerNumbers.Length; i++)
                {
                    if (playerNumbers[i] < 1 || playerNumbers[1] > 49)
                    {
                        ErrorLabel.Text = "Liczby musz¹ byæ z zakresu od 1 do 49.";
                        return;
                    }
                }




                // generate won numbers
                int[] wonNumbers = new int[6];

                /*//Test values 
                wonNumbers[0] = 1;
                wonNumbers[1] = 2;
                wonNumbers[2] = 3;
                wonNumbers[3] = 4;
                wonNumbers[4] = 5;
                wonNumbers[5] = 6;
                */

                for (int i = 0; i < 6; i++)
                {
                    int tempRandom = random.Next(1, 50);
                    while (wonNumbers.Contains(tempRandom) == true)
                    {
                        tempRandom = random.Next(1, 50);
                    }
                    wonNumbers[i] = tempRandom;
                }

                // check match number
                int matchedNumberScore = 0;
                for (int i = 0; i < 6; i++)
                {
                    foreach (int current in wonNumbers)
                    {
                        if (current == playerNumbers[i])
                        {
                            matchedNumberScore++;
                        }
                    }
                }

                // show result
                string resultMsg = string.Empty;

                switch (matchedNumberScore)
                {
                    case 0:
                        resultMsg = "Niestety siê nie uda³o, nie trafi³eœ ¿adnej lizczby.\nSpróbój ponownie!";
                        break;

                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        resultMsg = "GRATULACJE! Trafi³eœ " + matchedNumberScore + "/6 liczb.\nSpróbój ponownie!";
                        break;

                    case 6:
                        resultMsg = "GRATULACJE! Trafi³eœ wszystkie liczby. Wygra³eœ 2 000 000z³";
                        break;

                    default:
                        resultMsg = "Ops! Coœ posz³o nie tak, postaramy siê to jak najszybciej naprawiæ.\nSpróbój ponownie!";
                        break;
                }

                MessageBox.Show(resultMsg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}