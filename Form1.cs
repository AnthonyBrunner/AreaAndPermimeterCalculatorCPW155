namespace AreaAndPermimeterCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Get user input from the Length and Width Text box
            string inputLength = lengthText.Text;
            string inputWidth = widthText.Text;

            // Convert data to an integer
            if (!int.TryParse(inputLength, out int length))
            {
                MessageBox.Show("Invalid length entry. Please enter a valid integer.");
                lengthText.Focus();  // Used to move the user back to the length textbox
                return;
            }

            if (!int.TryParse(inputWidth, out int width))
            {
                MessageBox.Show("Invalid width entry. Please enter a valid integer.");
                widthText.Focus();  // Used to move the user back to the width textbox
                return;
            }

            // Calculate the Area
            int area = length * width;
            
            // Calculate the Perimeter
            // The formula for perimeter of a rectangle (2 * width) + (2 * length)
            int perimeter = (2 * length) + (2 * width);       

            // Display results to the user
            areaText.Text = area.ToString();
            perimeterText.Text = perimeter.ToString();
        }
    }
}
