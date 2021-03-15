Option Strict Off
Option Explicit On
Friend Class frmCap
	Inherits System.Windows.Forms.Form
#Region "Codice generato dalla finestra di progettazione Windows Form "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'La prima istanza creata per il form di avvio rappresenta l'istanza predefinita.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'Chiamata richiesta dalla progettazione Windows Form.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Il form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Richiesto dalla progettazione Windows Form
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Private ADOBind_qryCap As VB6.MBindingCollection
	Public WithEvents cmdModifica As System.Windows.Forms.Button
	Public WithEvents cmdElimina As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_0 As System.Windows.Forms.PictureBox
	Public WithEvents _imgTestata_1 As System.Windows.Forms.PictureBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_2 As System.Windows.Forms.PictureBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_5 As System.Windows.Forms.PictureBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_8 As System.Windows.Forms.PictureBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_6 As System.Windows.Forms.PictureBox
	Public WithEvents _imgTestata_7 As System.Windows.Forms.PictureBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_9 As System.Windows.Forms.PictureBox
	Public WithEvents PicTestata As System.Windows.Forms.Panel
	Public WithEvents cmdAggiungi As System.Windows.Forms.Button
	Public WithEvents dtcCap As AxMSDataListLib.AxDataCombo
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents imgTestata As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mEsci As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents mnuEsci As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents mnuFile As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents _mnuFile_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_2 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_3 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_4 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_5 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_6 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_7 As System.Windows.Forms.MenuItem
	Public WithEvents mFile As System.Windows.Forms.MenuItem
	Public WithEvents _mnuEsci_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuEsci_2 As System.Windows.Forms.MenuItem
	Public WithEvents _mEsci_1 As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTA: la routine seguente è richiesta dalla progettazione Windows Form.
	'Può essere modificata utilizzando la finestra di progettazione Windows Form.
	'Non modificarla mediante l'editor di codice.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCap))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdModifica = New System.Windows.Forms.Button
		Me.cmdElimina = New System.Windows.Forms.Button
		Me.PicTestata = New System.Windows.Forms.Panel
		Me.Label2 = New System.Windows.Forms.Label
		Me._imgTestata_0 = New System.Windows.Forms.PictureBox
		Me._imgTestata_1 = New System.Windows.Forms.PictureBox
		Me.Label10 = New System.Windows.Forms.Label
		Me._imgTestata_2 = New System.Windows.Forms.PictureBox
		Me.Label11 = New System.Windows.Forms.Label
		Me._imgTestata_4 = New System.Windows.Forms.PictureBox
		Me.Label13 = New System.Windows.Forms.Label
		Me._imgTestata_5 = New System.Windows.Forms.PictureBox
		Me.Label14 = New System.Windows.Forms.Label
		Me._imgTestata_8 = New System.Windows.Forms.PictureBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me._imgTestata_6 = New System.Windows.Forms.PictureBox
		Me._imgTestata_7 = New System.Windows.Forms.PictureBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me._imgTestata_9 = New System.Windows.Forms.PictureBox
		Me.cmdAggiungi = New System.Windows.Forms.Button
		Me.dtcCap = New AxMSDataListLib.AxDataCombo
		Me.Label1 = New System.Windows.Forms.Label
		Me.imgTestata = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.mEsci = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.mnuEsci = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.mnuFile = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mFile = New System.Windows.Forms.MenuItem
		Me._mnuFile_1 = New System.Windows.Forms.MenuItem
		Me._mnuFile_2 = New System.Windows.Forms.MenuItem
		Me._mnuFile_3 = New System.Windows.Forms.MenuItem
		Me._mnuFile_4 = New System.Windows.Forms.MenuItem
		Me._mnuFile_5 = New System.Windows.Forms.MenuItem
		Me._mnuFile_6 = New System.Windows.Forms.MenuItem
		Me._mnuFile_7 = New System.Windows.Forms.MenuItem
		Me._mEsci_1 = New System.Windows.Forms.MenuItem
		Me._mnuEsci_1 = New System.Windows.Forms.MenuItem
		Me._mnuEsci_2 = New System.Windows.Forms.MenuItem
		CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mEsci, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuEsci, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Gestione CAP"
		Me.ClientSize = New System.Drawing.Size(792, 546)
		Me.Location = New System.Drawing.Point(11, 57)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCap"
		Me.cmdModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdModifica.Text = "Modifica"
		Me.cmdModifica.Size = New System.Drawing.Size(113, 49)
		Me.cmdModifica.Location = New System.Drawing.Point(368, 304)
		Me.cmdModifica.Image = CType(resources.GetObject("cmdModifica.Image"), System.Drawing.Image)
		Me.cmdModifica.TabIndex = 14
		Me.cmdModifica.BackColor = System.Drawing.SystemColors.Control
		Me.cmdModifica.CausesValidation = True
		Me.cmdModifica.Enabled = True
		Me.cmdModifica.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdModifica.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdModifica.TabStop = True
		Me.cmdModifica.Name = "cmdModifica"
		Me.cmdElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdElimina.Text = "Elimina"
		Me.cmdElimina.Size = New System.Drawing.Size(113, 49)
		Me.cmdElimina.Location = New System.Drawing.Point(368, 232)
		Me.cmdElimina.Image = CType(resources.GetObject("cmdElimina.Image"), System.Drawing.Image)
		Me.cmdElimina.TabIndex = 13
		Me.cmdElimina.BackColor = System.Drawing.SystemColors.Control
		Me.cmdElimina.CausesValidation = True
		Me.cmdElimina.Enabled = True
		Me.cmdElimina.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdElimina.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdElimina.TabStop = True
		Me.cmdElimina.Name = "cmdElimina"
		Me.PicTestata.BackColor = System.Drawing.SystemColors.GrayText
		Me.PicTestata.Size = New System.Drawing.Size(793, 89)
		Me.PicTestata.Location = New System.Drawing.Point(0, 0)
		Me.PicTestata.TabIndex = 3
		Me.PicTestata.Dock = System.Windows.Forms.DockStyle.None
		Me.PicTestata.CausesValidation = True
		Me.PicTestata.Enabled = True
		Me.PicTestata.ForeColor = System.Drawing.SystemColors.ControlText
		Me.PicTestata.Cursor = System.Windows.Forms.Cursors.Default
		Me.PicTestata.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PicTestata.TabStop = True
		Me.PicTestata.Visible = True
		Me.PicTestata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PicTestata.Name = "PicTestata"
		Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label2.Text = "F8 - Titoli"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(472, 56)
		Me.Label2.TabIndex = 12
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me._imgTestata_0.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_0.Location = New System.Drawing.Point(480, 16)
		Me._imgTestata_0.Image = CType(resources.GetObject("_imgTestata_0.Image"), System.Drawing.Image)
		Me.ToolTip1.SetToolTip(Me._imgTestata_0, "Gestione Titoli")
		Me._imgTestata_0.Enabled = True
		Me._imgTestata_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_0.Visible = True
		Me._imgTestata_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_0.Name = "_imgTestata_0"
		Me._imgTestata_1.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_1.Location = New System.Drawing.Point(8, 16)
		Me._imgTestata_1.Image = CType(resources.GetObject("_imgTestata_1.Image"), System.Drawing.Image)
		Me._imgTestata_1.Enabled = True
		Me._imgTestata_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_1.Visible = True
		Me._imgTestata_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_1.Name = "_imgTestata_1"
		Me.Label10.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label10.Text = "F2 - Causali"
		Me.Label10.Size = New System.Drawing.Size(65, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 56)
		Me.Label10.TabIndex = 11
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me._imgTestata_2.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_2.Location = New System.Drawing.Point(88, 16)
		Me._imgTestata_2.Image = CType(resources.GetObject("_imgTestata_2.Image"), System.Drawing.Image)
		Me._imgTestata_2.Enabled = True
		Me._imgTestata_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_2.Visible = True
		Me._imgTestata_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_2.Name = "_imgTestata_2"
		Me.Label11.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label11.Text = "F3 - Città"
		Me.Label11.Size = New System.Drawing.Size(49, 17)
		Me.Label11.Location = New System.Drawing.Point(88, 56)
		Me.Label11.TabIndex = 10
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me._imgTestata_4.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_4.Location = New System.Drawing.Point(232, 16)
		Me._imgTestata_4.Image = CType(resources.GetObject("_imgTestata_4.Image"), System.Drawing.Image)
		Me._imgTestata_4.Enabled = True
		Me._imgTestata_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_4.Visible = True
		Me._imgTestata_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_4.Name = "_imgTestata_4"
		Me.Label13.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label13.Text = "F5 - Conti"
		Me.Label13.Size = New System.Drawing.Size(65, 17)
		Me.Label13.Location = New System.Drawing.Point(232, 56)
		Me.Label13.TabIndex = 9
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me._imgTestata_5.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_5.Location = New System.Drawing.Point(304, 16)
		Me._imgTestata_5.Image = CType(resources.GetObject("_imgTestata_5.Image"), System.Drawing.Image)
		Me._imgTestata_5.Enabled = True
		Me._imgTestata_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_5.Visible = True
		Me._imgTestata_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_5.Name = "_imgTestata_5"
		Me.Label14.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label14.Text = "F6 - Movimenti"
		Me.Label14.Size = New System.Drawing.Size(81, 17)
		Me.Label14.Location = New System.Drawing.Point(312, 56)
		Me.Label14.TabIndex = 8
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me._imgTestata_8.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_8.Location = New System.Drawing.Point(664, 16)
		Me._imgTestata_8.Image = CType(resources.GetObject("_imgTestata_8.Image"), System.Drawing.Image)
		Me._imgTestata_8.Enabled = True
		Me._imgTestata_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_8.Visible = True
		Me._imgTestata_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_8.Name = "_imgTestata_8"
		Me.Label16.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label16.Text = "F12 - Torna al menù principale"
		Me.Label16.Size = New System.Drawing.Size(129, 25)
		Me.Label16.Location = New System.Drawing.Point(656, 56)
		Me.Label16.TabIndex = 7
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label17.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label17.Text = "F7 - Filiali"
		Me.Label17.Size = New System.Drawing.Size(57, 17)
		Me.Label17.Location = New System.Drawing.Point(400, 56)
		Me.Label17.TabIndex = 6
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = False
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me._imgTestata_6.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_6.Location = New System.Drawing.Point(400, 16)
		Me._imgTestata_6.Image = CType(resources.GetObject("_imgTestata_6.Image"), System.Drawing.Image)
		Me._imgTestata_6.Enabled = True
		Me._imgTestata_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_6.Visible = True
		Me._imgTestata_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_6.Name = "_imgTestata_6"
		Me._imgTestata_7.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_7.Location = New System.Drawing.Point(560, 16)
		Me._imgTestata_7.Image = CType(resources.GetObject("_imgTestata_7.Image"), System.Drawing.Image)
		Me._imgTestata_7.Enabled = True
		Me._imgTestata_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_7.Visible = True
		Me._imgTestata_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_7.Name = "_imgTestata_7"
		Me.Label15.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label15.Text = "F9 - Interrompi"
		Me.Label15.Size = New System.Drawing.Size(73, 17)
		Me.Label15.Location = New System.Drawing.Point(552, 56)
		Me.Label15.TabIndex = 5
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label18.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label18.Text = "CTRL + F2 - Provincia"
		Me.Label18.Size = New System.Drawing.Size(65, 33)
		Me.Label18.Location = New System.Drawing.Point(160, 56)
		Me.Label18.TabIndex = 4
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label18.Enabled = True
		Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label18.UseMnemonic = True
		Me.Label18.Visible = True
		Me.Label18.AutoSize = False
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label18.Name = "Label18"
		Me._imgTestata_9.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_9.Location = New System.Drawing.Point(160, 16)
		Me._imgTestata_9.Image = CType(resources.GetObject("_imgTestata_9.Image"), System.Drawing.Image)
		Me._imgTestata_9.Enabled = True
		Me._imgTestata_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_9.Visible = True
		Me._imgTestata_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_9.Name = "_imgTestata_9"
		Me.cmdAggiungi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiungi.Text = "Aggiungi"
		Me.cmdAggiungi.Size = New System.Drawing.Size(113, 49)
		Me.cmdAggiungi.Location = New System.Drawing.Point(368, 160)
		Me.cmdAggiungi.Image = CType(resources.GetObject("cmdAggiungi.Image"), System.Drawing.Image)
		Me.cmdAggiungi.TabIndex = 2
		Me.cmdAggiungi.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiungi.CausesValidation = True
		Me.cmdAggiungi.Enabled = True
		Me.cmdAggiungi.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiungi.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiungi.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiungi.TabStop = True
		Me.cmdAggiungi.Name = "cmdAggiungi"
		dtcCap.OcxState = CType(resources.GetObject("dtcCap.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtcCap.Size = New System.Drawing.Size(137, 21)
		Me.dtcCap.Location = New System.Drawing.Point(208, 200)
		Me.dtcCap.TabIndex = 1
		Me.dtcCap.Name = "dtcCap"
		Me.Label1.Text = "NUMERO CAP"
		Me.Label1.Size = New System.Drawing.Size(137, 25)
		Me.Label1.Location = New System.Drawing.Point(56, 200)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.mFile.Text = "File"
		Me.mFile.Checked = False
		Me.mFile.Enabled = True
		Me.mFile.Visible = True
		Me.mFile.MDIList = False
		Me._mnuFile_1.Text = "Causali"
		Me._mnuFile_1.Shortcut = System.Windows.Forms.Shortcut.F2
		Me._mnuFile_1.Checked = False
		Me._mnuFile_1.Enabled = True
		Me._mnuFile_1.Visible = True
		Me._mnuFile_1.MDIList = False
		Me._mnuFile_2.Text = "Città"
		Me._mnuFile_2.Shortcut = System.Windows.Forms.Shortcut.F3
		Me._mnuFile_2.Checked = False
		Me._mnuFile_2.Enabled = True
		Me._mnuFile_2.Visible = True
		Me._mnuFile_2.MDIList = False
		Me._mnuFile_3.Text = "Provincia"
		Me._mnuFile_3.Shortcut = System.Windows.Forms.Shortcut.CtrlF2
		Me._mnuFile_3.Checked = False
		Me._mnuFile_3.Enabled = True
		Me._mnuFile_3.Visible = True
		Me._mnuFile_3.MDIList = False
		Me._mnuFile_4.Text = "Conti"
		Me._mnuFile_4.Shortcut = System.Windows.Forms.Shortcut.F5
		Me._mnuFile_4.Checked = False
		Me._mnuFile_4.Enabled = True
		Me._mnuFile_4.Visible = True
		Me._mnuFile_4.MDIList = False
		Me._mnuFile_5.Text = "Movimenti"
		Me._mnuFile_5.Shortcut = System.Windows.Forms.Shortcut.F6
		Me._mnuFile_5.Checked = False
		Me._mnuFile_5.Enabled = True
		Me._mnuFile_5.Visible = True
		Me._mnuFile_5.MDIList = False
		Me._mnuFile_6.Text = "Filiali"
		Me._mnuFile_6.Shortcut = System.Windows.Forms.Shortcut.F7
		Me._mnuFile_6.Checked = False
		Me._mnuFile_6.Enabled = True
		Me._mnuFile_6.Visible = True
		Me._mnuFile_6.MDIList = False
		Me._mnuFile_7.Text = "Titoli"
		Me._mnuFile_7.Shortcut = System.Windows.Forms.Shortcut.F8
		Me._mnuFile_7.Checked = False
		Me._mnuFile_7.Enabled = True
		Me._mnuFile_7.Visible = True
		Me._mnuFile_7.MDIList = False
		Me._mEsci_1.Text = "Esci"
		Me._mEsci_1.Checked = False
		Me._mEsci_1.Enabled = True
		Me._mEsci_1.Visible = True
		Me._mEsci_1.MDIList = False
		Me._mnuEsci_1.Text = "Interrompi"
		Me._mnuEsci_1.Shortcut = System.Windows.Forms.Shortcut.F9
		Me._mnuEsci_1.Checked = False
		Me._mnuEsci_1.Enabled = True
		Me._mnuEsci_1.Visible = True
		Me._mnuEsci_1.MDIList = False
		Me._mnuEsci_2.Text = "Torna al menù principale"
		Me._mnuEsci_2.Shortcut = System.Windows.Forms.Shortcut.F12
		Me._mnuEsci_2.Checked = False
		Me._mnuEsci_2.Enabled = True
		Me._mnuEsci_2.Visible = True
		Me._mnuEsci_2.MDIList = False
		Me.Controls.Add(cmdModifica)
		Me.Controls.Add(cmdElimina)
		Me.Controls.Add(PicTestata)
		Me.Controls.Add(cmdAggiungi)
		Me.Controls.Add(dtcCap)
		Me.Controls.Add(Label1)
		Me.PicTestata.Controls.Add(Label2)
		Me.PicTestata.Controls.Add(_imgTestata_0)
		Me.PicTestata.Controls.Add(_imgTestata_1)
		Me.PicTestata.Controls.Add(Label10)
		Me.PicTestata.Controls.Add(_imgTestata_2)
		Me.PicTestata.Controls.Add(Label11)
		Me.PicTestata.Controls.Add(_imgTestata_4)
		Me.PicTestata.Controls.Add(Label13)
		Me.PicTestata.Controls.Add(_imgTestata_5)
		Me.PicTestata.Controls.Add(Label14)
		Me.PicTestata.Controls.Add(_imgTestata_8)
		Me.PicTestata.Controls.Add(Label16)
		Me.PicTestata.Controls.Add(Label17)
		Me.PicTestata.Controls.Add(_imgTestata_6)
		Me.PicTestata.Controls.Add(_imgTestata_7)
		Me.PicTestata.Controls.Add(Label15)
		Me.PicTestata.Controls.Add(Label18)
		Me.PicTestata.Controls.Add(_imgTestata_9)
		Me.imgTestata.SetIndex(_imgTestata_0, CType(0, Short))
		Me.imgTestata.SetIndex(_imgTestata_1, CType(1, Short))
		Me.imgTestata.SetIndex(_imgTestata_2, CType(2, Short))
		Me.imgTestata.SetIndex(_imgTestata_4, CType(4, Short))
		Me.imgTestata.SetIndex(_imgTestata_5, CType(5, Short))
		Me.imgTestata.SetIndex(_imgTestata_8, CType(8, Short))
		Me.imgTestata.SetIndex(_imgTestata_6, CType(6, Short))
		Me.imgTestata.SetIndex(_imgTestata_7, CType(7, Short))
		Me.imgTestata.SetIndex(_imgTestata_9, CType(9, Short))
		Me.mEsci.SetIndex(_mEsci_1, CType(1, Short))
		Me.mnuEsci.SetIndex(_mnuEsci_1, CType(1, Short))
		Me.mnuEsci.SetIndex(_mnuEsci_2, CType(2, Short))
		Me.mnuFile.SetIndex(_mnuFile_1, CType(1, Short))
		Me.mnuFile.SetIndex(_mnuFile_2, CType(2, Short))
		Me.mnuFile.SetIndex(_mnuFile_3, CType(3, Short))
		Me.mnuFile.SetIndex(_mnuFile_4, CType(4, Short))
		Me.mnuFile.SetIndex(_mnuFile_5, CType(5, Short))
		Me.mnuFile.SetIndex(_mnuFile_6, CType(6, Short))
		Me.mnuFile.SetIndex(_mnuFile_7, CType(7, Short))
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuEsci, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mEsci, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mFile.Index = 0
		Me._mEsci_1.Index = 1
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mFile, Me._mEsci_1})
		Me._mnuFile_1.Index = 0
		Me._mnuFile_2.Index = 1
		Me._mnuFile_3.Index = 2
		Me._mnuFile_4.Index = 3
		Me._mnuFile_5.Index = 4
		Me._mnuFile_6.Index = 5
		Me._mnuFile_7.Index = 6
		mFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuFile_1, Me._mnuFile_2, Me._mnuFile_3, Me._mnuFile_4, Me._mnuFile_5, Me._mnuFile_6, Me._mnuFile_7})
		Me._mnuEsci_1.Index = 0
		Me._mnuEsci_2.Index = 1
		_mEsci_1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuEsci_1, Me._mnuEsci_2})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Supporto aggiornamento "
	Private Shared m_vb6FormDefInstance As frmCap
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmCap
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmCap()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub cmdAggiungi_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAggiungi.Click
		Dim sqlCap As String
		Dim recCap As New ADODB.Recordset
		sqlCap = "Select * from CAP WHERE numCap = " & dtcCap.CtlText
		recCap = New ADODB.Recordset
		recCap.Open(sqlCap, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recCap.EOF = True Then
			deBanche.rsqryCap.AddNew()
		Else
			MsgBox("Cap già presente. Inserire un altro codice!", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Errore inserimento dati")
			Exit Sub
		End If
		recCap.Close()
		'UPGRADE_NOTE: È possibile che l'oggetto recCap non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		recCap = Nothing
		
		
	End Sub
	
	Private Sub cmdElimina_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdElimina.Click
		deBanche.rsqryCap.Delete()
		
		
	End Sub
	
	Private Sub cmdModifica_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModifica.Click
		deBanche.rsqryCap.Update()
		
	End Sub
	
	Private Sub imgTestata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTestata.Click
		Dim Index As Short = imgTestata.GetIndex(eventSender)
		Dim frmTitoli As frmTitoli
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmConti As frmConti
		Dim frmMovimenti As frmMovimenti
		Dim frmFiliali As frmFiliali
		Dim frmGestioneContiCorrenti As frmGestioneContiCorrenti
		Dim frmProvincia As frmProvincia
		Select Case Index
			Case Is = 0
				frmTitoli = New frmTitoli
				frmTitoli.Show()
				
			Case Is = 1
				frmCausali = New frmCausali
				frmCausali.Show()
			Case Is = 2
				frmCitta = New frmCitta
				frmCitta.Show()
			Case Is = 4
				frmConti = New frmConti
				frmConti.Show()
			Case Is = 5
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 6
				frmFiliali = New frmFiliali
				frmFiliali.Show()
			Case Is = 7
				Me.Close()
				End
			Case Is = 8
				Me.Close()
				frmGestioneContiCorrenti = New frmGestioneContiCorrenti
				frmGestioneContiCorrenti.Show()
				
			Case Is = 9
				frmProvincia = New frmProvincia
				frmProvincia.Show()
		End Select
		
	End Sub
	
	Public Sub mnuEsci_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEsci.Popup
		mnuEsci_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuEsci_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEsci.Click
		Dim Index As Short = mnuEsci.GetIndex(eventSender)
		Dim frmGestioneContiCorrenti As frmGestioneContiCorrenti
		Select Case Index
			Case Is = 1
				Me.Close()
				End
			Case Is = 2
				Me.Close()
				frmGestioneContiCorrenti = New frmGestioneContiCorrenti
				frmGestioneContiCorrenti.Show()
		End Select
		
	End Sub
	
	Public Sub mnuFile_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Popup
		mnuFile_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Click
		Dim Index As Short = mnuFile.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmProvincia As frmProvincia
		Dim frmConti As frmConti
		Dim frmMovimenti As frmMovimenti
		Dim frmFiliali As frmFiliali
		Dim frmTitoli As frmTitoli
		Select Case Index
			Case Is = 1
				frmCausali = New frmCausali
				frmCausali.Show()
			Case Is = 2
				frmCitta = New frmCitta
				frmCitta.Show()
			Case Is = 3
				frmProvincia = New frmProvincia
				frmProvincia.Show()
			Case Is = 4
				frmConti = New frmConti
				frmConti.Show()
			Case Is = 5
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 6
				frmFiliali = New frmFiliali
				frmFiliali.Show()
			Case Is = 7
				frmTitoli = New frmTitoli
				frmTitoli.Show()
				
		End Select
		
	End Sub
	Public Sub VB6_AddADODataBinding()
		deBanche.qryCap()
		ADOBind_qryCap = New VB6.MBindingCollection()
		ADOBind_qryCap.DataSource = deBanche
		ADOBind_qryCap.DataMember = "qryCap"
		ADOBind_qryCap.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_qryCap.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_qryCap.Clear()
		ADOBind_qryCap.Dispose()
		ADOBind_qryCap = Nothing
	End Sub
End Class