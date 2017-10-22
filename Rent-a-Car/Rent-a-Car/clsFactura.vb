Imports System.IO 'Working With Files
Imports System.Text 'Working With Text
Imports iTextSharp.text 'Core PDF Text Functionalities
Imports iTextSharp.text.pdf 'PDF Content
Imports iTextSharp.text.pdf.parser 'Content Parser
Imports MySql.Data.MySqlClient

Public Class clsFactura
    Public Sub GenerarPDF(ByVal cliente As clsClientes, ByVal coche As clsCoches, ByVal totalPagar As Decimal, ByVal fecha As Date)
        Dim oDoc As New iTextSharp.text.Document(PageSize.A4, 0, 0, 0, 0)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim cb As PdfContentByte
        Dim fuente As iTextSharp.text.pdf.BaseFont
        Dim nombre = cliente.ObtenerNombreDeUsuari
        Dim NombreArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/" & nombre & ".pdf"
        Try
            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo,
            FileMode.Create, FileAccess.Write, FileShare.None))
            'Apertura del documento.
            oDoc.Open()
            cb = pdfw.DirectContent
            'Agregamos una pagina.
            oDoc.NewPage()
            'Iniciamos el flujo de bytes.
            cb.BeginText()
            'Instanciamos el objeto para la tipo de letra.
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
            'Seteamos el tipo de letra y el tamaño.
            cb.SetFontAndSize(fuente, 12)
            'Seteamos el color del texto a escribir.
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            'Aqui es donde se escribe el texto.
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Rent-a-Car", 75, PageSize.A4.Height - 50, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Factura de Renta", 200, PageSize.A4.Height - 65, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Datos del Cliente", 100, PageSize.A4.Height - 90, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Usuario: " & cliente.ObtenerNombreCompleto, 150, PageSize.A4.Height - 115, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ciudad: " & cliente.ObtenerCiudad, 150, PageSize.A4.Height - 140, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Datos del Coche:", 200, PageSize.A4.Height - 165, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Marca: " & coche.ObtenerMarca, 150, PageSize.A4.Height - 190, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Modelo: " & coche.ObtenerModelo, 150, PageSize.A4.Height - 215, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Color: " & coche.ObtenerColor, 150, PageSize.A4.Height - 240, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Num pasajeros: " & coche.ObtenerNPasajeros, 150, PageSize.A4.Height - 265, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha de devolucion: " & fecha.ToString, 350, PageSize.A4.Height - 215, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Precio de alquiler: $" & coche.ObtenerPrecioAlquiler, 350, PageSize.A4.Height - 300, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Total a pagar: $" & totalPagar, 350, PageSize.A4.Height - 330, 0)
            'Fin del flujo de bytes.
            cb.EndText()
            'Forzamos vaciamiento del buffer.
            pdfw.Flush()
            'Cerramos el documento.
            oDoc.Close()
        Catch ex As Exception
            'Si hubo una excepcion y el archivo existe ...
            If File.Exists(NombreArchivo) Then
                'Cerramos el documento si esta abierto.
                'Y asi desbloqueamos el archivo para su eliminacion.
                If oDoc.IsOpen Then oDoc.Close()
                '... lo eliminamos de disco.
                File.Delete(NombreArchivo)
            End If
            Throw New Exception("Error al generar archivo PDF")
        Finally
            cb = Nothing
            pdfw = Nothing
            oDoc = Nothing
        End Try
        EjecutarArchivos(NombreArchivo)
    End Sub

    Public Sub GenerarPDFDatosReserva(ByVal idReserva As String, ByVal TotalPagar As String)
        Dim reader As MySqlDataReader
        Dim Conexion As New clsConexion
        Conexion.obtenerDatos("SELECT cl.nombre, cl.nombre_usuario , cl.apellido, cl.ciudad, c.marca, c.modelo, c.color, c.num_pasajeros, c.precio_alquiler, r.fecha_devolucion FROM reservas r INNER JOIN coches c ON c.id_coche = r.id_coche INNER JOIN clientes cl ON cl.id_cliente = r.id_cliente WHERE r.id_reserva = '" & idReserva & "'", reader)
        reader.Read() 'Listo para lectura
        Dim oDoc As New iTextSharp.text.Document(PageSize.A4, 0, 0, 0, 0)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim cb As PdfContentByte
        Dim fuente As iTextSharp.text.pdf.BaseFont
        Dim nombre = reader(1)
        Dim NombreArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "/" & nombre & ".pdf"
        Try
            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(NombreArchivo,
            FileMode.Create, FileAccess.Write, FileShare.None))
            'Apertura del documento.
            oDoc.Open()
            cb = pdfw.DirectContent
            'Agregamos una pagina.
            oDoc.NewPage()
            'Iniciamos el flujo de bytes.
            cb.BeginText()
            'Instanciamos el objeto para la tipo de letra.
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
            'Seteamos el tipo de letra y el tamaño.
            cb.SetFontAndSize(fuente, 12)
            'Seteamos el color del texto a escribir.
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            'Aqui es donde se escribe el texto.
            'Aclaracion: Por alguna razon la coordenada vertical siempre es tomada desde el borde inferior (de ahi que se calcule como "PageSize.A4.Height - 50")
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Rent-a-Car", 75, PageSize.A4.Height - 50, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Factura de Renta", 200, PageSize.A4.Height - 65, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Datos del Cliente", 100, PageSize.A4.Height - 90, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Usuario: " & reader(0) & " " & reader(2), 150, PageSize.A4.Height - 115, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ciudad: " & reader(3), 150, PageSize.A4.Height - 140, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Datos del Coche:", 100, PageSize.A4.Height - 165, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Marca: " & reader(4), 150, PageSize.A4.Height - 190, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Modelo: " & reader(5), 150, PageSize.A4.Height - 215, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Color: " & reader(6), 150, PageSize.A4.Height - 240, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Num pasajeros: " & reader(7), 150, PageSize.A4.Height - 265, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha de devolucion: " & reader(9), 350, PageSize.A4.Height - 215, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Precio de alquiler: $" & reader(8), 350, PageSize.A4.Height - 300, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Total a pagar: $" & TotalPagar, 350, PageSize.A4.Height - 330, 0)
            'Fin del flujo de bytes.
            cb.EndText()
            'Forzamos vaciamiento del buffer.
            pdfw.Flush()
            'Cerramos el documento.
            oDoc.Close()
        Catch ex As Exception
            'Si hubo una excepcion y el archivo existe ...
            If File.Exists(NombreArchivo) Then
                'Cerramos el documento si esta abierto.
                'Y asi desbloqueamos el archivo para su eliminacion.
                If oDoc.IsOpen Then oDoc.Close()
                '... lo eliminamos de disco.
                File.Delete(NombreArchivo)
            End If
            Throw New Exception("Error al generar archivo PDF")
        Finally
            cb = Nothing
            pdfw = Nothing
            oDoc = Nothing
        End Try
        EjecutarArchivos(NombreArchivo)
        reader.Close() 'Se cierra la lectura
    End Sub
    Public Sub EjecutarArchivos(ruta As String)
        Dim ejecutarShell As Object
        ejecutarShell = Shell("rundll32.exe url.dll,FileProtocolHandler " & (ruta), 1)
        Exit Sub
    End Sub

End Class
