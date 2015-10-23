Public Class validate
    Public Function is_name(ByVal input As String) As Boolean
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
    Public Function is_fname(ByVal input As String) As Boolean
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
    Public Function is__number(ByVal input As String) As Boolean
        Dim output As Boolean = True
        For Each i As Char In input
            If Not Char.IsDigit(i) Then
                output = False
            End If
        Next
        Return output
    End Function
    Public Function is_des(ByVal input As String) As Boolean

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
End Class
