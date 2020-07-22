Imports System.Xml
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ÜresToolStripMenuItem.Checked = False
        KövetésiListaToolStripMenuItem.Checked = False
        UtolsóÁllapotToolStripMenuItem.Checked = False

        Select Case My.Settings.defaultlist
            Case 1
                ÜresToolStripMenuItem.Checked = True
            Case 2
                KövetésiListaToolStripMenuItem.Checked = True
            Case 3
                UtolsóÁllapotToolStripMenuItem.Checked = True
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim container As String
        For x = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(x).Cells(0).Value = True Then
                If container = "" Then
                    container = DataGridView1.Rows(x).Cells(1).Value
                Else
                    container = container & "," & DataGridView1.Rows(x).Cells(1).Value
                End If
            End If

            If (x + 1) Mod 10 = 0 Then
                Call wbrowser("https://www.posta.hu/ugyfelszolgalat/nyomkovetes?ids=" & container)
                container = ""
            End If

        Next
        If container <> "" Then Call wbrowser("https://www.posta.hu/ugyfelszolgalat/nyomkovetes?ids=" & container)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim container As String
        For x = 0 To DataGridView1.Rows.Count - 1
            If container = "" Then
                container = DataGridView1.Rows(x).Cells(1).Value
            Else
                container = container & "," & DataGridView1.Rows(x).Cells(1).Value
            End If
            If (x + 1) Mod 10 = 0 Then
                Call wbrowser("https://www.posta.hu/ugyfelszolgalat/nyomkovetes?ids=" & container)
                container = ""
            End If

        Next
        If container <> "" Then Call wbrowser("https://www.posta.hu/ugyfelszolgalat/nyomkovetes?ids=" & container)
    End Sub


    Private Sub wbrowser(ByVal sender As Object)
        Dim webAddress As String = sender
        Process.Start(webAddress)
    End Sub
    Private Sub MegnyitásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MegnyitásToolStripMenuItem.Click
        Call addxml
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call addxml()
    End Sub
    Private Sub addxml()
        'Add XML file
        Dim OpenFileDialog1 As New OpenFileDialog
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            DataGridView1.Rows.Clear()
            Dim xmldoc As New XmlDataDocument()
            Dim xmlnode As XmlNodeList
            Dim xmlnode2 As XmlNodeList
            Dim i As Integer
            Dim str As String
            Dim fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            xmldoc.Load(fs)

            xmlnode = xmldoc.GetElementsByTagName("mpl_csomag")
            xmlnode2 = xmldoc.GetElementsByTagName("efj_zaras")
            Dim puffer = xmlnode2(0).InnerText.Trim()
            Me.Text = "MPL Csomagkövetés - " & OpenFileDialog1.SafeFileName & " - 20" & Strings.Left(puffer, 2) & "-" & Strings.Left(Strings.Right(puffer, 11), 2) & "-" & Strings.Left(Strings.Right(puffer, 9), 2) & " - " & Strings.Left(Strings.Right(puffer, 6), 2) & ":" & Strings.Left(Strings.Right(puffer, 4), 2) & ":" & Strings.Right(puffer, 2)
            DataGridView1.AllowUserToAddRows = True
            Dim money
            For i = 0 To xmlnode.Count - 1
                money = xmlnode(i).ChildNodes.Item(20).InnerText.Trim()
                If money = "" Then money = 0
                DataGridView1.Rows.Insert(0, New String() {"True", Strings.Left(xmlnode(i).ChildNodes.Item(1).InnerText.Trim(), 13), xmlnode(i).ChildNodes.Item(4).InnerText.Trim(), xmlnode(i).ChildNodes.Item(5).InnerText.Trim(), xmlnode(i).ChildNodes.Item(6).InnerText.Trim(), xmlnode(i).ChildNodes.Item(13).InnerText.Trim(), money & " Ft", xmlnode(i).ChildNodes.Item(26).InnerText.Trim() & " Ft", xmlnode(i).ChildNodes.Item(19).InnerText.Trim(), xmlnode(i).ChildNodes.Item(18).InnerText.Trim() & " g"})
            Next
            DataGridView1.AllowUserToAddRows = False

            CheckBox1.Enabled = True
            CheckBox1.Checked = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For x = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(x).Cells(0).Value = CheckBox1.Checked
        Next
    End Sub
    Private Sub ÜresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜresToolStripMenuItem.Click
        ÜresToolStripMenuItem.Checked = True
        KövetésiListaToolStripMenuItem.Checked = False
        UtolsóÁllapotToolStripMenuItem.Checked = False
        My.Settings.defaultlist = 1
    End Sub
    Private Sub KövetésiListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KövetésiListaToolStripMenuItem.Click
        ÜresToolStripMenuItem.Checked = False
        KövetésiListaToolStripMenuItem.Checked = True
        UtolsóÁllapotToolStripMenuItem.Checked = False
        My.Settings.defaultlist = 2
    End Sub
    Private Sub UtolsóÁllapotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtolsóÁllapotToolStripMenuItem.Click
        ÜresToolStripMenuItem.Checked = False
        KövetésiListaToolStripMenuItem.Checked = False
        UtolsóÁllapotToolStripMenuItem.Checked = True
        My.Settings.defaultlist = 3
    End Sub
    Private Sub BezárásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BezárásToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NévjegyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NévjegyToolStripMenuItem.Click
        MsgBox("Báthori Zoltán - 2019. +3620/482-2625")
    End Sub


End Class
