﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReshetoE
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db")) 
            {
                new Database("dataSource=dataBase.db").InitializeDatabase();
            }
            Application.Run(new Authorization());
        }
    }
}
