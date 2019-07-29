using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ActionType : int
    {
        /// <summary>
        /// 添加或更新
        /// </summary>
        A,
        /// <summary>
        /// 删除
        /// </summary>
        D
    }
    public class SegmentBase
    {
        /// <summary>
        /// 段名
        /// </summary>
        public string SegmentName { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public ActionType Action { get; set; }
        /// <summary>
        /// 具体的值 
        /// </summary>
        public string SData { get; set; }
        /// <summary>
        /// 字段列表
        /// </summary>
        public List<FieldBase> Fields { get; set; }
        /// <summary>
        /// 数据部分字段列表
        /// </summary>
        public List<FieldBase> DataFields { get; set; }
        public string GetSegmentName()
        {
            string ret = "";
            if (Action == ActionType.A)
                ret = string.Format("{0}_{1:d3}_A", SegmentName, Sort);
            else if (Action == ActionType.D)
            {
                ret = string.Format("{0}_{1:d3}_D", SegmentName, Sort);
            }
            else
                throw new Exception("错误的操作类型");
            return ret;
        }

        public SegmentBase()
        {
            Fields = new List<FieldBase>();
            Fields.Add(new FieldBase("SEGNAM*", this.GetSegmentName(), 30, "SEGNAM", "段名"));
            Fields.Add(new FieldBase("MANDT*", 0, 3, "MANDT", "客户端"));
            Fields.Add(new FieldBase("DOCNUM*", 0, 16, "DOCNUM", "IDOC号"));
            Fields.Add(new FieldBase("SEGNUM*", 0, 6, "SEGNUM", "段号"));
            Fields.Add(new FieldBase("PSEGNUM", 0, 6, "PSEGNUM", "父段号"));
            Fields.Add(new FieldBase("HLEVEL", 0, 2, "HLEVEL", "层次等级"));
            Fields.Add(new FieldBase("SDATA", "", 1000, "SDATA", "用户数据"));
            DataFields = new List<FieldBase>();
            Sort = 1;
        }
         
        public override string ToString()
        {
            string ret = "";
            Fields[0].StringValue = this.GetSegmentName();
            foreach (var field in Fields)
            {
                ret += field.ToString();
            }
            return ret + "\r\n";
        }

        public object this[string fieldName]
        {
            get
            {
                var field = DataFields.Where(t => t.FieldName == fieldName).FirstOrDefault();

                switch(field?.FieldType)
                {
                    case FieldType.String:
                    case FieldType.Time:
                        return field.StringValue;
                    case FieldType.Int:
                        return field.IntValue;
                    case FieldType.Decimal:
                        return field.DecimalValue;
                    case FieldType.Date:
                        return field.DateValue;

                    default:
                        throw new Exception("未知的字段类型");
                }
            }
            set
            {
                var field = DataFields.Where(t => t.FieldName == fieldName).FirstOrDefault();
                switch (field?.FieldType)
                {
                    case FieldType.String:
                    case FieldType.Time:
                        field.StringValue = (string)value;
                        break;
                    case FieldType.Int:
                        field.IntValue = (int)value ;
                        break;
                    case FieldType.Decimal:
                        field.DecimalValue = (decimal)value;
                        break;
                    case FieldType.Date:
                        field.DateValue = (DateTime)value;
                        break;
                    default:
                        throw new Exception("未知的字段类型");
                }

            }
            
        }

        public void SetNameAlias(string name,object value)
        {
            var field = DataFields.Where(t => t.NameAlias == name).FirstOrDefault();
            this[field.FieldName] = value;
        }
        public object GetNameAlias(string name)
        {
            var field = DataFields.Where(t => t.NameAlias == name).FirstOrDefault();
            return this[field.FieldName];
        }

        protected void SetSData(string value)
        {
            var field = Fields.Where(t => t.FieldName == "SDATA").First();
            field.StringValue = value;
        }

    }
}
