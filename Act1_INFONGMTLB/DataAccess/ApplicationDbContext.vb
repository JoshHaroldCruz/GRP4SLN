Imports Microsoft.EntityFrameworkCore

Public Class ApplicationDbContext
    Inherits DbContext

    Public Property Products As DbSet(Of Product)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer("Server=(localdb)\MSSQLLocalDB;Database=Test;
    Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;
    Application Intent=ReadWrite;Multi Subnet Failover=False")
    End Sub
End Class