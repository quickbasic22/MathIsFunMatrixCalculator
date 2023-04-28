using MathNet.Numerics.LinearAlgebra;


namespace MathIsFunMatrixCalculator
{
    public partial class Form1 : Form
    {
        Matrix<double> MatrixA;
        Matrix<double> MatrixB;
        Matrix<double> MatrixC;
        int ColumnNumber = 1;
        int RowNumber = 1;
        TextBox[] textBoxes = new TextBox[16];
        public Form1()
        {
            InitializeComponent();
            MatrixAColumnTrackBar.Minimum = 1;
            MatrixAColumnTrackBar.Maximum = 5;
            MatrixBColumnTrackBar.Minimum = 1;
            MatrixBColumnTrackBar.Maximum = 5;
            MatrixARowTrackBar.Minimum = 1;
            MatrixARowTrackBar.Maximum = 5;
            MatrixBRowTrackBar.Minimum = 1;
            MatrixBRowTrackBar.Maximum = 5;

        }
        private void btnMatrixAUpArrow_Click(object sender, EventArgs e)
        {
            RowNumber++;
            if (RowNumber < 1)
            {
                RowNumber++;
            }
            else if (RowNumber > 5)
            {
                RowNumber--;
            }
            outTxt.Text = RowNumber.ToString() + "\n\r";
        }
        private void btnMatrixADownArrow_Click(object sender, EventArgs e)
        {
            RowNumber--;
            if (RowNumber < 1)
            {
                RowNumber++;
            }
            else if (RowNumber > 5)
            {
                RowNumber--;
            }
            outTxt.Text = RowNumber.ToString() + "\n\r";
        }


        private void btnMatrixALeftArrow_Click(object sender, EventArgs e)
        {
            ColumnNumber--;
            if (ColumnNumber < 1)
            {
                ColumnNumber++;
            }
            else if (ColumnNumber > 5)
            {
                ColumnNumber--;
            }
            outTxt.Text = ColumnNumber.ToString() + "\n\r";
        }

        private void btnMatrixARightArrow_Click(object sender, EventArgs e)
        {
            ColumnNumber++;
            if (ColumnNumber < 1)
            {
                ColumnNumber++;
            }
            else if (ColumnNumber > 5)
            {
                ColumnNumber--;
            }
            outTxt.Text = ColumnNumber.ToString() + "\n\r";
        }

        private void btnMatrixBUpArrow_Click(object sender, EventArgs e)
        {
            if (RowNumber == 1)
            {

            }
            else
            {
                RowNumber--;
            }
        }

        private void btnMatrixBDownArrow_Click(object sender, EventArgs e)
        {
            if (RowNumber == 1)
            {

            }
            else
            {
                RowNumber++;
            }
        }

        private void btnMatrixBLeftArrow_Click(object sender, EventArgs e)
        {
            if (ColumnNumber == 1)
            {

            }
            else
            {
                ColumnNumber--;
            }
        }

        private void btnMatrixBRightArrow_Click(object sender, EventArgs e)
        {
            if (ColumnNumber == 1)
            {

            }
            else
            {
                ColumnNumber++;
            }
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

        private void btnFromMatrixB_Click(object sender, EventArgs e)
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

        private void MatrixAColumnTrackBar_Scroll(object sender, EventArgs e)
        {
            switch (MatrixAColumnTrackBar.Value)
            {
                case 1:
                    ColumnNumber = 1;
                    break;
                case 2:
                    ColumnNumber = 2;
                    break;
                case 3:
                    ColumnNumber = 3;
                    break;
                case 4:
                    ColumnNumber = 4;
                    break;
                case 5:
                    ColumnNumber = 5;
                    break;
                default:
                    ColumnNumber = 1;
                    break;
            }
            outTxt.Text = ColumnNumber.ToString() + "\n\r";
        }
        private void MatrixARowTrackBar_Scroll(object sender, EventArgs e)
        {
            switch (MatrixARowTrackBar.Value)
            {
                case 1:
                    RowNumber = 1;
                    break;
                case 2:
                    RowNumber = 2;
                    break;
                case 3:
                    RowNumber = 3;
                    break;
                case 4:
                    RowNumber = 4;
                    break;
                case 5:
                    RowNumber = 5;
                    break;
                default:
                    RowNumber = 1;
                    break;
            }
            outTxt.Text = RowNumber.ToString() + "\n\r";
        }
        private void MatrixBColumnTrackBar_Scroll(object sender, EventArgs e)
        {
            switch (MatrixBColumnTrackBar.Value)
            {
                case 1:
                    ColumnNumber = 1;
                    break;
                case 2:
                    ColumnNumber = 2;
                    break;
                case 3:
                    ColumnNumber = 3;
                    break;
                case 4:
                    ColumnNumber = 4;
                    break;
                case 5:
                    ColumnNumber = 5;
                    break;
                default:
                    ColumnNumber = 1;
                    break;
            }
            outTxt.Text = ColumnNumber.ToString() + "\n\r";
        }

        private void MatrixBRowTrackBar_Scroll(object sender, EventArgs e)
        {
            switch (MatrixBRowTrackBar.Value)
            {
                case 1:
                    RowNumber = 1;
                    break;
                case 2:
                    RowNumber = 2;
                    break;
                case 3:
                    RowNumber = 3;
                    break;
                case 4:
                    RowNumber = 4;
                    break;
                case 5:
                    RowNumber = 5;
                    break;
                default:
                    RowNumber = 1;
                    break;
            }
            outTxt.Text = RowNumber.ToString() + "\n\r";
        }

    }
}