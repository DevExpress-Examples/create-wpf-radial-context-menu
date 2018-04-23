using DevExpress.Mvvm.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RadialMenuExample
{
    public interface ITextBoxService
    {
        void ClearSelection();
        bool CanClearSelection();
    }

    //This service is used for the Clear command. To learn more about custom services, refer to https://documentation.devexpress.com/#WPF/CustomDocument16920
    public class TextBoxService : ServiceBase, ITextBoxService
    {
        TextBox MyTextBox { get { return AssociatedObject as TextBox; } }
        public void ClearSelection()
        {
            MyTextBox.SelectionLength = 0;
        }
        public bool CanClearSelection()
        {
            return MyTextBox.SelectionLength > 0;
        }
    }
}
