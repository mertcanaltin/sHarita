<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRHAnaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainerTRH = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.YolTarifiAlButton = New System.Windows.Forms.Button()
        Me.NereyeTextBox = New System.Windows.Forms.TextBox()
        Me.NeredenTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MarkerTemizleButton = New System.Windows.Forms.Button()
        Me.MarkerSecButton = New System.Windows.Forms.Button()
        Me.MarkerCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.KoordinataGitButton = New System.Windows.Forms.Button()
        Me.BoylamTextBox = New System.Windows.Forms.TextBox()
        Me.EnlemTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AdresAraButton = New System.Windows.Forms.Button()
        Me.AdresTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ZoomNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HaritaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TRHGMap = New GMap.NET.WindowsForms.GMapControl()
        CType(Me.SplitContainerTRH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerTRH.Panel1.SuspendLayout()
        Me.SplitContainerTRH.Panel2.SuspendLayout()
        Me.SplitContainerTRH.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ZoomNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerTRH
        '
        Me.SplitContainerTRH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerTRH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerTRH.IsSplitterFixed = True
        Me.SplitContainerTRH.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerTRH.Name = "SplitContainerTRH"
        '
        'SplitContainerTRH.Panel1
        '
        Me.SplitContainerTRH.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainerTRH.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainerTRH.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainerTRH.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainerTRH.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainerTRH.Panel2
        '
        Me.SplitContainerTRH.Panel2.Controls.Add(Me.TRHGMap)
        Me.SplitContainerTRH.Size = New System.Drawing.Size(800, 534)
        Me.SplitContainerTRH.SplitterDistance = 250
        Me.SplitContainerTRH.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.YolTarifiAlButton)
        Me.GroupBox5.Controls.Add(Me.NereyeTextBox)
        Me.GroupBox5.Controls.Add(Me.NeredenTextBox)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 366)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(250, 127)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Yol Tarifi Al"
        '
        'YolTarifiAlButton
        '
        Me.YolTarifiAlButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.YolTarifiAlButton.Image = Global.sHarita.My.Resources.Resources.git
        Me.YolTarifiAlButton.Location = New System.Drawing.Point(3, 78)
        Me.YolTarifiAlButton.Name = "YolTarifiAlButton"
        Me.YolTarifiAlButton.Size = New System.Drawing.Size(244, 46)
        Me.YolTarifiAlButton.TabIndex = 9
        Me.YolTarifiAlButton.Text = "Yol Tarifi Al"
        Me.YolTarifiAlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.YolTarifiAlButton.UseVisualStyleBackColor = True
        '
        'NereyeTextBox
        '
        Me.NereyeTextBox.Location = New System.Drawing.Point(59, 46)
        Me.NereyeTextBox.Name = "NereyeTextBox"
        Me.NereyeTextBox.Size = New System.Drawing.Size(185, 20)
        Me.NereyeTextBox.TabIndex = 8
        '
        'NeredenTextBox
        '
        Me.NeredenTextBox.Location = New System.Drawing.Point(59, 20)
        Me.NeredenTextBox.Name = "NeredenTextBox"
        Me.NeredenTextBox.Size = New System.Drawing.Size(185, 20)
        Me.NeredenTextBox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nereye:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nereden:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MarkerTemizleButton)
        Me.GroupBox4.Controls.Add(Me.MarkerSecButton)
        Me.GroupBox4.Controls.Add(Me.MarkerCheckBox)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 118)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "İşaret Ekle"
        '
        'MarkerTemizleButton
        '
        Me.MarkerTemizleButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MarkerTemizleButton.Image = Global.sHarita.My.Resources.Resources.MarkerSec
        Me.MarkerTemizleButton.Location = New System.Drawing.Point(3, 78)
        Me.MarkerTemizleButton.Name = "MarkerTemizleButton"
        Me.MarkerTemizleButton.Size = New System.Drawing.Size(244, 37)
        Me.MarkerTemizleButton.TabIndex = 6
        Me.MarkerTemizleButton.Text = "Tüm İşaretleri Temizle"
        Me.MarkerTemizleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MarkerTemizleButton.UseVisualStyleBackColor = True
        '
        'MarkerSecButton
        '
        Me.MarkerSecButton.Image = Global.sHarita.My.Resources.Resources.MarkerSec
        Me.MarkerSecButton.Location = New System.Drawing.Point(163, 8)
        Me.MarkerSecButton.Name = "MarkerSecButton"
        Me.MarkerSecButton.Size = New System.Drawing.Size(84, 69)
        Me.MarkerSecButton.TabIndex = 5
        Me.MarkerSecButton.Text = "İşaret Şeç"
        Me.MarkerSecButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MarkerSecButton.UseVisualStyleBackColor = True
        '
        'MarkerCheckBox
        '
        Me.MarkerCheckBox.AutoSize = True
        Me.MarkerCheckBox.Image = Global.sHarita.My.Resources.Resources.mavi
        Me.MarkerCheckBox.Location = New System.Drawing.Point(15, 19)
        Me.MarkerCheckBox.Name = "MarkerCheckBox"
        Me.MarkerCheckBox.Size = New System.Drawing.Size(124, 48)
        Me.MarkerCheckBox.TabIndex = 0
        Me.MarkerCheckBox.Text = "İşaret Ekle"
        Me.MarkerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MarkerCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.KoordinataGitButton)
        Me.GroupBox3.Controls.Add(Me.BoylamTextBox)
        Me.GroupBox3.Controls.Add(Me.EnlemTextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 82)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Koordinata Git"
        '
        'KoordinataGitButton
        '
        Me.KoordinataGitButton.Image = Global.sHarita.My.Resources.Resources.git
        Me.KoordinataGitButton.Location = New System.Drawing.Point(186, 24)
        Me.KoordinataGitButton.Name = "KoordinataGitButton"
        Me.KoordinataGitButton.Size = New System.Drawing.Size(58, 46)
        Me.KoordinataGitButton.TabIndex = 4
        Me.KoordinataGitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KoordinataGitButton.UseVisualStyleBackColor = True
        '
        'BoylamTextBox
        '
        Me.BoylamTextBox.Location = New System.Drawing.Point(62, 50)
        Me.BoylamTextBox.Name = "BoylamTextBox"
        Me.BoylamTextBox.Size = New System.Drawing.Size(118, 20)
        Me.BoylamTextBox.TabIndex = 3
        '
        'EnlemTextBox
        '
        Me.EnlemTextBox.Location = New System.Drawing.Point(62, 24)
        Me.EnlemTextBox.Name = "EnlemTextBox"
        Me.EnlemTextBox.Size = New System.Drawing.Size(118, 20)
        Me.EnlemTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Boylam:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Enlem:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AdresAraButton)
        Me.GroupBox2.Controls.Add(Me.AdresTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adres Arama"
        '
        'AdresAraButton
        '
        Me.AdresAraButton.Image = Global.sHarita.My.Resources.Resources.ara
        Me.AdresAraButton.Location = New System.Drawing.Point(215, 32)
        Me.AdresAraButton.Name = "AdresAraButton"
        Me.AdresAraButton.Size = New System.Drawing.Size(29, 25)
        Me.AdresAraButton.TabIndex = 2
        Me.AdresAraButton.UseVisualStyleBackColor = True
        '
        'AdresTextBox
        '
        Me.AdresTextBox.Location = New System.Drawing.Point(6, 35)
        Me.AdresTextBox.Name = "AdresTextBox"
        Me.AdresTextBox.Size = New System.Drawing.Size(209, 20)
        Me.AdresTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Adres:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ZoomNUD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.HaritaComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Harita"
        '
        'ZoomNUD
        '
        Me.ZoomNUD.Location = New System.Drawing.Point(62, 63)
        Me.ZoomNUD.Name = "ZoomNUD"
        Me.ZoomNUD.Size = New System.Drawing.Size(50, 20)
        Me.ZoomNUD.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Yakınlaş:"
        '
        'HaritaComboBox
        '
        Me.HaritaComboBox.FormattingEnabled = True
        Me.HaritaComboBox.Location = New System.Drawing.Point(6, 36)
        Me.HaritaComboBox.Name = "HaritaComboBox"
        Me.HaritaComboBox.Size = New System.Drawing.Size(238, 21)
        Me.HaritaComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harita Seçimi:"
        '
        'TRHGMap
        '
        Me.TRHGMap.Bearing = 0!
        Me.TRHGMap.CanDragMap = True
        Me.TRHGMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TRHGMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.TRHGMap.GrayScaleMode = False
        Me.TRHGMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.TRHGMap.LevelsKeepInMemmory = 5
        Me.TRHGMap.Location = New System.Drawing.Point(0, 0)
        Me.TRHGMap.MarkersEnabled = True
        Me.TRHGMap.MaxZoom = 2
        Me.TRHGMap.MinZoom = 2
        Me.TRHGMap.MouseWheelZoomEnabled = True
        Me.TRHGMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.TRHGMap.Name = "TRHGMap"
        Me.TRHGMap.NegativeMode = False
        Me.TRHGMap.PolygonsEnabled = True
        Me.TRHGMap.RetryLoadTile = 0
        Me.TRHGMap.RoutesEnabled = True
        Me.TRHGMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.TRHGMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TRHGMap.ShowTileGridLines = False
        Me.TRHGMap.Size = New System.Drawing.Size(546, 534)
        Me.TRHGMap.TabIndex = 0
        Me.TRHGMap.Zoom = 0R
        '
        'TRHAnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.SplitContainerTRH)
        Me.Name = "TRHAnaForm"
        Me.Text = "sHarita"
        Me.SplitContainerTRH.Panel1.ResumeLayout(False)
        Me.SplitContainerTRH.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerTRH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerTRH.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ZoomNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerTRH As SplitContainer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ZoomNUD As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents HaritaComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TRHGMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents AdresAraButton As Button
    Friend WithEvents AdresTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents KoordinataGitButton As Button
    Friend WithEvents BoylamTextBox As TextBox
    Friend WithEvents EnlemTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MarkerSecButton As Button
    Friend WithEvents MarkerCheckBox As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents YolTarifiAlButton As Button
    Friend WithEvents NereyeTextBox As TextBox
    Friend WithEvents NeredenTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MarkerTemizleButton As Button
End Class
