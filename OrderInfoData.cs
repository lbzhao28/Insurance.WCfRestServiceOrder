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
    //保单明细表
    public class OrderDetInfo
    {
        //对照orderdet 表填充完成.
        #region Model
        private string _orderdetid;
        private string _orderid;
        private string _contactid;
        private string _producttype1;
        private string _soldwith;
        private string _status;
        private string _reckoning;
        private string _reckoningdt;
        private string _fbdt;
        private string _uprice;
        private string _prodnum;
        private string _freight;
        private string _payment;
        private string _postfee;
        private string _clearfee;
        private string _crdt;
        private string _breason;
        private string _feedback;
        private string _goodsback;
        private string _backdt;
        private string _backmoney;
        private string _cardrightnum;
        private string _accountingcost;
        private string _prodbankid;
        private string _isrefund;
        private string _refunddt;
        private string _proddetid;


        private string _dataState;

        public string DataState
        {
            get { return _dataState; }
            set { _dataState = value; }
        }
        /// <summary>
        /// 保单明细编号
        /// </summary>
        public string ORDERDETID
        {
            set { _orderdetid = value; }
            get { return _orderdetid; }
        }
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
        /// 规格编号1
        /// </summary>
        public string PRODUCTTYPE1
        {
            set { _producttype1 = value; }
            get { return _producttype1; }
        }
        /// <summary>
        /// 销售方式（SOLDWITH）
        /// </summary>
        public string SOLDWITH
        {
            set { _soldwith = value; }
            get { return _soldwith; }
        }
        /// <summary>
        /// 产品状态（PRODSTATUS）
        /// </summary>
        public string STATUS
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 结账状态
        /// </summary>
        public string RECKONING
        {
            set { _reckoning = value; }
            get { return _reckoning; }
        }
        /// <summary>
        /// 结账日期
        /// </summary>
        public string RECKONINGDT
        {
            set { _reckoningdt = value; }
            get { return _reckoningdt; }
        }
        /// <summary>
        /// 反馈日期
        /// </summary>
        public string FBDT
        {
            set { _fbdt = value; }
            get { return _fbdt; }
        }
        /// <summary>
        /// 产品原价
        /// </summary>
        public string UPRICE
        {
            set { _uprice = value; }
            get { return _uprice; }
        }
        /// <summary>
        /// 订购数量
        /// </summary>
        public string PRODNUM
        {
            set { _prodnum = value; }
            get { return _prodnum; }
        }
        /// <summary>
        /// 运费
        /// </summary>
        public string FREIGHT
        {
            set { _freight = value; }
            get { return _freight; }
        }
        /// <summary>
        /// 实际付款
        /// </summary>
        public string PAYMENT
        {
            set { _payment = value; }
            get { return _payment; }
        }
        /// <summary>
        /// 投递费
        /// </summary>
        public string POSTFEE
        {
            set { _postfee = value; }
            get { return _postfee; }
        }
        /// <summary>
        /// 结算费
        /// </summary>
        public string CLEARFEE
        {
            set { _clearfee = value; }
            get { return _clearfee; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public string CRDT
        {
            set { _crdt = value; }
            get { return _crdt; }
        }
        /// <summary>
        /// 退货原因
        /// </summary>
        public string BREASON
        {
            set { _breason = value; }
            get { return _breason; }
        }
        /// <summary>
        /// 产品反馈结果
        /// </summary>
        public string FEEDBACK
        {
            set { _feedback = value; }
            get { return _feedback; }
        }
        /// <summary>
        /// 退货地点
        /// </summary>
        public string GOODSBACK
        {
            set { _goodsback = value; }
            get { return _goodsback; }
        }
        /// <summary>
        /// 退货日期
        /// </summary>
        public string BACKDT
        {
            set { _backdt = value; }
            get { return _backdt; }
        }
        /// <summary>
        /// 退货金额
        /// </summary>
        public string BACKMONEY
        {
            set { _backmoney = value; }
            get { return _backmoney; }
        }
        /// <summary>
        /// 索权号
        /// </summary>
        public string CARDRIGHTNUM
        {
            set { _cardrightnum = value; }
            get { return _cardrightnum; }
        }
        /// <summary>
        /// 核算成本
        /// </summary>
        public string ACCOUNTINGCOST
        {
            set { _accountingcost = value; }
            get { return _accountingcost; }
        }
        /// <summary>
        /// 对应银行产品编号（银行业务有效）
        /// </summary>
        public string PRODBANKID
        {
            set { _prodbankid = value; }
            get { return _prodbankid; }
        }
        /// <summary>
        /// 是否退款 1 代表已汇款 0或Null 代表没汇款
        /// </summary>
        public string ISREFUND
        {
            set { _isrefund = value; }
            get { return _isrefund; }
        }
        /// <summary>
        /// 退款日期
        /// </summary>
        public string REFUNDDT
        {
            set { _refunddt = value; }
            get { return _refunddt; }
        }
        /// <summary>
        /// 产品明细编号
        /// </summary>
        public string PRODDETID
        {
            set { _proddetid = value; }
            get { return _proddetid; }
        }
        #endregion Model
    }
    //保险人信息
    public class InsuranceUsrInfo
    {
        //对照INSURANCE_USR 表填充完成.
        #region Model
        private string _insurance_usrid;

       
        private string _name;
        private string _sex;
        private string _idcardtype;
        private string _idcardno;
        private string _idperiod;
        private string _dsc;
        private string _crdt;
        private string _crusr;
        private string _mddt;
        private string _mdusr;
        private string _profession;
        private string _post;
        private string _proportion;

        public string Proportion
        {
            get { return _proportion; }
            set { _proportion = value; }
        }

        private string _dataState;

        public string DataState
        {
            get { return _dataState; }
            set { _dataState = value; }
        }
        /// <summary>
        /// /// <summary>
        /// 保险人编号
        /// </summary>
        /// </summary>
        public string INSURANCE_USRID
        {
            get { return _insurance_usrid; }
            set { _insurance_usrid = value; }
        }
        /// <summary>
        /// 保险人姓名
        /// </summary>
        public string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string SEX
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 身份证件类型
        /// </summary>
        public string IDCARDTYPE
        {
            set { _idcardtype = value; }
            get { return _idcardtype; }
        }
        /// <summary>
        /// 身份证件号码
        /// </summary>
        public string IDCARDNO
        {
            set { _idcardno = value; }
            get { return _idcardno; }
        }
        /// <summary>
        /// 身份证件有效期
        /// </summary>
        public string IDPERIOD
        {
            set { _idperiod = value; }
            get { return _idperiod; }
        }
        /// <summary>
        /// 保险人备注
        /// </summary>
        public string DSC
        {
            set { _dsc = value; }
            get { return _dsc; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public string CRDT
        {
            set { _crdt = value; }
            get { return _crdt; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CRUSR
        {
            set { _crusr = value; }
            get { return _crusr; }
        }
        /// <summary>
        /// 修改日期
        /// </summary>
        public string MDDT
        {
            set { _mddt = value; }
            get { return _mddt; }
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public string MDUSR
        {
            set { _mdusr = value; }
            get { return _mdusr; }
        }
        /// <summary>
        /// 职业编号
        /// </summary>
        public string PROFESSION
        {
            set { _profession = value; }
            get { return _profession; }
        }
        /// <summary>
        /// 职位编号
        /// </summary>
        public string POST
        {
            set { _post = value; }
            get { return _post; }
        }
        #endregion Model
    }
    //保单历时表
    public class OrderInfo
    {
        #region
        private string _orderid;
        private string _contactid;
        private string _addressid;
        private string _paytype;
        private string _mailtype;
        private string _ordertype;
        private string _crdt;
        private string _crusr;
        private string _grpid;
        private string _senddt;

        private string _fbdt;
        private string _accdt;
        private string _mddt;
        private string _mdusr;
        private string _urgent;
        private string _confirm;
        private string _status;
        private string _result;
        private string _mailprice;
        private string _prodprice;

        private string _discount;
        private string _totalprice;
        private string _bill;
        private string _note;
        private string _cardid;
        private string _cardrightnum;
        private string _nowmoney;
        private string _postfee;
        private string _clearfee;
        private string _consignee;

        private string _consignphn;
        private string _demonddt;
        private string _specialdsc;
        private string _billtitle;
        private string _billdemonded;
        private string _billdemonddsc;
        private string _amortisation;
        private string _insuranceid;
        private string _insurant;
        private string _beneficiaries;
        private string _beneficiaries2;
        private string _beneficiaries3;

        private string _productintro;
        private string _healthintro;
        private string _monitorrecorder;
        private string _policyholder;
        //private string _paytype;
        //private string _mailtype;
        //private string _ordertype;
        private string _paytypeDsc;
        private string _mailtypeDsc;
        private string _ordertypeDsc;
        private string _statusDsc;
        private string _resultDsc;
        private string _insurantrelation;
        private string _beneficiarierelation;
        private string _insurantrelationDsc;
        private string _beneficiarierelationDsc;

        public string Insurantrelation
        {
            get { return _insurantrelation; }
            set { _insurantrelation = value; }
        }
        public string InsurantrelationDsc
        {
            get { return _insurantrelationDsc; }
            set { _insurantrelationDsc = value; }
        }
        public string Beneficiarierelation
        {
            get { return _beneficiarierelation; }
            set { _beneficiarierelation = value; }
        }
        public string BeneficiarierelationDsc
        {
            get { return _beneficiarierelationDsc; }
            set { _beneficiarierelationDsc = value; }
        }


        public string PaytypeDsc
        {
            get { return _paytypeDsc; }
            set { _paytypeDsc = value; }
        }

        public string MailtypeDsc
        {
            get { return _mailtypeDsc; }
            set { _mailtypeDsc = value; }
        }

        public string OrdertypeDsc
        {
            get { return _ordertypeDsc; }
            set { _ordertypeDsc = value; }
        }


        public string StatusDsc
        {
            get { return _statusDsc; }
            set { _statusDsc = value; }
        }

        private List<OrderDetInfo> _lstorderdetinfo = new List<OrderDetInfo>();
        private List<InsuranceUsrInfo> _lstbeneficiaries = new List<InsuranceUsrInfo>();

        private InsuranceUsrInfo _insurant_usr = new InsuranceUsrInfo();
        private InsuranceUsrInfo _policyholder_usr = new InsuranceUsrInfo();
        /// <summary>
        /// 被保人
        /// </summary>
        public InsuranceUsrInfo Insurant_usr
        {
            get { return _insurant_usr; }
            set { _insurant_usr = value; }
        }
        /// <summary>
        /// 投保人
        /// </summary>
        public InsuranceUsrInfo Policyholder_usr
        {
            get { return _policyholder_usr; }
            set { _policyholder_usr = value; }
        }
        
  
        public string ResultDsc
        {
            get { return _resultDsc; }
            set { _resultDsc = value; }
        }
        /// <summary>
        /// 受益人
        /// </summary>
        public List<InsuranceUsrInfo> Lstbeneficiaries
        {
            get { return _lstbeneficiaries; }
            set { _lstbeneficiaries = value; }
        }


        public List<OrderDetInfo> ORDERDETINFO
        {
            get { return _lstorderdetinfo; }
            set { _lstorderdetinfo = value; }
        }


        private string _dataState;

        public string DataState
        {
            get { return _dataState; }
            set { _dataState = value; }
        }

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
        public string ADDRESSID
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
        /// <summary>
        /// 创建人
        /// </summary>
        public string CRUSR
        {
            set { _crusr = value; }
            get { return _crusr; }
        }
        /// <summary>
        /// 创建工作组
        /// </summary>
        public string GRPID
        {
            set { _grpid = value; }
            get { return _grpid; }
        }
        /// <summary>
        /// 交寄日期
        /// </summary>
        public string SENDDT
        {
            set { _senddt = value; }
            get { return _senddt; }
        }
        /// <summary>
        /// 反馈日期
        /// </summary>
        public string FBDT
        {
            set { _fbdt = value; }
            get { return _fbdt; }
        }
        /// <summary>
        /// 结账日期
        /// </summary>
        public string ACCDT
        {
            set { _accdt = value; }
            get { return _accdt; }
        }
        /// <summary>
        /// 最后修改日期
        /// </summary>
        public string MDDT
        {
            set { _mddt = value; }
            get { return _mddt; }
        }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public string MDUSR
        {
            set { _mdusr = value; }
            get { return _mdusr; }
        }
        /// <summary>
        /// 紧急保单
        /// </summary>
        public string URGENT
        {
            set { _urgent = value; }
            get { return _urgent; }
        }
        /// <summary>
        /// 索权标记
        /// </summary>
        public string CONFIRM
        {
            set { _confirm = value; }
            get { return _confirm; }
        }
        /// <summary>
        /// 保单状态
        /// </summary>
        public string STATUS
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 反馈结果
        /// </summary>
        public string RESULT
        {
            set { _result = value; }
            get { return _result; }
        }
        /// <summary>
        /// 运费
        /// </summary>
        public string MAILPRICE
        {
            set { _mailprice = value; }
            get { return _mailprice; }
        }
        /// <summary>
        /// 订购产品总额
        /// </summary>
        public string PRODPRICE
        {
            set { _prodprice = value; }
            get { return _prodprice; }
        }
        /// <summary>
        /// 最终优惠额
        /// </summary>
        public string DISCOUNT
        {
            set { _discount = value; }
            get { return _discount; }
        }
        /// <summary>
        /// 订单总额
        /// </summary>
        public string TOTALPRICE
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }
        /// <summary>
        /// 需要发票
        /// </summary>
        public string BILL
        {
            set { _bill = value; }
            get { return _bill; }
        }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string NOTE
        {
            set { _note = value; }
            get { return _note; }
        }
        /// <summary>
        /// 信用卡编号
        /// </summary>
        public string CARDID
        {
            set { _cardid = value; }
            get { return _cardid; }
        }
        /// <summary>
        /// 索权号码
        /// </summary>
        public string CARDRIGHTNUM
        {
            set { _cardrightnum = value; }
            get { return _cardrightnum; }
        }
        /// <summary>
        /// 实际收款
        /// </summary>
        public string NOWMONEY
        {
            set { _nowmoney = value; }
            get { return _nowmoney; }
        }
        /// <summary>
        /// 投递费
        /// </summary>
        public string POSTFEE
        {
            set { _postfee = value; }
            get { return _postfee; }
        }
        /// <summary>
        /// 结算费
        /// </summary>
        public string CLEARFEE
        {
            set { _clearfee = value; }
            get { return _clearfee; }
        }
        /// <summary>
        /// 收货人
        /// </summary>
        public string CONSIGNEE
        {
            set { _consignee = value; }
            get { return _consignee; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string CONSIGNPHN
        {
            set { _consignphn = value; }
            get { return _consignphn; }
        }
        /// <summary>
        /// 要求收货时间
        /// </summary>
        public string DEMONDDT
        {
            set { _demonddt = value; }
            get { return _demonddt; }
        }
        /// <summary>
        /// 特殊说明
        /// </summary>
        public string SPECIALDSC
        {
            set { _specialdsc = value; }
            get { return _specialdsc; }
        }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string BILLTITLE
        {
            set { _billtitle = value; }
            get { return _billtitle; }
        }
        /// <summary>
        /// 是否有发票要求
        /// </summary>
        public string BILLDEMONDED
        {
            set { _billdemonded = value; }
            get { return _billdemonded; }
        }
        /// <summary>
        /// 要求内容
        /// </summary>
        public string BILLDEMONDDSC
        {
            set { _billdemonddsc = value; }
            get { return _billdemonddsc; }
        }
        /// <summary>
        /// 信用卡分期数
        /// </summary>
        public string AMORTISATION
        {
            set { _amortisation = value; }
            get { return _amortisation; }
        }
        /// <summary>
        /// 承保单号
        /// </summary>
        public string INSURANCEID
        {
            set { _insuranceid = value; }
            get { return _insuranceid; }
        }
        /// <summary>
        /// 被保人编号
        /// </summary>
        public string INSURANT
        {
            set { _insurant = value; }
            get { return _insurant; }
        }
        /// <summary>
        /// 受益人编号
        /// </summary>
        public string BENEFICIARIES
        {
            set { _beneficiaries = value; }
            get { return _beneficiaries; }
        }
        public string BENEFICIARIES2
        {
            set { _beneficiaries2 = value; }
            get { return _beneficiaries2; }
        }
        public string BENEFICIARIES3
        {
            set { _beneficiaries3 = value; }
            get { return _beneficiaries3; }
        }
       
        /// <summary>
        /// 是否有产品介绍
        /// </summary>
        public string PRODUCTINTRO
        {
            set { _productintro = value; }
            get { return _productintro; }
        }
        /// <summary>
        /// 是否有健康告知
        /// </summary>
        public string HEALTHINTRO
        {
            set { _healthintro = value; }
            get { return _healthintro; }
        }
        /// <summary>
        /// 是否有保单录音监听
        /// </summary>
        public string MONITORRECORDER
        {
            set { _monitorrecorder = value; }
            get { return _monitorrecorder; }
        }
        /// <summary>
        /// 投保人编号
        /// </summary>
        public string POLICYHOLDER
        {
            set { _policyholder = value; }
            get { return _policyholder; }
        }
        #endregion
    }

       
}
