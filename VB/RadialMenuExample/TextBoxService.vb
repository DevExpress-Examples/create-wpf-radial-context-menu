Imports DevExpress.Mvvm.UI
Imports System.Windows.Controls

Namespace RadialMenuExample

    Public Interface ITextBoxService

        Sub ClearSelection()

        Function CanClearSelection() As Boolean

    End Interface

    'This service is used for the Clear command. To learn more about custom services, refer to https://documentation.devexpress.com/#WPF/CustomDocument16920
    Public Class TextBoxService
        Inherits ServiceBase
        Implements ITextBoxService

        Private ReadOnly Property MyTextBox As TextBox
            Get
                Return TryCast(AssociatedObject, TextBox)
            End Get
        End Property

        Public Sub ClearSelection() Implements ITextBoxService.ClearSelection
            MyTextBox.SelectionLength = 0
        End Sub

        Public Function CanClearSelection() As Boolean Implements ITextBoxService.CanClearSelection
            Return MyTextBox.SelectionLength > 0
        End Function
    End Class
End Namespace
