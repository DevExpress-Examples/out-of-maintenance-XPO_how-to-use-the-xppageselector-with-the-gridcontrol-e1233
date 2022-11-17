Namespace Q144847

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.xpPageSelector1 = New DevExpress.Xpo.XPPageSelector()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpPageSelector1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(639, 437)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' xpPageSelector1
            ' 
            Me.xpPageSelector1.Collection = Me.xpCollection1
            Me.xpPageSelector1.PageSize = 100
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.ObjectType = GetType(Northwind.Orders)
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.Caption = "OrderID"
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.Caption = "CustomerID"
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 1
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.Caption = "EmployeeID"
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            Me.colEmployeeID.Visible = True
            Me.colEmployeeID.VisibleIndex = 2
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.Caption = "OrderDate"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 3
            ' 
            ' colRequiredDate
            ' 
            Me.colRequiredDate.Caption = "RequiredDate"
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            Me.colRequiredDate.Visible = True
            Me.colRequiredDate.VisibleIndex = 4
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.simpleButton2)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 437)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(639, 43)
            Me.panelControl1.TabIndex = 1
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(5, 5)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(32, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "<<"
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click)
'''  ' 
            ' simpleButton2
            ' 
Me.simpleButton2.Location = New System.Drawing.Point(142, 5)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(29, 23)
            Me.simpleButton2.TabIndex = 1
            Me.simpleButton2.Text = ">>"
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click)
'''  ' 
            ' labelControl1
            ' 
Me.labelControl1.Location = New System.Drawing.Point(43, 10)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(639, 480)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private xpPageSelector1 As DevExpress.Xpo.XPPageSelector

        Private xpCollection1 As DevExpress.Xpo.XPCollection

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
