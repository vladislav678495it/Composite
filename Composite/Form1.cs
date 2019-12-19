using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] composite = { "raise taxes", "reduce taxes" };
            lst_laws.Items.AddRange(composite);
            lst_laws.SelectedIndexChanged += lst_laws_SelectedIndexChanged;
        }

        private void lst_laws_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelecteLaws = lst_laws.SelectedItem.ToString();
            MessageBox.Show(SelecteLaws);
        }

        private void btn_adopt_law_Click(object sender, EventArgs e)
        {
            if (client.(lst_laws.Text))
            {
                client.GetClient();
            }
        }

        private void txt_supreme_council_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
