﻿using System;
using MySql.Data.MySqlClient;
namespace DBMisc
{
    public class DB_Conn
    {
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn ;
			connetionString = "server=localhost;database=sstss_data;uid=root;pwd=sstssthor;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show ("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

    }
}
