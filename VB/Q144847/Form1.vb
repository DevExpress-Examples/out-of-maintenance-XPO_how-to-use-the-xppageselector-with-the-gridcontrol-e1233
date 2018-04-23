Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace Q144847
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			XpoDefault.ConnectionString = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind")
			InitializeComponent()
			UpdateLabel()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			If xpPageSelector1.CurrentPage = 0 Then
				Return
			End If
			xpPageSelector1.CurrentPage -= 1
			UpdateLabel()
		End Sub

		Private Sub UpdateLabel()
			labelControl1.Text = String.Format("Page {0} of {1}", xpPageSelector1.CurrentPage, xpPageSelector1.PageCount)
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			If xpPageSelector1.CurrentPage = xpPageSelector1.PageCount - 1 Then
				Return
			End If
			xpPageSelector1.CurrentPage += 1
			UpdateLabel()
		End Sub
	End Class
End Namespace