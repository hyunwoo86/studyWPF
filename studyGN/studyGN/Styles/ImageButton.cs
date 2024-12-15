using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace studyGN.Styles
{
    public class ImageButton : Button
    {
        public static readonly DependencyProperty ImagePathProperty =   DependencyProperty.Register(
                                                                        nameof(ImagePath),
                                                                        typeof(string),
                                                                        typeof(ImageButton),
                                                                        new PropertyMetadata(default(string)));

        public string ImagePath
        {
            get => (string)GetValue(ImagePathProperty);
            set => SetValue(ImagePathProperty, value);
        }
    }
}
