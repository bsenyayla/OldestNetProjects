using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Text;


namespace Kronus.Client.Common.Libs
{
    public class FormFactory
    {
        public static Form FormOlustur(string dllName, string Assembly)
        {
            Assembly assembly = System.Reflection.Assembly.LoadFile(System.IO.Path.Combine(Application.StartupPath, dllName.Trim() + "." + "dll"));
            Type tip = assembly.GetType(Assembly.Trim());
            if (tip == null) return null;

            Object form = assembly.CreateInstance(Assembly.Trim());
            return form as Form;
        }
    }
}
