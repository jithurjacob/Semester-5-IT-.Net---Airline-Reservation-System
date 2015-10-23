Imports System.Text.RegularExpressions
Public Class valid
    Public Function is_mobile_number(input As String) As Boolean
        Dim output As Boolean = True
        '    input = input.Replace("-", "")
        ' Dim regex As Regex = New Regex("[1-9]")

        'Dim match As Match = regex.Match(input)
        If input.Length <> 10 Then
            output = False
        End If
        For Each i As Char In input
            If Not Char.IsDigit(i) Then
                output = False
            End If
        Next
        Return output
    End Function

    Public Function is_postive_number_only(input As String) As Boolean
        Dim output As Boolean = True
        For Each i As Char In input
            If Not (Char.IsDigit(i) Or Val(i) < 0) Then
                output = False
            End If
        Next

        Return output
    End Function
    Public Function number_only(input As String) As Boolean
        If input.StartsWith("-") Then
            input.Reverse()
            input.Remove(1)
            input.Reverse()
        End If
        If input.Contains(".") Then
            Dim count As Integer = 0
            For Each i As Char In input
                If i.ToString.Equals(".") Then
                    count += 1
                End If
            Next
            If count > 1 Then
                Return False
            Else
                input = input.Replace(".", "")
            End If
        End If
        Dim output As Boolean = True
        For Each i As Char In input
            If Not Char.IsDigit(i) Then
                output = False
            End If
        Next
        Return output
        Return output
    End Function

    Public Function is_alphabet_only(input As String) As Boolean
        Dim output As Boolean = True
        For Each i As Char In input
            If Not Char.IsLetter(i) Then
                output = False
            End If

        Next

        Return output
    End Function

    Public Function is_email(input As String) As Boolean
        If Not ((input.Contains("@")) And (input.Contains("."))) Then
            Return False
        End If
        ' MsgBox("ok checked @.")
        Dim count As Integer = 0
        For Each ch As Char In input
            If ch.ToString.Equals("@") Or ch.ToString.Equals(".") Then
                count += 1

            End If
            If Not (ch.ToString.Equals("@") Or ch.ToString.Equals(".") Or Char.IsLetterOrDigit(ch) Or ch.ToString.Equals("_")) Then
                ' MsgBox(ch.ToString)
                Return False
            End If
        Next
        ' MsgBox(count.ToString)
        If (count <> 2) Then
            Return False
        End If
        ' MsgBox("ok checked each character")
        Dim output As Boolean = True
        Dim id, site, post As String
        Dim str() As String = input.Split("@")
        Dim str1() As String = str(1).Split(".")
        id = str(0)
        site = str1(0)
        post = str1(1)

        If id.Length < 6 Then
            MsgBox("EMail id is too short eg. johndoe@gmail.com")
            Return False
        End If
        If Not (site.Equals("gmail") Or site.Equals("yopmail") Or site.Equals("yahoo") Or site.Equals("live")) Then
            MsgBox("EMail provider is missing eg. johndoe@gmail.com")
            Return False
        End If
        If Not (post.Equals("com") Or post.Equals("in")) Then
            MsgBox("post item is missing eg. johndoe@gmail.com")
            Return False
        End If


        Return output
    End Function

    Public Function is_name(input As String) As Boolean
        If input.Length < 3 Then
            Return False
        End If
        Dim output As Boolean = True
        For Each i As Char In input
            If Not (Char.IsLetter(i) Or Char.IsSeparator(i)) Then
                output = False
            End If

        Next

        Return output
    End Function

    Public Function is_age(input As String) As Boolean

        Dim output As Boolean = True
        For Each i As Char In input
            If Not Char.IsDigit(i) Then
                Return False
            End If
        Next

        Dim f As Int32
        f = Convert.ToInt32(input)

        ' MsgBox(f.ToString + output.ToString)
        If (output) Then

            If (f <= 0) Or f > 120 Then
                ' MsgBox(f.ToString)
                Return False
            End If

        End If

        Return output
    End Function

    Public Function contains_space(ByVal input As String) As Boolean
        Dim output As Boolean = True
        For Each i As Char In input
            If Char.IsWhiteSpace(i) Then
                output = False
            End If

        Next

        Return output
    End Function
End Class
