using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace studyGN.Commons
{
    public class BindTableTextBlock : TextBlock
    {
        public ObservableCollection<Inline> BindTableInlineList
        {
            get { return (ObservableCollection<Inline>)GetValue(BindableInlineListProperty); }
            set { SetValue(BindableInlineListProperty, value); }
        }

        public static readonly DependencyProperty BindableInlineListProperty =
            DependencyProperty.Register(
                "BindTableInlineList",
                typeof(ObservableCollection<Inline>),
                typeof(BindTableTextBlock),
                new UIPropertyMetadata(new ObservableCollection<Inline>(), OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var textBlock = sender as BindTableTextBlock;
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

