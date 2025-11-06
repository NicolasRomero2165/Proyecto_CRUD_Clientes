using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) //Botón de cerrar sesión
        {
            {
                DialogResult result = MessageBox.Show("¿Cerrar sesión?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { Close(); }
            }
        }
        public void ActualizarLista()
        {
            dgvClientes.DataSource = string.Empty;
            dgvClientes.DataSource = ListaCliente;
        }
        public void AmpliarLista()
        {
            gbxAltaCliente.Visible = false;
            dgvClientes.Width = 945;
            dgvClientes.Location = new Point(12, 27);
            btnArgentina.Visible = false;
        }

        public void AchicarLista()
        {
            gbxAltaCliente.Visible = true;
            dgvClientes.Width = 625;
            dgvClientes.Location = new Point(332, 27);
            btnArgentina.Visible = true;
        }

        public void Limpiar() //Limpia los campos
        {
            mtbCuit.Text = null;
            txtRazonSocial.Text = null;
            mtbTelefono.Text = null;
            cbxProvincia.Text = null;
            cbxLocalidad.Text = null;
            txtCalle.Text = null;
            cbxLocalidad.Enabled = false;
        }
        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e) //Abre el menú para ingresar los datos del cliente nuevo a registrar
        {
            if (gbxAltaCliente.Visible == false)
            {
                AchicarLista();
                Limpiar();
                gbxAltaCliente.Text = "Alta Cliente";
                btnRegistrar.Visible = true;
                btnModificarOk.Visible = false;
            }
            else
            {
                AmpliarLista();
                ActualizarLista();
            }
        }

        List<Cliente> ListaCliente = new List<Cliente>(); //Objeto Lista
        private void frmPrincipal_Load(object sender, EventArgs e) //Carga de datos al DGV
        {
            Cliente objCliente1 = new Cliente("30-74155478-3", "Cancha de Ferro", "1164377510", "GBA Sur", "Lanús", "Bv de los Italianos 3001");
            ListaCliente.Add(objCliente1);
            Cliente objCliente2 = new Cliente("27-41147351-6", "Trompix", "1147330147", "CABA", "Capital Federal", "Gral. Rodriguez 324");
            ListaCliente.Add(objCliente2);
            Cliente objCliente3 = new Cliente("20-44773512-5", "Sorny", "2118743400", "Catamarca", "San Fernando del Valle de Catamarca", "Itahualpi 7709");
            ListaCliente.Add(objCliente3);
            Cliente objCliente4 = new Cliente("40-47713547-1", "Plalladito", "3477014876", "Corrientes", "Goya", "Mendez 745");
            ListaCliente.Add(objCliente4);
            Cliente objCliente5 = new Cliente("34-44798144-5", "Fillips", "2177843044", "Catamarca", "Valle Viejo", "Camchaka 3347");
            ListaCliente.Add(objCliente5);
            Cliente objCliente6 = new Cliente("15-24478941-3", "Kilmes", "1164774101", "GBA Sur", "Quilmes", "Rodolfo López 815");
            ListaCliente.Add(objCliente6);
            Cliente objCliente7 = new Cliente("37-39874113-2", "CompuProvincia", "1174134786", "CABA", "Capital Federal", "Gral. Rodriguez 6678");
            ListaCliente.Add(objCliente7);
            Cliente objCliente8 = new Cliente("14-33214784-7", "Lenobo", "1164771047", "CABA", "Capital Federal", "Venezuela 7514");
            ListaCliente.Add(objCliente8);
            Cliente objCliente9 = new Cliente("61-74881473-5", "Jasbro", "1120201478", "GBA Sur", "Avellaneda", "Combate Los Pozos 357");
            ListaCliente.Add(objCliente9);
            Cliente objCliente10 = new Cliente("35-11473214-4", "I dop", "1174134786", "CABA", "Capital Federal", "Av. Santa Fé 5410");
            ListaCliente.Add(objCliente10);
            Cliente objCliente11 = new Cliente("34-14997852-4", "Fullí", "3244478416", "La Rioja", "Chilecito", "San Martín 3147");
            ListaCliente.Add(objCliente11);
            Cliente objCliente12 = new Cliente("33-27846312-5", "Chein", "1160786610", "CABA", "Capital Federal", "Viamonte 941");
            ListaCliente.Add(objCliente12);
            Cliente objCliente13 = new Cliente("38-47861246-1", "Anime ALV", "3144785430", "Mendoza", "San Rafael", "Pasteur 3478");
            ListaCliente.Add(objCliente13);
            Cliente objCliente14 = new Cliente("21-42114786-1", "Noche", "1185847130", "GBA Norte", "Pilar", "Agüero 320");
            ListaCliente.Add(objCliente14);
            Cliente objCliente15 = new Cliente("33-74132014-2", "Rimbo Latino", "1167750147", "GBA Sur", "Florencio Varela", "Arenales 1108");
            ListaCliente.Add(objCliente15);
            Cliente objCliente16 = new Cliente("34-44512478-7", "Taragüy", "3411478654", "Corrientes", "Corrientes", "Lavalle 1347");
            ListaCliente.Add(objCliente16);
            Cliente objCliente17 = new Cliente("18-56114783-5", "Güaimayén", "2144798413", "Mendoza", "Mendoza Capital", "Bartolomé Mitre 5477");
            ListaCliente.Add(objCliente17);
            Cliente objCliente18 = new Cliente("32-47786541-2", "ZTU Blade", "1189877410", "GBA Oeste", "La Matanza", "Chacabuco 5564");
            ListaCliente.Add(objCliente18);
            Cliente objCliente19 = new Cliente("54-44783001-2", "Fideos Maruchín", "1164778110", "GBA Sur", "Almirante Brown", "Solís 5479");
            ListaCliente.Add(objCliente19);
            Cliente objCliente20 = new Cliente("37-34458741-3", "Super Merk2", "1124431770", "CABA", "Capital Federal", "Matheu 355");
            ListaCliente.Add(objCliente20);
            Cliente objCliente21 = new Cliente("22-77441148-3", "Cande Lait", "3477841100", "Entre Ríos", "Paraná", "Gral. Urquiza 4570");
            ListaCliente.Add(objCliente21);
            Cliente objCliente22 = new Cliente("38-44710345-5", "Parrilla La Wacha", "1100147890", "GBA Sur", "Lomas de Zamora", "Virrey Cevallos 655");
            ListaCliente.Add(objCliente22);
            Cliente objCliente23 = new Cliente("40-49521003-9", "Linus Studios", "1190908714", "CABA", "Capital Federal", "Balcarce 3844");
            ListaCliente.Add(objCliente23);
            Cliente objCliente24 = new Cliente("17-29874110-5", "Carre4", "1120014789", "CABA", "Capital Federal", "Moreno 3144");
            ListaCliente.Add(objCliente24);
            Cliente objCliente25 = new Cliente("14-78841031-4", "Perón Perón", "1143124985", "GBA Sur", "Lanús", "Av. 9 de Julio 1999");
            ListaCliente.Add(objCliente25);
            dgvClientes.DataSource = ListaCliente;
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmpliarLista();
            ActualizarLista();
        }

        public void CamposVacios()
        {
            MessageBox.Show("Por favor, complete los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e) //Registra los datos del objeto cliente al DGV y actualiza la lista
        {
            if (mtbCuit.Text != string.Empty && txtRazonSocial.Text != string.Empty && mtbTelefono.Text != string.Empty && cbxProvincia.Text != string.Empty && cbxLocalidad.Text != string.Empty && txtCalle.Text != string.Empty)
            {
                Cliente objCliente = new Cliente(mtbCuit.Text, txtRazonSocial.Text, mtbTelefono.Text, cbxProvincia.Text, cbxLocalidad.Text, txtCalle.Text);
                ListaCliente.Add(objCliente);
                Limpiar();
                ActualizarLista();
                BotonesInactivos();
            }
            else
            {
                CamposVacios();
            }
        }

        private void Localidades() //Función de mostrar las localidades según la provincia
        {
            string Provincia = cbxProvincia.Text;
            switch (Provincia)
            {
                case "GBA Norte":
                    cbxLocalidad.Items.Clear();
                    string[] LocalidadesNorte = { "Escobar", "Gral. San Martín", "José C. Paz", "Malvinas Argentinas", "Pilar", "San Fernando", "San Isidro", "San Miguel", "Tigre", "Vicente López" };
                    cbxLocalidad.Items.AddRange(LocalidadesNorte);
                    cbxLocalidad.Enabled = true;
                    break;
                case "GBA Sur":
                    cbxLocalidad.Items.Clear();
                    string[] LocalidadesSur = { "Almirante Brown", "Avellaneda", "Berazategui", "Esteban Echeverría", "Ezeiza", "Florencio Varela", "Lanús", "Lomas de Zamora", "Presidente Perón", "Quilmes", "San Vicente" };
                    cbxLocalidad.Items.AddRange(LocalidadesSur);
                    cbxLocalidad.Enabled = true;
                    break;
                case "GBA Oeste":
                    cbxLocalidad.Items.Clear();
                    string[] LocalidadesOeste = { "General Rodriguez", "Hurlingham", "Ituzaingó", "La Matanza", "Marcos Paz", "Merlo", "Moreno", "Morón", "Tres de Febrero" };
                    cbxLocalidad.Items.AddRange(LocalidadesOeste);
                    cbxLocalidad.Enabled = true;
                    break;
                case "CABA":
                    cbxLocalidad.Items.Clear();
                    string[] Caba = { "Capital Federal" };
                    cbxLocalidad.Items.AddRange(Caba);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Catamarca":
                    cbxLocalidad.Items.Clear();
                    string[] Catamarca = { "Andalgalá", "Belén", "Fray Mamerto Esquiú", "Recreo", "San Fernando del Valle de Catamarca", "Santa María", "Tinogasta", "Valle Viejo" };
                    cbxLocalidad.Items.AddRange(Catamarca);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Chaco":
                    cbxLocalidad.Items.Clear();
                    string[] Chaco = { "Barranqueras", "Charata", "Fontana", "Gral. José de San Martín", "Juan José Castelli", "Magachai", "Presidencia Roque Sáenz Peña", "Resistencia", "Quintilipi", "Villa Ángela" };
                    cbxLocalidad.Items.AddRange(Chaco);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Chubut":
                    cbxLocalidad.Items.Clear();
                    string[] Chubut = { "Comodoro Rivadavia", "Esquel", "Gaiman", "Lago Pueblo", "Puerto Madryn", "Rada Tilly", "Rawson", "Trevelin", "Sarmiento", "Trelew" };
                    cbxLocalidad.Items.AddRange(Chubut);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Córdoba":
                    cbxLocalidad.Items.Clear();
                    string[] Cordoba = { "Córdoba Capital", "Villa Carlos Paz", "Mina Clavero", "Villa General Belgrano", "Santa Rosa de Calamuchita", "Cosquín", "Alta Gracia", "La Cumbrecita", "Nono", "Cura Brochero" };
                    cbxLocalidad.Items.AddRange(Cordoba);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Corrientes":
                    cbxLocalidad.Items.Clear();
                    string[] Corrientes = { "Corrientes", "Goya", "Paso de los Libres", "Curuzú Cuatiá", "Bella Vista", "Mercedes", "Gobernador Virasoro", "Esquina", "Santo Tomé", "Monte Caseros", "Ituzaingó", "Saladas", "San Luis del Palmar", "Lavalle", "Empedrado", "Santa Lucía", "Santa Rosa" };
                    cbxLocalidad.Items.AddRange(Corrientes);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Entre Ríos":
                    cbxLocalidad.Items.Clear();
                    string[] EntreRios = { "Paraná", "Gualeguaychú", "Colón", "Concordia", "Federación", "La Paz", "Villa Elisa", "Chajarí" };
                    cbxLocalidad.Items.AddRange(EntreRios);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Formosa":
                    cbxLocalidad.Items.Clear();
                    string[] Formosa = { "Formosa", "Clorinda" };
                    cbxLocalidad.Items.AddRange(Formosa);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Jujuy":
                    cbxLocalidad.Items.Clear();
                    string[] Jujuy = { "Humahuaca", "Purmamarca", "Tilcara", "San Salvador de Jujuy", "La Quiaca", "Santa Ana", "Casira", "Yavi", "Ocloyas", "Uquía" };
                    cbxLocalidad.Items.AddRange(Jujuy);
                    cbxLocalidad.Enabled = true;
                    break;
                case "La Pampa":
                    cbxLocalidad.Items.Clear();
                    string[] LaPampa = { "Santa Rosa", "Gral. Pico", "Toay", "Realicó", "Macachín", "Victorica", "Colonia 25 de Mayo", "Intendente Alvear", "Eduardo Castex", "Gral. Acha" };
                    cbxLocalidad.Items.AddRange(LaPampa);
                    cbxLocalidad.Enabled = true;
                    break;
                case "La Rioja":
                    cbxLocalidad.Items.Clear();
                    string[] LaRioja = { "La Rioja Capital", "Chilecito", "Aimogasta", "Chamical", "Chepes", "Famatina", "Olta", "Sanagasta", "Tama", "Valle de Bermejo" };
                    cbxLocalidad.Items.AddRange(LaRioja);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Mendoza":
                    cbxLocalidad.Items.Clear();
                    string[] Mendoza = { "Mendoza Capital", "San Rafael", "Malargue", "Uspallata", "Gral. Alvear", "Valle de Uco" };
                    cbxLocalidad.Items.AddRange(Mendoza);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Misiones":
                    cbxLocalidad.Items.Clear();
                    string[] Misiones = { "Posadas", "Puerto Iguazú", "Oberá", "Eldorado", "San Ignacio", "Apostoles" };
                    cbxLocalidad.Items.AddRange(Misiones);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Neuquén":
                    cbxLocalidad.Items.Clear();
                    string[] Neuquen = { "Neuquén Capital", "San Martín de los Andes", "Villa La Angostura", "Caviahue", "Cutral Co" };
                    cbxLocalidad.Items.AddRange(Neuquen);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Río Negro":
                    cbxLocalidad.Items.Clear();
                    string[] RioNegro = { "San Carlos de Bariloche", "Viedma", "Gral. Roca", "Cipolletti", "El Bolsón", "Las Grutas", "San Antonio" };
                    cbxLocalidad.Items.AddRange(RioNegro);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Salta":
                    cbxLocalidad.Items.Clear();
                    string[] Salta = { "Salta Capital", "Gral. José de San Martín", "Orán", "Anta", "Gral. Güemes", "Metán", "Rosario de Lerma", "Rosario de la Frontera", "Rivadavia", "Cerrillos" };
                    cbxLocalidad.Items.AddRange(Salta);
                    cbxLocalidad.Enabled = true;
                    break;
                case "San Juan":
                    cbxLocalidad.Items.Clear();
                    string[] SanJuan = { "San Juan Capital", "Rawson", "Chimbas", "Rivadavia", "Santa Lucía" };
                    cbxLocalidad.Items.AddRange(SanJuan);
                    cbxLocalidad.Enabled = true;
                    break;
                case "San Luis":
                    cbxLocalidad.Items.Clear();
                    string[] SanLuis = { "San Luis Capital", "Villa Mercedes", "Merlo", "La Punta", "Potrero de los Funes" };
                    cbxLocalidad.Items.AddRange(SanLuis);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Santa Cruz":
                    cbxLocalidad.Items.Clear();
                    string[] SantaCruz = { "Río Gallegos", "El Calafate", "El Chaltén", "Puerto Deseado", "Los Antiguos" };
                    cbxLocalidad.Items.AddRange(SantaCruz);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Santa Fe":
                    cbxLocalidad.Items.Clear();
                    string[] SantaFe = { "Rosario", "Santa Fé", "Rafaela", "Venado Tuerto", "Reconquista", "Cañada de Gómez", "San Javier" };
                    cbxLocalidad.Items.AddRange(SantaFe);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Santiago del Estero":
                    cbxLocalidad.Items.Clear();
                    string[] StgoEstero = { "Santiago del Estero Capital", "Termas de Río Hondo", "La Banda", "Frías", "Añatuya" };
                    cbxLocalidad.Items.AddRange(StgoEstero);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Tierra del Fuego":
                    cbxLocalidad.Items.Clear();
                    string[] TierraFuego = { "Ushuaia", "Río Grande", "Tolhuin", "Puerto Almanza", "San Sebastían", "Lago Escondido" };
                    cbxLocalidad.Items.AddRange(TierraFuego);
                    cbxLocalidad.Enabled = true;
                    break;
                case "Tucumán":
                    cbxLocalidad.Items.Clear();
                    string[] Tucuman = { "San Miguel de Tucumán", "Tafí del Valle", "Concepción", "Yerba Buena", "Simoca" };
                    cbxLocalidad.Items.AddRange(Tucuman);
                    cbxLocalidad.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e) //Utiliza la función al seleccionar la provincia
        {
            Localidades();
        }

        public void BotonesActivos()
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }
        public void BotonesInactivos()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e) //Elimina desde el list un objeto con el índice seleccionado en el DGV, toma el valor del index en el label.
        {
            int index = Convert.ToInt32(lblNumIndice.Text);
            DialogResult result = MessageBox.Show("¿Eliminar el cliente " + index + "?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ListaCliente.RemoveAt(index);
                ActualizarLista();
                BotonesInactivos();
            }
        }

        private void dgvClientes_CellsClick(object sender, DataGridViewCellEventArgs e) //Toma los datos de la lista seleccionando el DGV
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvClientes.Rows[e.RowIndex];
                var cliente = fila.DataBoundItem as Cliente;
                int indice = ListaCliente.IndexOf(cliente);
                lblNumIndice.Text = indice.ToString();
                BotonesActivos();
            }
            else
            {
                BotonesInactivos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) //Toma los datos del DGV para modificarlos
        {
            AchicarLista();
            gbxAltaCliente.Text = "Modificar Cliente";
            btnRegistrar.Visible = false;
            btnModificarOk.Visible = true;
            mtbCuit.Text = dgvClientes.SelectedCells[0].Value.ToString();
            txtRazonSocial.Text = dgvClientes.SelectedCells[1].Value.ToString();
            mtbTelefono.Text = dgvClientes.SelectedCells[2].Value.ToString();
            cbxProvincia.Text = dgvClientes.SelectedCells[3].Value.ToString();
            cbxLocalidad.Text = dgvClientes.SelectedCells[4].Value.ToString();
            txtCalle.Text = dgvClientes.SelectedCells[5].Value.ToString();
        }

        private void btnModificarOk_Click(object sender, EventArgs e) //Borra la fila antigua y crea una nueva con los nuevos datos ingresados
        {
            int index = Convert.ToInt32(lblNumIndice.Text);
            if (mtbCuit.Text != string.Empty && txtRazonSocial.Text != string.Empty && mtbTelefono.Text != string.Empty && cbxProvincia.Text != string.Empty && cbxLocalidad.Text != string.Empty && txtCalle.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Confirmar la modificación del cliente?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Cliente objCliente = new Cliente(mtbCuit.Text, txtRazonSocial.Text, mtbTelefono.Text, cbxProvincia.Text, cbxLocalidad.Text, txtCalle.Text);
                    ListaCliente.RemoveAt(index);
                    ListaCliente.Insert(index, objCliente);
                    Limpiar();
                    ActualizarLista();
                    AmpliarLista();
                    BotonesInactivos();
                }
                else
                {
                    AmpliarLista();
                }
            }
            else
            {
                CamposVacios();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            string tipoDato = cbxBuscar.Text;

            switch (tipoDato)
            {
                case "CUIT":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["CUIT"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                case "Razón Social":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["RazonSocial"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                case "Teléfono":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["Telefono"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                case "Provincia":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["Provincia"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                case "Localidad":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["Localidad"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                case "Calle":
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        string datoCliente = row.Cells["Calle"].Value.ToString();
                        if (dato == datoCliente)
                        {
                            row.Selected = true;
                            lblNumIndice.Text = row.Index.ToString();
                            BotonesActivos();
                        }
                    }
                    break;
                default: break;
            }
        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
        }
    }
}
