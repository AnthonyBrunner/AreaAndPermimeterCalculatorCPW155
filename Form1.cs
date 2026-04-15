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
            int length = Convert.ToInt32(inputLength);
            int width = Convert.ToInt32(inputWidth);

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
