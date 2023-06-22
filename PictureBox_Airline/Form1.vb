Imports System.IO
Imports System.Reflection

Public Class Form1
    Dim BizClass(20) As PictureBox      'Biz = Business
    Dim BizClassNames(20) As RichTextBox
    Dim EcoClass(100) As PictureBox     'Eco = Economy
    Dim EcoClassNames(100) As RichTextBox
    Dim NameBoxes(2) As TextBox
    Dim Names(2) As String 'Names(2)=> make 2 arrays
    Dim airlineSeatRelativePath As String = "..\..\..\IMG\airlineSeat.png"
    Dim airlineSeatEmptyRelativePath As String = "..\..\..\IMG\airlineSeatEmpty.png"
    'Dim myImageLocationPrefix As String = "C:\Repo\VB\PictureBox_Airline\PictureBox_Airline\bin\Debug\net6.0-windows"
    Dim imagePathSeatPath As String = Path.GetFullPath(airlineSeatRelativePath)
    Dim imagePathSeatEmptyPath As String = Path.GetFullPath(airlineSeatEmptyRelativePath)
    'Dim EmptySeatImg As String = "./airlineSeatEmpty.png" '이미지가 아닌 Text로 받으로 string type.
    'Dim FullSeatImg As String = "./airlineSeat.png"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '------------ Business Class  

        Dim xLocation As Integer = 10 'Form1의 왼쪽에서부터 시작하는데 10pixel의 space를 두고 시작
        Dim yLocation As Integer = 10 'Form1의 위에서부터 시작하는데 10pixel의 space를 두고 시작
        Names(0) = "First Name"
        Names(1) = "Last Name"

        For index = 0 To 19 'loop for 20 seats
            'Mybox is where we are instantiating the PictureBoxObject
            BizClass(index) = New PictureBox() With { 'New PictureBox: PIctureBox라는 큰 덩어리의 것을 새로 부른다.
            .ImageLocation = imagePathSeatEmptyPath,
            .Size = New Size(200, 200),
            .Location = New Point(xLocation, yLocation),
            .Name = "BizPictureBox" + index.ToString(),
            .Visible = True,
            .Enabled = True,
            .Cursor = Cursors.Hand
            } ' Inside the curly braces is where we add the properties
            BizClassNames(index) = New RichTextBox() With {
            .Size = New Size(200, 100), 'New = memory allocator, Size = a type like integer, point, string.
            .Location = New Point(xLocation, yLocation + 205),
            .Name = "RichTextBox" + index.ToString(),
            .Visible = True,
            .Enabled = True,
            .Cursor = Cursors.Hand
            }

            AddHandler BizClass(index).Click, AddressOf PictureBoxClick 'bizclass가 클릭되면, PictureBoxClick이라는 함수를 호출해라
            'Me.Controls.Add(BusinessClass(index)) 'Me is a reference to the form1, to translate it would be form1.controls.Add(MyBox). This adds MyBox to form1

            TabPage1.Controls.Add(BizClass(index))
            TabPage1.Controls.Add(BizClassNames(index))

            xLocation += 210
            If (index + 1) Mod 4 = 0 Then '이미지가 5개가 되면 다음칸으로 가도록 하는 코드
                xLocation = 10
                yLocation += 310
            End If
        Next

        '------------Economy Class

        xLocation = 10
        yLocation = 10

        For index = 0 To 99 'For loop 100 seats
            EcoClass(index) = New PictureBox() With {
            .ImageLocation = imagePathSeatEmptyPath,
            .Size = New Size(200, 200),
            .Location = New Point(xLocation, yLocation),
            .Name = "EcoPictureBox" + index.ToString(),
            .Visible = True,
            .Enabled = True,
            .Cursor = Cursors.Hand
            }
            EcoClassNames(index) = New RichTextBox() With {
            .Size = New Size(200, 100),
            .Location = New Point(xLocation, yLocation + 205),
            .Name = "RichTextBox" + index.ToString(),
            .Visible = True,
            .Enabled = True,
            .Cursor = Cursors.Hand
            }

            AddHandler EcoClass(index).Click, AddressOf PictureBoxClick

            TabPage2.Controls.Add(EcoClass(index))
            TabPage2.Controls.Add(EcoClassNames(index))

            xLocation += 210
            If (index + 1) Mod 4 = 0 Then
                xLocation = 10
                yLocation += 310
            End If
        Next
    End Sub

    Private Sub PictureBoxClick(sender As Object, e As EventArgs) 'PictureBoxClick: function, sender& e: parameter, Object& EventArgs: type
        Dim PictureBoxClicked As PictureBox = sender
        Dim PictureBoxIndex As Integer = Convert.ToInt32(PictureBoxClicked.Name.Substring(13)) '베열의 index는 무조건 숫자여야 해서 이름에서 글자를 빼고 String인 "1"을 타입변환(to integer)해서 PictureBoxIndex에 넣어 index로 사용. 배열은 덩어리기 때문에 인덱스를 사용하여 위치(주소)를 찾음
        Dim BizOrEco As String = (PictureBoxClicked.Name.Substring(0, 3))
        NameBoxes(0) = TextBox3
        NameBoxes(1) = TextBox4

        If BizOrEco = "Biz" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And BizClassNames(PictureBoxIndex).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If

        If BizOrEco = "Eco" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And EcoClassNames(PictureBoxIndex).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If

        If PictureBoxClicked.ImageLocation = imagePathSeatEmptyPath And BizOrEco = "Biz" Then
            PictureBoxClicked.ImageLocation = imagePathSeatPath
            BizClassNames(PictureBoxIndex).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text} "
            Return
        End If

        If PictureBoxClicked.ImageLocation = imagePathSeatEmptyPath And BizOrEco = "Eco" Then
            PictureBoxClicked.ImageLocation = imagePathSeatPath
            EcoClassNames(PictureBoxIndex).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text} "
            Return
        End If

        '--------- Cancellation

        If PictureBoxClicked.ImageLocation = imagePathSeatPath And BizOrEco = "Biz" Then

            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = imagePathSeatEmptyPath
                BizClassNames(PictureBoxIndex).Text = ""
                MessageBox.Show($"Your reservation has been cancelled.")
            ElseIf result = DialogResult.No Then
                MessageBox.Show($"Thank you for your reservation!")
            End If
            Return
        End If

        If PictureBoxClicked.ImageLocation = imagePathSeatPath And BizOrEco = "Eco" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = imagePathSeatEmptyPath
                EcoClassNames(PictureBoxIndex).Text = ""
                MessageBox.Show($"Your reservation has been cancelled.")
            ElseIf result = DialogResult.No Then
                MessageBox.Show($"Thank you for your reservation!")
            End If
            Return
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
