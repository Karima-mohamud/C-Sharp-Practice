# C# File  Assignment

## Question 1: Explain Other Reading Functions in C#

**Answer:**
C# provides different methods for reading files. One additional method is `File.ReadLines()`.
### Code:
```csharp
private void btnotherfunction_Click(object sender, EventArgs e)
{
    // Other reading function
    foreach (string line in File.ReadLines("Info.txt"))
    {
        Result.Items.Add(line);
    }
}
```

### Explanation:
- `File.ReadLines()` reads a file line by line.
- `foreach` goes through each line in the file.
- `Result.Items.Add(line)` displays each line in the ListBox.
---

## Question 2: How to Delete a File in C#?

**Answer:**
I use the `File.Delete()` method to delete a file.

### Code:
```csharp
private void btndeletefile_Click(object sender, EventArgs e)
{
    // Deleting file
    if (File.Exists("Info.txt"))
    {
        File.Delete("Info.txt");
        MessageBox.Show("File deleted successfully");
    }
    else
    {
        MessageBox.Show("File not found");
    }
}
```

### Explanation:
- `File.Exists()` checks whether the file exists.
- `File.Delete()` deletes the specified file.
- If the file does not exist, a message is displayed.

---

## Question 3: How to Delete an Item Inside a File?

**Answer:**
I used `File.ReadAllText()`, `Replace()`, and `File.WriteAllText()` to remove specific text from a file.

### Code:
```csharp
private void btndeleteitem_Click(object sender, EventArgs e)
{
    // Deleting item in file
    string content = File.ReadAllText("Info.txt");

    content = content.Replace("C#", "");

    File.WriteAllText("Info.txt", content);
}
```

### Explanation:
- `File.ReadAllText()` reads the entire file content.
- `Replace("C#", "")` removes the specified text.
- `File.WriteAllText()` saves the updated content back into the file.

**Note:** This removes every occurrence of `C#` from the file, not just one complete line.

