namespace GymManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Properties.Settings.Default.IsFirstOpen = false;
            
            if (Properties.Settings.Default.IsFirstOpen)
            {   
                ApplicationConfiguration.Initialize();  
                Application.Run(new Starting_Screen());
                Properties.Settings.Default.Save();

            }
            else
            {
                string querry = "Select Name from Gym_info";
                string name = (string)Helper.ScalarExecute(querry);
                querry = "Select img from Gym_info";
                ApplicationConfiguration.Initialize();
                if (name is null)
                {
                    Properties.Settings.Default.IsFirstOpen = true;
                    Properties.Settings.Default.Save();
                    Application.Run(new Starting_Screen());
                }
                else
                {
                    Application.Run(new Form2(name, (byte[])Helper.ScalarExecute(querry)));
                }
                Properties.Settings.Default.Save();
            }
        }

    }
}