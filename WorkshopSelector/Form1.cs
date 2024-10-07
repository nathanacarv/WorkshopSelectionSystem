namespace WorkshopSelector
{
    public partial class WorkshopSelectorForm : Form
    {
        public WorkshopSelectorForm()
        {
            InitializeComponent();
        }

        private void lbWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            // Variables to store selected workshop and location
            string workshop;
            string location;
            //price per workshop
            int stress = 1000;
            int timeMgmt = 800;
            int superSkills = 1500;
            int negotiation = 1300;
            int howToInterview = 500;
            //number of  days for each workshop
            int daysStress = 3;
            int daysTimeMgmt = 3;
            int daysSuperSkills = 3;
            int daysNegotiation = 5;
            int daysHowToInterview = 1;
            //lodging fees for different locations
            int austinRaleighFee = 150;
            int chicagoFee = 225;
            int dallasPhoenixFee = 175;
            int orlandoFee = 300;
            
     
            //variable to hold total cost
            int total;

            //check if a workshop is selected in the listbox
            if (ListBoxWorkshop.SelectedIndex != -1) 
            {
                //get selected workshop and location
                workshop = ListBoxWorkshop.SelectedItem.ToString();
                location = ListBoxLodging.SelectedItem.ToString();

                //determine total cost based on selected workshop and location
                switch (workshop) 
                {
                    case "Handling Stress":
                        lblRegistrationValue.Text = "$1000";
                        if (location == "Austin" || location == "Raleigh")
                        {
                            label1.Text = "$" + austinRaleighFee.ToString() + " X 3 days";
                            total = stress + (austinRaleighFee * daysStress);
                            label2.Text = "$" + total;
                        }else if (location == "Dallas" || location == "Phoenix")
                        {
                            label1.Text = "$" + dallasPhoenixFee.ToString() + " X 3 days";
                            total = stress + (dallasPhoenixFee * daysStress);
                            label2.Text = "$" + total;
                        }else if(location == "Chicago") 
                        {
                            label1.Text = "$" + chicagoFee.ToString() + " X 3 days";
                            total = stress + (chicagoFee * daysStress);
                            label2.Text = "$" + total;
                        }else if (location == "Orlando")
                        {
                            label1.Text = "$" + orlandoFee.ToString() + " X 3 days";
                            total = stress + (orlandoFee * daysStress);
                            label2.Text = "$" + total;
                        }
                        break;

                    case "Time Management":
                        lblRegistrationValue.Text = "$800";
                        if (location == "Austin" || location == "Raleigh")
                        {
                            label1.Text = "$" + austinRaleighFee.ToString() + " X 3 days";
                            total = timeMgmt + (austinRaleighFee * daysTimeMgmt);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Dallas" || location == "Phoenix")
                        {
                            label1.Text = "$" + dallasPhoenixFee.ToString() + " X 3 days";
                            total = timeMgmt + (dallasPhoenixFee * daysTimeMgmt);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Chicago")
                        {
                            label1.Text = "$" + chicagoFee.ToString() + " X 3 days";
                            total = timeMgmt + (chicagoFee * daysTimeMgmt);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Orlando")
                        {
                            label1.Text = "$" + orlandoFee.ToString() + " X 3 days";
                            total = timeMgmt + (orlandoFee * daysTimeMgmt);
                            label2.Text = "$" + total;
                        }
                        break;

                    case "Supervision Skills":
                        lblRegistrationValue.Text = "$1500";
                        if (location == "Austin" || location == "Raleigh")
                        {
                            label1.Text = "$" + austinRaleighFee.ToString() + " X 3 days";
                            total = superSkills + (austinRaleighFee * daysSuperSkills);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Dallas" || location == "Phoenix")
                        {
                            label1.Text = "$" + dallasPhoenixFee.ToString() + " X 3 days";
                            total = superSkills + (dallasPhoenixFee * daysSuperSkills);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Chicago")
                        {
                            label1.Text = "$" + chicagoFee.ToString() + " X 3 days";
                            total = superSkills + (chicagoFee * daysSuperSkills);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Orlando")
                        {
                            label1.Text = "$" + orlandoFee.ToString() + " X 3 days";
                            total = superSkills + (orlandoFee * daysSuperSkills);
                            label2.Text = "$" + total;
                        }
                        break;

                    case "Negotiation":
                        lblRegistrationValue.Text = "$1300";
                        if (location == "Austin" || location == "Raleigh")
                        {
                            label1.Text = "$" + austinRaleighFee.ToString() + " X 5 days";
                            total = negotiation + (austinRaleighFee * daysNegotiation);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Dallas" || location == "Phoenix")
                        {
                            label1.Text = "$" + dallasPhoenixFee.ToString() + " X 5 days";
                            total = negotiation + (dallasPhoenixFee * daysNegotiation);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Chicago")
                        {
                            label1.Text = "$" + chicagoFee.ToString() + " X 5 days";
                            total = negotiation + (chicagoFee * daysNegotiation);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Orlando")
                        {
                            label1.Text = "$" + orlandoFee.ToString() + " X 5 days";
                            total = negotiation + (orlandoFee * daysNegotiation);
                            label2.Text = "$" + total;
                        }
                        break;

                    case "How to Interview":
                        lblRegistrationValue.Text = "$500";
                        if (location == "Austin" || location == "Raleigh")
                        {
                            label1.Text = "$" + austinRaleighFee.ToString() + " X 1 days";
                            total = howToInterview + (austinRaleighFee * daysHowToInterview);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Dallas" || location == "Phoenix")
                        {
                            label1.Text = "$" + dallasPhoenixFee.ToString() + " X 1 days";
                            total = howToInterview + (dallasPhoenixFee * daysHowToInterview);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Chicago")
                        {
                            label1.Text = "$" + chicagoFee.ToString() + " X 1 days";
                            total = howToInterview + (chicagoFee * daysHowToInterview);
                            label2.Text = "$" + total;
                        }
                        else if (location == "Orlando")
                        {
                            label1.Text = "$" + orlandoFee.ToString() + " X 1 days";
                            total = howToInterview + (orlandoFee * daysHowToInterview);
                            label2.Text = "$" + total;
                        }
                        break;

                }


            }
        }

    }
}
