Imports System.Xml
Imports System.IO
Imports System.ComponentModel

Public Class Form1

    Dim dpath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dpath = ""
        ÜresToolStripMenuItem.Checked = False
        KövetésiListaToolStripMenuItem.Checked = False
        UtolsóÁllapotToolStripMenuItem.Checked = False

        Select Case My.Settings.defaultlist
            Case 1
                ÜresToolStripMenuItem.Checked = True
                Button2.Enabled = False
                Button3.Enabled = False
                CheckBox1.Enabled = False
                CheckBox1.Checked = False
            Case 2
                KövetésiListaToolStripMenuItem.Checked = True
                Call loadlist("followlist.txt")
                Me.Text = "MPL Csomagkövetés - Követési lista"
            Case 3
                UtolsóÁllapotToolStripMenuItem.Checked = True
                Call loadlist("lastcheckeditems.txt")
                Me.Text = "MPL Csomagkövetés - Utolsó állapot"
        End Select

    End Sub

    Private Sub loadlist(sender As String)
        If System.IO.File.Exists(dpath & sender) Then
            DataGridView1.Rows.Clear()
            Using objReader As New StreamReader(dpath & sender)
                Do While objReader.Peek() <> -1
                    Dim line As String = objReader.ReadLine()
                    If Not line.Contains("Különszolgáltatások") Then
                        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, lp As String
                        lp = Strings.Right(line, line.Length - line.IndexOf(";") - 1)
                        a1 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a2 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a3 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a4 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a5 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a6 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a7 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a8 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a9 = Strings.Left(lp, lp.IndexOf(";"))
                        lp = Strings.Right(lp, lp.Length - lp.IndexOf(";") - 1)
                        a10 = lp
                        DataGridView1.Rows.Insert(0, New String() {True, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10})
                    End If
                Loop
            End Using
        End If
        DataGridView1.Sort(DataGridView1.Columns(1),
        System.ComponentModel.ListSortDirection.Ascending)
        If DataGridView1.Rows.Count > 0 Then DataGridView1.CurrentRow.Selected = False
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
        Call addxml()
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
            Dim cim, money, money2
            For i = 0 To xmlnode.Count - 1
                If xmlnode(i).ChildNodes.Item(10).InnerText.Trim() = "" Then
                    cim = xmlnode(i).ChildNodes.Item(5).InnerText.Trim() & ", " & xmlnode(i).ChildNodes.Item(6).InnerText.Trim() & ", " & xmlnode(i).ChildNodes.Item(7).InnerText.Trim() & " " & xmlnode(i).ChildNodes.Item(8).InnerText.Trim() & " " & xmlnode(i).ChildNodes.Item(9).InnerText.Trim()
                Else
                    cim = xmlnode(i).ChildNodes.Item(5).InnerText.Trim() & ", " & xmlnode(i).ChildNodes.Item(6).InnerText.Trim() & ", " & xmlnode(i).ChildNodes.Item(10).InnerText.Trim()
                End If
                money = xmlnode(i).ChildNodes.Item(21).InnerText.Trim()
                money2 = xmlnode(i).ChildNodes.Item(20).InnerText.Trim()
                If money = "" Then money = 0
                If money2 = "" Then money2 = 0
                DataGridView1.Rows.Insert(0, New String() {"True", Strings.Left(xmlnode(i).ChildNodes.Item(1).InnerText.Trim(), 13), xmlnode(i).ChildNodes.Item(4).InnerText.Trim(), cim, xmlnode(i).ChildNodes.Item(13).InnerText.Trim(), xmlnode(i).ChildNodes.Item(12).InnerText.Trim(), money & " Ft", money2 & " Ft", xmlnode(i).ChildNodes.Item(26).InnerText.Trim() & " Ft", xmlnode(i).ChildNodes.Item(18).InnerText.Trim() & " g", xmlnode(i).ChildNodes.Item(19).InnerText.Trim()})
            Next
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.Sort(DataGridView1.Columns(1),
            System.ComponentModel.ListSortDirection.Ascending)
            DataGridView1.CurrentRow.Selected = False

            CheckBox1.Enabled = True
            CheckBox1.Checked = True
            Button2.Enabled = True
            Button3.Enabled = True
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
    Private Sub NévjegyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NévjegyToolStripMenuItem.Click
        MsgBox("Báthori Zoltán - 2020. +3620/482-2625")
    End Sub
    Private Sub currentlist()
        Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

        Using sw As New IO.StreamWriter(dpath & "lastcheckeditems.txt")
            sw.WriteLine("Választott" & String.Join(";", headers))
            For Each r In rows
                sw.WriteLine(String.Join(";", r))
            Next
        End Using
    End Sub

    Private Sub addtofollowlist()
        'Add the selected lines to the list
        Dim allLines As String() = File.ReadAllLines(dpath & "followlist.txt")
        Dim checkerlist As New ArrayList
        Using sw As New IO.StreamWriter(dpath & "followlist.txt")
            For Each line In allLines
                sw.WriteLine(line)
                If Strings.Left(line, line.IndexOf(";")) = "True" Then checkerlist.Add(Strings.Left(Strings.Right(line, line.Length - line.IndexOf(";") - 1), Strings.Right(line, line.Length - line.IndexOf(";") - 1).IndexOf(";")))

            Next
            Dim gotcha As Boolean
            gotcha = False
            Dim rr As Array
            Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow And row.Cells(0).Value = "True"
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            For Each r In rows
                rr = r
                gotcha = False
                For Each ch As String In checkerlist
                    If rr(1) = ch Then
                        gotcha = True
                        Exit For
                    End If
                Next
                If gotcha = False Then sw.WriteLine(String.Join(";", r))
            Next
        End Using
    End Sub
    Private Sub removefromfollowlist()
        'Remove the selected lines to the list
        Dim allLines As String() = File.ReadAllLines(dpath & "followlist.txt")
        Using sw As New IO.StreamWriter(dpath & "followlist.txt")



            Dim chlist As New ArrayList

            For x = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(x).Cells(0).Value = True Then
                    chlist.Add(DataGridView1.Rows(x).Cells(1).Value)
                End If
            Next x


            Dim gotcha As Boolean
            gotcha = False

            For Each line In allLines
                gotcha = False
                For Each ch As String In chlist
                    If ch = Strings.Left(Strings.Right(line, line.Length - line.IndexOf(";") - 1), Strings.Right(line, line.Length - line.IndexOf(";") - 1).IndexOf(";")) Then
                        gotcha = True
                        Exit For
                    End If
                Next
                If gotcha = False Then sw.WriteLine(line)
            Next

        End Using
    End Sub
    Private Sub ListaBetöltéseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaBetöltéseToolStripMenuItem.Click
        'Load the list into the view
        Call loadlist("followlist.txt")
        Me.Text = "MPL Csomagkövetés - Követési lista"
    End Sub

    Private Sub KIjelöltekHozzáadásaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KIjelöltekHozzáadásaToolStripMenuItem.Click
        'Add selected lines to the list
        Button5.Focus()
        DataGridView1.Focus()
        Call addtofollowlist()
    End Sub
    Private Sub ListaÜrítéseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaÜrítéseToolStripMenuItem.Click
        'Remove all lines from the list
        Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Using sw As New IO.StreamWriter(dpath & "followlist.txt")
            sw.WriteLine("Választott" & String.Join(";", headers))
        End Using
    End Sub
    Private Sub KijelöltekEltávolításaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KijelöltekEltávolításaToolStripMenuItem.Click
        'Remove selected lines from the list
        Button5.Focus()
        DataGridView1.Focus()
        Call removefromfollowlist()
    End Sub

    Private Sub BezárásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BezárásToolStripMenuItem.Click
        Call currentlist()
        Application.Exit()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call currentlist()
    End Sub

End Class