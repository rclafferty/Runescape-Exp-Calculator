using System;
using System.Windows.Forms;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;
using System.Data;

using System.Data.Odbc;

namespace ExpGuiThreePointOh
{
    public partial class MainGUI : Form
    {
        private int goalLVL;
        private int goalEXP;
        private int currentLVL;
        private int currentEXP;
        
        private int maxLVL;

        private int[] xp;

        private int itemLVL;
        private double itemEXP;
        
        public MainGUI()
        {
            InitializeComponent();

            goalLVL = 0;
            goalEXP = 0;
            currentLVL = 0;
            currentEXP = 0;
            itemLVL = 0;
            itemEXP = 0;

            maxLVL = 99;

            #region DEBUG XP ARRAY
            xp = new int[100];
            xp[1] = 0;
            xp[2] = 83;
            xp[3] = 174;
            xp[4] = 276;
            xp[5] = 388;
            xp[6] = 512;
            xp[7] = 650;
            xp[8] = 801;
            xp[9] = 969;
            xp[10] = 1154;
            xp[11] = 1358;
            xp[12] = 1584;
            xp[13] = 1833;
            xp[14] = 2107;
            xp[15] = 2411;
            xp[16] = 2746;
            xp[17] = 3115;
            xp[18] = 3523;
            xp[19] = 3973;
            xp[20] = 4470;
            xp[21] = 5018;
            xp[22] = 5624;
            xp[23] = 6291;
            xp[24] = 7028;
            xp[25] = 7842;
            xp[26] = 8740;
            xp[27] = 9730;
            xp[28] = 10824;
            xp[29] = 12031;
            xp[30] = 13363;
            xp[31] = 14833;
            xp[32] = 16456;
            xp[33] = 18247;
            xp[34] = 20224;
            xp[35] = 22406;
            xp[36] = 24815;
            xp[37] = 27473;
            xp[38] = 30408;
            xp[39] = 33648;
            xp[40] = 37224;
            xp[41] = 41171;
            xp[42] = 45529;
            xp[43] = 50339;
            xp[44] = 55649;
            xp[45] = 61512;
            xp[46] = 67983;
            xp[47] = 75127;
            xp[48] = 83014;
            xp[49] = 91721;
            xp[50] = 101333;
            xp[51] = 111945;
            xp[52] = 123660;
            xp[53] = 136594;
            xp[54] = 150872;
            xp[55] = 166636;
            xp[56] = 184040;
            xp[57] = 203254;
            xp[58] = 224466;
            xp[59] = 247886;
            xp[60] = 273742;
            xp[61] = 302288;
            xp[62] = 333804;
            xp[63] = 368599;
            xp[64] = 407015;
            xp[65] = 449428;
            xp[66] = 496254;
            xp[67] = 547953;
            xp[68] = 605032;
            xp[69] = 668051;
            xp[70] = 737627;
            xp[71] = 814445;
            xp[72] = 899257;
            xp[73] = 992895;
            xp[74] = 1096278;
            xp[75] = 1210421;
            xp[76] = 1336443;
            xp[77] = 1475581;
            xp[78] = 1629200;
            xp[79] = 1798808;
            xp[80] = 1986068;
            xp[81] = 2192818;
            xp[82] = 2421087;
            xp[83] = 2673114;
            xp[84] = 2951373;
            xp[85] = 3258594;
            xp[86] = 3597792;
            xp[87] = 3972294;
            xp[88] = 4385776;
            xp[89] = 4842295;
            xp[90] = 5346332;
            xp[91] = 5902831;
            xp[92] = 6517253;
            xp[93] = 7195629;
            xp[94] = 7944614;
            xp[95] = 8771558;
            xp[96] = 9684577;
            xp[97] = 10692629;
            xp[98] = 11805606;
            xp[99] = 13034431;
            #endregion

            uxMemberButton.Checked = true;
            uxFreeToPlayButton.Checked = false;
        }

