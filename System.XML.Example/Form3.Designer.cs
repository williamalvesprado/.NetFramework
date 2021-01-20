
namespace System.XML.Example
{
    partial class Form3
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
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox txtTelefone;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.Button btnSalvar;
        private Windows.Forms.ListBox listBox1;
        private Windows.Forms.Button btnDelete;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Panel pnlIncluir;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Button btnAlterar;
        private Windows.Forms.Label lblId;
    }
}