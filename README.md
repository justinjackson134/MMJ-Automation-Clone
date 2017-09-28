# MMJ-Automation

*** PLEASE NOTE THAT THIS IS A DIRECT CLONE OF A REPOSITORY CREATED FOR CPT_S 322 IN FALL 2016 ***
*** THE CONTENTS ARE COPIED HERE SO THAT I MAY RETAIN A COPY AS THE REPO WAS ON 12/24/2016 ***


Team Info:
Matthew Bouland (Contact person)
EECS: Mbourlan
Email: matthew.bourland@wsu.edu

Mike Nulle
EECS: mnulle
Email: michael.nulle@wsu.edu

Justin Jackson
EECS: jjackson
Email: justin.jackson@wsu.edu

Matt, Mike, Justin CS322



Running the Program:

In order to run our graphical automata tool, download the most recent AutomataGuiBuild, or the most recent AutomataGui. AutomataGuiBuild is the pre-built version that does not require Visual Studio to run, AutomataGui is the solution file that can be ran and edited inside of visual studio.

To run the Built version, download and extract the file. Click on the exe file to install the tool. All functions are handled by the menu bar along the top of the form. For an in-depth walkthrough of the operation of this tool, see the "Quickstart Guide" which is shown in the top left portion of the graphical tool.

To run the Visual Studio version, download and extract the solution. Open it in Visual Studio and use the run program function in the editor to run the program. Default keybind F5.

Please note that both versions contains three sample automata files named a, b, and c which can be loaded into the GUI to produce a quick visual of the tools functionality without the need to add additional automata.

Transcription of Quickstart Guide from GUI

To use this program, either select 'File'->'Load' to load an existing automata, or begin adding information to the forms below.

Once your automata is fully entered, click 'Update Finite Automata' below, this will load your automata into the system, and inform you of any errors encountered during processing. 

Note: Alphabet symbols may only be 1 character in length

Once your data is entered you may begin entering test words and press the adjacent 'Test' button to check if the entered word is valid.

At any point you may use 'File'->'Save As' to save your progress. You may also use 'File'->'Create New' to delete all data from all forms.

Testing Instructions:To run various test cases click "Debugging Test" button on the toolbar. The drop down menu conatins 5 testing options: 

1) No Path to Accepting: This will handle to case of passing a word into an automaton object that has no way to get to an accepting state.

2) Circular Path: This test will handle the case of passing a word into an automaton object that contains a loop within the states of the automaton.
   
3) Standard Success: This test will handle the case of passing in a word that should be accepted by an automaton object.
   
4) Standard Fail: This test will handle the case of passing a word that should not be accepted by an automaton object.
   
5) Invalid Alphabet: This test will handle the case of trying to go through a transition whos data field is not included in the alphabet (automaton is not represented right).
   
Each test option will open a window that presents you with a message regarding if the test was successful or failed. You can either run these tests individually or all of them by clicking "run all" in the drop down menu. Clicking "run all" will present the user with which tests failed and which were successful.
