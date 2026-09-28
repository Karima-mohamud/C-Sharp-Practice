# Chapter two - Processing Data

## Topics
3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants
Topics (2 of 2)
3.9 Declaring Variables as Fields
3.10 Using the Math Class
3.11 More G U I Details
3.12 Using the Debugger to Locate Logic Errors


 ## Reading Input with TextBox Controls
A TextBox is a control that allows the user to enter data using the keyboard. It is commonly used to collect input from the user and it accept only string values.
The user's input is stored in the TextBox's Text property.
## clear text box 
1-textBox1.Text = "";
2-textBox1.Text = string.Empty;
3-textBox1.Clear();

## Variable
A variable is a storage location in memory used to store data. A variable must be declared before it can be used.
## Variable Declaration:
DataType VariableName;
## Data Type
A data type specifies what type of data a variable can store, such as strings or integers.
## primitive data types
they store fundamental types of data (means essential or core
such as strings and integers
## Variable Naming Rules
A variable name:
Must begin with a letter or _
Cannot contain spaces
Should have a meaningful name
Cannot use C# keywords or reserved words

## String Variable
A string stores a combination of characters, such as names, phone numbers, or other text.
## String Concatenation
Concatenation means joining strings together. The + operator is used for concatenation.

## Local Variable
A local variable is a variable declared inside a method. It can only be accessed within that method.

## Scope
Scope is the part of a program where a variable can be accessed.
## Lifetime
Lifetime is the period during which a variable exists in memory while the program is running.
## Variable Initialization
Initialization means assigning a value to a variable.
## Assignment Compatibility
A value can only be assigned to a variable when the value is compatible with the variable's data type.

## Numeric Data Types and Variables

Numeric data types are used when a program needs to store and perform calculations with numbers.
## Data Type	Description
int	Stores whole numbers.
double	Stores numbers with decimal/fractional parts.
decimal	Stores decimal numbers with greater precision, commonly used for financial values.
## Numeric Literal
A numeric literal is a number written directly in the program.
A decimal literal uses m or M after the number.

## Type Casting
Type casting is explicitly converting a value from one data type to another.

## var Keyword
The var keyword allows C# to determine the variable's data type automatically from the value assigned to it.

## Performing Calculations
C# uses arithmetic operators to perform mathematical calculations.

Operator	Meaning
+	        Addition
-	        Subtraction
*	        Multiplication
/	        Division
%	        Modulus — remainder
## Integer Division
When two integers are divided, the result is an integer.

## Inputting and Outputting Numeric Values
Converting TextBox Input
TextBox input is always treated as a string, even when the user enters a number. Therefore, it must be converted to a numeric type before performing calculations.
## Common conversion methods:
int.Parse()
double.Parse()
decimal.Parse()

## Formatting Numbers with ToString()
The ToString() method can format numbers in different ways.
Format	Purpose	Example
"N"	Number format	12.300
"F"	Fixed-point format	123456.00
"E"	Exponential format	1.235e+005
"C"	Currency format	$1,234.56
"P"	Percentage format	23.40%

## Exception
An exception is an unexpected error that occurs while a program is running. Examples include invalid user input and dividing by zero.
## Exception Handling
Exception handling is the process of detecting and responding to runtime errors instead of allowing the program to stop unexpectedly.
## try-catch
The try block contains code that might cause an exception, while the catch block handles the exception.

## Named Constant
A named constant is a name that represents a value that cannot be changed during the program's execution.
The const keyword is used to declare a constant: