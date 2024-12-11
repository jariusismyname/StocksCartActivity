Imports System.Data.SqlClient

Public Class Form1
    ' Update the connection string to match your database configuration.
    Private connectionString As String = "Data Source=DESKTOP-D5V36F0\SQLEXPRESS;Initial Catalog=PetMgmt;Integrated Security=True;Connect Timeout=30;Encrypt=False"

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

    ' Call this method when the form loads or when you want to refresh the DataGridView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsStocks()
    End Sub
End Class
