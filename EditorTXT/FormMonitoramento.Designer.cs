namespace EditorTXT
{
    partial class FormMonitoramento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtLog = new RichTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Monitorando: ";
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.Location = new Point(15, 75);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(655, 363);
            txtLog.TabIndex = 1;
            txtLog.Text = "Esperando...";
            txtLog.WordWrap = false;
            // 
            // FormMonitoramento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(txtLog);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "FormMonitoramento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMonitoramento";
            FormClosing += FormMonitoramento_FormClosing;
            Load += FormMonitoramento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RichTextBox txtLog;
    }
}