using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.core;
using TMS.core.Data;
using TMS.Data.Initializers;

namespace TMS.Data
{
    public class MySqlDataProvider : IDataProvider
    {
        public bool BackupSupported
        {
            get
            {
                return true;
            }
        }

        public bool StoredProceduredSupported
        {
            get
            {
                return true;
            }
        }

        public DbParameter GetParameter()
        {
            return new MySqlParameter();
        }

        public void InitConnectionFactory()
        {
            var connectionFactory = new MySqlConnectionFactory();
            //TODO fix compilation warning (below)
            #pragma warning disable 0618
            Database.DefaultConnectionFactory = connectionFactory;
        }

        public void InitDatabase()
        {
            InitConnectionFactory();
            SetDatabaseInitializer();
        }

        public void SetDatabaseInitializer()
        {
            var tablesToValidate = new[] { "Customer", "Discount", "Order", "Product", "ShoppingCartItem" };

            //custom commands (stored proedures, indexes)

            var customCommands = new List<string>();
            //use webHelper.MapPath instead of HostingEnvironment.MapPath which is not available in unit tests
            customCommands.AddRange(ParseCommands(CommonHelper.MapPath("~/App_Data/MySql.Indexes.sql"), false));
            //use webHelper.MapPath instead of HostingEnvironment.MapPath which is not available in unit tests
            customCommands.AddRange(ParseCommands(CommonHelper.MapPath("~/App_Data/MySql.StoredProcedures.sql"), false));

            var initializer = new CreateTablesIfNotExist<TMSObjectContext>(tablesToValidate, customCommands.ToArray());
            Database.SetInitializer(initializer);
        }
        protected virtual string[] ParseCommands(string filePath, bool throwExceptionIfNonExists)
        {
            if (!File.Exists(filePath))
            {
                if (throwExceptionIfNonExists)
                    throw new ArgumentException(string.Format("Specified file doesn't exist - {0}", filePath));
                else
                    return new string[0];
            }


            var statements = new List<string>();
            using (var stream = File.OpenRead(filePath))
            using (var reader = new StreamReader(stream))
            {
                var statement = "";
                while ((statement = readNextStatementFromStream(reader)) != null)
                {
                    statements.Add(statement);
                }
            }

            return statements.ToArray();
        }
        protected virtual string readNextStatementFromStream(StreamReader reader)
        {
            var sb = new StringBuilder();

            string lineOfText;

            while (true)
            {
                lineOfText = reader.ReadLine();
                if (lineOfText == null)
                {
                    if (sb.Length > 0)
                        return sb.ToString();
                    else
                        return null;
                }

                //MySql doesn't support GO, so just use a commented out GO as the separator
                if (lineOfText.TrimEnd().ToUpper() == "-- GO")
                    break;

                sb.Append(lineOfText + Environment.NewLine);
            }

            return sb.ToString();
        }
        public int SupportedLengthOfBinaryHash()
        {
            return 0;
        }
    }
}
