namespace ToDoList
{
    public partial class MainForm : Form
    {

        private bool isMenuVisible;
        private int targetWidth = 125;


        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            menuPanel.Width = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            idozit.Start();

        }

        private void idozit_Tick(object sender, EventArgs e)
        {
            if (isMenuVisible)
            {
                menuPanel.Width -= 20; // Csökkentjük a szélességet
                if (menuPanel.Width <= 0)
                {
                    idozit.Stop();
                    isMenuVisible = false;
                }
            }
            else
            {
                menuPanel.Width += 20; // Növeljük a szélességet
                if (menuPanel.Width >= targetWidth)
                {
                    idozit.Stop();
                    isMenuVisible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuGomb2_Click(object sender, EventArgs e)
        {

        }
    }
}
