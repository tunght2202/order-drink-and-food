using ProjectPrn211.DAO;
using ProjectPrn211.Models;

namespace ProjectPrn211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String name;
        int qty;
        int price;
        int total;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudCola_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbFriedRice.Checked)
            {
                name = "Fried Rice";
                qty = int.Parse(nudFriedRice.Value.ToString());
                price = 100;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            if (cbChicken.Checked)
            {
                name = "Chicken";
                qty = int.Parse(nudChicken.Value.ToString());
                price = 120;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            if (cbFish.Checked)
            {
                name = "Fish";
                qty = int.Parse(nudFish.Value.ToString());
                price = 130;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            if (cbCoffee.Checked)
            {
                name = "Coffee";
                qty = int.Parse(nudCoffee.Value.ToString());
                price = 12;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            if (cbCola.Checked)
            {
                name = "Cola";
                qty = int.Parse(nudCola.Value.ToString());
                price = 100;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            if (cbBeer.Checked)
            {
                name = "Beer";
                qty = int.Parse(nudBeer.Value.ToString());
                price = 100;
                total = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, total);
            }

            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            tbTotal.Text = sum.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }
        public List<Order> getOrderformui()
        {
            List<Order> os = new List<Order>();
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                Order o = new Order();
                o.tableName = Convert.ToString(tbNameTable.Text);
                o.foodOrDrinkName = Convert.ToString(dataGridView1.Rows[row].Cells[0].Value);
                o.number = Convert.ToInt32(dataGridView1.Rows[row].Cells[2].Value);
                o.status = 0;
                os.Add(o);
            }
            return os;
        }
        private void BtOrder_Click(object sender, EventArgs e)
        {
            foreach (Order o in getOrderformui())
            {
                OderDAO.insertOrder(o);
            }
            MessageBox.Show("order successfull!");
        }
    }
}