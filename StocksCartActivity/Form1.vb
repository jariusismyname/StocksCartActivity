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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelOrderSuccess.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GenerateOrderNumber()
        PanelOrder.Visible = True
        PanelOrderSuccess.Visible = False
    End Sub
End Class
