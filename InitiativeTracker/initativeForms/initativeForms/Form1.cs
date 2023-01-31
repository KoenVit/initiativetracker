namespace initativeForms
{
    public partial class initiativeTrackerForm : Form
    {
        public initiativeTrackerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (typeCombobox.SelectedIndex == 0)
            {
                KeyValuePair<string, decimal> newCharacter = new KeyValuePair<string, decimal>(initialTextbox.Text, initiativeNumeric.Value);
                listBox.Items.Add(string.Format("{0}: ({1})", newCharacter.Value, newCharacter.Key));
            }
            else if(typeCombobox.SelectedIndex == 1)
            {
                KeyValuePair<decimal, decimal> newEnemy = new KeyValuePair<decimal, decimal>(enemyNumeric.Value, initiativeNumeric.Value);
                listBox.Items.Add(string.Format("{0}: (Enemy #{1})", newEnemy.Value, newEnemy.Key));
            }
            listBox.Sorted = true;
        }

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeCombobox.SelectedIndex) 
            {
                case 0: initialTextbox.Enabled = true;
                    enemyNumeric.Enabled = false;
                    initiativeNumeric.Enabled = true;
                    break;
                case 1: enemyNumeric.Enabled = true;
                    initialTextbox.Enabled = false;
                    initiativeNumeric.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}