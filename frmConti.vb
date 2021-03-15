Option Strict Off
Option Explicit On
Friend Class frmConti
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
	Private ADOBind_qryConto As VB6.MBindingCollection
	Public WithEvents txtIndirizzo As System.Windows.Forms.TextBox
	Public WithEvents txtTelefono As System.Windows.Forms.TextBox
	Public WithEvents dtcCap As AxMSDataListLib.AxDataCombo
	Public WithEvents dtcProvincia As AxMSDataListLib.AxDataCombo
	Public WithEvents dtcCitta As AxMSDataListLib.AxDataCombo
	Public WithEvents txtCognome As System.Windows.Forms.TextBox
	Public WithEvents txtNomeCliente As System.Windows.Forms.TextBox
	Public WithEvents dtcFiliale As AxMSDataListLib.AxDataCombo
	Public WithEvents cmdPrimo As System.Windows.Forms.Button
	Public WithEvents cmdPrecedente As System.Windows.Forms.Button
	Public WithEvents cmdSuccessivo As System.Windows.Forms.Button
	Public WithEvents cmdUltimo As System.Windows.Forms.Button
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_4 As System.Windows.Forms.PictureBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_3 As System.Windows.Forms.PictureBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_10 As System.Windows.Forms.PictureBox
	Public WithEvents _imgTestata_1 As System.Windows.Forms.PictureBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_2 As System.Windows.Forms.PictureBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_5 As System.Windows.Forms.PictureBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_7 As System.Windows.Forms.PictureBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_8 As System.Windows.Forms.PictureBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents _imgTestata_6 As System.Windows.Forms.PictureBox
	Public WithEvents _imgTestata_9 As System.Windows.Forms.PictureBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents PicTestata As System.Windows.Forms.Panel
	Public WithEvents cmdModifica As System.Windows.Forms.Button
	Public WithEvents cmdElimina As System.Windows.Forms.Button
	Public WithEvents cmdAggiungi As System.Windows.Forms.Button
	Public WithEvents txtProg_Avere As System.Windows.Forms.TextBox
	Public WithEvents txtProg_Dare As System.Windows.Forms.TextBox
	Public WithEvents txtSaldoConto As System.Windows.Forms.TextBox
	Public WithEvents txtTasAttivo As System.Windows.Forms.TextBox
	Public WithEvents txtTasPassivo As System.Windows.Forms.TextBox
	Public WithEvents txtNumeroConto As System.Windows.Forms.TextBox
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
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
	Public WithEvents _mnuFile_8 As System.Windows.Forms.MenuItem
	Public WithEvents mFile As System.Windows.Forms.MenuItem
	Public WithEvents _mnuEsci_1 As System.Windows.Forms.MenuItem
	Public WithEvents _mnuEsci_2 As System.Windows.Forms.MenuItem
	Public WithEvents _mEsci_0 As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTA: la routine seguente è richiesta dalla progettazione Windows Form.
	'Può essere modificata utilizzando la finestra di progettazione Windows Form.
	'Non modificarla mediante l'editor di codice.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConti))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._imgTestata_1 = New System.Windows.Forms.PictureBox
        Me._imgTestata_2 = New System.Windows.Forms.PictureBox
        Me._imgTestata_5 = New System.Windows.Forms.PictureBox
        Me._imgTestata_7 = New System.Windows.Forms.PictureBox
        Me._imgTestata_8 = New System.Windows.Forms.PictureBox
        Me._imgTestata_6 = New System.Windows.Forms.PictureBox
        Me._imgTestata_9 = New System.Windows.Forms.PictureBox
        Me.txtIndirizzo = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.dtcCap = New AxMSDataListLib.AxDataCombo
        Me.dtcProvincia = New AxMSDataListLib.AxDataCombo
        Me.dtcCitta = New AxMSDataListLib.AxDataCombo
        Me.txtCognome = New System.Windows.Forms.TextBox
        Me.txtNomeCliente = New System.Windows.Forms.TextBox
        Me.dtcFiliale = New AxMSDataListLib.AxDataCombo
        Me.cmdPrimo = New System.Windows.Forms.Button
        Me.cmdPrecedente = New System.Windows.Forms.Button
        Me.cmdSuccessivo = New System.Windows.Forms.Button
        Me.cmdUltimo = New System.Windows.Forms.Button
        Me.PicTestata = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me._imgTestata_4 = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me._imgTestata_3 = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me._imgTestata_10 = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdModifica = New System.Windows.Forms.Button
        Me.cmdElimina = New System.Windows.Forms.Button
        Me.cmdAggiungi = New System.Windows.Forms.Button
        Me.txtProg_Avere = New System.Windows.Forms.TextBox
        Me.txtProg_Dare = New System.Windows.Forms.TextBox
        Me.txtSaldoConto = New System.Windows.Forms.TextBox
        Me.txtTasAttivo = New System.Windows.Forms.TextBox
        Me.txtTasPassivo = New System.Windows.Forms.TextBox
        Me.txtNumeroConto = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.imgTestata = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.mEsci = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(Me.components)
        Me._mEsci_0 = New System.Windows.Forms.MenuItem
        Me._mnuEsci_1 = New System.Windows.Forms.MenuItem
        Me._mnuEsci_2 = New System.Windows.Forms.MenuItem
        Me.mnuEsci = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(Me.components)
        Me.mnuFile = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(Me.components)
        Me._mnuFile_1 = New System.Windows.Forms.MenuItem
        Me._mnuFile_2 = New System.Windows.Forms.MenuItem
        Me._mnuFile_3 = New System.Windows.Forms.MenuItem
        Me._mnuFile_4 = New System.Windows.Forms.MenuItem
        Me._mnuFile_5 = New System.Windows.Forms.MenuItem
        Me._mnuFile_6 = New System.Windows.Forms.MenuItem
        Me._mnuFile_7 = New System.Windows.Forms.MenuItem
        Me._mnuFile_8 = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mFile = New System.Windows.Forms.MenuItem
        CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtcProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtcCitta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtcFiliale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicTestata.SuspendLayout()
        CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mEsci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuEsci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_imgTestata_1
        '
        Me._imgTestata_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_1.Image = CType(resources.GetObject("_imgTestata_1.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_1, CType(1, Short))
        Me._imgTestata_1.Location = New System.Drawing.Point(16, 16)
        Me._imgTestata_1.Name = "_imgTestata_1"
        Me._imgTestata_1.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_1.TabIndex = 49
        Me._imgTestata_1.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_1, "Gestione Causali")
        '
        '_imgTestata_2
        '
        Me._imgTestata_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_2.Image = CType(resources.GetObject("_imgTestata_2.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_2, CType(2, Short))
        Me._imgTestata_2.Location = New System.Drawing.Point(88, 16)
        Me._imgTestata_2.Name = "_imgTestata_2"
        Me._imgTestata_2.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_2.TabIndex = 50
        Me._imgTestata_2.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_2, "Gestione Città")
        '
        '_imgTestata_5
        '
        Me._imgTestata_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_5.Image = CType(resources.GetObject("_imgTestata_5.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_5, CType(5, Short))
        Me._imgTestata_5.Location = New System.Drawing.Point(360, 16)
        Me._imgTestata_5.Name = "_imgTestata_5"
        Me._imgTestata_5.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_5.TabIndex = 51
        Me._imgTestata_5.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_5, "Gestione Movimenti")
        '
        '_imgTestata_7
        '
        Me._imgTestata_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_7.Image = CType(resources.GetObject("_imgTestata_7.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_7, CType(7, Short))
        Me._imgTestata_7.Location = New System.Drawing.Point(528, 16)
        Me._imgTestata_7.Name = "_imgTestata_7"
        Me._imgTestata_7.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_7.TabIndex = 52
        Me._imgTestata_7.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_7, "Gestione Titoli")
        '
        '_imgTestata_8
        '
        Me._imgTestata_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_8.Image = CType(resources.GetObject("_imgTestata_8.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_8, CType(8, Short))
        Me._imgTestata_8.Location = New System.Drawing.Point(712, 16)
        Me._imgTestata_8.Name = "_imgTestata_8"
        Me._imgTestata_8.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_8.TabIndex = 53
        Me._imgTestata_8.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_8, "Torna al menù principale")
        '
        '_imgTestata_6
        '
        Me._imgTestata_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_6.Image = CType(resources.GetObject("_imgTestata_6.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_6, CType(6, Short))
        Me._imgTestata_6.Location = New System.Drawing.Point(440, 16)
        Me._imgTestata_6.Name = "_imgTestata_6"
        Me._imgTestata_6.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_6.TabIndex = 54
        Me._imgTestata_6.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_6, "Gestione Filiali")
        '
        '_imgTestata_9
        '
        Me._imgTestata_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_9.Image = CType(resources.GetObject("_imgTestata_9.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_9, CType(9, Short))
        Me._imgTestata_9.Location = New System.Drawing.Point(616, 16)
        Me._imgTestata_9.Name = "_imgTestata_9"
        Me._imgTestata_9.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_9.TabIndex = 55
        Me._imgTestata_9.TabStop = False
        Me.ToolTip1.SetToolTip(Me._imgTestata_9, "Interrompe il programma")
        '
        'txtIndirizzo
        '
        Me.txtIndirizzo.AcceptsReturn = True
        Me.txtIndirizzo.AutoSize = False
        Me.txtIndirizzo.BackColor = System.Drawing.SystemColors.Window
        Me.txtIndirizzo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIndirizzo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIndirizzo.Location = New System.Drawing.Point(496, 384)
        Me.txtIndirizzo.MaxLength = 0
        Me.txtIndirizzo.Name = "txtIndirizzo"
        Me.txtIndirizzo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIndirizzo.Size = New System.Drawing.Size(145, 19)
        Me.txtIndirizzo.TabIndex = 43
        Me.txtIndirizzo.Text = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.AcceptsReturn = True
        Me.txtTelefono.AutoSize = False
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono.Location = New System.Drawing.Point(496, 344)
        Me.txtTelefono.MaxLength = 0
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelefono.Size = New System.Drawing.Size(145, 19)
        Me.txtTelefono.TabIndex = 42
        Me.txtTelefono.Text = ""
        '
        'dtcCap
        '
        Me.dtcCap.Location = New System.Drawing.Point(496, 304)
        Me.dtcCap.Name = "dtcCap"
        Me.dtcCap.OcxState = CType(resources.GetObject("dtcCap.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtcCap.RowSource = Nothing
        Me.dtcCap.Size = New System.Drawing.Size(145, 21)
        Me.dtcCap.TabIndex = 41
        '
        'dtcProvincia
        '
        Me.dtcProvincia.Location = New System.Drawing.Point(496, 264)
        Me.dtcProvincia.Name = "dtcProvincia"
        Me.dtcProvincia.OcxState = CType(resources.GetObject("dtcProvincia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtcProvincia.RowSource = Nothing
        Me.dtcProvincia.Size = New System.Drawing.Size(145, 21)
        Me.dtcProvincia.TabIndex = 40
        '
        'dtcCitta
        '
        Me.dtcCitta.Location = New System.Drawing.Point(496, 224)
        Me.dtcCitta.Name = "dtcCitta"
        Me.dtcCitta.OcxState = CType(resources.GetObject("dtcCitta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtcCitta.RowSource = Nothing
        Me.dtcCitta.Size = New System.Drawing.Size(145, 21)
        Me.dtcCitta.TabIndex = 39
        '
        'txtCognome
        '
        Me.txtCognome.AcceptsReturn = True
        Me.txtCognome.AutoSize = False
        Me.txtCognome.BackColor = System.Drawing.SystemColors.Window
        Me.txtCognome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCognome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCognome.Location = New System.Drawing.Point(496, 184)
        Me.txtCognome.MaxLength = 0
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCognome.Size = New System.Drawing.Size(145, 19)
        Me.txtCognome.TabIndex = 38
        Me.txtCognome.Text = ""
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.AcceptsReturn = True
        Me.txtNomeCliente.AutoSize = False
        Me.txtNomeCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNomeCliente.Location = New System.Drawing.Point(496, 144)
        Me.txtNomeCliente.MaxLength = 0
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNomeCliente.Size = New System.Drawing.Size(145, 19)
        Me.txtNomeCliente.TabIndex = 37
        Me.txtNomeCliente.Text = ""
        '
        'dtcFiliale
        '
        Me.dtcFiliale.Location = New System.Drawing.Point(192, 184)
        Me.dtcFiliale.Name = "dtcFiliale"
        Me.dtcFiliale.OcxState = CType(resources.GetObject("dtcFiliale.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtcFiliale.RowSource = Nothing
        Me.dtcFiliale.Size = New System.Drawing.Size(169, 21)
        Me.dtcFiliale.TabIndex = 29
        '
        'cmdPrimo
        '
        Me.cmdPrimo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrimo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrimo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrimo.Image = CType(resources.GetObject("cmdPrimo.Image"), System.Drawing.Image)
        Me.cmdPrimo.Location = New System.Drawing.Point(8, 456)
        Me.cmdPrimo.Name = "cmdPrimo"
        Me.cmdPrimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrimo.Size = New System.Drawing.Size(121, 57)
        Me.cmdPrimo.TabIndex = 27
        Me.cmdPrimo.Text = "Primo"
        Me.cmdPrimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdPrecedente
        '
        Me.cmdPrecedente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrecedente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrecedente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrecedente.Image = CType(resources.GetObject("cmdPrecedente.Image"), System.Drawing.Image)
        Me.cmdPrecedente.Location = New System.Drawing.Point(152, 456)
        Me.cmdPrecedente.Name = "cmdPrecedente"
        Me.cmdPrecedente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrecedente.Size = New System.Drawing.Size(121, 57)
        Me.cmdPrecedente.TabIndex = 26
        Me.cmdPrecedente.Text = "Precedente"
        Me.cmdPrecedente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdSuccessivo
        '
        Me.cmdSuccessivo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSuccessivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSuccessivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSuccessivo.Image = CType(resources.GetObject("cmdSuccessivo.Image"), System.Drawing.Image)
        Me.cmdSuccessivo.Location = New System.Drawing.Point(296, 456)
        Me.cmdSuccessivo.Name = "cmdSuccessivo"
        Me.cmdSuccessivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSuccessivo.Size = New System.Drawing.Size(121, 57)
        Me.cmdSuccessivo.TabIndex = 25
        Me.cmdSuccessivo.Text = "Successivo"
        Me.cmdSuccessivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdUltimo
        '
        Me.cmdUltimo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUltimo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUltimo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUltimo.Image = CType(resources.GetObject("cmdUltimo.Image"), System.Drawing.Image)
        Me.cmdUltimo.Location = New System.Drawing.Point(440, 456)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUltimo.Size = New System.Drawing.Size(121, 57)
        Me.cmdUltimo.TabIndex = 24
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PicTestata
        '
        Me.PicTestata.BackColor = System.Drawing.SystemColors.GrayText
        Me.PicTestata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicTestata.Controls.Add(Me.Label24)
        Me.PicTestata.Controls.Add(Me._imgTestata_4)
        Me.PicTestata.Controls.Add(Me.Label14)
        Me.PicTestata.Controls.Add(Me._imgTestata_3)
        Me.PicTestata.Controls.Add(Me.Label16)
        Me.PicTestata.Controls.Add(Me._imgTestata_10)
        Me.PicTestata.Controls.Add(Me._imgTestata_1)
        Me.PicTestata.Controls.Add(Me.Label13)
        Me.PicTestata.Controls.Add(Me._imgTestata_2)
        Me.PicTestata.Controls.Add(Me.Label15)
        Me.PicTestata.Controls.Add(Me._imgTestata_5)
        Me.PicTestata.Controls.Add(Me.Label12)
        Me.PicTestata.Controls.Add(Me._imgTestata_7)
        Me.PicTestata.Controls.Add(Me.Label9)
        Me.PicTestata.Controls.Add(Me._imgTestata_8)
        Me.PicTestata.Controls.Add(Me.Label10)
        Me.PicTestata.Controls.Add(Me.Label11)
        Me.PicTestata.Controls.Add(Me._imgTestata_6)
        Me.PicTestata.Controls.Add(Me._imgTestata_9)
        Me.PicTestata.Controls.Add(Me.Label8)
        Me.PicTestata.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicTestata.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicTestata.Location = New System.Drawing.Point(0, 0)
        Me.PicTestata.Name = "PicTestata"
        Me.PicTestata.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicTestata.Size = New System.Drawing.Size(793, 89)
        Me.PicTestata.TabIndex = 15
        Me.PicTestata.TabStop = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(208, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(65, 33)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "CTRL + F2  - Provincia"
        '
        '_imgTestata_4
        '
        Me._imgTestata_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_4.Image = CType(resources.GetObject("_imgTestata_4.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_4, CType(4, Short))
        Me._imgTestata_4.Location = New System.Drawing.Point(208, 16)
        Me._imgTestata_4.Name = "_imgTestata_4"
        Me._imgTestata_4.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_4.TabIndex = 46
        Me._imgTestata_4.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(152, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(49, 17)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "F4 - CAP"
        '
        '_imgTestata_3
        '
        Me._imgTestata_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_3.Image = CType(resources.GetObject("_imgTestata_3.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_3, CType(3, Short))
        Me._imgTestata_3.Location = New System.Drawing.Point(152, 16)
        Me._imgTestata_3.Name = "_imgTestata_3"
        Me._imgTestata_3.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_3.TabIndex = 47
        Me._imgTestata_3.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(280, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(81, 33)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "CTRL + F1 Estratto Conto"
        '
        '_imgTestata_10
        '
        Me._imgTestata_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._imgTestata_10.Image = CType(resources.GetObject("_imgTestata_10.Image"), System.Drawing.Image)
        Me.imgTestata.SetIndex(Me._imgTestata_10, CType(10, Short))
        Me._imgTestata_10.Location = New System.Drawing.Point(280, 16)
        Me._imgTestata_10.Name = "_imgTestata_10"
        Me._imgTestata_10.Size = New System.Drawing.Size(32, 32)
        Me._imgTestata_10.TabIndex = 48
        Me._imgTestata_10.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(16, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "F2 - Causali"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(88, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(65, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "F3 - Città"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(360, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "F6 - Movimenti"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(528, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "F8 - Titoli"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(712, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "F12 - Torna al menù prinicpale"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(440, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "F7 - Filiali"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(600, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "F11  - Interrompi"
        '
        'cmdModifica
        '
        Me.cmdModifica.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModifica.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModifica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModifica.Image = CType(resources.GetObject("cmdModifica.Image"), System.Drawing.Image)
        Me.cmdModifica.Location = New System.Drawing.Point(664, 360)
        Me.cmdModifica.Name = "cmdModifica"
        Me.cmdModifica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModifica.Size = New System.Drawing.Size(121, 57)
        Me.cmdModifica.TabIndex = 9
        Me.cmdModifica.Text = "Modifica"
        Me.cmdModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdElimina
        '
        Me.cmdElimina.BackColor = System.Drawing.SystemColors.Control
        Me.cmdElimina.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdElimina.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdElimina.Image = CType(resources.GetObject("cmdElimina.Image"), System.Drawing.Image)
        Me.cmdElimina.Location = New System.Drawing.Point(664, 280)
        Me.cmdElimina.Name = "cmdElimina"
        Me.cmdElimina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdElimina.Size = New System.Drawing.Size(121, 57)
        Me.cmdElimina.TabIndex = 8
        Me.cmdElimina.Text = "Elimina"
        Me.cmdElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdAggiungi
        '
        Me.cmdAggiungi.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAggiungi.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAggiungi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAggiungi.Image = CType(resources.GetObject("cmdAggiungi.Image"), System.Drawing.Image)
        Me.cmdAggiungi.Location = New System.Drawing.Point(664, 192)
        Me.cmdAggiungi.Name = "cmdAggiungi"
        Me.cmdAggiungi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAggiungi.Size = New System.Drawing.Size(121, 57)
        Me.cmdAggiungi.TabIndex = 7
        Me.cmdAggiungi.Text = "Aggiungi"
        Me.cmdAggiungi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtProg_Avere
        '
        Me.txtProg_Avere.AcceptsReturn = True
        Me.txtProg_Avere.AutoSize = False
        Me.txtProg_Avere.BackColor = System.Drawing.SystemColors.Window
        Me.txtProg_Avere.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProg_Avere.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProg_Avere.Location = New System.Drawing.Point(192, 344)
        Me.txtProg_Avere.MaxLength = 0
        Me.txtProg_Avere.Name = "txtProg_Avere"
        Me.txtProg_Avere.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProg_Avere.Size = New System.Drawing.Size(169, 19)
        Me.txtProg_Avere.TabIndex = 5
        Me.txtProg_Avere.Text = ""
        '
        'txtProg_Dare
        '
        Me.txtProg_Dare.AcceptsReturn = True
        Me.txtProg_Dare.AutoSize = False
        Me.txtProg_Dare.BackColor = System.Drawing.SystemColors.Window
        Me.txtProg_Dare.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProg_Dare.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProg_Dare.Location = New System.Drawing.Point(192, 304)
        Me.txtProg_Dare.MaxLength = 0
        Me.txtProg_Dare.Name = "txtProg_Dare"
        Me.txtProg_Dare.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProg_Dare.Size = New System.Drawing.Size(169, 19)
        Me.txtProg_Dare.TabIndex = 4
        Me.txtProg_Dare.Text = ""
        '
        'txtSaldoConto
        '
        Me.txtSaldoConto.AcceptsReturn = True
        Me.txtSaldoConto.AutoSize = False
        Me.txtSaldoConto.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaldoConto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSaldoConto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSaldoConto.Location = New System.Drawing.Point(192, 384)
        Me.txtSaldoConto.MaxLength = 0
        Me.txtSaldoConto.Name = "txtSaldoConto"
        Me.txtSaldoConto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaldoConto.Size = New System.Drawing.Size(169, 19)
        Me.txtSaldoConto.TabIndex = 6
        Me.txtSaldoConto.Text = ""
        '
        'txtTasAttivo
        '
        Me.txtTasAttivo.AcceptsReturn = True
        Me.txtTasAttivo.AutoSize = False
        Me.txtTasAttivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTasAttivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTasAttivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTasAttivo.Location = New System.Drawing.Point(192, 264)
        Me.txtTasAttivo.MaxLength = 0
        Me.txtTasAttivo.Name = "txtTasAttivo"
        Me.txtTasAttivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTasAttivo.Size = New System.Drawing.Size(169, 19)
        Me.txtTasAttivo.TabIndex = 3
        Me.txtTasAttivo.Text = ""
        '
        'txtTasPassivo
        '
        Me.txtTasPassivo.AcceptsReturn = True
        Me.txtTasPassivo.AutoSize = False
        Me.txtTasPassivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTasPassivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTasPassivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTasPassivo.Location = New System.Drawing.Point(192, 224)
        Me.txtTasPassivo.MaxLength = 0
        Me.txtTasPassivo.Name = "txtTasPassivo"
        Me.txtTasPassivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTasPassivo.Size = New System.Drawing.Size(169, 19)
        Me.txtTasPassivo.TabIndex = 2
        Me.txtTasPassivo.Text = ""
        '
        'txtNumeroConto
        '
        Me.txtNumeroConto.AcceptsReturn = True
        Me.txtNumeroConto.AutoSize = False
        Me.txtNumeroConto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroConto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumeroConto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumeroConto.Location = New System.Drawing.Point(192, 144)
        Me.txtNumeroConto.MaxLength = 0
        Me.txtNumeroConto.Name = "txtNumeroConto"
        Me.txtNumeroConto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroConto.Size = New System.Drawing.Size(169, 19)
        Me.txtNumeroConto.TabIndex = 1
        Me.txtNumeroConto.Text = ""
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(376, 384)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(105, 17)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "INDIRIZZO CLIENTE"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(376, 344)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(105, 17)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "TELEFONO CLIENTE"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(376, 184)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(105, 17)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "COGNOME CLIENTE"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(376, 304)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(105, 17)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "CAP CLIENTE"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(376, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(105, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "PROV. CLIENTE"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(376, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(105, 17)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "CITTA' CLIENTE"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(376, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "NOME CLIENTE"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(32, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(153, 17)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "ID. FILIALE"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(32, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(153, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "PROGRESSIVO AVERE"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(32, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(153, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PROGRESSIVO DARE"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SALDO"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(32, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TASSO ATTIVO"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TASSO PASSIVO"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUMERO CONTO"
        '
        'imgTestata
        '
        '
        '_mEsci_0
        '
        Me.mEsci.SetIndex(Me._mEsci_0, CType(0, Short))
        Me._mEsci_0.Index = 1
        Me._mEsci_0.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me._mnuEsci_1, Me._mnuEsci_2})
        Me._mEsci_0.Text = "Esci"
        '
        '_mnuEsci_1
        '
        Me.mnuEsci.SetIndex(Me._mnuEsci_1, CType(1, Short))
        Me._mnuEsci_1.Index = 0
        Me._mnuEsci_1.Shortcut = System.Windows.Forms.Shortcut.F11
        Me._mnuEsci_1.Text = "Fine"
        '
        '_mnuEsci_2
        '
        Me.mnuEsci.SetIndex(Me._mnuEsci_2, CType(2, Short))
        Me._mnuEsci_2.Index = 1
        Me._mnuEsci_2.Shortcut = System.Windows.Forms.Shortcut.F12
        Me._mnuEsci_2.Text = "Torna al menù principale"
        '
        'mnuEsci
        '
        '
        'mnuFile
        '
        '
        '_mnuFile_1
        '
        Me._mnuFile_1.Index = 0
        Me.mnuFile.SetIndex(Me._mnuFile_1, CType(1, Short))
        Me._mnuFile_1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me._mnuFile_1.Text = "Causali"
        '
        '_mnuFile_2
        '
        Me._mnuFile_2.Index = 1
        Me.mnuFile.SetIndex(Me._mnuFile_2, CType(2, Short))
        Me._mnuFile_2.Shortcut = System.Windows.Forms.Shortcut.F3
        Me._mnuFile_2.Text = "Citta"
        '
        '_mnuFile_3
        '
        Me._mnuFile_3.Index = 2
        Me.mnuFile.SetIndex(Me._mnuFile_3, CType(3, Short))
        Me._mnuFile_3.Shortcut = System.Windows.Forms.Shortcut.F4
        Me._mnuFile_3.Text = "CAP"
        '
        '_mnuFile_4
        '
        Me._mnuFile_4.Index = 3
        Me.mnuFile.SetIndex(Me._mnuFile_4, CType(4, Short))
        Me._mnuFile_4.Shortcut = System.Windows.Forms.Shortcut.CtrlF1
        Me._mnuFile_4.Text = "Estratto Conto"
        '
        '_mnuFile_5
        '
        Me._mnuFile_5.Index = 4
        Me.mnuFile.SetIndex(Me._mnuFile_5, CType(5, Short))
        Me._mnuFile_5.Shortcut = System.Windows.Forms.Shortcut.CtrlF2
        Me._mnuFile_5.Text = "Provincia"
        '
        '_mnuFile_6
        '
        Me._mnuFile_6.Index = 5
        Me.mnuFile.SetIndex(Me._mnuFile_6, CType(6, Short))
        Me._mnuFile_6.Shortcut = System.Windows.Forms.Shortcut.F6
        Me._mnuFile_6.Text = "Movimenti"
        '
        '_mnuFile_7
        '
        Me._mnuFile_7.Index = 6
        Me.mnuFile.SetIndex(Me._mnuFile_7, CType(7, Short))
        Me._mnuFile_7.Shortcut = System.Windows.Forms.Shortcut.F7
        Me._mnuFile_7.Text = "Filiali"
        '
        '_mnuFile_8
        '
        Me._mnuFile_8.Index = 7
        Me.mnuFile.SetIndex(Me._mnuFile_8, CType(8, Short))
        Me._mnuFile_8.Shortcut = System.Windows.Forms.Shortcut.F8
        Me._mnuFile_8.Text = "Titoli"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mFile, Me._mEsci_0})
        '
        'mFile
        '
        Me.mFile.Index = 0
        Me.mFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me._mnuFile_1, Me._mnuFile_2, Me._mnuFile_3, Me._mnuFile_4, Me._mnuFile_5, Me._mnuFile_6, Me._mnuFile_7, Me._mnuFile_8})
        Me.mFile.Text = "File"
        '
        'frmConti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(792, 546)
        Me.Controls.Add(Me.txtIndirizzo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.dtcCap)
        Me.Controls.Add(Me.dtcProvincia)
        Me.Controls.Add(Me.dtcCitta)
        Me.Controls.Add(Me.txtCognome)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.dtcFiliale)
        Me.Controls.Add(Me.cmdPrimo)
        Me.Controls.Add(Me.cmdPrecedente)
        Me.Controls.Add(Me.cmdSuccessivo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.PicTestata)
        Me.Controls.Add(Me.cmdModifica)
        Me.Controls.Add(Me.cmdElimina)
        Me.Controls.Add(Me.cmdAggiungi)
        Me.Controls.Add(Me.txtProg_Avere)
        Me.Controls.Add(Me.txtProg_Dare)
        Me.Controls.Add(Me.txtSaldoConto)
        Me.Controls.Add(Me.txtTasAttivo)
        Me.Controls.Add(Me.txtTasPassivo)
        Me.Controls.Add(Me.txtNumeroConto)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(11, 57)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmConti"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Gestione Conti"
        CType(Me.dtcCap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtcProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtcCitta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtcFiliale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicTestata.ResumeLayout(False)
        CType(Me.imgTestata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mEsci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuEsci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Supporto aggiornamento "
	Private Shared m_vb6FormDefInstance As frmConti
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmConti
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmConti()
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
		deBanche.rsqryConto.AddNew()
		Call disabilita()
		
	End Sub
	
	Private Sub cmdElimina_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdElimina.Click
		Dim risp As String
		risp = CStr(MsgBox("Il dato sarà eliminato definitivamente. Eliminare il record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo))
		If risp = CStr(MsgBoxResult.Yes) Then
			deBanche.rsqryConto.Delete(ADODB.AffectEnum.adAffectCurrent)
			deBanche.rsqryConto.MovePrevious()
			If deBanche.rsqryConto.EOF = True And deBanche.rsqryConto.BOF = True Then
				MsgBox("I dati sono stati cancellati completamente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly)
				Exit Sub
			End If
		End If
		
	End Sub
	
	
	
	
	
	Private Sub cmdModifica_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModifica.Click
		deBanche.rsqryConto.Fields!saldo.Value = Val(txtProg_Dare.Text) - Val(txtProg_Avere.Text)
		deBanche.rsqryConto.Update()
		
	End Sub
	
	Private Sub cmdPrecedente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrecedente.Click
		deBanche.rsqryConto.MovePrevious()
		If deBanche.rsqryConto.BOF Then
			deBanche.rsqryConto.MoveNext()
		End If
		
	End Sub
	
	Private Sub cmdPrimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrimo.Click
		deBanche.rsqryConto.MoveFirst()
		
	End Sub
	
	Private Sub cmdSuccessivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSuccessivo.Click
		deBanche.rsqryConto.MoveNext()
		If deBanche.rsqryConto.EOF Then
			deBanche.rsqryConto.MovePrevious()
		End If
		
	End Sub
	
	Private Sub cmdUltimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimo.Click
		deBanche.rsqryConto.MoveLast()
		
	End Sub
	
	
	
	'Private Sub dtcCliente_Click(Area As Integer)
	'Dim sqlConti As String
	'Dim recConti As New ADODB.Recordset
	'sqlConti = "Select * from Conti where idCliente = " & dtcCliente.Text
	'Set recConti = New ADODB.Recordset
	'recConti.Open sqlConti, deBanche.conBanche.ConnectionString, adOpenDynamic, adLockOptimistic
	'If recConti.EOF = False Then
	'   txtNumeroConto.Text = recConti.Fields!numConto
	'   txtTasPassivo.Text = recConti.Fields!tas_passivo
	'   txtTasAttivo.Text = recConti.Fields!tas_attivo
	'   txtProg_Dare.Text = recConti.Fields!prog_dare
	'  txtProg_Avere.Text = recConti.Fields!prog_avere
	'   txtSaldoConto.Text = recConti.Fields!saldo
	'Else
	'   MsgBox "Codice cliente inesistente. Inserire i dati ", vbInformation + vbOKOnly, "Codice errato"
	'   deBanche.rsqryConto.AddNew
	'End If
	'recConti.Close
	'Set recConti = Nothing
	'End Sub
	
	Private Sub imgTestata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTestata.Click
		Dim Index As Short = imgTestata.GetIndex(eventSender)
		Dim frmCausali As frmCausali
		Dim frmCitta As frmCitta
		Dim frmCap As frmCap
		Dim frmProvincia As frmProvincia
		Dim frmMovimenti As frmMovimenti
		Dim frmFiliali As frmFiliali
		Dim frmTitoli As frmTitoli
		Dim frmGestioneContiCorrenti As frmGestioneContiCorrenti
		Dim frmEstrattoConto As frmEstrattoConto
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
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
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
				Me.Close()
				End
			Case Is = 10
				frmEstrattoConto = New frmEstrattoConto
				frmEstrattoConto.Show()
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
		Dim frmEstrattoConto As frmEstrattoConto
		Dim frmProvincia As frmProvincia
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
				frmCap = New frmCap
				frmCap.Show()
				
			Case Is = 4
				frmEstrattoConto = New frmEstrattoConto
				frmEstrattoConto.Show()
			Case Is = 5
				frmProvincia = New frmProvincia
				frmProvincia.Show()
				
			Case Is = 6
				frmMovimenti = New frmMovimenti
				frmMovimenti.Show()
			Case Is = 7
				frmFiliali = New frmFiliali
				frmFiliali.Show()
			Case Is = 8
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
	
	
	
	Private Sub txtIndirizzo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIndirizzo.Leave
		Call abilita()
		
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
		deBanche.qryConto()
		ADOBind_qryConto = New VB6.MBindingCollection()
		ADOBind_qryConto.DataSource = deBanche
		ADOBind_qryConto.DataMember = "qryConto"
		ADOBind_qryConto.Add(txtProg_Avere, "Text", "PROG_AVERE", Nothing, "txtProg_Avere")
		ADOBind_qryConto.Add(txtProg_Dare, "Text", "PROG_DARE", Nothing, "txtProg_Dare")
		ADOBind_qryConto.Add(txtSaldoConto, "Text", "SALDO", Nothing, "txtSaldoConto")
		ADOBind_qryConto.Add(txtTasAttivo, "Text", "TAS_ATTIVO", Nothing, "txtTasAttivo")
		ADOBind_qryConto.Add(txtTasPassivo, "Text", "TAS_PASSIVO", Nothing, "txtTasPassivo")
		ADOBind_qryConto.Add(txtNumeroConto, "Text", "NUMCONTO", Nothing, "txtNumeroConto")
		ADOBind_qryConto.Add(txtCognome, "Text", "COGNOMECLIENTE", Nothing, "txtCognome")
		ADOBind_qryConto.Add(txtNomeCliente, "Text", "NOMECLIENTE", Nothing, "txtNomeCliente")
		ADOBind_qryConto.Add(txtIndirizzo, "Text", "INDCLIENTE", Nothing, "txtIndirizzo")
		ADOBind_qryConto.Add(txtTelefono, "Text", "TELCLIENTE", Nothing, "txtTelefono")
		ADOBind_qryConto.UpdateMode = VB6.UpdateMode.vbUpdateWhenPropertyChanges
		ADOBind_qryConto.UpdateControls()
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		ADOBind_qryConto.Clear()
		ADOBind_qryConto.Dispose()
		ADOBind_qryConto = Nothing
	End Sub

 

    Private Sub txtSaldoConto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaldoConto.GotFocus
        txtSaldoConto.Text = Val(txtProg_Dare.Text) - Val(txtProg_Avere.Text)


    End Sub

 
End Class