using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoldersCompare
{
    public partial class frmMain : Form
    {
        int countArquivosFaltantesDireita = 0;
        int countArquivosFaltantesEsquerda = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Eventos


        private void frmMain_Load(object sender, EventArgs e)
        {
            //limpa campos
            lblArquivosFaltantesEsquerdaDireita.Text = "";
            lblArquivosFaltantesDireitaEsquerda.Text = "";            
        }

        /// <summary>
        /// Evento botão seleciona Path na esquerda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                if (folderBrowserDialog1.SelectedPath != null)
                {
                    txtPathEsquerda.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Evento botão seleciona Path na direita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDireita_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                if (folderBrowserDialog1.SelectedPath != null)
                {
                    txtPathDireira.Text = folderBrowserDialog1.SelectedPath;
                }
            }            
        }

        /// <summary>
        /// Evento botão comparar da esquerda para direita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompareEsquerdaDireita_Click(object sender, EventArgs e)
        {
            //limpa campos
            lblArquivosFaltantesEsquerdaDireita.Text = "";
            lblArquivosFaltantesDireitaEsquerda.Text = "";
            countArquivosFaltantesDireita = 0;
            countArquivosFaltantesEsquerda = 0;

            CompareEsquerdaDireita(txtPathEsquerda.Text, txtPathDireira.Text);
        }

        /// <summary>
        /// Evento botão comparar da direita para esquerda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompareDireitaEsquerda_Click(object sender, EventArgs e)
        {
            //limpa campos
            lblArquivosFaltantesEsquerdaDireita.Text = "";
            lblArquivosFaltantesDireitaEsquerda.Text = "";
            countArquivosFaltantesDireita = 0;
            countArquivosFaltantesEsquerda = 0;

            CompareDireitaEsquerda(txtPathEsquerda.Text, txtPathDireira.Text);
        }


        #endregion

        #region Métodos

        /// <summary>
        /// Método compara da esquerda para direita
        /// </summary>
        /// <param name="pathEsquerda">localizacao dos arquivos da esquerda</param>
        /// <param name="pathDireita">localizacao dos arquivos da direita</param>
        private void CompareEsquerdaDireita(string pathEsquerda, string pathDireita)
        {  
            listViewEsquerda.Clear();
            listViewDireita.Clear();

            PreencherListViewEsquerda(pathEsquerda);
            PreencherListViewDireita(pathDireita);

            //Comparação da esquerda para direita
            for (int i = 0; i < listViewEsquerda.Items.Count - 1; i++)
            {
                FileInfo fileEsquerda = new FileInfo(listViewEsquerda.Items[i].Text);
                bool contem = false;

                foreach (ListViewItem item in listViewDireita.Items)
                {
                    FileInfo fileDireita = new FileInfo(item.Text);

                    if (String.Equals(fileEsquerda.Name, fileDireita.Name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        contem = true;
                        break;
                    }
                }

                if (!contem)
                {
                    listViewEsquerda.Items[i].BackColor = Color.GreenYellow;
                    countArquivosFaltantesDireita ++;
                }
            }

            lblArquivosFaltantesEsquerdaDireita.Text = "Existem " + countArquivosFaltantesDireita + " arquivos a mais do que o lado direito.";
        }

        /// <summary>
        /// Método compara da direita para esquerda
        /// </summary>
        /// <param name="pathEsquerda">localizacao dos arquivos da esquerda</param>
        /// <param name="pathDireita">localizacao dos arquivos da direita</param>
        private void CompareDireitaEsquerda(string pathEsquerda, string pathDireita)
        {
            listViewEsquerda.Clear();
            listViewDireita.Clear();

            PreencherListViewEsquerda(pathEsquerda);

            PreencherListViewDireita(pathDireita);


            //Comparação da esquerda para direita
            for (int i = 0; i < listViewDireita.Items.Count - 1; i++)
            {
                FileInfo fileEsquerda = new FileInfo(listViewDireita.Items[i].Text);
                bool contem = false;

                foreach (ListViewItem item in listViewEsquerda.Items)
                {
                    FileInfo fileDireita = new FileInfo(item.Text);

                    if (String.Equals(fileDireita.Name, fileEsquerda.Name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        contem = true;
                        break;
                    }
                }

                if (!contem)
                {
                    listViewDireita.Items[i].BackColor = Color.GreenYellow;
                    countArquivosFaltantesEsquerda++;
                }
            }

            lblArquivosFaltantesDireitaEsquerda.Text = "Existem " + countArquivosFaltantesEsquerda + " arquivos a mais do que o lado esquerdo.";
        }

        /// <summary>
        /// Método preencher o listView da esquerda
        /// </summary>
        /// <param name="pathEsquerda">localizacao dos arquivos da esquerda</param>
        private void PreencherListViewEsquerda(string pathEsquerda)
        {
            string[] filePathsEsquerda;

            //verifica se o diretorio da esquerda existe
            if (Directory.Exists(pathEsquerda))
            {
                //pega a lista de arquivos e pastas
                filePathsEsquerda = Directory.GetFiles(pathEsquerda, "*.*", SearchOption.AllDirectories);
                Array.Sort(filePathsEsquerda);

                //informa a quantidade de arquivos
                lblQuantidadeItensEsquerda.Text = filePathsEsquerda.Count().ToString() + " arquivos listados.";

                //adiciona uma coluna na listview
                listViewEsquerda.View = View.Details;
                listViewEsquerda.Columns.Add("Arquivo", 800, HorizontalAlignment.Left);


                //percorre cada item e carrega no listbox
                foreach (string fileEsquerda in filePathsEsquerda)
                {
                    string file = fileEsquerda.Replace(pathEsquerda, "");
                    listViewEsquerda.Items.Add(file);
                }

            }
        }

        /// <summary>
        /// Método preencher o listView da direita
        /// </summary>
        /// <param name="pathDireita">localizacao dos arquivos da direita</param>
        private void PreencherListViewDireita(string pathDireita)
        {
            string[] filePathsDireita;

            //verifica se o diretorio da direita existe
            if (Directory.Exists(pathDireita))
            {
                //pega a lista de arquivos e pastas
                filePathsDireita = Directory.GetFiles(pathDireita, "*.*", SearchOption.AllDirectories);
                Array.Sort(filePathsDireita);

                //informa a quantidade de arquivos
                lblQuantidadeItensDireita.Text = filePathsDireita.Count().ToString() + " arquivos listados.";

                //adiciona uma coluna na listview
                listViewDireita.View = View.Details;
                listViewDireita.Columns.Add("Arquivo", 800, HorizontalAlignment.Left);

                //percorre cada item e carrega no listbox
                foreach (string fileDireita in filePathsDireita)
                {
                    string file = fileDireita.Replace(pathDireita, "");
                    listViewDireita.Items.Add(file);                    
                }
            }
        }


        #endregion

       
    }
}
