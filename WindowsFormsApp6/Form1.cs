using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form, ISafeView
    {
        private readonly SafePresenter _presenter;
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            _presenter = new SafePresenter(this, new SafeModel());
        }


        public string Code
        {
            get { return txtCode.Text; }
            set { txtCode.Text = value; }
        }

        public event EventHandler CodeSubmitted;
        private void btnClear_Click(object sender, EventArgs e)
        {
            Code = string.Empty;
            txtCode.Items.Clear();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            CodeSubmitted?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Code += button.Text;
            txtCode.Items.Add(button.Text);

        }
    }
}
