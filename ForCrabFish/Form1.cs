using System.Windows.Forms.VisualStyles;

namespace ForCrabFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //To Do
            //List<MenuItem> menuItems = new List<MenuItem>()
            //{
            //    new MenuTheory{},
            //    new MenuPractice{}
            //};

            //MenuComboBox.DataSource = menuItems;
            //MenuComboBox.DisplayMember = "name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    abstract class MenuItem//to do
    {
        protected readonly string name;
    }

    class MenuTheory : MenuItem
    {
       public string name = "Теория";
    }

    class MenuPractice: MenuItem
    {
       public string name = "Практика";
    }
}
