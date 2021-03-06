using System;
using System.Collections.Generic;
using System.Text;

namespace CHEXC.ClassInfo
{
	public class tb_KcGoods
	{
        private int KcID;
        public int intKcID
        {
            get { return KcID; }
            set { KcID = value; }
        }
        private string GoodsID;
        public string strGoodsID
        {
            get { return GoodsID; }
            set { GoodsID = value; }
        }
        private string JhCompName;
        public string strJhCompName
        {
            get { return JhCompName; }
            set { JhCompName = value; }
        }
        private string KcDeptName;
        public string strKcDeptName
        {
            get { return KcDeptName; }
            set { KcDeptName = value; }
        }
        private string KcGoodsName;
        public string strKcGoodsName
        {
            get { return KcGoodsName; }
            set { KcGoodsName = value; }
        }
        private int  KcNum;
        public int intKcNum
        {
            get { return KcNum; }
            set { KcNum = value; }
        }
        private int KcAlarmNum;
        public int intKcAlarmNum
        {
            get { return KcAlarmNum; }
            set { KcAlarmNum = value; }
        }
        private string KcUnit;
        public string intKcUnit
        {
            get { return KcUnit; }
            set { KcUnit = value; }
        }
        private DateTime KcTime;
        public DateTime daKcTime
        {
            get { return KcTime; }
            set { KcTime = value; }
        }
        private string KcGoodsPrice;
        public string deKcGoodsPrice
        {
            get { return KcGoodsPrice; }
            set { KcGoodsPrice = value; }
        }
        private string KcSellPrice;
        public string deKcSellPrice
        {
            get { return KcSellPrice; }
            set { KcSellPrice = value; }
        }
        private string KcEmp;
        public string strKcEmp
        {
            get { return KcEmp; }
            set { KcEmp = value; }
        }
        private string KcRemark;
        public string strKcRemark
        {
            get { return KcRemark; }
            set { KcRemark = value; }
        }

        public tb_KcGoods() { }
        public tb_KcGoods(string GoodsId, string JhCompName, string KcDeptName, string KcGoodsName, int KcNum, int KcAlarmNum, string KcUnit, DateTime KcTime, string KcGoodsPrice, string KcSellPrice, string KcEmpt, string KcRemark)
        {
            this.GoodsID = GoodsId;
            this.JhCompName = JhCompName;
            this.KcDeptName = KcDeptName;
            this.KcGoodsName = KcGoodsName;
            this.KcNum = KcNum;
            this.KcAlarmNum = KcAlarmNum;
            this.KcUnit = KcUnit;
            this.KcTime = KcTime;
            this.deKcGoodsPrice = KcGoodsPrice;
            this.KcSellPrice = KcSellPrice;
            this.KcEmp = KcEmpt;
            this.KcRemark = KcRemark;
        }
	
       public tb_KcGoods(string GoodsId,int kc)
       {
           this.GoodsID = GoodsId;
           this.KcNum = kc;
       }

    } 
}