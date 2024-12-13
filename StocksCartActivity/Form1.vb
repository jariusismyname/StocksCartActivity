Imports System.Data.SqlClient

Public Class Form1
    ' Update the connection string to match your database configuration.
    Private connectionString As String = "Data Source=JARIUS-PC\SQLEXPRESS;Initial Catalog=SariSariStore;Integrated Security=True;Connect Timeout=30;Encrypt=False"

    Private Sub LoadItemsStocks()
        Try
            ' SQL query to fetch data from Items_Stocks table
            Dim query As String = "SELECT * FROM Items_Stocks"

            ' Create a new SqlConnection
            Using conn As New SqlConnection(connectionString)
                ' Create a SqlDataAdapter
                Using adapter As New SqlDataAdapter(query, conn)
                    ' Create a DataTable to store data
                    Dim table As New DataTable()

                    ' Fill the DataTable with data from Items_Stocks
                    adapter.Fill(table)

                    ' Bind the DataTable to the DataGridView
                    DataGridViewItems_Stocks.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub GenerateOrderNumber()
        ' Get the current date and time
        Dim currentTime As String = DateTime.Now.ToString("yyyyMMddHHmmss") ' e.g., 20241211123045
        ' Add a random component for extra uniqueness
        Dim randomComponent As String = New Random().Next(1000, 9999).ToString() ' e.g., 4567

        ' Combine components to create the unique order number
        Dim uniqueOrderNumber As String = "ORD-" & currentTime & "-" & randomComponent

        ' Assign the order number to the label
        Labelordernumber.Text = uniqueOrderNumber
    End Sub

    ' Call this method when the form loads or when you want to refresh the DataGridView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsStocks()
        SetupCartDataGridView()
    End Sub
    Private Sub TransferToCart()
        ' Ensure a row is selected in DatagridviewItems_Stocks
        If DataGridViewItems_Stocks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to add to the cart.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve selected stock details
        Dim selectedRow As DataGridViewRow = DataGridViewItems_Stocks.SelectedRows(0)
        Dim productCode As String = selectedRow.Cells("Product_Codes").Value.ToString()
        Dim productName As String = selectedRow.Cells("Name_of_Product").Value.ToString()
        Dim stockQuantity As Integer = CInt(selectedRow.Cells("Quantity").Value)
        Dim price As Decimal = CDec(selectedRow.Cells("Price").Value)

        ' Retrieve quantity from TextBoxQuantity
        Dim transferQuantity As Integer
        If Not Integer.TryParse(TextBoxQuantity.Text, transferQuantity) OrElse transferQuantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if there is enough stock
        If transferQuantity > stockQuantity Then
            MessageBox.Show("Insufficient stock available.", "Not Enough Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the Order Number from the Label
        Dim orderNumber As String = Labelordernumber.Text

        ' Add the selected product to DatagridviewItems_Cart
        If DataGridViewItems_Cart.Columns.Count = 0 Then
            SetupCartDataGridView()
        End If

        ' Transfer logic as before
        ' Add rows to the DataGridView
        DataGridViewItems_Cart.Rows.Add(Nothing, productCode, productName, transferQuantity, price, orderNumber)

        ' Update the stock quantity
        selectedRow.Cells("Quantity").Value = stockQuantity - transferQuantity

        ' Save the changes to the database
        Using conn As New SqlConnection("Data Source=JARIUS-PC\SQLEXPRESS;Initial Catalog=SariSariStore;Integrated Security=True;Connect Timeout=30;Encrypt=False")
            conn.Open()

            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insert into Items_Cart table
                Dim insertCartCmd As New SqlCommand("INSERT INTO Items_Cart (Product_Codes, Name_of_Product, Quantity, Price, Order_Number) VALUES (@Product_Codes, @Name_of_Product, @Quantity, @Price, @Order_Number)", conn, transaction)
                insertCartCmd.Parameters.AddWithValue("@Product_Codes", productCode)
                insertCartCmd.Parameters.AddWithValue("@Name_of_Product", productName)
                insertCartCmd.Parameters.AddWithValue("@Quantity", transferQuantity)
                insertCartCmd.Parameters.AddWithValue("@Price", price)
                insertCartCmd.Parameters.AddWithValue("@Order_Number", orderNumber)
                insertCartCmd.ExecuteNonQuery()

                ' Update Items_Stocks table
                Dim updateStockCmd As New SqlCommand("UPDATE Items_Stocks SET Quantity = Quantity - @Quantity WHERE Product_Codes = @Product_Codes", conn, transaction)
                updateStockCmd.Parameters.AddWithValue("@Quantity", transferQuantity)
                updateStockCmd.Parameters.AddWithValue("@Product_Codes", productCode)
                updateStockCmd.ExecuteNonQuery()

                ' Commit transaction
                transaction.Commit()

                MessageBox.Show("Item successfully transferred to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Rollback transaction in case of error
                transaction.Rollback()
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub PopulateDataGridViewItems_Cart()
        ' Ensure the label has a valid Order_Number
        If String.IsNullOrWhiteSpace(Labelordernumber.Text) Then
            MessageBox.Show("Order Number is empty. Cannot populate cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim orderNumber As String = Labelordernumber.Text

        ' Database connection string
        'Dim connectionString As String = "Your Connection String Here"

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' SQL query to fetch data matching the Order_Number
                Dim query As String = "SELECT CartId, Product_Codes, Name_of_Product, Quantity, Price, Order_Number " &
                                  "FROM Items_Cart WHERE Order_Number = @OrderNumber"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OrderNumber", orderNumber)

                    ' Use SqlDataAdapter to fill the DataGridView
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridViewItems_Cart.DataSource = dataTable
                End Using
            End Using

            MessageBox.Show("Cart populated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveTransactionData()
        PanelOrderSuccess.Visible = True
        PanelOrder.Visible = False
        'PopulateDataGridViewItems_Cart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GenerateOrderNumber()
        'PopulateDataGridViewItems_Cart()
        SetupCartDataGridView()
        PanelOrder.Visible = True
        PanelOrderSuccess.Visible = False
    End Sub
    Private Sub ComputeTotals()
        ' Initialize variables
        Dim total As Decimal = 0
        Dim discount As Decimal = 0
        Dim tax As Decimal = 0
        Dim grandTotal As Decimal = 0
        Dim payment As Decimal = 0
        Dim change As Decimal = 0

        ' Calculate Total from DataGridView
        For Each row As DataGridViewRow In DataGridViewItems_Cart.Rows
            If Not row.IsNewRow Then
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                total += price * quantity
            End If
        Next

        ' Display Total in txtTotal
        txtTotal.Text = total.ToString("F2")

        ' Calculate Discount
        If CheckBoxDiscount.Checked Then
            discount = total * 0.2D
        Else
            discount = 0
        End If
        txtDiscount.Text = discount.ToString("F2")

        ' Calculate Tax
        tax = total * 0.12D
        txtTax.Text = tax.ToString("F2")

        ' Calculate Grand Total
        grandTotal = total - discount
        txtGrandTotal.Text = grandTotal.ToString("F2")

        ' Validate Payment
        If Decimal.TryParse(txtPayment.Text, payment) AndAlso payment >= grandTotal Then
            ' Calculate Change
            change = payment - grandTotal
            txtchange.Text = change.ToString("F2")
            'receipt.show
            Labelmessage.Text = "Welcome, you  can buy anything."

        Else
            'MessageBox.Show("Payment must be greater than or equal to the Grand Total.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtchange.Text = "0.00"
            labelmessage.text = "Please make payment higher."
        End If
    End Sub
    Private Sub SaveTransactionData()
        ' Connection string to your MSSQL database
        'Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True"

        ' SQL Query to insert data into Transactions table
        Dim query As String = "INSERT INTO Transactions 
                           (Product_Codes, Name_of_Product, Quantity, Price, Order_Number, Total, Tax, Discount, Grand_Total, Payment, Change)
                           VALUES (@Product_Codes, @Name_of_Product, @Quantity, @Price, @Order_Number, @Total, @Tax, @Discount, @Grand_Total, @Payment, @Change)"

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Using transaction As SqlTransaction = conn.BeginTransaction()
                Try
                    For Each row As DataGridViewRow In DataGridViewItems_Cart.Rows
                        If Not row.IsNewRow Then
                            Using cmd As New SqlCommand(query, conn, transaction)
                                ' Bind parameters for DataGridView rows
                                cmd.Parameters.AddWithValue("@Product_Codes", row.Cells("Product_Codes").Value.ToString())
                                cmd.Parameters.AddWithValue("@Name_of_Product", row.Cells("Name_of_Product").Value.ToString())
                                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells("Quantity").Value))
                                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells("Price").Value))
                                cmd.Parameters.AddWithValue("@Order_Number", row.Cells("Order_Number").Value.ToString())

                                ' Bind parameters for TextBox values
                                cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txttotal.Text))
                                cmd.Parameters.AddWithValue("@Tax", Convert.ToDecimal(txttax.Text))
                                cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(txtdiscount.Text))
                                cmd.Parameters.AddWithValue("@Grand_Total", Convert.ToDecimal(txtgrandtotal.Text))
                                cmd.Parameters.AddWithValue("@Payment", Convert.ToDecimal(txtpayment.Text))
                                cmd.Parameters.AddWithValue("@Change", Convert.ToDecimal(txtchange.Text))

                                ' Execute the query
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    ' Commit the transaction
                    transaction.Commit()
                    MessageBox.Show("Transaction data has been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ' Rollback the transaction in case of an error
                    transaction.Rollback()
                    MessageBox.Show("An error occurred while saving transaction data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DataGridViewItems_Cart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewItems_Cart.CellValueChanged
        ComputeTotals()
    End Sub

    Private Sub CheckBoxDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDiscount.CheckedChanged
        ComputeTotals()
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        ComputeTotals()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TransferToCart()
        'PopulateDataGridViewItems_Cart()
    End Sub
    Private Sub SetupCartDataGridView()
        With DataGridViewItems_Cart
            .Columns.Clear()
            .Columns.Add("CartId", "Cart ID")
            .Columns.Add("Product_Codes", "Product Codes")
            .Columns.Add("Name_of_Product", "Product Name")
            .Columns.Add("Quantity", "Quantity")
            .Columns.Add("Price", "Price")
            .Columns.Add("Order_Number", "Order Number")
        End With
    End Sub

End Class
