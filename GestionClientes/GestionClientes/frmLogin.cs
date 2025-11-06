namespace GestionClientes
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) { 
            string Usuario = txtUser.Text;
            string Password = txtPassword.Text;

                if (Usuario != string.Empty && Password != string.Empty)
                {
                    if (Usuario == "admin" && Password == "1234")
                    {
                        txtUser.Text = null;
                        txtPassword.Text = null;
                        frmPrincipal Formulario = new frmPrincipal();
                        Formulario.ShowDialog();
                    }
                    else { MessageBox.Show("Datos incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Por favor, complete los campos.", "ERROR", MessageBoxButtons.OK); }
        }
    }
    }
