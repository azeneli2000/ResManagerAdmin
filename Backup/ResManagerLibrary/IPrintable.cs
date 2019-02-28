using System;
using System.Collections.Generic;
using System.Text;

namespace ResManagerLibrary
{
    /// <summary>
    /// Interface qe perdoret nga format qe implementojne printimin.
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        /// Event qe duhet te ndodhe kur propertia ReadyToPrint ndryshon
        /// </summary>
        event ReadyChangedEventHandler ReadyToPrintChanged;

        /// <summary>
        /// Printon raportin.
        /// </summary>
        void Print();

        /// <summary>
        /// Tregon raportin.
        /// </summary>
        void PrintPreview();

        /// <summary>
        /// Konverton raportin ne Excel
        /// </summary>
        void ConvertToExcel();
        /// <summary>
        /// Tregon nese nje operacion printimi eshte i mundur.
        /// </summary>
        bool ReadyToPrint
        {
            get;
            set;
        }

        /// <summary>
        /// dokumenti qe duhet printuar
        /// </summary>
        Janus.Windows.GridEX.GridEXPrintDocument Doc
        {
            get;
            set;
        }
    }
}
