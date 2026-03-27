namespace InheritanceMod
{
    public partial class Form1 : Form
    {
        List<Instruments> instrumentsList = new List<Instruments>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.instrumentsList.Clear();

            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                switch(random.Next() % 3)
                {
                    case 0:
                        this.instrumentsList.Add(Strings.Generate());
                        break;
                    case 1:
                        this.instrumentsList.Add(Keyboard.Generate());
                        break;
                    case 2:
                        this.instrumentsList.Add(Drum.Generate());
                        break;
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int keyboards = 0;
            int strings = 0;
            int drums = 0;

            foreach (var instrument in this.instrumentsList)
            {
                if (instrument is Keyboard)
                {
                    keyboards++;
                }
                else if (instrument is Strings)
                {
                    strings++;
                }
                else
                {
                    drums++;
                }
            }
    
                txtInfo.Text = "Стрн\tКлвш\tБрбн";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", strings, keyboards, drums);

            if (instrumentsList.Count == 0)
            {
                listOut.Text = "Следующий инстр: -";
            }
            else
            {
                listOut.Text = "Следующий инстр:" + instrumentsList[0].GetInfo();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.instrumentsList.Count == 0)
            {
                txtOut.Text = "Пусто(";
                return;
            }

            var instrument = this.instrumentsList[0];

            this.instrumentsList.RemoveAt(0);
            txtOut.Text = instrument.GetInfo();
            ShowInfo();
        }
    }
}
