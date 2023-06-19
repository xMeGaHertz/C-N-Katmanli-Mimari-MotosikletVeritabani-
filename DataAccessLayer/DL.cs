#define MySQL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (MySQL)

using MDbConnection = MySql.Data.MySqlClient.MySqlConnection;
using MDbConnectionStringBuilder = MySql.Data.MySqlClient.MySqlConnectionStringBuilder;
using MDbCommand = MySql.Data.MySqlClient.MySqlCommand;
using MDbDataReader = MySql.Data.MySqlClient.MySqlDataReader;

#elif (MSSQL)

#elif (ACCESS)

#endif

namespace DataAccessLayer
{
    public static class DL
    {
        static MDbConnection connection = new MDbConnection(
            new MDbConnectionStringBuilder()
            {
#if MySQL
                Server = "localhost",
                Database = "3 - motosiklet_bayi",
                UserID = "root",
                Password = "",
#elif MSSQL
#elif ACCESS
#endif

            }
            .ConnectionString);

        public static int MarkaEkle(string marka_id, string marka_adi, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MarkaEkle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@maid", marka_id);
                komut.Parameters.AddWithValue("@adi", marka_adi);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int MarkaDüzenle(string marka_id, string marka_adi, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MarkaDüzenle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@maid", marka_id);
                komut.Parameters.AddWithValue("@adi", marka_adi);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int MarkaSil(string marka_id, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MarkaSil", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@maid", marka_id);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int SegmentEkle(string segment_id, string segmentmarka_id, string segment_adi, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("SegmentEkle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@sid", segment_id);
                komut.Parameters.AddWithValue("@smid", segmentmarka_id);
                komut.Parameters.AddWithValue("@adi", segment_adi);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int SegmentDüzenle(string segment_id, string segment_adi, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("SegmentDüzenle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@sid", segment_id);
                komut.Parameters.AddWithValue("@adi", segment_adi);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int SegmentSil(string segment_id, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("SegmentSil", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@sid", segment_id);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int ModelEkle(string model_id, string modelsegment_id, string model_adi, int model_yil, int model_beygir, int model_hacim, string model_renk, float model_fiyat, string model_stok, string model_aciklama, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("ModelEkle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@moid", model_id);
                komut.Parameters.AddWithValue("@msid", modelsegment_id);
                komut.Parameters.AddWithValue("@adi", model_adi);
                komut.Parameters.AddWithValue("@yil", model_yil);
                komut.Parameters.AddWithValue("@beygir", model_beygir);
                komut.Parameters.AddWithValue("@hacim", model_hacim);
                komut.Parameters.AddWithValue("@renk", model_renk);
                komut.Parameters.AddWithValue("@fiyat", model_fiyat);
                komut.Parameters.AddWithValue("@stok", model_stok);
                komut.Parameters.AddWithValue("@aciklama", model_aciklama);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int ModelDüzenle(string model_id, string model_adi, int model_yil, int model_beygir, int model_hacim, string model_renk, float model_fiyat, string model_stok, string model_aciklama, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("ModelDüzenle", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@moid", model_id);
                komut.Parameters.AddWithValue("@adi", model_adi);
                komut.Parameters.AddWithValue("@yil", model_yil);
                komut.Parameters.AddWithValue("@beygir", model_beygir);
                komut.Parameters.AddWithValue("@hacim", model_hacim);
                komut.Parameters.AddWithValue("@renk", model_renk);
                komut.Parameters.AddWithValue("@fiyat", model_fiyat);
                komut.Parameters.AddWithValue("@stok", model_stok);
                komut.Parameters.AddWithValue("@aciklama", model_aciklama);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static int ModelSil(string model_id, out string error)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("ModelSil", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@moid", model_id);

                error = "";
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static List<(string marka_id, string marka_adi)> MarkaListele(out string error)
        {
            List<(string, string)> list = new List<(string, string)>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MarkaListele", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[1].ToString()
                        ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static List<(string segment_id, string segment_adi)> MarkanınSegmentiniListele(string segmentmarka_id, out string error)
        {
            List<(string, string)> list = new List<(string, string)>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MDbCommand komut = new MDbCommand("MarkaSegmentiniListele", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@sid", segmentmarka_id);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString()
                        ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }

        }

        public static List<(string model_id, string model_adi, int model_yil, int model_beygir, int model_hacim, string model_renk, float model_fiyat, string model_stok, string model_aciklama)> SegmentinModeliniListele(string modelsegment_id, out string error)
        {
            List<(string, string, int, int, int, string, float, string, string)> list = new List<(string, string, int, int, int, string, float, string, string)>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();


                MDbCommand komut = new MDbCommand("SegmentModeliniListele", connection) { CommandType = System.Data.CommandType.StoredProcedure };
                komut.Parameters.AddWithValue("@msid", modelsegment_id);
                MDbDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    list.Add((
                        dr[0].ToString(),
                        dr[2].ToString(),
                        (int)dr[3],
                        (int)dr[4],
                        (int)dr[5],
                        dr[6].ToString(),
                        (float)dr[7],
                        dr[8].ToString(),
                        dr[9].ToString()

                        ));
                }
                error = "";
                return list;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }

        }
    }
}
