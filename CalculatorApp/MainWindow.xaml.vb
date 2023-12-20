Imports System.Text
Imports DevExpress.Xpf.Core

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Partial Public Class MainWindow
    Inherits ThemedWindow
    Public Sub New()
        InitializeComponent()
        resultLabel.Content = "14321"
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As RoutedEventArgs)
        If (resultLabel.Content.ToString() = "0") Then
            resultLabel.Content = "7"
        Else
            resultLabel.Content = $"{resultLabel.Content}7"

        End If
    End Sub
End Class