using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 工序
    /// </summary>
    public class ProductOperation : SegmentBase
    {
        public List<OperationComponent> ComponentList { get; set; }
        public List<OperationResource> ResourceList { get; set; }
        public List<OperationDocument> DocumentList { get; set; }
        public List<OperationLongText> LongTextList { get; set; }
        public ComponentUserField OperationUserField { get; set; }
        public OperationSpecialData SpecialData { get; set; }
        public ProductOperation(ActionType actionType)
        {
            SegmentName = "HY72_AG_HD";
            this.Action = actionType;
            switch (Action)
            {
                case ActionType.A:
                    this.ComponentList = new List<OperationComponent>();
                    this.ResourceList = new List<OperationResource>();
                    this.DocumentList = new List<OperationDocument>();
                    this.LongTextList = new List<OperationLongText>();
                    break;
                case ActionType.D:
                    this.ComponentList = new List<OperationComponent>();
                    this.ResourceList = new List<OperationResource>();
                    this.DocumentList = new List<OperationDocument>();
                    this.LongTextList = new List<OperationLongText>();
                    break;
                default:
                    throw new Exception("错误的操作类型");
            }

            DataFields.Add(new FieldBase("ANR", "", 40, "ProdOprId", "组合订单/OP 号"));   //必填
            DataFields.Add(new FieldBase("AUART", "", 5, "", "订单类型"));
            DataFields.Add(new FieldBase("AGBEZ", "", 40, "", "工序名称"));  //必填
            DataFields.Add(new FieldBase("ATK", "", 40, "", "商品/制品（编号）"));
            DataFields.Add(new FieldBase("ATKBEZ", "", 40, "", "制品/商品名称"));
            DataFields.Add(new FieldBase("MATTYP", "", 10, "", "制品/商品的物料类型"));
            DataFields.Add(new FieldBase("FILLER", "", 10, "", "预留；必须为空"));
            DataFields.Add(new FieldBase("EXTPRIO", "", 1, "", "优先（0 - 9; 9 =优先级高）"));   //必填
            DataFields.Add(new FieldBase("MNR", "", 8, "", "计划的工位"));    //必填
            DataFields.Add(new FieldBase("MGRP", "", 8, "", "工位的计划组和/或组"));     //必填
            DataFields.Add(new FieldBase("OPT:PLAN", "", 1, "", "OPT:PLAN"));    //必填
            DataFields.Add(new FieldBase("RES:WNR", "", 40, "", "（主要）工具"));
            DataFields.Add(new FieldBase("RES:DNC", "", 40, "", "NC 程序"));
            DataFields.Add(new FieldBase("RES:EMAT", "", 40, "", "（主要）输入材料"));
            DataFields.Add(new FieldBase("COLOR", "", 20, "", "物料颜色"));
            DataFields.Add(new FieldBase("KST", "", 8, "", "成本中心"));
            DataFields.Add(new FieldBase("KART", "", 10, "", "成本类型"));
            DataFields.Add(new FieldBase("ASTUFE", "", 1, "", "登录/出工序的授权级别（最低授权= 1）"));
            DataFields.Add(new FieldBase("RMNR", "", 10, "", "上传数量"));
            DataFields.Add(new FieldBase("DATFB", DateTime.Parse("1900-01-01"), "ProdId", "最早开始（日期）"));
            DataFields.Add(new FieldBase("ZEIFB", 0, 5, "ProdId", "最早开始（时间）"));
            DataFields.Add(new FieldBase("DATSE", DateTime.Parse("1900-01-01"), "ProdId", "最后终止（日期）"));
            DataFields.Add(new FieldBase("ZEISE", 0, 5, "ProdId", "最后终止（时间）"));
            DataFields.Add(new FieldBase("DATTERMB", DateTime.Parse("1900-01-01"), "ProdId", "计划开始（日期）"));
            DataFields.Add(new FieldBase("ZEITERMB", 0, 5, "ProdId", "计划开始（时间）"));
            DataFields.Add(new FieldBase("DATTERME", DateTime.Parse("1900-01-01"), "ProdId", "计划终止（日期）"));
            DataFields.Add(new FieldBase("ZEITERME", 0, 5, "ProdId", "计划终止（时间）"));
            DataFields.Add(new FieldBase("DATSB", DateTime.Parse("1900-01-01"), "ProdId", "最新起始（日期）"));
            DataFields.Add(new FieldBase("ZEISB", 0, 5, "ProdId", "最新起始（时间）"));
            DataFields.Add(new FieldBase("DATFE", DateTime.Parse("1900-01-01"), "ProdId", "最早终止（日期）"));
            DataFields.Add(new FieldBase("ZEIFE", 0, 5, "ProdId", "最早终止（时间）"));
            DataFields.Add(new FieldBase("DATB", DateTime.Parse("1900-01-01"), "ProdId", "计划的起始（日期）"));
            DataFields.Add(new FieldBase("ZEIB", 0, 5, "ProdId", "计划起始（时间）"));
            DataFields.Add(new FieldBase("DATE", DateTime.Parse("1900-01-01"), "ProdId", "计划终止（日期）"));
            DataFields.Add(new FieldBase("ZEIE", 0, 5, "ProdId", "计划终止（时间）"));
            DataFields.Add(new FieldBase("SGR:GUTB", 0m, 13, 3, "", "目标数量（基本数量单位）"));   
            DataFields.Add(new FieldBase("SGR:GUTP", 0m, 13, 3, "", "目标数量（基本数量单位）"));   //必填
            DataFields.Add(new FieldBase("SGR:GUTS", 0m, 13, 3, "", "目标数量（次级数量单位）"));
            DataFields.Add(new FieldBase("SGR:GUTT", 0m, 13, 3, "", "目标数量（三级数量单位）"));
            DataFields.Add(new FieldBase("SGR:AUSB", 0m, 13, 3, "", "目标废品数（基本数量单位）"));
            DataFields.Add(new FieldBase("SGR:AUSP", 0m, 13, 3, "", "目标报废数量（基本数量单位）"));
            DataFields.Add(new FieldBase("SGR:AUSS", 0m, 13, 3, "", "目标报废数量（次级数量单位）"));
            DataFields.Add(new FieldBase("SGR:AUST", 0m, 13, 3, "", "目标报废数量（三级数量单位）"));
            DataFields.Add(new FieldBase("SGE:B", "", 3, "", "基本数量单位"));
            DataFields.Add(new FieldBase("SGE:P", "", 3, "", "基本输入数量单位"));  //必填
            DataFields.Add(new FieldBase("SGE:S", "", 3, "", "次级输入数量单位"));
            DataFields.Add(new FieldBase("SGE:T", "", 3, "", "三级输入数量单位"));
            DataFields.Add(new FieldBase("WEIGMENGE", 0m, 13, 3, "", "最小发送数量（基本数量单位）"));
            DataFields.Add(new FieldBase("MENGEPROZ:UNTLI", 0m, 13, 3, "", "欠交百分比"));
            DataFields.Add(new FieldBase("OPT:UNTLI", " ", 1, "", "对欠交的响应"));
            DataFields.Add(new FieldBase("MENGEPROZ:UEBLI", 0m, 13, 3, "", "超交百分率"));
            DataFields.Add(new FieldBase("OPT:UEBLI", " ", 1, "", "对超交的响应"));
            DataFields.Add(new FieldBase("UMRFAKTP:Z", 0, 8, "", "基准量转换到基本量的分子"));
            DataFields.Add(new FieldBase("UMRFAKTP:N", 0, 8, "", "基准量转换到基本量的分母"));
            DataFields.Add(new FieldBase("UMRFAKTS:Z", 0, 8, "", "次级数量到基本数量转换的分母"));
            DataFields.Add(new FieldBase("UMRFAKTS:N", 0, 8, "", "次级数量到基本数量转换的分子"));
            DataFields.Add(new FieldBase("UMRFAKTT:Z", 0, 8, "", "三级数量到基本量转换的分子"));
            DataFields.Add(new FieldBase("UMRFAKTT:N", 0, 8, "", "三级数量到基本数量转换的分母"));
            DataFields.Add(new FieldBase("RUEZ", 0, 8, "", "设置时间以秒为单位。如果无设置时间，该值应设为0."));
            DataFields.Add(new FieldBase("RUEZ:ZUSCHL", 0, 8, "", "附加设置时间以秒为单位。如果无附加设置时间则应设为0。"));
            DataFields.Add(new FieldBase("BEARBZEI", 0, 8, "", "处理时间以秒为单位。如果没有处理时间则应设为0"));
            DataFields.Add(new FieldBase("PZ", 0, 8, "", "检验时间以秒为单位。如果无检验时间则应设为0。"));
            DataFields.Add(new FieldBase("ABRZ", 0, 8, "", "分解/再加工时间以秒为单位。如果不存在则应设为0"));
            DataFields.Add(new FieldBase("LIZ", 0, 8, "", "交货时间以秒为单位"));
            DataFields.Add(new FieldBase("FREMDFERT", "N", 1, "", "外部处理工序Y/N"));
            DataFields.Add(new FieldBase("RLZ:EXPR", "", 6, "", "剩余运行时间（公式1）"));
            DataFields.Add(new FieldBase("RLZ:EXPR2", "", 6, "", "剩余运行时间（公式2）；选项（为空）"));
            DataFields.Add(new FieldBase("VLZ", 0, 8, "", "交付时间以秒为单位，如果不可用应设为0"));
            DataFields.Add(new FieldBase("LIEZ:MAX", 0, 8, "", "最大同步时间以秒为单位。如果不可用应设为0"));
            DataFields.Add(new FieldBase("WARTZ", 0, 8, "", "等待时间以秒为单位。如果不可用应设为0"));
            DataFields.Add(new FieldBase("WARTZ:MIN", 0, 8, "", "最短等待时间以秒为单位。如果不可用应设为0"));
            DataFields.Add(new FieldBase("LIEZ", 0, 8, "", "闲置期以秒为单位。如果不可用应设为0"));
            DataFields.Add(new FieldBase("LART", "", 4, "", "工资类型"));
            DataFields.Add(new FieldBase("PIECEWORK", "", 1, "", "计件指标/奖金"));
            DataFields.Add(new FieldBase("TE", 0m, 13, 3, "", "每 1000 件制品以秒为单位的溢价规格te 值。如果不适用应设为0"));
            DataFields.Add(new FieldBase("TR", 0m, 13, 3, "", "溢价规格tr 值以秒为单位。如果不适用应设为0"));
            DataFields.Add(new FieldBase("TEB", 0m, 13, 3, "", "每 1000 件制品以秒为单位的溢价规格teb 值。如果不适用应设为0"));
            DataFields.Add(new FieldBase("TRB", 0m, 13, 3, "", "溢价规格trb 值以秒为单位。如果不适用应设为0"));
            DataFields.Add(new FieldBase("VERARBCODE", "SYSTEM", 6, "", "处理代码；定为\"SYSTEM\"。偏离设置可能与HYDRA 客户化定制有关"));
            DataFields.Add(new FieldBase("OPT:ERF", "N", 1, "", "可记录 Y/N"));
            DataFields.Add(new FieldBase("OPT:MULTIMNR", "N", 1, "", "并行生产 Y/N"));
            DataFields.Add(new FieldBase("OPT:CNR", "N", 1, "", "服从批次管理J/N （\"J\" 仅与MPL / TRT 和/或AIP-MTR 相关）"));
            DataFields.Add(new FieldBase("OPT:SNR", "E", 1, "", "服从序列号管理"));
            DataFields.Add(new FieldBase("SZY", 0, 8, "", "目标周期以秒为单位/1000;"));
            DataFields.Add(new FieldBase("TLG", 1, 8, "", "分区；应该预置为1"));
            DataFields.Add(new FieldBase("IMPFAKT", 1m, 13, 3, "", "脉冲系数；只能为整数！默认为1"));
            DataFields.Add(new FieldBase("OPT:SPLIT", "N", 1, "", "分区 V/N"));
            DataFields.Add(new FieldBase("MAXANZSPLIT", 0, 8, "", "最大分隔数（ OPT:SPLIT = V 时才相关）"));
            DataFields.Add(new FieldBase("MBVERH:RUE", 0m, 5, 2, "", "设备-操作员比率设置/PEP 劳动力需求设置"));
            DataFields.Add(new FieldBase("MBVERH:NORM", 0m, 5, 2, "", "设备-操作员比率生产/PEP 劳动力需求生产"));
            DataFields.Add(new FieldBase("QUAL:NORM", 0, 8, "", "PEP：资质生产"));
            DataFields.Add(new FieldBase("QUAL:RUE", 0, 8, "", "PEP：资质设置"));


        }

        public override string ToString()
        {
            string ret = "";
            string data = "";
            foreach (var field in DataFields)
            {
                data += field.ToString();
            }
            this.SetSData(data);
            ret = base.ToString();
            foreach (var item in ComponentList)
            {
                ret += item.ToString();
            }
            foreach (var item in ResourceList)
            {
                ret += item.ToString();
            }
            foreach (var item in DocumentList)
            {
                ret += item.ToString();
            }
            foreach (var item in LongTextList)
            {
                ret += item.ToString();
            }
            if(OperationUserField != null)
            {
                ret += OperationUserField.ToString();
            }
            if (SpecialData != null)
            {
                ret += SpecialData.ToString();
            }
            return ret;
        }

    }
}
