namespace FoldersCompare
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewDireita = new System.Windows.Forms.ListView();
            this.listViewEsquerda = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArquivosFaltantesDireitaEsquerda = new System.Windows.Forms.Label();
            this.lblArquivosFaltantesEsquerdaDireita = new System.Windows.Forms.Label();
            this.btnCompareDireitaEsquerda = new System.Windows.Forms.Button();
            this.lblQuantidadeItensDireita = new System.Windows.Forms.Label();
            this.lblQuantidadeItensEsquerda = new System.Windows.Forms.Label();
            this.btnCompareEsquerdaDireita = new System.Windows.Forms.Button();
            this.txtPathDireira = new System.Windows.Forms.TextBox();
            this.txtPathEsquerda = new System.Windows.Forms.TextBox();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDireita
            // 
            this.listViewDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDireita.Location = new System.Drawing.Point(0, 0);
            this.listViewDireita.Name = "listViewDireita";
            this.listViewDireita.Size = new System.Drawing.Size(692, 659);
            this.listViewDireita.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewDireita.TabIndex = 0;
            this.listViewDireita.UseCompatibleStateImageBehavior = false;
            this.listViewDireita.View = System.Windows.Forms.View.List;
            // 
            // listViewEsquerda
            // 
            this.listViewEsquerda.AutoArrange = false;
            this.listViewEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEsquerda.GridLines = true;
            this.listViewEsquerda.Location = new System.Drawing.Point(0, 0);
            this.listViewEsquerda.Name = "listViewEsquerda";
            this.listViewEsquerda.Size = new System.Drawing.Size(681, 659);
            this.listViewEsquerda.TabIndex = 0;
            this.listViewEsquerda.UseCompatibleStateImageBehavior = false;
            this.listViewEsquerda.View = System.Windows.Forms.View.List;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewEsquerda);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewDireita);
            this.splitContainer1.Size = new System.Drawing.Size(1377, 659);
            this.splitContainer1.SplitterDistance = 681;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblArquivosFaltantesDireitaEsquerda);
            this.panel1.Controls.Add(this.lblArquivosFaltantesEsquerdaDireita);
            this.panel1.Controls.Add(this.btnCompareDireitaEsquerda);
            this.panel1.Controls.Add(this.lblQuantidadeItensDireita);
            this.panel1.Controls.Add(this.lblQuantidadeItensEsquerda);
            this.panel1.Controls.Add(this.btnCompareEsquerdaDireita);
            this.panel1.Controls.Add(this.txtPathDireira);
            this.panel1.Controls.Add(this.txtPathEsquerda);
            this.panel1.Controls.Add(this.btnEsquerda);
            this.panel1.Controls.Add(this.btnDireita);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 75);
            this.panel1.TabIndex = 8;
            // 
            // lblArquivosFaltantesDireitaEsquerda
            // 
            this.lblArquivosFaltantesDireitaEsquerda.AutoSize = true;
            this.lblArquivosFaltantesDireitaEsquerda.Location = new System.Drawing.Point(882, 31);
            this.lblArquivosFaltantesDireitaEsquerda.Name = "lblArquivosFaltantesDireitaEsquerda";
            this.lblArquivosFaltantesDireitaEsquerda.Size = new System.Drawing.Size(89, 13);
            this.lblArquivosFaltantesDireitaEsquerda.TabIndex = 29;
            this.lblArquivosFaltantesDireitaEsquerda.Text = "Arquivos listados.";
            // 
            // lblArquivosFaltantesEsquerdaDireita
            // 
            this.lblArquivosFaltantesEsquerdaDireita.AutoSize = true;
            this.lblArquivosFaltantesEsquerdaDireita.Location = new System.Drawing.Point(245, 31);
            this.lblArquivosFaltantesEsquerdaDireita.Name = "lblArquivosFaltantesEsquerdaDireita";
            this.lblArquivosFaltantesEsquerdaDireita.Size = new System.Drawing.Size(89, 13);
            this.lblArquivosFaltantesEsquerdaDireita.TabIndex = 28;
            this.lblArquivosFaltantesEsquerdaDireita.Text = "Arquivos listados.";
            // 
            // btnCompareDireitaEsquerda
            // 
            this.btnCompareDireitaEsquerda.Location = new System.Drawing.Point(705, 3);
            this.btnCompareDireitaEsquerda.Name = "btnCompareDireitaEsquerda";
            this.btnCompareDireitaEsquerda.Size = new System.Drawing.Size(98, 25);
            this.btnCompareDireitaEsquerda.TabIndex = 27;
            this.btnCompareDireitaEsquerda.Text = "<--  Compare ";
            this.btnCompareDireitaEsquerda.UseVisualStyleBackColor = true;
            this.btnCompareDireitaEsquerda.Click += new System.EventHandler(this.btnCompareDireitaEsquerda_Click);
            // 
            // lblQuantidadeItensDireita
            // 
            this.lblQuantidadeItensDireita.AutoSize = true;
            this.lblQuantidadeItensDireita.Location = new System.Drawing.Point(1205, 31);
            this.lblQuantidadeItensDireita.Name = "lblQuantidadeItensDireita";
            this.lblQuantidadeItensDireita.Size = new System.Drawing.Size(89, 13);
            this.lblQuantidadeItensDireita.TabIndex = 26;
            this.lblQuantidadeItensDireita.Text = "Arquivos listados.";
            // 
            // lblQuantidadeItensEsquerda
            // 
            this.lblQuantidadeItensEsquerda.AutoSize = true;
            this.lblQuantidadeItensEsquerda.Location = new System.Drawing.Point(1, 31);
            this.lblQuantidadeItensEsquerda.Name = "lblQuantidadeItensEsquerda";
            this.lblQuantidadeItensEsquerda.Size = new System.Drawing.Size(89, 13);
            this.lblQuantidadeItensEsquerda.TabIndex = 25;
            this.lblQuantidadeItensEsquerda.Text = "Arquivos listados.";
            // 
            // btnCompareEsquerdaDireita
            // 
            this.btnCompareEsquerdaDireita.Location = new System.Drawing.Point(543, 3);
            this.btnCompareEsquerdaDireita.Name = "btnCompareEsquerdaDireita";
            this.btnCompareEsquerdaDireita.Size = new System.Drawing.Size(98, 25);
            this.btnCompareEsquerdaDireita.TabIndex = 24;
            this.btnCompareEsquerdaDireita.Text = "Compare  -->";
            this.btnCompareEsquerdaDireita.UseVisualStyleBackColor = true;
            this.btnCompareEsquerdaDireita.Click += new System.EventHandler(this.btnCompareEsquerdaDireita_Click);
            // 
            // txtPathDireira
            // 
            this.txtPathDireira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPathDireira.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtPathDireira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathDireira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathDireira.Location = new System.Drawing.Point(685, 49);
            this.txtPathDireira.Name = "txtPathDireira";
            this.txtPathDireira.Size = new System.Drawing.Size(653, 21);
            this.txtPathDireira.TabIndex = 23;
            // 
            // txtPathEsquerda
            // 
            this.txtPathEsquerda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPathEsquerda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtPathEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathEsquerda.Location = new System.Drawing.Point(0, 50);
            this.txtPathEsquerda.Name = "txtPathEsquerda";
            this.txtPathEsquerda.Size = new System.Drawing.Size(641, 21);
            this.txtPathEsquerda.TabIndex = 22;
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(640, 49);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(42, 23);
            this.btnEsquerda.TabIndex = 21;
            this.btnEsquerda.Text = "...";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(1337, 48);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(40, 23);
            this.btnDireita.TabIndex = 20;
            this.btnDireita.Text = "...";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Compare";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView listViewDireita;
        private System.Windows.Forms.ListView listViewEsquerda;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompareDireitaEsquerda;
        private System.Windows.Forms.Label lblQuantidadeItensDireita;
        private System.Windows.Forms.Label lblQuantidadeItensEsquerda;
        private System.Windows.Forms.Button btnCompareEsquerdaDireita;
        private System.Windows.Forms.TextBox txtPathDireira;
        private System.Windows.Forms.TextBox txtPathEsquerda;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Label lblArquivosFaltantesDireitaEsquerda;
        private System.Windows.Forms.Label lblArquivosFaltantesEsquerdaDireita;
    }
}

