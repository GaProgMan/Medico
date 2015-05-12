using System;
using System.Collections.Generic;
using System.Diagnostics;
using NDesk.Options;

namespace Medico
{
	public class MainClass
    {
		public static void Main (string[] args)
		{
			if (args.Length > 0)
			{
				// There are arugments, parse them
                ParseArguments(args);
			}
			else
			{
				// There are no arguments, call the GUI
                Console.WriteLine("Supplied no arguments, calling the GUI");
                GuiCall();
			}
		}

        /// <summary>
        /// Parses the arguments passed into the command line interface
        /// </summary>
        /// <param name="args">Arguments.</param>
		static void ParseArguments(string[] args)
		{
            var show_help = false;

            var p = new OptionSet () {
                { "h|help",  "show this message and exit", v => show_help = v != null },
                { "g|gui", "call the gui", v => GuiCall() },
                { "scheduler", "initialise the scheduler", v => InitialiseScheduler() }
            };

            List<string> extra;
            try {
                extra = p.Parse (args);
            }
            catch (OptionException e) {
                Console.Write ("medico: ");
                Console.WriteLine (e.Message);
                Console.WriteLine ("Try `medico --help' for more information.");
                return;
            }

            // we have some unused arguments

            show_help |= extra.Count > 0;

            if (show_help) {
                ShowHelp (p);
                return;
            }
		}

        /// <summary>
        /// Shows the help text on the console
        /// </summary>
        /// <param name="p">The option set</param>
        static void ShowHelp (OptionSet p)
        {
            Console.WriteLine ("Usage: medico [OPTIONS]");
            Console.WriteLine ("Call the medico system from the command line");
            Console.WriteLine ();
            Console.WriteLine ("Options:");
            p.WriteOptionDescriptions (Console.Out);
        }

        /// <summary>
        /// Calls the main GUI of medico
        /// </summary>
        static void GuiCall()
        {
            Debug.WriteLine("you just called the GUI");
            var gui = new BeaJay.Gui();
            gui.ShowGui();
        }

        /// <summary>
        /// Initialises the scheduler service
        /// </summary>
        static void InitialiseScheduler()
        {
            Debug.WriteLine("You just called the scheduler");
        }
	}
}
