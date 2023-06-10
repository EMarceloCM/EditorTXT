using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EditorTXT
{
    public partial class FormMonitoramento : Form
    {
        private string filePath;
        FileSystemWatcher? watcher;
        private enum LogType
        {
            Created, Deleted, Renamed, Changed
        }
        public FormMonitoramento(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private async void FormMonitoramento_Load(object sender, EventArgs e)
        {
            await Task_Void_Async();
        }

        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            _ = Monitoramento();
        }

        private bool Monitoramento()
        {
            try
            {
                watcher = new FileSystemWatcher(filePath);

                using (watcher)
                {
                    watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
                    watcher.Filter = "*.txt";

                    watcher.Created += OnFileCreated;
                    watcher.Deleted += OnFileDeleted;
                    watcher.Renamed += OnFileRenamed;
                    watcher.Changed += OnFileChanged;
                    watcher.Error += OnError;

                    watcher.IncludeSubdirectories = true;
                    watcher.EnableRaisingEvents = true;
                    watcher.BeginInit();
                }

                lblTitulo.Text = "Monitorando: " + filePath;
                txtLog.Text = "Aguardando...\n";
                return true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"\nErro ao monitorar arquivo:\n{ex.Message}\n";
                return false;
            }
        }

        private void setLog(string log, string? log2, LogType type)
        {
            if (type == LogType.Created) txtLog.Text += $"Arquivo criado: {log} às {DateTime.Now}\n";
            else if (type == LogType.Deleted) txtLog.Text += $"Arquivo deletado: {log} às {DateTime.Now}\n";
            else if (type == LogType.Renamed) txtLog.Text += $"Arquivo renomeado de: {log} para: {log2} às {DateTime.Now}\n";
            else if (type == LogType.Changed) txtLog.Text += $"Arquivo alterado: {log} às {DateTime.Now}\n";
        }

        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            setLog(e.FullPath, null, LogType.Created);
        }

        private void OnFileDeleted(object sender, FileSystemEventArgs e)
        {
            setLog(e.FullPath, null, LogType.Deleted);
        }

        private void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            setLog(e.OldFullPath, e.FullPath, LogType.Renamed);
        }

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            setLog(e.FullPath, null, LogType.Changed);
        }

        private void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                txtLog.Text += $"Message: {ex.Message}\n";
                txtLog.Text += $"Stacktrace:\n{ex.StackTrace}\n";
                PrintException(ex.InnerException);
            }
        }

        private void FormMonitoramento_FormClosing(object sender, FormClosingEventArgs e)
        {
            watcher?.EndInit();
        }
    }
}
