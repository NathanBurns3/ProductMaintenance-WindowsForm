namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void Form1_Load(object sender, EventArgs e)
        {
            //software objects
            Software p = new Software("1.2.5", "OFFICE2016", "Microsoft Office 2016", 100);
            Software p1 = new Software("2.5.3", "OFFICE2019", "Microsoft Office 2019", 120);

            //books objects
            Book p2 = new Book
            {
                Code = "LOTRTT",
                Description = "The Two Towers",
                Price = 19.99m,
                Author = "J.R.R Tolkien"
            };
            var p3 = new Book("J.R.R Tolkien", "LOTRFOTR", "Fellowship of the Ring", 19.99m);

            //Add the Product objects to a list
            List<Product> products = new List<Product> { p, p1, p2, p3 };

            //print out each product object using the GetDisplayText method
            products.ForEach(p => lstProducts.Items.Add(p.GetDisplayText(", ")));
        }
    }
}