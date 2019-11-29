using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PluginsInterface;
using WindowsAttribute;

namespace FormsPlugins
{
    [WindowAttribute(DockStyle.Bottom)]
    public partial class Form2 : Form, PluginsInterface.FormInterface
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
