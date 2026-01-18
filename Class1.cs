using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

public static class Helper
{
    public static int flag = 0;
    // Helper method to create rounded region for button
    public static void SetRoundedButton(Control button, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
        path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), 270, 90);
        path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
        path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);
        path.CloseFigure();
        button.Region = new Region(path);
    }
    public static void QuerryExecute(string querry) {
        using (SqlConnection conn = new SqlConnection(GymManagement.Properties.Settings.Default.ConnectionString))
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new(querry, conn);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public static int getCounter(string name) {
        string Querry = $"select {name} from Counters";
        int no = (int)Helper.ScalarExecute(Querry);
        if (!(name == "Registration"))
        {
            Querry = $"Update COunters Set {name} = {no + 1}";
            Helper.QuerryExecute(Querry);
        }
        return no;
    }


    public static object ScalarExecute(string querry) { 
            using (SqlConnection conn = new SqlConnection(GymManagement.Properties.Settings.Default.ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand sqlCommand = new(querry, conn);
                    return sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
    } 

}

