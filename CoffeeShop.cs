namespace _Coffee_Shop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int price;
            string coffee = CBox1.Text;
            string size = CBox2.Text;
            if (coffee == "Latte")
            {
                if (size == "Large") price = 280;
                else if (size == "Regular") price = 180;
                else price = 120;
            }
            else if (coffee == "Cappuccino")
            {
                if (size == "Large") price = 320;
                else if (size == "Regular") price = 220;
                else price = 150;
            }
            else if (coffee == "Americano")
            {
                if (size == "Large") price = 280;
                else if (size == "Regular") price = 180;
                else price = 120;
            }
            else if (coffee == "Expresso")
            {
                if (size == "Large") price = 300;
                else if (size == "Regular") price = 190;
                else price = 130;
            }
            else
            {
                if (size == "Large") price = 250;
                else if (size == "Regular") price = 150;
                else price = 110;
            }
            RText.Clear();
            RText.Text = "\n\nOrder Detail : \n" + "Customer Name: " + Name.Text + "\n" + "Contact No.: " + Contact.Text + "\n" + "Address: " + Address.Text + "\n" + "Selected Coffee: " + coffee + "\n" + "Total Bill : " + price + "\n";
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}