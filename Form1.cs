using System.Data;

namespace Calculate
{
    public partial class Form1 : Form
    {
        private List<string> _oldText = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void kpAnswer_Click(object sender, EventArgs e)
        {
            changeAnswer();
        }

        private void kpInteracte(object sender, EventArgs e)
        {
            _oldText.Add(textResult.Text);
            if (textResult.Text.Contains(" = "))
                textResult.Text = textResult.Text.Remove(0, textResult.Text.IndexOf("=") + 2);

            textResult.Text += (sender as Button).Text;
        }

        private void kpInteracteTrig(object sender, EventArgs e)
        {
            _oldText.Add(textResult.Text);
            string _expression = textResult.Text == "" ? "0" : textResult.Text;
            textResult.Text = (sender as Button).Text.Replace("x", _expression);
        }

        private void changeAnswer()
        {
            _oldText.Add(textResult.Text);
            textResult.Text += " = " + new DataTable().Compute(textResult.Text, null).ToString();
        }

        private void kpC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        private void kpBackSpace_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text.Remove(textResult.TextLength - 1);
        }

        private void kpCE_Click(object sender, EventArgs e)
        {
            if (_oldText.Count - 1 < 0)
                return;
            textResult.Text = _oldText[_oldText.Count - 1];
            _oldText.Remove(_oldText[_oldText.Count - 1]);
        }
    }
}