using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 工单
    /// </summary>
    public class ProductOrder : SegmentBase
    {
        /// <summary>
        /// 长文本
        /// </summary>
        public List<ProductLongText> ProductLongTextList { get; set; }
        /// <summary>
        /// 用户字段
        /// </summary>
        public ProductUserField ProductUserField { get; set; }
        /// <summary>
        /// 操作数据
        /// </summary>
        public List<ProductOperation> OperationList { get; set; }

        public ProductOrder(ActionType actionType)
        {
            SegmentName = "HY72_AU_HD";
            this.Action = actionType;
            InitFromActionType();
        }

        private void InitFromActionType()
        {
            switch(Action)
            {
                case ActionType.A:
                    this.ProductLongTextList = new List<ProductLongText>();
                    this.OperationList = new List<ProductOperation>();
                    break;
                case ActionType.D:
                    this.ProductLongTextList = new List<ProductLongText>();
                    this.OperationList = new List<ProductOperation>();
                    break;
                default:
                    throw new Exception("错误的操作类型");
            }

            DataFields.Add(new FieldBase("AUNR", "", 40, "ProdId", "订单号"));               //必填
            DataFields.Add(new FieldBase("AUART", "", 5, "ProdType", "订单类型"));            //必填
            DataFields.Add(new FieldBase("ATK", "", 40, "ItemId", "物品，字母符号需大写"));//必填   
            DataFields.Add(new FieldBase("ATKBEZ", "", 40, "ItemName", "物品名称"));
            DataFields.Add(new FieldBase("KDBEZ", "", 40, "", "客户名"));
            DataFields.Add(new FieldBase("KDAUNR", "", 25, "", "销售订单"));
            DataFields.Add(new FieldBase("KDAUPOS", "", 15, "", "销售订单项"));
            DataFields.Add(new FieldBase("EXTPRIO", "", 1, "", "优先级"));
            DataFields.Add(new FieldBase("AUIDX", 0.0m, 4, 2, "", "订单指数"));
            DataFields.Add(new FieldBase("SGE:B", "", 3, "UnitId", "基本数量单位=订单头-数量单位"));//必填
            DataFields.Add(new FieldBase("SGR:GUTB", 1.0m, 13,3, "ProdQty", "目标数量（基本数量单位）"));//必填
            DataFields.Add(new FieldBase("SGR:AUSB", 1.0m, 13,3, "", "目标废品数（基本数量单位）"));
            DataFields.Add(new FieldBase("MATTYP", "SYSTEM", 10, "", "制品物料类型"));
            DataFields.Add(new FieldBase("FILLER", "", 10, "", "预留；应该为空"));
            DataFields.Add(new FieldBase("CNR", "", 20, "", "批次号"));
            DataFields.Add(new FieldBase("PCNR", "", 20, "", "检验订单/检验批次号"));
            DataFields.Add(new FieldBase("PPKTTYP", "", 1, "", "样本类型"));
            DataFields.Add(new FieldBase("DATFB", DateTime.Parse("1900-01-01"), "", "最早开始（日期）"));
            DataFields.Add(new FieldBase("ZEIFB", 0, 5, "", "最早开始（时间）"));
            DataFields.Add(new FieldBase("DATSE", DateTime.Parse("1900-01-01"), "", "最后终止（日期）"));
            DataFields.Add(new FieldBase("ZEISE", 0, 5, "", "最后终止（时间）"));
            DataFields.Add(new FieldBase("DATTERMB", DateTime.Parse("1900-01-01"), "", "计划开始（日期）"));
            DataFields.Add(new FieldBase("ZEITERMB", 0, 5, "", "计划开始（时间）"));
            DataFields.Add(new FieldBase("DATTERME", DateTime.Parse("1900-01-01"), "", "计划终止（日期）"));
            DataFields.Add(new FieldBase("ZEITERME", 0, 5, "", "计划终止（时间）"));
            DataFields.Add(new FieldBase("TERMART", "", 1, "", "日程安排类型"));
            DataFields.Add(new FieldBase("REDSTRAT", "", 2, "", "缩减策略符合HYDRA 客户化定制"));
            DataFields.Add(new FieldBase("AUGRP", "", 4, "", "订单组"));
            DataFields.Add(new FieldBase("DISP", "", 10, "", "MRP 控制器"));
            DataFields.Add(new FieldBase("PRJNR", "", 25, "", "项目号"));
            DataFields.Add(new FieldBase("PLANAUNR", "", 25, "", "计划订单"));
            DataFields.Add(new FieldBase("KTR", "", 25, "", "成本对象"));
            DataFields.Add(new FieldBase("APNR", "", 40, "", "工作计划"));
            DataFields.Add(new FieldBase("APVER", "", 12, "", "工作计划版本"));
            DataFields.Add(new FieldBase("SLVER", "", 12, "", "BOM 版本"));
            DataFields.Add(new FieldBase("KLKK:MNR", 0m, 13, 3, "", "计算设备成本"));
            DataFields.Add(new FieldBase("KLKK:L", 0m, 13, 3, "", "计算薪资成本"));
            DataFields.Add(new FieldBase("KLKK:MAT", 0m, 13, 3, "", "计算物料成本"));
            DataFields.Add(new FieldBase("KLKK:SONST", 0m, 13, 3, "", "计算其他成本"));
            DataFields.Add(new FieldBase("MATWERT:GOOD", 0m, 13, 3, "", "物料值"));
            DataFields.Add(new FieldBase("MATWERT:AUS", 0m, 13, 3, "", "废料值"));
            DataFields.Add(new FieldBase("ANR.KBN:LBEZID", "", 15, "", "eKANBAN 逻辑系统"));

        }

        public override string ToString()
        {
            string data = "";
            foreach (var field in DataFields)
            {
                data += field.ToString();
            }
            this.SetSData(data);
            string ret =  base.ToString();
            foreach (var item in ProductLongTextList)
            {
                ret += item.ToString();
            }
            if (ProductUserField != null)
                ret += ProductUserField.ToString();
            foreach (var item in OperationList)
            {
                ret += item.ToString();
            }

            return ret;
        }

        public void Load(string path)
        {

        }

        public void Save(string path)
        {
            UTF8Encoding utf8 = new UTF8Encoding(false);
            using (StreamWriter sw = new StreamWriter(path, false, utf8))
            {
                sw.Write(this.ToString());
                sw.Flush();
                sw.Close();
            }
        }
    }
}
