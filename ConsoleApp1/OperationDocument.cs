using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 工序文档
    /// </summary>
    public class OperationDocument : SegmentBase
    {
        public OperationDocument(ActionType actionType)
        {
            SegmentName = "HY72_AG_DOC";
            this.Action = actionType;

            DataFields.Add(new FieldBase("ANR", "", 40, "", "组合订单/OP 号")); //必填
            DataFields.Add(new FieldBase("ATK", "", 40, "", "文档 ID: 唯一键"));//必填
            DataFields.Add(new FieldBase("ATKBEZ", "", 40, "", "指示"));//必填
            DataFields.Add(new FieldBase("BEZ", "", 30, "", "备注 1"));
            DataFields.Add(new FieldBase("BEZ:2", "", 30, "", "备注 2"));
            DataFields.Add(new FieldBase("PATH", "", 8, "", "参考 path configuration 中定义的路径"));//必填
            DataFields.Add(new FieldBase("DATEI", "", 128, "", "文件名"));//必填

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
