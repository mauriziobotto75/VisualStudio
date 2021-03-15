Option Strict Off
Option Explicit On
Friend Class frmMovimenti
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
	Private ADOBind_qryMovimenti2 As VB6.MBindingCollection
	Public WithEvents txtIdConto As System.Windows.Forms.TextBox
	Public WithEvents txtNumConto As System.Windows.Forms.TextBox
	Public WithEvents cmdAggiornaSaldo As System.Windows.Forms.Button
	Public WithEvents _imgTestata_5 As System.Windows.Forms.PictureBox
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_3 As System.Windows.Forms.PictureBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_9 As System.Windows.Forms.PictureBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_6 As System.Windows.Forms.PictureBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_8 As System.Windows.Forms.PictureBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_7 As System.Windows.Forms.PictureBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_2 As System.Windows.Forms.PictureBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_1 As System.Windows.Forms.PictureBox
	Public WithEvents PicTestata As System.Windows.Forms.Panel
	Public WithEvents cmdModifica As System.Windows.Forms.Button
	Public WithEvents cmdElimina As System.Windows.Forms.Button
	Public WithEvents cmdAggiungi As System.Windows.Forms.Button
	Public WithEvents cmdPrimo As System.Windows.Forms.Button
	Public WithEvents cmdPrecedente As System.Windows.Forms.Button
	Public WithEvents cmdSuccessivo As System.Windows.Forms.Button
	Public WithEvents cmdUltimo As System.Windows.Forms.Button
	Public WithEvents txtSegnoMovimento As System.Windows.Forms.TextBox
	Public WithEvents txtDataValuta As System.Windows.Forms.TextBox
	Public WithEvents txtImporto As System.Windows.Forms.TextBox
	Public WithEvents txtDesMovimento As System.Windows.Forms.TextBox
	Public WithEvents txtDataMovimento As System.Windows.Forms.TextBox
	Public WithEvents dtcCausale As AxMSDataListLib.AxDataCombo
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents imgTestata As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mOperazioni As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents mnuFile As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents mnuOperazioni As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents _mnuFile_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_2 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_3 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_4 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_5 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_6 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_7 As System.Windows.Forms.MenuItem
	Public WithEvents mFile As System.Windows.Forms.MenuItem
	Public WithEvents _mnuOperazioni_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mOperazioni_1 As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTA: la routine seguente è richiesta dalla progettazione Windows Form.
	'Può essere modificata utilizzando la finestra di progettazione Windows Form.
	'Non modificarla mediante l'editor di codice.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovimenti))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.txtIdConto = New System.Windows.Forms.TextBox
		Me.txtNumConto = New System.Windows.Forms.TextBox
		Me.cmdAggiornaSaldo = New System.Windows.Forms.Button
		Me.PicTestata = New System.Windows.Forms.Panel
		Me._imgTestata_5 = New System.Windows.Forms.PictureBox
		Me.Label17 = New System.Windows.Forms.Label
		Me._imgTestata_3 = New System.Windows.Forms.PictureBox
		Me.Label16 = New System.Windows.Forms.Label
		Me._imgTestata_9 = New System.Windows.Forms.PictureBox
		Me.Label12 = New System.Windows.Forms.Label
		Me._imgTestata_6 = New System.Windows.Forms.PictureBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me._imgTestata_8 = New System.Windows.Forms.PictureBox
		Me.Label13 = New System.Windows.Forms.Label
		Me._imgTestata_7 = New System.Windows.Forms.PictureBox
		Me.Label11 = New System.Windows.Forms.Label
		Me._imgTestata_4 = New System.Windows.Forms.PictureBox
		Me.Label9 = New System.Windows.Forms.Label
		Me._imgTestata_2 = New System.Windows.Forms.PictureBox
		Me.Label7 = New System.Windows.Forms.Label
		Me._imgTestata_1 = New System.Windows.Forms.PictureBox
		Me.cmdModifica = New System.Windows.Forms.Button
		Me.cmdElimina = New System.Windows.Forms.Button
		Me.cmdAggiungi = New System.Windows.Forms.Button
		Me.cmdPrimo = New System.Windows.Forms.Button
		Me.cmdPrecedente = New System.Windows.Forms.Button
		Me.cmdSuccessivo = New System.Windows.Forms.Button
		Me.cmdUltimo = New System.Windows.Forms.Button
		Me.txtSegnoMovimento = New System.Windows.Forms.TextBox
		Me.txtDataValuta = New System.Windows.Forms.TextBox
		Me.txtImporto = New System.Windows.Forms.TextBox
		Me.txtDesMovimento = New System.Windows.Forms.TextBox
		Me.txtDataMovimento = New System.Windows.Forms.TextBox
		Me.dtcCausale = New AxMSDataListLib.AxDataCombo
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.imgTestata = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.mOperazioni = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.mnuFile = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.mnuOperazioni = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mFile = New System.Windows.Forms.MenuItem
		Me._mnuFile_1 = New System.Windows.Forms.MenuItem
		Me._mnuFile_2 = New System.Windows.Forms.MenuItem
		Me._mnuFile_3 = New System.Windows.Forms.MenuItem
		Me._mnuFile_4 = New System.Windows.Forms.MenuItem
		Me._mnuFile_5 = New System.Windows.Forms.MenuItem
		Me._mnuFile_6 = New System.Windows.Forms.MenuItem
		Me._mnuFile_7 = New System.Windows.Forms.MenuItem
		Me._mOperazioni_1 = New System.Windows.Forms.MenuItem
		Me._mnuOperazioni_1 = New System.Windows.Forms.MenuItem
		CType(Me.dtcCausale, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "GESTIONE MOVIMENTI"
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
		Me.Name = "frmMovimenti"
		Me.txtIdConto.AutoSize = False
		Me.txtIdConto.Size = New System.Drawing.Size(177, 19)
		Me.txtIdConto.Location = New System.Drawing.Point(248, 192)
		Me.txtIdConto.TabIndex = 31
		Me.txtIdConto.Text = " "
		Me.txtIdConto.AcceptsReturn = True
		Me.txtIdConto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIdConto.BackColor = System.Drawing.SystemColors.Window
		Me.txtIdConto.CausesValidation = True
		Me.txtIdConto.Enabled = True
		Me.txtIdConto.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIdConto.HideSelection = True
		Me.txtIdConto.ReadOnly = False
		Me.txtIdConto.Maxlength = 0
		Me.txtIdConto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIdConto.MultiLine = False
		Me.txtIdConto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIdConto.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIdConto.TabStop = True
		Me.txtIdConto.Visible = True
		Me.txtIdConto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIdConto.Name = "txtIdConto"
		Me.txtNumConto.AutoSize = False
		Me.txtNumConto.Size = New System.Drawing.Size(177, 19)
		Me.txtNumConto.Location = New System.Drawing.Point(248, 224)
		Me.txtNumConto.TabIndex = 29
		Me.txtNumConto.Text = " "
		Me.txtNumConto.AcceptsReturn = True
		Me.txtNumConto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNumConto.BackColor = System.Drawing.SystemColors.Window
		Me.txtNumConto.CausesValidation = True
		Me.txtNumConto.Enabled = True
		Me.txtNumConto.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNumConto.HideSelection = True
		Me.txtNumConto.ReadOnly = False
		Me.txtNumConto.Maxlength = 0
		Me.txtNumConto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNumConto.MultiLine = False
		Me.txtNumConto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNumConto.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNumConto.TabStop = True
		Me.txtNumConto.Visible = True
		Me.txtNumConto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNumConto.Name = "txtNumConto"
		Me.cmdAggiornaSaldo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiornaSaldo.Text = "Aggiorna Saldo"
		Me.cmdAggiornaSaldo.Size = New System.Drawing.Size(121, 49)
		Me.cmdAggiornaSaldo.Location = New System.Drawing.Point(640, 224)
		Me.cmdAggiornaSaldo.Image = CType(resources.GetObject("cmdAggiornaSaldo.Image"), System.Drawing.Image)
		Me.cmdAggiornaSaldo.TabIndex = 27
		Me.cmdAggiornaSaldo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiornaSaldo.CausesValidation = True
		Me.cmdAggiornaSaldo.Enabled = True
		Me.cmdAggiornaSaldo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiornaSaldo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiornaSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiornaSaldo.TabStop = True
		Me.cmdAggiornaSaldo.Name = "cmdAggiornaSaldo"
		Me.PicTestata.BackColor = System.Drawing.SystemColors.GrayText
		Me.PicTestata.Size = New System.Drawing.Size(793, 89)
		Me.PicTestata.Location = New System.Drawing.Point(0, 0)
		Me.PicTestata.TabIndex = 20
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
		Me._imgTestata_5.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_5.Location = New System.Drawing.Point(224, 16)
		Me._imgTestata_5.Image = CType(resources.GetObject("_imgTestata_5.Image"), System.Drawing.Image)
		Me._imgTestata_5.Enabled = True
		Me._imgTestata_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_5.Visible = True
		Me._imgTestata_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_5.Name = "_imgTestata_5"
		Me.Label17.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label17.Text = "CTRL + F2 - Provincia"
		Me.Label17.Size = New System.Drawing.Size(65, 25)
		Me.Label17.Location = New System.Drawing.Point(224, 56)
		Me.Label17.TabIndex = 33
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
		Me._imgTestata_3.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_3.Location = New System.Drawing.Point(168, 16)
		Me._imgTestata_3.Image = CType(resources.GetObject("_imgTestata_3.Image"), System.Drawing.Image)
		Me._imgTestata_3.Enabled = True
		Me._imgTestata_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_3.Visible = True
		Me._imgTestata_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_3.Name = "_imgTestata_3"
		Me.Label16.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label16.Text = "F4 - CAP"
		Me.Label16.Size = New System.Drawing.Size(65, 17)
		Me.Label16.Location = New System.Drawing.Point(168, 56)
		Me.Label16.TabIndex = 32
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
		Me._imgTestata_9.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_9.Location = New System.Drawing.Point(544, 16)
		Me._imgTestata_9.Image = CType(resources.GetObject("_imgTestata_9.Image"), System.Drawing.Image)
		Me._imgTestata_9.Enabled = True
		Me._imgTestata_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_9.Visible = True
		Me._imgTestata_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_9.Name = "_imgTestata_9"
		Me.Label12.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label12.Text = "F9 - Aggiorna Saldo"
		Me.Label12.Size = New System.Drawing.Size(81, 33)
		Me.Label12.Location = New System.Drawing.Point(544, 56)
		Me.Label12.TabIndex = 28
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me._imgTestata_6.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_6.Location = New System.Drawing.Point(408, 16)
		Me._imgTestata_6.Image = CType(resources.GetObject("_imgTestata_6.Image"), System.Drawing.Image)
		Me._imgTestata_6.Enabled = True
		Me._imgTestata_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_6.Visible = True
		Me._imgTestata_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_6.Name = "_imgTestata_6"
		Me.Label15.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label15.Text = "F7 - Filiali"
		Me.Label15.Size = New System.Drawing.Size(65, 17)
		Me.Label15.Location = New System.Drawing.Point(408, 56)
		Me.Label15.TabIndex = 26
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
		Me.Label14.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label14.Text = "F12 - Torna al menù principale"
		Me.Label14.Size = New System.Drawing.Size(121, 25)
		Me.Label14.Location = New System.Drawing.Point(656, 56)
		Me.Label14.TabIndex = 25
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
		Me._imgTestata_8.Location = New System.Drawing.Point(656, 16)
		Me._imgTestata_8.Image = CType(resources.GetObject("_imgTestata_8.Image"), System.Drawing.Image)
		Me._imgTestata_8.Enabled = True
		Me._imgTestata_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_8.Visible = True
		Me._imgTestata_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_8.Name = "_imgTestata_8"
		Me.Label13.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label13.Text = "F8 - Titoli"
		Me.Label13.Size = New System.Drawing.Size(81, 17)
		Me.Label13.Location = New System.Drawing.Point(480, 56)
		Me.Label13.TabIndex = 24
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
		Me._imgTestata_7.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_7.Location = New System.Drawing.Point(480, 16)
		Me._imgTestata_7.Image = CType(resources.GetObject("_imgTestata_7.Image"), System.Drawing.Image)
		Me._imgTestata_7.Enabled = True
		Me._imgTestata_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_7.Visible = True
		Me._imgTestata_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_7.Name = "_imgTestata_7"
		Me.Label11.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label11.Text = "F5 - Conti"
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.Location = New System.Drawing.Point(296, 56)
		Me.Label11.TabIndex = 23
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
		Me._imgTestata_4.Location = New System.Drawing.Point(296, 16)
		Me._imgTestata_4.Image = CType(resources.GetObject("_imgTestata_4.Image"), System.Drawing.Image)
		Me._imgTestata_4.Enabled = True
		Me._imgTestata_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_4.Visible = True
		Me._imgTestata_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_4.Name = "_imgTestata_4"
		Me.Label9.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label9.Text = "F3 - Città"
		Me.Label9.Size = New System.Drawing.Size(65, 17)
		Me.Label9.Location = New System.Drawing.Point(104, 56)
		Me.Label9.TabIndex = 22
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me._imgTestata_2.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_2.Location = New System.Drawing.Point(104, 16)
		Me._imgTestata_2.Image = CType(resources.GetObject("_imgTestata_2.Image"), System.Drawing.Image)
		Me._imgTestata_2.Enabled = True
		Me._imgTestata_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_2.Visible = True
		Me._imgTestata_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_2.Name = "_imgTestata_2"
		Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label7.Text = "F2 - Causali"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 56)
		Me.Label7.TabIndex = 21
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me._imgTestata_1.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_1.Location = New System.Drawing.Point(8, 16)
		Me._imgTestata_1.Image = CType(resources.GetObject("_imgTestata_1.Image"), System.Drawing.Image)
		Me._imgTestata_1.Enabled = True
		Me._imgTestata_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_1.Visible = True
		Me._imgTestata_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_1.Name = "_imgTestata_1"
		Me.cmdModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdModifica.Text = "Modifica"
		Me.cmdModifica.Size = New System.Drawing.Size(121, 49)
		Me.cmdModifica.Location = New System.Drawing.Point(640, 280)
		Me.cmdModifica.Image = CType(resources.GetObject("cmdModifica.Image"), System.Drawing.Image)
		Me.cmdModifica.TabIndex = 19
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
		Me.cmdElimina.Size = New System.Drawing.Size(121, 49)
		Me.cmdElimina.Location = New System.Drawing.Point(496, 280)
		Me.cmdElimina.Image = CType(resources.GetObject("cmdElimina.Image"), System.Drawing.Image)
		Me.cmdElimina.TabIndex = 18
		Me.cmdElimina.BackColor = System.Drawing.SystemColors.Control
		Me.cmdElimina.CausesValidation = True
		Me.cmdElimina.Enabled = True
		Me.cmdElimina.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdElimina.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdElimina.TabStop = True
		Me.cmdElimina.Name = "cmdElimina"
		Me.cmdAggiungi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiungi.Text = "Aggiungi"
		Me.cmdAggiungi.Size = New System.Drawing.Size(121, 49)
		Me.cmdAggiungi.Location = New System.Drawing.Point(496, 224)
		Me.cmdAggiungi.Image = CType(resources.GetObject("cmdAggiungi.Image"), System.Drawing.Image)
		Me.cmdAggiungi.TabIndex = 17
		Me.cmdAggiungi.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiungi.CausesValidation = True
		Me.cmdAggiungi.Enabled = True
		Me.cmdAggiungi.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiungi.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiungi.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiungi.TabStop = True
		Me.cmdAggiungi.Name = "cmdAggiungi"
		Me.cmdPrimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrimo.Text = "Primo"
		Me.cmdPrimo.Size = New System.Drawing.Size(121, 57)
		Me.cmdPrimo.Location = New System.Drawing.Point(96, 472)
		Me.cmdPrimo.Image = CType(resources.GetObject("cmdPrimo.Image"), System.Drawing.Image)
		Me.cmdPrimo.TabIndex = 16
		Me.cmdPrimo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrimo.CausesValidation = True
		Me.cmdPrimo.Enabled = True
		Me.cmdPrimo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrimo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrimo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrimo.TabStop = True
		Me.cmdPrimo.Name = "cmdPrimo"
		Me.cmdPrecedente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrecedente.Text = "Precedente"
		Me.cmdPrecedente.Size = New System.Drawing.Size(121, 57)
		Me.cmdPrecedente.Location = New System.Drawing.Point(240, 472)
		Me.cmdPrecedente.Image = CType(resources.GetObject("cmdPrecedente.Image"), System.Drawing.Image)
		Me.cmdPrecedente.TabIndex = 15
		Me.cmdPrecedente.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrecedente.CausesValidation = True
		Me.cmdPrecedente.Enabled = True
		Me.cmdPrecedente.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrecedente.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrecedente.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrecedente.TabStop = True
		Me.cmdPrecedente.Name = "cmdPrecedente"
		Me.cmdSuccessivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSuccessivo.Text = "Successivo"
		Me.cmdSuccessivo.Size = New System.Drawing.Size(121, 57)
		Me.cmdSuccessivo.Location = New System.Drawing.Point(384, 472)
		Me.cmdSuccessivo.Image = CType(resources.GetObject("cmdSuccessivo.Image"), System.Drawing.Image)
		Me.cmdSuccessivo.TabIndex = 14
		Me.cmdSuccessivo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSuccessivo.CausesValidation = True
		Me.cmdSuccessivo.Enabled = True
		Me.cmdSuccessivo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSuccessivo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSuccessivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSuccessivo.TabStop = True
		Me.cmdSuccessivo.Name = "cmdSuccessivo"
		Me.cmdUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdUltimo.Text = "Ultimo"
		Me.cmdUltimo.Size = New System.Drawing.Size(121, 57)
		Me.cmdUltimo.Location = New System.Drawing.Point(528, 472)
		Me.cmdUltimo.Image = CType(resources.GetObject("cmdUltimo.Image"), System.Drawing.Image)
		Me.cmdUltimo.TabIndex = 13
		Me.cmdUltimo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUltimo.CausesValidation = True
		Me.cmdUltimo.Enabled = True
		Me.cmdUltimo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUltimo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUltimo.TabStop = True
		Me.cmdUltimo.Name = "cmdUltimo"
		Me.txtSegnoMovimento.AutoSize = False
		Me.txtSegnoMovimento.Size = New System.Drawing.Size(41, 19)
		Me.txtSegnoMovimento.Location = New System.Drawing.Point(248, 416)
		Me.txtSegnoMovimento.TabIndex = 12
		Me.txtSegnoMovimento.Text = " "
		Me.txtSegnoMovimento.AcceptsReturn = True
		Me.txtSegnoMovimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSegnoMovimento.BackColor = System.Drawing.SystemColors.Window
		Me.txtSegnoMovimento.CausesValidation = True
		Me.txtSegnoMovimento.Enabled = True
		Me.txtSegnoMovimento.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSegnoMovimento.HideSelection = True
		Me.txtSegnoMovimento.ReadOnly = False
		Me.txtSegnoMovimento.Maxlength = 0
		Me.txtSegnoMovimento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSegnoMovimento.MultiLine = False
		Me.txtSegnoMovimento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSegnoMovimento.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSegnoMovimento.TabStop = True
		Me.txtSegnoMovimento.Visible = True
		Me.txtSegnoMovimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSegnoMovimento.Name = "txtSegnoMovimento"
		Me.txtDataValuta.AutoSize = False
		Me.txtDataValuta.Size = New System.Drawing.Size(185, 19)
		Me.txtDataValuta.Location = New System.Drawing.Point(248, 384)
		Me.txtDataValuta.TabIndex = 10
		Me.txtDataValuta.Text = " "
		Me.txtDataValuta.AcceptsReturn = True
		Me.txtDataValuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDataValuta.BackColor = System.Drawing.SystemColors.Window
		Me.txtDataValuta.CausesValidation = True
		Me.txtDataValuta.Enabled = True
		Me.txtDataValuta.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDataValuta.HideSelection = True
		Me.txtDataValuta.ReadOnly = False
		Me.txtDataValuta.Maxlength = 0
		Me.txtDataValuta.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDataValuta.MultiLine = False
		Me.txtDataValuta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDataValuta.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDataValuta.TabStop = True
		Me.txtDataValuta.Visible = True
		Me.txtDataValuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDataValuta.Name = "txtDataValuta"
		Me.txtImporto.AutoSize = False
		Me.txtImporto.Size = New System.Drawing.Size(185, 19)
		Me.txtImporto.Location = New System.Drawing.Point(248, 352)
		Me.txtImporto.TabIndex = 8
		Me.txtImporto.Text = " "
		Me.txtImporto.AcceptsReturn = True
		Me.txtImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtImporto.BackColor = System.Drawing.SystemColors.Window
		Me.txtImporto.CausesValidation = True
		Me.txtImporto.Enabled = True
		Me.txtImporto.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtImporto.HideSelection = True
		Me.txtImporto.ReadOnly = False
		Me.txtImporto.Maxlength = 0
		Me.txtImporto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtImporto.MultiLine = False
		Me.txtImporto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtImporto.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtImporto.TabStop = True
		Me.txtImporto.Visible = True
		Me.txtImporto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtImporto.Name = "txtImporto"
		Me.txtDesMovimento.AutoSize = False
		Me.txtDesMovimento.Size = New System.Drawing.Size(185, 19)
		Me.txtDesMovimento.Location = New System.Drawing.Point(248, 320)
		Me.txtDesMovimento.TabIndex = 6
		Me.txtDesMovimento.Text = " "
		Me.txtDesMovimento.AcceptsReturn = True
		Me.txtDesMovimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDesMovimento.BackColor = System.Drawing.SystemColors.Window
		Me.txtDesMovimento.CausesValidation = True
		Me.txtDesMovimento.Enabled = True
		Me.txtDesMovimento.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDesMovimento.HideSelection = True
		Me.txtDesMovimento.ReadOnly = False
		Me.txtDesMovimento.Maxlength = 0
		Me.txtDesMovimento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDesMovimento.MultiLine = False
		Me.txtDesMovimento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDesMovimento.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDesMovimento.TabStop = True
		Me.txtDesMovimento.Visible = True
		Me.txtDesMovimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDesMovimento.Name = "txtDesMovimento"
		Me.txtDataMovimento.AutoSize = False
		Me.txtDataMovimento.Size = New System.Drawing.Size(177, 19)
		Me.txtDataMovimento.Location = New System.Drawing.Point(248, 288)
		Me.txtDataMovimento.TabIndex = 4
		Me.txtDataMovimento.Text = " "
		Me.txtDataMovimento.AcceptsReturn = True
		Me.txtDataMovimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDataMovimento.BackColor = System.Drawing.SystemColors.Window
		Me.txtDataMovimento.CausesValidation = True
		Me.txtDataMovimento.Enabled = True
		Me.txtDataMovimento.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDataMovimento.HideSelection = True
		Me.txtDataMovimento.ReadOnly = False
		Me.txtDataMovimento.Maxlength = 0
		Me.txtDataMovimento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDataMovimento.MultiLine = False
		Me.txtDataMovimento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDataMovimento.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDataMovimento.TabStop = True
		Me.txtDataMovimento.Visible = True
		Me.txtDataMovimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDataMovimento.Name = "txtDataMovimento"
		dtcCausale.OcxState = CType(resources.GetObject("dtcCausale.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtcCausale.Size = New System.Drawing.Size(177, 21)
		Me.dtcCausale.Location = New System.Drawing.Point(248, 256)
		Me.dtcCausale.TabIndex = 2
		Me.dtcCausale.Name = "dtcCausale"
		Me.Label10.Text = "ID.  CONTO"
		Me.Label10.Size = New System.Drawing.Size(145, 25)
		Me.Label10.Location = New System.Drawing.Point(96, 192)
		Me.Label10.TabIndex = 30
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label8.Text = "SEGNO"
		Me.Label8.Size = New System.Drawing.Size(145, 25)
		Me.Label8.Location = New System.Drawing.Point(96, 416)
		Me.Label8.TabIndex = 11
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label6.Text = "DATA VALUTA"
		Me.Label6.Size = New System.Drawing.Size(145, 25)
		Me.Label6.Location = New System.Drawing.Point(96, 384)
		Me.Label6.TabIndex = 9
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "IMPORTO"
		Me.Label5.Size = New System.Drawing.Size(145, 17)
		Me.Label5.Location = New System.Drawing.Point(96, 352)
		Me.Label5.TabIndex = 7
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "DESCRIZIONE MOVIMENTO"
		Me.Label4.Size = New System.Drawing.Size(145, 17)
		Me.Label4.Location = New System.Drawing.Point(96, 320)
		Me.Label4.TabIndex = 5
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "DATA MOVIMENTO"
		Me.Label3.Size = New System.Drawing.Size(145, 25)
		Me.Label3.Location = New System.Drawing.Point(96, 288)
		Me.Label3.TabIndex = 3
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "COD. CAUSALE"
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(96, 256)
		Me.Label2.TabIndex = 1
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "NUM. CONTO"
		Me.Label1.Size = New System.Drawing.Size(145, 25)
		Me.Label1.Location = New System.Drawing.Point(96, 224)
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
		Me._mnuFile_3.Text = "CAP"
		Me._mnuFile_3.Shortcut = System.Windows.Forms.Shortcut.F4
		Me._mnuFile_3.Checked = False
		Me._mnuFile_3.Enabled = True
		Me._mnuFile_3.Visible = True
		Me._mnuFile_3.MDIList = False
		Me._mnuFile_4.Text = "Provincie"
		Me._mnuFile_4.Shortcut = System.Windows.Forms.Shortcut.CtrlF2
		Me._mnuFile_4.Checked = False
		Me._mnuFile_4.Enabled = True
		Me._mnuFile_4.Visible = True
		Me._mnuFile_4.MDIList = False
		Me._mnuFile_5.Text = "Conti"
		Me._mnuFile_5.Shortcut = System.Windows.Forms.Shortcut.F5
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
		Me._mOperazioni_1.Text = "Operazioni"
		Me._mOperazioni_1.Checked = False
		Me._mOperazioni_1.Enabled = True
		Me._mOperazioni_1.Visible = True
		Me._mOperazioni_1.MDIList = False
		Me._mnuOperazioni_1.Text = "Aggiorna Saldo"
		Me._mnuOperazioni_1.Shortcut = System.Windows.Forms.Shortcut.F9
		Me._mnuOperazioni_1.Checked = False
		Me._mnuOperazioni_1.Enabled = True
		Me._mnuOperazioni_1.Visible = True
		Me._mnuOperazioni_1.MDIList = False
		Me.Controls.Add(txtIdConto)
		Me.Controls.Add(txtNumConto)
		Me.Controls.Add(cmdAggiornaSaldo)
		Me.Controls.Add(PicTestata)
		Me.Controls.Add(cmdModifica)
		Me.Controls.Add(cmdElimina)
		Me.Controls.Add(cmdAggiungi)
		Me.Controls.Add(cmdPrimo)
		Me.Controls.Add(cmdPrecedente)
		Me.Controls.Add(cmdSuccessivo)
		Me.Controls.Add(cmdUltimo)
		Me.Controls.Add(txtSegnoMovimento)
		Me.Controls.Add(txtDataValuta)
		Me.Controls.Add(txtImporto)
		Me.Controls.Add(txtDesMovimento)
		Me.Controls.Add(txtDataMovimento)
		Me.Controls.Add(dtcCausale)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.PicTestata.Controls.Add(_imgTestata_5)
		Me.PicTestata.Controls.Add(Label17)
		Me.PicTestata.Controls.Add(_imgTestata_3)
		Me.PicTestata.Controls.Add(Label16)
		Me.PicTestata.Controls.Add(_imgTestata_9)
		Me.PicTestata.Controls.Add(Label12)
		Me.PicTestata.Controls.Add(_imgTestata_6)
		Me.PicTestata.Controls.Add(Label15)
		Me.PicTestata.Controls.Add(Label14)
		Me.PicTestata.Controls.Add(_imgTestata_8)
		Me.PicTestata.Controls.Add(Label13)
		Me.PicTestata.Controls.Add(_imgTestata_7)
		Me.PicTestata.Controls.Add(Label11)
		Me.PicTestata.Controls.Add(_imgTestata_4)
		Me.PicTestata.Controls.Add(Label9)
		Me.PicTestata.Controls.Add(_imgTestata_2)
		Me.PicTestata.Controls.Add(Label7)
		Me.PicTestata.Controls.Add(_imgTestata_1)
		Me.imgTestata.SetIndex(_imgTestata_5, CType(5, Short))
		Me.imgTestata.SetIndex(_imgTestata_3, CType(3, Short))
		Me.imgTestata.SetIndex(_imgTestata_9, CType(9, Short))
		Me.imgTestata.SetIndex(_imgTestata_6, CType(6, Short))
		Me.imgTestata.SetIndex(_imgTestata_8, CType(8, Short))
		Me.imgTestata.SetIndex(_imgTestata_7, CType(7, Short))
		Me.imgTestata.SetIndex(_imgTestata_4, CType(4, Short))
		Me.imgTestata.SetIndex(_imgTestata_2, CType(2, Short))
		Me.imgTestata.SetIndex(_imgTestata_1, CType(1, Short))
		Me.mOperazioni.SetIndex(_mOperazioni_1, CType(1, Short))
		Me.mnuFile.SetIndex(_mnuFile_1, CType(1, Short))
		Me.mnuFile.SetIndex(_mnuFile_2, CType(2, Short))
		Me.mnuFile.SetIndex(_mnuFile_3, CType(3, Short))
		Me.mnuFile.SetIndex(_mnuFile_4, CType(4, Short))
		Me.mnuFile.SetIndex(_mnuFile_5, CType(5, Short))
		Me.mnuFile.SetIndex(_mnuFile_6, CType(6, Short))
		Me.mnuFile.SetIndex(_mnuFile_7, CType(7, Short))
		Me.mnuOperazioni.SetIndex(_mnuOperazioni_1, CType(1, Short))
		CType(Me.mnuOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.mOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtcCausale, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mFile.Index = 0
		Me._mOperazioni_1.Index = 1
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mFile, Me._mOperazioni_1})
		Me._mnuFile_1.Index = 0
		Me._mnuFile_2.Index = 1
		Me._mnuFile_3.Index = 2
		Me._mnuFile_4.Index = 3
		Me._mnuFile_5.Index = 4
		Me._mnuFile_6.Index = 5
		Me._mnuFile_7.Index = 6
		mFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuFile_1, Me._mnuFile_2, Me._mnuFile_3, Me._mnuFile_4, Me._mnuFile_5, Me._mnuFile_6, Me._mnuFile_7})
		Me._mnuOperazioni_1.Index = 0
		_mOperazioni_1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuOperazioni_1})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Supporto aggiornamento "
	Private Shared m_vb6FormDefInstance As frmMovimenti
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMovimenti
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMovimenti()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub cmdAggiornaSaldo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAggiornaSaldo.Click
		Dim sqlConto As String
		Dim recConto As New ADODB.Recordset
		sqlConto = "Select * from Conti where idConto = " & txtIdConto.Text
		
		recConto = New ADODB.Recordset
		
		recConto.Open(sqlConto, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recConto.EOF = False Then
			If txtSegnoMovimento.Text = "D" Then
				recConto.Fields!prog_dare.Value = recConto.Fields!prog_dare.Value + Val(txtImporto.Text)
				recConto.Fields!saldo.Value = recConto.Fields!prog_dare.Value - recConto.Fields!prog_avere.Value
			Else
				recConto.Fields!prog_avere.Value = recConto.Fields!prog_avere.Value + Val(txtImporto.Text)
				recConto.Fields!saldo.Value = recConto.Fields!prog_dare.Value - recConto.Fields!prog_avere.Value
			End If
			recConto.Update()
			MsgBox("Saldo aggiornato", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Operazione effettuata")
		Else
			MsgBox("Conto inesistente", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Operazione errata")
		End If
		
		recConto.Close()
		'UPGRADE_NOTE: È possibile che l'oggetto recConto non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		recConto = Nothing
		
	End Sub
	
	Private Sub cmdAggiungi_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAggiungi.Click
		deBanche.rsqryMovimenti2.AddNew()
		Call disabilita()
		
	End Sub
	
	Private Sub cmdPrecedente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrecedente.Click
		deBanche.rsqryMovimenti2.MovePrevious()
		If deBanche.rsqryMovimenti2.BOF Then
			deBanche.rsqryMovimenti2.MoveNext()
		End If
		
	End Sub
	
	Private Sub cmdPrimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrimo.Click
		deBanche.rsqryMovimenti2.MoveFirst()
		
	End Sub
	
	Private Sub cmdSuccessivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSuccessivo.Click
		deBanche.rsqryMovimenti2.MoveNext()
		If deBanche.rsqryMovimenti2.EOF Then
			deBanche.rsqryMovimenti2.MovePrevious()
		End If
		
	End Sub
	
	Private Sub cmdUltimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimo.Click
		deBanche.rsqryMovimenti2.MoveLast()
		
	End Sub
	Private Sub disabilita()
		
		cmdElimina.Enabled = False
		cmdModifica.Enabled = False
		cmdPrimo.Enabled = False
		cmdPrecedente.Enabled = False
		cmdSuccessivo.Enabled = False
		cmdUltimo.Enabled = False
		
		
	End Sub
	
	
	Private Sub abilita()
		cmdElimina.Enabled = True
		cmdModifica.Enabled = True
		cmdPrimo.Enabled = True
		cmdPrecedente.Enabled = True
		cmdSuccessivo.Enabled = True
		cmdUltimo.Enabled = True
		
	End Sub
	
	
	
	
	Private Sub imgTestata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTestata.Click
		Dim Index As Short = imgTestata.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmCap As frmCap
		Dim frmConti As frmConti
		Dim frmProvincia As frmProvincia
		Dim frmFiliali As frmFiliali
		Dim frmTitoli As frmTitoli
		Dim frmGestioneContiCorrenti As frmGestioneContiCorrenti
		Select Case Index
			Case Is = 1
				frmCausali = New frmCausali
				frmCausali.Show()
			Case Is = 2
				frmCitta = New frmCitta
				frmCitta.Show()
			Case Is = 3
				frmCap = New frmCap
				frmCap.Show()
				
			Case Is = 4
				frmConti = New frmConti
				frmConti.Show()
			Case Is = 5
				frmProvincia = New frmProvincia
				frmProvincia.Show()
				
			Case Is = 6
				frmFiliali = New frmFiliali
				frmFiliali.Show()
				
			Case Is = 7
				frmTitoli = New frmTitoli
				frmTitoli.Show()
			Case Is = 8
				Me.Close()
				frmGestioneContiCorrenti = New frmGestioneContiCorrenti
				frmGestioneContiCorrenti.Show()
			Case Is = 9
				Call cmdAggiornaSaldo_Click(cmdAggiornaSaldo, New System.EventArgs())
				
		End Select
		
	End Sub
	
	Public Sub mnuFile_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Popup
		mnuFile_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFile.Click
		Dim Index As Short = mnuFile.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmCap As frmCap
		Dim frmProvincia As frmProvincia
		Dim frmConti As frmConti
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
				frmCap = New frmCap
				frmCap.Show()
			Case Is = 4
				frmProvincia = New frmProvincia
				frmProvincia.Show()
				
			Case Is = 5
				frmConti = New frmConti
				frmConti.Show()
			Case Is = 6
				frmFiliali = New frmFiliali
				frmFiliali.Show()
			Case Is = 7
				frmTitoli = New frmTitoli
				frmTitoli.Show()
				
		End Select
		
	End Sub
	
	Public Sub mnuOperazioni_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOperazioni.Popup
		mnuOperazioni_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuOperazioni_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOperazioni.Click
		Dim Index As Short = mnuOperazioni.GetIndex(eventSender)
		Select Case Index
			Case Is = 1
				Call cmdAggiornaSaldo_Click(cmdAggiornaSaldo, New System.EventArgs())
		End Select
		
	End Sub
	
	Private Sub txtDesMovimento_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDesMovimento.Enter
		Dim recCausale As New ADODB.Recordset
		Dim data As Date
		
		Dim sqlCausale As String
		sqlCausale = "Select * from Causali where idCausale = " & dtcCausale.CtlText
		recCausale.Open(sqlCausale, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recCausale.EOF = False Then
			txtDesMovimento.Text = recCausale.Fields!desCausale.Value
			data = CDate(txtDataMovimento.Text)
            txtDataValuta.Text = data.Add(recCausale.Fields!giorniValuta.Value)
            txtSegnoMovimento.Text = recCausale.Fields!segnoCausale.Value
        Else
            MsgBox("Causale Inesistente!", MsgBoxStyle.Exclamation, "Causale Errata")
            Exit Sub
        End If
        recCausale.Close()
        'UPGRADE_NOTE: È possibile che l'oggetto recCausale non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
        recCausale = Nothing
		
		
		
		
	End Sub
	
	
	
	
	
	
	Private Sub txtNumConto_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNumConto.Enter
		Dim recNumConto As New ADODB.Recordset
		Dim sqlNumConto As String
		recNumConto = New ADODB.Recordset
		sqlNumConto = "Select * from Conti where idConto = " & txtIdConto.Text
		recNumConto.Open(sqlNumConto, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recNumConto.EOF = False Then
			txtNumConto.Text = recNumConto.Fields!numConto.Value
		End If
		recNumConto.Close()
		'UPGRADE_NOTE: È possibile che l'oggetto recNumConto non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		recNumConto = Nothing
		
	End Sub
	
	Private Sub txtSegnoMovimento_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSegnoMovimento.Enter
		Dim recSegnoMovimento As New ADODB.Recordset
		Dim sqlSegnoMovimento As String
		sqlSegnoMovimento = "Select * from Causali where idCausale = " & dtcCausale.CtlText
		recSegnoMovimento.Open(sqlSegnoMovimento, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recSegnoMovimento.EOF = False Then
			txtSegnoMovimento.Text = recSegnoMovimento.Fields!segnoCausale.Value
		Else
			MsgBox("Codice causale inesistente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Conto Errato")
			Exit Sub
		End If
		recSegnoMovimento.Close()
		'UPGRADE_NOTE: È possibile che l'oggetto recSegnoMovimento non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		recSegnoMovimento = Nothing
		
		Call abilita()
	End Sub
	Public Sub VB6_AddADODataBinding()
		deBanche.qryMovimenti2()
		ADOBind_qryMovimenti2 = New VB6.MBindingCollection()
		ADOBind_qryMovimenti2.DataSource = deBanche
		ADOBind_qryMovimenti2.DataMember = "qryMovimenti2"
		ADOBind_qryMovimenti2.Add(txtIdConto, "Text", "idConto", Nothing, "txtIdConto")
		ADOBind_qryMovimenti2.Add(txtNumConto, "Text", "numConto", Nothing, "txtNumConto")
		ADOBind_qryMovimenti2.Add(txtSegnoMovimento, "Text", "segnoMovimento", Nothing, "txtSegnoMovimento")
		ADOBind_qryMovimenti2.Add(txtDataValuta, "Text", "dataValuta", Nothing, "txtDataValuta")
		ADOBind_qryMovimenti2.Add(txtImporto, "Text", "importo", Nothing, "txtImporto")
		ADOBind_qryMovimenti2.Add(txtDesMovimento, "Text", "desMovimento", Nothing, "txtDesMovimento")
		ADOBind_qryMovimenti2.Add(txtDataMovimento, "Text", "dataMovimento", Nothing, "txtDataMovimento")
		ADOBind_qryMovimenti2.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_qryMovimenti2.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_qryMovimenti2.Clear()
		ADOBind_qryMovimenti2.Dispose()
		ADOBind_qryMovimenti2 = Nothing
	End Sub
End Class