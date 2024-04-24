namespace GitPractice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            foreach (var cur in (Currency[])Enum.GetValues(typeof(Currency)))
            {
                comboBox1.Items.Add(cur);
                comboBox2.Items.Add(cur);
            }
        }

        enum Currency
        {
            Undefined,
            Ruble,
            Dollar,
            Euro
        }
        static Dictionary<Currency, Dictionary<Currency, decimal>> Ratio = new Dictionary<Currency, Dictionary<Currency, decimal>>()
            {
                {
                    Currency.Ruble,
                    new Dictionary<Currency, decimal>()
                    {
                        {
                            Currency.Ruble,
                            1m
                        },
                        {
                            Currency.Dollar,
                            1.011m
                        },
                        {
                            Currency.Euro,
                            0.010m
                        }
                    }
                },
                {
                    Currency.Dollar,
                    new Dictionary<Currency, decimal>()
                    {
                        {
                            Currency.Ruble,
                            93.77m
                        },
                        {
                            Currency.Dollar,
                            1m
                        },
                        {
                            Currency.Euro,
                            0.94m
                        }
                    }
                },
                {
                    Currency.Euro,
                    new Dictionary<Currency, decimal>()
                    {
                        {
                            Currency.Ruble,
                            100.19m
                        },
                        {
                            Currency.Dollar,
                            1.07m
                        },
                        {
                            Currency.Euro,
                            1m
                        }
                    }
                }
            };
        private async void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (await GetValue()).ToString();
        }
        private async Task<decimal> GetValue()
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                return 0;
            Currency cur1 = 0;
            Currency cur2 = 0;
            foreach (var currency in (Currency[])Enum.GetValues(typeof(Currency)))
            {
                if (comboBox1.Text == currency.ToString())
                    cur1 = currency;
                if (comboBox2.Text == currency.ToString())
                    cur2 = currency;
            }
            if (cur1 == Currency.Undefined || cur2 == Currency.Undefined)
                return 0;
            if (int.TryParse(textBox1.Text, out int val1) == false)
                return 0;
            if (cur1 == cur2)
                return val1;
            if (Ratio.TryGetValue(cur1, out Dictionary<Currency, decimal> ratioArr1) == false)
                return 0;
            foreach(var cur in ratioArr1)
            {
                if(cur2 == cur.Key)
                {
                    return val1 * cur.Value;
                }
            }
            return 0;
            ///TODO: thank u for help!
            ///TODO: Adding new message.
        }




        ///TODO: first master commit!
        ///TODO: создать конвертер валют.
        /* 1. Разобраться как работают конвертеры. -d.
         * 2. Сделать конвертер. -d.
         * 3. Сделать соотношение валют, хранение значения одного к другому и т.д. т.п. -d.
         * 4. Комитить этапы разработки.
         */
        



        ///TODO: merge with conflict -need repair



    }
}
