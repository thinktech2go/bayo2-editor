﻿Public Class Credits
    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Me.Text = "Change Prperties Through Coding"
        ''Me.BackColor = Color.Gray

        ''Me.Location = New Point(300, 300)
        ''Me.MaximizeBox = False
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        System.Diagnostics.Process.Start("https://gbatemp.net/members/type_o_dev.438011/")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://discordapp.com/channels/@madhatter#5558")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/thinktech2go/Bayo2-editor/issues")
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("https://gbatemp.net/members/type_o_dev.438011/")
    End Sub
End Class