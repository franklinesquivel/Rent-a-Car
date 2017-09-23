
Public Class clsCliente



    'Atributos
    Private _IdCliente As String
    Private _Dui As String
    Private _Pasaporte As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Direccion As String
    Private _Ciudad As String
    Private _Email As String
    Private _Pais As String

    'Bandera
    Private _ReservaEstado As Boolean

    Public Function registrarDatos(ByVal dui As String, ByVal pasaporte As String, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal ciudad As String, ByVal email As String, ByVal pais As String) As Boolean

        dui = dui.Trim
        pasaporte = pasaporte.Trim
        nombre = nombre.Trim
        apellido = apellido.Trim
        direccion = direccion.Trim
        ciudad = ciudad.Trim
        email = email.Trim
        pais = pais.Trim

        If dui.Length = 0 Then
            MsgBox("Ingrese su DUI!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Dui = dui
        End If

        If pasaporte.Length = 0 Then
            MsgBox("Ingrese su Pasaporte!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Pasaporte = pasaporte
        End If

        If nombre.Length = 0 Then
            MsgBox("Ingrese su Nombre!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Nombre = nombre
        End If

        If apellido.Length = 0 Then
            MsgBox("Ingrese su Apellido!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Apellido = apellido
        End If

        If direccion.Length = 0 Then
            MsgBox("Ingrese su Dirección!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Direccion = direccion
        End If

        If ciudad.Length = 0 Then
            MsgBox("Ingrese su Ciudad!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Ciudad = ciudad
        End If

        If email.Length = 0 Then
            MsgBox("Ingrese su Email!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Email = email
        End If

        If pais.Length = 0 Then
            MsgBox("Ingrese su País!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Pais = pais
        End If

        Return True

    End Function









End Class
