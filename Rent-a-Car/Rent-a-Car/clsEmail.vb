Imports System.Net.Mail 'Espacio de Nombre para el envio de correos
Imports System.IO
Imports System.Drawing.Imaging
Public Class clsEmail
    Private smtpServer As New SmtpClient()
    Private mensaje As New MailMessage()
    Public Sub enviarCorreo(ByVal cliente As clsClientes, ByVal coche As clsCoches, ByVal totalPagar As Decimal)

        'Dim objBmp As New Bitmap(My.Resources.AF)
        'Dim img As Image = Image.FromFile(Path.Combine(Application.StartupPath, "\Resources\AF.jpg"))
        'Dim propItems As PropertyItem() = img.PropertyItems
        'Dim encoding As New System.Text.ASCIIEncoding()
        Dim filepath As String = Application.StartupPath
        Dim directoryName As String
        Dim x As Integer = 0
        Dim i As Integer = 0
        Do
            'Guardamos el nombre - ruta del directorio que se pasa como parametro
            directoryName = Path.GetDirectoryName(filepath)

            'Guardamos la ruta del directorio
            filepath = directoryName

            If i = 1 Then
                filepath = directoryName + "\" 'Damos saltos de línea hacia atrás
            End If
            i = i + 1
            x += 1 'Variable controladora del bucle
        Loop While (x < 2)

        Try
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential("ezic2017@gmail.com", "niu126/17/9.pjc.IEY")
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True

            mensaje.From = New MailAddress("ezic2017@gmail.com")
            mensaje.To.Add(cliente.ObetenerCorreoElectronico)
            mensaje.Subject = "Rent a car: Reserva de coche"
            mensaje.IsBodyHtml = True

            'Se agregan los datos del cliente
            mensaje.Body += "<h1> Datos del Cliente </h1>"
            mensaje.Body += "<ul>"
            mensaje.Body += "<li><b>Usuario: </b>" & cliente.ObtenerNombreDeUsuari & "</li>"
            mensaje.Body += "<li><b>Ciudad: </b>" & cliente.ObtenerCiudad & "</li>"
            mensaje.Body += "<li><b>Dui: </b> " & cliente.ObtenerDui & "</li>"
            mensaje.Body += "<li><b>Pasaporte: </b> " & cliente.ObtenerPasaporte & "</li>"
            mensaje.Body += "</ul>"

            'Se agregan los datos del coche
            mensaje.Body += "<h1> Datos del Coche </h1>"
            mensaje.Body += "<ul>"
            mensaje.Body += "<li><b>Marca: </b>" & coche.ObtenerMarca & "</li>"
            mensaje.Body += "<li><b>Modelo: </b> " & coche.ObtenerModelo & "</li>"
            mensaje.Body += "<li><b>Color: </b>" & coche.ObtenerColor & "</li>"
            mensaje.Body += "<li><b>Num pasajeros: </b>" & coche.ObtenerNPasajeros & "</li>"
            mensaje.Body += "<li><b>Precio de alquiler: </b>$" & coche.ObtenerPrecioAlquiler & "</li>"
            mensaje.Body += "<li><b>Total a pagar: </b>$" & totalPagar & "</li>"
            mensaje.Body += "</ul>"

            Dim attachement As Attachment
            attachement = New System.Net.Mail.Attachment(filepath + "\Resources\Coches\" & coche.ObtenerFotografia & "")
            mensaje.Attachments.Add(attachement)
            smtpServer.Send(mensaje)
        Catch ex As Exception
            MsgBox("Error: El correo electrónico no se ha enviado correctamente")
        End Try

    End Sub
End Class
