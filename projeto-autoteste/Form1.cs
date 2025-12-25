using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projeto_autoteste
{
    public partial class Form1 : Form
    {
        // 📂 Pasta base das suites
        string pastaBase = @"C:\AutomacaoTestes\Suites";

        // ⚙️ Caminho do AutoIt
        string autoItExe = @"C:\Program Files (x86)\AutoIt3\AutoIt3.exe";

        public Form1()
        {
            InitializeComponent();
            CarregarAmbientes();
        }

        // ================= LOG =================
        void Log(string message, Color? color = null)
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;
            txtLog.SelectionColor = color ?? Color.White;
            txtLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
            txtLog.SelectionColor = Color.White;
            txtLog.ScrollToCaret();
        }

        // ============ AMBIENTES ============
        void CarregarAmbientes()
        {
            cmbEnvironment.Items.Clear();
            cmbEnvironment.Items.AddRange(new object[]
            {
                "DEV",
                "HML",
                "PRD"
            });
            cmbEnvironment.SelectedIndex = 0;
        }

        // ============ CARREGAR SUITES ============
        private void btnRunSuite_Click(object sender, EventArgs e)
        {
            lstSuites.Items.Clear();
            lstTests.Items.Clear();

            if (!Directory.Exists(pastaBase))
            {
                Log("Pasta base não encontrada", Color.Red);
                return;
            }

            foreach (var dir in Directory.GetDirectories(pastaBase))
            {
                lstSuites.Items.Add(Path.GetFileName(dir));
            }

            Log("Suites carregadas", Color.Cyan);
        }

        // ============ SELEÇÃO DA SUITE ============
        private void lstSuites_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTests.Items.Clear();

            if (lstSuites.SelectedItem == null)
                return;

            string suite = lstSuites.SelectedItem.ToString();
            string caminhoSuite = Path.Combine(pastaBase, suite);

            foreach (var script in Directory.GetFiles(caminhoSuite, "*.au3"))
            {
                lstTests.Items.Add(Path.GetFileName(script));
            }

            Log($"Suite selecionada: {suite}", Color.LightBlue);
        }

        // ============ EXECUTAR TESTE ÚNICO ============
        private void btnRunTest_Click(object sender, EventArgs e)
        {
            if (lstSuites.SelectedItem == null || lstTests.SelectedItem == null)
            {
                Log("Selecione uma suite e um teste", Color.Yellow);
                return;
            }

            ExecutarTeste(
                lstSuites.SelectedItem.ToString(),
                lstTests.SelectedItem.ToString()
            );
        }

        // ============ EXECUTAR SUITE COMPLETA ============
        private void btnRunAll_Click(object sender, EventArgs e)
        {
            if (lstSuites.SelectedItem == null)
            {
                Log("Selecione uma suite", Color.Yellow);
                return;
            }

            string suite = lstSuites.SelectedItem.ToString();
            string caminhoSuite = Path.Combine(pastaBase, suite);

            var scripts = Directory.GetFiles(caminhoSuite, "*.au3");

            int passou = 0;
            int falhou = 0;

            Log($"🚀 Iniciando execução da suite: {suite}", Color.Cyan);

            foreach (var script in scripts)
            {
                string nomeTeste = Path.GetFileName(script);

                bool resultado = ExecutarTeste(suite, nomeTeste);

                if (resultado)
                    passou++;
                else
                    falhou++;
            }

            Log("==================================", Color.White);
            Log($"SUITE FINALIZADA ✅", Color.LightBlue);
            Log($"Passaram: {passou}", Color.Lime);
            Log($"Falharam: {falhou}", Color.Red);
            Log("==================================", Color.White);
        }

        // ============ MÉTODO CENTRAL DE EXECUÇÃO ============
        private bool ExecutarTeste(string suite, string teste)
        {
            if (!File.Exists(autoItExe))
            {
                Log("AutoIt3.exe não encontrado", Color.Red);
                return false;
            }

            string ambiente = cmbEnvironment.SelectedItem.ToString();
            string caminhoScript = Path.Combine(pastaBase, suite, teste);

            Log($"[{ambiente}] Executando {teste}", Color.Cyan);

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = autoItExe;
                proc.StartInfo.Arguments = $"\"{caminhoScript}\" {ambiente}";
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(caminhoScript);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.WaitForExit();

                if (proc.ExitCode == 0)
                {
                    Log("PASSOU ✅", Color.Lime);
                    return true;
                }
                else
                {
                    Log($"FALHOU ❌ (ExitCode {proc.ExitCode})", Color.Red);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log($"Erro ao executar teste: {ex.Message}", Color.Red);
                return false;
            }
        }

        // Eventos inúteis mas necessários
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
