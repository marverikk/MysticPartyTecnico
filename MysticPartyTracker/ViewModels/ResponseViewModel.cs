using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.ViewModels
{
    public partial class Result : ObservableObject
    {
        [ObservableProperty]
        public int _index;
        [ObservableProperty]
        public int _name;
        [ObservableProperty]
        public int _level;
        [ObservableProperty]
        public int _url;
    }

    public class Response
    {
        public int Count { get; set; }
        public List<Result> Results { get; set; }
    }
}
