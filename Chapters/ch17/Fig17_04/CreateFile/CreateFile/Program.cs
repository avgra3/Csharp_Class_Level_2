﻿//
// Antony Gradillas 10/09/2023
// CIS262AD - Fall 2023
// Class 15677
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreateFile
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
         Application.Run(new CreateFileForm());
      }
   }
}