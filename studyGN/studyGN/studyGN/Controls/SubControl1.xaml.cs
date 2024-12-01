using System.Windows;
using System.Windows.Controls;

namespace studyGN.Controls
{
    /// <summary>
    /// SubControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SubControl1 : UserControl
    {
        public SubControl1()
        {
            InitializeComponent();
        }

        public string Text1
        {
            get { return (string)GetValue(Text1Property); }
            set { SetValue(Text1Property, value); }
        }

        public static readonly DependencyProperty Text1Property =
            DependencyProperty.Register("Text1", 
                typeof(string), 
                typeof(SubControl1), 
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );


        public string Text2
        {
            get { return (string)GetValue(Text2Property); }
            set { SetValue(Text2Property, value); }
        }

        public static readonly DependencyProperty Text2Property =
            DependencyProperty.Register("Text2", 
                typeof(string), 
                typeof(SubControl1), 
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

    }
}
