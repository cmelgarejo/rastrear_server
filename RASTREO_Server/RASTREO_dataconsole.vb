Imports RASTREO_Lib
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic

Public Class RASTREO_dataconsole

    Private allTailWorking As Boolean = True
    Private miThreadList As New List(Of Thread)
    Private DirectorioLOGS As String = "\RASTREAR_SRV\PORT_LOGS\"
    Private Sub RASTREO_dataconsole_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        StopLogging()
    End Sub

    Private Sub RASTREO_dataconsole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartLogging()
    End Sub
    Private Sub StopLogging()
        Try
            allTailWorking = False
            'For Each miThread As Thread In miThreadList
            '    If miThread.IsAlive Then miThread.Join()
            'Next
            'Thread.Sleep(300)
            For Each miThread As Thread In miThreadList
                If miThread.IsAlive Then miThread.Join(10)
                miThread = Nothing
            Next
            'Thread.Sleep(300)
        Catch ex As Exception
            RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub
    Private Sub StartLogging()
        Try
            For Each Log As FileInfo In New DirectoryInfo(DirectorioLOGS).GetFiles("*.log")
                If Log.CreationTime.Date = Now.Date And Not Log.FullName.Contains("REPETIDO") Then
                    Dim Th As New Thread(AddressOf Tail)
                    Th.Start(DirectorioLOGS + Log.Name)
                    miThreadList.Add(Th)
                End If
            Next
        Catch ex As Exception
            If Not ex.Message.ToLowerInvariant.Contains("subproceso anulado") Then
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(ex)
            End If
        End Try
    End Sub

    Delegate Sub txtConsole_SetText_CallBack(ByVal text As String)
    Private Sub Add_to_Console(ByVal text As String)
        Try
            If Me.txtConsole.InvokeRequired Then
                Dim d As New txtConsole_SetText_CallBack(AddressOf Add_to_Console)
                Me.Invoke(d, New Object() {text})
            Else
                If txtConsole.Text.Length > 10000 Then txtConsole.Text = String.Empty
                txtConsole.Text += text + Environment.NewLine
                txtConsole.Select(txtConsole.TextLength, 0)
                txtConsole.ScrollToCaret()
                txtConsole.Refresh()
            End If
        Catch ex As Exception
            If Not ex.Message.ToLowerInvariant.Contains("subproceso anulado") Then
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(ex)
            End If
        End Try
    End Sub

    Private Function Tail(ByVal _FileName As Object) As Boolean
        Try
            Dim FileName As String = DirectCast(_FileName, String)
            Using reader As New StreamReader(New FileStream(FileName, FileMode.Open, _
                                                            FileAccess.Read, FileShare.ReadWrite))

                Dim lastMaxOffset As Long = reader.BaseStream.Length
                While allTailWorking
                    Thread.Sleep(1000)
                    If reader.BaseStream.Length = lastMaxOffset Then Continue While
                    Dim linea As String = String.Empty
                    reader.BaseStream.Position = lastMaxOffset
                    While Not reader.EndOfStream
                        linea = reader.ReadLine()
                        If linea <> String.Empty Then
                            If chkFILTER.Checked Then
                                If linea.ToUpperInvariant().Contains(txtFILTER.Text.ToUpperInvariant()) Then
                                    Add_to_Console(FileName.Replace(".log", "").Replace(DirectorioLOGS, "").Replace("LOG_PORT_", "") _
                                                   + " - " + linea.Replace(vbTab, " "))
                                End If
                            Else
                                Add_to_Console(FileName.Replace(".log", "").Replace(DirectorioLOGS, "").Replace("LOG_PORT_", "") _
                                               + " - " + linea.Replace(vbTab, " "))
                            End If
                        End If
                    End While
                    lastMaxOffset = reader.BaseStream.Position
                End While
            End Using

        Catch ex As Exception
            If Not ex.Message.ToLowerInvariant.Contains("subproceso anulado") Then
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(ex)
            End If
        End Try
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkFILTER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFILTER.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtConsole.Text = String.Empty

    End Sub
End Class