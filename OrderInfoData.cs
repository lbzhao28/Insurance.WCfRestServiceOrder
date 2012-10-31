using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Rayda.Insurance.WcfRestServiceOrder
{
    public class ReturnInfo
    {
        private bool _returnflag;
        private string _returninfo;


        public bool RETURNFLAG
        {
            set { _returnflag = value; }
            get { return _returnflag; }
        }
        public string RETURNINFO 
        {
            set { _returninfo = value; }
            get { return _returninfo; }
        }
 
    }

    public class OrderInfo
    {
        private string _orderid;
        private string _contactid;
        private string _addressid;
        private string _paytype;
        private string _mailtype;
        private string _ordertype;
        private string _crdt;

        public string DataState { get; set; }

        /// <summary>
        /// 保单编号
        /// </summary>
        public string ORDERID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string CONTACTID
        {
            set { _contactid = value; }
            get { return _contactid; }
        }
        /// <summary>
        /// 地址编号
        /// </summary>
        public string addressid
        {
            set { _addressid = value; }
            get { return _addressid; }
        }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string paytype
        {
            set { _paytype = value; }
            get { return _paytype; }
        }
        /// <summary>
        /// 订购方式
        /// </summary>
        public string mailtype
        {
            set { _mailtype = value; }
            get { return _mailtype; }
        }
        /// <summary>
        /// 保单类型
        /// </summary>
        public string ordertype
        {
            set { _ordertype = value; }
            get { return _ordertype; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public string crdt
        {
            set { _crdt = value; }
            get { return _crdt; }
        }

        //#region model
        //private string _orderid;
        //private string _contactid;
        //private string _addressid;
        //private string _paytype;
        //private string _mailtype;
        //private string _ordertype;
        //private datetime _crdt;
        //private string _crusr;
        //private string _grpid;
        //private datetime _senddt;
        //private datetime _fbdt;
        //private datetime _accdt;
        //private datetime _mddt;
        //private string _mdusr;
        //private string _urgent;
        //private string _confirm;
        //private string _status;
        //private string _result;
        //private decimal _mailprice;
        //private decimal _prodprice;
        //private decimal _discount;
        //private decimal _totalprice;
        //private string _bill;
        //private string _note;
        //private string _cardid;
        //private string _cardrightnum;
        //private decimal _nowmoney;
        //private decimal _postfee;
        //private decimal _clearfee;
        //private string _consignee;
        //private string _consignphn;
        //private datetime _demonddt;
        //private string _specialdsc;
        //private string _billtitle;
        //private string _billdemonded;
        //private string _billdemonddsc;
        //private string _amortisation;
        //private string _insuranceid;
        //private string _insurant;
        //private string _beneficiaries;
        //private string _productintro;
        //private string _healthintro;
        //private string _monitorrecorder;
        //private string _policyholder;
        ///// <summary>
        ///// 保单编号
        ///// </summary>
        //public string orderid
        //{
        //    set { _orderid = value; }
        //    get { return _orderid; }
        //}
        ///// <summary>
        ///// 客户编号
        ///// </summary>
        //public string contactid
        //{
        //    set { _contactid = value; }
        //    get { return _contactid; }
        //}
        ///// <summary>
        ///// 地址编号
        ///// </summary>
        //public string addressid
        //{
        //    set { _addressid = value; }
        //    get { return _addressid; }
        //}
        ///// <summary>
        ///// 付款方式
        ///// </summary>
        //public string paytype
        //{
        //    set { _paytype = value; }
        //    get { return _paytype; }
        //}
        ///// <summary>
        ///// 订购方式
        ///// </summary>
        //public string mailtype
        //{
        //    set { _mailtype = value; }
        //    get { return _mailtype; }
        //}
        ///// <summary>
        ///// 保单类型
        ///// </summary>
        //public string ordertype
        //{
        //    set { _ordertype = value; }
        //    get { return _ordertype; }
        //}
        ///// <summary>
        ///// 创建日期
        ///// </summary>
        //public datetime crdt
        //{
        //    set { _crdt = value; }
        //    get { return _crdt; }
        //}
        ///// <summary>
        ///// 创建人
        ///// </summary>
        //public string crusr
        //{
        //    set { _crusr = value; }
        //    get { return _crusr; }
        //}
        ///// <summary>
        ///// 创建工作组
        ///// </summary>
        //public string grpid
        //{
        //    set { _grpid = value; }
        //    get { return _grpid; }
        //}
        ///// <summary>
        ///// 交寄日期
        ///// </summary>
        //public datetime senddt
        //{
        //    set { _senddt = value; }
        //    get { return _senddt; }
        //}
        ///// <summary>
        ///// 反馈日期
        ///// </summary>
        //public datetime fbdt
        //{
        //    set { _fbdt = value; }
        //    get { return _fbdt; }
        //}
        ///// <summary>
        ///// 结账日期
        ///// </summary>
        //public datetime accdt
        //{
        //    set { _accdt = value; }
        //    get { return _accdt; }
        //}
        ///// <summary>
        ///// 最后修改日期
        ///// </summary>
        //public datetime mddt
        //{
        //    set { _mddt = value; }
        //    get { return _mddt; }
        //}
        ///// <summary>
        ///// 最后修改人
        ///// </summary>
        //public string mdusr
        //{
        //    set { _mdusr = value; }
        //    get { return _mdusr; }
        //}
        ///// <summary>
        ///// 紧急保单
        ///// </summary>
        //public string urgent
        //{
        //    set { _urgent = value; }
        //    get { return _urgent; }
        //}
        ///// <summary>
        ///// 索权标记
        ///// </summary>
        //public string confirm
        //{
        //    set { _confirm = value; }
        //    get { return _confirm; }
        //}
        ///// <summary>
        ///// 保单状态
        ///// </summary>
        //public string status
        //{
        //    set { _status = value; }
        //    get { return _status; }
        //}
        ///// <summary>
        ///// 反馈结果
        ///// </summary>
        //public string result
        //{
        //    set { _result = value; }
        //    get { return _result; }
        //}
        ///// <summary>
        ///// 运费
        ///// </summary>
        //public decimal mailprice
        //{
        //    set { _mailprice = value; }
        //    get { return _mailprice; }
        //}
        ///// <summary>
        ///// 订购产品总额
        ///// </summary>
        //public decimal prodprice
        //{
        //    set { _prodprice = value; }
        //    get { return _prodprice; }
        //}
        ///// <summary>
        ///// 最终优惠额
        ///// </summary>
        //public decimal discount
        //{
        //    set { _discount = value; }
        //    get { return _discount; }
        //}
        ///// <summary>
        ///// 订单总额
        ///// </summary>
        //public decimal totalprice
        //{
        //    set { _totalprice = value; }
        //    get { return _totalprice; }
        //}
        ///// <summary>
        ///// 需要发票
        ///// </summary>
        //public string bill
        //{
        //    set { _bill = value; }
        //    get { return _bill; }
        //}
        ///// <summary>
        ///// 订单备注
        ///// </summary>
        //public string note
        //{
        //    set { _note = value; }
        //    get { return _note; }
        //}
        ///// <summary>
        ///// 信用卡编号
        ///// </summary>
        //public string cardid
        //{
        //    set { _cardid = value; }
        //    get { return _cardid; }
        //}
        ///// <summary>
        ///// 索权号码
        ///// </summary>
        //public string cardrightnum
        //{
        //    set { _cardrightnum = value; }
        //    get { return _cardrightnum; }
        //}
        ///// <summary>
        ///// 实际收款
        ///// </summary>
        //public decimal nowmoney
        //{
        //    set { _nowmoney = value; }
        //    get { return _nowmoney; }
        //}
        ///// <summary>
        ///// 投递费
        ///// </summary>
        //public decimal postfee
        //{
        //    set { _postfee = value; }
        //    get { return _postfee; }
        //}
        ///// <summary>
        ///// 结算费
        ///// </summary>
        //public decimal clearfee
        //{
        //    set { _clearfee = value; }
        //    get { return _clearfee; }
        //}
        ///// <summary>
        ///// 收货人
        ///// </summary>
        //public string consignee
        //{
        //    set { _consignee = value; }
        //    get { return _consignee; }
        //}
        ///// <summary>
        ///// 联系电话
        ///// </summary>
        //public string consignphn
        //{
        //    set { _consignphn = value; }
        //    get { return _consignphn; }
        //}
        ///// <summary>
        ///// 要求收货时间
        ///// </summary>
        //public datetime demonddt
        //{
        //    set { _demonddt = value; }
        //    get { return _demonddt; }
        //}
        ///// <summary>
        ///// 特殊说明
        ///// </summary>
        //public string specialdsc
        //{
        //    set { _specialdsc = value; }
        //    get { return _specialdsc; }
        //}
        ///// <summary>
        ///// 发票抬头
        ///// </summary>
        //public string billtitle
        //{
        //    set { _billtitle = value; }
        //    get { return _billtitle; }
        //}
        ///// <summary>
        ///// 是否有发票要求
        ///// </summary>
        //public string billdemonded
        //{
        //    set { _billdemonded = value; }
        //    get { return _billdemonded; }
        //}
        ///// <summary>
        ///// 要求内容
        ///// </summary>
        //public string billdemonddsc
        //{
        //    set { _billdemonddsc = value; }
        //    get { return _billdemonddsc; }
        //}
        ///// <summary>
        ///// 信用卡分期数
        ///// </summary>
        //public string amortisation
        //{
        //    set { _amortisation = value; }
        //    get { return _amortisation; }
        //}
        ///// <summary>
        ///// 承保单号
        ///// </summary>
        //public string insuranceid
        //{
        //    set { _insuranceid = value; }
        //    get { return _insuranceid; }
        //}
        ///// <summary>
        ///// 被保人编号
        ///// </summary>
        //public string insurant
        //{
        //    set { _insurant = value; }
        //    get { return _insurant; }
        //}
        ///// <summary>
        ///// 受益人编号
        ///// </summary>
        //public string beneficiaries
        //{
        //    set { _beneficiaries = value; }
        //    get { return _beneficiaries; }
        //}
        ///// <summary>
        ///// 是否有产品介绍
        ///// </summary>
        //public string productintro
        //{
        //    set { _productintro = value; }
        //    get { return _productintro; }
        //}
        ///// <summary>
        ///// 是否有健康告知
        ///// </summary>
        //public string healthintro
        //{
        //    set { _healthintro = value; }
        //    get { return _healthintro; }
        //}
        ///// <summary>
        ///// 是否有保单录音监听
        ///// </summary>
        //public string monitorrecorder
        //{
        //    set { _monitorrecorder = value; }
        //    get { return _monitorrecorder; }
        //}
        ///// <summary>
        ///// 投保人编号
        ///// </summary>
        //public string policyholder
        //{
        //    set { _policyholder = value; }
        //    get { return _policyholder; }
        //}
        //#endregion model

    }
}
