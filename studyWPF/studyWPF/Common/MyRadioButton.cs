using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace studyWPF.Common
{
    public class MyRadioButton : RadioButton
    {
        static MyRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyRadioButton), new FrameworkPropertyMetadata(typeof(MyRadioButton)));
        }
    }
}
