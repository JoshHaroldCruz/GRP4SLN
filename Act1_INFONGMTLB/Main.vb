Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using context As New ApplicationDbContext()
            ' Querying data
            Dim products = context.Products.ToList()

            ' Adding new data
            Dim newProduct As New Product With {
                .Name = "New Product",
                .Price = 10.99
            }
            context.Products.Add(newProduct)
            context.SaveChanges()

            ' Updating existing data
            Dim productToUpdate = context.Products.FirstOrDefault(Function(p) p.Id = 1)
            If productToUpdate IsNot Nothing Then
                productToUpdate.Price = 19.99
                context.SaveChanges()
            End If

            ' Deleting data
            Dim productToDelete = context.Products.FirstOrDefault(Function(p) p.Id = 2)
            If productToDelete IsNot Nothing Then
                context.Products.Remove(productToDelete)
                context.SaveChanges()
            End If
        End Using
    End Sub

End Class
