Option Strict Off
Option Explicit On
Friend Class ctrlProv
	Inherits System.Windows.Forms.UserControl
#Region "Codice generato dalla finestra di progettazione Windows Form "
	Public Sub New()
		MyBase.New()
		'Chiamata richiesta dalla progettazione Windows Form.
		InitializeComponent()
	End Sub
	'Il form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Richiesto dalla progettazione Windows Form
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents Line20 As System.Windows.Forms.Label
	Friend WithEvents Line19 As System.Windows.Forms.Label
	Friend WithEvents Line18 As System.Windows.Forms.Label
	Friend WithEvents Line17 As System.Windows.Forms.Label
	Friend WithEvents Line16 As System.Windows.Forms.Label
	Friend WithEvents Line15 As System.Windows.Forms.Label
	Friend WithEvents Line14 As System.Windows.Forms.Label
	Friend WithEvents Line13 As System.Windows.Forms.Label
	Friend WithEvents Line12 As System.Windows.Forms.Label
	Friend WithEvents Line11 As System.Windows.Forms.Label
	Friend WithEvents Line10 As System.Windows.Forms.Label
	Friend WithEvents Line9 As System.Windows.Forms.Label
	Friend WithEvents Line8 As System.Windows.Forms.Label
	Friend WithEvents Line7 As System.Windows.Forms.Label
	Friend WithEvents Line6 As System.Windows.Forms.Label
	Friend WithEvents Line5 As System.Windows.Forms.Label
	Friend WithEvents Line4 As System.Windows.Forms.Label
	Friend WithEvents Line3 As System.Windows.Forms.Label
	Friend WithEvents Line2 As System.Windows.Forms.Label
	Friend WithEvents Line1 As System.Windows.Forms.Label
	'NOTA: la routine seguente è richiesta dalla progettazione Windows Form.
	'Può essere modificata utilizzando la finestra di progettazione Windows Form.
	'Non modificarla mediante l'editor di codice.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ctrlProv))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Line20 = New System.Windows.Forms.Label
		Me.Line19 = New System.Windows.Forms.Label
		Me.Line18 = New System.Windows.Forms.Label
		Me.Line17 = New System.Windows.Forms.Label
		Me.Line16 = New System.Windows.Forms.Label
		Me.Line15 = New System.Windows.Forms.Label
		Me.Line14 = New System.Windows.Forms.Label
		Me.Line13 = New System.Windows.Forms.Label
		Me.Line12 = New System.Windows.Forms.Label
		Me.Line11 = New System.Windows.Forms.Label
		Me.Line10 = New System.Windows.Forms.Label
		Me.Line9 = New System.Windows.Forms.Label
		Me.Line8 = New System.Windows.Forms.Label
		Me.Line7 = New System.Windows.Forms.Label
		Me.Line6 = New System.Windows.Forms.Label
		Me.Line5 = New System.Windows.Forms.Label
		Me.Line4 = New System.Windows.Forms.Label
		Me.Line3 = New System.Windows.Forms.Label
		Me.Line2 = New System.Windows.Forms.Label
		Me.Line1 = New System.Windows.Forms.Label
		Me.ClientSize = New System.Drawing.Size(342, 240)
		MyBase.Location = New System.Drawing.Point(0, 0)
		MyBase.Name = "ctrlProv"
		Me.Line20.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line20.Visible = True
		Me.Line20.Location = New System.Drawing.Point(200, 80)
		Me.Line20.Width = 1
		Me.Line20.Height = 32
		Me.Line20.Name = "Line20"
		Me.Line19.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line19.Visible = True
		Me.Line19.Location = New System.Drawing.Point(232, 80)
		Me.Line19.Width = 1
		Me.Line19.Height = 32
		Me.Line19.Name = "Line19"
		Me.Line18.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line18.Visible = True
		Me.Line18.Location = New System.Drawing.Point(200, 80)
		Me.Line18.Width = 32
		Me.Line18.Height = 1
		Me.Line18.Name = "Line18"
		Me.Line17.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line17.Visible = True
		Me.Line17.Location = New System.Drawing.Point(200, 112)
		Me.Line17.Width = 32
		Me.Line17.Height = 1
		Me.Line17.Name = "Line17"
		Me.Line16.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line16.Visible = True
		Me.Line16.Location = New System.Drawing.Point(232, 120)
		Me.Line16.Width = 1
		Me.Line16.Height = 88
		Me.Line16.Name = "Line16"
		Me.Line15.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line15.Visible = True
		Me.Line15.Location = New System.Drawing.Point(200, 120)
		Me.Line15.Width = 32
		Me.Line15.Height = 1
		Me.Line15.Name = "Line15"
		Me.Line14.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line14.Visible = True
		Me.Line14.Location = New System.Drawing.Point(200, 120)
		Me.Line14.Width = 1
		Me.Line14.Height = 88
		Me.Line14.Name = "Line14"
		Me.Line13.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line13.Visible = True
		Me.Line13.Location = New System.Drawing.Point(232, 208)
		Me.Line13.Width = 24
		Me.Line13.Height = 1
		Me.Line13.Name = "Line13"
		Me.Line12.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line12.Visible = True
		Me.Line12.Location = New System.Drawing.Point(176, 208)
		Me.Line12.Width = 24
		Me.Line12.Height = 1
		Me.Line12.Name = "Line12"
		Me.Line11.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line11.Visible = True
		Me.Line11.Location = New System.Drawing.Point(176, 72)
		Me.Line11.Width = 1
		Me.Line11.Height = 136
		Me.Line11.Name = "Line11"
		Me.Line10.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line10.Visible = True
		Me.Line10.Location = New System.Drawing.Point(176, 72)
		Me.Line10.Width = 80
		Me.Line10.Height = 1
		Me.Line10.Name = "Line10"
		Me.Line9.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line9.Visible = True
		Me.Line9.Location = New System.Drawing.Point(256, 72)
		Me.Line9.Width = 1
		Me.Line9.Height = 136
		Me.Line9.Name = "Line9"
		Me.Line8.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line8.Visible = True
		Me.Line8.Location = New System.Drawing.Point(80, 208)
		Me.Line8.Width = 32
		Me.Line8.Height = 1
		Me.Line8.Name = "Line8"
		Me.Line7.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line7.Visible = True
		Me.Line7.Location = New System.Drawing.Point(112, 104)
		Me.Line7.Width = 1
		Me.Line7.Height = 104
		Me.Line7.Name = "Line7"
		Me.Line6.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line6.Visible = True
		Me.Line6.Location = New System.Drawing.Point(80, 104)
		Me.Line6.Width = 1
		Me.Line6.Height = 104
		Me.Line6.Name = "Line6"
		Me.Line5.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line5.Visible = True
		Me.Line5.Location = New System.Drawing.Point(48, 72)
		Me.Line5.Width = 1
		Me.Line5.Height = 32
		Me.Line5.Name = "Line5"
		Me.Line4.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line4.Visible = True
		Me.Line4.Location = New System.Drawing.Point(144, 72)
		Me.Line4.Width = 1
		Me.Line4.Height = 32
		Me.Line4.Name = "Line4"
		Me.Line3.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line3.Visible = True
		Me.Line3.Location = New System.Drawing.Point(112, 104)
		Me.Line3.Width = 32
		Me.Line3.Height = 1
		Me.Line3.Name = "Line3"
		Me.Line2.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line2.Visible = True
		Me.Line2.Location = New System.Drawing.Point(48, 104)
		Me.Line2.Width = 32
		Me.Line2.Height = 1
		Me.Line2.Name = "Line2"
		Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
		Me.Line1.Visible = True
		Me.Line1.Location = New System.Drawing.Point(48, 72)
		Me.Line1.Width = 96
		Me.Line1.Height = 1
		Me.Line1.Name = "Line1"
		Me.Controls.Add(Line20)
		Me.Controls.Add(Line19)
		Me.Controls.Add(Line18)
		Me.Controls.Add(Line17)
		Me.Controls.Add(Line16)
		Me.Controls.Add(Line15)
		Me.Controls.Add(Line14)
		Me.Controls.Add(Line13)
		Me.Controls.Add(Line12)
		Me.Controls.Add(Line11)
		Me.Controls.Add(Line10)
		Me.Controls.Add(Line9)
		Me.Controls.Add(Line8)
		Me.Controls.Add(Line7)
		Me.Controls.Add(Line6)
		Me.Controls.Add(Line5)
		Me.Controls.Add(Line4)
		Me.Controls.Add(Line3)
		Me.Controls.Add(Line2)
		Me.Controls.Add(Line1)
	End Sub
#End Region 
End Class