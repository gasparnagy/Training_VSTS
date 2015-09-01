using System;
using System.Linq;
using System.Windows.Forms;
using T100.Model;

namespace T100
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            rotor1Selector.SelectedIndex = 3;
            rotor2Selector.SelectedIndex = 1;
            rotor3Selector.SelectedIndex = 2;
            rotor1Position.SelectedIndex = 9;
            rotor2Position.SelectedIndex = 0;
            rotor3Position.SelectedIndex = 2;
        }

        private Rotor CreateRotor(string algName, string position)
        {
            int positionValue = int.Parse(position);
            return new Rotor(GetRotorAlg(algName), positionValue);
        }

        private IRotorAlg GetRotorAlg(string name)
        {
            switch(name)
            {
                case "Shift": return new ShiftRotorAlg();
                case "Mod": return new ModRotorAlg();
                case "TE": return new TERotorAlg();
                case "n/a": return new IdentityRotorAlg();
                default: 
                    throw new Exception();
            }
        }

        private Rotor GetRotors()
        {
            var rotors = new[]
                {
                    CreateRotor(rotor1Selector.Text, rotor1Position.Text),
                    CreateRotor(rotor2Selector.Text, rotor2Position.Text),
                    CreateRotor(rotor3Selector.Text, rotor3Position.Text)
                };

            for (int i = 1; i < rotors.Length; i++)
            {
                rotors[i - 1].AttachTo(rotors[i]);
            }

            return rotors[0];
        }

        private void encButton_Click(object sender, EventArgs e)
        {
            var rotor = GetRotors();
            var engine = new EnigmaEngine();

            string text = messageTextBox.Text;
            var result = engine.Encrypt(text, rotor);

            resultTextBox.Text = result;
        }

        private void decrButton_Click(object sender, EventArgs e)
        {
            var rotor = GetRotors();
            var engine = new EnigmaEngine();

            string text = resultTextBox.Text;
            var result = engine.Decrypt(text, rotor);

            origMessageTextBox.Text = result;
        }
    }
}
