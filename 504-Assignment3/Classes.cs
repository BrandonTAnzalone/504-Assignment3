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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Each unique race
    public enum Race { Orc, Troll, Tauren, Forsaken };

    public enum Classes
    {
        Warrior, Mage, Druid, Priest, Warlock,
        Rogue, Paladin, Hunter, Shaman
    };

    public enum Role { Tank, Healer, Damage };

    public enum GuildTypes { Casual, Questing, Mythic, Raiding, PVP };

    public class Guild : IComparable
    {
        // Private attributes
        private uint id;
        private GuildTypes type;
        private string name;
        private string server;

        // Read Only Access
        public uint Id
        {
            get { return id; }
            private set { id = value; }
        }

        // Read Only Access
        // Must be between 0 and 4
        public GuildTypes Type
        {
            get { return type; }
            private set
            {
                if (value >= (GuildTypes)0 || value <= (GuildTypes)4)
                    type = value;
                else
                {
                    Console.WriteLine(value + " is not a valid race id");
                }
            }
        }

        // Read Only Access
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Read Only Access
        public string Server
        {
            get { return server; }
            private set { server = value; }
        }

        // Default Constructor
        public Guild()
        {
            Id = 0;
            Type = 0;
            Name = "";
            Server = "";
        }

        // Constructor
        public Guild(uint newID, GuildTypes newType, string newName, string newServer)
        {
            Id = newID;
            Type = newType;
            Name = newName;
            Server = newServer;
        }



        // ToString Method
        public override string ToString()
        {
           
            //string output = String.Format("Name: {0}Race: {1} Level: {2}{3}", this.Name.PadRight(20), raceString.PadRight(10), levelString.PadRight(10), guildString);
            string output = String.Format("<{0}>", this.Name);
            return output;
        }



        // IComparable Method
        public int CompareTo(object alpha)
        {
            //Check for null values
            if (alpha == null) return 1;

            //typecast
            Guild rightOp = alpha as Guild;

            //Players are compared by name
            if (rightOp != null)
                return Name.CompareTo(rightOp.Name);
            else
                throw new ArgumentException("Item CompareTo argument is not an item");
        }



    }

    public class Player : IComparable
    {
        // Private attributes
        private uint id;
        private string name;
        private Race playerRace;
        private uint level;
        private uint exp;
        private uint guildID;
        private Classes playerClass;
        private Role playerRole;
        private static uint MAX_LEVEL = 60;



        // Read Only Access
        public uint Id
        {
            get { return id; }
            private set { id = value; }
        }

        // Read Only Access
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Read Only Access
        // Must be between 0 and 3
        public Race PlayerRace
        {
            get { return playerRace; }
            private set
            {
                if (value >= (Race)0 || value <= (Race)3)
                    playerRace = value;
                else
                {
                    Console.WriteLine(value + " is not a valid race id");
                }
            }
        }

        // Read Only Access
        // Must be between 0 and 8
        public Classes PlayerClass
        {
            get { return playerClass; }
            private set
            {
                if (value >= (Classes)0 || value <= (Classes)8)
                    playerClass = value;
                else
                {
                    Console.WriteLine(value + " is not a valid class id");
                }
            }
        }

        // Read Only Access
        // Must be between 0 and 2
        public Role PlayerRole
        {
            get { return playerRole; }
            private set
            {
                if (value >= (Role)0 || value <= (Role)2)
                    playerRole = value;
                else
                {
                    Console.WriteLine(value + "is not a valid role id");
                }
            }
        }

        // Read/Write Access
        public uint Level
        {
            get { return level; }
            set
            {
                if (value >= 0 || value <= MAX_LEVEL)
                    level = value;
                else
                {
                    Console.WriteLine(value + " is not a valid level");
                }
            }
        }

        // Read Access, Write Access Increases Current Level
        public uint Exp
        {
            get { return exp; }
            set
            {
                exp = exp + value;
            }
        }

        // Read/Write Access
        public uint GuildID
        {
            get { return guildID; }
            set { guildID = value; }
        }


        // Default Constructor
        public Player()
        {
            Id = 0;
            Name = "";
            PlayerRace = 0;
            PlayerClass = 0;
            PlayerRole = 0;
            Level = 1;
            GuildID = 0;
            Exp = 0;
        }

        // Constructor
        public Player(uint newID, string newName, Race newPlayerRace, Classes newPlayerClass, Role newPlayerRole, uint newLevel, uint newExp, uint newGuildID)
        {
            Id = newID;
            Name = newName;
            PlayerRace = newPlayerRace;
            Level = newLevel;
            GuildID = newGuildID;
            PlayerClass = newPlayerClass;
            PlayerRole = newPlayerRole;
            Exp = newExp;

        }

        
        // ToString Method
        public override string ToString()
        {
            // Displays the player name, race, level, and guild
            string raceString = "" + (Race)this.PlayerRace;
            string levelString = "" + this.Level;
            string roleString = "" + (Role)this.PlayerRole;
            string classString = "" + (Classes)this.PlayerClass;

            // If the player is in a guild it will say which guild, if not then nothing
            string guildString = "";
            if (Form1.GuildDictionary.ContainsKey(this.guildID))
            {
                guildString += Form1.GuildDictionary[this.guildID];
            }

            string output = String.Format("Name: {0}({1} - {2})\tRace: {3}Level: {4}{5}\n", this.Name.PadRight(15), classString, roleString, raceString.PadRight(10), levelString.PadRight(5), guildString);
            return output;
        }
        
        // IComparable Method
        public int CompareTo(object alpha)
        {
            //Check for null values
            if (alpha == null) return 1;

            //typecast
            Player rightOp = alpha as Player;

            //Players are compared by name
            if (rightOp != null)
                return Name.CompareTo(rightOp.Name);
            else
                throw new ArgumentException("Item CompareTo argument is not an item");
        }

    }
}
