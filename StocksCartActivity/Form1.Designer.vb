﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridViewItems_Stocks = New System.Windows.Forms.DataGridView()
        Me.DataGridViewItems_Cart = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Labelordernumber = New System.Windows.Forms.Label()
        Me.PanelOrder = New System.Windows.Forms.Panel()
        Me.PanelOrderSuccess = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBoxdiscount = New System.Windows.Forms.CheckBox()
        Me.Labelmessage = New System.Windows.Forms.Label()
        CType(Me.DataGridViewItems_Stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewItems_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOrder.SuspendLayout()
        Me.PanelOrderSuccess.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewItems_Stocks
        '
        Me.DataGridViewItems_Stocks.AllowUserToAddRows = False
        Me.DataGridViewItems_Stocks.AllowUserToDeleteRows = False
        Me.DataGridViewItems_Stocks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewItems_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems_Stocks.Location = New System.Drawing.Point(28, 201)
        Me.DataGridViewItems_Stocks.Name = "DataGridViewItems_Stocks"
        Me.DataGridViewItems_Stocks.ReadOnly = True
        Me.DataGridViewItems_Stocks.Size = New System.Drawing.Size(326, 221)
        Me.DataGridViewItems_Stocks.TabIndex = 0
        '
        'DataGridViewItems_Cart
        '
        Me.DataGridViewItems_Cart.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewItems_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems_Cart.Location = New System.Drawing.Point(471, 201)
        Me.DataGridViewItems_Cart.Name = "DataGridViewItems_Cart"
        Me.DataGridViewItems_Cart.Size = New System.Drawing.Size(336, 221)
        Me.DataGridViewItems_Cart.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(150, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 111)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add To Cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(150, 553)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 111)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add To Cart"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(589, 543)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(218, 107)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Remove from Cart"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(463, 543)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 557)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQuantity.Location = New System.Drawing.Point(28, 480)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(326, 67)
        Me.TextBoxQuantity.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stocks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cart"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 82)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sari Sari Store"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(839, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 38)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txttotal.Location = New System.Drawing.Point(846, 55)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(293, 53)
        Me.txttotal.TabIndex = 12
        Me.txttotal.Text = "0"
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtdiscount.Location = New System.Drawing.Point(845, 251)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(293, 53)
        Me.txtdiscount.TabIndex = 14
        Me.txtdiscount.Text = "0"
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrandtotal.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtgrandtotal.Location = New System.Drawing.Point(845, 364)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(293, 53)
        Me.txtgrandtotal.TabIndex = 16
        Me.txtgrandtotal.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(838, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 38)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Payment"
        '
        'txtpayment
        '
        Me.txtpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayment.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtpayment.Location = New System.Drawing.Point(845, 480)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(293, 53)
        Me.txtpayment.TabIndex = 18
        Me.txtpayment.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(838, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 38)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Grand Total"
        '
        'txtchange
        '
        Me.txtchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtchange.Location = New System.Drawing.Point(846, 576)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(293, 53)
        Me.txtchange.TabIndex = 20
        Me.txtchange.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(839, 535)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 38)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Change"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(467, 441)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(340, 68)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Place Order"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(157, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(235, 38)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Order Number:"
        '
        'Labelordernumber
        '
        Me.Labelordernumber.AutoSize = True
        Me.Labelordernumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelordernumber.Location = New System.Drawing.Point(418, 82)
        Me.Labelordernumber.Name = "Labelordernumber"
        Me.Labelordernumber.Size = New System.Drawing.Size(161, 38)
        Me.Labelordernumber.TabIndex = 23
        Me.Labelordernumber.Text = "00000000"
        '
        'PanelOrder
        '
        Me.PanelOrder.Controls.Add(Me.Labelmessage)
        Me.PanelOrder.Controls.Add(Me.CheckBoxdiscount)
        Me.PanelOrder.Controls.Add(Me.txttax)
        Me.PanelOrder.Controls.Add(Me.Label11)
        Me.PanelOrder.Controls.Add(Me.Labelordernumber)
        Me.PanelOrder.Controls.Add(Me.Label10)
        Me.PanelOrder.Controls.Add(Me.Button5)
        Me.PanelOrder.Controls.Add(Me.txtchange)
        Me.PanelOrder.Controls.Add(Me.Label9)
        Me.PanelOrder.Controls.Add(Me.txtpayment)
        Me.PanelOrder.Controls.Add(Me.Label8)
        Me.PanelOrder.Controls.Add(Me.txtgrandtotal)
        Me.PanelOrder.Controls.Add(Me.Label7)
        Me.PanelOrder.Controls.Add(Me.txtdiscount)
        Me.PanelOrder.Controls.Add(Me.txttotal)
        Me.PanelOrder.Controls.Add(Me.Label5)
        Me.PanelOrder.Controls.Add(Me.Label4)
        Me.PanelOrder.Controls.Add(Me.Label3)
        Me.PanelOrder.Controls.Add(Me.Label2)
        Me.PanelOrder.Controls.Add(Me.Label1)
        Me.PanelOrder.Controls.Add(Me.TextBoxQuantity)
        Me.PanelOrder.Controls.Add(Me.PictureBox2)
        Me.PanelOrder.Controls.Add(Me.PictureBox1)
        Me.PanelOrder.Controls.Add(Me.Button4)
        Me.PanelOrder.Controls.Add(Me.Button3)
        Me.PanelOrder.Controls.Add(Me.Button1)
        Me.PanelOrder.Controls.Add(Me.DataGridViewItems_Cart)
        Me.PanelOrder.Controls.Add(Me.DataGridViewItems_Stocks)
        Me.PanelOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOrder.Location = New System.Drawing.Point(0, 0)
        Me.PanelOrder.Name = "PanelOrder"
        Me.PanelOrder.Size = New System.Drawing.Size(1151, 676)
        Me.PanelOrder.TabIndex = 24
        '
        'PanelOrderSuccess
        '
        Me.PanelOrderSuccess.Controls.Add(Me.Button2)
        Me.PanelOrderSuccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOrderSuccess.Location = New System.Drawing.Point(0, 0)
        Me.PanelOrderSuccess.Name = "PanelOrderSuccess"
        Me.PanelOrderSuccess.Size = New System.Drawing.Size(1151, 676)
        Me.PanelOrderSuccess.TabIndex = 24
        Me.PanelOrderSuccess.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(386, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(345, 104)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Order Again"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txttax
        '
        Me.txttax.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttax.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txttax.Location = New System.Drawing.Point(846, 152)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(293, 53)
        Me.txttax.TabIndex = 25
        Me.txttax.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(839, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 38)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Tax"
        '
        'CheckBoxdiscount
        '
        Me.CheckBoxdiscount.AutoSize = True
        Me.CheckBoxdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxdiscount.Location = New System.Drawing.Point(845, 210)
        Me.CheckBoxdiscount.Name = "CheckBoxdiscount"
        Me.CheckBoxdiscount.Size = New System.Drawing.Size(140, 35)
        Me.CheckBoxdiscount.TabIndex = 26
        Me.CheckBoxdiscount.Text = "Discount"
        Me.CheckBoxdiscount.UseVisualStyleBackColor = True
        '
        'Labelmessage
        '
        Me.Labelmessage.AutoSize = True
        Me.Labelmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmessage.Location = New System.Drawing.Point(292, 120)
        Me.Labelmessage.Name = "Labelmessage"
        Me.Labelmessage.Size = New System.Drawing.Size(153, 38)
        Me.Labelmessage.TabIndex = 27
        Me.Labelmessage.Text = "Welcome"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1151, 676)
        Me.Controls.Add(Me.PanelOrder)
        Me.Controls.Add(Me.PanelOrderSuccess)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridViewItems_Stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewItems_Cart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOrder.ResumeLayout(False)
        Me.PanelOrder.PerformLayout()
        Me.PanelOrderSuccess.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewItems_Stocks As DataGridView
    Friend WithEvents DataGridViewItems_Cart As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Labelordernumber As Label
    Friend WithEvents PanelOrder As Panel
    Friend WithEvents PanelOrderSuccess As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents txttax As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBoxdiscount As CheckBox
    Friend WithEvents Labelmessage As Label
End Class
