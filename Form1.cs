using MarkovChainSentenceGenerator.Generator;

namespace MarkovChainSentenceGenerator
{
    public partial class MarcusChainSentenceGenerator : Form
    {
        TextGenerator textGenerator;

        public MarcusChainSentenceGenerator()
        {
            InitializeComponent();
            textGenerator = new TextGenerator();
        }

        private void btnConan_Click(object sender, EventArgs e)
        {
            textView.Clear();
            string text = textGenerator.ConanText(500);
            textView.Text = text;
        }
    }
}