using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 组件
    /// </summary>
    public class OperationComponent:SegmentBase
    {
        public ComponentUserField ComponentUserField { get; set; }
        public OperationComponent(ActionType actionType)
        {
            SegmentName = "HY72_AG_KOMPL";
            this.Action = actionType;

            DataFields.Add(new FieldBase("ANR", "", 40, "ProdOprId", "组合订单/OP 号"));   //必填
            DataFields.Add(new FieldBase("ATK", "", 40, "", "物料编号"));   //必填
            DataFields.Add(new FieldBase("ATKBEZ", "", 40, "", "物料名称"));  //必填
            DataFields.Add(new FieldBase("BEZ", "", 30, "", "备注 1"));
            DataFields.Add(new FieldBase("BEZ:2", "", 30, "", "备注 2"));
            DataFields.Add(new FieldBase("SLP", "", 10, "", "BOM item 层型结构中组件的位置")); //必填
            DataFields.Add(new FieldBase("SLS", 0, 8, "", "BOM level"));
            DataFields.Add(new FieldBase("ART", "", 2, "", "物料类型"));
            DataFields.Add(new FieldBase("MATTYP", "SYSTEM", 10, "", "MPL/MPL-RF：物料类型"));
            DataFields.Add(new FieldBase("VERBR", "", 1, "", "MPL/MPL-RF：消耗类型"));
            DataFields.Add(new FieldBase("OPT:ERSB", "N", 1, "", "MPL-RF：可替换–除计划物料外是否还可以使用另外的物料"));
            DataFields.Add(new FieldBase("OPT:WZW", "N", 1, "", "MPL/MPL-RF：必须变更；物料输入批次变更需要一个输出批次的变更"));
            DataFields.Add(new FieldBase("SGR:GUT", 0m, 13, 3, "", "MPL/MPL-RF：输入量参考工序基准数量单位内生产一件商品所需的量。"));
            DataFields.Add(new FieldBase("SGE:GUT", "", 3, "", "MPL/MPL-RF：输入量的数量单位"));
            DataFields.Add(new FieldBase("MENGEPROZ", 0m, 13, 3, "", "输入量比率"));
            DataFields.Add(new FieldBase("OTG", 0m, 13, 3, "", "公差上限百分比； 小数点后保留3 位"));
            DataFields.Add(new FieldBase("UTG", 0m, 13, 3, "", "公差下限百分比；小数点后保留3 位"));
            DataFields.Add(new FieldBase("EGR:GUT", 0m, 13, 3, "", "总量/需求量：工序总需求量，即待生产量（产量）"));
            DataFields.Add(new FieldBase("EGE:GUT", "", 3, "", "需求量单位"));
            DataFields.Add(new FieldBase("SLS:M", 0, 8, "", "初始物料的BOM 级别"));
            DataFields.Add(new FieldBase("SLP:M", "", 10, "", "初始物料的BOM 项目"));
            DataFields.Add(new FieldBase("MENGE:FIX", "", 1, "", "指标：定量"));
            DataFields.Add(new FieldBase("PPS:RETRO", "", 1, "", "指标：逆算法（逆行消除）（in PPS）"));
            DataFields.Add(new FieldBase("MENGETOL", 0m, 13, 3, "", "公差百分比"));
            DataFields.Add(new FieldBase("MENGEABW", 0m, 13, 3, "", "偏差百分比"));
        }

        public override string ToString()
        {
            string data = "";
            foreach (var field in DataFields)
            {
                data += field.ToString();
            }
            this.SetSData(data);
            string ret = base.ToString();
            if (ComponentUserField != null)
                ret += ComponentUserField.ToString();
            return ret;
        }
    }
}
