using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductRoute
    {
        public string SegmentName { get; set; }
        public List<FieldBase> FieldList { get; set; }

        public ProductRoute()
        {
            SegmentName = "HY72ADRCK_TIMETICKET";
            FieldList = new List<FieldBase>();
            FieldList.Add(new FieldBase("SegName", "", 33, "", "段名"));
            FieldList.Add(new FieldBase("SegNum", 0, 16, "", "序号"));
            FieldList.Add(new FieldBase("Blank", "", 12, "", "序号"));
            FieldList.Add(new FieldBase("Blank1", 0, 2, "", "序号"));

            FieldList.Add(new FieldBase("SART", "", 1, "", "接口记录类型")); //"A“ 工序相关上传 "P“ 人员相关上传
            FieldList.Add(new FieldBase("ERFART", "", 1, "", "原点 采集的原始数据记录")); //"E" 过账维护中手动创建的数据记录 "S" 撤销PPS
            FieldList.Add(new FieldBase("RMNR", "", 40, "", "确认/上传编号"));
            FieldList.Add(new FieldBase("ANR", "", 40, "", "订单号"));
            FieldList.Add(new FieldBase("AUART", "", 5, "", "订单类型"));
            FieldList.Add(new FieldBase("KENN", "", 1, "", "采集时运行状态指标")); //"L“ 工序正在运行（记录类型"A"）"E“ 工序已终止（记录类型"E"）"U“ 工序已中断（记录类型“U“、“T“、“H”）
            FieldList.Add(new FieldBase("AST", "", 5, "", "根据HYDRA 配置，PPS 确认时的运行状态"));
            FieldList.Add(new FieldBase("SKNR", 0, 2, "", "工位中的班次，生成BDE/车间过账"));
            FieldList.Add(new FieldBase("PDAUER", 0m, 10, 2, "", "人员处理时间（小时）"));
            //此处可能有字段
            FieldList.Add(new FieldBase("BMK01", 0m, 7, 2, "", "资源性能账户（RPA）1 in hours"));
            FieldList.Add(new FieldBase("BMK02", 0m, 7, 2, "", "资源性能账户（RPA）2 in hours"));
            FieldList.Add(new FieldBase("BMK03", 0m, 7, 2, "", "资源性能账户（RPA）3 in hours"));
            FieldList.Add(new FieldBase("BMK04", 0m, 7, 2, "", "资源性能账户（RPA）4 in hours"));
            FieldList.Add(new FieldBase("BMK05", 0m, 7, 2, "", "资源性能账户（RPA）5 in hours"));
            FieldList.Add(new FieldBase("BMK06", 0m, 7, 2, "", "资源性能账户（RPA）6 in hours"));
            FieldList.Add(new FieldBase("BMK07", 0m, 7, 2, "", "资源性能账户（RPA）7 in hours"));
            FieldList.Add(new FieldBase("BMK08", 0m, 7, 2, "", "资源性能账户（RPA）8 in hours"));
            FieldList.Add(new FieldBase("BMK09", 0m, 7, 2, "", "资源性能账户（RPA）9 in hours"));
            FieldList.Add(new FieldBase("BMK010", 0m, 7, 2, "", "资源性能账户（RPA）10 in hours"));
            FieldList.Add(new FieldBase("BMK011", 0m, 7, 2, "", "资源性能账户（RPA）11 in hours"));
            FieldList.Add(new FieldBase("BMK012", 0m, 7, 2, "", "资源性能账户（RPA）12 in hours"));
            FieldList.Add(new FieldBase("BMKSUMME", 0m, 7, 2, "", "除休息时间外资源性能账户小时数总和（RPA 12）"));
            FieldList.Add(new FieldBase("FILLER", "", 4, "", "已预留"));
            FieldList.Add(new FieldBase("MGRP", "", 8, "", "下一工位/设备分配的组"));
            FieldList.Add(new FieldBase("MNR", "", 8, "", "进行过账的工位/设备"));
            FieldList.Add(new FieldBase("PNR", "", 10, "", "人员数"));
            FieldList.Add(new FieldBase("LART", "", 4, "", "只有保存到工序的工资类型， 才可以直接从工序中获得"));
            FieldList.Add(new FieldBase("EGR:GUTB", 0m, 13, 3, "", "根据转换因素，输入和/或计算良品的基本数量"));
            FieldList.Add(new FieldBase("EGR:AUSB", 0m, 13, 3, "", "根据转换因素，输入和/或计算废品的基本数量"));
            FieldList.Add(new FieldBase("EGE:B", "", 3, "", "基本数量–工序的数量单位"));
            FieldList.Add(new FieldBase("EGR:GUTP", 0m, 13, 3, "", "记录的初级产额"));
            FieldList.Add(new FieldBase("EGR:AUSP", 0m, 13, 3, "", "自最后一次确认/上传后基本数量单位中记录的废品数"));
            FieldList.Add(new FieldBase("EGE:P", "", 3, "", "工序的基本记录数量单位（基本数量单位）"));
            //此处可能有字段
            FieldList.Add(new FieldBase("EGG:GUTP", "", 4, "", "陈述原因（偏差原因）"));
            FieldList.Add(new FieldBase("GUTBEZK", "", 5, "", "陈述原因（偏差原因）-外部参考"));
            FieldList.Add(new FieldBase("EGG:AUSP", "", 4, "", "报废原因"));
            FieldList.Add(new FieldBase("AUSBEZK", "", 5, "", "报废原因-外部参考"));
            FieldList.Add(new FieldBase("AUSTATUS", "", 1, "", "订单状态（订单头状态的控制指示灯）")); //E"（结 束），否则为"L"（正在运行）
            FieldList.Add(new FieldBase("", DateTime.Parse("1900-01-01"), "", ""));
            FieldList.Add(new FieldBase("", 0, 3, "", ""));
            FieldList.Add(new FieldBase("", DateTime.Parse("1900-01-01"), "", ""));
            FieldList.Add(new FieldBase("", 0, 3, "", ""));



            FieldList.Add(new FieldBase("",DateTime.Parse("1900-01-01"), "", ""));
            FieldList.Add(new FieldBase("", "", 4, "", ""));
            FieldList.Add(new FieldBase("", 0, 3, "", ""));
            FieldList.Add(new FieldBase("", 0m, 13, 3, "", ""));


        }

        public object this[string fieldName]
        {
            get
            {
                var field = FieldList.Where(t => t.FieldName == fieldName).FirstOrDefault();
                switch (field?.FieldType)
                {
                    case FieldType.String:
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
                var field = FieldList.Where(t => t.FieldName == fieldName).FirstOrDefault();
                switch (field?.FieldType)
                {
                    case FieldType.String:
                        field.StringValue = (string)value;
                        break;
                    case FieldType.Int:
                        field.IntValue = (int)value;
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

        public void Load(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string text = sr.ReadToEnd();
                int s = 0;
                for(int i = 0;i< FieldList.Count;i++)
                {
                    var field = FieldList[i];
                    var value = text.Substring(s, field.FieldLength.Value);
                    if (i == 0 && value != SegmentName)
                        throw new Exception("文件格式错误");
                    switch(field.FieldType)
                    {
                        case FieldType.String:
                            field.StringValue = value.Trim();
                            break;
                        case FieldType.Int:
                            field.IntValue = int.Parse(value);
                            break;
                        case FieldType.Decimal:
                            field.DecimalValue = decimal.Parse(value);
                            break;
                        case FieldType.Date:
                            if (string.IsNullOrEmpty(value))
                                field.DateValue = DateTime.Parse("1900-01-01");
                            else
                                field.DateValue = DateTime.ParseExact(value, "MM/dd/yyyy", null);
                            break;
                        default:
                            throw new Exception("未知的字段类型");
                    }
                    s = s + field.FieldLength.Value + 1;
                }

                sr.Close();
            }
        }
    }
}
