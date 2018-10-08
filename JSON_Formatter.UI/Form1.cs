using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Formatter.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBtnFormat_Click(object sender, EventArgs e)
        {

            var jsonString = this.CtxBxTextArea.Text;

            var prettyFormatter = Library.Factories.PrettyJSONFormatterFactory.Get(jsonString);

            var temp = prettyFormatter.GetFormattedString();

            this.CtxBxTextArea.Text = temp;

        }

        private void CbtnClear_Click(object sender, EventArgs e)
        {
            this.CtxBxTextArea.Text = string.Empty;
        }
    }
}
