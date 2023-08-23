using System;
using System.Windows.Forms;

namespace IdealPoint
{


    public partial class ManeForm: Form
    {
        ListItem[] A, W;
        public string[] cashr;
        public string[] cashl;

        int AmountControls;
        int AmountStates;
        public ManeForm()
        {
            InitializeComponent();
        }

        private void ClearPanels()
        {
            panel_Controls.Controls.Clear();
            panel_States.Controls.Clear();
        }

        private void SetPanels()
        {
            AmountControls = Convert.ToInt32(numeric_Controls.Value);
            AmountStates = Convert.ToInt32(numeric_States.Value);

            A = new ListItem[AmountControls];
            W = new ListItem[AmountStates];

            for (int i = 0; i < AmountControls; i++)
            {
                A[i] = new(i + 1, "о");
                panel_Controls.Controls.Add(A[i]);
            }

            for (int i = 0; i < AmountStates; i++)
            {
                W[i] = new(i + 1, "к");
                panel_States.Controls.Add(W[i]);
            }
        }

        private void button_OpenMatrix_Click(object sender, EventArgs e)
        {
            cashl = new string[AmountControls];
            cashr = new string[AmountStates];

            for (int i = 0; i < AmountControls; i++)
            {
                cashl[i] = A[i].DescriptionTB.Text;
            }

            for (int i = 0; i < AmountStates; i++)
            {
                cashr[i] = W[i].DescriptionTB.Text;
            }

            //this.Hide();
            Form2 newForm = new Form2();
            newForm.cerf(this);
            newForm.Show();

        }



        private void button_Apply_Click(object sender, EventArgs e)
        {
            ClearPanels();
            SetPanels();
        }
    }
}
