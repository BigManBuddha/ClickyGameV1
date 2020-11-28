using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClickyGameEngine.Models;
using System.Timers;



namespace ClickyGameV1
{
    public partial class Form1 : Form
    {
        double increase = 1;
        public Form1()
        {
            InitializeComponent();
            //Create a two lists of active and passive items
            List<ActiveItem> ActiveItems = new List<ActiveItem>();
            List<PassiveItem> PassiveItems = new List<PassiveItem>();
            // add titles to each listbox and set the id for each object to a constant value
            listbox_PassiveItems.Items.Add("Passive Items\n");
            listBox1.Items.Add("Active Items\n");
            const int AITEM_ID_2 = 1;
            const int AITEM_ID_4 = 2;
            const int AITEM_ID_8 = 3;
            const int AITEM_ID_16 = 4;
            const int AITEM_ID_32 = 5;
            const int AITEM_ID_64 = 6;
            const int AITEM_ID_128 = 7;
            const int AITEM_ID_256 = 8;
            const int AITEM_ID_512 = 9;
            const int AITEM_ID_1024 = 10;
            const int AITEM_ID_2048 = 11;

            const int PITEM_ID_01 = 1;
            const int PITEM_ID_05 = 2;
            const int PITEM_ID_1 = 3;
            const int PITEM_ID_17 = 4;
            const int PITEM_ID_43 = 5;
            const int PITEM_ID_65 = 6;
            const int PITEM_ID_74 = 7;
            const int PITEM_ID_106 = 8;
            const int PITEM_ID_123 = 9;
            const int PITEM_ID_154 = 10;
            const int PITEM_ID_20 = 11;
            // add an instantiations of objects to each list
            ActiveItems.Add(new ActiveItem(2, AITEM_ID_2, "Double Your Money: 500", 500));
            ActiveItems.Add(new ActiveItem(4, AITEM_ID_4, "Double Your Money: 1,000", 1000));
            ActiveItems.Add(new ActiveItem(8, AITEM_ID_8, "Double Your Money: 2,000", 2000));
            ActiveItems.Add(new ActiveItem(16, AITEM_ID_16, "Double Your Money: 4,000", 4000));
            ActiveItems.Add(new ActiveItem(32, AITEM_ID_32, "Double Your Money: 8,000", 8000));
            ActiveItems.Add(new ActiveItem(64, AITEM_ID_64, "Double Your Money: 16,000", 16000));
            ActiveItems.Add(new ActiveItem(128, AITEM_ID_128, "Double Your Money: 32,000", 32000));
            ActiveItems.Add(new ActiveItem(256, AITEM_ID_256, "Double Your Money: 64,000", 64000));
            ActiveItems.Add(new ActiveItem(512, AITEM_ID_512, "Double Your Money: 128,000", 128000));
            ActiveItems.Add(new ActiveItem(1024, AITEM_ID_1024, "Double Your Money: 256,000", 256000));
            ActiveItems.Add(new ActiveItem(2048, AITEM_ID_2048, "Double Your Money: 512,000", 512000));

            PassiveItems.Add(new PassiveItem(0.1, PITEM_ID_01, "Poverty Wages: 300", 300));
            PassiveItems.Add(new PassiveItem(0.5, PITEM_ID_05, "Pity Wages: 900", 900));
            PassiveItems.Add(new PassiveItem(1, PITEM_ID_1, "Minimum Wage: 1,500", 1500));
            PassiveItems.Add(new PassiveItem(1.7, PITEM_ID_17, "Living Wage: 2,000", 2000));
            PassiveItems.Add(new PassiveItem(4.3, PITEM_ID_43, "Graduate Earnings: 5,000", 5000));
            PassiveItems.Add(new PassiveItem(6.5, PITEM_ID_65, "Rising the Corporate Ranks: 9,000", 9000));
            PassiveItems.Add(new PassiveItem(7.4, PITEM_ID_74, "Managerial Position: 20,000", 20000));
            PassiveItems.Add(new PassiveItem(10.6, PITEM_ID_106, "On the Board: 50,000", 50000));
            PassiveItems.Add(new PassiveItem(12.3, PITEM_ID_123, "Successful Entrepeneur: 100,000", 100000));
            PassiveItems.Add(new PassiveItem(15.4, PITEM_ID_154, "Financial Independence: 250,000", 250000));
            PassiveItems.Add(new PassiveItem(20, PITEM_ID_20, "P Factory: 500,000", 500000));
            // show lists in listboxes
            foreach (ActiveItem activeItem in ActiveItems)
            {
                listBox1.Items.Add(activeItem);


            }
            foreach (PassiveItem passiveItem in PassiveItems)
            {
                listbox_PassiveItems.Items.Add(passiveItem);
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        { 
        }


        // when the 'click' button is pressed increase it by a value
        private void btn_Click_Click(object sender, EventArgs e)
        {
            if(lbl_clickValue.Text == "")
            {
                lbl_clickValue.Text = "0";
            }
            double clicks = 0;
            clicks = double.Parse(lbl_clickValue.Text);
            clicks += increase;
            lbl_clickValue.Text = clicks.ToString("#");
        }
        // when the 'surprise item' button is clicked increase the total amount of clicks by a set value between -1000 and 1000
        private void btn_SurpriseItem1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double amount = rnd.Next(-1000, 1000);
            double price = 500;

            SurpriseItem1 _surpiseItemAmount = new SurpriseItem1(amount, price);
            if (double.Parse(lbl_clickValue.Text) >= price)
            {
                lbl_clickValue.Text = ((double.Parse(lbl_clickValue.Text) - price) + amount).ToString("0.#");
                string description = string.Format("For a price of {0} clicks,\n you have gained a surprise click amount of \n{1} clicks!", price.ToString("0.#"), amount.ToString("0.0#")).ToString();
                lblDescription.Text = description;
            }
        }

        private void listbox_PassiveItems_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        // when the second 'surprise item' is clicked multiply it by a percentage value between -300% and 300%
        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Random rand2 = new Random();
            double percentage = rand.NextDouble() + rand2.Next(-2, 2);
            double price = 500;

            SurpriseItem2 _surpriseItem2 = new SurpriseItem2(percentage, price);
            if (double.Parse(lbl_clickValue.Text) >= price)
            {
                lbl_clickValue.Text = ((double.Parse(lbl_clickValue.Text) - price) + (double.Parse(lbl_clickValue.Text) * percentage)).ToString("0.#");
                string description = string.Format("For a price of {0} clicks,\n your clicks have increased by {1}%!", price.ToString("0.#"), (percentage * 100).ToString("0.0#")).ToString();
                lblDescription.Text = description;
            }
        }
        // when the 'buy' button is clicked buy a item from a list then remove it
        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            
                
            
            PassiveItem passiveItem = listbox_PassiveItems.SelectedItem as PassiveItem;
            ActiveItem activeItem = listBox1.SelectedItem as ActiveItem;
            double clicks = double.Parse(lbl_clickValue.Text);
            // if an active item is selected do the following
            if (listBox1.SelectedItem != null)
            {
                
                double cost = activeItem.Cost;
                increase = activeItem.ClickValueIncrease;
                lbl_clickValue.Text = (clicks - cost).ToString("#");
                
                lblDescription.Text = string.Format("Your {0} click purchase\n now makes each click worth\n {1} clicks!", cost, increase);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.ClearSelected();
                
            }
            //if a passive item is second do the following
            if (listbox_PassiveItems.SelectedItem != null)
            {

                
                double cost = passiveItem.Cost;
                double increment = passiveItem.PassiveClicks;
                lbl_clickValue.Text = (clicks - cost).ToString("#");
                lblDescription.Text = string.Format("You now have a passive income of\n {0} clicks per second!", increment);
                

                System.Timers.Timer timer1 = new System.Timers.Timer(1000);
                timer1.Elapsed += new ElapsedEventHandler(TimerEventProcessor);
                timer1.Enabled = true;
                timer1.AutoReset = true;
                timer1.Start();
                timer1.SynchronizingObject = this;
                void  TimerEventProcessor(object send, ElapsedEventArgs a)
                {
                    if (lbl_clickValue.Text == "")
                    {
                        lbl_clickValue.Text = "0";
                    }
                    lbl_clickValue.Text = (double.Parse(lbl_clickValue.Text) + increment).ToString();
                }
                listbox_PassiveItems.Items.Remove(listbox_PassiveItems.SelectedItem);
                listbox_PassiveItems.ClearSelected();







            }
           
            
              
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }  
}
