

Imports System.Data.SqlClient

Namespace DAL
    Public Class DatosDAL

        Private cnn As New SqlConnection("Data Source=192.168.0.4;Initial Catalog=MRG_CAJAS_TURNOS;User ID=sa;Password=6ervasi0")
        Private cmd As SqlCommand

        Public Sub AbrirCnn()
            ' Try
            cnn.Open()
            '  Catch ex As SqlException
            ' MsgBox("Error en  al conectarse a la BD ", ex.Message)
            ' ' Catch ex As Exception
            '  MsgBox(ex)
            '  End Try
        End Sub

        Public Sub CerrarCnn()
            Try
                cnn.Close()
                cnn.Dispose()
                cnn = Nothing
                GC.Collect()

            Catch ex As SqlException
                MsgBox(ex)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End Sub

        Public Sub Escribir(ByVal Consulta As String)
            AbrirCnn()
            'ABRE TRANSACCION ###################################
            Dim myTrans As SqlTransaction
            myTrans = cnn.BeginTransaction()
            Try

                'cnn.Open()

                cmd = New SqlCommand(Consulta, cnn)
                cmd.Transaction = myTrans
                cmd.ExecuteNonQuery()
                myTrans.Commit()


                'cnn.Close()
                'cnn.Dispose()
            Catch ex As SqlException
                myTrans.Rollback()
                MsgBox(ex)
                '
            Catch ex As Exception
                MsgBox(ex)
            End Try
            'TERMINA TRANSACCION ###################################
            CerrarCnn()
        End Sub

        Public Function Leer(ByVal consulta As String) As DataTable
            Dim tabla As New DataTable
            Try
                'MessageBox.Show(consulta)
                Dim Da As New SqlDataAdapter(consulta, cnn)
                Da.Fill(tabla)

            Catch ex As SqlException
                MsgBox(ex)
            Catch ex As Exception
                MsgBox(ex)
            End Try
            Return tabla
        End Function
    End Class
End Namespace
