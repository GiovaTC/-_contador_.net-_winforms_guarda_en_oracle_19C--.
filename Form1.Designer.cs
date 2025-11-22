// Form1.Designer.cs
namespace ContadorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNumber;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private ProgressBar progressBar;
        private CheckBox chkAutoSave;
        private Button btnSaveOnce;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNumber = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            progressBar = new ProgressBar();
            chkAutoSave = new CheckBox();
            btnSaveOnce = new Button();
            lblStatus = new Label();

            SuspendLayout();

            // lblNumber
            lblNumber.AutoSize = true;
            lblNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblNumber.Location = new System.Drawing.Point(30, 20);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new System.Drawing.Size(38, 45);
            lblNumber.Text = "0";

            // btnStart
            btnStart.Location = new System.Drawing.Point(30, 80);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(100, 30);
            btnStart.Text = "Iniciar";

            // btnStop
            btnStop.Location = new System.Drawing.Point(140, 80);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(100, 30);
            btnStop.Text = "Detener";

            // btnReset
            btnReset.Location = new System.Drawing.Point(250, 80);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(100, 30);
            btnReset.Text = "Reiniciar";

            // progressBar
            progressBar.Location = new System.Drawing.Point(30, 130);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(320, 20);

            // chkAutoSave
            chkAutoSave.Location = new System.Drawing.Point(30, 170);
            chkAutoSave.Name = "chkAutoSave";
            chkAutoSave.Size = new System.Drawing.Size(150, 20);
            chkAutoSave.Text = "Guardado automático";

            // btnSaveOnce
            btnSaveOnce.Location = new System.Drawing.Point(190, 165);
            btnSaveOnce.Name = "btnSaveOnce";
            btnSaveOnce.Size = new System.Drawing.Size(160, 30);
            btnSaveOnce.Text = "Guardar ahora";

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(30, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(100, 15);
            lblStatus.Text = "Estado: Listo";

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 260);
            Controls.Add(lblNumber);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnReset);
            Controls.Add(progressBar);
            Controls.Add(chkAutoSave);
            Controls.Add(btnSaveOnce);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Contador .NET";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}