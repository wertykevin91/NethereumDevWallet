﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NethereumDevWallet
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
            InitializeEntryForm();
            Application.Run();
        }

        private static void InitializeEntryForm()
        {
            var mainForm = new EntryForm();
            mainForm.Show();
        }
    }
}
