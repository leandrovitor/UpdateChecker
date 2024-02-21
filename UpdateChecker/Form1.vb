Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(5)

        Else

            Dim web As New Net.WebClient
            Dim NovaVersao As String = web.DownloadString("http://forumup.ddns.net/update.txt")

            Timer1.Stop()

            Me.Label1.Text = "Versão: " + NovaVersao
            Me.Label3.Text = "Versão Atual: " + Application.ProductVersion

            If NovaVersao = Application.ProductVersion = True Then
                Me.Label2.Text = "Nenhuma Atualização Disponivel"
                Me.Label1.Text = ""

            Else
                Me.Label2.Text = "Atualização Disponivel"
                Me.Label1.Text = "Versão: " + NovaVersao
                Form2.Show()
            End If

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
