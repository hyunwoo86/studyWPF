using studyWPF.Models;
using System.Collections.Generic;

namespace studyWPF.ViewModels
{
    class MainViewModel
    {
        public MainViewModel()
        {
            Items = ComboItem.Items;
        }

        public List<ComboItem> Items { get; set; }
    }
}
