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
            int numberOfWords = Convert.ToInt32(numWords.Value);
            string folderName = "\\conan\\";
            string text = textGenerator.PredifinedText(folderName, numberOfWords);
            textView.Text = text;
        }

        private void btnLovecraft_Click(object sender, EventArgs e)
        {
            textView.Clear();
            int numberOfWords = Convert.ToInt32(numWords.Value);
            string folderName = "\\lovecraft\\";
            string text = textGenerator.PredifinedText(folderName, numberOfWords);
            textView.Text = text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Font fnt = new Font(textView.Font.FontFamily, Convert.ToSingle(numSize.Value));
            textView.Font = fnt;
        }

        private void MarcusChainSentenceGenerator_Load(object sender, EventArgs e)
        {
            Font fnt = new Font(textView.Font.FontFamily, Convert.ToSingle(numSize.Value));
            textView.Font = fnt;
        }
    }
}