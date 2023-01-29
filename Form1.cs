using System.Data;

namespace Calculate
{
    public partial class Form1 : Form
    {
        private List<string> _history = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonBaseClick(object sender, EventArgs e)
        {
            _history.Add(textResult.Text);

            if (textResult.Text.Contains("="))
                textResult.Text = textResult.Text.Remove(0, textResult.Text.IndexOf("=") + 2);
            if (textResult.Text == "0")
                textResult.Text = "";

            textResult.Text += (sender as Button).Text;
        }

        private void kpBackSpace_Click(object sender, EventArgs e)
        {
                textResult.Text = textResult.TextLength > 1 ? textResult.Text.Remove(textResult.TextLength - 1) : "0";
        }

        private void kpC_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void kpCE_Click(object sender, EventArgs e)
        {
            if (_history.Count == 0)
                return;

            textResult.Text = _history[_history.Count - 1];
            _history.Remove(_history[_history.Count - 1]);
        }
    }
}