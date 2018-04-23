using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RadialMenuExample
{
    public class RadialContextMenuViewModel
    {
        public virtual ITextBoxService TextBoxService { get { return null; } }

        public ICommand CopyCommand { get; set; }
        public ICommand PasteCommand { get; set; }
        public ICommand CutCommand { get; set; }
        public ICommand SelectAllCommand { get; set; }

        public RadialContextMenuViewModel()
        {
            CopyCommand = ApplicationCommands.Copy;
            PasteCommand = ApplicationCommands.Paste;
            CutCommand = ApplicationCommands.Cut;
            SelectAllCommand = ApplicationCommands.SelectAll;
        }

        // A ClearSelectionCommand is automatically created from the following methods by POCO:
        public bool CanClearSelection()
        {
            return TextBoxService.CanClearSelection();
        }

        public void ClearSelection()
        {
            TextBoxService.ClearSelection();
        }
    }
}
