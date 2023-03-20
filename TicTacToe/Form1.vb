Public Class Form1
    Private intRand As Integer = 1
    Private intButtonID As Integer = 0

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Reset()
        Button1.Text = "O"
        intButtonID = 1
        Timer1.Start()
    End Sub

    Private Sub Reset()

        For Each ctl In Controls

            If TypeOf ctl Is Button Then

                ctl.Text = ""

                ctl.Enabled = True

            End If

        Next ctl

        startButton.Text = "New Game"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) _
         Handles Timer1.Tick

        intRand += 1

        If intRand = 10 Then

            intRand = 1

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles Button1.Click,
            Button2.Click, Button3.Click, Button4.Click,
            Button5.Click, Button6.Click, Button7.Click,
            Button8.Click, Button9.Click

        sender.Text = "X"
        sender.Enabled = False

        Timer1.Stop()

        intButtonID = Int32.Parse(sender.tag)

        If intRand = intButtonID Then

            intRand = intRand + 1

        End If

        If intRand > 0 Then

            ComputerPlayer()

            intRand = 0

        ElseIf intRand = 0 Then

            Choices()

        End If


        WhoWins()

    End Sub
    Public Sub ComputerPlayer()

        Select Case intRand

            Case 1

                Button1.Text = "O"
                Button1.Enabled = False

            Case 2

                Button2.Text = "O"
                Button2.Enabled = False

            Case 3

                Button1.Text = "O"
                Button3.Enabled = False

            Case 4

                Button1.Text = "O"
                Button4.Enabled = False

            Case 5

                Button1.Text = "O"
                Button5.Enabled = False

            Case 6

                Button1.Text = "O"
                Button6.Enabled = False

            Case 7

                Button1.Text = "O"
                Button7.Enabled = False

            Case 8

                Button1.Text = "O"
                Button8.Enabled = False

            Case 9

                Button1.Text = "O"
                Button9.Enabled = False

        End Select

    End Sub
    Public Sub Choices()

        Select Case intButtonID
            Case 1

                If Button2.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button3.Text = "X" And
                  Button2.Enabled = True Then

                    Button2.Text = "O"
                    Button2.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button4.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False

                ElseIf Button7.Text = "X" And
                  Button4.Enabled = True Then

                    Button4.Text = "O"
                    Button4.Enabled = False

                ElseIf Button8.Text = "X" Or
                  Button6.Text = "X" Then

                    Play()

                End If

            Case 2

                If Button1.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button1.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button8.Enabled = True Then

                    Button8.Text = "O"
                    Button8.Enabled = False

                ElseIf Button8.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button6.Text = "X" Or
                  Button4.Text = "X" Or
                  Button7.Text = "X" Or
                  Button9.Text = "X" Then

                    Play()

                End If

            Case 3

                If Button1.Text = "X" And
                  Button2.Enabled = True Then

                    Button2.Text = "O"
                    Button2.Enabled = False

                ElseIf Button2.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button6.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button6.Enabled = True Then

                    Button6.Text = "O"
                    Button6.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False

                ElseIf Button7.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button8.Text = "X" Or
                  Button4.Text = "X" Then

                    Play()

                End If

            Case 4

                If Button1.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False

                ElseIf Button7.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button6.Enabled = True Then

                    Button6.Text = "O"
                    Button6.Enabled = False

                ElseIf Button6.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button2.Text = "X" Or
                  Button3.Text = "X" Or
                  Button8.Text = "X" Or
                  Button9.Text = "X" Then

                    Play()

                End If

            Case 5

                If Button1.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button2.Text = "X" And
                  Button8.Enabled = True Then

                    Button8.Text = "O"
                    Button8.Enabled = False

                ElseIf Button8.Text = "X" And
                  Button2.Enabled = True Then

                    Button2.Text = "O"
                    Button2.Enabled = False

                ElseIf Button3.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False

                ElseIf Button7.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button6.Text = "X" And
                  Button4.Enabled = True Then

                    Button4.Text = "O"
                    Button4.Enabled = False

                ElseIf Button4.Text = "X" And
                  Button6.Enabled = True Then

                    Button6.Text = "O"
                    Button6.Enabled = False

                End If

            Case 6

                If Button3.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button4.Enabled = True Then

                    Button4.Text = "O"
                    Button4.Enabled = False

                ElseIf Button4.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button1.Text = "X" Or
                  Button2.Text = "X" Or
                  Button7.Text = "X" Or
                  Button8.Text = "X" Then

                    Play()

                End If

            Case 7

                If Button1.Text = "X" And
                  Button4.Enabled = True Then

                    Button4.Text = "O"
                    Button4.Enabled = False

                ElseIf Button4.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button3.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button8.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button8.Enabled = True Then

                    Button8.Text = "O"
                    Button8.Enabled = False

                ElseIf Button6.Text = "X" Or
                  Button2.Text = "X" Then

                    Play()

                End If

            Case 8

                If Button2.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button2.Enabled = True Then

                    Button2.Text = "O"
                    Button2.Enabled = False

                ElseIf Button9.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False

                ElseIf Button7.Text = "X" And
                  Button9.Enabled = True Then

                    Button9.Text = "O"
                    Button9.Enabled = False

                ElseIf Button6.Text = "X" Or
                  Button3.Text = "X" Or
                  Button1.Text = "X" Or
                  Button4.Text = "X" Then

                    Play()

                End If

            Case 9

                If Button6.Text = "X" And
                  Button3.Enabled = True Then

                    Button3.Text = "O"
                    Button3.Enabled = False

                ElseIf Button3.Text = "X" And
                  Button6.Enabled = True Then

                    Button6.Text = "O"
                    Button6.Enabled = False

                ElseIf Button5.Text = "X" And
                  Button1.Enabled = True Then

                    Button1.Text = "O"
                    Button1.Enabled = False

                ElseIf Button1.Text = "X" And
                  Button5.Enabled = True Then

                    Button5.Text = "O"
                    Button5.Enabled = False

                ElseIf Button8.Text = "X" And
                  Button7.Enabled = True Then

                    Button7.Text = "O"
                    Button7.Enabled = False
                ElseIf Button7.Text = "X" And
                  Button8.Enabled = True Then

                    Button8.Text = "O"
                    Button8.Enabled = False

                ElseIf Button2.Text = "X" Or
                  Button4.Text = "X" Then

                    Play()

                End If

        End Select
    End Sub

    Public Sub Play()

        For Each ctl As Control In Me.Controls

            If intButtonID < 9 Then

                If (ctl.Name.StartsWith("Button" _
                  & intButtonID + 1)) Then

                    Dim btn As Button = DirectCast(ctl, Button)

                    If btn.Enabled = True Then

                        btn.Text = "O"
                        btn.Enabled = False

                    Else

                        intButtonID = intButtonID + 1

                    End If

                End If

            Else

                If (ctl.Name.StartsWith("Button1")) Then

                    Dim btn As Button = DirectCast(ctl, Button)

                    If btn.Enabled = True Then

                        btn.Text = "O"
                        btn.Enabled = False

                    Else

                        intButtonID = intButtonID + 1

                    End If

                End If

            End If

        Next

    End Sub
    Public Sub WhoWins()

        If (Button1.Text = "O" And Button2.Text = "O" _
            And Button3.Text = "O") _
            Or (Button4.Text = "O" And Button5.Text = "O" _
            And Button6.Text = "O") _
            Or (Button7.Text = "O" And Button8.Text = "O" _
            And Button9.Text = "O") _
            Or (Button1.Text = "O" And Button4.Text = "O" _
            And Button7.Text = "O") _
            Or (Button2.Text = "O" And Button5.Text = "O" _
            And Button8.Text = "O") _
            Or (Button3.Text = "O" And Button6.Text = "O" _
            And Button9.Text = "O") _
            Or (Button1.Text = "O" And Button5.Text = "O" _
            And Button9.Text = "O") _
            Or (Button7.Text = "O" And Button5.Text = "O" _
            And Button3.Text = "O") Then

            Label1.Text = "O Wins !"

            Reset()

        ElseIf (Button1.Text = "X" And Button2.Text = "X" _
            And Button3.Text = "X") _
            Or (Button4.Text = "X" And Button5.Text = "X" _
            And Button6.Text = "X") _
            Or (Button7.Text = "X" And Button8.Text = "X" _
            And Button9.Text = "X") _
            Or (Button1.Text = "X" And Button4.Text = "X" _
            And Button7.Text = "X") _
            Or (Button2.Text = "X" And Button5.Text = "X" _
            And Button8.Text = "X") _
            Or (Button3.Text = "X" And Button6.Text = "X" _
            And Button9.Text = "X") _
            Or (Button1.Text = "X" And Button5.Text = "X" _
            And Button9.Text = "X") _
            Or (Button7.Text = "X" And Button5.Text = "X" _
            And Button3.Text = "X") Then

            Label1.Text = "X Wins!"

            Reset()

        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
End Class
