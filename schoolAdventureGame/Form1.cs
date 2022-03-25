using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolAdventureGame
{
    public partial class Form1 : Form
    {

        string ben;
        string shirt;
        string pants;
        int page = 0;
        int randomChance;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 0)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 31;
            }
            else if (page == 41)
            {
                page = 44;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 19)
            {
                page = 33;
            }
            else if (page == 39)
            {
                page = 40;
            }
            else if (page == 42)
            {
                page = 47;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 26;
            }
            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 33;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 36)
            {
                page = 99;
            }
            else if (page == 38)
            {
                page = 99;
            }
            else if (page == 40)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 47)
            {
                page = 99;
            }
            else if (page == 44)
            {
                page = 99;
            }
            else if (page == 46)
            {
                page = 99;
            }
            else if (page == 45)
            {
                page = 99;
            }
            else if (page == 30){
                page = 99;
            }

            displayPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                shirt = "tshirt";
                page = 2;
            }
            else if (page == 2)
            {
                pants = "Jeans";
                page = 3;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 14;
            }
            else if (page == 14 && randomChance > 5)
            {
                page = 15;
            }
            else if (page == 14 && randomChance < 6)
            {
                page = 21;
            }
            else if ((page == 21) && (shirt == "tshirt") && (pants == "jogging pants"))
            {
                page = 23;
            }
            else if ((page == 21) && (shirt != "tshirt") || (pants != "jogging pants"))
            {
                page = 24;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 31)
            {
                page = 33;
            }
            else if (page == 33)
            {
                page = 34;
            }
            else if (page == 35)
            {
                page = 36;
            }
            else if (page == 37)
            {
                page = 39;
            }
            else if (page == 26 && randomChance > 5)
            {
                page = 29;
            }
            else if (page == 26 && randomChance < 6)
            {
                page = 30;
            }
            else if (page == 41)
            {
                page = 42;
            }
            else if (page == 43)
            {
                page = 45;
            }
            else if (page == 99)
            {
                page = 0;
            }
            displayPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                shirt = "tshirt";
                page = 2;
            }
            else if (page == 2)
            {
                pants = "jogging pants";
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 7)
            {
                page = 14;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 26)
            {
                page = 41;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 41)
            {
                page = 43;
            }
            else if (page == 43)
            {
                page = 46;
            }

            else if (page == 14)
            {
                page = 26;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 15 && ben == "yes")
            {
                page = 18;
            }
            else if (page == 15 && ben == "no")
            {
                page = 17;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 31)
            {
                page = 32;
            }
            else if (page == 33)
            {
                page = 35;
            }
            else if (page == 35)
            {
                page = 37;
            }
            else if (page == 37)
            {
                page = 38;
            }
            else if (page == 99)
            {
                page = 0;
            }

            displayPage();
        }

        void displayPage()
        {
            switch (page)
            {
                case 0:
                    mainImage.Image = Properties.Resources.page_0;
                    break;

                case 1:
                    titleLabel.Text = "";
                    titleLabel.Visible = false;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Enabled = false;
                    button3.Visible = false;
                    mainImage.Visible = false;
                    image1.Visible = true;
                    image2.Visible = true;

                    image1.BackgroundImage = Properties.Resources.page1;
                    image2.BackgroundImage = Properties.Resources.page1b;

                    outputLabel.Text = "It's your first day of school. \n\nWhat will you wear?";
                    break;

                case 2:
                    outputLabel.Text = "And what pants?";

                    image1.BackgroundImage = Properties.Resources.page2;
                    image2.BackgroundImage = Properties.Resources.page2b;
                    break;

                case 3:
                    outputLabel.Text = "You're finally ready to leave. \n\nTake the bus or walk?";
                    image2.BackgroundImage = Properties.Resources.bus;
                    image1.BackgroundImage = Properties.Resources.walk;

                    button1.Text = "Walk";
                    button2.Text = "Take the bus";
                    break;

                case 4:
                    outputLabel.Text = "On the bus you have a choice. \n\nFront of the bus or back of the bus?";
                    
                    mainImage.Visible = true;
                    mainImage.BackgroundImage = Properties.Resources.inside_of_bus;
                    image1.Visible = false;
                    image2.Visible = false;
                    
                    button1.Text = "Front";
                    button2.Text = "Back";
                    break;

                case 5:
                    outputLabel.Text = "You meet a kid named Ben.\n\nDo you want to be friends with him?";

                    mainImage.BackgroundImage = Properties.Resources.ben;
                    break;
                case 6:
                    outputLabel.Text = "The bus hits a bump and you fly out of your seat \n\nYou hit your head on the roof and die.";

                    mainImage.BackgroundImage = Properties.Resources.death1;
                    button3.Enabled = true;
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button1.Visible = false;
                    button2.Visible = false; 

                    button3.Text = "Continue";
                    break;
                case 7:
                    outputLabel.Text = "You're a little early. \n\nTake the scenic route or direct route?";

                    mainImage.BackgroundImage = Properties.Resources.sidewalk;
                    button1.Text = "Scenic Route";
                    button2.Text = "Direct Route";
                    break;
                case 8:
                    outputLabel.Text = "After deciding to take the scenic route, you find yourself running late \n\nCut though someones backyard?";

                    mainImage.BackgroundImage = Properties.Resources.backyard;

                    button1.Text = "No";
                    button2.Text = "Yes";
                    break;
                case 9:
                    outputLabel.Text = "You get caught running through someone's backyard \n\nRun away or try to talk to them?";

                    mainImage.BackgroundImage = Properties.Resources.angry;

                    button1.Text = "Talk it out";
                    button2.Text = "Run away";
                    break;
                case 10:
                    outputLabel.Text = "They chase you and you come to a dark alley \n\nStop and talk to them or continue down alley?";

                    mainImage.BackgroundImage = Properties.Resources.alley;

                    button1.Text = "Stop and talk";
                    button2.Text = "Continue down alley";

                    break;



            }
        }

    }
}

