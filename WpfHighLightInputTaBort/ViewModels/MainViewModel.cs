using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHighLightInputTaBort.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public PatHandler PathObj { get; private set; }

        public MainViewModel()
        {
            PathObj = new();
        }
    }
}
