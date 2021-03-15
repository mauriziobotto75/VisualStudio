Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_deBanche_Module
	Friend deBanche As DataEnvironment_deBanche = New DataEnvironment_deBanche()
End Module

Friend Class DataEnvironment_deBanche
	Inherits VB6.BaseDataEnvironment
	Public WithEvents conBanche As ADODB.Connection
	Public WithEvents rsqryCausali As ADODB.Recordset
	Private m_qryCausali As ADODB.Command
	Public WithEvents rsqryNumConto As ADODB.Recordset
	Private m_qryNumConto As ADODB.Command
	Public WithEvents rsqryNConto As ADODB.Recordset
	Private m_qryNConto As ADODB.Command
	Public WithEvents rsqryFiliale As ADODB.Recordset
	Private m_qryFiliale As ADODB.Command
	Public WithEvents rsqryMovimenti2 As ADODB.Recordset
	Private m_qryMovimenti2 As ADODB.Command
	Public WithEvents rsqryCitta As ADODB.Recordset
	Private m_qryCitta As ADODB.Command
	Public WithEvents rsqryCap As ADODB.Recordset
	Private m_qryCap As ADODB.Command
	Public WithEvents rsqrySegno As ADODB.Recordset
	Private m_qrySegno As ADODB.Command
	Public WithEvents rsqryTitoli As ADODB.Recordset
	Private m_qryTitoli As ADODB.Command
	Public WithEvents rsqryNomeTitolo As ADODB.Recordset
	Private m_qryNomeTitolo As ADODB.Command
	Public WithEvents rsqryIdConto As ADODB.Recordset
	Private m_qryIdConto As ADODB.Command
	Public WithEvents rsqryCliente As ADODB.Recordset
	Private m_qryCliente As ADODB.Command
	Public WithEvents rsqryConto As ADODB.Recordset
	Private m_qryConto As ADODB.Command
	Public WithEvents rsqryProv As ADODB.Recordset
	Private m_qryProv As ADODB.Command
	Public WithEvents rsqryGiorni As ADODB.Recordset
	Private m_qryGiorni As ADODB.Command
	Public WithEvents rsqryMese As ADODB.Recordset
	Private m_qryMese As ADODB.Command
	Public WithEvents rsqryAnno As ADODB.Recordset
	Private m_qryAnno As ADODB.Command
	Public Sub New()
		MyBase.New()
		Dim par As ADODB.Parameter
		
		
		conBanche = New ADODB.Connection()
		conBanche.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Documents and Settings\Maurizio\Desktop\ContiCorrentiBancari\ContiCorrenti.mdb;Mode=ReadWrite|Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=0;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;"
		m_Connections.Add(conBanche, "conBanche")
		m_qryCausali = New ADODB.Command()
		rsqryCausali = New ADODB.Recordset()
		m_qryCausali.Name = "qryCausali"
		m_qryCausali.CommandText = "SELECT Causali.* FROM Causali"
		m_qryCausali.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryCausali.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryCausali.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryCausali.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryCausali.Source = m_qryCausali
		m_Commands.Add(m_qryCausali, "qryCausali")
		m_Recordsets.Add(rsqryCausali, "qryCausali")
		m_qryNumConto = New ADODB.Command()
		rsqryNumConto = New ADODB.Recordset()
		m_qryNumConto.Name = "qryNumConto"
		m_qryNumConto.CommandText = "SELECT numConto FROM Conti"
		m_qryNumConto.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryNumConto.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryNumConto.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryNumConto.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryNumConto.Source = m_qryNumConto
		m_Commands.Add(m_qryNumConto, "qryNumConto")
		m_Recordsets.Add(rsqryNumConto, "qryNumConto")
		m_qryNConto = New ADODB.Command()
		rsqryNConto = New ADODB.Recordset()
		m_qryNConto.Name = "qryNConto"
		m_qryNConto.CommandText = "SELECT DISTINCTROW numConto FROM Conti"
		m_qryNConto.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryNConto.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryNConto.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryNConto.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryNConto.Source = m_qryNConto
		m_Commands.Add(m_qryNConto, "qryNConto")
		m_Recordsets.Add(rsqryNConto, "qryNConto")
		m_qryFiliale = New ADODB.Command()
		rsqryFiliale = New ADODB.Recordset()
		m_qryFiliale.Name = "qryFiliale"
		m_qryFiliale.CommandText = "SELECT Filiale.* FROM Filiale"
		m_qryFiliale.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryFiliale.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryFiliale.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryFiliale.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryFiliale.Source = m_qryFiliale
		m_Commands.Add(m_qryFiliale, "qryFiliale")
		m_Recordsets.Add(rsqryFiliale, "qryFiliale")
		m_qryMovimenti2 = New ADODB.Command()
		rsqryMovimenti2 = New ADODB.Recordset()
		m_qryMovimenti2.Name = "qryMovimenti2"
		m_qryMovimenti2.CommandText = "SELECT dataMovimento, dataValuta, desMovimento, idCausale, idConto, idMovimento, importo, numConto, segnoMovimento FROM Movimenti"
		m_qryMovimenti2.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryMovimenti2.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryMovimenti2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryMovimenti2.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryMovimenti2.Source = m_qryMovimenti2
		m_Commands.Add(m_qryMovimenti2, "qryMovimenti2")
		m_Recordsets.Add(rsqryMovimenti2, "qryMovimenti2")
		m_qryCitta = New ADODB.Command()
		rsqryCitta = New ADODB.Recordset()
		m_qryCitta.Name = "qryCitta"
		m_qryCitta.CommandText = "SELECT Citta.* FROM Citta"
		m_qryCitta.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryCitta.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryCitta.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryCitta.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryCitta.Source = m_qryCitta
		m_Commands.Add(m_qryCitta, "qryCitta")
		m_Recordsets.Add(rsqryCitta, "qryCitta")
		m_qryCap = New ADODB.Command()
		rsqryCap = New ADODB.Recordset()
		m_qryCap.Name = "qryCap"
		m_qryCap.CommandText = "SELECT CAP.* FROM CAP"
		m_qryCap.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryCap.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryCap.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryCap.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryCap.Source = m_qryCap
		m_Commands.Add(m_qryCap, "qryCap")
		m_Recordsets.Add(rsqryCap, "qryCap")
		m_qrySegno = New ADODB.Command()
		rsqrySegno = New ADODB.Recordset()
		m_qrySegno.Name = "qrySegno"
		m_qrySegno.CommandText = "SELECT DISTINCT  segnoCausale FROM Causali"
		m_qrySegno.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqrySegno.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqrySegno.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqrySegno.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqrySegno.Source = m_qrySegno
		m_Commands.Add(m_qrySegno, "qrySegno")
		m_Recordsets.Add(rsqrySegno, "qrySegno")
		m_qryTitoli = New ADODB.Command()
		rsqryTitoli = New ADODB.Recordset()
		m_qryTitoli.Name = "qryTitoli"
		m_qryTitoli.CommandText = "SELECT Titoli.* FROM Titoli"
		m_qryTitoli.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryTitoli.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryTitoli.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryTitoli.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryTitoli.Source = m_qryTitoli
		m_Commands.Add(m_qryTitoli, "qryTitoli")
		m_Recordsets.Add(rsqryTitoli, "qryTitoli")
		m_qryNomeTitolo = New ADODB.Command()
		rsqryNomeTitolo = New ADODB.Recordset()
		m_qryNomeTitolo.Name = "qryNomeTitolo"
		m_qryNomeTitolo.CommandText = "SELECT DISTINCTROW nomeTitolo FROM TipoTitolo "
		m_qryNomeTitolo.CommandType = ADODB.CommandTypeEnum.adCmdText
		par = m_qryNomeTitolo.CreateParameter
		par.Name = "nomeTitolo"
		par.Type = ADODB.DataTypeEnum.adVarWChar
		par.Size = 510
		par.Precision = 255
		par.Direction = ADODB.ParameterDirectionEnum.adParamInput
		m_qryNomeTitolo.Parameters.Append(par)
		rsqryNomeTitolo.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryNomeTitolo.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryNomeTitolo.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryNomeTitolo.Source = m_qryNomeTitolo
		m_Commands.Add(m_qryNomeTitolo, "qryNomeTitolo")
		m_Recordsets.Add(rsqryNomeTitolo, "qryNomeTitolo")
		m_qryIdConto = New ADODB.Command()
		rsqryIdConto = New ADODB.Recordset()
		m_qryIdConto.Name = "qryIdConto"
		m_qryIdConto.CommandText = "SELECT DISTINCTROW idConto FROM Conti"
		m_qryIdConto.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryIdConto.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryIdConto.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryIdConto.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryIdConto.Source = m_qryIdConto
		m_Commands.Add(m_qryIdConto, "qryIdConto")
		m_Recordsets.Add(rsqryIdConto, "qryIdConto")
		m_qryCliente = New ADODB.Command()
		rsqryCliente = New ADODB.Recordset()
		m_qryCliente.Name = "qryCliente"
		m_qryCliente.CommandText = "SELECT cap AS CAP, cellulare AS CELLULARE, citta AS CITTA, cognome AS COGNOME, indirizzo AS INDIRIZZO, nome AS NOME, telefono AS TELEFONO, idCliente AS IDCLIENTE FROM Clienti"
		m_qryCliente.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryCliente.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryCliente.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryCliente.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryCliente.Source = m_qryCliente
		m_Commands.Add(m_qryCliente, "qryCliente")
		m_Recordsets.Add(rsqryCliente, "qryCliente")
		m_qryConto = New ADODB.Command()
		rsqryConto = New ADODB.Recordset()
		m_qryConto.Name = "qryConto"
		m_qryConto.CommandText = "SELECT capCliente AS CAPCLIENTE, cittaCliente AS CITTACLIENTE, cognomeCliente AS COGNOMECLIENTE, idCliente AS IDCLIENTE, telCliente AS TELCLIENTE, tas_passivo AS TAS_PASSIVO, tas_attivo AS TAS_ATTIVO, saldo AS SALDO, provCliente AS PROVCLIENTE, prog_dare AS PROG_DARE, prog_avere AS PROG_AVERE, numConto AS NUMCONTO, nomeCliente AS NOMECLIENTE, indirizzoCliente AS INDCLIENTE, idFiliale AS IDFILIALE, idConto AS IDCONTO FROM Conti"
		m_qryConto.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryConto.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryConto.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryConto.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryConto.Source = m_qryConto
		m_Commands.Add(m_qryConto, "qryConto")
		m_Recordsets.Add(rsqryConto, "qryConto")
		m_qryProv = New ADODB.Command()
		rsqryProv = New ADODB.Recordset()
		m_qryProv.Name = "qryProv"
		m_qryProv.CommandText = "SELECT nomeProv FROM Provincia"
		m_qryProv.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryProv.LockType = ADODB.LockTypeEnum.adLockOptimistic
		rsqryProv.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryProv.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryProv.Source = m_qryProv
		m_Commands.Add(m_qryProv, "qryProv")
		m_Recordsets.Add(rsqryProv, "qryProv")
		m_qryGiorni = New ADODB.Command()
		rsqryGiorni = New ADODB.Recordset()
		m_qryGiorni.Name = "qryGiorni"
		m_qryGiorni.CommandText = "SELECT giorno FROM Giorni"
		m_qryGiorni.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryGiorni.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryGiorni.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryGiorni.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryGiorni.Source = m_qryGiorni
		m_Commands.Add(m_qryGiorni, "qryGiorni")
		m_Recordsets.Add(rsqryGiorni, "qryGiorni")
		m_qryMese = New ADODB.Command()
		rsqryMese = New ADODB.Recordset()
		m_qryMese.Name = "qryMese"
		m_qryMese.CommandText = "SELECT mese FROM Mese"
		m_qryMese.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryMese.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryMese.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryMese.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryMese.Source = m_qryMese
		m_Commands.Add(m_qryMese, "qryMese")
		m_Recordsets.Add(rsqryMese, "qryMese")
		m_qryAnno = New ADODB.Command()
		rsqryAnno = New ADODB.Recordset()
		m_qryAnno.Name = "qryAnno"
		m_qryAnno.CommandText = "SELECT Anno AS ANNO FROM Anno"
		m_qryAnno.CommandType = ADODB.CommandTypeEnum.adCmdText
		rsqryAnno.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsqryAnno.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsqryAnno.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsqryAnno.Source = m_qryAnno
		m_Commands.Add(m_qryAnno, "qryAnno")
		m_Recordsets.Add(rsqryAnno, "qryAnno")
	End Sub
	Public Sub qryCausali()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryCausali.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryCausali.Close()
		End If
		m_qryCausali.ActiveConnection = conBanche
		rsqryCausali.Open()
	End Sub
	Public Sub qryNumConto()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryNumConto.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryNumConto.Close()
		End If
		m_qryNumConto.ActiveConnection = conBanche
		rsqryNumConto.Open()
	End Sub
	Public Sub qryNConto()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryNConto.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryNConto.Close()
		End If
		m_qryNConto.ActiveConnection = conBanche
		rsqryNConto.Open()
	End Sub
	Public Sub qryFiliale()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryFiliale.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryFiliale.Close()
		End If
		m_qryFiliale.ActiveConnection = conBanche
		rsqryFiliale.Open()
	End Sub
	Public Sub qryMovimenti2()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryMovimenti2.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryMovimenti2.Close()
		End If
		m_qryMovimenti2.ActiveConnection = conBanche
		rsqryMovimenti2.Open()
	End Sub
	Public Sub qryCitta()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryCitta.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryCitta.Close()
		End If
		m_qryCitta.ActiveConnection = conBanche
		rsqryCitta.Open()
	End Sub
	Public Sub qryCap()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryCap.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryCap.Close()
		End If
		m_qryCap.ActiveConnection = conBanche
		rsqryCap.Open()
	End Sub
	Public Sub qrySegno()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqrySegno.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqrySegno.Close()
		End If
		m_qrySegno.ActiveConnection = conBanche
		rsqrySegno.Open()
	End Sub
	Public Sub qryTitoli()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryTitoli.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryTitoli.Close()
		End If
		m_qryTitoli.ActiveConnection = conBanche
		rsqryTitoli.Open()
	End Sub
	Public Sub qryNomeTitolo(ByVal nomeTitolo As String)
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryNomeTitolo.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryNomeTitolo.Close()
		End If
		m_qryNomeTitolo.ActiveConnection = conBanche
		m_qryNomeTitolo.Parameters.Item("nomeTitolo").Value = nomeTitolo
		rsqryNomeTitolo.Open()
	End Sub
	Public Sub qryIdConto()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryIdConto.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryIdConto.Close()
		End If
		m_qryIdConto.ActiveConnection = conBanche
		rsqryIdConto.Open()
	End Sub
	Public Sub qryCliente()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryCliente.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryCliente.Close()
		End If
		m_qryCliente.ActiveConnection = conBanche
		rsqryCliente.Open()
	End Sub
	Public Sub qryConto()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryConto.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryConto.Close()
		End If
		m_qryConto.ActiveConnection = conBanche
		rsqryConto.Open()
	End Sub
	Public Sub qryProv()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryProv.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryProv.Close()
		End If
		m_qryProv.ActiveConnection = conBanche
		rsqryProv.Open()
	End Sub
	Public Sub qryGiorni()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryGiorni.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryGiorni.Close()
		End If
		m_qryGiorni.ActiveConnection = conBanche
		rsqryGiorni.Open()
	End Sub
	Public Sub qryMese()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryMese.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryMese.Close()
		End If
		m_qryMese.ActiveConnection = conBanche
		rsqryMese.Open()
	End Sub
	Public Sub qryAnno()
		If conBanche.State = ADODB.ObjectStateEnum.adStateClosed Then
			conBanche.Open()
		End If
		If rsqryAnno.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsqryAnno.Close()
		End If
		m_qryAnno.ActiveConnection = conBanche
		rsqryAnno.Open()
	End Sub
End Class