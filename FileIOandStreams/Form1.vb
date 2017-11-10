Imports System.IO 'imports file I/O functionality

Public Class Form1

#Region "Main Program"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Text = "File Input & Output" 'set form title
        Me.TextBox1.Font = New Font("Calibri", 12) 'set font face and size
        Me.TextBox1.ScrollBars = ScrollBars.Vertical 'force vertial scrollbar

    End Sub
    'Use file I/O methods for read/write
    'This procedure will create a new text file and populate it with
    'supplied text (in this case, supplied as part of the procedure
    'but the text could just as easily come from user input) and then
    'save the file. The file is then opened in read mode and its contents
    'displayed in a text box.

    Private Sub TestFileIO()

        'declare and initalise variables
        Dim filename As String = ""
        Dim inputText As String = ""
        Dim inputLine As String = ""
        Dim filenumber As Integer = 0

        'set the fileName
        filename = Directory.GetCurrentDirectory() & "\ReadWrite.txt"

        'find an unused file number
        'you must request an avadiable file number bfore attemptin to open
        'a file for reading or writing. Each open file is assinged a file number.
        filenumber = FreeFile()

        'open the text file for output
        FileOpen(filenumber, filename, OpenMode.Output, OpenAccess.Write)

        'write some lines of text to the file
        WriteLine(filenumber, "Soup Soup Tasty Soup")
        WriteLine(filenumber, "Spicy carrot and corriander")
        WriteLine(filenumber, "Chili chowder")
        WriteLine(filenumber, "Crouton Crouton")
        WriteLine(filenumber, "Crunch friends in a liquid broth")
        WriteLine(filenumber, "I am gespatchio Oh!")
        WriteLine(filenumber, "I am a summer soup mmmm!")
        WriteLine(filenumber, "Miso Miso")
        WriteLine(filenumber, "Fighting in the dojo")
        WriteLine(filenumber, "Miso Miso")
        WriteLine(filenumber, "Oritental Prince in the land of soup")

        'close the file
        FileClose(filenumber)

        'find an unused file number 
        filenumber = FreeFile()

        'open text file for input
        FileOpen(filenumber, filename, OpenMode.Input, OpenAccess.Read)

        'read contents of file into temporary variable
        Do Until EOF(filenumber)
            inputLine = LineInput(filenumber)
            inputText += inputLine.Substring(1, inputLine.Length - 2) & vbCrLf
        Loop

        'close the file
        FileClose(filenumber)

        'Display contents of the file
        TextBox1.Text = "Testing File 





    End Sub
#End Region
End Class
