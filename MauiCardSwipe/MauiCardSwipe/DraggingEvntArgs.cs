using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCardSwipe
{
    public class DraggingEventArgs
    {
        public readonly object Item;

        public DraggingEventArgs(object item)
        {
            this.Item = item;
        }
    }
}
