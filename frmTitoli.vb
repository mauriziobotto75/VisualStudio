Option Strict Off
Option Explicit On
Friend Class frmTitoli
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
	Private ADOBind_qryTitoli As VB6.MBindingCollection
	Public WithEvents cmbTitolo As System.Windows.Forms.ComboBox
	Public WithEvents _imgTestata_9 As System.Windows.Forms.PictureBox
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_3 As System.Windows.Forms.PictureBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_7 As System.Windows.Forms.PictureBox
	Public WithEvents _imgTestata_6 As System.Windows.Forms.PictureBox
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_8 As System.Windows.Forms.PictureBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_5 As System.Windows.Forms.PictureBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_2 As System.Windows.Forms.PictureBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_1 As System.Windows.Forms.PictureBox
	Public WithEvents PicTestata As System.Windows.Forms.Panel
	Public WithEvents cmdAggiungi As System.Windows.Forms.Button
	Public WithEvents cmdElimina As System.Windows.Forms.Button
	Public WithEvents cmdAggiorna As System.Windows.Forms.Button
	Public WithEvents cmdUltimo As System.Windows.Forms.Button
	Public WithEvents cmdSuccessivo As System.Windows.Forms.Button
	Public WithEvents cmdPrecedente As System.Windows.Forms.Button
	Public WithEvents cmdPrimo As System.Windows.Forms.Button
	Public WithEvents dtcConto As AxMSDataListLib.AxDataCombo
	Public WithEvents txtValutaInteresse As System.Windows.Forms.TextBox
	Public WithEvents txtDataCedola2 As System.Windows.Forms.TextBox
	Public WithEvents txtDataCedola1 As System.Windows.Forms.TextBox
	Public WithEvents txtValoreCedola As System.Windows.Forms.TextBox
	Public WithEvents txtTassoInteresse As System.Windows.Forms.TextBox
	Public WithEvents txtValoreNominale As System.Windows.Forms.TextBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTitoli))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmbTitolo = New System.Windows.Forms.ComboBox
		Me.PicTestata = New System.Windows.Forms.Panel
		Me._imgTestata_9 = New System.Windows.Forms.PictureBox
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me._imgTestata_3 = New System.Windows.Forms.PictureBox
		Me.Label15 = New System.Windows.Forms.Label
		Me._imgTestata_7 = New System.Windows.Forms.PictureBox
		Me._imgTestata_6 = New System.Windows.Forms.PictureBox
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me._imgTestata_8 = New System.Windows.Forms.PictureBox
		Me.Label14 = New System.Windows.Forms.Label
		Me._imgTestata_5 = New System.Windows.Forms.PictureBox
		Me.Label13 = New System.Windows.Forms.Label
		Me._imgTestata_4 = New System.Windows.Forms.PictureBox
		Me.Label11 = New System.Windows.Forms.Label
		Me._imgTestata_2 = New System.Windows.Forms.PictureBox
		Me.Label10 = New System.Windows.Forms.Label
		Me._imgTestata_1 = New System.Windows.Forms.PictureBox
		Me.cmdAggiungi = New System.Windows.Forms.Button
		Me.cmdElimina = New System.Windows.Forms.Button
		Me.cmdAggiorna = New System.Windows.Forms.Button
		Me.cmdUltimo = New System.Windows.Forms.Button
		Me.cmdSuccessivo = New System.Windows.Forms.Button
		Me.cmdPrecedente = New System.Windows.Forms.Button
		Me.cmdPrimo = New System.Windows.Forms.Button
		Me.dtcConto = New AxMSDataListLib.AxDataCombo
		Me.txtValutaInteresse = New System.Windows.Forms.TextBox
		Me.txtDataCedola2 = New System.Windows.Forms.TextBox
		Me.txtDataCedola1 = New System.Windows.Forms.TextBox
		Me.txtValoreCedola = New System.Windows.Forms.TextBox
		Me.txtTassoInteresse = New System.Windows.Forms.TextBox
		Me.txtValoreNominale = New System.Windows.Forms.TextBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
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
		CType(Me.dtcConto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mEsci, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuEsci, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Gestione Titoli"
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
		Me.Name = "frmTitoli"
		Me.cmbTitolo.Size = New System.Drawing.Size(185, 21)
		Me.cmbTitolo.Location = New System.Drawing.Point(224, 184)
		Me.cmbTitolo.TabIndex = 29
		Me.cmbTitolo.Text = " "
		Me.cmbTitolo.BackColor = System.Drawing.SystemColors.Window
		Me.cmbTitolo.CausesValidation = True
		Me.cmbTitolo.Enabled = True
		Me.cmbTitolo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbTitolo.IntegralHeight = True
		Me.cmbTitolo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbTitolo.Sorted = False
		Me.cmbTitolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbTitolo.TabStop = True
		Me.cmbTitolo.Visible = True
		Me.cmbTitolo.Name = "cmbTitolo"
		Me.PicTestata.BackColor = System.Drawing.SystemColors.GrayText
		Me.PicTestata.Size = New System.Drawing.Size(793, 89)
		Me.PicTestata.Location = New System.Drawing.Point(0, 0)
		Me.PicTestata.TabIndex = 22
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
		Me._imgTestata_9.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_9.Location = New System.Drawing.Point(216, 16)
		Me._imgTestata_9.Image = CType(resources.GetObject("_imgTestata_9.Image"), System.Drawing.Image)
		Me._imgTestata_9.Enabled = True
		Me._imgTestata_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_9.Visible = True
		Me._imgTestata_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_9.Name = "_imgTestata_9"
		Me.Label18.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label18.Text = "CTRL + F2 - Provincia"
		Me.Label18.Size = New System.Drawing.Size(65, 33)
		Me.Label18.Location = New System.Drawing.Point(216, 56)
		Me.Label18.TabIndex = 32
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
		Me.Label12.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label12.Text = "F4 - CAP"
		Me.Label12.Size = New System.Drawing.Size(65, 17)
		Me.Label12.Location = New System.Drawing.Point(144, 56)
		Me.Label12.TabIndex = 31
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
		Me._imgTestata_3.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_3.Location = New System.Drawing.Point(144, 16)
		Me._imgTestata_3.Image = CType(resources.GetObject("_imgTestata_3.Image"), System.Drawing.Image)
		Me._imgTestata_3.Enabled = True
		Me._imgTestata_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_3.Visible = True
		Me._imgTestata_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_3.Name = "_imgTestata_3"
		Me.Label15.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label15.Text = "F9 - Interrompi"
		Me.Label15.Size = New System.Drawing.Size(73, 17)
		Me.Label15.Location = New System.Drawing.Point(552, 56)
		Me.Label15.TabIndex = 30
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
		Me._imgTestata_7.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_7.Location = New System.Drawing.Point(560, 16)
		Me._imgTestata_7.Image = CType(resources.GetObject("_imgTestata_7.Image"), System.Drawing.Image)
		Me._imgTestata_7.Enabled = True
		Me._imgTestata_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_7.Visible = True
		Me._imgTestata_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_7.Name = "_imgTestata_7"
		Me._imgTestata_6.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_6.Location = New System.Drawing.Point(464, 16)
		Me._imgTestata_6.Image = CType(resources.GetObject("_imgTestata_6.Image"), System.Drawing.Image)
		Me._imgTestata_6.Enabled = True
		Me._imgTestata_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_6.Visible = True
		Me._imgTestata_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_6.Name = "_imgTestata_6"
		Me.Label17.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label17.Text = "F7 - Filiali"
		Me.Label17.Size = New System.Drawing.Size(81, 17)
		Me.Label17.Location = New System.Drawing.Point(464, 56)
		Me.Label17.TabIndex = 28
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
		Me.Label16.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label16.Text = "F12 - Torna al menù principale"
		Me.Label16.Size = New System.Drawing.Size(129, 25)
		Me.Label16.Location = New System.Drawing.Point(656, 56)
		Me.Label16.TabIndex = 27
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
		Me._imgTestata_8.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_8.Location = New System.Drawing.Point(664, 16)
		Me._imgTestata_8.Image = CType(resources.GetObject("_imgTestata_8.Image"), System.Drawing.Image)
		Me._imgTestata_8.Enabled = True
		Me._imgTestata_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_8.Visible = True
		Me._imgTestata_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_8.Name = "_imgTestata_8"
		Me.Label14.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label14.Text = "F6 - Movimenti"
		Me.Label14.Size = New System.Drawing.Size(81, 17)
		Me.Label14.Location = New System.Drawing.Point(368, 56)
		Me.Label14.TabIndex = 26
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
		Me._imgTestata_5.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_5.Location = New System.Drawing.Point(368, 16)
		Me._imgTestata_5.Image = CType(resources.GetObject("_imgTestata_5.Image"), System.Drawing.Image)
		Me._imgTestata_5.Enabled = True
		Me._imgTestata_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_5.Visible = True
		Me._imgTestata_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_5.Name = "_imgTestata_5"
		Me.Label13.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label13.Text = "F5 - Conti"
		Me.Label13.Size = New System.Drawing.Size(65, 17)
		Me.Label13.Location = New System.Drawing.Point(296, 56)
		Me.Label13.TabIndex = 25
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
		Me._imgTestata_4.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_4.Location = New System.Drawing.Point(296, 16)
		Me._imgTestata_4.Image = CType(resources.GetObject("_imgTestata_4.Image"), System.Drawing.Image)
		Me._imgTestata_4.Enabled = True
		Me._imgTestata_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_4.Visible = True
		Me._imgTestata_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_4.Name = "_imgTestata_4"
		Me.Label11.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label11.Text = "F3 - Città"
		Me.Label11.Size = New System.Drawing.Size(49, 17)
		Me.Label11.Location = New System.Drawing.Point(88, 56)
		Me.Label11.TabIndex = 24
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
		Me._imgTestata_2.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_2.Location = New System.Drawing.Point(88, 16)
		Me._imgTestata_2.Image = CType(resources.GetObject("_imgTestata_2.Image"), System.Drawing.Image)
		Me._imgTestata_2.Enabled = True
		Me._imgTestata_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_2.Visible = True
		Me._imgTestata_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_2.Name = "_imgTestata_2"
		Me.Label10.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label10.Text = "F2 - Causali"
		Me.Label10.Size = New System.Drawing.Size(65, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 56)
		Me.Label10.TabIndex = 23
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
		Me._imgTestata_1.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_1.Location = New System.Drawing.Point(8, 16)
		Me._imgTestata_1.Image = CType(resources.GetObject("_imgTestata_1.Image"), System.Drawing.Image)
		Me._imgTestata_1.Enabled = True
		Me._imgTestata_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_1.Visible = True
		Me._imgTestata_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_1.Name = "_imgTestata_1"
		Me.cmdAggiungi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiungi.Text = "Aggiungi"
		Me.cmdAggiungi.Size = New System.Drawing.Size(121, 49)
		Me.cmdAggiungi.Location = New System.Drawing.Point(480, 216)
		Me.cmdAggiungi.Image = CType(resources.GetObject("cmdAggiungi.Image"), System.Drawing.Image)
		Me.cmdAggiungi.TabIndex = 21
		Me.cmdAggiungi.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiungi.CausesValidation = True
		Me.cmdAggiungi.Enabled = True
		Me.cmdAggiungi.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiungi.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiungi.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiungi.TabStop = True
		Me.cmdAggiungi.Name = "cmdAggiungi"
		Me.cmdElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdElimina.Text = "Elimina"
		Me.cmdElimina.Size = New System.Drawing.Size(121, 49)
		Me.cmdElimina.Location = New System.Drawing.Point(480, 280)
		Me.cmdElimina.Image = CType(resources.GetObject("cmdElimina.Image"), System.Drawing.Image)
		Me.cmdElimina.TabIndex = 20
		Me.cmdElimina.BackColor = System.Drawing.SystemColors.Control
		Me.cmdElimina.CausesValidation = True
		Me.cmdElimina.Enabled = True
		Me.cmdElimina.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdElimina.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdElimina.TabStop = True
		Me.cmdElimina.Name = "cmdElimina"
		Me.cmdAggiorna.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiorna.Text = "Aggiorna"
		Me.cmdAggiorna.Size = New System.Drawing.Size(121, 49)
		Me.cmdAggiorna.Location = New System.Drawing.Point(480, 344)
		Me.cmdAggiorna.Image = CType(resources.GetObject("cmdAggiorna.Image"), System.Drawing.Image)
		Me.cmdAggiorna.TabIndex = 19
		Me.cmdAggiorna.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiorna.CausesValidation = True
		Me.cmdAggiorna.Enabled = True
		Me.cmdAggiorna.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiorna.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiorna.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiorna.TabStop = True
		Me.cmdAggiorna.Name = "cmdAggiorna"
		Me.cmdUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdUltimo.Text = "Ultimo"
		Me.cmdUltimo.Size = New System.Drawing.Size(121, 57)
		Me.cmdUltimo.Location = New System.Drawing.Point(480, 480)
		Me.cmdUltimo.Image = CType(resources.GetObject("cmdUltimo.Image"), System.Drawing.Image)
		Me.cmdUltimo.TabIndex = 18
		Me.cmdUltimo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUltimo.CausesValidation = True
		Me.cmdUltimo.Enabled = True
		Me.cmdUltimo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUltimo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUltimo.TabStop = True
		Me.cmdUltimo.Name = "cmdUltimo"
		Me.cmdSuccessivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSuccessivo.Text = "Successivo"
		Me.cmdSuccessivo.Size = New System.Drawing.Size(121, 57)
		Me.cmdSuccessivo.Location = New System.Drawing.Point(344, 480)
		Me.cmdSuccessivo.Image = CType(resources.GetObject("cmdSuccessivo.Image"), System.Drawing.Image)
		Me.cmdSuccessivo.TabIndex = 17
		Me.cmdSuccessivo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSuccessivo.CausesValidation = True
		Me.cmdSuccessivo.Enabled = True
		Me.cmdSuccessivo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSuccessivo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSuccessivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSuccessivo.TabStop = True
		Me.cmdSuccessivo.Name = "cmdSuccessivo"
		Me.cmdPrecedente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrecedente.Text = "Precedente"
		Me.cmdPrecedente.Size = New System.Drawing.Size(121, 57)
		Me.cmdPrecedente.Location = New System.Drawing.Point(208, 480)
		Me.cmdPrecedente.Image = CType(resources.GetObject("cmdPrecedente.Image"), System.Drawing.Image)
		Me.cmdPrecedente.TabIndex = 16
		Me.cmdPrecedente.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrecedente.CausesValidation = True
		Me.cmdPrecedente.Enabled = True
		Me.cmdPrecedente.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrecedente.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrecedente.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrecedente.TabStop = True
		Me.cmdPrecedente.Name = "cmdPrecedente"
		Me.cmdPrimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdPrimo.Text = "Primo"
		Me.cmdPrimo.Size = New System.Drawing.Size(121, 57)
		Me.cmdPrimo.Location = New System.Drawing.Point(72, 480)
		Me.cmdPrimo.Image = CType(resources.GetObject("cmdPrimo.Image"), System.Drawing.Image)
		Me.cmdPrimo.TabIndex = 15
		Me.cmdPrimo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrimo.CausesValidation = True
		Me.cmdPrimo.Enabled = True
		Me.cmdPrimo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrimo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrimo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrimo.TabStop = True
		Me.cmdPrimo.Name = "cmdPrimo"
		dtcConto.OcxState = CType(resources.GetObject("dtcConto.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtcConto.Size = New System.Drawing.Size(185, 21)
		Me.dtcConto.Location = New System.Drawing.Point(224, 368)
		Me.dtcConto.TabIndex = 14
		Me.dtcConto.Name = "dtcConto"
		Me.txtValutaInteresse.AutoSize = False
		Me.txtValutaInteresse.Size = New System.Drawing.Size(185, 19)
		Me.txtValutaInteresse.Location = New System.Drawing.Point(224, 432)
		Me.txtValutaInteresse.TabIndex = 12
		Me.txtValutaInteresse.Text = " "
		Me.txtValutaInteresse.AcceptsReturn = True
		Me.txtValutaInteresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtValutaInteresse.BackColor = System.Drawing.SystemColors.Window
		Me.txtValutaInteresse.CausesValidation = True
		Me.txtValutaInteresse.Enabled = True
		Me.txtValutaInteresse.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtValutaInteresse.HideSelection = True
		Me.txtValutaInteresse.ReadOnly = False
		Me.txtValutaInteresse.Maxlength = 0
		Me.txtValutaInteresse.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtValutaInteresse.MultiLine = False
		Me.txtValutaInteresse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtValutaInteresse.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtValutaInteresse.TabStop = True
		Me.txtValutaInteresse.Visible = True
		Me.txtValutaInteresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtValutaInteresse.Name = "txtValutaInteresse"
		Me.txtDataCedola2.AutoSize = False
		Me.txtDataCedola2.Size = New System.Drawing.Size(185, 19)
		Me.txtDataCedola2.Location = New System.Drawing.Point(224, 344)
		Me.txtDataCedola2.TabIndex = 10
		Me.txtDataCedola2.Text = " "
		Me.txtDataCedola2.AcceptsReturn = True
		Me.txtDataCedola2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDataCedola2.BackColor = System.Drawing.SystemColors.Window
		Me.txtDataCedola2.CausesValidation = True
		Me.txtDataCedola2.Enabled = True
		Me.txtDataCedola2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDataCedola2.HideSelection = True
		Me.txtDataCedola2.ReadOnly = False
		Me.txtDataCedola2.Maxlength = 0
		Me.txtDataCedola2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDataCedola2.MultiLine = False
		Me.txtDataCedola2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDataCedola2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDataCedola2.TabStop = True
		Me.txtDataCedola2.Visible = True
		Me.txtDataCedola2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDataCedola2.Name = "txtDataCedola2"
		Me.txtDataCedola1.AutoSize = False
		Me.txtDataCedola1.Size = New System.Drawing.Size(185, 19)
		Me.txtDataCedola1.Location = New System.Drawing.Point(224, 312)
		Me.txtDataCedola1.TabIndex = 8
		Me.txtDataCedola1.Text = " "
		Me.txtDataCedola1.AcceptsReturn = True
		Me.txtDataCedola1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDataCedola1.BackColor = System.Drawing.SystemColors.Window
		Me.txtDataCedola1.CausesValidation = True
		Me.txtDataCedola1.Enabled = True
		Me.txtDataCedola1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDataCedola1.HideSelection = True
		Me.txtDataCedola1.ReadOnly = False
		Me.txtDataCedola1.Maxlength = 0
		Me.txtDataCedola1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDataCedola1.MultiLine = False
		Me.txtDataCedola1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDataCedola1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDataCedola1.TabStop = True
		Me.txtDataCedola1.Visible = True
		Me.txtDataCedola1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDataCedola1.Name = "txtDataCedola1"
		Me.txtValoreCedola.AutoSize = False
		Me.txtValoreCedola.Size = New System.Drawing.Size(185, 19)
		Me.txtValoreCedola.Location = New System.Drawing.Point(224, 280)
		Me.txtValoreCedola.TabIndex = 6
		Me.txtValoreCedola.Text = " "
		Me.txtValoreCedola.AcceptsReturn = True
		Me.txtValoreCedola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtValoreCedola.BackColor = System.Drawing.SystemColors.Window
		Me.txtValoreCedola.CausesValidation = True
		Me.txtValoreCedola.Enabled = True
		Me.txtValoreCedola.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtValoreCedola.HideSelection = True
		Me.txtValoreCedola.ReadOnly = False
		Me.txtValoreCedola.Maxlength = 0
		Me.txtValoreCedola.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtValoreCedola.MultiLine = False
		Me.txtValoreCedola.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtValoreCedola.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtValoreCedola.TabStop = True
		Me.txtValoreCedola.Visible = True
		Me.txtValoreCedola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtValoreCedola.Name = "txtValoreCedola"
		Me.txtTassoInteresse.AutoSize = False
		Me.txtTassoInteresse.Size = New System.Drawing.Size(185, 19)
		Me.txtTassoInteresse.Location = New System.Drawing.Point(224, 248)
		Me.txtTassoInteresse.TabIndex = 4
		Me.txtTassoInteresse.Text = " "
		Me.txtTassoInteresse.AcceptsReturn = True
		Me.txtTassoInteresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTassoInteresse.BackColor = System.Drawing.SystemColors.Window
		Me.txtTassoInteresse.CausesValidation = True
		Me.txtTassoInteresse.Enabled = True
		Me.txtTassoInteresse.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTassoInteresse.HideSelection = True
		Me.txtTassoInteresse.ReadOnly = False
		Me.txtTassoInteresse.Maxlength = 0
		Me.txtTassoInteresse.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTassoInteresse.MultiLine = False
		Me.txtTassoInteresse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTassoInteresse.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTassoInteresse.TabStop = True
		Me.txtTassoInteresse.Visible = True
		Me.txtTassoInteresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTassoInteresse.Name = "txtTassoInteresse"
		Me.txtValoreNominale.AutoSize = False
		Me.txtValoreNominale.Size = New System.Drawing.Size(185, 19)
		Me.txtValoreNominale.Location = New System.Drawing.Point(224, 216)
		Me.txtValoreNominale.TabIndex = 2
		Me.txtValoreNominale.Text = " "
		Me.txtValoreNominale.AcceptsReturn = True
		Me.txtValoreNominale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtValoreNominale.BackColor = System.Drawing.SystemColors.Window
		Me.txtValoreNominale.CausesValidation = True
		Me.txtValoreNominale.Enabled = True
		Me.txtValoreNominale.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtValoreNominale.HideSelection = True
		Me.txtValoreNominale.ReadOnly = False
		Me.txtValoreNominale.Maxlength = 0
		Me.txtValoreNominale.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtValoreNominale.MultiLine = False
		Me.txtValoreNominale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtValoreNominale.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtValoreNominale.TabStop = True
		Me.txtValoreNominale.Visible = True
		Me.txtValoreNominale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtValoreNominale.Name = "txtValoreNominale"
		Me.Label8.Text = "ID.  CONTO"
		Me.Label8.Size = New System.Drawing.Size(145, 17)
		Me.Label8.Location = New System.Drawing.Point(72, 376)
		Me.Label8.TabIndex = 13
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
		Me.Label7.Text = "VALUTA INTERESSE"
		Me.Label7.Size = New System.Drawing.Size(145, 17)
		Me.Label7.Location = New System.Drawing.Point(72, 432)
		Me.Label7.TabIndex = 11
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label6.Text = "DATA CEDOLA 2"
		Me.Label6.Size = New System.Drawing.Size(145, 17)
		Me.Label6.Location = New System.Drawing.Point(72, 344)
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
		Me.Label5.Text = "DATA CEDOLA 1"
		Me.Label5.Size = New System.Drawing.Size(137, 17)
		Me.Label5.Location = New System.Drawing.Point(72, 312)
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
		Me.Label4.Text = "VALORE CEDOLA"
		Me.Label4.Size = New System.Drawing.Size(137, 17)
		Me.Label4.Location = New System.Drawing.Point(72, 280)
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
		Me.Label3.Text = "TASSO INTERESSE"
		Me.Label3.Size = New System.Drawing.Size(137, 17)
		Me.Label3.Location = New System.Drawing.Point(72, 248)
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
		Me.Label2.Text = "VALORE NOMINALE"
		Me.Label2.Size = New System.Drawing.Size(137, 25)
		Me.Label2.Location = New System.Drawing.Point(72, 216)
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
		Me.Label1.Text = "NOME TITOLO"
		Me.Label1.Size = New System.Drawing.Size(137, 25)
		Me.Label1.Location = New System.Drawing.Point(72, 184)
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
		Me._mnuFile_4.Text = "Provincia"
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
		Me._mnuFile_6.Text = "Movimenti"
		Me._mnuFile_6.Shortcut = System.Windows.Forms.Shortcut.F6
		Me._mnuFile_6.Checked = False
		Me._mnuFile_6.Enabled = True
		Me._mnuFile_6.Visible = True
		Me._mnuFile_6.MDIList = False
		Me._mnuFile_7.Text = "Filiali"
		Me._mnuFile_7.Shortcut = System.Windows.Forms.Shortcut.F7
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
		Me._mnuEsci_2.Text = "Torna al menù principale "
		Me._mnuEsci_2.Shortcut = System.Windows.Forms.Shortcut.F12
		Me._mnuEsci_2.Checked = False
		Me._mnuEsci_2.Enabled = True
		Me._mnuEsci_2.Visible = True
		Me._mnuEsci_2.MDIList = False
		Me.Controls.Add(cmbTitolo)
		Me.Controls.Add(PicTestata)
		Me.Controls.Add(cmdAggiungi)
		Me.Controls.Add(cmdElimina)
		Me.Controls.Add(cmdAggiorna)
		Me.Controls.Add(cmdUltimo)
		Me.Controls.Add(cmdSuccessivo)
		Me.Controls.Add(cmdPrecedente)
		Me.Controls.Add(cmdPrimo)
		Me.Controls.Add(dtcConto)
		Me.Controls.Add(txtValutaInteresse)
		Me.Controls.Add(txtDataCedola2)
		Me.Controls.Add(txtDataCedola1)
		Me.Controls.Add(txtValoreCedola)
		Me.Controls.Add(txtTassoInteresse)
		Me.Controls.Add(txtValoreNominale)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.PicTestata.Controls.Add(_imgTestata_9)
		Me.PicTestata.Controls.Add(Label18)
		Me.PicTestata.Controls.Add(Label12)
		Me.PicTestata.Controls.Add(_imgTestata_3)
		Me.PicTestata.Controls.Add(Label15)
		Me.PicTestata.Controls.Add(_imgTestata_7)
		Me.PicTestata.Controls.Add(_imgTestata_6)
		Me.PicTestata.Controls.Add(Label17)
		Me.PicTestata.Controls.Add(Label16)
		Me.PicTestata.Controls.Add(_imgTestata_8)
		Me.PicTestata.Controls.Add(Label14)
		Me.PicTestata.Controls.Add(_imgTestata_5)
		Me.PicTestata.Controls.Add(Label13)
		Me.PicTestata.Controls.Add(_imgTestata_4)
		Me.PicTestata.Controls.Add(Label11)
		Me.PicTestata.Controls.Add(_imgTestata_2)
		Me.PicTestata.Controls.Add(Label10)
		Me.PicTestata.Controls.Add(_imgTestata_1)
		Me.imgTestata.SetIndex(_imgTestata_9, CType(9, Short))
		Me.imgTestata.SetIndex(_imgTestata_3, CType(3, Short))
		Me.imgTestata.SetIndex(_imgTestata_7, CType(7, Short))
		Me.imgTestata.SetIndex(_imgTestata_6, CType(6, Short))
		Me.imgTestata.SetIndex(_imgTestata_8, CType(8, Short))
		Me.imgTestata.SetIndex(_imgTestata_5, CType(5, Short))
		Me.imgTestata.SetIndex(_imgTestata_4, CType(4, Short))
		Me.imgTestata.SetIndex(_imgTestata_2, CType(2, Short))
		Me.imgTestata.SetIndex(_imgTestata_1, CType(1, Short))
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
		CType(Me.dtcConto, System.ComponentModel.ISupportInitialize).EndInit()
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
	Private Shared m_vb6FormDefInstance As frmTitoli
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmTitoli
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmTitoli()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub cmdAggiorna_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAggiorna.Click
		deBanche.rsqryTitoli.Update()
	End Sub
	Private Sub cmdAggiungi_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAggiungi.Click
		deBanche.rsqryTitoli.AddNew()
	End Sub
	
	Private Sub cmdElimina_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdElimina.Click
		Dim risp As Short
		risp = MsgBox("Il dato sarà eliminato definitivamente. Eliminare il dato?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Elimnazione dati")
		If risp = MsgBoxResult.Yes Then
			deBanche.rsqryTitoli.Delete(ADODB.AffectEnum.adAffectCurrent)
			deBanche.rsqryTitoli.MovePrevious()
		End If
		
	End Sub
	
	Private Sub cmdModifica_Click()
		deBanche.rsqryTitoli.Update()
		
	End Sub
	
	Private Sub cmdPrecedente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrecedente.Click
		deBanche.rsqryTitoli.MovePrevious()
		If deBanche.rsqryTitoli.BOF Then
			deBanche.rsqryTitoli.MoveNext()
		End If
		
	End Sub
	Private Sub cmdPrimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrimo.Click
		deBanche.rsqryTitoli.MoveFirst()
		
	End Sub
	Private Sub cmdSuccessivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSuccessivo.Click
		deBanche.rsqryTitoli.MoveNext()
		If deBanche.rsqryTitoli.EOF Then
			deBanche.rsqryTitoli.MovePrevious()
		End If
		
	End Sub
	Private Sub cmdUltimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimo.Click
		deBanche.rsqryTitoli.MoveLast()
		
	End Sub
	
	Private Sub frmTitoli_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cmbTitolo.Items.Add(("BOT 6  mesi"))
		cmbTitolo.Items.Add(("Bot 1  anno"))
		cmbTitolo.Items.Add(("CCT 3  anni"))
		cmbTitolo.Items.Add(("CCT 5  anni"))
		cmbTitolo.Items.Add(("CCT 7  anni"))
		cmbTitolo.Items.Add(("BTP 3  anni"))
		cmbTitolo.Items.Add(("BTP 5  anni"))
		cmbTitolo.Items.Add(("BTP 7  anni"))
		cmbTitolo.Text = deBanche.rsqryTitoli.Fields!nomeTitolo.Value
		
		
	End Sub
	
	Private Sub imgTestata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTestata.Click
		Dim Index As Short = imgTestata.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmCap As frmCap
		Dim frmConti As frmConti
		Dim frmMovimenti As frmMovimenti
		Dim frmFiliali As frmFiliali
		Dim frmGestioneContiCorrenti As frmGestioneContiCorrenti
		Dim frmProvincia As frmProvincia
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
		Dim frmCap As frmCap
		Dim frmProvincia As frmProvincia
		Dim frmConti As frmConti
		Dim frmMovimenti As frmMovimenti
		Dim frmFiliali As frmFiliali
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
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 7
				frmFiliali = New frmFiliali
				frmFiliali.Show()
				
				
				
				
				
				
				
		End Select
		
	End Sub
	
	Private Sub txtValoreCedola_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtValoreCedola.Enter
		txtValoreCedola.Text = CStr(Val(txtValoreNominale.Text) * Val(txtTassoInteresse.Text) * 6 \ 1200)
		txtValoreCedola.Text = CStr(Val(txtValoreCedola.Text))
		
	End Sub
	Private Sub txtValutaInteresse_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtValutaInteresse.Enter
		Dim txtIdCausale As Object
		Dim sqlValutaInteresse As String
		Dim recValutaInteresse As New ADODB.Recordset
		recValutaInteresse = New ADODB.Recordset
		'UPGRADE_WARNING: Impossibile risolvere la proprietà predefinita dell'oggetto txtIdCausale.Text. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		sqlValutaInteresse = "Select giorniValuta from Causali where idCausale = " & txtIdCausale.Text
		recValutaInteresse.Open(sqlValutaInteresse, deBanche.conBanche.ConnectionString, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		If recValutaInteresse.EOF = False Then
			If Today <= CDate(txtDataCedola1.Text) Then
				
                txtValutaInteresse.Text = CDate(txtDataCedola1.Text).Add(recValutaInteresse.Fields!giorniValuta.Value)

			ElseIf Today > CDate(txtDataCedola1.Text) And Today <= CDate(txtDataCedola2.Text) Then 
                txtValutaInteresse.Text = CDate(txtDataCedola2.Text).Add(recValutaInteresse.Fields!giorniValuta.Value)

			End If
		End If
		recValutaInteresse.Close()
		'UPGRADE_NOTE: È possibile che l'oggetto recValutaInteresse non venga eliminato finché non venga raccolto nel Garbage Collector. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		recValutaInteresse = Nothing
		
	End Sub
	Public Sub VB6_AddADODataBinding()
		deBanche.qryTitoli()
		ADOBind_qryTitoli = New VB6.MBindingCollection()
		ADOBind_qryTitoli.DataSource = deBanche
		ADOBind_qryTitoli.DataMember = "qryTitoli"
		ADOBind_qryTitoli.Add(txtValutaInteresse, "Text", "valutaInteresse", Nothing, "txtValutaInteresse")
		ADOBind_qryTitoli.Add(txtDataCedola2, "Text", "dataCedola2", Nothing, "txtDataCedola2")
		ADOBind_qryTitoli.Add(txtDataCedola1, "Text", "dataCedola1", Nothing, "txtDataCedola1")
		ADOBind_qryTitoli.Add(txtValoreCedola, "Text", "valoreCedola", Nothing, "txtValoreCedola")
		ADOBind_qryTitoli.Add(txtTassoInteresse, "Text", "intTitolo", Nothing, "txtTassoInteresse")
		ADOBind_qryTitoli.Add(txtValoreNominale, "Text", "valoreNominale", Nothing, "txtValoreNominale")
		'UPGRADE_WARNING: L'associazione dati per ComboBox cmbTitolo è in sola lettura. Fare clic qui per ulteriori informazioni: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup3065"'
		ADOBind_qryTitoli.Add(cmbTitolo, "Text", "nomeTitolo", Nothing, "cmbTitolo")
		ADOBind_qryTitoli.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_qryTitoli.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_qryTitoli.Clear()
		ADOBind_qryTitoli.Dispose()
		ADOBind_qryTitoli = Nothing
	End Sub
End Class