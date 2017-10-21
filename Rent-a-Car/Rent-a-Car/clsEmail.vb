Imports System.Net.Mail 'Espacio de Nombre para el envio de correos
Imports System.IO
Imports System.Drawing.Imaging
Public Class clsEmail
    '_______________________________________________
    '|    Atributos de configuración de la clase    |
    '|______________________________________________|
    Private smtpServer As New SmtpClient()
    Private mensaje As New MailMessage()
    '________________________________________________
    '|     Métodos generales de la clase            |
    '|______________________________________________|
    Public Sub enviarCorreo(ByVal cliente As clsClientes, ByVal coche As clsCoches, ByVal totalPagar As Decimal) 'Metodo para enviar la reserva

        Dim filepath As String = Application.StartupPath
        Dim directoryName As String
        Dim x As Integer = 0
        Dim i As Integer = 0

        Do 'Obtenemos la carpeta coches (Donde se guardan las imagenes)
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
            smtpServer.UseDefaultCredentials = False 'Desactivamos credenciales por defecto
            smtpServer.Credentials = New Net.NetworkCredential("ezic2017@gmail.com", "niu126/17/9.pjc.IEY") 'Agregamos el correo de donde enviaremos datos
            smtpServer.Port = 587 'Activamos puerto SMPT
            smtpServer.Host = "smtp.gmail.com" 'El host de donde se enviará (En este caso el de Gmail)
            smtpServer.EnableSsl = True 'Activamos la seguridad Ssl

            mensaje.From = New MailAddress("ezic2017@gmail.com") 'Correo donde se enviará

            mensaje.To.Add(cliente.ObetenerCorreoElectronico) 'Correo del cliente
            mensaje.Subject = "Rent a car: Reserva de coche" 'Asunto
            mensaje.IsBodyHtml = True 'Activamos el cuerpo del mensaje como html
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

            Dim attachement As Attachment 'Guarda la imagen
            attachement = New System.Net.Mail.Attachment(filepath + "\Resources\Coches\" & coche.ObtenerFotografia & "") 'Agregamos como documento la fotografía del auto
            mensaje.Attachments.Add(attachement) 'Se agrega al cuerpo del mensaje
            smtpServer.Send(mensaje) 'Se manda el mensaje
        Catch ex As Exception
            MsgBox("Error: El correo electrónico no se ha enviado correctamente")
        End Try
    End Sub

    Public Function RecuperarContrasenna(ByVal emailUsuario As String, ByVal contrasenna As String) As Boolean 'Metodo para enviar la contraseña recuperada
        Try
            smtpServer.UseDefaultCredentials = False 'Desactivamos credenciales por defecto
            smtpServer.Credentials = New Net.NetworkCredential("ezic2017@gmail.com", "niu126/17/9.pjc.IEY") 'Agregamos el correo de donde enviaremos datos
            smtpServer.Port = 587 'Activamos puerto SMPT
            smtpServer.Host = "smtp.gmail.com" 'El host de donde se enviará (En este caso el de Gmail)
            smtpServer.EnableSsl = True 'Activamos la seguridad Ssl
            mensaje.From = New MailAddress("ezic2017@gmail.com") 'Correo donde se enviará

            mensaje.To.Add(emailUsuario) 'Destinatario
            mensaje.Subject = "Rent a car: Recuperación de contraseña" 'Titulo del mensaje
            mensaje.IsBodyHtml = True 'Activamos el cuerpo del mensaje como html
            mensaje.Body = "<b>Contraseña: </b>" & contrasenna 'Mensaje
            smtpServer.Send(mensaje) 'Mandamos el mensaje
            Return 1
        Catch ex As Exception
            MsgBox("Error: El correo electrónico no se ha enviado correctamente")
            Return 0
        End Try
    End Function

    Public Function Registro(ByVal _correo As String, ByVal _nombreUsuario As String, ByVal _contrasenna As String) As Boolean 'Se envía el correo al usuario cuando se registra
        Try
            smtpServer.UseDefaultCredentials = False 'Desactivamos credenciales por defecto
            smtpServer.Credentials = New Net.NetworkCredential("ezic2017@gmail.com", "niu126/17/9.pjc.IEY") 'Agregamos el correo de donde enviaremos datos
            smtpServer.Port = 587 'Activamos puerto SMPT
            smtpServer.Host = "smtp.gmail.com" 'El host de donde se enviará (En este caso el de Gmail)
            smtpServer.EnableSsl = True 'Activamos la seguridad Ssl
            mensaje.From = New MailAddress("ezic2017@gmail.com") 'Correo donde se enviará

            mensaje.To.Add(_correo) 'Destinatario
            mensaje.Subject = "Rent a car: Bienvenido!" 'Titulo del mensaje
            mensaje.IsBodyHtml = True 'Activamos el cuerpo del mensaje como html
            mensaje.Body += "<b>Nombre de Usuario: </b>" & _nombreUsuario & "<br>" 'Mensaje
            mensaje.Body += "<b>Contraseña: </b>" & _contrasenna 'Mensaje
            smtpServer.Send(mensaje) 'Mandamos el mensaje
            Return 1
        Catch ex As Exception
            MsgBox("Error: El correo electrónico no se ha enviado correctamente")
            Return 0
        End Try
    End Function
End Class
