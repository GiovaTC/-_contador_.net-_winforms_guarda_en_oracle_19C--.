using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace ContadorApp
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private int _current = 0;
        private const int _max = 6325;

        // configuracion de conexion : remplaza con tus valores .   
        private String _connectionString = "User Id=system;Password=Tapiero123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));";

        // si prefieres usar TNS name: "User Id=system;Password=Tapiero123;Data Source=tnsname;" 
        public Form1()
        {
            InitializeComponent();
            // inicializar controles    
            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
            btnReset.Click += BtnReset_Click;
            btnSaveOnce.Click += BtnSaveOnce_Click;
            chkAutoSave.CheckedChanged += ChkAutoSave_CheckedChanged;

            lblStatus.Text = "Listo";
            UpdateLabel();
        }

        private void ChkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            // nothing special needed
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
           if (_cts != null) return; // ya en ejecucion

           _cts = new CancellationTokenSource();
            lblStatus.Text = "En ejecucion";
            try
            {
                await RunCounterAsync(_cts.Token);
                lblStatus.Text = "Completado";
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Detenido";
            }
            finally
            {
                _cts.Dispose();
                _cts = null;
            }
        }   

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (_cts != null) return; // no permitir reset mientras se ejecuta
            _current = 0;
            UpdateLabel();
            lblStatus.Text = "Reiniciado";
        }

        private async void BtnSaveOnce_Click(object sender, EventArgs e)
        {
            await SaveNumberToOracleAsync(_current); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