        /// <summary>
        /// Handles when the Calculate button is clicked. The program displays the information in a MessageBox and the writes it to report.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCalculateButton_Click(object sender, EventArgs e)
        {
            if (uxGoalLevelBox.Text == "Test")
            {
                TestCalculate();
                return;
            }

            string skill = uxSkillBox.Text;
            if (currentLVL < itemLVL && skill != "ATTACK" && skill != "STRENGTH" && skill != "DEFENCE" && skill != "HITPOINTS" && skill != "RANGE")
            {
                //MessageBox.Show("Invalid level! Required level is : " + itemLVL);
                //return;
            }

            int levels = goalLVL - currentLVL;
            int experience = goalEXP - currentEXP;
            int remaining = (int)Math.Ceiling(experience / itemEXP);

            StringBuilder sb = new StringBuilder();
            sb.Append("Item:              ");
            sb.Append(FormatText(uxItemBox.Text));
            sb.Append("\nSkill:             ");
            sb.Append(FormatText(uxSkillBox.Text));
            sb.Append("\nCurrent Level:    ");
            sb.Append(FormatIntToString(currentLVL));
            sb.Append("\nGoal Level:       ");
            sb.Append(FormatIntToString(goalLVL));
            sb.Append("\nLevels to go:     ");
            sb.Append(FormatIntToString(levels));
            sb.Append("\nCurrent Exp:      ");
            sb.Append(FormatIntToString(currentEXP));
            sb.Append("\nGoal Exp:         ");
            sb.Append(FormatIntToString(goalEXP));
            sb.Append("\nExperience left:  ");
            sb.Append(FormatIntToString(experience));
            sb.Append("\nExp per item:      ");
            sb.Append(FormatDoubleToString(itemEXP));
            sb.Append("\nItems remaining:  ");
            sb.Append(FormatIntToString(remaining));

            MessageBox.Show(sb.ToString());

            // The following code is only used if logging previous calculations, which is currently not implemented

            /*bool tf = false;
            if (File.Exists("report.txt"))
            {
                tf = true;
            }

            using (StreamWriter sw = new StreamWriter("report.txt", append: true))
            {
                if (!tf)
                {
                    sw.WriteLine("Calculation Report:");
                }
                sw.WriteLine("--------------------------------");
                sw.WriteLine(sb.ToString());
            }

            sb.Clear();
            sb.Append("INSERT INTO skillCalculations (nameID, skillID, currentLVL, goalLVL, diffLVL, currentEXP, goalEXP, diffEXP, itemEXP, itemRemaining) VALUES (");
            sb.Append(uxItemBox.SelectedIndex + 1);
            sb.Append(",");
            sb.Append(uxSkillBox.SelectedIndex + 1);
            sb.Append(",");
            sb.Append(currentLVL);
            sb.Append(",");
            sb.Append(goalLVL);
            sb.Append(",");
            sb.Append(goalLVL - currentLVL);
            sb.Append(",");
            sb.Append(currentEXP);
            sb.Append(",");
            sb.Append(goalEXP);
            sb.Append(",");
            sb.Append(goalEXP - currentEXP);
            sb.Append(",");
            sb.Append(itemEXP);
            sb.Append(",");
            sb.Append(remaining);
            sb.Append(")");

            using (MySqlConnection conn = GetConnection())
            //using (OdbcConnection conn = GetOdbcConnection())
            {
                OpenConnection(conn);

                MySqlDataReader reader = Execute(conn, sb.ToString());
                //OdbcDataReader reader = Execute(conn, sb.ToString());
                reader.Close();

                CloseConnection(conn);
            }*/
        }

