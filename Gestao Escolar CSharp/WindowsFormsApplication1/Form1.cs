using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGE_em_CSharp_fx_06_018.Bag_frms;


namespace SGE_em_CSharp_fx_06_018
{
    public partial class frmAluno : Form
    {
        public String validaData(String dt)
        {
         int anoActual = 2018;
         int anoMinimo = 1985;
            String valido = null;
            int d, m, a;

            if (dt.Length == 10)
            {
                    d = int.Parse(dt.Substring(0, 2) );  

                    m = int.Parse(dt.Substring(3, 2));  
                    a = int.Parse(dt.Substring(6, 4));


                    if (a >= anoMinimo && a < anoActual - 11)
                    {

                        if (m >= 0 && m <= 12)
                        {
                            if (d > 0 && d < 32)
                            {
                                switch (m)
                                {
                                    case 4:
                                    case 6:
                                    case 9:
                                    case 11:
                                        if (d < 31)
                                        {
                                            valido = dt;
                                        }
                                        else
                                        {
                                            valido = ("Mes ivalido.  O mes de " + m + " nao tem [31 dias]");
                                        }
                                        break;
                                    case 2:
                                        if (a % 2 == 0 && d > 28)
                                        {
                                            valido = ("Dia e mes ivalido. " + d + "/02/" + a + ", nao e verdade.");
                                        }
                                        else if (a % 2 == 1 && d > 29)
                                        {
                                            valido = ("Dia e mes ivalido. " + d + "/02/" + a + ", nao e verdade.");
                                        }
                                        else
                                        {
                                            valido = dt;
                                        }
                                        break;
                                    default:
                                        valido = dt;
                                        break;
                                }
                            }
                            else
                            {
                                valido = (" Dia ivalido ('" + d+ "')! Fora dos parametros!");
                            }
                        }
                        else
                        {
                            valido = (" Mes ivalido ('" + m + "')!Deve estar entre: [ 01 - 12 ]");
                        }
                    }
                    else
                    {
                        valido = (" Ano ivalido ('" + a + "')! Deve estar entre: [ 1985 - " + (anoActual - 11) + " ] " + a);
                    }
            }
            else
            {
                valido = "Data ivalida. Deve ter o modelo: [ aa-mm-aaaa ]";
            }
            return valido;
        }

        public frmAluno()
        {
            InitializeComponent();
            pnl_do_fundo.Enabled = false;
            pnl_btnMenu1.Enabled = false;
            pnl_btnsMatricNovIng.Enabled = false;

            cbos_Inicializacao();
            limpaCamposDeRequisitos();
            limpaCamposDeDadosPessoais();

            txtLogin.Text = "fx";
        }

