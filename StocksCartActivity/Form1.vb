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


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelOrderSuccess.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GenerateOrderNumber()
        PanelOrder.Visible = True
        PanelOrderSuccess.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TransferToCart()
    End Sub
End Class