        /// <summary>
        /// Calculates the level for the given experience points
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public int CalculateLevel(int exp)
        {
            if (exp < 0)
                return -1;  //negative value error
            
            int points = 0;
            int output = 0;
            for (int i = 1; i <= maxLVL; i++)
            {
                //Algorithm taken from http://rsdo.net/rsdonline/guides/Experience%20formula.html
                points += (int)Math.Floor(i + 300 * Math.Pow(2, (double)i / 7));
                output = (int)Math.Floor(points / 4.0);

                if (exp < output)
                    return i;
            }

            if (output < 0)
                return -2; //Bit overflow error
            else if (xp[maxLVL] != output)
                return -3;
            else return output;
        }

        /// <summary>
        /// Calculates the difference in experience points between the two given levels
        /// </summary>
        /// <param name="startLVL"></param>
        /// <param name="endLVL"></param>
        /// <returns></returns>
        public int CalculateExpFromLevel(int startLVL, int endLVL)
        {
            if (startLVL > maxLVL || startLVL < 0)
                return -1; //Invalid level error
            if (endLVL > maxLVL || endLVL < 0)
                return -1; //Invalid level error

            int points = 0;
            int output = 0;
            for (int i = startLVL; i <= endLVL; i++)
            {
                //Algorithm taken from http://rsdo.net/rsdonline/guides/Experience%20formula.html
                points += (int)Math.Floor(i + 300 * Math.Pow(2, (double)i / 7));
                output = (int)Math.Floor(points / 4.0);
            }

            if (output < 0)
                return -2; //Bit overflow error
            else return output;
        }

        /// <summary>
        /// Calculates the experience points for the given level
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public int CalculateExp(int level)
        {
            if (level > maxLVL || level < 0)
                return -1; //Invalid level error
            
            int points = 0;
            int output = 0;
            for (int i = 1; i < level; i++)
            {
                //Algorithm taken from http://rsdo.net/rsdonline/guides/Experience%20formula.html
                points += (int)Math.Floor(i + 300 * Math.Pow(2, (double)i / 7));
                output = (int)Math.Floor(points / 4.0);
            }

            if (output < 0)
                return -2; //Bit overflow error
            else if (xp[level] != output)
                return -3;
            else return output;
        }

        /// <summary>
        /// Displays the CORRECT calculated exp / levels for each level
        /// </summary>
        public void TestCalculate()
        {
            int minLVL = 2;
            int maxLVL = 99;
            int points = 0;
            int output = 0;

            //Calculate the experience for the i'th level
            for (int i = 1; i <= maxLVL; i++)
            {
                if (i >= minLVL)
                    Console.WriteLine("Level " + i + " - " + output);
                points += (int)Math.Floor(i + 300 * Math.Pow(2, (double)i / 7));
                output = (int)Math.Floor(points / 4.0);
            }
        }

        /// <summary>
        /// Handles when user changes the Current Experience input. The program calculates the level for that experience and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCurrentExperienceBox_TextChanged(object sender, EventArgs e)
        {
            //No entry for current experience
            if (uxCurrentExperienceBox.Text == String.Empty)
            {
                uxCurrentLevelBox.Text = "";
                return;
            }

            //Otherwise, get current exp
            try
            {
                currentEXP = Convert.ToInt32(uxCurrentExperienceBox.Text);
            }
            catch (FormatException fe) //If user inputs "12,34" or something that is not a pure number OR inputs a decimal
            {
                return;
            }

            //Calculate current level from given exp
            currentLVL = CalculateLevel(currentEXP);
            if (currentLVL == -1)
                uxCurrentLevelBox.Text = "Negative Values!";
            else if (currentLVL == -2)
                uxCurrentLevelBox.Text = "> 99";
            else if (currentLVL == -3)
                uxCurrentLevelBox.Text = "ERROR";
            else
                uxCurrentLevelBox.Text = currentLVL.ToString();
        }

