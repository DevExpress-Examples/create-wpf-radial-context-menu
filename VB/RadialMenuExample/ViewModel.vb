Imports System.Windows.Input

Namespace RadialMenuExample

    Public Class RadialContextMenuViewModel

        Public Overridable ReadOnly Property TextBoxService As ITextBoxService
            Get
                Return Nothing
            End Get
        End Property

        Public Property CopyCommand As ICommand

        Public Property PasteCommand As ICommand

        Public Property CutCommand As ICommand

        Public Property SelectAllCommand As ICommand

        Public Sub New()
            CopyCommand = ApplicationCommands.Copy
            PasteCommand = ApplicationCommands.Paste
            CutCommand = ApplicationCommands.Cut
            SelectAllCommand = ApplicationCommands.SelectAll
        End Sub

        ' A ClearSelectionCommand is automatically created from the following methods by POCO:
        Public Function CanClearSelection() As Boolean
            Return TextBoxService.CanClearSelection()
        End Function

        Public Sub ClearSelection()
            TextBoxService.ClearSelection()
        End Sub
    End Class
End Namespace
