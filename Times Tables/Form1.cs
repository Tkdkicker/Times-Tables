namespace Times_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int timesTables; //stores which times table we want

            timesTables = int.Parse(txtNumber.Text);

            txtTimesTables.Text = ""; //clear the text box
            for (int i = 0; i <= 10; i++)
            {
                txtTimesTables.Text = txtTimesTables.Text + i * timesTables + Environment.NewLine;
            }
        }
    }
}