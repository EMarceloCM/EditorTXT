namespace EditorTXT
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            menuBar = new MenuStrip();
            mArquivo = new ToolStripMenuItem();
            mArquivoNovo = new ToolStripMenuItem();
            mArquivoNovaJanela = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mArquivoAbrir = new ToolStripMenuItem();
            mArquivoSalvar = new ToolStripMenuItem();
            mArquivoSalvarComo = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mArquivoSair = new ToolStripMenuItem();
            mEditar = new ToolStripMenuItem();
            mEditarDesfazer = new ToolStripMenuItem();
            mEditarRefazer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mEditarRecortar = new ToolStripMenuItem();
            mEditarCopiar = new ToolStripMenuItem();
            mEditarColar = new ToolStripMenuItem();
            mEditarExcluir = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mEditarDataHora = new ToolStripMenuItem();
            mFormat = new ToolStripMenuItem();
            mFormatLinha = new ToolStripMenuItem();
            mFormatFonte = new ToolStripMenuItem();
            mExibir = new ToolStripMenuItem();
            mExibirZoom = new ToolStripMenuItem();
            mExibirZoomAmpliar = new ToolStripMenuItem();
            mExibirZoomReduzir = new ToolStripMenuItem();
            mExibirZoomRestaurar = new ToolStripMenuItem();
            mExibirStatus = new ToolStripMenuItem();
            mAvancado = new ToolStripMenuItem();
            mAvancadoMinotorar = new ToolStripMenuItem();
            mAjuda = new ToolStripMenuItem();
            mAjudaExibir = new ToolStripMenuItem();
            mAjudaSobre = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusBarLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolBarNovo = new ToolStripButton();
            toolBarAbrir = new ToolStripButton();
            toolBarSalvar = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolBarFonte = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolBarZoomMais = new ToolStripButton();
            toolBarZoomMenos = new ToolStripButton();
            toolBarZoom = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolBarAjuda = new ToolStripButton();
            txtConteudo = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            resources.ApplyResources(menuBar, "menuBar");
            menuBar.BackColor = SystemColors.ControlLight;
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { mArquivo, mEditar, mFormat, mExibir, mAvancado, mAjuda });
            menuBar.Name = "menuBar";
            // 
            // mArquivo
            // 
            resources.ApplyResources(mArquivo, "mArquivo");
            mArquivo.DropDownItems.AddRange(new ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            // 
            // mArquivoNovo
            // 
            resources.ApplyResources(mArquivoNovo, "mArquivoNovo");
            mArquivoNovo.Image = Properties.Resources.new_document;
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            resources.ApplyResources(mArquivoNovaJanela, "mArquivoNovaJanela");
            mArquivoNovaJanela.Image = Properties.Resources.add;
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mArquivoAbrir
            // 
            resources.ApplyResources(mArquivoAbrir, "mArquivoAbrir");
            mArquivoAbrir.Image = Properties.Resources.folder;
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mArquivoSalvar
            // 
            resources.ApplyResources(mArquivoSalvar, "mArquivoSalvar");
            mArquivoSalvar.Image = Properties.Resources.floppy_disk;
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            resources.ApplyResources(mArquivoSalvarComo, "mArquivoSalvarComo");
            mArquivoSalvarComo.Image = Properties.Resources.data_storage;
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // mArquivoSair
            // 
            resources.ApplyResources(mArquivoSair, "mArquivoSair");
            mArquivoSair.Image = Properties.Resources.logout;
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            resources.ApplyResources(mEditar, "mEditar");
            mEditar.DropDownItems.AddRange(new ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataHora });
            mEditar.Name = "mEditar";
            // 
            // mEditarDesfazer
            // 
            resources.ApplyResources(mEditarDesfazer, "mEditarDesfazer");
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.Click += mEditarDesfazer_Click;
            // 
            // mEditarRefazer
            // 
            resources.ApplyResources(mEditarRefazer, "mEditarRefazer");
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.Click += mEditarRefazer_Click;
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // mEditarRecortar
            // 
            resources.ApplyResources(mEditarRecortar, "mEditarRecortar");
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.Click += mEditarRecortar_Click;
            // 
            // mEditarCopiar
            // 
            resources.ApplyResources(mEditarCopiar, "mEditarCopiar");
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.Click += mEditarCopiar_Click;
            // 
            // mEditarColar
            // 
            resources.ApplyResources(mEditarColar, "mEditarColar");
            mEditarColar.Name = "mEditarColar";
            mEditarColar.Click += mEditarColar_Click;
            // 
            // mEditarExcluir
            // 
            resources.ApplyResources(mEditarExcluir, "mEditarExcluir");
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.Click += mEditarExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // mEditarDataHora
            // 
            resources.ApplyResources(mEditarDataHora, "mEditarDataHora");
            mEditarDataHora.Image = Properties.Resources.schedule;
            mEditarDataHora.Name = "mEditarDataHora";
            mEditarDataHora.Click += mEditarDataHora_Click;
            // 
            // mFormat
            // 
            resources.ApplyResources(mFormat, "mFormat");
            mFormat.DropDownItems.AddRange(new ToolStripItem[] { mFormatLinha, mFormatFonte });
            mFormat.Name = "mFormat";
            // 
            // mFormatLinha
            // 
            resources.ApplyResources(mFormatLinha, "mFormatLinha");
            mFormatLinha.CheckOnClick = true;
            mFormatLinha.Name = "mFormatLinha";
            mFormatLinha.Click += mFormatLinha_Click;
            // 
            // mFormatFonte
            // 
            resources.ApplyResources(mFormatFonte, "mFormatFonte");
            mFormatFonte.Name = "mFormatFonte";
            mFormatFonte.Click += mFormatFonte_Click;
            // 
            // mExibir
            // 
            resources.ApplyResources(mExibir, "mExibir");
            mExibir.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoom, mExibirStatus });
            mExibir.Name = "mExibir";
            // 
            // mExibirZoom
            // 
            resources.ApplyResources(mExibirZoom, "mExibirZoom");
            mExibirZoom.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
            mExibirZoom.Image = Properties.Resources.icons8_zoom_100;
            mExibirZoom.Name = "mExibirZoom";
            // 
            // mExibirZoomAmpliar
            // 
            resources.ApplyResources(mExibirZoomAmpliar, "mExibirZoomAmpliar");
            mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
            // 
            // mExibirZoomReduzir
            // 
            resources.ApplyResources(mExibirZoomReduzir, "mExibirZoomReduzir");
            mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
            // 
            // mExibirZoomRestaurar
            // 
            resources.ApplyResources(mExibirZoomRestaurar, "mExibirZoomRestaurar");
            mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            mExibirZoomRestaurar.Click += mExibirZoomRestaurar_Click;
            // 
            // mExibirStatus
            // 
            resources.ApplyResources(mExibirStatus, "mExibirStatus");
            mExibirStatus.Checked = true;
            mExibirStatus.CheckOnClick = true;
            mExibirStatus.CheckState = CheckState.Checked;
            mExibirStatus.Name = "mExibirStatus";
            mExibirStatus.Click += mExibirStatus_Click;
            // 
            // mAvancado
            // 
            resources.ApplyResources(mAvancado, "mAvancado");
            mAvancado.DropDownItems.AddRange(new ToolStripItem[] { mAvancadoMinotorar });
            mAvancado.Name = "mAvancado";
            // 
            // mAvancadoMinotorar
            // 
            resources.ApplyResources(mAvancadoMinotorar, "mAvancadoMinotorar");
            mAvancadoMinotorar.Name = "mAvancadoMinotorar";
            mAvancadoMinotorar.Click += monitorarArquivoToolStripMenuItem_Click;
            // 
            // mAjuda
            // 
            resources.ApplyResources(mAjuda, "mAjuda");
            mAjuda.DropDownItems.AddRange(new ToolStripItem[] { mAjudaExibir, mAjudaSobre });
            mAjuda.Name = "mAjuda";
            // 
            // mAjudaExibir
            // 
            resources.ApplyResources(mAjudaExibir, "mAjudaExibir");
            mAjudaExibir.Image = Properties.Resources.help_desk;
            mAjudaExibir.Name = "mAjudaExibir";
            mAjudaExibir.Click += mAjudaExibir_Click;
            // 
            // mAjudaSobre
            // 
            resources.ApplyResources(mAjudaSobre, "mAjudaSobre");
            mAjudaSobre.Image = Properties.Resources.info;
            mAjudaSobre.Name = "mAjudaSobre";
            mAjudaSobre.Click += mAjudaSobre_Click;
            // 
            // statusBar
            // 
            resources.ApplyResources(statusBar, "statusBar");
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
            statusBar.Name = "statusBar";
            // 
            // statusBarLabel
            // 
            resources.ApplyResources(statusBarLabel, "statusBarLabel");
            statusBarLabel.Name = "statusBarLabel";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBarNovo, toolBarAbrir, toolBarSalvar, toolStripSeparator7, toolBarFonte, toolStripSeparator5, toolBarZoomMais, toolBarZoomMenos, toolBarZoom, toolStripSeparator6, toolBarAjuda });
            toolStrip1.Name = "toolStrip1";
            // 
            // toolBarNovo
            // 
            resources.ApplyResources(toolBarNovo, "toolBarNovo");
            toolBarNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarNovo.Image = Properties.Resources.new_document;
            toolBarNovo.Name = "toolBarNovo";
            toolBarNovo.Click += mArquivoNovo_Click;
            // 
            // toolBarAbrir
            // 
            resources.ApplyResources(toolBarAbrir, "toolBarAbrir");
            toolBarAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarAbrir.Image = Properties.Resources.folder;
            toolBarAbrir.Name = "toolBarAbrir";
            toolBarAbrir.Click += mArquivoAbrir_Click;
            // 
            // toolBarSalvar
            // 
            resources.ApplyResources(toolBarSalvar, "toolBarSalvar");
            toolBarSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarSalvar.Image = Properties.Resources.floppy_disk;
            toolBarSalvar.Name = "toolBarSalvar";
            toolBarSalvar.Click += mArquivoSalvar_Click;
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(toolStripSeparator7, "toolStripSeparator7");
            toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // toolBarFonte
            // 
            resources.ApplyResources(toolBarFonte, "toolBarFonte");
            toolBarFonte.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolBarFonte.Name = "toolBarFonte";
            toolBarFonte.Click += mFormatFonte_Click;
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolBarZoomMais
            // 
            resources.ApplyResources(toolBarZoomMais, "toolBarZoomMais");
            toolBarZoomMais.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarZoomMais.Image = Properties.Resources.magnifying_glass__1_;
            toolBarZoomMais.Name = "toolBarZoomMais";
            toolBarZoomMais.Click += mExibirZoomAmpliar_Click;
            // 
            // toolBarZoomMenos
            // 
            resources.ApplyResources(toolBarZoomMenos, "toolBarZoomMenos");
            toolBarZoomMenos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarZoomMenos.Image = Properties.Resources.magnifying_glass;
            toolBarZoomMenos.Name = "toolBarZoomMenos";
            toolBarZoomMenos.Click += mExibirZoomReduzir_Click;
            // 
            // toolBarZoom
            // 
            resources.ApplyResources(toolBarZoom, "toolBarZoom");
            toolBarZoom.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarZoom.Image = Properties.Resources.loupe;
            toolBarZoom.Name = "toolBarZoom";
            toolBarZoom.Click += mExibirZoomRestaurar_Click;
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // toolBarAjuda
            // 
            resources.ApplyResources(toolBarAjuda, "toolBarAjuda");
            toolBarAjuda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarAjuda.Image = Properties.Resources.help_desk;
            toolBarAjuda.Name = "toolBarAjuda";
            toolBarAjuda.Click += mAjudaExibir_Click;
            // 
            // txtConteudo
            // 
            resources.ApplyResources(txtConteudo, "txtConteudo");
            txtConteudo.Name = "txtConteudo";
            txtConteudo.TextChanged += txtConteudo_TextChanged;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtConteudo);
            Controls.Add(toolStrip1);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "mainForm";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormat;
        private ToolStripMenuItem mFormatLinha;
        private ToolStripMenuItem mFormatFonte;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirStatus;
        private ToolStripMenuItem mAjuda;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataHora;
        private ToolStripMenuItem mAjudaExibir;
        private ToolStripMenuItem mAjudaSobre;
        private ToolStripMenuItem mExibirZoomAmpliar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBarNovo;
        private ToolStripButton toolBarAbrir;
        private ToolStripButton toolBarSalvar;
        private ToolStripButton toolBarFonte;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolBarZoomMais;
        private ToolStripButton toolBarZoomMenos;
        private ToolStripButton toolBarZoom;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolBarAjuda;
        private RichTextBox txtConteudo;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem mAvancado;
        public ToolStripMenuItem mAvancadoMinotorar;
    }
}