//***************************************************************************
//
//  Troy DeClerck       - Z1877438
//  Brandon Anzalone    - Z1884778
//  CSCI 473/504        Assignment 3
//
//  We certify that this is our own work and where appropriate an extension
//  of the starter code provided for the assignment
//***************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Specialized;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        // File Paths
        public static string GuildFile = @"..\..\guilds.txt";
        public static string PlayerFile = @"..\..\players.txt";

        // Dictionary declarations
        public static Dictionary<uint, Player> PlayerDictionary = new Dictionary<uint, Player>();
        public static Dictionary<uint, Guild> GuildDictionary = new Dictionary<uint, Guild>();

        string selectedRadioBtn = "";

        public Form1()
        {
            InitializeComponent();
        }
         /**
         * Reads the Player file and stores them into a dictionary.
         * 
         * Converts each input separated by tabs and adds them to 
         * a previously defined player dictionary.
         * 
         * @param input - The name of the input file to be read.
         ****************************************************************************/
        private void ReadPlayers(string input)
        {
            // String to read lines into
            string inputLine;

            // Try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    inputLine = inFile.ReadLine();

                    while (inputLine != null)
                    {
                        // Separate with tab
                        string[] inPlayers = inputLine.Split('\t');
                        // If the correct number of attributes are on the line, create a player from line
                        if (inPlayers.Length == 8)
                        {
                            AddPlayer(Convert.ToUInt32(inPlayers[0]), inPlayers[1], (Race)Convert.ToUInt32(inPlayers[2]), (Classes)Convert.ToUInt32(inPlayers[3]),
                                        (Role)Convert.ToUInt32(inPlayers[4]), Convert.ToUInt32(inPlayers[5]), Convert.ToUInt32(inPlayers[6]), Convert.ToUInt32(inPlayers[7]));

                        }

                        // Read next line
                        inputLine = inFile.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
                Environment.Exit(1);
            }
        }

        // Refactored AddPlayer function
        private void AddPlayer(uint newID, string newName, Race newPlayerRace, Classes newPlayerClass, Role newPlayerRole, uint newLevel, uint newExp, uint newGuildID)
        {
            // Create the player from the array, convert string to uints and other attributes when necessary
            Player inputPlayer = new Player(newID, newName, newPlayerRace, newPlayerClass, newPlayerRole, newLevel, newExp, newGuildID);

            // Add to dictionary of players
            PlayerDictionary.Add(inputPlayer.Id, inputPlayer);
        }
         /**
         * Reads the Guild file and stores them into a dictionary.
         * 
         * Converts each input separated by tabs and adds them to 
         * a previously defined guild dictionary.
         * 
         * @param input - The name of the input file to be read.
         ****************************************************************************/
        private void ReadGuilds(string input)
        {
            // String to read lines into
            string inputLine;

            // Try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    inputLine = inFile.ReadLine();

                    while (inputLine != null)
                    {
                        // Separate with tab
                        string[] inGuilds = inputLine.Split('\t');
                        // If the correct number of attributes are on the line, create a guild from line
                        if (inGuilds.Length == 3)
                        {
                            string[] GuildServer = inGuilds[2].Split('-');
                            AddGuild(Convert.ToUInt32(inGuilds[0]), (GuildTypes)Convert.ToUInt32(inGuilds[1]), GuildServer[0], GuildServer[1]);
                        }

                        // Read next line
                        inputLine = inFile.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
                Environment.Exit(1);
            }
        }

        // Refactored Guild Add
        private void AddGuild(uint guildId, GuildTypes guildType, string guildName, string guildServer)
        {
            Guild inputGuild = new Guild(guildId, guildType, guildName, guildServer);

            // Add to dictionary of items
            GuildDictionary.Add(inputGuild.Id, inputGuild);
        }
        /**
        * Searches Guild and Player dictionary to find the classes on a server
        * 
        * Uses 3 LINQ's to create one large LINQ to find all the classes by server.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void SearchAllClassTypes(object sender, EventArgs e)
        {
            Query_Box.Clear();

            // Check to see if selections were made
            if (Class_Combobox.SelectedIndex != -1 && Server_Combobox1.SelectedIndex != -1)
            {
                Query_Box.Text += string.Format("All {0}s From {1}\n", Class_Combobox.SelectedItem, Server_Combobox1.SelectedItem);
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";

                var ClassSort =
                    from N in PlayerDictionary
                    where N.Value.PlayerClass.Equals(Class_Combobox.SelectedItem)
                    select N;

                var ServerSort =
                    from M in GuildDictionary
                    where M.Value.Server.Equals(Server_Combobox1.SelectedItem)
                    select M;

                var FinalSort =
                    from M in ServerSort
                    from N in ClassSort
                    where (N.Value.GuildID == M.Value.Id)
                    orderby N.Value.Level ascending
                    orderby N.Value.GuildID ascending
                    select N;


                foreach (var result in FinalSort)
                {
                    Query_Box.Text += result.Value;
                }

                Query_Box.Text += string.Format("\nEND RESULTS \n");
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";
            }
            else
                Query_Box.Text += String.Format("BOTH SELECTIONS MUST BE MADE\n");


        }
        /**
        * Searches Guild and Player dictionary to find percentage of reces on a single server
        * 
        * Uses 3 LINQ's to create one large LINQ to find all the races by server.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void SearchPercentage(object sender, EventArgs e)
        {
            Query_Box.Clear();

            // Check to see if selection was made
            if (Server_Combobox2.SelectedIndex != -1)
            {
                Query_Box.Text += string.Format("Percentage of Each Race from {0}\n", Server_Combobox2.SelectedItem);
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";

                var FindServer =
                    from S in GuildDictionary
                    where S.Value.Server.Equals(Server_Combobox2.SelectedItem)
                    select S;

                var FindPlayers =
                    from P in PlayerDictionary
                    from S in FindServer
                    where (P.Value.GuildID == S.Value.Id)
                    select P;

                double TotalPlayers = (
                    from A in FindPlayers
                    select A
                    ).Count();

                var TotalRaces =
                    from P in FindPlayers
                    group P by P.Value.PlayerRace into RaceGroup
                    orderby RaceGroup.Key ascending
                    select new
                    {
                        Races = RaceGroup.Key,
                        Count = RaceGroup.Count() / TotalPlayers
                    };

                foreach (var result in TotalRaces)
                {
                    Query_Box.Text += String.Format("{0}:    \t {1:P2}\n", result.Races, result.Count);
                }

                Query_Box.Text += string.Format("\nEND RESULTS \n");
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";
            }
            else
                Query_Box.Text += String.Format("A SERVER MUST BE CHOSEN\n");

        }

        /**
        * Searches Guild and Player dictionary to select all roles from a single
        * server with a level range
        * 
        * Uses 2 LINQ's to create one large LINQ to find all the roles in one sever
        * by range of two numeric updowns values'
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void SelectLevelRange(object sender, EventArgs e)
        {
            Query_Box.Clear();

            if(Min_UpDown.Value > Max_UpDown.Value)
            {
                Max_UpDown.Value = Min_UpDown.Value;
            }
            if(Max_UpDown.Value < Min_UpDown.Value)
            {
                Min_UpDown.Value = Max_UpDown.Value;
            }


            if (Server_Box3.SelectedIndex != -1 && RoleBox.SelectedIndex != -1 && (Min_UpDown.Value <= Max_UpDown.Value))
            {

                Query_Box.Text += string.Format("All {0} From [{1}], Levels {2} to {3} \n", RoleBox.SelectedItem, Server_Box3.SelectedItem, Min_UpDown.Value, Max_UpDown.Value);
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";


                var FindServer =
                     from A in GuildDictionary
                     where A.Value.Server.Equals(Server_Box3.SelectedItem)
                     select A;

                var FindRole =
                    from B in PlayerDictionary
                    from A in FindServer
                    where ((B.Value.GuildID == A.Value.Id) && (B.Value.Level >= Min_UpDown.Value) && (B.Value.Level <= Max_UpDown.Value) && (B.Value.PlayerRole.Equals(RoleBox.SelectedItem)))
                    select new
                    {
                        playerName = B.Value.Name,
                        playerClass = B.Value.PlayerClass,
                        playerRole = B.Value.PlayerRole,
                        playerRace = B.Value.PlayerRace,
                        playerLevel = B.Value.Level,
                        playerGuild = A.Value.Name
                    };

                    foreach (var result in FindRole)
                    {
                        Query_Box.Text += String.Format("Name: {0,-10}({1,-7} - {2,-6})   Race: {3,-8} Level: {4,2}    <{5}>\n", result.playerName, result.playerClass, result.playerRole, result.playerRace, result.playerLevel, result.playerGuild);
                    }

                Query_Box.Text += string.Format("\nEND RESULTS \n");
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";
            }
            else
            {
                MessageBox.Show("Error Please Select Something from the Form.", "Level Range Error", MessageBoxButtons.OK);
            }
        }

        /**
        * Searches Guild dictionary to find all guilds by type
        * 
        * Uses 1 LINQ to find all guilds of one type, then outputs them formatted by
        * the server they reside in
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void ShowAllGuildsSingleType(object sender, EventArgs e)
        {
            Query_Box.Clear();

            string holdServer = "";

            Query_Box.Text += string.Format("All {0}-Type of Guilds \n", Type_ComboBox.SelectedItem);
            Query_Box.Text += new string('-',80);
            Query_Box.Text += "\n";

            if (Type_ComboBox.SelectedIndex != -1)
            {
                var FindGuilds =
                    from N in GuildDictionary
                    where N.Value.Type.Equals(Type_ComboBox.SelectedItem)
                    group N by (N.Value.Server, N.Value.Name) into A
                    select new
                    {
                        server = A.Key.Server,
                        guildName = A.Key.Name
                    };

                foreach (var result in FindGuilds.OrderBy(servers => servers.server))
                {
                    if(holdServer != result.server)
                    {
                        Query_Box.Text += string.Format("{0} \n", result.server);
                        holdServer = result.server;
                    }
                    Query_Box.Text += String.Format("\t <{0}> \n",result.guildName);
                }

                Query_Box.Text += string.Format("\nEND RESULTS \n");
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";
            }
            else
            {
                MessageBox.Show("Error Please Select Something from the Form.", "Guild Type Error", MessageBoxButtons.OK);
            }

        }
        /**
        * Populates all the forms combo boxes
        * 
        * Population of forms combo Boxes.
        * 
        ****************************************************************************/
        private void FillComboBox()
        {
            foreach(KeyValuePair<uint,Player> pair in PlayerDictionary)
            {
                if(!Class_Combobox.Items.Contains(pair.Value.PlayerClass))
                    Class_Combobox.Items.Add(pair.Value.PlayerClass);

                if (!RoleBox.Items.Contains(pair.Value.PlayerRole))
                    RoleBox.Items.Add(pair.Value.PlayerRole);
            }

            foreach(KeyValuePair<uint, Guild> guildPair in GuildDictionary)
            {
                if (!Server_Combobox1.Items.Contains(guildPair.Value.Server))
                    Server_Combobox1.Items.Add(guildPair.Value.Server);

                if (!Server_Combobox2.Items.Contains(guildPair.Value.Server))
                    Server_Combobox2.Items.Add(guildPair.Value.Server);

                if (!Server_Box3.Items.Contains(guildPair.Value.Server))
                    Server_Box3.Items.Add(guildPair.Value.Server);

                if (!Type_ComboBox.Items.Contains(guildPair.Value.Type))
                    Type_ComboBox.Items.Add(guildPair.Value.Type);
            }
        }

        /**
        * The initial function called as the form loads
        * 
        * Reads the guild and player text files as well as all necesarry
        * combo boxes.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void Form1_Load(object sender, System.EventArgs e)
        {
            ReadGuilds(GuildFile);
            ReadPlayers(PlayerFile);
            FillComboBox();
        }

        /**
        * Monitors the value of the Min_Updowns value 
        * 
        * On Min_upDowns click event, checks to see that the value is less than the max
        *  UpDowns value and not = 0, If value is greater takes max_UpDowns value increments it
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void Min_UpDown_Click(object sender, EventArgs e)
        {
            if (Min_UpDown.Value > Max_UpDown.Value && Min_UpDown.Value != 0)
            {
                if(Max_UpDown.Value != 1)
                {
                    Max_UpDown.Value = Min_UpDown.Value + 1;
                }
            }
        }
        /**
        * Monitors the value of the Max_Updowns value 
        * 
        * On Max_upDowns click event, checks to see that the value is less than the Min
        *  UpDowns value and not = 0, If value is less then, takes Min_UpDowns value decrements it
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void Max_UpDown_Click(object sender, EventArgs e)
        {
            if (Max_UpDown.Value < Min_UpDown.Value && Max_UpDown.Value != 0)
            {
                if (Min_UpDown.Value != 1)
                {
                    Min_UpDown.Value = Max_UpDown.Value - 1;
                }
            }
        }

        /**
        * Finds the percentage of max leveled players in every guild
        * 
        * Uses a set of LINQ queries to find players in each guild, find the max
        * leveled players out of that list, and prints out the percentage.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void MaxLevelPercent(object sender, EventArgs e)
        {
            Query_Box.Clear();

            Query_Box.Text += "Percentage of Max Level Players in All Guilds\n";
            Query_Box.Text += new string('-', 80);
            Query_Box.Text += "\n";

            foreach (KeyValuePair<uint, Guild> pair in GuildDictionary)
            {
                var FindPlayers =
                    from P in PlayerDictionary
                    where (P.Value.GuildID == pair.Key)
                    select P;

                var MaxPlayers =
                    from P in FindPlayers
                    where (P.Value.Level == 60)
                    select P;

                double TotalPlayers = (
                    from P in FindPlayers
                    select P
                    ).Count();

                double MaxTotalPlayers = (
                    from P in MaxPlayers
                    select P
                    ).Count();

                var FindPercent =
                    from P in MaxPlayers
                    group P by pair.Value.Name into GuildNames
                    orderby GuildNames.Key ascending
                    select new
                    {
                        Guilds = GuildNames.Key,
                        Count = MaxTotalPlayers / TotalPlayers
                    };

                foreach (var match in FindPercent)
                {
                    Query_Box.Text += String.Format("{0,-30}{1:P2}\n\n", pair.Value, match.Count);
                }
            }

            Query_Box.Text += string.Format("\nEND RESULTS \n");
            Query_Box.Text += new string('-', 80);
            Query_Box.Text += "\n";


        }

        /**
        * Linq to find the players not in a role that can also fill the role
        * 
        * Linq to search the player dictionary to find the players that are not in selected role
        * then checks to see if they are eligible for the role then prints out the data formatted. 
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void PlayerNotInRoles_Click(object sender, EventArgs e)
        {
            Query_Box.Clear();

            var FindPlayers = (dynamic)null;



            if (TankOpt.Checked || HealerOpt.Checked || DamageOpt.Checked)
            {
                Query_Box.Text += string.Format("All Eligible Players Not Fulfilling the {0} Role\n", selectedRadioBtn);
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";

                // switch/case dependent on user's choice
                switch (selectedRadioBtn)
                {
                    case "Tank":
                        FindPlayers =
                           from A in PlayerDictionary
                           join B in GuildDictionary on A.Value.GuildID equals B.Value.Id
                           where (A.Value.PlayerRole != Role.Tank && (A.Value.PlayerClass == Classes.Warrior || A.Value.PlayerClass == Classes.Druid || A.Value.PlayerClass == Classes.Paladin))
                           orderby A.Value.Level ascending
                           select new
                           {
                               playerName = A.Value.Name,
                               playerClass = A.Value.PlayerClass,
                               playerRole = A.Value.PlayerRole,
                               playerRace = A.Value.PlayerRace,
                               playerLevel = A.Value.Level,
                               playerGuild = B.Value.Name
                           };
                        break;
                    case "Healer":
                        FindPlayers =
                               from A in PlayerDictionary
                               join B in GuildDictionary on A.Value.GuildID equals B.Value.Id
                               where (A.Value.PlayerRole != Role.Healer && (A.Value.PlayerClass == Classes.Priest || A.Value.PlayerClass == Classes.Druid || A.Value.PlayerClass == Classes.Paladin || A.Value.PlayerClass == Classes.Shaman))
                               orderby A.Value.Level ascending
                               select new
                               {
                                   playerName = A.Value.Name,
                                   playerClass = A.Value.PlayerClass,
                                   playerRole = A.Value.PlayerRole,
                                   playerRace = A.Value.PlayerRace,
                                   playerLevel = A.Value.Level,
                                   playerGuild = B.Value.Name
                               };
                        break;
                    case "Damage":
                        FindPlayers =
                           from A in PlayerDictionary
                           join B in GuildDictionary on A.Value.GuildID equals B.Value.Id
                           where (A.Value.PlayerRole != Role.Damage && (A.Value.PlayerClass == Classes.Druid || A.Value.PlayerClass == Classes.Paladin || A.Value.PlayerClass == Classes.Shaman || A.Value.PlayerClass == Classes.Priest))
                           orderby A.Value.Level ascending
                           select new
                           {
                               playerName = A.Value.Name,
                               playerClass = A.Value.PlayerClass,
                               playerRole = A.Value.PlayerRole,
                               playerRace = A.Value.PlayerRace,
                               playerLevel = A.Value.Level,
                               playerGuild = B.Value.Name
                           };
                        break;

                }
                foreach (var result in FindPlayers)
                {
                    Query_Box.Text += String.Format("Name: {0,-10}({1,-7} - {2,-6})   Race: {3,-8} Level: {4,2}    <{5}>\n", result.playerName, result.playerClass, result.playerRole, result.playerRace, result.playerLevel, result.playerGuild);
                }

                Query_Box.Text += string.Format("\nEND RESULTS \n");
                Query_Box.Text += new string('-', 80);
                Query_Box.Text += "\n";
            }
            else
                Query_Box.Text += string.Format("PLEASE SELECT AN OPTION\n");
        }

        // Radio button check
        private void TankOpt_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = "Tank";
        }

        // Radio button check
        private void HealerOpt_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = "Healer";
        }

        // Radio button check
        private void DamageOpt_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = "Damage";
        }
    }
}
