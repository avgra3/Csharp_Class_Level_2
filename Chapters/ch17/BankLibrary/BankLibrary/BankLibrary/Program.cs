//
// Antony Gradillas 10/10/2023
// CIS262AD - Fall 2023
// Class 15677
//
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankLibrary
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main( string[] args )
      {
         Application.EnableVisualStyles();
         Application.Run(new BankUIForm());
      }
   }
}