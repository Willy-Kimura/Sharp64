#region Copyright

/*
 * Developer: Willy Kimura.
 * Product:   Sharp64 - A Base64 Encoder/Decoder
 * License:   MIT
 * 
 * A product of Willy Kimura.
 * Copyright (c) 2020.
 * 
 */

#endregion


using System;
using System.Windows.Forms;

namespace WK.Apps.Sharp64
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Views.MainForm());
        }
    }
}