        /// <summary>
        /// Handles when user changes the Goal Level input. The program calculates the experience for that level and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGoalLevelBox_TextChanged(object sender, EventArgs e)
        {
            //No entry for goal level
            if (uxGoalLevelBox.Text == String.Empty)
            {
                uxGoalExperienceBox.Text = "";
                return;
            }

            //Otherwise, get the goal level from user input
            try
            { 
                goalLVL = Convert.ToInt32(uxGoalLevelBox.Text);
            }
            catch (FormatException fe) //If user inputs "12,34" or something that is not a pure number OR inputs a decimal
            {
                return;
            }

            //Calculate goal exp from given level
            goalEXP = CalculateExp(goalLVL);
            if (goalEXP == -1 || goalEXP == -2)
                uxGoalExperienceBox.Text = "Invalid level";
            else if (goalEXP == -3)
                uxGoalExperienceBox.Text = "ERROR";
            else
                uxGoalExperienceBox.Text = goalEXP.ToString();
        }

        /// <summary>
        /// Creates a new connection to the database
        /// </summary>
        /// <returns></returns>
        private MySqlConnection GetConnection()
        {
            //Credentials
            string user = "user";
            string pass = "password";
            string server = "server";
            string database = "database";

            //Create the Connection String
            MySqlConnectionStringBuilder mscsb = new MySqlConnectionStringBuilder();
            mscsb.Add("Server", server);
            mscsb.Add("Database", database);
            mscsb.Add("User", user);
            mscsb.Add("Password", pass);
            mscsb.Add("Connection Timeout", 120);

            //Return a new connection using the connection string
            return new MySqlConnection(mscsb.ToString());
        }
        /// <summary>
        /// Creates a new connection to the database
        /// </summary>
        /// <returns></returns>
        private OdbcConnection GetOdbcConnection()
        {
            //Credentials
            string user = "user";
            string pass = "password";
            string server = "server";
            string database = "database";

            //Create the Connection String
            OdbcConnectionStringBuilder mscsb = new OdbcConnectionStringBuilder();
            mscsb.Add("Server", server);
            mscsb.Add("Database", database);
            mscsb.Add("User", user);
            mscsb.Add("Password", pass);
            mscsb.Add("Connection Timeout", 120);

            //Return a new connection using the connection string
            return new OdbcConnection(mscsb.ToString());
        }

