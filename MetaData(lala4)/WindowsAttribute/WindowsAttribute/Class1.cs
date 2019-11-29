using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsAttribute
{
    public class WindowAttribute : System.Attribute
    {
        public DockStyle Dock;

        public WindowAttribute(DockStyle dock)
        {
            Dock = dock;

        }
    }
}
