using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();
        BindingSource carListBinding = new BindingSource();
        BindingSource shoppingListBindingSource = new BindingSource();
        public Form1()
        {



            InitializeComponent();

            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            listBox1.DataSource = carListBinding;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";
            shoppingListBindingSource.DataSource = store.ShoppingList;
            listBox2.DataSource = shoppingListBindingSource;
            listBox2.DisplayMember = "Display";
            listBox2.ValueMember = "Display";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CarCreateBtn_Click(object sender, EventArgs e)
        {
            Car newcar = new Car();
            newcar.Make = textBox1.Text;
            newcar.Model = textBox2.Text;
            newcar.Price = decimal.Parse(textBox3.Text);
            newcar.Color = textBox4.Text;
            newcar.Year = int.Parse(textBox5.Text);

            store.CarList.Add(newcar);
            carListBinding.ResetBindings(false);

        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)listBox1.SelectedItem);
            shoppingListBindingSource.ResetBindings(false);

        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            CostLbl.Text = total.ToString();
        }
    }
}
