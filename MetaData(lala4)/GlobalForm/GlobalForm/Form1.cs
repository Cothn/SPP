using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using PluginsInterface;
using WindowsAttribute;

namespace GlobalForm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            //плагины
            string pluginPath = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");
            DirectoryInfo pluginDirect = new DirectoryInfo(pluginPath);
            //if (!pluginDirect.Exists)
            //{ pluginDirect.Create(); }

            //берем все dll
            var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                //загружаем сборку
                Assembly asm = Assembly.LoadFrom(file);
                //Ищем типы  //type of plugin is AssignableFrom
                var types = asm.GetTypes().Where(t => t.GetInterfaces().Where(j => j.FullName == typeof(FormInterface).FullName).Any());



                foreach (var type in types)
                {
                    var form = asm.CreateInstance(type.FullName) as Form;
                    form.MdiParent = this;
                    form.StartPosition = FormStartPosition.Manual;
                    object[] attributes = type.GetCustomAttributes(typeof(WindowAttribute), inherit: true);
                    if (attributes.Length != 0)
                    {
                        WindowAttribute windowAttribute = (WindowAttribute)attributes[0];
                        form.Dock = windowAttribute.Dock;
                    }
                    form.Show();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
