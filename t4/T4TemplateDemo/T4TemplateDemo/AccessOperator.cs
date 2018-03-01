using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateDemo
{
    public class AccessDBEx : IDataBaseEx
    {
        private string connStr = null;        //连接字符串
        private OleDbConnection Con;

        public AccessDBEx(string filePath)
        {
            string connectStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath;
            connStr = connectStr;
            Con = new OleDbConnection(connStr);
        }
        /// <summary>
        ///   连接数据库
        /// </summary>
        /// <returns></returns>
        public bool OpenDB()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                    return true;
                Con.Open();
                if (Con.State == ConnectionState.Open)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
            }
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        /// <returns></returns>
        public bool CloseDB()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return true;
        }
        /// <summary>
        /// 获取所有表
        /// </summary>
        /// <returns></returns>
        public List<TableInfo> GetTables()
        {
            if (Con.State != ConnectionState.Open)
            {
                if (!OpenDB())
                    return null;
            }
            DataTable table = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            List<TableInfo> tableInfoList = new List<TableInfo>();
            foreach (DataRow row in table.Rows)
            {
                TableInfo tableInfoItem = new TableInfo();
                tableInfoItem.TableName = row["TABLE_NAME"].ToString();
                tableInfoList.Add(tableInfoItem);
            }
            CloseDB();
            return tableInfoList;
        }
        /// <summary>
        ///  获取Access 数据库中某个表的字段信息
        /// </summary>
        /// <param name="tableInfo"></param>
        /// <returns></returns>
        public List<FieldInfo> GetFields(TableInfo tableInfo)
        {
            if (Con.State != ConnectionState.Open)
            {
                if (!OpenDB())
                    return null;
            }
            DataTable table = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new Object[] { null, null, tableInfo.TableName, null });

            List<FieldInfo> fieldInfoList = new List<FieldInfo>();
            for (int j = 0; j < table.Rows.Count; j++)
            {
                FieldInfo fieldInfo = new FieldInfo();
                fieldInfo.FieldName = table.Rows[j]["COLUMN_NAME"].ToString();

                int lx = int.Parse(table.Rows[j]["DATA_TYPE"].ToString());    //字段类型

                switch (lx)
                {
                    case 2: fieldInfo.FieldType = "int"; break;
                    case 3: fieldInfo.FieldType = "int"; break;
                    case 4: fieldInfo.FieldType = "double"; break;
                    case 5: fieldInfo.FieldType = "double"; break;
                    case 6: fieldInfo.FieldType = "decimal"; break;
                    case 7: fieldInfo.FieldType = "DateTime"; break;
                    case 11: fieldInfo.FieldType = "bool"; break;
                    case 17: fieldInfo.FieldType = "byte"; break;
                    case 72: fieldInfo.FieldType = "string"; break;
                    case 130: fieldInfo.FieldType = "string"; break;
                    case 131: fieldInfo.FieldType = "decimal"; break;
                    case 128: fieldInfo.FieldType = "string"; break;
                    default: fieldInfo.FieldType = "string"; break;
                }
                fieldInfoList.Add(fieldInfo);
            }

            table = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, null);    //主键

            foreach (DataRow row in table.Rows)
            {
                if (row["TABLE_NAME"].ToString() == tableInfo.TableName)
                {
                    foreach (FieldInfo item in fieldInfoList)
                    {
                        if (item.FieldName == row["COLUMN_NAME"].ToString())
                        {
                            item.IsPrimaryKey = true;
                        }
                    }

                }
            }
            CloseDB();
            return fieldInfoList;
        }
    }

}
