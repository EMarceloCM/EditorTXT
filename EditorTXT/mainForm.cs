using System.Security.Principal;

namespace EditorTXT
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        #region Menu Arquivo

        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new mainForm()));
            t.SetApartmentState(ApartmentState.STA); //single thread apartment
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir...";
            open.Filter = "todos|*.*|txt|*.txt|pdf|*.pdf|rich text file|*.rtf"; //extensão

            var result = open.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(open.FileName))
                {
                    FileInfo file = new FileInfo(open.FileName);
                    Text = Application.ProductName + " - " + file.Name;
                    Gerenciador.setFileSettings(file);

                    StreamReader reader;

                    try
                    {
                        using (reader = new StreamReader(file.FullName, true))
                        {
                            txtConteudo.Text = reader.ReadToEnd();
                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo não suportado.\n" + ex.Message);
                    }
                }
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Salvar...";
                save.Filter = ".txt|*.txt|pdf|*.pdf|rich text file|*.rtf|todos|*.*";
                save.CheckFileExists = false;
                save.CheckPathExists = true;

                var result = save.ShowDialog();
                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(save.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Salvar...";
            save.Filter = ".txt|*.txt|rich text file|*.rtf"; //extensão
            save.CheckFileExists = false;
            save.CheckPathExists = true;

            var result = save.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(save.FileName);
            }
        }

        private void SalvarArquivo(string path)
        {
            StreamWriter? writer = null;
            try
            {
                using (writer = new StreamWriter(path, false))
                {
                    writer.Write(txtConteudo.Text);
                }

                FileInfo file = new FileInfo(path);
                Text = Application.ProductName + " - " + file.Name;
                Gerenciador.setFileSettings(file);

                mArquivoSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: \n" + ex.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;
        }

        #endregion
        #region Menu Editar
        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (index == txtConteudo.Text.Length)
            {
                txtConteudo.Text += dataHora;
                index += dataHora.Length;
                return;
            }

            string aux = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == index)
                {
                    aux += dataHora;
                }
                aux += txtConteudo.Text[i];
            }
            txtConteudo.Text = aux;
        }
        #endregion
        #region Menu Formatar
        private void mFormatLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatLinha.Checked;
        }

        private void mFormatFonte_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            //habilita as opções
            font.ShowColor = true;
            font.ShowEffects = true;

            font.Font = txtConteudo.Font;
            font.Color = txtConteudo.ForeColor;
            if (font.ShowDialog() == DialogResult.OK)
            {
                txtConteudo.Font = font.Font;
                txtConteudo.ForeColor = font.Color;
            }
        }
        #endregion
        #region Menu Exibir
        private void changeZoomText(float zoom)
        {
            statusBarLabel.Text = Math.Round(zoom).ToString() + " %";
        }

        private void mExibirZoomAmpliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            changeZoomText(txtConteudo.ZoomFactor * 100);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            changeZoomText(txtConteudo.ZoomFactor * 100);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
            changeZoomText(txtConteudo.ZoomFactor * 100);
        }

        private void mExibirStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirStatus.Checked;
        }
        #endregion
        #region Menu Ajuda
        private void mAjudaExibir_Click(object sender, EventArgs e)
        {
            FormAjuda f = new FormAjuda();
            f.Show();
        }

        private void mAjudaSobre_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.Show();
        }
        #endregion
        #region Menu Avançado
        private void monitorarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isAdmin = VerifyAdmin();

            if (isAdmin == false)
            {
                MessageBox.Show("Necessário iniciar como administrador.", "Aviso");
                return;
            }

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir...";
            open.Filter = "todos|*.*|txt|*.txt|pdf|*.pdf|rich text file|*.rtf";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(open.FileName))
                {
                    FileInfo fi = new (open.FileName);

                    FormMonitoramento f = new (fi.FullName);
                    f.Show();
                }
            }
        }


        private static bool VerifyAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new (identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        #endregion

    }
}