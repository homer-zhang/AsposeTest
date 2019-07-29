using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationUserField :SegmentBase
    {
        public OperationUserField(ActionType actionType)
        {
            SegmentName = "HY72_AG_USRFLD";
            this.Action = actionType;

            DataFields.Add(new FieldBase("ANR", "", 40, "", "组合订单/OP 号"));    //必填
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
            DataFields.Add(new FieldBase("FU:31", "", 1, "", "用户字段31"));
            DataFields.Add(new FieldBase("FU:32", "", 1, "", "用户字段32"));
            DataFields.Add(new FieldBase("FU:33", "", 1, "", "用户字段33"));
            DataFields.Add(new FieldBase("FU:34", "", 1, "", "用户字段34"));
            DataFields.Add(new FieldBase("FU:35", "", 1, "", "用户字段35"));
            DataFields.Add(new FieldBase("FU:36", "", 1, "", "用户字段36"));
            DataFields.Add(new FieldBase("FU:37", "", 1, "", "用户字段37"));
            DataFields.Add(new FieldBase("FU:38", "", 1, "", "用户字段38"));
            DataFields.Add(new FieldBase("FU:39", "", 1, "", "用户字段39"));
            DataFields.Add(new FieldBase("FU:40", "", 1, "", "用户字段40"));
            DataFields.Add(new FieldBase("FU:41", "", 1, "", "用户字段41"));
            DataFields.Add(new FieldBase("FU:42", "", 1, "", "用户字段42"));
            DataFields.Add(new FieldBase("FU:43", "", 1, "", "用户字段43"));
            DataFields.Add(new FieldBase("FU:44", "", 1, "", "用户字段44"));

            DataFields.Add(new FieldBase("FU:45", "", 10, "", "用户字段45"));
            DataFields.Add(new FieldBase("FU:46", "", 10, "", "用户字段46"));
            DataFields.Add(new FieldBase("FU:47", "", 10, "", "用户字段47"));
            DataFields.Add(new FieldBase("FU:48", "", 10, "", "用户字段48"));
            DataFields.Add(new FieldBase("FU:49", "", 10, "", "用户字段49"));
            DataFields.Add(new FieldBase("FU:50", "", 10, "", "用户字段50"));

            DataFields.Add(new FieldBase("FU:51", "", 20, "", "用户字段51"));
            DataFields.Add(new FieldBase("FU:52", "", 20, "", "用户字段52"));
            DataFields.Add(new FieldBase("FU:53", "", 20, "", "用户字段53"));
            DataFields.Add(new FieldBase("FU:54", "", 20, "", "用户字段54"));
            DataFields.Add(new FieldBase("FU:55", "", 20, "", "用户字段55"));
            DataFields.Add(new FieldBase("FU:56", "", 20, "", "用户字段56"));
            DataFields.Add(new FieldBase("FU:57", "", 20, "", "用户字段57"));
            DataFields.Add(new FieldBase("FU:58", "", 20, "", "用户字段58"));
            DataFields.Add(new FieldBase("FU:59", "", 20, "", "用户字段59"));
            DataFields.Add(new FieldBase("FU:60", "", 20, "", "用户字段60"));
            DataFields.Add(new FieldBase("FU:61", "", 20, "", "用户字段61"));
            DataFields.Add(new FieldBase("FU:62", "", 20, "", "用户字段62"));
            DataFields.Add(new FieldBase("FU:63", "", 20, "", "用户字段63"));
            DataFields.Add(new FieldBase("FU:64", "", 20, "", "用户字段64"));

            DataFields.Add(new FieldBase("FU:65", "", 40, "", "用户字段65"));
            DataFields.Add(new FieldBase("FU:66", "", 50, "", "用户字段66"));

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
