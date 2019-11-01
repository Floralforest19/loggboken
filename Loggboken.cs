// ===============================
// AUTHOR           : Mikaela Fryklund
// CREATE DATE      : 2017-06-21
// PURPOSE          : NTI - Övning 3 - Loggboken 
//==================================

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace upg2rygg
{
	class program
	{
		public static void Main()
		{
			//Welcome startup message
			Console.WriteLine("Välkommen till loggboken");
			//Create menu option array
			string[] Menyoptions = new string[] { "Meny", "Skriv nytt inlägg i loggboken", "Skriv ut alla loggar", "Radera från loggboken", "Sök inlägg i loggboken", "Avsluta" };
			//Create empty Loggbook List. (Easier to add/remove content from a list than an array.)
			List<string> Loggbook = new List<string>();
			//Loop program
			while (true)
			{
				//print menu
				for (int i = 1; i < Menyoptions.Length; i++)
				{
					string s = Menyoptions[i];
					Console.WriteLine("[" + i + "] " + s);
				}
				Console.WriteLine("välj:");

				try
				{
					//Get selected menu option from user
					int i = int.Parse(System.Console.ReadLine());
					//Test "i" against predefined menu options. Return if no result could be found
					switch (i)
					{
						//Case 1 - Add content to logg
						case 1:
							{
								//Tell user that writing exit will let them return to main menu
								System.Console.WriteLine("Skriv 'exit' för att återgå till menyn");
								while (true)
								{
									System.Console.WriteLine(Menyoptions[i] + ": ");
									string q_newcontent = Console.ReadLine();
									//If userinput == exit. Return to main menu
									if (q_newcontent == "exit")
									{
										break;
									}
									//Else add content to loggbook
									Loggbook.Add(q_newcontent);
								}
								break;
							}
						//Case 2 - List loggbook content
						case 2:
							{
								//Echo selected menu option + Amount stored in Loggbook
								System.Console.WriteLine(Menyoptions[i]);
								System.Console.WriteLine("Du har totalt " + Loggbook.Count + " inlägg");
								//Loop content. Echo each thing
								foreach (string thing in Loggbook)
								{
									System.Console.WriteLine(thing);
								}
								//Wait for Enter key to be clicked before returning to menu.
								System.Console.WriteLine("Tryck på 'Enter' för att återgå");
								Console.ReadLine();
								break;
							}
						//Case 3 remove entry from logg
						case 3:
							{
								//Echo selected menu option + information
								System.Console.WriteLine(Menyoptions[i]);
								System.Console.WriteLine("Skriv 'exit' för att återgå till menyn");
								while (true)
								{
									//Check if logg is empty
									if (Loggbook.Count == 0)
									{
										Console.WriteLine("Din loggbok är tom. Tryck 'Enter' för att återgå");
										Console.ReadLine();
										break;
									}

									//Loop logg content. Echo content plus key
									for (int i2 = 0; i2 < Loggbook.Count; i2++)
									{
										string s = Loggbook[i2];
										Console.WriteLine("[" + i2 + "] " + s);
									}

									//Ask the user for a index key
									Console.WriteLine("Ange nr på det du vill radera:");
									string q_erasestuff = System.Console.ReadLine();

									//If exit. Break loop, return to menu
									if (q_erasestuff == "exit")
									{
										break;
									}
									//If supplied key does'nt exit in loggbook. Tell user
									else if (Loggbook.Count < int.Parse(q_erasestuff))
									{
										Console.WriteLine("Objektet finns inte!");
									}
									//Else. Remove selected object from list
									else
									{
										Console.WriteLine("Du har nu tagit bort: " + Loggbook[int.Parse(q_erasestuff)]);
										Loggbook.RemoveAt(int.Parse(q_erasestuff));
									}
								}
								//Break back to menu
								break;
							}
						//Search logg
						case 4:
							{
								System.Console.WriteLine(Menyoptions[i]);
                                Console.WriteLine("Vad söker du?");
                                string q_search = System.Console.ReadLine();

								//Loop logg content. Echo content plus key
								for (int i2 = 0; i2 < Loggbook.Count; i2++)
								{
									string t = Loggbook[i2];
                                    string h = Loggbookheader[i2] 
                                    if((s.IndexOf(q_search, 0, s.Length) != -1) || (h.IndexOf(q_search, 0, h.Length) != -1)){
                                        Console.WriteLine("["+ m +"]" + s);
                                    }
									//Console.WriteLine("[" + i2 + "] " + s);
								}
                                break;

							}
                            //Terminate program
						case 5:
							{
								System.Console.WriteLine(Menyoptions[i]);
								Environment.Exit(0);
								break;
							}
						//If invalid number. Reprint menu
						default:
							{
								System.Console.WriteLine("Invalid number");
								break;
							}
					}
				}
				catch
				{
					//Catch errors....
				}
			} // End of loop 1

		} //Main()
	}
}
