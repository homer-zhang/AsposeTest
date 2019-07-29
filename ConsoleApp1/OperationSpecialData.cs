using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OperationSpecialData : SegmentBase
    {
        public OperationSpecialData(ActionType actionType)
        {
            SegmentName = "HY72_AG_RF";
            this.Action = actionType;

            DataFields.Add(new FieldBase("ANR", "", 40, "", "组合订单/OP 号"));    //必填
            DataFields.Add(new FieldBase("RFAGTYP", " ", 1, "", "特殊指标；工序类型"));
            DataFields.Add(new FieldBase("RFABZ", "M", 1, "", "识别主工序和子工序"));
            DataFields.Add(new FieldBase("RFOPT:RS", " ", 1, "", "滚切指标（仅与切割工序相关"));
            DataFields.Add(new FieldBase("RFMANR", "", 40, "", "卷轴切割中提及的主工序用于定义切割计划"));
            DataFields.Add(new FieldBase("RFTRANZ", 0, 5, "", "对于切割工序：每次切割规划的子卷轴数量"));
            DataFields.Add(new FieldBase("RFTRANZSUM", 0, 5, "", "对于切割工序（主工序）：每次切割规划的子卷轴数量（所有扣除的物料）"));
            DataFields.Add(new FieldBase("RFRANZ", 0, 6, "", "计划生产的卷轴总量（主/子卷轴）；HYDRA 中不做特殊处理"));
            DataFields.Add(new FieldBase("RFSTKF", 0, 8, "", "制品外观,单位：MM2/ PCE （总数）"));
            DataFields.Add(new FieldBase("RFBSBRS", 0m, 10, 3, "", "卷边宽度总计"));
            DataFields.Add(new FieldBase("RFBREITEE", 0m, 10, 3, "", "工序的输入数据带宽"));
            DataFields.Add(new FieldBase("RFBREITEA", 0m, 10, 3, "", "工序的输出数据带宽"));
            DataFields.Add(new FieldBase("RFAGVFA", 0m, 10, 3, "", "单位面积质量单位 I：G/M2"));
            DataFields.Add(new FieldBase("Casingweight", 0m, 10, 3, "", "切割进程中显示子卷轴的套管重量单位： G"));

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
