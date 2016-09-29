using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;


/*
 * Programmers: Matt Bourland, Justin Jackson
 * CS322 9/28/16
 * 
 * This program is a console application that can create a new xml file or
 * load an existing xml file (print contents of xml to console). It can only
 * load xml files that have been created using this software. The xml file format
 * defined in this file creator/reader is unique for our purposes.
 * 
 * XML document format:
 * Input alphabet
 * States (Nodes)
 * Initial state
 * accepting states
 * Transition set
*/



namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_intput = "";
            string load_file_name = "";
            string save_file_name = "";
            
            //storage for creating
            string start_thing = "";
            string input_alphabet = "";
            string state_set = "";
            string initial_state = "";
            string accepting_states = "";
            string transition_set = "";

            while (true)
            {
                //menu
                Console.Clear();
                Console.WriteLine("1. Load XML File");
                Console.WriteLine("2. Create new XML File");
                Console.WriteLine("3. Exit");
                user_intput = Console.ReadLine();


                if (user_intput == "1") //load xml file
                {
                    Console.Clear();
                    Console.WriteLine("Enter filename to load: ");
                    load_file_name = Console.ReadLine();


                    //loop for displaying 
                    XElement allData = XElement.Load(load_file_name);
                    if (allData != null)
                    {
                        IEnumerable<XElement> elements = allData.Elements().Descendants(); //here
                        foreach (XElement element in elements)
                        {
                            Console.WriteLine((string)element);
                            Console.WriteLine("");
                        }
                    }
                    Console.WriteLine("Press enter to return to main menu...");
                    Console.ReadLine();


                }
                if (user_intput == "2") //Create new XML file
                {
                    //prompt user for automota information
                    Console.WriteLine("Enter filename to save: ");
                    save_file_name = Console.ReadLine();
                    Console.WriteLine("Enter Input alphabet: ");
                    input_alphabet = Console.ReadLine();
                    Console.WriteLine("Enter States: ");
                    state_set = Console.ReadLine();
                    Console.WriteLine("Enter Initial State: ");
                    initial_state = Console.ReadLine();
                    Console.WriteLine("Enter Accepting States: ");
                    accepting_states = Console.ReadLine();
                    Console.WriteLine("Enter Transition Set: ");
                    transition_set = Console.ReadLine();

                    // Create a root node
                    XElement automotas = new XElement("Automata");

                    // Add child nodes
                    XAttribute start = new XAttribute("Automata_", start_thing); //here

                    XElement in_alphabet = new XElement("inputAlphabet", input_alphabet);
                    XElement s_set = new XElement("stateSet", state_set);
                    XElement in_state = new XElement("intialState", initial_state);
                    XElement acc_states = new XElement("acceptingStates", accepting_states);
                    XElement trans_set = new XElement("transitionSet", transition_set);
                    XElement automota = new XElement("automata");
                    automota.Add(start);
                    automota.Add(in_alphabet);
                    automota.Add(s_set);
                    automota.Add(in_state);
                    automota.Add(acc_states);
                    automota.Add(trans_set);
                    automotas.Add(automota);

                    //Save file
                    automotas.Save(save_file_name);
                    Console.WriteLine("");
                    Console.WriteLine("File created!");
                    Console.WriteLine("Press enter to return to main menu...");
                    Console.ReadLine();
                }

                if (user_intput == "3") //exit program
                {
                    break;
                }
            }
        }
    }
}
