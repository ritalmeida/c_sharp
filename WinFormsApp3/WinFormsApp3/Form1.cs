namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração da variável que irá contar as disciplinas
            int disciplinas = 0;

            //Este ciclo de repetição irá percorrer todos os elementos da lista
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                //Verificar se o elemento está selecionado
                if (checkedListBox1.GetItemChecked(i))
                {
                    disciplinas++; //contar como selecionado
                }
            }
            //Apresentar o resultado
            MessageBox.Show("Total de Disciplinas = " + disciplinas, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

