namespace A1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parse input values
            if (double.TryParse(amountCost.Text, out double amount) && double.TryParse(amountPaid.Text, out double payment))
            {
                // Check for negative values
                if (amount < 0 || payment < 0)
                {
                    resultsLabel.Text = "Invalid amount or payment.";
                }
                // Check if payment is less than amount
                else if (payment < amount)
                {
                    resultsLabel.Text = "Payment is less than the total price.";
                }
                else
                {
                    // Calculate the change
                    int change = (int)(payment - amount);
                    resultsLabel.Text = GetChangeDescription(change);
                }
            }
            else
            {
                // If the input is not a valid number, show an error message
                resultsLabel.Text = "Please enter valid numbers!";
            }
        }

        private string GetChangeDescription(int amount)
        {
            // Define a dictionary to map each denomination value int to its string
            var denominations = new Dictionary<int, string>
            {
                { 500, "femhundralapp" },
                { 200, "tv�hundralapp" },
                { 100, "etthundralapp" },
                { 50, "femtiolapp" },
                { 20, "tjugolapp" },
                { 10, "tiokronor" },
                { 5, "femkronor" },
                { 1, "enkronor" }
            };
            //Create a list to store the change details
            List<string> changeList = new List<string>();

            // Loop through each denomination in descending order
            foreach (int key in denominations.Keys)
            {
            //Calculate how many of the current denomination can be given from the amount
                int count = amount / key;
            // If the denomination count is greater than 0 it means its part of the change
                if (count > 0)
                {
                //Update the remaining amount
                    amount %= key;
             //Add the formatted denomination count and name to the change list
                    changeList.Add($"{count} {denominations[key]}");
                }
            }

            return string.Join("\n", changeList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
