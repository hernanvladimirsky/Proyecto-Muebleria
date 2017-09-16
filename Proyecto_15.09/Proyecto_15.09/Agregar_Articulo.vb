Public Class Agregar_Articulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Agregar_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.MuebleriaDataSet.Articulos)
        Me.ArticulosBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        Articulos.ArticulosTableAdapter.Fill(Articulos.MuebleriaDataSet.Articulos)
        Me.ArticulosTableAdapter.Fill(Me.MuebleriaDataSet.Articulos)
        Me.ArticulosBindingSource.MoveLast()
        MsgBox("el codigo de el articulo es: " & ArticulosBindingSource.Current("Id_articulo"))
        DescripcionTextBox.Focus()
        Me.ArticulosBindingSource.AddNew()
    End Sub
End Class