        /// <summary>
        /// Opens given connection
        /// </summary>
        /// <param name="conn"></param>
        private void OpenConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException mse)
            {
                MessageBox.Show("ERROR OPENING CONNECTION");
                return;
            }
        }
        /// <summary>
        /// Opens given connection
        /// </summary>
        /// <param name="conn"></param>
        private void OpenConnection(OdbcConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (OdbcException mse)
            {
                MessageBox.Show("ERROR OPENING CONNECTION");
                return;
            }
        }

        /// <summary>
        /// Closes given connection safely
        /// </summary>
        /// <param name="conn"></param>
        private void CloseConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException mse)
            {
                MessageBox.Show("ERROR CLOSING CONNECTION");
                return;
            }
        }
        /// <summary>
        /// Closes given connection safely
        /// </summary>
        /// <param name="conn"></param>
        private void CloseConnection(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException mse)
            {
                MessageBox.Show("ERROR CLOSING CONNECTION");
                return;
            }
        }

        /// <summary>
        /// Execute command given the command string and connection
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private MySqlDataReader Execute(MySqlConnection conn, string s)
        {
            MySqlCommand msc = conn.CreateCommand();
            msc.CommandText = s;
            MySqlDataReader reader = msc.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Execute command given the command string and connection
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private OdbcDataReader Execute(OdbcConnection conn, string s)
        {
            OdbcCommand msc = conn.CreateCommand();
            msc.CommandText = s;
            OdbcDataReader reader = msc.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// Handles when users select a membership button, either "Member" or "Free-to-Play"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMemberButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear skills
            uxSkillBox.Text = "";
            uxSkillBox.Items.Clear();

            //Get skills from the database depending on membership
            using (MySqlConnection conn = GetConnection())
            {
                OpenConnection(conn);

                MySqlDataReader reader = Execute(conn, "SELECT COUNT(id) FROM runescapeSkills");
                reader.Read();
                int countSkills = reader.GetInt32(0);
                reader.Close();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT name FROM runescapeSkills ");
                
                //If free to play is selected...
                if (uxFreeToPlayButton.Checked)
                {
                    query.Append(" WHERE membership like 'FREE' ");
                }

                query.Append(" ORDER BY name ");

                reader = Execute(conn, query.ToString());

                //Read skills
                string st = "";
                while (reader.Read())
                {
                    st = ToTitleCase(reader.GetString(0));
                    uxSkillBox.Items.Add(st);
                }

                reader.Close();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// Formats text to Title Case
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        private string ToTitleCase(string st)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(st.ToLower());
        }

        /// <summary>
        /// Handles when users change the selected item in the Skills box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSkillBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear items
            uxItemBox.Text = "";
            uxItemBox.Items.Clear();

            //Get the items of the selected skill
            using (MySqlConnection conn = GetConnection())
            {
                OpenConnection(conn);
                
                StringBuilder query = new StringBuilder();
                query.Append("SELECT name FROM runescapeItems WHERE skill like '");
                query.Append(uxSkillBox.Text);
                query.Append("'");

                //If free to play is selected...
                if (uxFreeToPlayButton.Checked)
                {
                    query.Append(" AND membership like 'FREE'");
                }

                query.Append(" ORDER BY name");

                MySqlDataReader reader = Execute(conn, query.ToString());
                
                //Read items from database
                while (reader.Read())
                {
                    uxItemBox.Items.Add(ToTitleCase(reader.GetString(0)));
                }

                reader.Close();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// Handles when user change the selected item in the Items box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get data for given item from database
            using (MySqlConnection conn = GetConnection())
            {
                OpenConnection(conn);
                
                //Get information about item
                StringBuilder query = new StringBuilder();
                query.Append("SELECT level, exp FROM runescapeItems WHERE name like '");
                query.Append(uxItemBox.Text);
                query.Append("' ORDER BY name");
                
                MySqlDataReader reader = Execute(conn, query.ToString());
                reader.Read();

                itemLVL = reader.GetInt32(0);
                itemEXP = reader.GetDouble(1);

                //Set exp box to the exp for the required level
                string skill = uxSkillBox.Text;
                if (skill != "ATTACK" && skill != "STRENGTH" && skill != "DEFENCE" && skill != "HITPOINTS" && skill != "RANGE")
                    uxCurrentExperienceBox.Text = (CalculateExp(itemLVL)).ToString();

                reader.Close();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// Formats the given integer to a comma-separated string in a ##,###,##0 format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormatIntToString(int number)
        {
            string st = number.ToString("##,###,##0");
            //13,034,431 (LVL 99 exp)

            int diff = 13 - st.Length;
            if (diff > 0)
            {
                for (int i = 0; i < diff; i++)
                {
                    st = st.Insert(0, " ");
                }
            }

            return st;
        }

        /// <summary>
        /// Formats the given double to a comma-separated string in a ##,###,##0.00 format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormatDoubleToString(double number)
        {
            //Format the string with commas
            string st = number.ToString("##,###,##0.00");
            //13,034,431.00 (LVL 99 exp)

            int diff = 15 - st.Length;
            if (diff > 0)
            {
                //Insert spaces at the beginning of the number
                for (int i = 0; i < diff; i++)
                {
                    st = st.Insert(0, " ");
                }
            }

            return st;
        }

        /// <summary>
        /// Right-aligns text for the report.txt file
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        private string FormatText(string st)
        {
            string template = "construction";

            int diff = template.Length - st.Length;
            if (diff > 0)
            {
                //Insert spaces at the beginning of the word
                for (int i = 0; i < diff; i++)
                    st = st.Insert(0, " ");
            }

            return st;
        }
    }
}
