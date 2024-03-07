Caricare dati da una lista di oggetti
Ci sono vari modi per caricare dati in una DataGridView. Un metodo è quello di mettere una lista di oggetti in binding con la DataGridView.
La prima cosa da fare è definire una classe i cui oggetti rappresentano le righe da visualizzare nella griglia.
In questo esempio si definisce la classe 'Persone' in questo modo:

   public class Persone
   {
       public string Nome { get; set; }
       public string Cognome { get; set; }
       public DateTime DataDiNascita { get; set; }

       public Persone(string nome, string cognome, DateTime dataDiNascita)
       {
           Nome = nome;
           Cognome = cognome;
           DataDiNascita = dataDiNascita;
       }
   }

La classe ha tre proprietà ('Nome', 'Cognome' e 'DataDiNascita'): queste proprietà saranno messe in 'binding' con le colonne della griglia.
È presente anche un costruttore, utile per generare velocemente gli oggetti (si veda il codice successivo).
Il secondo passo da fare è definire una lista di oggetti, in questo esempio di oggetti di tipo 'Persone'.
Questa definizione deve essere inserita all'interno della classe 'Form', perché l'oggetto 'lstData' deve essere visibile da tutti i metodi della Form.

   // Lista con gli oggetti da mostrare in griglia
   BindingList<Persone> lstData = new BindingList<Persone>();

Il terzo passo è quello di inserire un paio di controlli nella Form: un Button (in questo esempio è 'button1') e una DataGridView (chiamata 'dgvData').
Infine nell'evento click del Button occorre inserire il codice seguente:

   private void button1_Click(object sender, EventArgs e)
   {
       // Imposta colonne della griglia.
       dgvData.Columns.Clear();
 
       DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
       col1.DataPropertyName = "Nome";
       col1.HeaderText = "Nome";
       col1.Name = "colNome";
       col1.ValueType = typeof(string);
       col1.Width = 100;
       col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
       col1.ReadOnly = true;
       col1.MinimumWidth = 50;
       dgvData.Columns.Add(col1);
 
       DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
       col2.DataPropertyName = "Cognome";
       col2.HeaderText = "Cognome";
       col2.Name = "colCognome";
       col2.ValueType = typeof(string);
       col2.Width = 100;
       col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
       col2.ReadOnly = true;
       col2.MinimumWidth = 50;
       dgvData.Columns.Add(col2);

       DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
       col3.DataPropertyName = "DataDiNascita";
       col3.HeaderText = "Data di nascita";
       col3.Name = "colDataDiNascita";
       col3.ValueType = typeof(DateTime);
       col3.Width = 100;
       col3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
       col3.ReadOnly = true;
       col3.MinimumWidth = 50;
       dgvData.Columns.Add(col3);

       // Carica i dati nella lista
       lstData.Clear();
       lstData.Add(new Persone("Isaac", "Asimov", new DateTime(1920, 1, 2)));
       lstData.Add(new Persone("Ray", "Bradbury", new DateTime(1920, 8, 22)));
       lstData.Add(new Persone("Philip K.", "Dick", new DateTime(1928, 12, 16)));
       lstData.Add(new Persone("Arthur C.", "Clarke", new DateTime(1917, 12, 16)));
       lstData.Add(new Persone("William", "Gibson", new DateTime(1948, 3, 17)));

       // La dgv si aggiorna da sola perché la lista è BindingList
       dgvData.DataSource = lstData;   
