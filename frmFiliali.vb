Option Strict Off
Option Explicit On
Friend Class frmFiliali
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
	Private ADOBind_qryFiliale As VB6.MBindingCollection
	Public WithEvents cmdModifica As System.Windows.Forms.Button
	Public WithEvents cmdElimina As System.Windows.Forms.Button
	Public WithEvents dtcCap As AxMSDataListLib.AxDataCombo
	Public WithEvents dtcCitta As AxMSDataListLib.AxDataCombo
	Public WithEvents _imgTestata_6 As System.Windows.Forms.PictureBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_3 As System.Windows.Forms.PictureBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_9 As System.Windows.Forms.PictureBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_8 As System.Windows.Forms.PictureBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_7 As System.Windows.Forms.PictureBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_5 As System.Windows.Forms.PictureBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_2 As System.Windows.Forms.PictureBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_1 As System.Windows.Forms.PictureBox
	Public WithEvents PicTestata As System.Windows.Forms.Panel
	Public WithEvents cmdUltimo As System.Windows.Forms.Button
	Public WithEvents cmdSuccessivo As System.Windows.Forms.Button
	Public WithEvents cmdPrecedente As System.Windows.Forms.Button
	Public WithEvents cmdPrimo As System.Windows.Forms.Button
	Public WithEvents cmdAggiungi As System.Windows.Forms.Button
	Public WithEvents txtIndirizzo As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents imgTestata As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents mnuFile As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents _mnuFile_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_2 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_3 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_4 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_5 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_6 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuFile_7 As System.Windows.Forms.MenuItem
	Public WithEvents mFile As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTA: la routine seguente è richiesta dalla progettazione Windows Form.
	'Può essere modificata utilizzando la finestra di progettazione Windows Form.
	'Non modificarla mediante l'editor di codice.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFiliali))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdModifica = New System.Windows.Forms.Button
		Me.cmdElimina = New System.Windows.Forms.Button
		Me.dtcCap = New AxMSDataListLib.AxDataCombo
		Me.dtcCitta = New AxMSDataListLib.AxDataCombo
		Me.PicTestata = New System.Windows.Forms.Panel
		Me._imgTestata_6 = New System.Windows.Forms.PictureBox
		Me.Label12 = New System.Windows.Forms.Label
		Me._imgTestata_3 = New System.Windows.Forms.PictureBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me._imgTestata_9 = New System.Windows.Forms.PictureBox
		Me.Label10 = New System.Windows.Forms.Label
		Me._imgTestata_8 = New System.Windows.Forms.PictureBox
		Me.Label9 = New System.Windows.Forms.Label
		Me._imgTestata_7 = New System.Windows.Forms.PictureBox
		Me.Label8 = New System.Windows.Forms.Label
		Me._imgTestata_5 = New System.Windows.Forms.PictureBox
		Me.Label7 = New System.Windows.Forms.Label
		Me._imgTestata_4 = New System.Windows.Forms.PictureBox
		Me.Label5 = New System.Windows.Forms.Label
		Me._imgTestata_2 = New System.Windows.Forms.PictureBox
		Me.Label4 = New System.Windows.Forms.Label
		Me._imgTestata_1 = New System.Windows.Forms.PictureBox
		Me.cmdUltimo = New System.Windows.Forms.Button
		Me.cmdSuccessivo = New System.Windows.Forms.Button
		Me.cmdPrecedente = New System.Windows.Forms.Button
		Me.cmdPrimo = New System.Windows.Forms.Button
		Me.cmdAggiungi = New System.Windows.Forms.Button
		Me.txtIndirizzo = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.imgTestata = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
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
		CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtcCitta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Gestione Filiali"
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
		Me.Name = "frmFiliali"
		Me.cmdModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdModifica.Text = "Modifica"
		Me.cmdModifica.Size = New System.Drawing.Size(145, 57)
		Me.cmdModifica.Location = New System.Drawing.Point(528, 384)
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
		Me.cmdElimina.Size = New System.Drawing.Size(145, 57)
		Me.cmdElimina.Location = New System.Drawing.Point(528, 312)
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
		dtcCap.OcxState = CType(resources.GetObject("dtcCap.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtcCap.Size = New System.Drawing.Size(153, 21)
		Me.dtcCap.Location = New System.Drawing.Point(280, 352)
		Me.dtcCap.TabIndex = 17
		Me.dtcCap.Name = "dtcCap"
		dtcCitta.OcxState = CType(resources.GetObject("dtcCitta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtcCitta.Size = New System.Drawing.Size(153, 21)
		Me.dtcCitta.Location = New System.Drawing.Point(280, 312)
		Me.dtcCitta.TabIndex = 16
		Me.dtcCitta.Name = "dtcCitta"
		Me.PicTestata.BackColor = System.Drawing.SystemColors.GrayText
		Me.PicTestata.Size = New System.Drawing.Size(793, 89)
		Me.PicTestata.Location = New System.Drawing.Point(0, 0)
		Me.PicTestata.TabIndex = 9
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
		Me._imgTestata_6.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_6.Location = New System.Drawing.Point(224, 16)
		Me._imgTestata_6.Image = CType(resources.GetObject("_imgTestata_6.Image"), System.Drawing.Image)
		Me._imgTestata_6.Enabled = True
		Me._imgTestata_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_6.Visible = True
		Me._imgTestata_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_6.Name = "_imgTestata_6"
		Me.Label12.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label12.Text = "CTRL + F2 Provincia"
		Me.Label12.Size = New System.Drawing.Size(65, 25)
		Me.Label12.Location = New System.Drawing.Point(216, 56)
		Me.Label12.TabIndex = 22
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
		Me._imgTestata_3.Location = New System.Drawing.Point(168, 16)
		Me._imgTestata_3.Image = CType(resources.GetObject("_imgTestata_3.Image"), System.Drawing.Image)
		Me._imgTestata_3.Enabled = True
		Me._imgTestata_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_3.Visible = True
		Me._imgTestata_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_3.Name = "_imgTestata_3"
		Me.Label6.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label6.Text = "F4 - CAP"
		Me.Label6.Size = New System.Drawing.Size(57, 17)
		Me.Label6.Location = New System.Drawing.Point(160, 56)
		Me.Label6.TabIndex = 21
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label11.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label11.Text = "F11  - Interrompi"
		Me.Label11.Size = New System.Drawing.Size(81, 17)
		Me.Label11.Location = New System.Drawing.Point(592, 56)
		Me.Label11.TabIndex = 20
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
		Me._imgTestata_9.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_9.Location = New System.Drawing.Point(600, 16)
		Me._imgTestata_9.Image = CType(resources.GetObject("_imgTestata_9.Image"), System.Drawing.Image)
		Me._imgTestata_9.Enabled = True
		Me._imgTestata_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_9.Visible = True
		Me._imgTestata_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_9.Name = "_imgTestata_9"
		Me.Label10.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label10.Text = "F12 - Torna al menù principale"
		Me.Label10.Size = New System.Drawing.Size(81, 25)
		Me.Label10.Location = New System.Drawing.Point(712, 56)
		Me.Label10.TabIndex = 15
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
		Me._imgTestata_8.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_8.Location = New System.Drawing.Point(712, 16)
		Me._imgTestata_8.Image = CType(resources.GetObject("_imgTestata_8.Image"), System.Drawing.Image)
		Me._imgTestata_8.Enabled = True
		Me._imgTestata_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_8.Visible = True
		Me._imgTestata_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_8.Name = "_imgTestata_8"
		Me.Label9.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label9.Text = "F8 - Titoli"
		Me.Label9.Size = New System.Drawing.Size(81, 17)
		Me.Label9.Location = New System.Drawing.Point(512, 56)
		Me.Label9.TabIndex = 14
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
		Me._imgTestata_7.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_7.Location = New System.Drawing.Point(512, 16)
		Me._imgTestata_7.Image = CType(resources.GetObject("_imgTestata_7.Image"), System.Drawing.Image)
		Me._imgTestata_7.Enabled = True
		Me._imgTestata_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_7.Visible = True
		Me._imgTestata_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_7.Name = "_imgTestata_7"
		Me.Label8.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label8.Text = "F6 - Movimenti"
		Me.Label8.Size = New System.Drawing.Size(81, 17)
		Me.Label8.Location = New System.Drawing.Point(416, 56)
		Me.Label8.TabIndex = 13
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me._imgTestata_5.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_5.Location = New System.Drawing.Point(416, 16)
		Me._imgTestata_5.Image = CType(resources.GetObject("_imgTestata_5.Image"), System.Drawing.Image)
		Me._imgTestata_5.Enabled = True
		Me._imgTestata_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_5.Visible = True
		Me._imgTestata_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_5.Name = "_imgTestata_5"
		Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label7.Text = "F5 - Conti"
		Me.Label7.Size = New System.Drawing.Size(65, 17)
		Me.Label7.Location = New System.Drawing.Point(296, 56)
		Me.Label7.TabIndex = 12
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
		Me._imgTestata_4.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_4.Location = New System.Drawing.Point(296, 16)
		Me._imgTestata_4.Image = CType(resources.GetObject("_imgTestata_4.Image"), System.Drawing.Image)
		Me._imgTestata_4.Enabled = True
		Me._imgTestata_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_4.Visible = True
		Me._imgTestata_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_4.Name = "_imgTestata_4"
		Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label5.Text = "F3 - Città"
		Me.Label5.Size = New System.Drawing.Size(65, 17)
		Me.Label5.Location = New System.Drawing.Point(104, 56)
		Me.Label5.TabIndex = 11
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me._imgTestata_2.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_2.Location = New System.Drawing.Point(104, 16)
		Me._imgTestata_2.Image = CType(resources.GetObject("_imgTestata_2.Image"), System.Drawing.Image)
		Me._imgTestata_2.Enabled = True
		Me._imgTestata_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_2.Visible = True
		Me._imgTestata_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_2.Name = "_imgTestata_2"
		Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
		Me.Label4.Text = "F2 - Causali"
		Me.Label4.Size = New System.Drawing.Size(65, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 56)
		Me.Label4.TabIndex = 10
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me._imgTestata_1.Size = New System.Drawing.Size(32, 32)
		Me._imgTestata_1.Location = New System.Drawing.Point(8, 16)
		Me._imgTestata_1.Image = CType(resources.GetObject("_imgTestata_1.Image"), System.Drawing.Image)
		Me._imgTestata_1.Enabled = True
		Me._imgTestata_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgTestata_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgTestata_1.Visible = True
		Me._imgTestata_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgTestata_1.Name = "_imgTestata_1"
		Me.cmdUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdUltimo.Text = "Ultimo"
		Me.cmdUltimo.Size = New System.Drawing.Size(145, 65)
		Me.cmdUltimo.Location = New System.Drawing.Point(528, 480)
		Me.cmdUltimo.Image = CType(resources.GetObject("cmdUltimo.Image"), System.Drawing.Image)
		Me.cmdUltimo.TabIndex = 8
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
		Me.cmdSuccessivo.Size = New System.Drawing.Size(145, 65)
		Me.cmdSuccessivo.Location = New System.Drawing.Point(360, 480)
		Me.cmdSuccessivo.Image = CType(resources.GetObject("cmdSuccessivo.Image"), System.Drawing.Image)
		Me.cmdSuccessivo.TabIndex = 7
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
		Me.cmdPrecedente.Size = New System.Drawing.Size(145, 65)
		Me.cmdPrecedente.Location = New System.Drawing.Point(192, 480)
		Me.cmdPrecedente.Image = CType(resources.GetObject("cmdPrecedente.Image"), System.Drawing.Image)
		Me.cmdPrecedente.TabIndex = 6
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
		Me.cmdPrimo.Size = New System.Drawing.Size(145, 65)
		Me.cmdPrimo.Location = New System.Drawing.Point(24, 480)
		Me.cmdPrimo.Image = CType(resources.GetObject("cmdPrimo.Image"), System.Drawing.Image)
		Me.cmdPrimo.TabIndex = 5
		Me.cmdPrimo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrimo.CausesValidation = True
		Me.cmdPrimo.Enabled = True
		Me.cmdPrimo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrimo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrimo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrimo.TabStop = True
		Me.cmdPrimo.Name = "cmdPrimo"
		Me.cmdAggiungi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAggiungi.Text = "Aggiungi"
		Me.cmdAggiungi.Size = New System.Drawing.Size(145, 57)
		Me.cmdAggiungi.Location = New System.Drawing.Point(528, 240)
		Me.cmdAggiungi.Image = CType(resources.GetObject("cmdAggiungi.Image"), System.Drawing.Image)
		Me.cmdAggiungi.TabIndex = 4
		Me.cmdAggiungi.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAggiungi.CausesValidation = True
		Me.cmdAggiungi.Enabled = True
		Me.cmdAggiungi.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAggiungi.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAggiungi.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAggiungi.TabStop = True
		Me.cmdAggiungi.Name = "cmdAggiungi"
		Me.txtIndirizzo.AutoSize = False
		Me.txtIndirizzo.Size = New System.Drawing.Size(153, 19)
		Me.txtIndirizzo.Location = New System.Drawing.Point(280, 272)
		Me.txtIndirizzo.TabIndex = 3
		Me.txtIndirizzo.Text = " "
		Me.txtIndirizzo.AcceptsReturn = True
		Me.txtIndirizzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIndirizzo.BackColor = System.Drawing.SystemColors.Window
		Me.txtIndirizzo.CausesValidation = True
		Me.txtIndirizzo.Enabled = True
		Me.txtIndirizzo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIndirizzo.HideSelection = True
		Me.txtIndirizzo.ReadOnly = False
		Me.txtIndirizzo.Maxlength = 0
		Me.txtIndirizzo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIndirizzo.MultiLine = False
		Me.txtIndirizzo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIndirizzo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIndirizzo.TabStop = True
		Me.txtIndirizzo.Visible = True
		Me.txtIndirizzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIndirizzo.Name = "txtIndirizzo"
		Me.Label3.Text = "CAP"
		Me.Label3.Size = New System.Drawing.Size(137, 25)
		Me.Label3.Location = New System.Drawing.Point(104, 352)
		Me.Label3.TabIndex = 2
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
		Me.Label2.Text = "CITTA"
		Me.Label2.Size = New System.Drawing.Size(137, 25)
		Me.Label2.Location = New System.Drawing.Point(104, 312)
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
		Me.Label1.Text = "INDIRIZZO"
		Me.Label1.Size = New System.Drawing.Size(137, 25)
		Me.Label1.Location = New System.Drawing.Point(104, 272)
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
		Me._mnuFile_7.Text = "Titoli"
		Me._mnuFile_7.Shortcut = System.Windows.Forms.Shortcut.F8
		Me._mnuFile_7.Checked = False
		Me._mnuFile_7.Enabled = True
		Me._mnuFile_7.Visible = True
		Me._mnuFile_7.MDIList = False
		Me.Controls.Add(cmdModifica)
		Me.Controls.Add(cmdElimina)
		Me.Controls.Add(dtcCap)
		Me.Controls.Add(dtcCitta)
		Me.Controls.Add(PicTestata)
		Me.Controls.Add(cmdUltimo)
		Me.Controls.Add(cmdSuccessivo)
		Me.Controls.Add(cmdPrecedente)
		Me.Controls.Add(cmdPrimo)
		Me.Controls.Add(cmdAggiungi)
		Me.Controls.Add(txtIndirizzo)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.PicTestata.Controls.Add(_imgTestata_6)
		Me.PicTestata.Controls.Add(Label12)
		Me.PicTestata.Controls.Add(_imgTestata_3)
		Me.PicTestata.Controls.Add(Label6)
		Me.PicTestata.Controls.Add(Label11)
		Me.PicTestata.Controls.Add(_imgTestata_9)
		Me.PicTestata.Controls.Add(Label10)
		Me.PicTestata.Controls.Add(_imgTestata_8)
		Me.PicTestata.Controls.Add(Label9)
		Me.PicTestata.Controls.Add(_imgTestata_7)
		Me.PicTestata.Controls.Add(Label8)
		Me.PicTestata.Controls.Add(_imgTestata_5)
		Me.PicTestata.Controls.Add(Label7)
		Me.PicTestata.Controls.Add(_imgTestata_4)
		Me.PicTestata.Controls.Add(Label5)
		Me.PicTestata.Controls.Add(_imgTestata_2)
		Me.PicTestata.Controls.Add(Label4)
		Me.PicTestata.Controls.Add(_imgTestata_1)
		Me.imgTestata.SetIndex(_imgTestata_6, CType(6, Short))
		Me.imgTestata.SetIndex(_imgTestata_3, CType(3, Short))
		Me.imgTestata.SetIndex(_imgTestata_9, CType(9, Short))
		Me.imgTestata.SetIndex(_imgTestata_8, CType(8, Short))
		Me.imgTestata.SetIndex(_imgTestata_7, CType(7, Short))
		Me.imgTestata.SetIndex(_imgTestata_5, CType(5, Short))
		Me.imgTestata.SetIndex(_imgTestata_4, CType(4, Short))
		Me.imgTestata.SetIndex(_imgTestata_2, CType(2, Short))
		Me.imgTestata.SetIndex(_imgTestata_1, CType(1, Short))
		Me.mnuFile.SetIndex(_mnuFile_1, CType(1, Short))
		Me.mnuFile.SetIndex(_mnuFile_2, CType(2, Short))
		Me.mnuFile.SetIndex(_mnuFile_3, CType(3, Short))
		Me.mnuFile.SetIndex(_mnuFile_4, CType(4, Short))
		Me.mnuFile.SetIndex(_mnuFile_5, CType(5, Short))
		Me.mnuFile.SetIndex(_mnuFile_6, CType(6, Short))
		Me.mnuFile.SetIndex(_mnuFile_7, CType(7, Short))
		CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtcCitta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mFile.Index = 0
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mFile})
		Me._mnuFile_1.Index = 0
		Me._mnuFile_2.Index = 1
		Me._mnuFile_3.Index = 2
		Me._mnuFile_4.Index = 3
		Me._mnuFile_5.Index = 4
		Me._mnuFile_6.Index = 5
		Me._mnuFile_7.Index = 6
		mFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuFile_1, Me._mnuFile_2, Me._mnuFile_3, Me._mnuFile_4, Me._mnuFile_5, Me._mnuFile_6, Me._mnuFile_7})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Supporto aggiornamento "
	Private Shared m_vb6FormDefInstance As frmFiliali
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmFiliali
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmFiliali()
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
		deBanche.rsqryFiliale.AddNew()
		Call disabilita()
		
	End Sub
	
	Private Sub cmdElimina_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdElimina.Click
		Dim risp As String
		risp = CStr(MsgBox("Il dato sarà eliminato definitivamente. Eliminare il record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione record"))
		If risp = CStr(MsgBoxResult.Yes) Then
			deBanche.rsqryFiliale.Delete(ADODB.AffectEnum.adAffectCurrent)
			deBanche.rsqryFiliale.MovePrevious()
		End If
		
	End Sub
	
	Private Sub cmdModifica_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModifica.Click
		deBanche.rsqryFiliale.Update()
		
	End Sub
	
	Private Sub cmdPrecedente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrecedente.Click
		deBanche.rsqryFiliale.MovePrevious()
		If deBanche.rsqryFiliale.BOF Then
			deBanche.rsqryFiliale.MoveNext()
		End If
		
	End Sub
	
	Private Sub cmdPrimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrimo.Click
		deBanche.rsqryFiliale.MoveFirst()
		
	End Sub
	
	Private Sub cmdSuccessivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSuccessivo.Click
		deBanche.rsqryFiliale.MoveNext()
		If deBanche.rsqryFiliale.EOF Then
			deBanche.rsqryFiliale.MovePrevious()
		End If
		
	End Sub
	
	Private Sub cmdUltimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimo.Click
		deBanche.rsqryFiliale.MoveLast()
		
	End Sub
	
	
	
	
	Private Sub dtcCap_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtcCap.Leave
		Call abilita()
		
	End Sub
	
	Private Sub imgTestata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTestata.Click
		Dim Index As Short = imgTestata.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmCap As frmCap
		Dim frmConti As frmConti
		Dim frmMovimenti As frmMovimenti
		Dim frmProvincia As frmProvincia
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
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 6
				frmProvincia = New frmProvincia
				frmProvincia.Show()
				
			Case Is = 7
				frmTitoli = New frmTitoli
				frmTitoli.Show()
			Case Is = 8
				Me.Close()
				frmGestioneContiCorrenti = New frmGestioneContiCorrenti
				frmGestioneContiCorrenti.Show()
			Case Is = 9
				Me.Close()
				End
				
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
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 7
				frmTitoli = New frmTitoli
				frmTitoli.Show()
		End Select
		
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
	Public Sub VB6_AddADODataBinding()
		deBanche.qryFiliale()
		ADOBind_qryFiliale = New VB6.MBindingCollection()
		ADOBind_qryFiliale.DataSource = deBanche
		ADOBind_qryFiliale.DataMember = "qryFiliale"
		ADOBind_qryFiliale.Add(txtIndirizzo, "Text", "indFiliale", Nothing, "txtIndirizzo")
		ADOBind_qryFiliale.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_qryFiliale.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_qryFiliale.Clear()
		ADOBind_qryFiliale.Dispose()
		ADOBind_qryFiliale = Nothing
	End Sub
End Class