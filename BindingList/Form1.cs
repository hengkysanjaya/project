using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingList
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        BindingList<Product> blProduct = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blProduct = new BindingList<Product>(db.Products.ToList());
            dataGridView1.DataSource = blProduct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blProduct[0].Name = "test";
            blProduct.RemoveAt(0);
            db.SubmitChanges();
        }
    }
}
