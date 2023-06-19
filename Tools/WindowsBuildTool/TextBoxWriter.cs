using System.Text;

namespace WindowsBuildTool
{
    internal class TextBoxWriter : TextWriter
    {
        private readonly TextBox _textBox;

        public override Encoding Encoding => Encoding.ASCII;

        public TextBoxWriter(TextBox textBox)
        {
            _textBox = textBox;
        }

        public override void Write(char value)
        {
            _textBox.Text += value;
        }

        public override void Write(string? value)
        {
            if (value != null)
                _textBox.Text += value;
        }
    }
}
