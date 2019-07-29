using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OperationResource:SegmentBase
    {
       /// <summary>
       /// 工序资源和工具
       /// </summary>
       /// <param name="actionType"></param>
        public OperationResource(ActionType actionType)
        {
            SegmentName = "HY72_AG_FHM";
            this.Action = actionType;

            DataFields.Add(new FieldBase("ANR", "", 40, "", "组合订单/OP 号"));  //必填
            DataFields.Add(new FieldBase("RESTYP", "", 4, "", "资源类型；可能的数值")); //DNC DNC 程序ENT 拆除装置TEM 保温装置VOR 设施/装置WNR 工具
            DataFields.Add(new FieldBase("ATK", "", 40, "", "资源/物料编号"));//必填
            DataFields.Add(new FieldBase("ATKBEZ", "", 40, "", "指示"));
            DataFields.Add(new FieldBase("BEZ", "", 30, "", "备注 1"));
            DataFields.Add(new FieldBase("BEZ:2", "", 30, "", "备注 2"));
            DataFields.Add(new FieldBase("SGR:GUT", 1m, 13, 3, "", "已使用数量"));
            DataFields.Add(new FieldBase("SGE:GUT", "", 3, "", "数量单位"));

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
