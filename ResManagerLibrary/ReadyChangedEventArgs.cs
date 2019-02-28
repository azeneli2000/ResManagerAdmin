using System;
using System.Collections.Generic;
using System.Text;

namespace ResManagerLibrary
{
    /// <summary>
    /// Delegat per eventin ReadyChanged
    /// </summary>
    public delegate void ReadyChangedEventHandler(object source, ReadyChangedEventArgs e);

    public class ReadyChangedEventArgs : EventArgs
    {
        public ReadyChangedEventArgs()
        {
        }
    }
}
