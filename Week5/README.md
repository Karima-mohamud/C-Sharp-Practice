# Chapter 4 Part 2 Files
## Topics
Using Files for Data Storage
The OpenFileDialog and SaveFileDialog Controls

### Using Files for Data Storage

File handling allows a program to save data for later use and retrieve previously saved data.

There are three main steps in file handling:

1. `Open the file:` Establish a connection between the file and the program.
2. `Process the file:` Read data from the file or write data to it.
3. `Close the file:` Disconnect the file from the program.

### Types of Files
There are two main types of files:
- ``Text File:`` Contains data encoded as text using a character encoding scheme such as Unicode.
- `Binary File:` Contains data st\ored in binary format and cannot normally be understood by reading it in a text editor.

##  File Accessing Classes

.NET provides two important classes for working with text files:

 `StreamWriter`:  Writes data to a text file. 
 `StreamReader `:Reads data from a text file. 

A `file object` is an object associated with a specific file that allows a program to work with that file.

## Writing Data to a File
To write data to a file, we use the `StreamWriter` class.

##  Write() vs WriteLine()

Both methods are used to write data into a file.

 Write() :  Writes data without adding a new line.
 WriteLine():rites data and adds a new line. 

##  CreateText() vs AppendText()
Both methods create a StreamWriter object, but they handle existing file content differently.
### CreateText()
- Creates a new file if it does not exist.
- If the file already exists, its previous content is erased.
- Returns a StreamWriter object.

### AppendText()
- Adds new data to the end of an existing file.
- Preserves the previous content.
- Creates the file if it does not exist.
- Returns a StreamWriter object.


##  Specifying the Location of an Output File

We can specify a file path to save a file in a particular directory.

### Example

```csharp
StreamWriter outputFile;

outputFile = File.AppendText(@"C:\Data\Names.txt");

outputFile.Close();
```
The `@` symbol allows us to write a Windows path without escaping each backslash.

We can also use double backslashes:
```csharp
outputFile = File.CreateText("D:\\C#\\courses.txt");
```


##  Reading Data from a File

To read data from a text file, we use the `StreamReader` class.


##  Reading Methods

StreamReader provides different methods for reading data.

ReadLine() :Reads one line and returns it as a string. 
 Read() : Reads the next character and returns its integer character code, or -1 at the end. 
 ReadToEnd() : Reads all remaining characters and returns them as a string.

The `File` class also provides:

- `File.ReadAllText():` Reads the entire file and returns its content as a string.

##  Reading a File with a Loop

The `EndOfStream` property is a Boolean property that indicates whether the end of a file has been reached.
We can use it with a while loop to read a file line by line.


##  OpenFileDialog and SaveFileDialog
These controls allow an application to display standard Windows dialog boxes for opening and saving files.

They are `invisible controls`, meaning they do not appear directly on the form. Instead, they appear in the component tray in the Windows Forms Designer.
OpenFileDialog = Displays a dialog box for selecting a file to open. 
SaveFileDialog = Displays a dialog box for selecting where to save a file. 

## OpenFileDialog
The OpenFileDialog control allows users to select an existing file.

The `ShowDialog()` method displays the Open dialog box.

##  Detecting the User's Selection

The `ShowDialog()` method returns a `DialogResult` value.
- `DialogResult.OK`: The user clicks Open.
- `DialogResult.Cancel`: The user cancels the operation.


## FileName and InitialDirectory Properties

### FileName Property

The `FileName` property stores the selected file's path and filename.

### Example

```csharp
StreamReader inputFile;

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);

    string content = inputFile.ReadToEnd();

    MessageBox.Show(content);

    inputFile.Close();
}
```

### InitialDirectory Property

The `InitialDirectory` property specifies which folder appears first when the dialog box opens.

##  SaveFileDialog

The SaveFileDialog control displays a standard Windows Save As dialog box. It allows the user to select a filename and location for saving a file.
