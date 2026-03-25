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
            for (var i = 0; i < 10; i++)
            {
                this.instrumentsList.Add(new Keyboard());
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
