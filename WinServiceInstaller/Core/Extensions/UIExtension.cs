using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinServiceInstaller.Core.Extensions
{
    static partial class Extension
    {
        static internal bool IsValid(this Control current)
        {
            var errorProvider = current.GetErrorProvider();
            if (errorProvider == null)
                throw new InvalidOperationException("error provider not found");

            foreach (Control c in errorProvider.ContainerControl.Controls)
                if (errorProvider.GetError(c) != "")
                    return false;

            return true;
        }

        private static ErrorProvider GetErrorProvider(this Control control)
        {
            var form = control.GetContainerControl();

            var componentField = form.GetType().GetField("components", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (componentField != null)
            {
                var components = componentField.GetValue(form);

                return (components as IContainer)?.Components?.OfType<ErrorProvider>()?.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        static internal bool IsEmpty(this TextBox textBox,string emptyMessage="boş buraxıla bilməz")
        {
            var errorProvider = textBox.GetErrorProvider();
            if (errorProvider == null)
                throw new InvalidOperationException("error provider not found");

            
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, emptyMessage);
                
                if (textBox.Tag == null)
                {
                    textBox.Tag = textBox.Width;
                    textBox.Width -= 20;
                }
                
                return true;
            }

            if (textBox.Tag != null)
                textBox.Width = Convert.ToInt32(textBox.Tag);

            errorProvider.Clear();
            return false;
        }

    }
}
