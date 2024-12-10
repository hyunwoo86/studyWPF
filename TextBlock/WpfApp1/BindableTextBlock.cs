using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp1
{
    public class BindableTextBlock : TextBlock
    {
        public ObservableCollection<Inline> BindableInlineList
        {
            get { return (ObservableCollection<Inline>)GetValue(BindableInlineListProperty); }
            set { SetValue(BindableInlineListProperty, value); }
        }

        public static readonly DependencyProperty BindableInlineListProperty =
            DependencyProperty.Register(
                "BindableInlineList",
                typeof(ObservableCollection<Inline>),
                typeof(BindableTextBlock),
                new UIPropertyMetadata(new ObservableCollection<Inline>(), OnPropertyChanged));

        //private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        //{
        //    BindableTextBlock textBlock = sender as BindableTextBlock;
        //    if (textBlock != null)
        //    {
        //        if (e.OldValue is ObservableCollection<Inline> oldList)
        //        {
        //            oldList.CollectionChanged -= textBlock.InlineCollectionChanged;
        //        }

        //        if (e.NewValue is ObservableCollection<Inline> newList)
        //        {
        //            newList.CollectionChanged += textBlock.InlineCollectionChanged;
        //        }
        //    }
        //}

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var textBlock = sender as BindableTextBlock;
            if (textBlock == null)
                return;

            // 이전 리스트의 이벤트 해제
            if (e.OldValue is ObservableCollection<Inline> oldList)
            {
                oldList.CollectionChanged -= textBlock.InlineCollectionChanged;
            }

            // 새 리스트의 이벤트 연결
            if (e.NewValue is ObservableCollection<Inline> newList)
            {
                newList.CollectionChanged += textBlock.InlineCollectionChanged;
                // 기존 아이템 초기화 처리
                foreach (var inline in newList)
                {
                    if (inline != null)
                    {
                        textBlock.Inlines.Add(inline);
                    }
                }
            }
        }


        private void InlineCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Inline inline in e.NewItems)
                {
                    if (inline != null)
                    {
                        this.Inlines.Add(inline);
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (Inline inline in e.OldItems)
                {
                    if (inline != null)
                    {
                        this.Inlines.Remove(inline);
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                this.Inlines.Clear();
            }
        }
    }
}
