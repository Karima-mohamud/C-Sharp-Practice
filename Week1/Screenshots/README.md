## Displaying a Message Using MessageBox
In this example, a button click event is used to display a simple message to the user. When the user clicks the button, the messagebtn_click event runs and shows a message box containing "Hello World".
### code
```Csharp
private void messagebtn_click_Click(object sender, EventArgs e)
{
    // displaying message using messageBox
    MessageBox.Show("Hello World");
}

## Displaying Output in a Label Control
In this example, a button click event is used to display text in a Label control. When the user clicks the button, the btnanswer_Click event runs and changes the text of lblanswer to "Jamhuriya University".

### code
```Csharp
private void btnanswer_Click(object sender, EventArgs e)
{
    //Display Output in a Label Control
    lblanswer.Text = "Jamhuriya University";
}

## Creating a Clickable Image Using PictureBox
In this example, a PictureBox click event is used to make an image clickable. When the user clicks the image, the pictureboxclick_Click event runs and displays a message box containing "Welcome to our class".
### code
```Csharp
private void pictureboxclick_Click(object sender, EventArgs e)
{
    // creating clickable image 
    MessageBox.Show("Welcome to our class");
}

## Hiding a PictureBox Using the Visible Property
In this example, the Visible property of a PictureBox is used to hide the image. When the user clicks the picture, the pictureboxgirl_Click event runs and sets pictureboxgirl.Visible to false, making the picture disappear.

### code
```Csharp
private void pictureboxgirl_Click(object sender, EventArgs e)
{
    //using visible property of picture box
    pictureboxgirl.Visible = false;
}

## Closing the Form Using the Close Method
In this example, the Close() method is used to close the current form. When the user clicks the button, the btnclose_Click event runs and this.Close() closes the application window.

### code
```Csharp
private void btnclose_Click(object sender, EventArgs e)
{
    // using this.close() to exit
    this.Close();
}