namespace WindowA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelHome.Visible = true;
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous label texts before validation
            labelfirstName.Text = "";
            labelLastName.Text = "";
            labelPnr.Text = "";
            labelGender.Text = "";

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string pnr = textBox3.Text;

            Person person = new Person(firstName, lastName, pnr);

            // Validate first name
            if (string.IsNullOrEmpty(person.FirstName) || !person.HasNoNumbers(person.FirstName))
            {
                labelfirstName.Text = $"Ogiltligt!";
                return;
            }

            // Validate last name
            if (string.IsNullOrEmpty(person.LastName) || !person.HasNoNumbers(person.LastName))
            {
                labelLastName.Text = $"Ogiltligt!";
                return; 
            }

            // Validate personal number
            if (!person.IsValidPersonnummer())
            {
                labelPnr.Text = $"Ogiltligt!";
                return;
            }

            labelfirstName.Text = $"F�rnamn: {person.FirstName}";
            labelLastName.Text = $"Efternamn: {person.LastName}";
            labelPnr.Text = $"Person Nummer: {person.Personnummer}";
            labelGender.Text = $"K�n: {person.Gender}";
        }
        //Exit application menu button
        private void L�mmnaMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Display registration form menu button
        private void RegMenuItem_Click(object sender, EventArgs e)
        {   //set panelHome visible to false to hide panel and to show registration from
            panelHome.Visible = false;
            label4.Visible = false;
        }
        //Display Home page menu button
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {   //set panelHome visible to true to show panel and to hide registration from
            panelHome.Visible = true;
            label4.Visible = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear all of the textboxes and resets the labels
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            labelfirstName.Text = $"F�rnamn:";
            labelLastName.Text = $"Efternamn:";
            labelPnr.Text = $"Person Nummer:";
            labelGender.Text = $"K�n:";
        }
    }

    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Personnummer { get; private set; }
        public string Gender => GetGender();

        public Person(string firstName, string lastName, string personnummer)
        {
            FirstName = firstName;
            LastName = lastName;
            Personnummer = personnummer.Replace("-", "");
        }
        //Check if string contatins numbers
        public bool HasNoNumbers(string input) => !input.Any(char.IsDigit);

        // Function that validates personnummer
        public bool IsValidPersonnummer()
        {
            //we check the length of pnr and if it contains only numeric characters
            if (Personnummer.Length != 10 || !long.TryParse(Personnummer, out _))
                return false;

            int sum = 0; //variable to store sum
            //itereate trough first 9 values of pnr
            for (int i = 0; i < 9; i++)
            {
                //Parse i to string
                int digit = int.Parse(Personnummer[i].ToString());
                // Multiply digit by 2 if its position is even or by 1 if odd
                int product = digit * (i % 2 == 0 ? 2 : 1);
                // If the product is greater than 9, subtract 9 from it 
                sum += product > 9 ? product - 9 : product;
            }
            // Calculate the control digit by taking the remainder of the sum mod 10 and subtracting from 10
            int controlDigit = (10 - (sum % 10)) % 10;
            // Parse the last digit of pnr
            int lastDigit = int.Parse(Personnummer[9].ToString());
            return lastDigit == controlDigit;
        }
        
        private string GetGender()
        {
            // Check if the personummer is too short to contain gender info.
            if (Personnummer.Length < 10)
                return "Unknown";

            int secondToLastDigit; // Variable to store the second-to-last digit

            // Attempt to parse the second-to-last character as an integer.
            if (int.TryParse(Personnummer[Personnummer.Length - 2].ToString(), out secondToLastDigit))
                // If parsing is successful, check if the digit is even or odd to determine gender.
                // Even numbers represent Kvinna, odd numbers represent Man
                return secondToLastDigit % 2 == 0 ? "Kvinna" : "Man";

            return "Unknown";
        }

    }
}
