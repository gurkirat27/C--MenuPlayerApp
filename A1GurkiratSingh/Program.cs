using System;
using System.Collections.Generic;

namespace A1GurkiratSingh
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Player> basketball = new List<Player>();
            List<Player> hockey = new List<Player>();
            List<Player> baseball = new List<Player>();

            Player h1 = new HockeyPlayer("Hockey Player", 101, "John Nofel", "Brampton", 10, 3, 4);
            Player h2 = new HockeyPlayer("Hockey Player", 102, "Michell", "Toronto", 12, 4, 2);

            Player bb1 = new BasketballPlayer("Basketball Player", 103, "Ray Roefl", "Edmonton", 13, 23, 10);
            Player bb2 = new BasketballPlayer("Basketball Player", 104, "Mark Joe", "Vaughan", 18, 10, 14);

            Player b1 = new BaseballPlayer("Baseball Player   ", 105, "Nora", "Saskatchewan", 20, 54, 3);
            Player b2 = new BaseballPlayer("Baseball Player", 106, "Stark", "Montreal", 25, 50, 7);



            basketball.Add(bb1);
            basketball.Add(bb2);

            baseball.Add(b1);
            baseball.Add(b2);

            hockey.Add(h1);
            hockey.Add(h2);


            void displayMenu()
            {

                Console.WriteLine("1-Add Player");
                Console.WriteLine("2-Edit Player");
                Console.WriteLine("3-Delete Player");
                Console.WriteLine("4-View Player");
                Console.WriteLine("5-Search Player");
                Console.WriteLine("6-Exit");

            }

            void addMenu()
            {

                Console.WriteLine("1-Add Basketball Player");
                Console.WriteLine("2-Add Baseball Player");
                Console.WriteLine("3-Add Hockey Player");
                Console.WriteLine("4-Main Menu");

            }

            void deleteMenu()
            {

                Console.WriteLine("1-Delete Basketball Player");
                Console.WriteLine("2-Delete Baseball Player");
                Console.WriteLine("3-Delete Hockey Player");
                Console.WriteLine("4-Main Menu");

            }

            void editMenu()
            {

                Console.WriteLine("1-Edit Basketball Player");
                Console.WriteLine("2-Edit Baseball Player");
                Console.WriteLine("3-Edit Hockey Player");
                Console.WriteLine("4-Main Menu");

            }
            Console.WriteLine("----------PLAYER CONSOLE APP-------------");
            MainApp();
            void MainApp()
            {
                
            displayMenu();
            

                int opt;

                Console.WriteLine("     ");

                do
                {
                    Console.WriteLine("Enter Option:");
                    opt = int.Parse(Console.ReadLine());
                    Console.WriteLine("     ");

                    if (opt < 1 || opt > 6 )
                    {

                        Console.WriteLine("Invalid Input");


                    }
                    else
                    {





                        switch (opt)
                        {
                            //-----------------------------------------------------------ADD CASE----------------------------------------------------
                            case 1:
                                addMenu();
                                {
                                    int addOpt;

                                    do
                                    {
                                        Console.WriteLine("Enter Option:");
                                        addOpt = int.Parse(Console.ReadLine());

                                        if (addOpt < 1 || addOpt > 4)
                                        {

                                            Console.WriteLine("Invalid Input!Try Again");


                                        }

                                        else
                                        {

                                            switch (addOpt)
                                            {
                                                case 1:
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("    ");
                                                    Console.WriteLine("    ");
                                                    
                                                  

                                                    Console.Write("Player ID: ");
                                                    int id = int.Parse(Console.ReadLine());

                                                    Console.Write("Player Name: ");
                                                    String name = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string team = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int games = int.Parse(Console.ReadLine());

                                                    Console.Write("Field Goals: ");
                                                    int fieldGoals = int.Parse(Console.ReadLine());

                                                    Console.Write("Three Pointers: ");
                                                    int pointers = int.Parse(Console.ReadLine());


                                                    Player bbPlayer = new BasketballPlayer("Basketball Player", id, name, team, games, fieldGoals, pointers);

                                                    basketball.Add(bbPlayer);
                                                    Console.WriteLine("-------Basketball Player Successfully Addded-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back4 = Console.ReadLine();

                                                    if (back4 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }


                                                    break;

                                                case 2:
                                                    foreach (Player pb in baseball)
                                                    {
                                                        Console.WriteLine(pb);
                                                    }

                                                    Console.WriteLine("    ");
                                                    Console.WriteLine("    ");
                                                    

                                                    Console.Write("Player ID: ");
                                                    int idB = int.Parse(Console.ReadLine());

                                                    Console.Write("Player Name: ");
                                                    String nameB = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string teamB = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int gamesB = int.Parse(Console.ReadLine());

                                                    Console.Write("Runs: ");
                                                    int runs = int.Parse(Console.ReadLine());

                                                    Console.Write("Home Runs: ");
                                                    int homeRuns = int.Parse(Console.ReadLine());


                                                    Player bPlayer = new BaseballPlayer("Baseball Player", idB, nameB, teamB, gamesB, runs, homeRuns);

                                                    baseball.Add(bPlayer);
                                                    Console.WriteLine("-------Baseball Player Successfully Addded-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in baseball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }



                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back5 = Console.ReadLine();

                                                    if (back5 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }



                                                    break;

                                                case 3:
                                                    foreach (Player ph in hockey)
                                                    {
                                                        Console.WriteLine(ph);
                                                    }

                                                    Console.WriteLine("    ");
                                                    Console.WriteLine("    ");
                                                    

                                                    Console.Write("Player ID: ");
                                                    int idH = int.Parse(Console.ReadLine());

                                                    Console.Write("Player Name: ");
                                                    String nameH = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string teamH = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int gamesH = int.Parse(Console.ReadLine());

                                                    Console.Write("Assist: ");
                                                    int assist = int.Parse(Console.ReadLine());

                                                    Console.Write("Goals: ");
                                                    int goals = int.Parse(Console.ReadLine());


                                                    Player hPlayer = new HockeyPlayer("Hockey Player", idH, nameH, teamH, gamesH, assist, goals);

                                                    hockey.Add(hPlayer);
                                                    Console.WriteLine("-------Hockey Player Successfully Addded-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in hockey)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back6 = Console.ReadLine();

                                                    if (back6 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }


                                                    break;

                                                case 4:




                                                    
                                                    MainApp();
                                                    break;

                                            }
                                            break;









                                        }



                                    } while (addOpt < 1 || addOpt > 4);








                                    break;












                                }
                            //---------------------------------------EDIT  CASE------------------------------------------------------------
                            case 2:





                                editMenu();
                                {

                                    int editOpt;

                                    do
                                    {
                                        Console.WriteLine("Enter Option:");
                                        editOpt = int.Parse(Console.ReadLine());

                                        if (editOpt < 1 || editOpt > 4)
                                        {

                                            Console.WriteLine("Invalid Input!Try Again");


                                        }
                                        else
                                        {



                                            switch (editOpt)
                                            {
                                                case 1:
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }
                                                    Console.Write("Enter Player Id to Edit:");
                                                    int editId = int.Parse(Console.ReadLine());

                                                    Player bb = basketball.Find(e => e.PlayerId.Equals(editId));
                                                    int i = basketball.IndexOf(bb);
                                                    basketball.RemoveAt(i);





                                                    

                                                    Console.Write("Player Name: ");
                                                    String name = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string team = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int games = int.Parse(Console.ReadLine());

                                                    Console.Write("Field Goals: ");
                                                    int fieldGoals = int.Parse(Console.ReadLine());

                                                    Console.Write("Three Pointers: ");
                                                    int pointers = int.Parse(Console.ReadLine());




                                                    //  basketball.Add(bbPlayer);


                                                    basketball.Insert(i, new BasketballPlayer("Basketball Player", editId, name, team, games, fieldGoals, pointers));



                                                    
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }


                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back1 = Console.ReadLine();

                                                    if (back1 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }



                                                    break;

                                                case 2:
                                                    foreach (Player pb in baseball)
                                                    {
                                                        Console.WriteLine(pb);
                                                    }




                                                    Console.Write("Enter Player Id to Edit:");
                                                    editId = int.Parse(Console.ReadLine());

                                                    Player b = baseball.Find(e => e.PlayerId.Equals(editId));
                                                    int j = baseball.IndexOf(b);
                                                    baseball.RemoveAt(j);





                                                    

                                                    Console.Write("Player Name: ");
                                                    String nameB = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string teamB = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int gamesB = int.Parse(Console.ReadLine());

                                                    Console.Write("Runs: ");
                                                    int runsB = int.Parse(Console.ReadLine());

                                                    Console.Write("HomeRuns: ");
                                                    int homeRunsB = int.Parse(Console.ReadLine());







                                                    baseball.Insert(j, new BaseballPlayer("Baseball Player", editId, nameB, teamB, gamesB, runsB, homeRunsB));



                                                    Console.WriteLine("    ");
                                                    foreach (Player p in baseball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back2 = Console.ReadLine();

                                                    if (back2 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }



                                                    break;
                                                case 3:
                                                    foreach (Player ph in hockey)
                                                    {
                                                        Console.WriteLine(ph);
                                                    }



                                                    Console.Write("Enter Player Id to Edit:");
                                                    editId = int.Parse(Console.ReadLine());

                                                    Player h = hockey.Find(e => e.PlayerId.Equals(editId));
                                                    int k = hockey.IndexOf(h);
                                                    hockey.RemoveAt(k);





                                                   
                                                    Console.Write("Player Name: ");
                                                    String nameH = Console.ReadLine();

                                                    Console.Write("Team: ");
                                                    string teamH = Console.ReadLine();

                                                    Console.Write("Games Played: ");
                                                    int gamesH = int.Parse(Console.ReadLine());

                                                    Console.Write("Assist: ");
                                                    int assistH = int.Parse(Console.ReadLine());

                                                    Console.Write("Goals: ");
                                                    int goalsB = int.Parse(Console.ReadLine());







                                                    hockey.Insert(k, new BaseballPlayer("Hockey Player", editId, nameH, teamH, gamesH, assistH, goalsB));




                                                    Console.WriteLine("    ");
                                                    foreach (Player p in hockey)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back3 = Console.ReadLine();

                                                    if (back3 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }



                                                    break;

                                                case 4:
                                                    MainApp();
                                                    break;

                                            }
                                            break;



                                        }
                                    } while (editOpt < 1 || editOpt > 4);


                                    break;
                                }
                            //---------------------------------------REMOVE  CASE------------------------------------------------------------

                            case 3:

                                deleteMenu();
                                {

                                    int delOpt;

                                    do
                                    {
                                        Console.WriteLine("Enter Option:");
                                        delOpt = int.Parse(Console.ReadLine());

                                        if (delOpt < 1 || delOpt > 4)
                                        {

                                            Console.WriteLine("Invalid Input!Try Again");


                                        }
                                        else
                                        {



                                            switch (delOpt)
                                            {
                                                case 1:
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }
                                                    Console.Write("Enter Player Id to delete:");
                                                    int delId = int.Parse(Console.ReadLine());
                                                    //int j = basketball.FindIndex(delId);

                                                    Player bb = basketball.Find(e => e.PlayerId.Equals(delId));
                                                    int i = basketball.IndexOf(bb);

                                                    basketball.RemoveAt(i);

                                                    Console.WriteLine("-------Basketball Player Successfully Deleted-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in basketball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }



                                                    
                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back7 = Console.ReadLine();

                                                    if (back7 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }

                                                    break;

                                                case 2:
                                                    foreach (Player pb in baseball)
                                                    {
                                                        Console.WriteLine(pb);
                                                    }




                                                    Console.Write("Enter Player Id to delete:");
                                                    int delIdB = int.Parse(Console.ReadLine());
                                                    //int j = basketball.FindIndex(delId);

                                                    Player b = baseball.Find(e => e.PlayerId.Equals(delIdB));
                                                    int j = baseball.IndexOf(b);

                                                    baseball.RemoveAt(j);

                                                    Console.WriteLine("-------Baseball Player Successfully Deleted-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in baseball)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back8 = Console.ReadLine();

                                                    if (back8 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }


                                                    break;
                                                case 3:
                                                    foreach (Player ph in hockey)
                                                    {
                                                        Console.WriteLine(ph);
                                                    }



                                                    Console.Write("Enter Player Id to delete:");
                                                    int delIdH = int.Parse(Console.ReadLine());
                                                    //int j = basketball.FindIndex(delId);

                                                    Player h = hockey.Find(e => e.PlayerId.Equals(delIdH));
                                                    int k = hockey.IndexOf(h);

                                                    hockey.RemoveAt(k);

                                                    Console.WriteLine("-------Hockey Player Successfully Deleted-------------------");
                                                    Console.WriteLine("    ");
                                                    foreach (Player p in hockey)
                                                    {
                                                        Console.WriteLine(p);
                                                    }

                                                    Console.WriteLine("Press 1 to return to main menu:");
                                                    String back9 = Console.ReadLine();

                                                    if (back9 == "1")
                                                    {
                                                        Console.Clear();


                                                        MainApp();
                                                    }



                                                    break;

                                                case 4:
                                                    MainApp();
                                                    break;

                                            }
                                            break;



                                        }
                                    } while (delOpt < 1 || delOpt > 4);





                                    break;



                                }

                            //-----------------------------------------------------------------VIEW CASE--------------------------------------------
                            case 4:
                                {
                                    Console.WriteLine("Basketball Players");


                                    foreach (Player p in basketball)
                                    {
                                        Console.WriteLine(p);
                                    }

                                    Console.WriteLine("   ");
                                    Console.WriteLine("   ");

                                    Console.WriteLine("Baseball Players");

                                    foreach (Player pb in baseball)
                                    {
                                        Console.WriteLine(pb);
                                    }

                                    Console.WriteLine("   ");
                                    Console.WriteLine("   ");

                                    Console.WriteLine("Hockey Players");
                                    foreach (Player ph in hockey)
                                    {
                                        Console.WriteLine(ph);
                                    }

                                    Console.WriteLine("Press 1 to return to main menu:");
                                    String backS = Console.ReadLine();

                                    if (backS == "1")
                                    {
                                        Console.Clear();
                                        MainApp();
                                    }


                                }
                                break;



                            //-----------------------------------------------------SEARCH CASE-----------------------------------------------------

                            case 5:

                                Console.WriteLine("Search a player");
                                Console.WriteLine("  ");
                                Console.WriteLine("Enter Player Name:");
                                String searchP = Console.ReadLine();
                                Console.WriteLine("   ");

                                Player e = basketball.Find(e => e.PlayerName.Contains(searchP));
                                Player f = baseball.Find(e => e.PlayerName.Contains(searchP));
                                Player g = hockey.Find(e => e.PlayerName.Contains(searchP));
                                Console.WriteLine(e);
                                Console.WriteLine(f);
                                Console.WriteLine(g);

                                Console.WriteLine("Press 1 to return to main menu:");
                                String backP = Console.ReadLine();

                                if (backP == "1") {
                                    Console.Clear();


                                    MainApp();
                                }



                                break;

                            //----------------------------------------------EXIT CASE--------------------------------------------------
                            case 6:
                                Environment.Exit(0);
                                break;


                        }










                    }


                } while (opt < 0 || opt >= 6);












            }
        }
        
    }
    
}
