using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCardSwipe
{
    public class SwipedEventArgs : EventArgs
    {
        public readonly object Item;
        public readonly SwipeDirection Direction;

        public SwipedEventArgs(object item, SwipeDirection direction)
        {
            this.Item = item;
            this.Direction = direction;
        }
    }

    public enum SwipeDirection
    {
        Left, Right
    }
}

