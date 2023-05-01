namespace MathIsFunMatrixCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox textBox2;
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnMatrixARightArrow = new Button();
            btnMatrixALeftArrow = new Button();
            btnMatrixADownArrow = new Button();
            btnMatrixAUpArrow = new Button();
            MatrixARowTrackBar = new TrackBar();
            MatrixAColumnTrackBar = new TrackBar();
            panel2 = new Panel();
            textBox3 = new TextBox();
            btnMatrixBRightArrow = new Button();
            btnMatrixBLeftArrow = new Button();
            btnMatrixBDownArrow = new Button();
            btnMatrixBUpArrow = new Button();
            MatrixBRowTrackBar = new TrackBar();
            MatrixBColumnTrackBar = new TrackBar();
            panel3 = new Panel();
            btnFromMatrixB = new Button();
            btnFromMatrixA = new Button();
            btnToMatrixB = new Button();
            btnToMatrixA = new Button();
            outTxt = new TextBox();
            txtConstant = new TextBox();
            btncB = new Button();
            btncA = new Button();
            btnMatrixBSquared = new Button();
            btnMatrixASquared = new Button();
            btnMatrixBTranspose = new Button();
            btnMatrixATranspose = new Button();
            btnExample = new Button();
            btnSwtichASwitchB = new Button();
            btnMatrixBIdentity = new Button();
            btnMatrixAIdentity = new Button();
            btnInvMatrixA = new Button();
            btnMatrixAdetDetails = new Button();
            btndetMatrixA = new Button();
            btnAB = new Button();
            btnAMinusB = new Button();
            btnAPlusB = new Button();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixARowTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixAColumnTrackBar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixBRowTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MatrixBColumnTrackBar).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox2.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.HideSelection = false;
            textBox2.Location = new Point(-106, -17);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(806, 93);
            textBox2.TabIndex = 8;
            textBox2.TabStop = false;
            textBox2.Text = "Matrix Calculator";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnMatrixARightArrow);
            panel1.Controls.Add(btnMatrixALeftArrow);
            panel1.Controls.Add(btnMatrixADownArrow);
            panel1.Controls.Add(btnMatrixAUpArrow);
            panel1.Controls.Add(MatrixARowTrackBar);
            panel1.Controls.Add(MatrixAColumnTrackBar);
            panel1.Location = new Point(115, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 406);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 174);
            textBox1.TabIndex = 8;
            // 
            // btnMatrixARightArrow
            // 
            btnMatrixARightArrow.Location = new Point(373, 99);
            btnMatrixARightArrow.Name = "btnMatrixARightArrow";
            btnMatrixARightArrow.Size = new Size(42, 33);
            btnMatrixARightArrow.TabIndex = 7;
            btnMatrixARightArrow.Text = "▶";
            btnMatrixARightArrow.UseVisualStyleBackColor = true;
            btnMatrixARightArrow.Click += btnMatrixARightArrow_Click;
            // 
            // btnMatrixALeftArrow
            // 
            btnMatrixALeftArrow.Location = new Point(333, 99);
            btnMatrixALeftArrow.Name = "btnMatrixALeftArrow";
            btnMatrixALeftArrow.Size = new Size(42, 33);
            btnMatrixALeftArrow.TabIndex = 6;
            btnMatrixALeftArrow.Text = "◀";
            btnMatrixALeftArrow.UseVisualStyleBackColor = true;
            btnMatrixALeftArrow.Click += btnMatrixALeftArrow_Click;
            // 
            // btnMatrixADownArrow
            // 
            btnMatrixADownArrow.Location = new Point(293, 99);
            btnMatrixADownArrow.Name = "btnMatrixADownArrow";
            btnMatrixADownArrow.Size = new Size(42, 33);
            btnMatrixADownArrow.TabIndex = 5;
            btnMatrixADownArrow.Text = "▼";
            btnMatrixADownArrow.UseVisualStyleBackColor = true;
            btnMatrixADownArrow.Click += btnMatrixADownArrow_Click;
            // 
            // btnMatrixAUpArrow
            // 
            btnMatrixAUpArrow.Location = new Point(253, 99);
            btnMatrixAUpArrow.Name = "btnMatrixAUpArrow";
            btnMatrixAUpArrow.Size = new Size(42, 33);
            btnMatrixAUpArrow.TabIndex = 4;
            btnMatrixAUpArrow.Text = "▲";
            btnMatrixAUpArrow.UseVisualStyleBackColor = true;
            btnMatrixAUpArrow.Click += btnMatrixAUpArrow_Click;
            // 
            // MatrixARowTrackBar
            // 
            MatrixARowTrackBar.Location = new Point(18, 153);
            MatrixARowTrackBar.Name = "MatrixARowTrackBar";
            MatrixARowTrackBar.Orientation = Orientation.Vertical;
            MatrixARowTrackBar.Size = new Size(45, 190);
            MatrixARowTrackBar.TabIndex = 3;
            MatrixARowTrackBar.TickStyle = TickStyle.None;
            MatrixARowTrackBar.Scroll += MatrixARowTrackBar_Scroll;
            // 
            // MatrixAColumnTrackBar
            // 
            MatrixAColumnTrackBar.Location = new Point(28, 102);
            MatrixAColumnTrackBar.Name = "MatrixAColumnTrackBar";
            MatrixAColumnTrackBar.Size = new Size(219, 45);
            MatrixAColumnTrackBar.TabIndex = 0;
            MatrixAColumnTrackBar.TickStyle = TickStyle.None;
            MatrixAColumnTrackBar.Scroll += MatrixAColumnTrackBar_Scroll;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnMatrixBRightArrow);
            panel2.Controls.Add(btnMatrixBLeftArrow);
            panel2.Controls.Add(btnMatrixBDownArrow);
            panel2.Controls.Add(btnMatrixBUpArrow);
            panel2.Controls.Add(MatrixBRowTrackBar);
            panel2.Controls.Add(MatrixBColumnTrackBar);
            panel2.Location = new Point(539, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 406);
            panel2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 153);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 174);
            textBox3.TabIndex = 12;
            // 
            // btnMatrixBRightArrow
            // 
            btnMatrixBRightArrow.Location = new Point(362, 99);
            btnMatrixBRightArrow.Name = "btnMatrixBRightArrow";
            btnMatrixBRightArrow.Size = new Size(42, 33);
            btnMatrixBRightArrow.TabIndex = 11;
            btnMatrixBRightArrow.Text = "▶";
            btnMatrixBRightArrow.UseVisualStyleBackColor = true;
            btnMatrixBRightArrow.Click += btnMatrixBRightArrow_Click;
            // 
            // btnMatrixBLeftArrow
            // 
            btnMatrixBLeftArrow.Location = new Point(322, 99);
            btnMatrixBLeftArrow.Name = "btnMatrixBLeftArrow";
            btnMatrixBLeftArrow.Size = new Size(42, 33);
            btnMatrixBLeftArrow.TabIndex = 10;
            btnMatrixBLeftArrow.Text = "◀";
            btnMatrixBLeftArrow.UseVisualStyleBackColor = true;
            btnMatrixBLeftArrow.Click += btnMatrixBLeftArrow_Click;
            // 
            // btnMatrixBDownArrow
            // 
            btnMatrixBDownArrow.Location = new Point(282, 99);
            btnMatrixBDownArrow.Name = "btnMatrixBDownArrow";
            btnMatrixBDownArrow.Size = new Size(42, 33);
            btnMatrixBDownArrow.TabIndex = 9;
            btnMatrixBDownArrow.Text = "▼";
            btnMatrixBDownArrow.UseVisualStyleBackColor = true;
            btnMatrixBDownArrow.Click += btnMatrixBDownArrow_Click;
            // 
            // btnMatrixBUpArrow
            // 
            btnMatrixBUpArrow.Location = new Point(242, 99);
            btnMatrixBUpArrow.Name = "btnMatrixBUpArrow";
            btnMatrixBUpArrow.Size = new Size(42, 33);
            btnMatrixBUpArrow.TabIndex = 8;
            btnMatrixBUpArrow.Text = "▲";
            btnMatrixBUpArrow.UseVisualStyleBackColor = true;
            btnMatrixBUpArrow.Click += btnMatrixBUpArrow_Click;
            // 
            // MatrixBRowTrackBar
            // 
            MatrixBRowTrackBar.Location = new Point(16, 150);
            MatrixBRowTrackBar.Name = "MatrixBRowTrackBar";
            MatrixBRowTrackBar.Orientation = Orientation.Vertical;
            MatrixBRowTrackBar.Size = new Size(45, 193);
            MatrixBRowTrackBar.TabIndex = 1;
            MatrixBRowTrackBar.TickStyle = TickStyle.None;
            MatrixBRowTrackBar.Scroll += MatrixBRowTrackBar_Scroll;
            // 
            // MatrixBColumnTrackBar
            // 
            MatrixBColumnTrackBar.Location = new Point(16, 99);
            MatrixBColumnTrackBar.Name = "MatrixBColumnTrackBar";
            MatrixBColumnTrackBar.Size = new Size(219, 45);
            MatrixBColumnTrackBar.TabIndex = 2;
            MatrixBColumnTrackBar.TickStyle = TickStyle.None;
            MatrixBColumnTrackBar.Scroll += MatrixBColumnTrackBar_Scroll;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFromMatrixB);
            panel3.Controls.Add(btnFromMatrixA);
            panel3.Controls.Add(btnToMatrixB);
            panel3.Controls.Add(btnToMatrixA);
            panel3.Controls.Add(outTxt);
            panel3.Controls.Add(txtConstant);
            panel3.Controls.Add(btncB);
            panel3.Controls.Add(btncA);
            panel3.Controls.Add(btnMatrixBSquared);
            panel3.Controls.Add(btnMatrixASquared);
            panel3.Controls.Add(btnMatrixBTranspose);
            panel3.Controls.Add(btnMatrixATranspose);
            panel3.Controls.Add(btnExample);
            panel3.Controls.Add(btnSwtichASwitchB);
            panel3.Controls.Add(btnMatrixBIdentity);
            panel3.Controls.Add(btnMatrixAIdentity);
            panel3.Controls.Add(btnInvMatrixA);
            panel3.Controls.Add(btnMatrixAdetDetails);
            panel3.Controls.Add(btndetMatrixA);
            panel3.Controls.Add(btnAB);
            panel3.Controls.Add(btnAMinusB);
            panel3.Controls.Add(btnAPlusB);
            panel3.Location = new Point(93, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 452);
            panel3.TabIndex = 2;
            // 
            // btnFromMatrixB
            // 
            btnFromMatrixB.Location = new Point(18, 286);
            btnFromMatrixB.Name = "btnFromMatrixB";
            btnFromMatrixB.Size = new Size(54, 37);
            btnFromMatrixB.TabIndex = 28;
            btnFromMatrixB.Text = "from B";
            btnFromMatrixB.UseVisualStyleBackColor = true;
            btnFromMatrixB.Click += btnFromMatrixB_Click;
            // 
            // btnFromMatrixA
            // 
            btnFromMatrixA.Location = new Point(18, 243);
            btnFromMatrixA.Name = "btnFromMatrixA";
            btnFromMatrixA.Size = new Size(54, 37);
            btnFromMatrixA.TabIndex = 27;
            btnFromMatrixA.Text = "from A";
            btnFromMatrixA.UseVisualStyleBackColor = true;
            btnFromMatrixA.Click += btnFromMatrixA_Click;
            // 
            // btnToMatrixB
            // 
            btnToMatrixB.Location = new Point(19, 200);
            btnToMatrixB.Name = "btnToMatrixB";
            btnToMatrixB.Size = new Size(54, 37);
            btnToMatrixB.TabIndex = 26;
            btnToMatrixB.Text = "to B";
            btnToMatrixB.UseVisualStyleBackColor = true;
            btnToMatrixB.Click += btnToMatrixB_Click;
            // 
            // btnToMatrixA
            // 
            btnToMatrixA.Location = new Point(19, 157);
            btnToMatrixA.Name = "btnToMatrixA";
            btnToMatrixA.Size = new Size(54, 37);
            btnToMatrixA.TabIndex = 25;
            btnToMatrixA.Text = "to A";
            btnToMatrixA.UseVisualStyleBackColor = true;
            btnToMatrixA.Click += btnToMatrixA_Click;
            // 
            // outTxt
            // 
            outTxt.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            outTxt.Location = new Point(86, 120);
            outTxt.Multiline = true;
            outTxt.Name = "outTxt";
            outTxt.Size = new Size(764, 332);
            outTxt.TabIndex = 24;
            outTxt.Text = "1 2 3 4\r\n5 6 7 8\r\n9 10 11 12";
            // 
            // txtConstant
            // 
            txtConstant.Location = new Point(403, 61);
            txtConstant.Multiline = true;
            txtConstant.Name = "txtConstant";
            txtConstant.Size = new Size(33, 23);
            txtConstant.TabIndex = 23;
            txtConstant.Text = "1";
            txtConstant.TextChanged += txtConstant_TextChanged;
            // 
            // btncB
            // 
            btncB.Location = new Point(347, 55);
            btncB.Name = "btncB";
            btncB.Size = new Size(50, 33);
            btncB.TabIndex = 22;
            btncB.Text = "cB";
            btncB.UseVisualStyleBackColor = true;
            btncB.Click += btncB_Click;
            // 
            // btncA
            // 
            btncA.Location = new Point(311, 55);
            btncA.Name = "btncA";
            btncA.Size = new Size(34, 33);
            btncA.TabIndex = 21;
            btncA.Text = "cA";
            btncA.UseVisualStyleBackColor = true;
            btncA.Click += btncA_Click;
            // 
            // btnMatrixBSquared
            // 
            btnMatrixBSquared.Location = new Point(271, 55);
            btnMatrixBSquared.Name = "btnMatrixBSquared";
            btnMatrixBSquared.Size = new Size(34, 33);
            btnMatrixBSquared.TabIndex = 20;
            btnMatrixBSquared.Text = "B²";
            btnMatrixBSquared.UseVisualStyleBackColor = true;
            btnMatrixBSquared.Click += btnMatrixBSquared_Click;
            // 
            // btnMatrixASquared
            // 
            btnMatrixASquared.Location = new Point(231, 55);
            btnMatrixASquared.Name = "btnMatrixASquared";
            btnMatrixASquared.Size = new Size(34, 33);
            btnMatrixASquared.TabIndex = 19;
            btnMatrixASquared.Text = "A²";
            btnMatrixASquared.UseVisualStyleBackColor = true;
            btnMatrixASquared.Click += btnMatrixASquared_Click;
            // 
            // btnMatrixBTranspose
            // 
            btnMatrixBTranspose.Location = new Point(182, 55);
            btnMatrixBTranspose.Name = "btnMatrixBTranspose";
            btnMatrixBTranspose.Size = new Size(46, 33);
            btnMatrixBTranspose.TabIndex = 18;
            btnMatrixBTranspose.Text = "B(T)";
            btnMatrixBTranspose.UseVisualStyleBackColor = true;
            btnMatrixBTranspose.Click += btnMatrixBTranspose_Click;
            // 
            // btnMatrixATranspose
            // 
            btnMatrixATranspose.Location = new Point(147, 55);
            btnMatrixATranspose.Name = "btnMatrixATranspose";
            btnMatrixATranspose.Size = new Size(48, 33);
            btnMatrixATranspose.TabIndex = 17;
            btnMatrixATranspose.Text = "A(T)";
            btnMatrixATranspose.UseVisualStyleBackColor = true;
            btnMatrixATranspose.Click += btnMatrixATranspose_Click;
            // 
            // btnExample
            // 
            btnExample.Location = new Point(474, 20);
            btnExample.Name = "btnExample";
            btnExample.Size = new Size(89, 33);
            btnExample.TabIndex = 16;
            btnExample.Text = "example";
            btnExample.UseVisualStyleBackColor = true;
            btnExample.Click += btnExample_Click;
            // 
            // btnSwtichASwitchB
            // 
            btnSwtichASwitchB.Location = new Point(420, 20);
            btnSwtichASwitchB.Name = "btnSwtichASwitchB";
            btnSwtichASwitchB.Size = new Size(48, 33);
            btnSwtichASwitchB.TabIndex = 15;
            btnSwtichASwitchB.Text = "A⬌B";
            btnSwtichASwitchB.UseVisualStyleBackColor = true;
            btnSwtichASwitchB.Click += btnSwtichASwitchB_Click;
            // 
            // btnMatrixBIdentity
            // 
            btnMatrixBIdentity.Location = new Point(380, 20);
            btnMatrixBIdentity.Name = "btnMatrixBIdentity";
            btnMatrixBIdentity.Size = new Size(34, 33);
            btnMatrixBIdentity.TabIndex = 14;
            btnMatrixBIdentity.Text = "B=I";
            btnMatrixBIdentity.UseVisualStyleBackColor = true;
            btnMatrixBIdentity.Click += btnMatrixBIdentity_Click;
            // 
            // btnMatrixAIdentity
            // 
            btnMatrixAIdentity.Location = new Point(340, 20);
            btnMatrixAIdentity.Name = "btnMatrixAIdentity";
            btnMatrixAIdentity.Size = new Size(34, 33);
            btnMatrixAIdentity.TabIndex = 13;
            btnMatrixAIdentity.Text = "A=I";
            btnMatrixAIdentity.UseVisualStyleBackColor = true;
            btnMatrixAIdentity.Click += btnMatrixAIdentity_Click;
            // 
            // btnInvMatrixA
            // 
            btnInvMatrixA.Location = new Point(271, 20);
            btnInvMatrixA.Name = "btnInvMatrixA";
            btnInvMatrixA.Size = new Size(66, 33);
            btnInvMatrixA.TabIndex = 12;
            btnInvMatrixA.Text = "inv(A)";
            btnInvMatrixA.UseVisualStyleBackColor = true;
            btnInvMatrixA.Click += btnInvMatrixA_Click;
            // 
            // btnMatrixAdetDetails
            // 
            btnMatrixAdetDetails.Location = new Point(182, 20);
            btnMatrixAdetDetails.Name = "btnMatrixAdetDetails";
            btnMatrixAdetDetails.Size = new Size(95, 33);
            btnMatrixAdetDetails.TabIndex = 11;
            btnMatrixAdetDetails.Text = "det(A) details";
            btnMatrixAdetDetails.UseVisualStyleBackColor = true;
            btnMatrixAdetDetails.Click += btnMatrixAdetDetails_Click;
            // 
            // btndetMatrixA
            // 
            btndetMatrixA.Location = new Point(125, 20);
            btndetMatrixA.Name = "btndetMatrixA";
            btndetMatrixA.Size = new Size(60, 33);
            btndetMatrixA.TabIndex = 10;
            btndetMatrixA.Text = "det(A)";
            btndetMatrixA.UseVisualStyleBackColor = true;
            btndetMatrixA.Click += btndetMatrixA_Click;
            // 
            // btnAB
            // 
            btnAB.Location = new Point(91, 20);
            btnAB.Name = "btnAB";
            btnAB.Size = new Size(38, 33);
            btnAB.TabIndex = 9;
            btnAB.Text = "AB";
            btnAB.UseVisualStyleBackColor = true;
            btnAB.Click += btnAB_Click;
            // 
            // btnAMinusB
            // 
            btnAMinusB.Location = new Point(59, 20);
            btnAMinusB.Name = "btnAMinusB";
            btnAMinusB.Size = new Size(37, 33);
            btnAMinusB.TabIndex = 8;
            btnAMinusB.Text = "A-B";
            btnAMinusB.UseVisualStyleBackColor = true;
            btnAMinusB.Click += btnAMinusB_Click;
            // 
            // btnAPlusB
            // 
            btnAPlusB.Location = new Point(18, 20);
            btnAPlusB.Name = "btnAPlusB";
            btnAPlusB.Size = new Size(45, 33);
            btnAPlusB.TabIndex = 0;
            btnAPlusB.Text = "A+B";
            btnAPlusB.UseVisualStyleBackColor = true;
            btnAPlusB.Click += btnAPlusB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 621);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixARowTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixAColumnTrackBar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MatrixBRowTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MatrixBColumnTrackBar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMatrixARightArrow;
        private Button btnMatrixALeftArrow;
        private Button btnMatrixADownArrow;
        private Button btnMatrixAUpArrow;
        private TrackBar MatrixARowTrackBar;
        private TrackBar MatrixAColumnTrackBar;
        private Panel panel2;
        private Button btnMatrixBRightArrow;
        private Button btnMatrixBLeftArrow;
        private Button btnMatrixBDownArrow;
        private Button btnMatrixBUpArrow;
        private TrackBar MatrixBRowTrackBar;
        private TrackBar MatrixBColumnTrackBar;
        private Panel panel3;
        private Button btnAPlusB;
        private Button btnMatrixAdetDetails;
        private Button btndetMatrixA;
        private Button btnAB;
        private Button btnAMinusB;
        private Button btncB;
        private Button btncA;
        private Button btnMatrixBSquared;
        private Button btnMatrixASquared;
        private Button btnMatrixBTranspose;
        private Button btnMatrixATranspose;
        private Button btnExample;
        private Button btnSwtichASwitchB;
        private Button btnMatrixBIdentity;
        private Button btnMatrixAIdentity;
        private Button btnInvMatrixA;
        private Button btnFromMatrixB;
        private Button btnFromMatrixA;
        private Button btnToMatrixB;
        private Button btnToMatrixA;
        private TextBox outTxt;
        private TextBox txtConstant;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}