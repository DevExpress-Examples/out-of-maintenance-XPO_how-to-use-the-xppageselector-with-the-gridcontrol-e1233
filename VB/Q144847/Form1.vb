Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace Q144847

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            XpoDefault.ConnectionString = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind")
            InitializeComponent()
            UpdateLabel()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If xpPageSelector1.CurrentPage = 0 Then Return
            xpPageSelector1.CurrentPage -= 1
            UpdateLabel()
        End Sub

        Private Sub UpdateLabel()
            labelControl1.Text = String.Format("Page {0} of {1}", xpPageSelector1.CurrentPage, xpPageSelector1.PageCount)
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If xpPageSelector1.CurrentPage = xpPageSelector1.PageCount - 1 Then Return
            xpPageSelector1.CurrentPage += 1
            UpdateLabel()
        End Sub
    End Class
End Namespace
