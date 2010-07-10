using System.Text.RegularExpressions;

namespace roundhouse.databases.sqlserver
{
    using System;
    using infrastructure.extensions;
    using infrastructure.logging;
    using sql;

    public class SqlServerDatabase : AdoNetDatabase
    {
        private string connect_options = "Integrated Security";

        public override void initialize_connections()
        {
            if (!string.IsNullOrEmpty(connection_string))
            {
                string[] parts = connection_string.Split(';');
                foreach (string part in parts)
                {
                    if (string.IsNullOrEmpty(server_name) && (part.to_lower().Contains("server") || part.to_lower().Contains("data source")))
                    {
                        server_name = part.Substring(part.IndexOf("=") + 1);
                    }

                    if (string.IsNullOrEmpty(database_name) && (part.to_lower().Contains("initial catalog") || part.to_lower().Contains("database")))
                    {
                        database_name = part.Substring(part.IndexOf("=") + 1);
                    }
                }

                if (!connection_string.to_lower().Contains(connect_options.to_lower()))
                {
                    connect_options = string.Empty;
                    foreach (string part in parts)
                    {
                        if (!part.to_lower().Contains("server") && !part.to_lower().Contains("data source") && !part.to_lower().Contains("initial catalog") &&
                            !part.to_lower().Contains("database"))
                        {
                            connect_options += part + ";";
                        }
                    }
                }
            }

            if (connect_options == "Integrated Security")
            {
                connect_options = "Integrated Security=SSPI;";
            }

            if (string.IsNullOrEmpty(connection_string))
            {
                connection_string = build_connection_string(server_name, database_name, connect_options);
            }

            set_provider_and_sql_scripts();

            admin_connection_string = Regex.Replace(connection_string, "initial catalog=.*?;", "initial catalog=master;");
        }

        public override void set_provider_and_sql_scripts()
        {
            provider = "System.Data.SqlClient";
            DatabaseTypeSpecifics.sql_scripts_dictionary.TryGetValue(provider, out sql_scripts);
            if (sql_scripts == null)
            {
                sql_scripts = DatabaseTypeSpecifics.t_sql_specific;
            }
        }

        private static string build_connection_string(string server_name, string database_name, string connection_options)
        {
            return string.Format("Server={0};initial catalog={1};{2}", server_name, database_name, connection_options);
        }

        public override void run_database_specific_tasks()
        {
            Log.bound_to(this).log_an_info_event_containing(" Creating {0} schema if it doesn't exist.", roundhouse_schema_name);
            create_roundhouse_schema_if_it_doesnt_exist();


            //TODO: Delete RoundhousE user if it exists (i.e. migration from SQL2000 to 2005)
        }

        public void create_roundhouse_schema_if_it_doesnt_exist()
        {
            try
            {
                run_sql(sql_scripts.create_roundhouse_schema(roundhouse_schema_name));
            }
            catch (Exception ex)
            {
                Log.bound_to(this).log_a_warning_event_containing(
                    "Either the schema has already been created OR {0} with provider {1} does not provide a facility for creating roundhouse schema at this time.{2}{3}",
                    GetType(), provider, Environment.NewLine, ex.Message);
            }
        }



    }
}