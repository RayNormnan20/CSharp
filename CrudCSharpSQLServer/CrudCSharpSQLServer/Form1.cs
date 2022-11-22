namespace CrudCSharpSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);

            // Desahabilita la modificacion del campo Id
            txtID.Enabled= false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.ModificarAlumnos(txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);

            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ttnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.GuardarAlumnos(txtDNI, txtNombres, txtApellidos, txtEdad);
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);

            // Luego de guaradar los campos se ponen en vacio

            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";

        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.SelecionarAlumnos(dgvAlumnos, txtID, txtDNI, txtNombres, txtApellidos, txtEdad);

            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.EliminarAlumnos(txtID);  //Elimna
            objetoAlumnos.mostrarAlumnos(dgvAlumnos); // Se actualiza instantaneamnete

            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";

        }
    }
}