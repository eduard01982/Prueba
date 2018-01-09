Imports System.IO
Imports System.Xml

Public Class Llamador

    Dim oCaja As New BLL.Caja
    Dim recienentro As Boolean = True

    Private Sub Llamador_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim oTurnero As New Turnero
        oTurnero.Show()
        'Dim oLC As New LlamadorCaja
        'oLC.Show()
        'Dim oLC2 As New LlamadorCaja
        ' oLC2.Show()

        'leer numero de la caja de xml'
        Dim doc As New XmlDocument
        Dim llamador As XmlNodeList
        Dim caja As XmlNodeList

        If My.Computer.FileSystem.FileExists("llamador.xml") Then
            doc.Load("llamador.xml")
            llamador = doc.GetElementsByTagName("llamador")
            caja = doc.GetElementsByTagName("caja")
            NumeroDeCaja.Text = doc.GetElementsByTagName("numero")(0).InnerXml
            'MsgBox(doc.GetElementsByTagName("numero")(0).InnerXml)
        End If
        If YaExisteLaCaja(NumeroDeCaja.Text) Then
            MsgBox("La caja " & NumeroDeCaja.Text & " ya esta hablititada como otra pc. Seleccione otro numero de caja.")
        Else
            oCaja.caja = NumeroDeCaja.Text
            oCaja.conectar(oCaja)
            oCaja.libre(oCaja)
        End If
        recienentro = False
    End Sub

    Private Function YaExisteLaCaja(n As Int16) As Boolean
        oCaja.caja = n
        Return oCaja.EstaConectado(oCaja)
    End Function

    Private Sub ResetearCajas()
        Dim i As Int16 = 1
        While (i <= 10)
            oCaja.caja = i
            oCaja.desconectar(oCaja)
            oCaja.ocupado(oCaja)
            i = i + 1
        End While
    End Sub

    Private Sub ResetearCajaActual()
        oCaja.desconectar(oCaja)
        oCaja.ocupado(oCaja)
    End Sub
    Private Sub ButtonLlamar_Click(sender As Object, e As EventArgs) Handles ButtonLibre.Click
        ' If Not YaExisteLaCaja(NumeroDeCaja.Text) Then
        oCaja.libre(oCaja)
        ButtonOcupado.Enabled = True
        ButtonLibre.Enabled = False
        'End If
    End Sub

    Private Sub ButtonOcupado_Click(sender As Object, e As EventArgs) Handles ButtonOcupado.Click
        'If Not YaExisteLaCaja(NumeroDeCaja.Text) Then
        oCaja.ocupado(oCaja)
        ButtonOcupado.Enabled = False
            ButtonLibre.Enabled = True
        ' Else
        'MsgBox("La caja " & NumeroDeCaja.Text & " ya esta hablititada como otra pc. Seleccione otro numero de caja.")
        '  End If
    End Sub

    'Private Sub NumeroDeCaja_SelectedItemChanged(sender As Object, e As EventArgs)
    'If Not recienentro Then
    '      oCaja.desconectar(oCaja)
    '     oCaja.ocupado(oCaja)
    'If Not YaExisteLaCaja(NumeroDeCaja.Text) Then

    'VEEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRRRRRRRRRRRVERRRRR
    '      oCaja.caja = NumeroDeCaja.Text
    '      oCaja.conectar(oCaja)
    '        oCaja.libre(oCaja)
    'End If
    'End If
    ' End Sub

    Private Sub Llamador_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

        'guardar el numero de la caja en xml'
        Dim doc As New XmlDocument
        If My.Computer.FileSystem.FileExists("llamador.xml") Then
            My.Computer.FileSystem.DeleteFile("llamador.xml")
        End If
        Dim archivoxml As New XmlTextWriter("llamador.xml", System.Text.Encoding.UTF8)
        archivoxml.Formatting = Formatting.Indented
        archivoxml.Indentation = 2
        archivoxml.WriteStartDocument(True)
        archivoxml.WriteStartElement("llamador")
        archivoxml.WriteStartElement("caja")
        archivoxml.WriteElementString("numero", NumeroDeCaja.Text)
        'MsgBox(" escribe " + NumeroDeCaja.Text)
        archivoxml.WriteEndElement()
        archivoxml.WriteEndElement()
        archivoxml.WriteEndDocument()
        archivoxml.Close()


        ResetearCajaActual()
        'falta resetear individual

    End Sub

End Class