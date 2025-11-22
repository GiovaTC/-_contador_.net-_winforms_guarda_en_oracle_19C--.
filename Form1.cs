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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
