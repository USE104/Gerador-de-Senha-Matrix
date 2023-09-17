using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geradorador_de_Senha
{
    public partial class frmgeradorSenha : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmgeradorSenha()
        {
            InitializeComponent();
        }

        private void frmgeradorSenha_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }


        public string GerarSenhas()
        {
            int Tamanho = 22;
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 01 && codigo <= 90) || (codigo >= 100 && codigo <= 110))

                {

                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Não é possivel limpar campos vázios", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                txtSenha.Clear();
            }


        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Não é possivel copiar campos vázios", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtSenha.SelectAll();
                txtSenha.Copy();
            }
        }



        private void btngerarSenha_Click_1(object sender, EventArgs e)
        {
            string senha = GerarSenhas();
            txtSenha.Text = senha;
            cboSenha.Text = "";
            cboSenha.Items.Add(txtSenha.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmar o encerramento do Gerador de Senha", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)

            {

                MessageBox.Show("O Gerador está sendo encerrado", "Mensagem do Sistema");
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Fechamento de janela cancelado", "Mensagem do Sistema");
            }

            }

            private void txtSenha_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboSenha.Items.Add(txtSenha);
                }
            }

            private void chkHistoricodeSenha_CheckedChanged_1(object sender, EventArgs e)
            {
                if (chkHistoricodeSenha.Checked)
                {
                    chkHistoricodeSenha.Text = "Habilitar";
                    cboSenha.Visible = false;

                }
                else
                {
                    cboSenha.Visible = true;
                    chkHistoricodeSenha.Text = "Desabilitar";
                }
            }

            private void chkPasswordChar_CheckedChanged(object sender, EventArgs e)
            {
                if (chkPasswordChar.Checked)
                {
                    chkPasswordChar.Text = ("Desabilitar");
                    txtSenha.PasswordChar = '*';
                    // MessageBox.Show("Atenção Somente o campo que a senha é gerada que será ocultada. Por segurança, ao fazer uso oculte o campo de Histórico de Senha", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    txtSenha.PasswordChar = (char)0;
                    chkPasswordChar.Text = ("Habilitar");

                }
            }


            private void cboSenha_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }
        }

    }

