Public Class clsEncriptacion
    Private numeros = New String(9) {"e", "l", "a", "y", "A", "L", "F", "R", "o", "p"}
    Private letras = New String(53) {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Private espacio = New String(4) {"-", "*", "/", "!", "?"}

    Private Function verificarNumero(ByVal caracter As String) As String
        For i As Long = 0 To (numeros.Length - 1)
            If caracter = CStr(i) Then
                Return MyClass.numeros(i)
            End If
        Next
        Return "-1"
    End Function

    Private Function verificarLetra(ByVal caracter As String) As String
        For i As Long = 0 To (letras.Length - 1)
            If caracter = letras(i) Then
                Return i
            End If
        Next
        Return "-1"
    End Function

    Private Function verificarEspacio(ByVal caracter As String) As Boolean
        For i As Long = 0 To (espacio.Length - 1)
            If caracter = espacio(i) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ArmarEncriptacion(ByVal _contrasenna As String) As String
        Dim _contraEncriptada = ""

        For Each i As String In _contrasenna
            Dim _ascciCaracter, _longitudCaracter, _verificarNumero, _verificarLetra As String
            _ascciCaracter = Asc(i)
            _longitudCaracter = _ascciCaracter.Length
            _verificarNumero = MyClass.verificarNumero(i)
            _verificarLetra = MyClass.verificarLetra(i)
            Dim _randomEspacio As New Random()

            If _verificarNumero <> "-1" Then
                _contraEncriptada += _ascciCaracter & _verificarNumero & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            ElseIf _verificarLetra <> "-1" Then
                _contraEncriptada += _ascciCaracter & _verificarLetra & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            Else
                _contraEncriptada += _ascciCaracter & _longitudCaracter & MyClass.espacio(_randomEspacio.Next(0, 5))
            End If
        Next
        Return _contraEncriptada
    End Function

    Public Function DesarmarEncriptacion(ByVal _contrasenna As String) As String
        Dim _contraDesencriptada = "", palabra As String = ""
        For Each i As String In _contrasenna
            If MyClass.verificarEspacio(i) Then
                Dim _longitudPalabra, _ascciCaracter As String
                _longitudPalabra = palabra.Substring(palabra.Length - 1)
                _ascciCaracter = palabra.Substring(0, _longitudPalabra)
                _contraDesencriptada += Chr(_ascciCaracter)
                palabra = ""
            Else
                palabra += i
            End If
        Next
        Return _contraDesencriptada
    End Function
End Class
