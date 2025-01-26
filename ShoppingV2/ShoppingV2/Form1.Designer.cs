namespace ShoppingV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            checkCoffee = new CheckBox();
            checkGreenTea = new CheckBox();
            cf_Price = new TextBox();
            gt_Price = new TextBox();
            cf_Quantity = new TextBox();
            gt_Quantity = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            pz_Price = new TextBox();
            pz_Quantity = new TextBox();
            checkBerger = new CheckBox();
            bg_Quantity = new TextBox();
            checkPizza = new CheckBox();
            bg_Price = new TextBox();
            CheckOut = new Button();
            label5 = new Label();
            label6 = new Label();
            tbTotal = new TextBox();
            tbCash = new TextBox();
            Change = new Button();
            groupBox3 = new GroupBox();
            Onesatang = new TextBox();
            Fivesatang = new TextBox();
            Tensatang = new TextBox();
            Fiftysatang = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label4 = new Label();
            FiveHundred = new TextBox();
            label7 = new Label();
            One = new TextBox();
            label8 = new Label();
            Five = new TextBox();
            label9 = new Label();
            Ten = new TextBox();
            label10 = new Label();
            Twenty = new TextBox();
            label13 = new Label();
            Fifty = new TextBox();
            label12 = new Label();
            OneHundred = new TextBox();
            label11 = new Label();
            label16 = new Label();
            OneThousand = new TextBox();
            label15 = new Label();
            tbChange = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            tbFood = new TextBox();
            tbWater = new TextBox();
            tbAll = new TextBox();
            checkFood = new CheckBox();
            checkWater = new CheckBox();
            checkAll = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 12);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // checkCoffee
            // 
            checkCoffee.AutoSize = true;
            checkCoffee.Location = new Point(14, 32);
            checkCoffee.Name = "checkCoffee";
            checkCoffee.Size = new Size(75, 24);
            checkCoffee.TabIndex = 2;
            checkCoffee.Text = "Coffee";
            checkCoffee.UseVisualStyleBackColor = true;
            checkCoffee.CheckedChanged += checkCoffee_CheckedChanged;
            // 
            // checkGreenTea
            // 
            checkGreenTea.AutoSize = true;
            checkGreenTea.Location = new Point(14, 78);
            checkGreenTea.Name = "checkGreenTea";
            checkGreenTea.Size = new Size(98, 24);
            checkGreenTea.TabIndex = 3;
            checkGreenTea.Text = "Green Tea";
            checkGreenTea.UseVisualStyleBackColor = true;
            checkGreenTea.CheckedChanged += checkGreenTea_CheckedChanged;
            // 
            // cf_Price
            // 
            cf_Price.Enabled = false;
            cf_Price.Location = new Point(155, 29);
            cf_Price.Name = "cf_Price";
            cf_Price.Size = new Size(125, 27);
            cf_Price.TabIndex = 4;
            // 
            // gt_Price
            // 
            gt_Price.Enabled = false;
            gt_Price.Location = new Point(155, 78);
            gt_Price.Name = "gt_Price";
            gt_Price.Size = new Size(125, 27);
            gt_Price.TabIndex = 5;
            // 
            // cf_Quantity
            // 
            cf_Quantity.Enabled = false;
            cf_Quantity.Location = new Point(329, 30);
            cf_Quantity.Name = "cf_Quantity";
            cf_Quantity.Size = new Size(125, 27);
            cf_Quantity.TabIndex = 6;
            // 
            // gt_Quantity
            // 
            gt_Quantity.Enabled = false;
            gt_Quantity.Location = new Point(329, 78);
            gt_Quantity.Name = "gt_Quantity";
            gt_Quantity.Size = new Size(125, 27);
            gt_Quantity.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gt_Price);
            groupBox1.Controls.Add(gt_Quantity);
            groupBox1.Controls.Add(checkCoffee);
            groupBox1.Controls.Add(cf_Quantity);
            groupBox1.Controls.Add(checkGreenTea);
            groupBox1.Controls.Add(cf_Price);
            groupBox1.Location = new Point(20, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Water";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 9;
            label1.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 12);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "Quantity";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pz_Price);
            groupBox2.Controls.Add(pz_Quantity);
            groupBox2.Controls.Add(checkBerger);
            groupBox2.Controls.Add(bg_Quantity);
            groupBox2.Controls.Add(checkPizza);
            groupBox2.Controls.Add(bg_Price);
            groupBox2.Location = new Point(20, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // pz_Price
            // 
            pz_Price.Enabled = false;
            pz_Price.Location = new Point(155, 78);
            pz_Price.Name = "pz_Price";
            pz_Price.Size = new Size(125, 27);
            pz_Price.TabIndex = 5;
            // 
            // pz_Quantity
            // 
            pz_Quantity.Enabled = false;
            pz_Quantity.Location = new Point(329, 78);
            pz_Quantity.Name = "pz_Quantity";
            pz_Quantity.Size = new Size(125, 27);
            pz_Quantity.TabIndex = 7;
            // 
            // checkBerger
            // 
            checkBerger.AutoSize = true;
            checkBerger.Location = new Point(14, 32);
            checkBerger.Name = "checkBerger";
            checkBerger.Size = new Size(75, 24);
            checkBerger.TabIndex = 2;
            checkBerger.Text = "Berger";
            checkBerger.UseVisualStyleBackColor = true;
            checkBerger.CheckedChanged += checkBerger_CheckedChanged;
            // 
            // bg_Quantity
            // 
            bg_Quantity.Enabled = false;
            bg_Quantity.Location = new Point(329, 30);
            bg_Quantity.Name = "bg_Quantity";
            bg_Quantity.Size = new Size(125, 27);
            bg_Quantity.TabIndex = 6;
            // 
            // checkPizza
            // 
            checkPizza.AutoSize = true;
            checkPizza.Location = new Point(14, 78);
            checkPizza.Name = "checkPizza";
            checkPizza.Size = new Size(65, 24);
            checkPizza.TabIndex = 3;
            checkPizza.Text = "Pizza";
            checkPizza.UseVisualStyleBackColor = true;
            checkPizza.CheckedChanged += checkPizza_CheckedChanged;
            // 
            // bg_Price
            // 
            bg_Price.Enabled = false;
            bg_Price.Location = new Point(155, 29);
            bg_Price.Name = "bg_Price";
            bg_Price.Size = new Size(125, 27);
            bg_Price.TabIndex = 4;
            // 
            // CheckOut
            // 
            CheckOut.Location = new Point(500, 52);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new Size(69, 447);
            CheckOut.TabIndex = 11;
            CheckOut.Text = "Check out";
            CheckOut.UseVisualStyleBackColor = true;
            CheckOut.Click += CheckOut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 21);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 13;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 54);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 14;
            label6.Text = "Cash";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(157, 18);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 15;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(157, 54);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 16;
            tbCash.TextChanged += tbCash_TextChanged;
            // 
            // Change
            // 
            Change.Location = new Point(138, 92);
            Change.Name = "Change";
            Change.Size = new Size(161, 27);
            Change.TabIndex = 17;
            Change.Text = "change";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Onesatang);
            groupBox3.Controls.Add(Fivesatang);
            groupBox3.Controls.Add(Tensatang);
            groupBox3.Controls.Add(Fiftysatang);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(FiveHundred);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(One);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(Five);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(Ten);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(Twenty);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(Fifty);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(OneHundred);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(OneThousand);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(tbChange);
            groupBox3.Location = new Point(575, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 334);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            // 
            // Onesatang
            // 
            Onesatang.Location = new Point(271, 129);
            Onesatang.Name = "Onesatang";
            Onesatang.Size = new Size(125, 27);
            Onesatang.TabIndex = 43;
            // 
            // Fivesatang
            // 
            Fivesatang.Location = new Point(271, 96);
            Fivesatang.Name = "Fivesatang";
            Fivesatang.Size = new Size(125, 27);
            Fivesatang.TabIndex = 42;
            // 
            // Tensatang
            // 
            Tensatang.Location = new Point(271, 63);
            Tensatang.Name = "Tensatang";
            Tensatang.Size = new Size(125, 27);
            Tensatang.TabIndex = 41;
            // 
            // Fiftysatang
            // 
            Fiftysatang.Location = new Point(271, 29);
            Fiftysatang.Name = "Fiftysatang";
            Fiftysatang.Size = new Size(125, 27);
            Fiftysatang.TabIndex = 40;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(223, 136);
            label21.Name = "label21";
            label21.Size = new Size(36, 20);
            label21.TabIndex = 39;
            label21.Text = "0.01";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(223, 103);
            label20.Name = "label20";
            label20.Size = new Size(36, 20);
            label20.TabIndex = 38;
            label20.Text = "0.05";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(223, 66);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 37;
            label19.Text = "0.10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 30);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 36;
            label4.Text = "0.50";
            // 
            // FiveHundred
            // 
            FiveHundred.Location = new Point(79, 92);
            FiveHundred.Name = "FiveHundred";
            FiveHundred.Size = new Size(125, 27);
            FiveHundred.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 29);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 18;
            label7.Text = "change";
            // 
            // One
            // 
            One.Location = new Point(79, 295);
            One.Name = "One";
            One.Size = new Size(125, 27);
            One.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 59);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 19;
            label8.Text = "1000";
            // 
            // Five
            // 
            Five.Location = new Point(79, 262);
            Five.Name = "Five";
            Five.Size = new Size(125, 27);
            Five.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 92);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 20;
            label9.Text = "500";
            // 
            // Ten
            // 
            Ten.Location = new Point(79, 229);
            Ten.Name = "Ten";
            Ten.Size = new Size(125, 27);
            Ten.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 129);
            label10.Name = "label10";
            label10.Size = new Size(33, 20);
            label10.TabIndex = 21;
            label10.Text = "100";
            // 
            // Twenty
            // 
            Twenty.Location = new Point(79, 195);
            Twenty.Name = "Twenty";
            Twenty.Size = new Size(125, 27);
            Twenty.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 162);
            label13.Name = "label13";
            label13.Size = new Size(25, 20);
            label13.TabIndex = 22;
            label13.Text = "50";
            // 
            // Fifty
            // 
            Fifty.Location = new Point(79, 162);
            Fifty.Name = "Fifty";
            Fifty.Size = new Size(125, 27);
            Fifty.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 195);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 23;
            label12.Text = "20";
            // 
            // OneHundred
            // 
            OneHundred.Location = new Point(79, 129);
            OneHundred.Name = "OneHundred";
            OneHundred.Size = new Size(125, 27);
            OneHundred.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 229);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 24;
            label11.Text = "10";
            label11.Click += label11_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 262);
            label16.Name = "label16";
            label16.Size = new Size(17, 20);
            label16.TabIndex = 25;
            label16.Text = "5";
            label16.Click += label16_Click;
            // 
            // OneThousand
            // 
            OneThousand.Location = new Point(79, 59);
            OneThousand.Name = "OneThousand";
            OneThousand.Size = new Size(125, 27);
            OneThousand.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 295);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 26;
            label15.Text = "1";
            // 
            // tbChange
            // 
            tbChange.Location = new Point(79, 27);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 27;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbCash);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(Change);
            groupBox4.Controls.Add(tbTotal);
            groupBox4.Location = new Point(575, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(402, 125);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(tbFood);
            groupBox5.Controls.Add(tbWater);
            groupBox5.Controls.Add(tbAll);
            groupBox5.Controls.Add(checkFood);
            groupBox5.Controls.Add(checkWater);
            groupBox5.Controls.Add(checkAll);
            groupBox5.Location = new Point(53, 327);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(441, 172);
            groupBox5.TabIndex = 39;
            groupBox5.TabStop = false;
            groupBox5.Text = "Discount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(338, 128);
            label18.Name = "label18";
            label18.Size = new Size(21, 20);
            label18.TabIndex = 8;
            label18.Text = "%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(338, 84);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 7;
            label17.Text = "%";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(338, 31);
            label14.Name = "label14";
            label14.Size = new Size(21, 20);
            label14.TabIndex = 6;
            label14.Text = "%";
            label14.Click += label14_Click;
            // 
            // tbFood
            // 
            tbFood.Enabled = false;
            tbFood.Location = new Point(191, 122);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(125, 27);
            tbFood.TabIndex = 5;
            // 
            // tbWater
            // 
            tbWater.Enabled = false;
            tbWater.Location = new Point(191, 77);
            tbWater.Name = "tbWater";
            tbWater.Size = new Size(125, 27);
            tbWater.TabIndex = 4;
            // 
            // tbAll
            // 
            tbAll.Enabled = false;
            tbAll.Location = new Point(191, 26);
            tbAll.Name = "tbAll";
            tbAll.Size = new Size(125, 27);
            tbAll.TabIndex = 3;
            tbAll.TextChanged += tbAll_TextChanged;
            // 
            // checkFood
            // 
            checkFood.AutoSize = true;
            checkFood.Location = new Point(11, 124);
            checkFood.Name = "checkFood";
            checkFood.Size = new Size(65, 24);
            checkFood.TabIndex = 2;
            checkFood.Text = "Food";
            checkFood.UseVisualStyleBackColor = true;
            checkFood.CheckedChanged += checkFood_CheckedChanged;
            // 
            // checkWater
            // 
            checkWater.AutoSize = true;
            checkWater.Location = new Point(14, 80);
            checkWater.Name = "checkWater";
            checkWater.Size = new Size(71, 24);
            checkWater.TabIndex = 1;
            checkWater.Text = "Water";
            checkWater.UseVisualStyleBackColor = true;
            checkWater.CheckedChanged += checkWater_CheckedChanged;
            // 
            // checkAll
            // 
            checkAll.AutoSize = true;
            checkAll.Location = new Point(14, 34);
            checkAll.Name = "checkAll";
            checkAll.Size = new Size(49, 24);
            checkAll.TabIndex = 0;
            checkAll.Text = "All";
            checkAll.UseVisualStyleBackColor = true;
            checkAll.CheckedChanged += checkAll_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 558);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(CheckOut);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox checkCoffee;
        private CheckBox checkGreenTea;
        private TextBox cf_Price;
        private TextBox gt_Price;
        private TextBox cf_Quantity;
        private TextBox gt_Quantity;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox pz_Price;
        private TextBox pz_Quantity;
        private CheckBox checkBerger;
        private TextBox bg_Quantity;
        private CheckBox checkPizza;
        private TextBox bg_Price;
        private Button CheckOut;
        private Label label5;
        private Label label6;
        private TextBox tbTotal;
        private TextBox tbCash;
        private Button Change;
        private GroupBox groupBox3;
        private TextBox FiveHundred;
        private Label label7;
        private TextBox One;
        private Label label8;
        private TextBox Five;
        private Label label9;
        private TextBox Ten;
        private Label label10;
        private TextBox Twenty;
        private Label label13;
        private TextBox Fifty;
        private Label label12;
        private TextBox OneHundred;
        private Label label11;
        private Label label16;
        private TextBox OneThousand;
        private Label label15;
        private TextBox tbChange;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox tbAll;
        private CheckBox checkFood;
        private CheckBox checkWater;
        private CheckBox checkAll;
        private Label label18;
        private Label label17;
        private Label label14;
        private TextBox tbFood;
        private TextBox tbWater;
        private Label label19;
        private Label label4;
        private Label label20;
        private TextBox Onesatang;
        private TextBox Fivesatang;
        private TextBox Tensatang;
        private TextBox Fiftysatang;
        private Label label21;
    }
}
