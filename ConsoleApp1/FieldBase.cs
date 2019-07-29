using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum FieldType : int
    {
        String,
        Int,
        Decimal,
        Date,
        Time
    }
    public class FieldBase
    {
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string NameAlias { get; set; }
        public FieldType FieldType { get; set; }
        public int? FieldLength { get; set; }
        public int? DecimalLength { get; set; }
        public int? IntValue { get; set; }
        public string StringValue { get; set; }
        public decimal? DecimalValue { get; set; }
        public DateTime? DateValue { get; set; }
        public int? TimeValue { get; set; }
        public override string ToString()
        {
            switch(FieldType)
            {
                case FieldType.String:
                case FieldType.Time:
                    if (!FieldLength.HasValue)
                        throw new Exception("必须指定字段长度");
                    return StringValue.PadRight(FieldLength.Value);
                case FieldType.Int:
                    if (!FieldLength.HasValue)
                        throw new Exception("必须指定字段长度");
                    if (!IntValue.HasValue)
                        throw new Exception("必须指定字段值");
                    return IntValue.ToString().PadRight(FieldLength.Value , '0');
                case FieldType.Decimal:
                    if (!FieldLength.HasValue || !DecimalLength.HasValue)
                        throw new Exception("必须指定字段长度");
                    if (!DecimalValue.HasValue)
                        throw new Exception("必须指定字段值");
                    string format =  "{0:" + 0.ToString().PadLeft(FieldLength.Value - DecimalLength.Value, '0') + "." + 0.ToString().PadRight(DecimalLength.Value, '0') + "}";
                    string ret = string.Format(format, DecimalValue);
                    if (DecimalValue.Value < 0)
                        ret = "-" + ret;
                    else
                        ret = "+" + ret;
                    return ret ;
                case FieldType.Date:
                    if (!DateValue.HasValue)
                        throw new Exception("必须指定字段值");
                    if (DateValue.Value == DateTime.Parse("1900-01-01"))
                        return "".PadLeft(FieldLength.Value);
                    return DateValue.Value.ToString("MM/dd/yyyy");
                
                   
                default:
                    throw new Exception("未知的字段类型");
            } 
        }

        public FieldBase(string fieldName,string value, int length,string name, string desc)
        {
            this.FieldType = FieldType.String;
            this.StringValue = value;
            this.FieldLength = length;
            this.Description = desc;
            this.FieldName = fieldName;
            this.NameAlias = name;
        }

        public FieldBase(string fieldName, string value, string name, string desc)
        {
            this.FieldType = FieldType.Time;
            this.StringValue = value;
            this.FieldLength = 6;
            this.Description = desc;
            this.FieldName = fieldName;
            this.NameAlias = name;
        }

        public FieldBase(string fieldName, int value, int length, string name, string desc)
        {
            this.FieldType = FieldType.Int;
            this.IntValue = value;
            this.FieldLength = length;
            this.Description = desc;
            this.FieldName = fieldName;
            this.NameAlias = name;
        }

        public FieldBase(string fieldName, decimal value, int length, int decimalLength, string name, string desc)
        {
            this.FieldType = FieldType.Decimal;
            this.DecimalValue = value;
            this.FieldLength = length;
            this.DecimalLength = decimalLength;
            this.Description = desc;
            this.FieldName = fieldName;
            this.NameAlias = name;
        }

        public FieldBase(string fieldName, DateTime value, string name, string desc,int length = 10)
        {
            this.FieldType = FieldType.Date;
            this.DateValue = value;
            this.Description = desc;
            this.FieldName = fieldName;
            this.NameAlias = name;
            this.FieldLength = length;
        }
    }
}