        private void cbos_Inicializacao()
        {//DIA
            for (int i = 1; i < 32; i++)
            {
                if (i < 10)
                {
                    cboDiaConc.Items.Add("0" + i);
                    cboDiaNasc.Items.Add("0" + i);
                }
                else
                {
                    cboDiaConc.Items.Add("" + i);
                    cboDiaNasc.Items.Add("" + i);
                }
            }
            //MES
            for (int i = 1; i < 13; i++)
            {
                if (i < 10)
                {
                    cboMesConc.Items.Add("0" + i);
                    cboMesNasc.Items.Add("0" + i);
                }
                else
                {
                    cboMesConc.Items.Add("" + i);
                    cboMesNasc.Items.Add("" + i);
                }
            }
            //ANO
            for (int i = 2018; i >1984; i--)
            {
                    cboAnoConc.Items.Add("" + i);
                    cboAnoNasc.Items.Add("" + i);
            }

            cboClasse.Items.Add("8");
            cboClasse.Items.Add("9");
            cboClasse.Items.Add("10");
            cboClasse.Items.Add("11");
            cboClasse.Items.Add("12");


            cboEstCivil.Items.Add("Solteiro");
            cboEstCivil.Items.Add("Casado");
            cboEstCivil.Items.Add("Divorciado");
            cboEstCivil.Items.Add("Viuvo");

            cboTipoDoc.Items.Add("BI");
            cboTipoDoc.Items.Add("DIRE");
            cboTipoDoc.Items.Add("CEDULA");
            cboTipoDoc.Items.Add("CARTA DE COND");
            cboTipoDoc.Items.Add("CART. ELEITOR");
            cboTipoDoc.Items.Add("PASSAPORTE");

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            grbDadosPessNovIng.Enabled = false;
            if (txtLogin.Text == "fx")
            {
                pnl_do_fundo.Enabled = true;
                pnl_btnMenu1.Enabled = true;
                pnl_Autenticacao.Visible = false;
                btnSair.Text = "INICIO";
                lblErroSENHA.Text = "[   Senha invalida!   ]";
                lblErrosGerais.Text = "[   Senha aceite!   ]";
            }
            else
            {
                lblErroSENHA.Text = "[   Senha invalida!   ]";
                pnl_do_fundo.Enabled = false;
                pnl_btnMenu1.Enabled = false;
                btnSair.Text = "SAIR";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            //SAIR
            if (btnSair.Text!="SAIR")
            {
                grbDadosPessNovIng.Enabled = false;
                btnSair.Text = "SAIR";

                lblErroSENHA.Text = "[   --   ]";
                lblErrosGerais.Text = "-";

                pnl_Autenticacao.Visible = true;
                pnl_do_fundo.Enabled = false;
                pnl_btnMenu1.Enabled = false;
            }
            else
            {
                Close();
            }
        }

        private void btnConfirRequisitos_Click(object sender, EventArgs e)
        {
            if (txtEscAnt.Text != "" && txtValMatric.Text != "" && txtValProp.Text != "")
            {
                string avanco = validaData(cboDiaConc.Text + "-" + cboMesConc.Text + "-" + cboAnoConc.Text);

                if (avanco.Length == 10)
                {
                    grbDadosPessNovIng.Enabled = true;
                    pnl_btnsMatricNovIng.Enabled = true;
                    pnlRequisitosNovIng.Enabled = false;
                    lblErrosGerais.Text = "Area de textos de apoio!";
                }
                else
                {
                    lblErrosGerais.Text = "Erro: " + avanco;
                }
            }
            else
            {
                lblErrosGerais.Text = "Erro: Algum campo de requisitos vazio!";
            }
        }

        List<Aluno> lista_al = new List<Aluno>() { };
        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtApelido.Text != "" && txtContacto.Text != ""
                && txtEmail.Text != "" && txtCodDoc.Text != "")
            {
                string avanco = validaData(cboDiaNasc.Text + "-" + cboMesNasc.Text + "-" + cboAnoNasc.Text);

                if (avanco.Length == 10)
                {
                    lista_al.Add(gravaAluno());
                //    MessageBox.Show(lista_al.ToString);
                    adicionaNaLista();

                    pnlRequisitosNovIng.Enabled = true;
                    grbDadosPessNovIng.Enabled = false;
                    pnl_btnsMatricNovIng.Enabled = false; 

                    limpaCamposDeDadosPessoais();
                    limpaCamposDeRequisitos();
                    lblErrosGerais.Text = "Area de textos de apoio!";
                }
                else
                {
                    lblErrosGerais.Text = "Erro: " + avanco;
                }
            }
            else
            {
                lblErrosGerais.Text = "Erro: Algum campo de dados vazio!";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblErrosGerais.Text = "";
            for (int i = btnProfs.Text.Length - 1; i >= 0; i-- )
            { lblErrosGerais.Text += btnProfs.Text.Substring(i, 1);

            }
            /*
            limpaCamposDeRequisitos();
            limpaCamposDeDadosPessoais();
            pnlRequisitosNovIng.Enabled = true;
            grbDadosPessNovIng.Enabled = false;
            pnl_btnsMatricNovIng.Enabled = false;*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCamposDeDadosPessoais();
        }

        private void limpaCamposDeRequisitos()
        {
            cboClasse.Text = "8";
            txtEscAnt.Text = "";
            cboDiaConc.Text = "01";
            cboMesConc.Text = "01";
            cboAnoConc.Text = "2005";
            txtMedFinal.Text = "0.0";
            txtValMatric.Text = "0.0";
            txtValProp.Text = "0.0";


        }

        private void limpaCamposDeDadosPessoais()
        {
            txtNome.Text = "";
            txtApelido.Text = "";
            rdoM.Checked = true;
            rdoF.Checked = false;
            cboEstCivil.Text = "Solteiro";
            txtContacto.Text = "";
            txtEmail.Text = "";
            cboDiaNasc.Text = "01";
            cboMesNasc.Text = "01";
            cboAnoNasc.Text = "2005";
            cboTipoDoc.Text = "BI";
            txtCodDoc.Text = "";
        }
        Aluno al;
        private Aluno gravaAluno()
        {
            al = new Aluno();

            al.classeAnterior= cboClasse.Text;
            al.NomeDaEscolaDaClasseAnterior = txtEscAnt.Text;
           al.anoDeConclusaoDaClasseAnterior= cboDiaConc.Text+"-"+cboMesConc.Text+"-"+cboAnoConc.Text;
           al.mediaDaClasseAnterior=double.Parse( txtMedFinal.Text);
           al.nrDePropinasPagas+=1;

           al.nome= txtNome.Text;
           al.apelido= txtApelido.Text;           
            if (rdoM.Checked == true)
            {
                al.sexo="M";
            }
            else
            {
                al.sexo="F";
            }
           al.estCivil= cboEstCivil.Text;
           al.contacto= txtContacto.Text;
           al.email= txtEmail.Text;
           al.dataNasc= cboDiaNasc.Text+"-"+cboMesNasc.Text+"-"+cboAnoNasc.Text;
           al.tipoDeDoc= cboTipoDoc.Text;
           al.codidoDoDoc= txtCodDoc.Text;
            return al;
        }
        int id = 1;
        private void adicionaNaLista()
        {
            ListViewItem lista = new ListViewItem("" + id);
            if (id < 10)
            {
                lista.SubItems.Add("AL0" + id);
            }
            else
            {
                lista.SubItems.Add("AL" + id);
            }
            lista.SubItems.Add(txtNome.Text);
            lista.SubItems.Add(txtApelido.Text);

            if (rdoM.Checked == true)
            {
                lista.SubItems.Add("M");
            }
            else
            {
                lista.SubItems.Add("F");
            }
            lista.SubItems.Add(cboEstCivil.Text);
            lista.SubItems.Add(txtContacto.Text);
            lista.SubItems.Add(txtEmail.Text);
            lista.SubItems.Add(cboClasse.Text);
            lista.SubItems.Add(cboDiaConc.Text + "-" + cboMesConc.Text + "-" + cboAnoConc.Text);

            lstvIngresso.Items.Add(lista);
            id++;
        }









        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlDadosNovIng_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMedFinal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGestao_Click(object sender, EventArgs e)
        {
           /*
             * adicionar componentes nas CBOs
             * Definir valores de matriculas e propinas
             * definir parametros de faltas
             * definir turmas e turnos
             * Outros
             * Notas, faltas, presensas, comportamento
             * Transferencias
             * 
             * Pagamentos
             */


            Jogo_fx frmMv = new Jogo_fx();
            // this.Dispose();
          //  frmMv.ShowDialog();
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            //Relatorios de alunos por:
            /*
             * - Dispensados
             * -Admitidos
             * Aprovados
             * Excluidos
             * Chumbados
             * 
             * valores Matriculas
             * valores outros
             * valores Propinas
             
             */
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
          
        }
        int s = 0;
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
          //  txtLogin.Text +=""+ s/2;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            //frmMover frmMv = new frmMover();
           // this.Dispose();
           // frmMv.ShowDialog();
        }

        private void btnNovoIng_Click(object sender, EventArgs e)
        {

        }

    }
}
