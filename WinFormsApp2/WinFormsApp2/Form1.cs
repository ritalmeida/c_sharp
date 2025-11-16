namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool estado;    //se carregamos ou não o checkbox
            if (checkBox1.Checked)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            MessageBox.Show("Mais de 18 anos = " + estado, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
