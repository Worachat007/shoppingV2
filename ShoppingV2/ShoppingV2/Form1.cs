namespace ShoppingV2
{
    public partial class Form1 : Form
    {
        Item itemCoffee = new Item();
        Item itemGreenTea = new Item();
        Item itemBerger = new Item();
        Item itemPizza = new Item();
        Discountitem disocuntAll = new Discountitem();
        Discountitem disocuntWater = new Discountitem();
        Discountitem disocuntFood = new Discountitem();





        public Form1()
        {
            InitializeComponent();
            // object data
            itemCoffee.name = "Coffee";
            itemCoffee.price = 30;
            cf_Price.Text = itemCoffee.price.ToString();
            cf_Price.ReadOnly = true;


            itemGreenTea.name = "Green Tea";
            itemGreenTea.price = 35;
            gt_Price.Text = itemGreenTea.price.ToString(); 
            gt_Price.ReadOnly = true;


            itemBerger.name = "Berger";
            itemBerger.price = 50;
            bg_Price.Text = itemBerger.price.ToString();
            gt_Price.ReadOnly = true;


            itemPizza.name = "Pizza";
            itemPizza.price = 80;
            pz_Price.Text = itemPizza.price.ToString();
            pz_Price.ReadOnly = true;



            //discount play data
            disocuntAll.name = "All";
            disocuntAll.per = 15;
            tbAll.Text = disocuntAll.per.ToString();
            tbAll.ReadOnly = true;


            disocuntWater.name = "Water";
            disocuntWater.per = 5;
            tbWater.Text = disocuntWater.per.ToString(); 
            tbWater.ReadOnly = true;
            

            disocuntFood.name = "Food";
            disocuntFood.per = 10;
            tbFood.Text = disocuntFood.per.ToString();
            tbFood.ReadOnly = true;
        }
        private double textFuntion(TextBox cf_Price, TextBox cf_Quantity, TextBox gt_Price, TextBox gt_Quantity, CheckBox checkCoffee, CheckBox checkGreenTea2)
        {
            


            string inputCFP = cf_Price.Text;
            string inputCFQ = cf_Quantity.Text;
            string inputGTP = gt_Price.Text;
            string inputGTQ = gt_Quantity.Text;

            int iCF_Price = 0;
            int iCF_Quantity = 0;
            int iGT_Price = 0;
            int iGT_Quantity = 0;

            try
            {
                if (checkCoffee.Checked)
                {
                    iCF_Price = int.Parse(inputCFP);
                    iCF_Quantity = int.Parse(inputCFQ);
                }
                if (checkGreenTea.Checked)
                {
                    iGT_Price = int.Parse(inputGTP);
                    iGT_Quantity = int.Parse(inputGTQ);
                }
            }
            catch (FormatException ex)
            {
                iCF_Price = 0;
                iCF_Quantity = 0;
                iGT_Price = 0;
                iGT_Quantity = 0;
            }

            int sum1 = iCF_Price * iCF_Quantity;
            int sum2 = iGT_Price * iGT_Quantity;
            int sum = sum1 + sum2;

            return sum;
        }
        private double DiscountAll(double Water, double Food)
        {
            double sum1 = 0;
            if (checkAll.Checked)
            {
                double discountValue = 0;
                try
                {
                    discountValue = int.Parse(tbAll.Text);
                    double all = Water + Food;
                    all = all - (all * discountValue / 100);
                    sum1 += all;
                }
                catch (FormatException)
                {
                    double all = Water + Food;
                    sum1 += all;
                }
            }
            return sum1;
        }
        private double discountAll(double Water)
        {
            if (checkWater.Checked)
            {
                double discountValue = 0;
                try
                {
                    discountValue = int.Parse(tbWater.Text);
                    Water = Water - (Water * discountValue / 100);
                }
                catch (FormatException)
                {
                    Water = Water - (Water * discountValue / 100);
                }
            }
            return Water;

        }
        private double discountFood(double Food)
        {
            if (checkFood.Checked)
            {
                double discountValue = 0;
                try
                {
                    discountValue = int.Parse(tbFood.Text);
                    Food = Food - (Food * discountValue / 100);
                }
                catch (FormatException)
                {
                    Food = Food - (Food * discountValue / 100);
                }
            }
            return Food;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            double total = 0;
            double cash = 0;
            try
            {
                cash = double.Parse(tbCash.Text);
            }
            catch (FormatException) 
            {  
       
            }
            try
            {
                total = double.Parse(tbTotal.Text);
            }
            catch (FormatException)
            { }

            decimal change = (decimal)cash - (decimal)total;
            tbChange.Text = change.ToString("F2");

            int OneT = 0;
            int FiveH = 0;
            int oneH = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            int fiftyCents = 0;
            int tenCents = 0;
            int fiveCents = 0;
            int oneCent = 0;

            while (change > 0.01m)
            {
                if (change >= 1000)
                {
                    change -= 1000;
                    OneT++;
                }
                else if (change >= 500)
                {
                    change -= 500;
                    FiveH++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    oneH++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    fifty++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    twenty++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    ten++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    five++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    one++;
                }
                else if (change >= 0.50m)
                {
                    change -= 0.50m;
                    fiftyCents++;
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                    tenCents++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    fiveCents++;
                }
                else if (change >= 0.01m)
                {
                    change -= 0.01m;
                    oneCent++;
                }
            }

            OneThousand.Text = OneT.ToString();
            FiveHundred.Text = FiveH.ToString();
            OneHundred.Text = oneH.ToString();
            Fifty.Text = fifty.ToString();
            Twenty.Text = twenty.ToString();
            Ten.Text = ten.ToString();
            Five.Text = five.ToString();
            One.Text = one.ToString();
            Fiftysatang.Text = fiftyCents.ToString();
            Tensatang.Text = tenCents.ToString();
            Fivesatang.Text = fiveCents.ToString();
            Onesatang.Text = oneCent.ToString();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            double Water = textFuntion(cf_Price, cf_Quantity, gt_Price, gt_Quantity, checkCoffee, checkGreenTea);
            double Food = textFuntion(bg_Price, bg_Quantity, pz_Price, pz_Quantity, checkBerger, checkPizza);
            double sum1 = 0;
            if (checkAll.Checked)
            {
                sum1 = DiscountAll(Water, Food);
            }
            else if (checkWater.Checked)
            {
                sum1 = discountAll(Water);
                sum1 += Food;
            }
            else if (checkFood.Checked)
            {
                sum1 = discountFood(Food);
                sum1 += Water;
            }
            else
            {
                sum1 = Water + Food;
            }
            tbTotal.Text = sum1.ToString();
        }

        private void tbAll_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCoffee.Checked == true)
            {
                cf_Price.Enabled = true;
                cf_Quantity.Enabled = true;
            }
            else
            {
                cf_Price.Enabled = false;
                cf_Quantity.Enabled = false;
            }
        }

        private void checkGreenTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGreenTea.Checked == true)
            {
                gt_Price.Enabled = true;
                gt_Quantity.Enabled = true;
            }
            else
            {
                gt_Price.Enabled = false;
                gt_Quantity.Enabled = false;
            }
        }

        private void checkBerger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBerger.Checked == true)
            {
                bg_Price.Enabled = true;
                bg_Quantity.Enabled = true;
            }
            else
            {
                bg_Price.Enabled = false;
                bg_Quantity.Enabled = false;
            }
        }

        private void checkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPizza.Checked == true)
            {
                pz_Price.Enabled = true;
                pz_Quantity.Enabled = true;
            }
            else
            {
                pz_Price.Enabled = false;
                pz_Quantity.Enabled = false;
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true)
            {
                checkWater.Checked = false;
                checkFood.Checked = false;
                checkAll.Checked = true;
                tbAll.Enabled = true;
            }
            else
            {
                tbAll.Enabled = false;
            }
        }

        private void checkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWater.Checked == true)
            {
                checkAll.Checked = false;
                checkFood.Checked = false;
                tbWater.Enabled = true;
            }
            else
            {
                tbWater.Enabled = false;
            }
        }

        private void checkFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFood.Checked == true)
            {
                checkAll.Checked = false;
                checkWater.Checked = false;
                tbFood.Enabled = true;
            }
            else
            {
                tbFood.Enabled = false;
            }
        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}