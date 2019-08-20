using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    //By Brandon Price 06/08/2019
    //Created 28th April 2019
    public partial class Form1 : Form
    {
        //First numbers entered in the calculator will be classified as number one until an operator is pressed
        double? number1;
        //If number1 does not equal null and operator has been pressed, 
        //then numbers entered by calculator will go to number2
        double? number2;
        //adding, subtracting, dividing or multiplying number 1 and number 2
        double? total;

        //Allows to calculate digits with more than one number.
        int startedTotal1 = 0;
        int startedTotal2 = 0;

        //Determines if number is negative or positive when multiple negative and positive operators have been pressed
        int checkPosOrNeg = 0;

        //Used to store temporay values
        string tempStorage;

        //checks for the operators pressed
        bool minusFirstClicked = false;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        public Form1()
        {
            InitializeComponent();
        }
        //click button zero
        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    txtDisplay.Text = "-" + BtnZero.Text;
                    //total1 = 0 - 1;        
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnZero.Text;
                    minusFirstClicked = false;
                }
                else
                {
                    //total1 = 1;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnZero.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnZero.Text;
                }
            }
            else if (number2 == null)
            {
                startedTotal2 = 1;
                //total2 = 2;
                tempStorage = tempStorage + BtnZero.Text;
                txtDisplay.Text = txtDisplay.Text + BtnZero.Text;
            }
            //txtDisplay.Text = txtDisplay.Text;
            txtBox.Text = txtBox.Text + BtnZero.Text;
        }
        //click button one
        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    txtDisplay.Text = "-" + BtnOne.Text;
                    //total1 = 0 - 1;        
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnOne.Text;
                    minusFirstClicked = false;
                }
                else
                {
                    //total1 = 1;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnOne.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnOne.Text;
                }
            }
            else if (number2 == null)
            {
                startedTotal2 = 1;
                //total2 = 2;
                tempStorage = tempStorage + BtnOne.Text;
                txtDisplay.Text = txtDisplay.Text + BtnOne.Text;
            }
            //txtDisplay.Text = btnOne.Text;
            txtBox.Text = txtBox.Text + BtnOne.Text;
        }

        //click button two
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 2;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnTwo.Text;
                    txtDisplay.Text = "-" + BtnTwo.Text;
                    minusFirstClicked = false;
                }
                else
                {
                    //total1 = 2;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnTwo.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnTwo.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 2;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnTwo.Text;
                txtDisplay.Text = txtDisplay.Text + BtnTwo.Text;
            }
            //txtDisplay.Text = btnTwo.Text;
            txtBox.Text = txtBox.Text + BtnTwo.Text;
        }

        //click button three
        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 3;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnThree.Text;
                    txtDisplay.Text = "-" + BtnThree.Text;
                    minusFirstClicked = false;
                }
                else
                {
                    //total1 = 3;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnThree.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnThree.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 3;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnThree.Text;
                txtDisplay.Text = txtDisplay.Text + BtnThree.Text;
            }
            txtBox.Text = txtBox.Text + BtnThree.Text;
        }

        //click button four
        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 4;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnFour.Text;
                    txtDisplay.Text = "-" + BtnFour.Text;
                    minusFirstClicked = false;
                }
                else
                {
                    //total1 = 4;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnFour.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnFour.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 4;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnFour.Text;
                txtDisplay.Text = txtDisplay.Text + BtnFour.Text;
            }
            txtBox.Text = txtBox.Text + BtnFour.Text;
        }

        //click button five
        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 5;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnFive.Text;
                    minusFirstClicked = false;
                    txtDisplay.Text = "-" + BtnFive.Text;
                }
                else
                {
                    //total1 = 5;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnFive.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnFive.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 5;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnFive.Text;
                txtDisplay.Text = txtDisplay.Text + BtnFive.Text;
            }
            txtBox.Text = txtBox.Text + BtnFive.Text;
        }

        //click button six
        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 6;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnSix.Text;
                    minusFirstClicked = false;
                    txtDisplay.Text = "-" + BtnSix.Text;
                }
                else
                {
                    //total1 = 6;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnSix.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnSix.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 6;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnSix.Text;
                txtDisplay.Text = txtDisplay.Text + BtnSix.Text;
            }
            txtBox.Text = txtBox.Text + BtnSix.Text;
        }

        //click button seven
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 7;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnSeven.Text;
                    minusFirstClicked = false;
                    txtDisplay.Text = "-" + BtnSeven.Text;
                }
                else
                {
                    //total1 = 7;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnSeven.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnSeven.Text;
                }
            }
            else if (number2 == null)
            {
                number2 = 7;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnSeven.Text;
                txtDisplay.Text = txtDisplay.Text + BtnSeven.Text;
            }
            txtBox.Text = txtBox.Text + BtnSeven.Text;
        }

        //click button eight
        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 8;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnEight.Text;
                    minusFirstClicked = false;
                    txtDisplay.Text = "-" + BtnEight.Text;
                }
                else
                {
                    //total1 = 8;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnEight.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnEight.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 8;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnEight.Text;
                txtDisplay.Text = txtDisplay.Text + BtnEight.Text;
            }
            txtBox.Text = txtBox.Text + BtnEight.Text;
        }

        //click button nine
        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (number1 == null)
            {
                if (minusFirstClicked)
                {
                    //total1 = 0 - 9;
                    startedTotal1 = 1;
                    tempStorage = "-" + BtnNine.Text;
                    minusFirstClicked = false;
                    txtDisplay.Text = "-" + BtnNine.Text;
                }
                else
                {
                    //total1 = 9;
                    startedTotal1 = 1;
                    tempStorage = tempStorage + BtnNine.Text;
                    txtDisplay.Text = txtDisplay.Text + BtnNine.Text;
                }
            }
            else if (number2 == null)
            {
                //total2 = 9;
                startedTotal2 = 1;
                tempStorage = tempStorage + BtnNine.Text;
                txtDisplay.Text = txtDisplay.Text + BtnNine.Text;
            }
            txtBox.Text = txtBox.Text + BtnNine.Text;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnDot.Text;
            txtBox.Text = txtBox.Text + BtnDot.Text;
            //total1 = double.Parse(txtBox.Text);
            if (number1 == null && number2 == null)
            {
                tempStorage = tempStorage + BtnDot.Text;
            }
            else if (number1 != null && number2 == null)
            {
                tempStorage = tempStorage + BtnDot.Text;
            }

        }

        //prepares for addition for total1 number and total2 number (total1+total2).
        //Equals button when pressed will then execute the calculation between the two variables
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (number1 != null && tempStorage.Length != 0)
            {
                return;
            }
            if (startedTotal1 == 1)//allows to calculate digits higher the 9, so 10,100 and etc.
            {
                double temp;
                Double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                number1 = temp;
                txtDisplay.Text = temp.ToString();
                startedTotal1 = 2;
                string test = "";
                tempStorage = test;
            }

            if (number1 == null)
            {

            }
            else if (number2 == null)
            {
                plusButtonClicked = true;
            }
            txtBox.Text = txtBox.Text + "+";
            txtDisplay.Text = "+";
        }
        //prepares for subtraction for total1 number and total2 number (total1-total2).
        //Equals button when pressed will then execute the calculation between the two variables
        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (number1 != null && tempStorage.Length != 0)
            {
                return;
            }
            if (startedTotal1 == 1)//allows to calculate digits higher the 9, so 10,100 and etc.
            {
                //double temp;
                //Double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                number1 = double.Parse(tempStorage);
                txtDisplay.Text = number1.ToString();
                startedTotal1 = 2;
                string test = "";
                tempStorage = test;
            }

            if (number1 == null)//if number1 equals null, it means the negative integer is first character written on calculator
            {
                if (string.IsNullOrEmpty(txtDisplay.Text))//this is a check so if user presses negative integer, it will remain negative
                {
                    txtBox.Text = txtBox.Text + "-";
                    minusFirstClicked = true;
                }
            }
            //if number2 equals null, it means the number2 does not equal null
            //the negative operator is applied between number1 and number 2
            else if (number2 == null)
            {
                checkPosOrNeg++;

                if (checkPosOrNeg % 2 != 0)// if negative
                {
                    txtBox.Text = txtBox.Text + "-";
                    plusButtonClicked = false;
                    minusButtonClicked = true;
                }
                else if (checkPosOrNeg % 2 == 0)//negative negative = positive (If positive)
                {
                    txtBox.Text = txtBox.Text + "-";
                    plusButtonClicked = true;
                    minusButtonClicked = false;
                }
            }
            txtDisplay.Text = "-";
        }

        //prepares for divison for total1 number and total2 number (total1/total2).
        //Equals button when pressed will then execute the calculation between the two variables
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (number1 != null && tempStorage.Length != 0)//error trapping
            {
                return;
            }
            if (startedTotal1 == 1)//allows for multiple digits when calcing
            {
                double temp;
                Double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                number1 = temp;
                txtDisplay.Text = temp.ToString();
                startedTotal1 = 2;
                string test = "";
                tempStorage = test;
            }
            if (number1 == null)//cannot be null or error
            {
                //Print Error
                txtDisplay.Text = "ERROR";
            }
            else if (number2 == null)//means number1 is not null. This allows number1 to be divised by number 2
            {
                plusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
                txtBox.Text = txtBox.Text + "/";
                txtDisplay.Text = "/";
            }


        }

        //prepares for multiplication for total1 number and total2 number (total1*total2).
        //Equals button when pressed will then execute the calculation between the two variables
        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (number1 != null && tempStorage.Length != 0)//error trapping
            {
                return;
            }
            if (startedTotal1 == 1)//allows for multiple digits when calcing
            {
                double temp;
                Double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                number1 = temp;
                txtDisplay.Text = temp.ToString();
                startedTotal1 = 2;
                string test = "";
                tempStorage = test;
            }
            if (number1 == null)//error trapping
            {
                //Print Error
                txtDisplay.Text = "ERROR";
            }
            else if (number2 == null)//means number1 is not null. This allows number1 to be multipliedby number 2
            {
                plusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
                txtBox.Text = txtBox.Text + "*";
                txtDisplay.Text = "*";
            }
        }

        //once numbers have been inputed and the operator has been declared (Divide,Multiply, Add and Subract)
        //the equals method will then calculate the equation and display the results
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (startedTotal2 == 1)//this enables for number bigger than one diget to be calculated properly
            {
                double temp;
                double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                number2 = temp;
                txtDisplay.Text = temp.ToString();
                startedTotal2 = 2;
                string test = "";
                tempStorage = test;
            }

            //when there is a postive and negative operator (-+), it will consider both the selected as false. 
            //This helps calculate the value further down the code
            if ((plusButtonClicked && minusButtonClicked) == true)
            {
                plusButtonClicked = false;
            }
            //when there is a postive and negative operator (-+)
            if ((plusButtonClicked && minusButtonClicked) == true)
            {
                total = Arithmetic.Maths.Subtraction(number1, number2); //number1 will subtract number2
            }
            //when there is a postive operator (+) and no negative operators
            if (plusButtonClicked == true && minusButtonClicked == false)
            {
                total = Arithmetic.Maths.Addition(number1, number2); //number1 will add number2
            }
            //when there is a negative operator (-) and no division operator
            if ((minusButtonClicked == true) && (divideButtonClicked == false))
            {
                if (multiplyButtonClicked == false)//checks if multiply is selected
                {
                    total = Arithmetic.Maths.Subtraction(number1, number2); //number1 will subtract number2
                }
            }
            //when there is a negative operator and division operatore selected(-/)
            if (divideButtonClicked == true && minusButtonClicked == true)
            {
                if (number2 == 0)//Error handling incase of divising zero
                {
                    txtDisplay.Text = "undefined";
                    number2 = null;
                    number1 = null;
                    plusButtonClicked = false;
                    minusButtonClicked = false;
                    divideButtonClicked = false;
                    multiplyButtonClicked = false;
                    checkPosOrNeg = 0;
                    startedTotal1 = 0;
                    startedTotal2 = 0;
                    txtBox.Clear();
                    return;
                }
                else
                {
                    total = Arithmetic.Maths.Division(number1, -number2);//number1 divide and minus number2
                }
            }
            //when there is a division operator selected(/) and no negative operator
            if (divideButtonClicked == true && minusButtonClicked == false)
            {
                if (number2 == 0)//error handling for divisng zero
                {
                    txtDisplay.Text = "undefined";
                    number2 = null;
                    number1 = null;
                    plusButtonClicked = false;
                    minusButtonClicked = false;
                    divideButtonClicked = false;
                    multiplyButtonClicked = false;
                    checkPosOrNeg = 0;
                    startedTotal1 = 0;
                    startedTotal2 = 0;
                    txtBox.Clear();
                    return;
                }
                else
                {
                    total = Arithmetic.Maths.Division(number1, number2);//number1 divide number2
                }
            }
            //when there is a multiplyer and subtract operator selected(-+)
            if (multiplyButtonClicked == true && minusButtonClicked == true)
            {
                total = Arithmetic.Maths.Multiply(number1, -number2);//number1 mutliplayer negative number2
            }
            //when there is a multiplyer operator select (*) and subtract operator is not selected
            if (multiplyButtonClicked == true && minusButtonClicked == false)
            {
                total = Arithmetic.Maths.Multiply(number1, number2); //number1 add number2
            }
            //Resetting all values to original state.
            tempStorage = "";
            txtDisplay.Text = total.ToString();//Display results
            number2 = null;
            number1 = total;
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            checkPosOrNeg = 0;
            startedTotal1 = 0;
            startedTotal2 = 0;
            txtBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //wipes all variables and clears all textboxes on calculator
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtBox.Clear();

            checkPosOrNeg = 0;
            startedTotal1 = 0;
            startedTotal2 = 0;

            number1 = null;
            number2 = null;
            total = null;

            startedTotal1 = 0;
            startedTotal2 = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            tempStorage = "";
        }

        //Square root method uses a library to calculate the square root.
        //The method is accessed when a user clicks square root button "SQRT"
        private void BtnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text.Length > 0)
                {
                    double inputDisplay = double.Parse(txtDisplay.Text);
                    double num = Algebraic.Maths.SquareRoot(inputDisplay);
                    double temp = num;
                    if (temp >= 0)
                    {
                        txtDisplay.Text = num.ToString();
                        txtBox.Clear();
                    }
                    else
                    {
                        txtDisplay.Text = "N/A";
                    }
                }
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }

        //Cube root method uses a library to calculate the cube root.
        //The method is accessed when a user clicks cube root button "Cube RT"
        private void BtnCubeRT_Click(object sender, EventArgs e)
        {
            try
            {
                double temp;
                double.TryParse(tempStorage, NumberStyles.Any, CultureInfo.InvariantCulture, out temp);
                double inputDisplay = temp;
                double num = Algebraic.Maths.CubeRoot(inputDisplay);
                txtDisplay.Text = num.ToString();
                txtBox.Clear();
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }

        //Inverse method uses a library to calculate the inverse of a number.
        //The method is accessed when a user clicks inverse button "Inv"
        private void BtnInv_Click(object sender, EventArgs e)
        {
            try
            {
                double inputDisplay = double.Parse(txtDisplay.Text);
                if (inputDisplay != 0)
                {
                    double num = Algebraic.Maths.Inverse(inputDisplay);
                    txtDisplay.Text = num.ToString();
                    txtBox.Clear();
                }
                else if (inputDisplay == 0)
                {
                    txtDisplay.Text = "N/A";
                }
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }

        //Tan method uses a library to calculate the tan of a number.
        //The method is accessed when a user clicks tan button "Tan"
        private void BtnTan_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = Trigonometry.Maths.Tan(txtDisplay.Text);
                txtBox.Clear();
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }

        //Sine method uses a library to calculate the Sine of a number.
        //The method is accessed when a user clicks sine button "Sin"
        private void BtnSin_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = Trigonometry.Maths.Sine(txtDisplay.Text);
                txtBox.Clear();
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }

        //Cosine method uses a library to calculate the Cosine of a number.
        //The method is accessed when a user clicks cosine button "Cos"
        private void BtnCos_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = Trigonometry.Maths.Cosine(txtDisplay.Text);
                txtBox.Clear();
            }
            catch
            {
                txtDisplay.Text = "N/A";
            }
        }
    }
}
