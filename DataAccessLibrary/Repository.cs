﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace DataAccessLibrary
{
    public class Repository
    {
        public int NewID { get; set; }
        protected string _Query;
        protected List<string> Parameters { get; set; } = new List<string>();
        protected OleDbConnection connection { get; set; }

        protected void ResetConnections()
        {
            Parameters.Clear();
            connection.Close();
            connection.Dispose();
        }

        protected void ModifyData()
        {
            using (connection = new OleDbConnection(ConnectionString.Connection))
            using (OleDbCommand command = new OleDbCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = _Query;

                if (Parameters != null)
                {
                    foreach (string parameter in Parameters)
                    {
                        command.Parameters.AddWithValue($"@{parameter}", parameter);
                    }
                }

                command.ExecuteNonQuery();

                using (OleDbCommand selectCommand = new OleDbCommand("SELECT @@IDENTITY", connection))
                {
                    // Retrieve the newly created primary key
                    this.NewID = Convert.ToInt32(selectCommand.ExecuteScalar());

                }
            }
        }

        protected OleDbDataReader FetchData()
        {
            connection = new OleDbConnection(ConnectionString.Connection);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader;
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = _Query;

            if (Parameters != null)
            {
                foreach (string parameter in Parameters)
                {
                    command.Parameters.AddWithValue($"@{parameter}", parameter);
                }
            }

            return reader = command.ExecuteReader();
        }

    }
}
