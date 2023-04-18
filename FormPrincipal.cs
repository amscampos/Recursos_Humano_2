namespace Recursos_Humanos_2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            //minimizarSubMenu();
        }

        /*
        //Minimiza os submenus...
        private void minimizarSubMenu()
        {
            panelgerenciamentoSubMenu.Visible = false;
            panelrelatoriosSubMenu.Visible = false;
            panelteste01SubMenu.Visible = false;
            //Colocar aqui os submenus...
        }

        */

        //Esconde os submenus
        private void esconderSubMenu()
        {
            if (panelgerenciamentoSubMenu.Visible == true)
                // panelgerenciamentoSubMenu.Visible = false;
                if (panelrelatoriosSubMenu.Visible == true)
                    // panelrelatoriosSubMenu.Visible = false;
                    if (panelteste01SubMenu.Visible == true) ;
            // panelteste01SubMenu.Visible = false;
            //Colocar aqui os submenus...
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        //-------------------------------------Começo do submenu gerenciamento---------------------------
        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelgerenciamentoSubMenu);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormCadastro());
            //ActiveButton(btnCadastro);
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormAlterarCadastro());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormPesquisar());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormCargos());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormDeletarFuncionario());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }
        //-------------------------------------Fim do submenu gerenciamento--------------------------

        //-------------------------------------Começo do submenu relatorio---------------------------
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelrelatoriosSubMenu);
        }

        private void btnCalculoPagamento_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormCalculoPagamento());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnFolhaNormal_Click_1(object sender, EventArgs e)
        {
            abrirFormFilho(new FormFolhaNormal());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnFolhaDetalhada_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormFolhaDetalhada());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            abrirFormFilho(new FormHolerite());
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        //-------------------------------------Fim do submenu relatorio--------------------------

        //-------------------------------------Começo do submenu teste01-------------------------
        private void btnteste01_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelteste01SubMenu);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //códigos
            //códigos
            //códigos
            esconderSubMenu();
        }
        //-------------------------------------Fim do submenu teste01--------------------------

        private Form formAtivo = null;
        private void abrirFormFilho(Form formFilho)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelFormFilho.Controls.Add(formFilho);
            panelFormFilho.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
        }

        /*
        // Esse bloco mudaria a cor do botão selecionado no submenu e deixaria estática.
        private void ActiveButton(Button formFilho)
        {   
            int[] teste = new int[3] { 65, 105, 225 };

            foreach (Control ctrl in panelmenuLateral.Controls)
            {
                ctrl.ForeColor = Color.Black;
                ctrl.BackColor = Color.CornflowerBlue;
                formAtivo.ForeColor = Color.Cyan;
                formAtivo.BackColor = Color.FromArgb(teste[0], teste[1], teste[2]);
            }
        }
        */

    }
}