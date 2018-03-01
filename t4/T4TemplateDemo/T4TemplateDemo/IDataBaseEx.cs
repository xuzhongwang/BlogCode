using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateDemo
{
    /// <summary>
    ///  数据库管理接口。 如 获取表的架构等
    /// </summary>
    public interface IDataBaseEx
    {
        bool OpenDB();
        bool CloseDB();
        List<TableInfo> GetTables();
        List<FieldInfo> GetFields(TableInfo tableInfo);
    }

    public class TableInfo
    {
        public string TableName { get; set; }
    }

    public class FieldInfo
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}
