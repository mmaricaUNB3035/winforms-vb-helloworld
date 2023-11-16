Imports System.Windows.Forms

Public Class HelloWorldForm
    Inherits Form

    Private counter = 0
    Private counterLabel

    Sub New() ' constructor

        Dim helloLabel As New Label()
        helloLabel.Text = "Hello, world!"
        helloLabel.TextAlign = ContentAlignment.MiddleCenter
        helloLabel.Margin = New Padding(
            (Me.ClientSize.Width - helloLabel.Width) / 2,
            80,
            helloLabel.Margin.Right,
            helloLabel.Margin.Bottom
        )

        Dim incrementButton As New Button
        incrementButton.Text = "Increment"
        AddHandler incrementButton.Click, AddressOf IncrementButton_Click

        Dim counterLabel As New Label
        counterLabel.TextAlign = ContentAlignment.MiddleCenter
        counterLabel.Text = counter
        Me.counterLabel = counterLabel

        Dim subPanel As New FlowLayoutPanel
        subPanel.Controls.AddRange({incrementButton, counterLabel})
        subPanel.FlowDirection = FlowDirection.LeftToRight
        subPanel.Margin = New Padding(
            (Me.ClientSize.Width - incrementButton.Width - counterLabel.Width) / 2,
            subPanel.Margin.Top,
            subPanel.Margin.Right,
            subPanel.Margin.Bottom
        )

        Dim mainPanel As New FlowLayoutPanel
        mainPanel.Controls.AddRange({helloLabel, subPanel})
        mainPanel.FlowDirection = FlowDirection.TopDown
        mainPanel.Dock = DockStyle.Fill

        Me.Controls.Add(mainPanel)

    End Sub

    Private Sub IncrementButton_Click()
        counter += 1
        counterLabel.Text = counter
    End Sub

    Shared Sub Main() ' entry point
        Application.Run(New HelloWorldForm())
    End Sub
End Class
