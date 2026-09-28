### explaining the code of chapter 2

## Reading and Displaying TextBox Input
In this example, the TextBox is used to receive input from the user. When the button is clicked, the text entered in textboxmessage is stored in the message variable and then displayed in the lbltext Label.
### code
```Csharp
private void btntextboxshow_Click(object sender, EventArgs e)
{
    // Store the user input from the TextBox in a variable
    String message = textboxmessage.Text;

    //display the message in label
    lbltext.Text=message;
}

## Clearing TextBox and Label Controls
In this example, the btnclear_Click event is used to clear the contents of both a TextBox and a Label when the button is clicked. The TextBox can be cleared using three methods: Clear(), setting Text to "", or setting Text to String.Empty. The Label can similarly be cleared by setting its Text property to "" or String.Empty.

### code
```Csharp
private void btnclear_Click(object sender, EventArgs e)
{
    // clearing textbox
    //method one
    textboxmessage.Clear();
    //method two
    //textboxmessage.Text = "";
    //method three
    //textboxmessage.Text = String.Empty;

    // clearing label
    lbltext.Text = "";
    //method two
    //lbltext.Text=String.Empty;

}

## Declaring, Initializing, and Concatenating Variables
In this example, different variables are declared and then initialized with values. Multiple variables of the same data type are declared in one statement. The FirstName and LastName variables are joined together using string concatenation with the + operator, and the resulting fullName is displayed in the lblinfo Label.

### code
```Csharp
 private void button1_Click(object sender, EventArgs e)
 {
     // delaring variable
     int number;
     // declaring multiple variables in one statement
     string firstName, lastName, fullName;

     //Initilizing variables
     number = 10;
     firstName = "Karima";
     lastName = "Ahmed";
     // concatination
     fullName =firstName + " " + lastName;
     // displaying variables in label
     lblinfo.Text = fullName;

 }
 ## Using a Local Variable
In this example, a local variable named age is declared and initialized inside the button1_Click method. Because age is declared inside this method, it can only be accessed within this method. Its value is initialized to 7.
### code
```Csharp
 private void button1_Click(object sender, EventArgs e)
 {
     // local variables
     int age = 7;
 }

 ## Using Numeric Data Types, Type Casting, and Calculations
In this example, different numeric data types are used to store values such as age, height, and salary. The code also demonstrates type casting by converting the decimal salary to an int. Finally, it performs addition, subtraction, and integer division using two integer variables.

### code
```Csharp
 private void btnnumeric_Click(object sender, EventArgs e)
 {
     // numeric data types variables
     int age = 20;
     double height = 1.75;
     decimal salary = 500.50m;
     // type casting
     int money = (int)salary;
     //performing calculations
     int num1 = 30;
     int num2 = 6 ;
     int addition =num1 + num2;
     int subtraction =num1 - num2;

     // integer division 
     int division =num1 / num2;

 }

 ## Converting Between String and Integer
In this example, the program converts the value entered in a TextBox from a string to an int using the int.Parse() method. After that, the integer value is converted back to a string using ToString() so it can be displayed in the Label.

### code
```Csharp
 private void btninout_Click(object sender, EventArgs e)
 {
     // converting from string to integer using parse method
     int age = int.Parse(textinout.Text);

     //converting from numeric int to string
     lblinputoutput.Text= age.ToString();

 }
 ## Converting Input with Exception Handling
 n this example, exception handling is used to safely convert the TextBox input from a string to an int. The try block contains the code that may cause an error, such as int.Parse() when the user enters invalid input. If an error occurs, the catch block handles the exception and displays a message asking the user to enter a valid number.
 private void btninout_Click(object sender, EventArgs e)
{
    //using try 
    try
    {
        // converting from string to integer using parse method
        int age = int.Parse(textinout.Text);

        //converting from numeric int to string
        lblinputoutput.Text = age.ToString();
    }
    //using catch 
    catch (Exception ex)
    {
        MessageBox.Show("Please enter a valid number");

    }
}

## Using a Named Constant
In this example, a named constant called PI is declared using the const keyword. Its value is set to 3.14 and cannot be changed while the program is running. The program then uses PI and the radius to calculate the area of a circle, and the result is displayed in the lblconstant Label.


### code
```Csharp

    private void btnconstant_Click(object sender, EventArgs e)
    {
        // declaring constant variable 
        const  double PI = 3.14;
        double radius = 5;
        //calculating area of circle
        double area = PI *( radius* radius);
        lblconstant.Text = area.ToString();
    }
