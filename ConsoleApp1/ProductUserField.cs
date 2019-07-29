using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 工单用户字段
    /// </summary>
    public class ProductUserField : SegmentBase
    {
        public ProductUserField(ActionType actionType)
        {
            SegmentName = "HY72_AU_USRFLD";
            this.Action = actionType;

            DataFields.Add(new FieldBase("AUNR", "", 40, "ProdId", "订单号"));    //必填
            DataFields.Add(new FieldBase("USRFLD", "", 8, "", "用户字段密钥"));    //必填

            DataFields.Add(new FieldBase("FU:1", DateTime.Parse("1900-01-01"), "", "用户字段1"));
            DataFields.Add(new FieldBase("FU:2", DateTime.Parse("1900-01-01"), "", "用户字段2"));
            DataFields.Add(new FieldBase("FU:3", DateTime.Parse("1900-01-01"), "", "用户字段3"));
            DataFields.Add(new FieldBase("FU:4", DateTime.Parse("1900-01-01"), "", "用户字段4"));
            DataFields.Add(new FieldBase("FU:5", DateTime.Parse("1900-01-01"), "", "用户字段5"));
            DataFields.Add(new FieldBase("FU:6", DateTime.Parse("1900-01-01"), "", "用户字段6"));

            DataFields.Add(new FieldBase("FU:7", 0, 8, "", "用户字段7"));
            DataFields.Add(new FieldBase("FU:8", 0, 8, "", "用户字段8"));
            DataFields.Add(new FieldBase("FU:9", 0, 8, "", "用户字段9"));
            DataFields.Add(new FieldBase("FU:10", 0, 8, "", "用户字段10"));
            DataFields.Add(new FieldBase("FU:11", 0, 8, "", "用户字段11"));
            DataFields.Add(new FieldBase("FU:12", 0, 8, "", "用户字段12"));
            DataFields.Add(new FieldBase("FU:13", 0, 8, "", "用户字段13"));
            DataFields.Add(new FieldBase("FU:14", 0, 8, "", "用户字段14"));
            DataFields.Add(new FieldBase("FU:15", 0, 8, "", "用户字段15"));
            DataFields.Add(new FieldBase("FU:16", 0, 8, "", "用户字段16"));
            DataFields.Add(new FieldBase("FU:17", 0, 8, "", "用户字段17"));
            DataFields.Add(new FieldBase("FU:18", 0, 8, "", "用户字段18"));
            DataFields.Add(new FieldBase("FU:19", 0, 8, "", "用户字段19"));
            DataFields.Add(new FieldBase("FU:20", 0, 8, "", "用户字段20"));
            DataFields.Add(new FieldBase("FU:21", 0, 8, "", "用户字段21"));
            DataFields.Add(new FieldBase("FU:22", 0, 8, "", "用户字段22"));

            DataFields.Add(new FieldBase("FU:23", 0m, 13, 3, "", "用户字段23"));
            DataFields.Add(new FieldBase("FU:24", 0m, 13, 3, "", "用户字段24"));
            DataFields.Add(new FieldBase("FU:25", 0m, 13, 3, "", "用户字段25"));
            DataFields.Add(new FieldBase("FU:26", 0m, 13, 3, "", "用户字段26"));
            DataFields.Add(new FieldBase("FU:27", 0m, 13, 3, "", "用户字段27"));
            DataFields.Add(new FieldBase("FU:28", 0m, 13, 3, "", "用户字段28"));

            DataFields.Add(new FieldBase("FU:29", "", 1, "", "用户字段29"));
            DataFields.Add(new FieldBase("FU:30", "", 1, "", "用户字段30"));
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
