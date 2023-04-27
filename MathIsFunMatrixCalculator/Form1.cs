using MathNet.Numerics.LinearAlgebra;


namespace MathIsFunMatrixCalculator
{
    public partial class Form1 : Form
    {
        Matrix<double> MatrixA;
        Matrix<double> MatrixB;
        Matrix<double> MatrixC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatrixAUpArrow_Click(object sender, EventArgs e)
        {

        }

        private void MatrixAColumnTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MatrixARowTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MatrixBColumnTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MatrixBRowTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMatrixADownArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixALeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixARightArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixBUpArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixBDownArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixBLeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixBRightArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnAPlusB_Click(object sender, EventArgs e)
        {

        }

        private void btnAMinusB_Click(object sender, EventArgs e)
        {

        }

        private void btnAB_Click(object sender, EventArgs e)
        {

        }

        private void btndetMatrixA_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixAdetDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrixAIdentity_Click(object sender, EventArgs e)
        {

        }

        private void btnInvMatrixA_Click(object sender, EventArgs e)
        {
        }

        private void btnMatrixBIdentity_Click(object sender, EventArgs e)
        {
        }

        private void btnSwtichASwitchB_Click(object sender, EventArgs e)
        {
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
        }

        private void btnMatrixATranspose_Click(object sender, EventArgs e)
        {
        }

        private void btnMatrixBTranspose_Click(object sender, EventArgs e)
        {
        }

        private void btnMatrixASquared_Click(object sender, EventArgs e)
        {
        }

        private void btnMatrixBSquared_Click(object sender, EventArgs e)
        {
        }

        private void btncA_Click(object sender, EventArgs e)
        {
        }

        private void btncB_Click(object sender, EventArgs e)
        {
        }

        private void txtConstant_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnToMatrixB_Click(object sender, EventArgs e)
        {
            string input = outTxt.Text.Trim(); // Get the input text from the textbox and remove any leading/trailing whitespace
            string[] rows = input.Split('\n'); // Split the input into rows using the newline character as a delimiter

            double[,] numbers = new double[rows.Length, rows[0].Trim().Split(' ').Length]; // Create a 2D array to store the parsed numbers

            for (int i = 0; i < rows.Length; i++)
            {
                string[] values = rows[i].Trim().Split(' '); // Split each row into individual values using the space character as a delimiter and remove any leading/trailing whitespace

                for (int j = 0; j < values.Length; j++)
                {
                    double.TryParse(values[j], out numbers[i, j]); // Attempt to parse each value as a double and store it in the array
                }
            }

            MatrixB = Matrix<double>.Build.DenseOfArray(numbers);

        }

        private void btnToMatrixA_Click(object sender, EventArgs e)
        {
            string input = outTxt.Text.Trim(); // Get the input text from the textbox and remove any leading/trailing whitespace
            string[] rows = input.Split('\n'); // Split the input into rows using the newline character as a delimiter

            double[,] numbers = new double[rows.Length, rows[0].Trim().Split(' ').Length]; // Create a 2D array to store the parsed numbers

            for (int i = 0; i < rows.Length; i++)
            {
                string[] values = rows[i].Trim().Split(' '); // Split each row into individual values using the space character as a delimiter and remove any leading/trailing whitespace

                for (int j = 0; j < values.Length; j++)
                {
                    double.TryParse(values[j], out numbers[i, j]); // Attempt to parse each value as a double and store it in the array
                }
            }

            MatrixA = Matrix<double>.Build.DenseOfArray(numbers);

        }

        private void btnFromMatrixA_Click(object sender, EventArgs e)
        {
        }

        private void btnFromMatrixB_Click(object sender, EventArgs e)
        {
        }

        private void MatrixAColumnTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        TextBox MatrixColumnMaker()
        {
            TextBox newText = new TextBox();
            newText.Text = "0";
            newText.Width = 5;
            newText.Height = 5;
            return newText;
        }

        TextBox MatrixRowMaker()
        {
            TextBox newText = new TextBox();
            newText.Text = "0";
            newText.Width = 5;
            newText.Height = 5;
            return newText;
        }
    }
}