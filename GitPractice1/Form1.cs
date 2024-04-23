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

        }

        enum Currency
        {
            Ruble,
            Dollar,
            Euro
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private decimal GetValue()
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                return 0;
            Currency cur1;
            Currency cur2;
            foreach(var currency in (Currency[])Enum.GetValues(typeof(Currency)))
            {
                if (comboBox1.Text == currency.ToString())
                    cur1 = currency;
                if (comboBox2.Text == currency.ToString())
                    cur2 = currency;
            }



        }




        ///TODO: first master commit!
        ///TODO: создать конвертер валют.
        /* 1. Разобраться как работают конвертеры. -d.
         * 2. Сделать конвертер. -p.
         * 3. Сделать соотношение валют, хранение значения одного к другому и т.д. т.п.
         * 4. ...
         */
        ///TODO: доделать проект этот, и приступить к след видео про гит и его практике.








    }
}
