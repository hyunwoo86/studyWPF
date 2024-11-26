using System.Windows;
using System.Windows.Controls;

namespace studyWPF.Common
{
    public class MyTextBox : TextBox
    {
        static MyTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(MyTextBox),
                new FrameworkPropertyMetadata(typeof(MyTextBox))
                );
        }
    }
}

