﻿Public Class uCtrlModificarBeneficio

    Dim id As Integer
    Dim nombre As String
    Dim porcentaje As Double
    Dim aplicacion As String
    Dim uCntrlBuscarBeneficio As uCntrlBuscarBeneficio

  
    Public Sub getFrmBuscar(puCntrlBuscarBeneficio As uCntrlBuscarBeneficio)

        uCntrlBuscarBeneficio = puCntrlBuscarBeneficio
    End Sub

    ''' <summary>
    ''' Este método se encarga de 'Setear' los textbox con los parametros recibidos
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="pnombre">Es el nombre del beneficio</param>
    ''' <param name="pporcentaje">El porcentaje del beneficio</param>
    ''' <param name="paplicacion">La aplicabilidad del beneficio</param>

    Public Sub recieveData(pid As Integer, pnombre As String, pporcentaje As Double, paplicacion As String)

        id = pid
        txtNombre.Text = pnombre
        txtPorcentaje.Text = pporcentaje
        txtAplicabilidad.Text = paplicacion


    End Sub

   
    ''' <summary>
    ''' Este método se encarga de 'Setear' las variables globales del userControl.
    ''' Las variables se setean con la informacion que se encuentra en los textbox.
    ''' Una vez seteadas las variables, las envia al gestor para modificar el beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        nombre = txtNombre.Text
        porcentaje = CType(txtPorcentaje.Text, Double)
        aplicacion = txtAplicabilidad.Text


        objGestorBeneficio.modificarBeneficio(id, nombre, porcentaje, aplicacion)
        objGestorBeneficio.guardarCambios()

        MsgBox("El beneficio se modifico correctamente")

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()
        Me.Hide()
        Me.Dispose()

    End Sub

    ''' <summary>
    ''' Este metodo se encarga de esconder el formulario cuando el usuario da click en cancelar.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Hide()
        Me.Dispose()
    End Sub

  
End Class
