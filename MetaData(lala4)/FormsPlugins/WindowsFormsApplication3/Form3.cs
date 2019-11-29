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
        [WindowAttribute(DockStyle.Right)]
    public partial class Form3 : Form, PluginsInterface.FormInterface
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
