using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProjEden_and_Ofir
{
    class dbConnection
    {

        string strCon = @"Data Source=DESKTOP-M25PR0B;Initial Catalog=FinalProjC#;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;


        public dbConnection()
        {
            con = new SqlConnection(strCon);
            dt = new DataTable();
        }

        public DataTable DBRefreshDB()
        {
            try
            {
                cmd = new SqlCommand("select MovieCode, MovieName, MovieDuration, Grade,Type1, Type2, Creator, YearCreated from Movies", con);
                adtr = new SqlDataAdapter(cmd);
                dt.Clear();
                ds = new DataSet();
                adtr.Fill(ds, "M1");
                dt = ds.Tables["M1"];

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int InsertMovie(Movies movie)
        {
            try
            {

                string type2;

                if (movie.Type.Count == 1)
                {
                    type2 = null;
                }
                else
                {
                    type2 = movie.Type[1];
                }

                con.Open();
                cmd = new SqlCommand($"insert into Movies values('{movie.Name}','{movie.YearCreated}','{movie.MovieDuration}','{movie.Grade}','{movie.Creator}','{movie.Type[0]}','{type2}')", con);
                return cmd.ExecuteNonQuery();

                //op2:
                //DataRow dr = dt.NewRow();
                //dr["MovieName"] = movie.Name;
                //dr["YearCreated"] = movie.YearCreated;
                //dr["MovieDuration"] = movie.MovieDuration;
                //dr["Grade"] = movie.Grade;
                //dr["Creator"] = movie.Creator;
                //dr["Type1"] = movie.Type[0];
                //dr["Type2"] = type2;
                //dt.Rows.Add(dr);
                //UpdateDataBase(dt);
                //return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("The movie wasnt inserted, please try again","Error");
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void DeleteMovie(int movieCode)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["MovieCode"].ToString() == movieCode.ToString())
                    {
                        dt.Rows[i].Delete();
                        MessageBox.Show("Movie has been deleted successfully");
                        UpdateDataBase(dt);
                        return;
                                           
                    }               
                }
                MessageBox.Show("There's no movie with this code!");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Could not delete the movie from DB", "Error");
            }
        }

        public void UpdateDataBase(DataTable table)
        {
            new SqlCommandBuilder(adtr);
            adtr.Update(table);           
        }

        public DataTable Sort(string sort)
        {
       
            try
            {
                con.Open();
                cmd = new SqlCommand("SortByHorror1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parType = new SqlParameter("@Type", SqlDbType.NVarChar);
                parType.Direction = ParameterDirection.Input;
                parType.Value = sort;
                cmd.Parameters.Add(parType);

                adtr = new SqlDataAdapter(cmd);
                ds.Clear();
                adtr.Fill(ds, "tblItmes");
                dt = ds.Tables["tblItmes"];
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
