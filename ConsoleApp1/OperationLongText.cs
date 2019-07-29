using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 工序长文本
    /// </summary>
    public class OperationLongText : SegmentBase
    {
        public OperationLongText(ActionType actionType)
        {
            SegmentName = "HY72_AG_INFO_AI";
            this.Action = actionType;

            DataFields.Add(new FieldBase("KEY", "", 40, "" , "组合订单/OP 号")); //必填
            DataFields.Add(new FieldBase("TYP", "AI", 2, "", "记录类型；固定：\"AI\""));//必填
            DataFields.Add(new FieldBase("SUBKEY:1", 0, 8, "", "预留；固定设为\"00000000\""));
            DataFields.Add(new FieldBase("SUBKEY:2", 0, 8, "", "以 \"00000001\"开头的密钥内的序号"));
            DataFields.Add(new FieldBase("INFO:BEZ", "", 20, "", "短文本；仅与SUBKEY"));
            DataFields.Add(new FieldBase("INFO:1", "", 80, "", "信息文本1"));
            DataFields.Add(new FieldBase("INFO:2", "", 80, "", "信息文本2"));
            DataFields.Add(new FieldBase("INFO:3", "", 80, "", "信息文本3"));
            DataFields.Add(new FieldBase("INFO:4", "", 80, "", "信息文本4"));
            DataFields.Add(new FieldBase("INFO:5", "", 80, "", "信息文本5"));
            DataFields.Add(new FieldBase("INFO:6", "", 80, "", "信息文本6"));
            DataFields.Add(new FieldBase("INFO:7", "", 80, "", "信息文本7"));
            DataFields.Add(new FieldBase("INFO:8", "", 80, "", "信息文本8"));
            DataFields.Add(new FieldBase("INFO:9", "", 80, "", "信息文本9"));
            DataFields.Add(new FieldBase("INFO:10", "", 80, "", "信息文本10"));
        }

        public override string ToString()
        {
            string data = "";
            foreach (var field in DataFields)
            {
                data += field.ToString();
            }
            this.SetSData(data);
            return base.ToString();
        }
    }
}
