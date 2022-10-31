namespace MidTerm_Practice
{
    public partial class Form1 : Form
    {

        int Counter = 0;

        Random Colour1 = new Random();
        Random Colour2 = new Random();
        Random Colour3 = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void numUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            numUpDown1.Maximum = 69;
            numUpDown1.Minimum = 0;

            if(numUpDown1.Value < 39)
            {
                this.BackColor = Color.FromArgb (69, 200, 32);
            }
            else if (numUpDown1.Value == 69)
            {
                this.Close();
            }
            else
            {
                this.BackColor = Color.DeepSkyBlue;
            }
        }

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 64, 88);
        }

        private void rBtn2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(132, 111, 47);
        }

        private void rBtn3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(69, 52, 32);
        }

        private void rBtn4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(42, 79, 201);
        }

        private void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 72, 244);
        }

        private void rBtn6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(69, 224, 128);
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //682 Left value for right side
            

            while (Counter < 5)
            {
                
                while(picLine.Left < 682)
                {
                    picLine.Left += 2;
                    picLine.Refresh();
                    System.Threading.Thread.Sleep(0);

                }
                
                while(picLine.Left > 12)
                {
                    picLine.Left -= 2;
                    picLine.Refresh();
                    System.Threading.Thread.Sleep(0);

                }
                

                Counter++;

            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Counter = 0;
        }

        private void btnSeizure_Click(object sender, EventArgs e)
        {
            
            while(Counter < 55)
            {
                

                int Seizure1 = Colour1.Next(0, 256);
                int Seizure2 = Colour2.Next(0, 256);
                int Seizure3 = Colour3.Next(0, 256);

                
                
                this.BackColor = Color.FromArgb(Seizure1, Seizure2, Seizure3);
                this.Refresh();
                System.Threading.Thread.Sleep(50);

                Counter++;
                
            }
            

        }
    }
}