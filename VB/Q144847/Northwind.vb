Imports DevExpress.Xpo

Namespace Northwind

    Public Class Orders
        Inherits XPLiteObject

        Private fOrderID As Integer

        <Key(True)>
        Public Property OrderID As Integer
            Get
                Return fOrderID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("OrderID", fOrderID, value)
            End Set
        End Property

        Private fCustomerID As String

        <Size(5)>
        Public Property CustomerID As String
            Get
                Return fCustomerID
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerID", fCustomerID, value)
            End Set
        End Property

        Private fEmployeeID As Integer

        Public Property EmployeeID As Integer
            Get
                Return fEmployeeID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("EmployeeID", fEmployeeID, value)
            End Set
        End Property

        Private fOrderDate As Date

        Public Property OrderDate As Date
            Get
                Return fOrderDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("OrderDate", fOrderDate, value)
            End Set
        End Property

        Private fRequiredDate As Date

        Public Property RequiredDate As Date
            Get
                Return fRequiredDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("RequiredDate", fRequiredDate, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class
End Namespace
