namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string getFileDirectory = "";
        public Form1()
        {
            InitializeComponent();
            getFileDirectory = Directory.GetCurrentDirectory();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void setup_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream inputFile = new FileStream(getFileDirectory + "\\" + fileName.Text + ".in", FileMode.Create);
                FileStream outputFile = new FileStream(getFileDirectory + "\\" + fileName.Text + ".out", FileMode.Create);
                StreamWriter i = new StreamWriter(inputFile);
                StreamWriter o = new StreamWriter(outputFile);
                i.Write(input.Text);
                o.Write(output.Text);
                i.Close(); o.Close();
                inputFile.Close(); outputFile.Close();
                try
                {
                    fileName.Text = int.Parse(fileName.Text) + 1 + "";
                }
                catch
                {

                }
                if (checkBox1.Checked)
                {
                    input.Text = "";
                    output.Text = "";
                }
                //MessageBox.Show();
            }
            catch
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}