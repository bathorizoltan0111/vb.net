<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Checker = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FájlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MegnyitásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlapértelmezettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KövetésiListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtolsóÁllapotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BezárásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KövetésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaBetöltéseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KIjelöltekHozzáadásaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KijelöltekEltávolításaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaÜrítéseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NévjegyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Checker, Me.ID, Me.RecipientName, Me.Address, Me.Phone, Me.Email, Me.PValue, Me.Amount, Me.Price, Me.Weight, Me.Extras})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 31)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1291, 622)
        Me.DataGridView1.TabIndex = 6
        '
        'Checker
        '
        Me.Checker.Frozen = True
        Me.Checker.HeaderText = ""
        Me.Checker.Name = "Checker"
        Me.Checker.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Checker.Width = 30
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "Csomagkód"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 120
        '
        'RecipientName
        '
        Me.RecipientName.Frozen = True
        Me.RecipientName.HeaderText = "Név"
        Me.RecipientName.Name = "RecipientName"
        Me.RecipientName.ReadOnly = True
        Me.RecipientName.Width = 160
        '
        'Address
        '
        Me.Address.HeaderText = "Cím"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 220
        '
        'Phone
        '
        Me.Phone.HeaderText = "Telefonszám"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Width = 115
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 170
        '
        'PValue
        '
        Me.PValue.HeaderText = "Érték"
        Me.PValue.Name = "PValue"
        Me.PValue.ReadOnly = True
        Me.PValue.Width = 68
        '
        'Amount
        '
        Me.Amount.HeaderText = "Utánvét"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 68
        '
        'Price
        '
        Me.Price.HeaderText = "Feladási ktg."
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 68
        '
        'Weight
        '
        Me.Weight.HeaderText = "Súly"
        Me.Weight.Name = "Weight"
        Me.Weight.ReadOnly = True
        Me.Weight.Width = 68
        '
        'Extras
        '
        Me.Extras.HeaderText = "Különszolgáltatások"
        Me.Extras.Name = "Extras"
        Me.Extras.ReadOnly = True
        Me.Extras.Width = 175
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 660)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Kijelöltek ellenőrzése"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 660)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Mind ellenőrzése"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FájlToolStripMenuItem, Me.KövetésToolStripMenuItem, Me.NévjegyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1323, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FájlToolStripMenuItem
        '
        Me.FájlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MegnyitásToolStripMenuItem, Me.AlapértelmezettToolStripMenuItem, Me.BezárásToolStripMenuItem})
        Me.FájlToolStripMenuItem.Name = "FájlToolStripMenuItem"
        Me.FájlToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
        Me.FájlToolStripMenuItem.Text = "Fájl"
        '
        'MegnyitásToolStripMenuItem
        '
        Me.MegnyitásToolStripMenuItem.Name = "MegnyitásToolStripMenuItem"
        Me.MegnyitásToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.MegnyitásToolStripMenuItem.Text = "Megnyitás"
        '
        'AlapértelmezettToolStripMenuItem
        '
        Me.AlapértelmezettToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜresToolStripMenuItem, Me.KövetésiListaToolStripMenuItem, Me.UtolsóÁllapotToolStripMenuItem})
        Me.AlapértelmezettToolStripMenuItem.Name = "AlapértelmezettToolStripMenuItem"
        Me.AlapértelmezettToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AlapértelmezettToolStripMenuItem.Text = "Alapértelmezett"
        '
        'ÜresToolStripMenuItem
        '
        Me.ÜresToolStripMenuItem.Checked = True
        Me.ÜresToolStripMenuItem.CheckOnClick = True
        Me.ÜresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ÜresToolStripMenuItem.Name = "ÜresToolStripMenuItem"
        Me.ÜresToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.ÜresToolStripMenuItem.Text = "Üres"
        '
        'KövetésiListaToolStripMenuItem
        '
        Me.KövetésiListaToolStripMenuItem.CheckOnClick = True
        Me.KövetésiListaToolStripMenuItem.Name = "KövetésiListaToolStripMenuItem"
        Me.KövetésiListaToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.KövetésiListaToolStripMenuItem.Text = "Követési lista"
        '
        'UtolsóÁllapotToolStripMenuItem
        '
        Me.UtolsóÁllapotToolStripMenuItem.CheckOnClick = True
        Me.UtolsóÁllapotToolStripMenuItem.Name = "UtolsóÁllapotToolStripMenuItem"
        Me.UtolsóÁllapotToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.UtolsóÁllapotToolStripMenuItem.Text = "Utolsó állapot"
        '
        'BezárásToolStripMenuItem
        '
        Me.BezárásToolStripMenuItem.Name = "BezárásToolStripMenuItem"
        Me.BezárásToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.BezárásToolStripMenuItem.Text = "Bezárás"
        '
        'KövetésToolStripMenuItem
        '
        Me.KövetésToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaBetöltéseToolStripMenuItem, Me.KIjelöltekHozzáadásaToolStripMenuItem, Me.KijelöltekEltávolításaToolStripMenuItem, Me.ListaÜrítéseToolStripMenuItem})
        Me.KövetésToolStripMenuItem.Name = "KövetésToolStripMenuItem"
        Me.KövetésToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.KövetésToolStripMenuItem.Text = "Követési lista"
        '
        'ListaBetöltéseToolStripMenuItem
        '
        Me.ListaBetöltéseToolStripMenuItem.Name = "ListaBetöltéseToolStripMenuItem"
        Me.ListaBetöltéseToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.ListaBetöltéseToolStripMenuItem.Text = "Lista betöltése"
        '
        'KIjelöltekHozzáadásaToolStripMenuItem
        '
        Me.KIjelöltekHozzáadásaToolStripMenuItem.Name = "KIjelöltekHozzáadásaToolStripMenuItem"
        Me.KIjelöltekHozzáadásaToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.KIjelöltekHozzáadásaToolStripMenuItem.Text = "Kijelöltek hozzáadása"
        '
        'KijelöltekEltávolításaToolStripMenuItem
        '
        Me.KijelöltekEltávolításaToolStripMenuItem.Name = "KijelöltekEltávolításaToolStripMenuItem"
        Me.KijelöltekEltávolításaToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.KijelöltekEltávolításaToolStripMenuItem.Text = "Kijelöltek eltávolítása"
        '
        'ListaÜrítéseToolStripMenuItem
        '
        Me.ListaÜrítéseToolStripMenuItem.Name = "ListaÜrítéseToolStripMenuItem"
        Me.ListaÜrítéseToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.ListaÜrítéseToolStripMenuItem.Text = "Lista ürítése"
        '
        'NévjegyToolStripMenuItem
        '
        Me.NévjegyToolStripMenuItem.Name = "NévjegyToolStripMenuItem"
        Me.NévjegyToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.NévjegyToolStripMenuItem.Text = "Névjegy"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 660)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 28)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "XML Import"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(24, 46)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 697)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "MPL Csomagkövetés"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FájlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MegnyitásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BezárásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KövetésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaBetöltéseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KIjelöltekHozzáadásaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaÜrítéseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NévjegyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button5 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AlapértelmezettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KövetésiListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtolsóÁllapotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KijelöltekEltávolításaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Checker As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents RecipientName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents PValue As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Weight As DataGridViewTextBoxColumn
    Friend WithEvents Extras As DataGridViewTextBoxColumn
End Class
