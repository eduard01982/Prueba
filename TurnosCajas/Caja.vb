Namespace BLL
    Public Class Caja

        Public Property caja As Integer
        Public Property estado As String
        Public Property conectado As Boolean


        Public Sub conectar(oCaja As Caja)
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "update cajas set conectado=1 where caja=" & oCaja.caja
            oDatos.Escribir(sql)
        End Sub
        Public Sub desconectar(oCaja As Caja)
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "update cajas set conectado=0 where caja=" & oCaja.caja
            oDatos.Escribir(sql)
        End Sub
        Public Sub libre(oCaja As Caja)
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "update cajas set estado='LIBRE' where caja=" & oCaja.caja
            oDatos.Escribir(sql)
        End Sub
        Public Sub ocupado(oCaja As Caja)
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "update cajas set estado='OCUPADO' where caja=" & oCaja.caja
            oDatos.Escribir(sql)
        End Sub

        Public Function EstaLibre(oCaja As Caja) As Boolean
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "select * from cajas where estado='LIBRE' and caja=" & oCaja.caja
            If (oDatos.Leer(sql).Rows.Count > 0) Then
                Return True
            Else Return False
                End If
        End Function
        Public Function EstaConectado(oCaja As Caja) As Boolean
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "select * from cajas where conectado=1 and caja=" & oCaja.caja
            If (oDatos.Leer(sql).Rows.Count > 0) Then
                Return True
            Else Return False
            End If
        End Function

        Public Function CajaConectadaYLibre() As Int16
            Dim oDatos As New DAL.DatosDAL
            Dim sql As String
            sql = "select top 1 caja from cajas where estado='LIBRE' and conectado=1" ' order by newid()"
            If (oDatos.Leer(sql).Rows.Count > 0) Then
                Return oDatos.Leer(sql).Rows(0).Item("caja")
            Else Return 0
            End If
        End Function

    End Class


End Namespace