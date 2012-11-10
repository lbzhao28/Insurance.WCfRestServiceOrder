using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Rayda.Data;
using Rayda.Common;
using System.Data;
using Rayda.Common.Special;
using Rayda.Data.Special;

namespace Rayda.Insurance.WcfRestServiceOrder
{
    //处理和保单有关的数据库操作
    public class OrderInfoDB
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public OrderInfo DataRowToOrderModel(DataRow row)
        {
            OrderInfo model = new OrderInfo();
            if (row != null)
            {
                if (row["ORDERID"] != null)
                {
                    model.ORDERID = row["ORDERID"].ToString();
                }
                if (row["CONTACTID"] != null)
                {
                    model.CONTACTID = row["CONTACTID"].ToString();
                }
                if (row["ADDRESSID"] != null)
                {
                    model.ADDRESSID = row["ADDRESSID"].ToString();
                }
                if (row["PAYTYPE"] != null)
                {
                    model.paytype = row["PAYTYPE"].ToString();

                    if (!string.IsNullOrEmpty(model.paytype))
                    {
                        model.PaytypeDsc = getNamesById("CON.ORDER.PAYTYPE", model.paytype);
                    }
                    else
                    {
                        // do nothing
                    }
                }
                if (row["MAILTYPE"] != null)
                {
                    model.mailtype = row["MAILTYPE"].ToString();
                    if (!string.IsNullOrEmpty(model.mailtype))
                    {
                        model.MailtypeDsc = getNamesById("CON.ORDER.MAILTYPE", model.mailtype);
                    }
                    else
                    {
                        //do nothing
                    }
                }
                if (row["ORDERTYPE"] != null)
                {
                    model.ordertype = row["ORDERTYPE"].ToString();
                    if (!string.IsNullOrEmpty(model.ordertype))
                    {
                        model.OrdertypeDsc = getNamesById("CON.ORDER.ORDERTYPE", model.ordertype);
                    }
                    else
                    {
                        // do nothing
                    }
                }
                if (row["CRDT"] != null && row["CRDT"].ToString() != "")
                {
                    model.crdt = row["CRDT"].ToString();
                }
                if (row["CRUSR"] != null)
                {
                    model.CRUSR = row["CRUSR"].ToString();
                }
                if (row["GRPID"] != null)
                {
                    model.GRPID = row["GRPID"].ToString();
                }
                if (row["SENDDT"] != null && row["SENDDT"].ToString() != "")
                {
                    model.SENDDT = row["SENDDT"].ToString();
                }
                if (row["FBDT"] != null && row["FBDT"].ToString() != "")
                {
                    model.FBDT = row["FBDT"].ToString();
                }
                if (row["ACCDT"] != null && row["ACCDT"].ToString() != "")
                {
                    model.ACCDT = row["ACCDT"].ToString();
                }
                if (row["MDDT"] != null && row["MDDT"].ToString() != "")
                {
                    model.MDDT = row["MDDT"].ToString();
                }
                if (row["MDUSR"] != null)
                {
                    model.MDUSR = row["MDUSR"].ToString();
                }
                if (row["URGENT"] != null)
                {
                    model.URGENT = row["URGENT"].ToString();
                }
                if (row["CONFIRM"] != null)
                {
                    model.CONFIRM = row["CONFIRM"].ToString();
                }
                if (row["STATUS"] != null)
                {
                    model.STATUS = row["STATUS"].ToString();
                    if (!string.IsNullOrEmpty(model.STATUS))
                    {
                        model.StatusDsc = getNamesById("CON.ORDER.STATUS", model.STATUS);
                    }
                    else
                    {
                        // do nothing
                    }
                }
                if (row["RESULT"] != null)
                {
                    model.RESULT = row["RESULT"].ToString();
                    if (!string.IsNullOrEmpty(model.RESULT))
                    {
                        model.ResultDsc = getNamesById("CON.ORDER.RESULT", model.RESULT);
                    }
                    else
                    {
                        //do nothing
                    }
                }
                if (row["MAILPRICE"] != null && row["MAILPRICE"].ToString() != "")
                {
                    model.MAILPRICE = row["MAILPRICE"].ToString();
                }
                if (row["PRODPRICE"] != null && row["PRODPRICE"].ToString() != "")
                {
                    model.PRODPRICE = row["PRODPRICE"].ToString();
                }
                if (row["DISCOUNT"] != null && row["DISCOUNT"].ToString() != "")
                {
                    model.DISCOUNT = row["DISCOUNT"].ToString();
                }
                if (row["TOTALPRICE"] != null && row["TOTALPRICE"].ToString() != "")
                {
                    model.TOTALPRICE = row["TOTALPRICE"].ToString();
                }
                if (row["BILL"] != null)
                {
                    model.BILL = row["BILL"].ToString();
                }
                if (row["NOTE"] != null)
                {
                    model.NOTE = row["NOTE"].ToString();
                }
                if (row["CARDID"] != null)
                {
                    model.CARDID = row["CARDID"].ToString();
                }
                if (row["CARDRIGHTNUM"] != null)
                {
                    model.CARDRIGHTNUM = row["CARDRIGHTNUM"].ToString();
                }
                if (row["NOWMONEY"] != null && row["NOWMONEY"].ToString() != "")
                {
                    model.NOWMONEY = row["NOWMONEY"].ToString();
                }
                if (row["POSTFEE"] != null && row["POSTFEE"].ToString() != "")
                {
                    model.POSTFEE = row["POSTFEE"].ToString();
                }
                if (row["CLEARFEE"] != null && row["CLEARFEE"].ToString() != "")
                {
                    model.CLEARFEE = row["CLEARFEE"].ToString();
                }
                if (row["CONSIGNEE"] != null)
                {
                    model.CONSIGNEE = row["CONSIGNEE"].ToString();
                }
                if (row["CONSIGNPHN"] != null)
                {
                    model.CONSIGNPHN = row["CONSIGNPHN"].ToString();
                }
                if (row["DEMONDDT"] != null && row["DEMONDDT"].ToString() != "")
                {
                    model.DEMONDDT = row["DEMONDDT"].ToString();
                }
                if (row["SPECIALDSC"] != null)
                {
                    model.SPECIALDSC = row["SPECIALDSC"].ToString();
                }
                if (row["BILLTITLE"] != null)
                {
                    model.BILLTITLE = row["BILLTITLE"].ToString();
                }
                if (row["BILLDEMONDED"] != null)
                {
                    model.BILLDEMONDED = row["BILLDEMONDED"].ToString();
                }
                if (row["BILLDEMONDDSC"] != null)
                {
                    model.BILLDEMONDDSC = row["BILLDEMONDDSC"].ToString();
                }
                if (row["AMORTISATION"] != null)
                {
                    model.AMORTISATION = row["AMORTISATION"].ToString();
                }
                if (row["INSURANCEID"] != null)
                {
                    model.INSURANCEID = row["INSURANCEID"].ToString();
                }
                if (row["INSURANT"] != null)
                {
                    model.INSURANT = row["INSURANT"].ToString();
                }
                if (row["BENEFICIARIES"] != null)
                {
                    model.BENEFICIARIES = row["BENEFICIARIES"].ToString();
                }
                if (row["BENEFICIARIES2"] != null)
                {
                    model.BENEFICIARIES2 = row["BENEFICIARIES2"].ToString();
                }
                if (row["BENEFICIARIES3"] != null)
                {
                    model.BENEFICIARIES3 = row["BENEFICIARIES3"].ToString();
                }
                if (row["PRODUCTINTRO"] != null)
                {
                    model.PRODUCTINTRO = row["PRODUCTINTRO"].ToString();
                }
                if (row["HEALTHINTRO"] != null)
                {
                    model.HEALTHINTRO = row["HEALTHINTRO"].ToString();
                }
                if (row["MONITORRECORDER"] != null)
                {
                    model.MONITORRECORDER = row["MONITORRECORDER"].ToString();
                }
                if (row["POLICYHOLDER"] != null)
                {
                    model.POLICYHOLDER = row["POLICYHOLDER"].ToString();
                }
                if (row["Insurantrelation"] != null)
                {
                    model.Insurantrelation = row["Insurantrelation"].ToString();
                    if (!string.IsNullOrEmpty(model.Insurantrelation))
                    {
                        model.InsurantrelationDsc = getNamesById("CON.ORDER.HIST.INSURANCE", model.Insurantrelation);
                    }
                    else
                    {
                        //do nothing
                    }
                }
                if (row["Beneficiarierelation"] != null)
                {
                    model.Beneficiarierelation = row["Beneficiarierelation"].ToString();
                    if (!string.IsNullOrEmpty(model.Insurantrelation))
                    {
                        model.BeneficiarierelationDsc = getNamesById("CON.ORDER.HIST.BENEFICIARIES", model.Beneficiarierelation);
                    }
                    else
                    {
                        //do nothing
                    }
                }
            }
            return model;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public OrderDetInfo DataRowToOrderDetModel(DataRow row)
        {
            OrderDetInfo model = new OrderDetInfo();
            if (row != null)
            {
                if (row["ORDERDETID"] != null)
                {
                    model.ORDERDETID = row["ORDERDETID"].ToString();
                }
                if (row["ORDERID"] != null)
                {
                    model.ORDERID = row["ORDERID"].ToString();
                }
                if (row["CONTACTID"] != null)
                {
                    model.CONTACTID = row["CONTACTID"].ToString();
                }
                if (row["PRODUCTTYPE1"] != null)
                {
                    model.PRODUCTTYPE1 = row["PRODUCTTYPE1"].ToString();
                }
                if (row["SOLDWITH"] != null)
                {
                    model.SOLDWITH = row["SOLDWITH"].ToString();
                }
                if (row["STATUS"] != null)
                {
                    model.STATUS = row["STATUS"].ToString();
                }
                if (row["RECKONING"] != null)
                {
                    model.RECKONING = row["RECKONING"].ToString();
                }
                if (row["RECKONINGDT"] != null && row["RECKONINGDT"].ToString() != "")
                {
                    model.RECKONINGDT = row["RECKONINGDT"].ToString();
                }
                if (row["FBDT"] != null && row["FBDT"].ToString() != "")
                {
                    model.FBDT = row["FBDT"].ToString();
                }
                if (row["UPRICE"] != null && row["UPRICE"].ToString() != "")
                {
                    model.UPRICE = row["UPRICE"].ToString();
                }
                if (row["PRODNUM"] != null && row["PRODNUM"].ToString() != "")
                {
                    model.PRODNUM = row["PRODNUM"].ToString();
                }
                if (row["FREIGHT"] != null && row["FREIGHT"].ToString() != "")
                {
                    model.FREIGHT = row["FREIGHT"].ToString();
                }
                if (row["PAYMENT"] != null && row["PAYMENT"].ToString() != "")
                {
                    model.PAYMENT = row["PAYMENT"].ToString();
                }
                if (row["POSTFEE"] != null && row["POSTFEE"].ToString() != "")
                {
                    model.POSTFEE = row["POSTFEE"].ToString();
                }
                if (row["CLEARFEE"] != null && row["CLEARFEE"].ToString() != "")
                {
                    model.CLEARFEE = row["CLEARFEE"].ToString();
                }
                if (row["CRDT"] != null && row["CRDT"].ToString() != "")
                {
                    model.CRDT = row["CRDT"].ToString();
                }
                if (row["BREASON"] != null)
                {
                    model.BREASON = row["BREASON"].ToString();
                }
                if (row["FEEDBACK"] != null)
                {
                    model.FEEDBACK = row["FEEDBACK"].ToString();
                }
                if (row["GOODSBACK"] != null)
                {
                    model.GOODSBACK = row["GOODSBACK"].ToString();
                }
                if (row["BACKDT"] != null && row["BACKDT"].ToString() != "")
                {
                    model.BACKDT = row["BACKDT"].ToString();
                }
                if (row["BACKMONEY"] != null && row["BACKMONEY"].ToString() != "")
                {
                    model.BACKMONEY = row["BACKMONEY"].ToString();
                }
                if (row["CARDRIGHTNUM"] != null)
                {
                    model.CARDRIGHTNUM = row["CARDRIGHTNUM"].ToString();
                }
                if (row["ACCOUNTINGCOST"] != null && row["ACCOUNTINGCOST"].ToString() != "")
                {
                    model.ACCOUNTINGCOST = row["ACCOUNTINGCOST"].ToString();
                }
                if (row["PRODBANKID"] != null)
                {
                    model.PRODBANKID = row["PRODBANKID"].ToString();
                }
                if (row["ISREFUND"] != null)
                {
                    model.ISREFUND = row["ISREFUND"].ToString();
                }
                if (row["REFUNDDT"] != null && row["REFUNDDT"].ToString() != "")
                {
                    model.REFUNDDT = row["REFUNDDT"].ToString();
                }
                if (row["PRODDETID"] != null)
                {
                    model.PRODDETID = row["PRODDETID"].ToString();
                }
                
            }
            return model;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public InsuranceUsrInfo DataRowToInsuranceUsrInfoModel(DataRow row)
        {
            InsuranceUsrInfo model = new InsuranceUsrInfo();
            if (row != null)
            {
                if (row["NAME"] != null)
                {
                    model.NAME = row["NAME"].ToString();
                }
                if (row["SEX"] != null)
                {
                    model.SEX = row["SEX"].ToString();
                }
                if (row["IDCARDTYPE"] != null)
                {
                    model.IDCARDTYPE = row["IDCARDTYPE"].ToString();
                }
                if (row["IDCARDNO"] != null)
                {
                    model.IDCARDNO = row["IDCARDNO"].ToString();
                }
                if (row["IDPERIOD"] != null)
                {
                    model.IDPERIOD = row["IDPERIOD"].ToString();
                }
                if (row["DSC"] != null)
                {
                    model.DSC = row["DSC"].ToString();
                }
                if (row["CRDT"] != null && row["CRDT"].ToString() != "")
                {
                    model.CRDT = row["CRDT"].ToString();
                }
                if (row["CRUSR"] != null)
                {
                    model.CRUSR = row["CRUSR"].ToString();
                }
                if (row["MDDT"] != null && row["MDDT"].ToString() != "")
                {
                    model.MDDT = row["MDDT"].ToString();
                }
                if (row["MDUSR"] != null)
                {
                    model.MDUSR = row["MDUSR"].ToString();
                }
                if (row["PROFESSION"] != null)
                {
                    model.PROFESSION = row["PROFESSION"].ToString();
                }
                if (row["POST"] != null)
                {
                    model.POST = row["POST"].ToString();
                }
                if (row["INSURANCE_USRID"] != null)
                {
                    model.INSURANCE_USRID = row["INSURANCE_USRID"].ToString();
                }
                if (row["Proportion"] != null)
                {
                    model.Proportion = row["Proportion"].ToString();
                }
            }
            return model;
        }

        #region 处理OrderHist表
        public void addNewOrderHistData(SqlLib lib, IDb db, object obj, ref DataTable outDt)
        {
            string sql = "";
            string localID = "";

            bool ret = false;

            try
            {
                OrderInfo li = new OrderInfo();

                ret = DataHandle.CompareObjectType(obj, li);

                if (ret)
                {
                    //get the correct list.
                    li = (OrderInfo)obj;
                }
                else
                {
                    return;
                }

                if (outDt == null)
                {
                    throw new NullReferenceException("outDt is null");
                }


                DataTable localDt = new DataTable();

                //只取一条记录，以便得到表结构，如果一条都没有，那么会有什么结果？能够取出表结构。
                sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderHistStructInfo");
                localDt = db.GetTable(sql);

                //新增加的记录，在oracle中需要取到sequence编号
                sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetNewOrderHistId");
                DataTable dt = new DataTable();
                dt = db.GetTable(sql);
                if (dt.Rows.Count > 0)
                {
                    localID = dt.Rows[0][0].ToString();
                    dt.Reset();
                }

                if (string.IsNullOrEmpty(localID))
                {
                    return;
                }

                DataRow dr = localDt.NewRow();

                dr["orderid"] = DataHandle.EmptyString2DBNull(localID);
                dr["contactid"] = DataHandle.EmptyString2DBNull(li.CONTACTID);
                dr["addressid"] = DataHandle.EmptyString2DBNull(li.ADDRESSID);

                dr["ACCDT"] = DataHandle.EmptyString2DBNull(li.ACCDT);
                dr["AMORTISATION"] = DataHandle.EmptyString2DBNull(li.AMORTISATION);
                dr["BENEFICIARIES"] = DataHandle.EmptyString2DBNull(li.BENEFICIARIES);
                dr["BILL"] = DataHandle.EmptyString2DBNull(li.BILL);
                dr["BILLDEMONDDSC"] = DataHandle.EmptyString2DBNull(li.BILLDEMONDDSC);
                dr["BILLDEMONDED"] = DataHandle.EmptyString2DBNull(li.BILLDEMONDED);
                dr["BILLTITLE"] = DataHandle.EmptyString2DBNull(li.BILLTITLE);
                dr["CARDID"] = DataHandle.EmptyString2DBNull(li.CARDID);
                dr["CARDRIGHTNUM"] = DataHandle.EmptyString2DBNull(li.CARDRIGHTNUM);
                dr["CLEARFEE"] = DataHandle.EmptyString2DBNull(li.CLEARFEE);

                dr["CONFIRM"] = DataHandle.EmptyString2DBNull(li.CONFIRM);
                dr["CONSIGNEE"] = DataHandle.EmptyString2DBNull(li.CONSIGNEE);
                dr["CONSIGNPHN"] = DataHandle.EmptyString2DBNull(li.CONSIGNPHN);
                dr["CRUSR"] = DataHandle.EmptyString2DBNull(li.CRUSR);
                dr["DEMONDDT"] = DataHandle.EmptyString2DBNull(li.DEMONDDT);
                dr["DISCOUNT"] = DataHandle.EmptyString2DBNull(li.DISCOUNT);
                dr["FBDT"] = DataHandle.EmptyString2DBNull(li.FBDT);
                dr["GRPID"] = DataHandle.EmptyString2DBNull(li.GRPID);
                dr["HEALTHINTRO"] = DataHandle.EmptyString2DBNull(li.HEALTHINTRO);
                dr["INSURANCEID"] = DataHandle.EmptyString2DBNull(li.INSURANCEID);

                dr["INSURANT"] = DataHandle.EmptyString2DBNull(li.INSURANT);
                dr["MAILPRICE"] = DataHandle.EmptyString2DBNull(li.MAILPRICE);
                dr["MDDT"] = DataHandle.EmptyString2DBNull(li.MDDT);
                dr["MDUSR"] = DataHandle.EmptyString2DBNull(li.MDUSR);
                dr["MONITORRECORDER"] = DataHandle.EmptyString2DBNull(li.MONITORRECORDER);
                dr["NOTE"] = DataHandle.EmptyString2DBNull(li.NOTE);
                dr["NOWMONEY"] = DataHandle.EmptyString2DBNull(li.NOWMONEY);
                dr["POLICYHOLDER"] = DataHandle.EmptyString2DBNull(li.POLICYHOLDER);
                dr["POSTFEE"] = DataHandle.EmptyString2DBNull(li.POSTFEE);
                dr["PRODPRICE"] = DataHandle.EmptyString2DBNull(li.PRODPRICE);

                dr["PRODUCTINTRO"] = DataHandle.EmptyString2DBNull(li.PRODUCTINTRO);
                dr["RESULT"] = DataHandle.EmptyString2DBNull(li.RESULT);
                dr["SENDDT"] = DataHandle.EmptyString2DBNull(li.SENDDT);
                dr["SPECIALDSC"] = DataHandle.EmptyString2DBNull(li.SPECIALDSC);
                dr["STATUS"] = DataHandle.EmptyString2DBNull(li.STATUS);
                dr["TOTALPRICE"] = DataHandle.EmptyString2DBNull(li.TOTALPRICE);
                dr["URGENT"] = DataHandle.EmptyString2DBNull(li.URGENT);
                dr["ordertype"] = DataHandle.EmptyString2DBNull(li.ordertype);
                dr["paytype"] = DataHandle.EmptyString2DBNull(li.paytype);
                dr["mailtype"] = DataHandle.EmptyString2DBNull(li.mailtype);
                dr["CRDT"] = DataHandle.EmptyString2DBNull(li.crdt);

                localDt.Rows.Add(dr);

                outDt.Merge(localDt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderHistData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderHistData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderHistData" + ex.Message);
                throw;
            }
        }

        public void updateOrderHistData(SqlLib lib, IDb db, object obj, ref DataTable outOrderHistDt)
        {
            string sql = "";
            bool ret = true;

            try
            {

                OrderInfo li = new OrderInfo();

                ret = DataHandle.CompareObjectType(obj, li);
                if (ret)
                {
                    //get the correct list.
                    li = (OrderInfo)obj;
                }
                else
                {
                    return;
                }

                if (outOrderHistDt == null)
                {
                    throw new NullReferenceException("outOrderHistDt is null");
                }


                DataTable localDt = new DataTable();
                //每次更新一条数据
                sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderInfo");
                if (!string.IsNullOrEmpty(li.ORDERID))
                {
                    sql = sql + " and orderid= '" + li.ORDERID + "'";
                    localDt = db.GetTable(sql);
                    if (localDt.Rows.Count == 1)
                    {
                        DataRow dr = localDt.Rows[0];
                        dr.BeginEdit();
                        dr["orderid"] = DataHandle.EmptyString2DBNull(li.ORDERID);
                        dr["contactid"] = DataHandle.EmptyString2DBNull(li.CONTACTID);
                        dr["addressid"] = DataHandle.EmptyString2DBNull(li.ADDRESSID);

                        dr["ACCDT"] = DataHandle.EmptyString2DBNull(li.ACCDT);
                        dr["AMORTISATION"] = DataHandle.EmptyString2DBNull(li.AMORTISATION);
                        dr["BENEFICIARIES"] = DataHandle.EmptyString2DBNull(li.BENEFICIARIES);
                        dr["BILL"] = DataHandle.EmptyString2DBNull(li.BILL);
                        dr["BILLDEMONDDSC"] = DataHandle.EmptyString2DBNull(li.BILLDEMONDDSC);
                        dr["BILLDEMONDED"] = DataHandle.EmptyString2DBNull(li.BILLDEMONDED);
                        dr["BILLTITLE"] = DataHandle.EmptyString2DBNull(li.BILLTITLE);
                        dr["CARDID"] = DataHandle.EmptyString2DBNull(li.CARDID);
                        dr["CARDRIGHTNUM"] = DataHandle.EmptyString2DBNull(li.CARDRIGHTNUM);
                        dr["CLEARFEE"] = DataHandle.EmptyString2DBNull(li.CLEARFEE);

                        dr["CONFIRM"] = DataHandle.EmptyString2DBNull(li.CONFIRM);
                        dr["CONSIGNEE"] = DataHandle.EmptyString2DBNull(li.CONSIGNEE);
                        dr["CONSIGNPHN"] = DataHandle.EmptyString2DBNull(li.CONSIGNPHN);
                        dr["CRUSR"] = DataHandle.EmptyString2DBNull(li.CRUSR);
                        dr["DEMONDDT"] = DataHandle.EmptyString2DBNull(li.DEMONDDT);
                        dr["DISCOUNT"] = DataHandle.EmptyString2DBNull(li.DISCOUNT);
                        dr["FBDT"] = DataHandle.EmptyString2DBNull(li.FBDT);
                        dr["GRPID"] = DataHandle.EmptyString2DBNull(li.GRPID);
                        dr["HEALTHINTRO"] = DataHandle.EmptyString2DBNull(li.HEALTHINTRO);
                        dr["INSURANCEID"] = DataHandle.EmptyString2DBNull(li.INSURANCEID);

                        dr["INSURANT"] = DataHandle.EmptyString2DBNull(li.INSURANT);
                        dr["MAILPRICE"] = DataHandle.EmptyString2DBNull(li.MAILPRICE);
                        dr["MDDT"] = DataHandle.EmptyString2DBNull(li.MDDT);
                        dr["MDUSR"] = DataHandle.EmptyString2DBNull(li.MDUSR);
                        dr["MONITORRECORDER"] = DataHandle.EmptyString2DBNull(li.MONITORRECORDER);
                        dr["NOTE"] = DataHandle.EmptyString2DBNull(li.NOTE);
                        dr["NOWMONEY"] = DataHandle.EmptyString2DBNull(li.NOWMONEY);
                        dr["POLICYHOLDER"] = DataHandle.EmptyString2DBNull(li.POLICYHOLDER);
                        dr["POSTFEE"] = DataHandle.EmptyString2DBNull(li.POSTFEE);
                        dr["PRODPRICE"] = DataHandle.EmptyString2DBNull(li.PRODPRICE);

                        dr["PRODUCTINTRO"] = DataHandle.EmptyString2DBNull(li.PRODUCTINTRO);
                        dr["RESULT"] = DataHandle.EmptyString2DBNull(li.RESULT);
                        dr["SENDDT"] = DataHandle.EmptyString2DBNull(li.SENDDT);
                        dr["SPECIALDSC"] = DataHandle.EmptyString2DBNull(li.SPECIALDSC);
                        dr["STATUS"] = DataHandle.EmptyString2DBNull(li.STATUS);
                        dr["TOTALPRICE"] = DataHandle.EmptyString2DBNull(li.TOTALPRICE);
                        dr["URGENT"] = DataHandle.EmptyString2DBNull(li.URGENT);
                        dr["ordertype"] = DataHandle.EmptyString2DBNull(li.ordertype);
                        dr["paytype"] = DataHandle.EmptyString2DBNull(li.paytype);
                        dr["mailtype"] = DataHandle.EmptyString2DBNull(li.mailtype);
                        dr["CRDT"] = DataHandle.EmptyString2DBNull(li.crdt);
                        dr.EndEdit();
                        outOrderHistDt.Merge(localDt, true);
                    }
                    else
                    {
                        //do nothing
                    }
                }
                else
                {
                    //do nothing
                }

                //ScmProviderData li = new ScmProviderData();

                //ret = DataHandle.CompareObjectType(obj, li);

                //if (ret)
                //{
                //    //get the correct list.
                //    li = (ScmProviderData)obj;
                //}
                //else
                //{
                //    return;
                //}

                //if (outDtPlace == null)
                //{
                //    throw new NullReferenceException("outDtPlace is null");
                //}

                //DataTable localDt = new DataTable();

                ////每次更新一条。
                //sql = lib.GetSql("SqlPlace/PlaceProdInfo", "GetPlaceProdRelationInfo");

                //if (!string.IsNullOrEmpty(li.PROVIDERID))
                //{
                //    sql = sql + " and PROVIDERID= '" + li.PROVIDERID + "'";
                //    localDt = db.GetTable(sql);

                //    //have one record
                //    if (localDt.Rows.Count == 1)
                //    {
                //        // only one record.
                //        DataRow dr = localDt.Rows[0];

                //        dr.BeginEdit();
                //        dr["PROVIDERID"] = DataHandle.EmptyString2DBNull(li.PROVIDERID);

                //        dr["CRDT"] = DataHandle.EmptyString2DBNull(li.CRDT);
                //        dr["CRUSR"] = DataHandle.EmptyString2DBNull(li.CRUSR);
                //        dr["DSC"] = DataHandle.EmptyString2DBNull(li.DSC.ToString());


                //        dr["MDDT"] = DataHandle.EmptyString2DBNull(li.MDDT);
                //        dr["MDUSR"] = DataHandle.EmptyString2DBNull(li.MDUSR);
                //        dr["NAME"] = DataHandle.EmptyString2DBNull(li.NAME.ToString());
                //        dr.EndEdit();

                //        outDtPlace.Merge(localDt, true);
                //    }
                //    else
                //    {
                //        //do nothing.
                //    }
                //}
                //else
                //{
                //    // do nothing
                //}


            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistData" + ex.Message);
                throw;
            }
        }

        public void deleteOrderHistData(SqlLib lib, IDb db, object obj, ref DataTable outDt)
        {
            string sql = "";
            bool ret = true;

            try
            {
                OrderInfo orderInfo = new OrderInfo();
                ret = DataHandle.CompareObjectType(obj, orderInfo);

                if (ret)
                {
                    //get the correct list.
                    orderInfo = (OrderInfo)obj;
                }
                else
                {
                    return;
                }

                if (outDt == null)
                {
                    throw new NullReferenceException("outDt is null");
                }

                DataTable localDt = new DataTable();

                //每次删除一条或者多条.
                sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderInfo");

                if (!string.IsNullOrEmpty(orderInfo.ORDERID))
                {
                    sql = sql + " and ORDERID= '" + orderInfo.ORDERID + "'";
                }
                else
                {
                    //不允许都为空的情况，那样就全部删除了。抛出异常。
                    throw new NullReferenceException("产品详细关联号不可以为空!");
                }

                if (!string.IsNullOrEmpty(sql))
                {
                    localDt = db.GetTable(sql);
                }

                for (int i = 0; i < localDt.Rows.Count; i++)
                {
                    DataRow dr = localDt.Rows[i];

                    dr.Delete();
                }
                //ScmProviderData li = new ScmProviderData();

                //ret = DataHandle.CompareObjectType(obj, li);

                //if (ret)
                //{
                //    //get the correct list.
                //    li = (ScmProviderData)obj;
                //}
                //else
                //{
                //    return;
                //}

                //if (outDtPlace == null)
                //{
                //    throw new NullReferenceException("outDtPlace is null");
                //}

                //DataTable localDt = new DataTable();

                ////每次删除一条或者多条.
                //sql = lib.GetSql("SqlPlace/PlaceProdInfo", "GetPlaceProdRelationInfo");

                //if (!string.IsNullOrEmpty(li.PROVIDERID))
                //{
                //    sql = sql + " and PROVIDERID= '" + li.PROVIDERID + "'";
                //}
                //else
                //{
                //    //不允许都为空的情况，那样就全部删除了。抛出异常。
                //    throw new NullReferenceException("场所号和场所产品关联号不可以同时为空!");
                //}

                //if (!string.IsNullOrEmpty(sql))
                //{
                //    localDt = db.GetTable(sql);
                //}


                //for (int i = 0; i < localDt.Rows.Count; i++)
                //{
                //    DataRow dr = localDt.Rows[i];

                //    dr.Delete();
                //}

                //outDtPlace.Merge(localDt, true);

                outDt.Merge(localDt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
                throw;
            }
        }

        public void deleteOrderHistAllDetData(SqlLib lib, IDb db, object obj, ref DataTable outOrderDetDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                OrderInfo localOrderinfo = new OrderInfo();
                ret = DataHandle.CompareObjectType(obj, localOrderinfo);
                if (ret)
                {
                    localOrderinfo = (OrderInfo)obj;
                }
                else
                {
                    return;
                }
                if (outOrderDetDt == null)
                {
                    throw new NullReferenceException("outOrderDetInfo is null");
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetInfo");

                if (!string.IsNullOrEmpty(localOrderinfo.ORDERID))
                {
                    sql += " and ORDERID='" + localOrderinfo.ORDERID + "'";
                }
                else
                {
                    throw new NullReferenceException("保单信息不能为空");
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    localdt = db.GetTable(sql);
                }

                for (int i = 0; i < localdt.Rows.Count; i++)
                {
                    DataRow dr = localdt.Rows[i];
                    dr.Delete();
                }

                outOrderDetDt.Merge(localdt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteOrderHistAllDetData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteOrderHistAllDetData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteOrderHistAllDetData" + ex.Message);
                throw;
            }


        }
        public void deleteOrderHistAllInsurantData(SqlLib lib, IDb db, object obj, ref DataTable outInsuranceUsrDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                OrderInfo localOrderInfo = new OrderInfo();
                ret = DataHandle.CompareObjectType(obj, localOrderInfo);
                if (ret)
                {
                    localOrderInfo = (OrderInfo)obj;
                }
                else
                {
                    return;
                }
                if (outInsuranceUsrDt == null)
                {
                    throw new NullReferenceException("outInsuranceUsrDt is null");
                }

                string InsuranceUsrID = "";

                sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderHistInfo");
                sql = sql + string.Format(" and orderid = '{0}'", localOrderInfo.ORDERID);


                /// 保险人信息
                InsuranceUsrInfo localInsuranceUsrInfo = new InsuranceUsrInfo();

                CTrace.WriteLine(CTrace.TraceLevel.Info, "insurance.outOrderInfo sql={0}.", sql);
                DataTable dt = db.GetTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow locaorderDr = dt.Rows[0];

                    localOrderInfo = DataRowToOrderModel(locaorderDr);

                    if (localOrderInfo.BENEFICIARIES != null && !string.IsNullOrEmpty(localOrderInfo.BENEFICIARIES))
                    {
                        InsuranceUsrID = "'" + localOrderInfo.BENEFICIARIES.ToString() + "',";
                    }
                    if (localOrderInfo.BENEFICIARIES2 !=null && !string.IsNullOrEmpty(localOrderInfo.BENEFICIARIES2))
                    {
                        InsuranceUsrID =  InsuranceUsrID +"'" + localOrderInfo.BENEFICIARIES2.ToString() + "',";
                    }
                    if (localOrderInfo.BENEFICIARIES3 != null && !string.IsNullOrEmpty(localOrderInfo.BENEFICIARIES3))
                    {
                        InsuranceUsrID = InsuranceUsrID + "'" + localOrderInfo.BENEFICIARIES3.ToString() + "',";
                    }
                    if (localOrderInfo.INSURANT != null && !string.IsNullOrEmpty(localOrderInfo.INSURANT))
                    {
                        InsuranceUsrID = InsuranceUsrID + "'" + localOrderInfo.INSURANT.ToString() + "',";
                    }
                    if (localOrderInfo.POLICYHOLDER !=null && !string.IsNullOrEmpty(localOrderInfo.POLICYHOLDER))
                    {
                        InsuranceUsrID = InsuranceUsrID + "'" + localOrderInfo.POLICYHOLDER.ToString() + "',";
                    }
                }


                if (string.IsNullOrEmpty(InsuranceUsrID))
                {
                    return;
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrInfo");


                if (!string.IsNullOrEmpty(InsuranceUsrID))
                {
                    InsuranceUsrID = InsuranceUsrID.Substring(0, InsuranceUsrID.Length - 1);
                    sql += " and INSURANCE_USRID in (" + InsuranceUsrID + " )";
                }
                else
                {
                    throw new NullReferenceException("保单详细信息不能为空");
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    localdt = db.GetTable(sql);
                }

                for (int i = 0; i < localdt.Rows.Count; i++)
                {
                    DataRow dr = localdt.Rows[i];
                    dr.Delete();
                }
                outInsuranceUsrDt.Merge(localdt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
                throw;
            }
        }



        public bool updateOrderHistDataTable(SqlLib lib, IDb db, DataTable inDt)
        {
            bool ret = false;


            try
            {

                if (inDt.Rows.Count == 0)
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }

                //更新OrderHist表
                //循环更新所有的。
                for (int i = 0; i < inDt.Rows.Count; i++)
                {
                    DataRow dr = inDt.Rows[i];

                    string localOrderid = "";

                    if (dr.RowState == DataRowState.Unchanged)
                    {
                        //do nothing.jump out the loop.
                        continue;
                    }
                    else
                        if (dr.RowState == DataRowState.Deleted)
                        {
                            //do nothing.
                        }
                        else
                        {
                            localOrderid = dr["orderid"].ToString();
                        }

                    string sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderHistStructInfo");
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updateOrderHistDataTable sql={0}.", sql);

                    ret = db.Save(inDt, sql);
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updateOrderHistDataTable result={0}.", ret.ToString());
                    if (ret)
                    {
                        //return true.
                    }
                    else
                    {
                        db.Rollback();
                        localOrderid = "";
                        CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistDataTable" + db.Error.Message);
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistDataTable" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistDataTable" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderHistDataTable" + ex.Message);
                throw;
            }

            return ret;

        }

        public List<OrderInfo> outOrderInfo(string queryString)
        {
            List<OrderInfo> localOrderInfo = new List<OrderInfo>();

            if (string.IsNullOrEmpty(queryString))
            {
                return localOrderInfo;
            }
            try
            {

                CTrace.WriteLine(CTrace.TraceLevel.Info, "Insurance outProductDetInfoSearch Search.");

                SqlLib lib = SpecialSqlLib.CreateLib();
                IDb db = DataManager.CreateDb();
                if (db != null)
                {
                    string sql = "";
                    string sqlInsuranceUsrInfo = "";

                    DataTable localInsuranceUsrInfodt = new DataTable();
                    /// 投保人 受益人 被保人 的sql
                    sqlInsuranceUsrInfo = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrInfo");

                    sql = lib.GetSql("SqlOrderInfo/OrderInfo", "GetOrderHistInfo");
                    sql = sql + queryString;


                    /// 保险人信息
                    InsuranceUsrInfo localInsuranceUsrInfo = new InsuranceUsrInfo();

                    CTrace.WriteLine(CTrace.TraceLevel.Info, "insurance.outOrderInfo sql={0}.", sql);
                    DataTable dt = db.GetTable(sql);

                    OrderInfo model = new OrderInfo();

                    foreach (DataRow row in dt.Rows)
                    {


                        if (row != null)
                        {
                            model = DataRowToOrderModel(row);
                            OrderDetInfo localOrderDetInfo = new OrderDetInfo();

                            DataTable dtOrderDetInfo = new DataTable();
                            sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetInfo");
                            sql = string.Format(sql + " and orderid = '{0}' ", model.ORDERID);
                            dtOrderDetInfo = db.GetTable(sql);

                            foreach (DataRow rowDet in dtOrderDetInfo.Rows)
                            {
                                localOrderDetInfo = DataRowToOrderDetModel(rowDet);
                                model.ORDERDETINFO.Add(localOrderDetInfo);
                            }


                            /// 增加被保人信息

                            string sqlLSTINSURANT = string.Format(sqlInsuranceUsrInfo + " and insurance_usrid = '{0}' ", model.INSURANT);
                            localInsuranceUsrInfodt = db.GetTable(sqlLSTINSURANT);


                            if (localInsuranceUsrInfodt != null && localInsuranceUsrInfodt.Rows.Count > 0)
                            {
                                DataRow rowDet = localInsuranceUsrInfodt.Rows[0];
                                localInsuranceUsrInfo = DataRowToInsuranceUsrInfoModel(rowDet);
                                model.Insurant_usr = localInsuranceUsrInfo;
                            }



                            /// 收益人信息
                            InsuranceUsrInfo localBENEFICIARIES = new InsuranceUsrInfo();


                            string strBENEFICIARIES = "";
                            if (!string.IsNullOrEmpty(model.BENEFICIARIES))
                            {
                                strBENEFICIARIES = "'" + model.BENEFICIARIES + "'";
                            }
                            if (!string.IsNullOrEmpty(model.BENEFICIARIES2))
                            {
                                strBENEFICIARIES += ",'" + model.BENEFICIARIES2 + "'";
                            }
                            if (!string.IsNullOrEmpty(model.BENEFICIARIES3))
                            {
                                strBENEFICIARIES += ",'" + model.BENEFICIARIES3 + "'";
                            }
                            string sqlLstbeneficiaries = string.Format(sqlInsuranceUsrInfo + " and insurance_usrid in ({0}) ", strBENEFICIARIES);
                            localInsuranceUsrInfodt = db.GetTable(sqlLstbeneficiaries);

                            foreach (DataRow rowDet in localInsuranceUsrInfodt.Rows)
                            {
                                localInsuranceUsrInfo = DataRowToInsuranceUsrInfoModel(rowDet);
                                if (localInsuranceUsrInfo != null)
                                    model.Lstbeneficiaries.Add(localInsuranceUsrInfo);
                            }



                            /// 投保人信息
                            InsuranceUsrInfo localPOLICYHOLDER = new InsuranceUsrInfo();
                            string sqlLstpolicyholder = string.Format(sqlInsuranceUsrInfo + " and insurance_usrid = '{0}' ", model.POLICYHOLDER);
                            localInsuranceUsrInfodt = db.GetTable(sqlLstpolicyholder);


                            if (localInsuranceUsrInfodt != null && localInsuranceUsrInfodt.Rows.Count > 0)
                            {
                                DataRow rowDet = localInsuranceUsrInfodt.Rows[0];
                                localInsuranceUsrInfo = DataRowToInsuranceUsrInfoModel(rowDet);
                                model.Policyholder_usr = localInsuranceUsrInfo;
                            }


                            localOrderInfo.Add(model);

                        }
                    }

                    CTrace.WriteLine(CTrace.TraceLevel.Info, "insurance.outProductDetInfoSearch GetTable {0}.", sql);
                }


            }
            catch (FormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outScmProviderInfoSearch Search" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (TimeoutException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in outProductDetInfoSearch Search" + ex.Message);
                throw;
            }

            return localOrderInfo;
        }

        /// <summary>
        /// 根据 tid 和 id 查询names 表获取names 的详细信息
        /// </summary>
        /// <param name="tid"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getNamesById(string tid, string id)
        {
            string dsc = "";
            SqlLib lib = SpecialSqlLib.CreateLib();
            IDb db = DataManager.CreateDb();
            if (db != null)
            {

                string sqlNamesInfo = "";

                DataTable localInsuranceUsrInfodt = new DataTable();
                /// 投保人 受益人 被保人 的sql
                sqlNamesInfo = lib.GetSql("SqlNamesInfo/NamesInfo", "GetNamesInfo");
                sqlNamesInfo = string.Format(sqlNamesInfo, tid, id);


                CTrace.WriteLine(CTrace.TraceLevel.Info, "insurance.outOrderInfo sql={0}", sqlNamesInfo);
                DataTable dt = db.GetTable(sqlNamesInfo);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dsc = dt.Rows[0][0].ToString();
                }

            }
            return dsc;
        }

        public void addNewOrderDetData(SqlLib lib, IDb db, object obj, ref DataTable outOrderDetDt)
        {
            string sql = "";
            string localID = "";
            bool ret = false;
            try
            {
                OrderDetInfo li = new OrderDetInfo();
                ret = DataHandle.CompareObjectType(obj, li);
                if (ret)
                {
                    li = (OrderDetInfo)obj;
                }
                else
                {
                    return;
                }
                if (outOrderDetDt == null)
                {
                    throw new NullReferenceException("outOrderDetDt is null");
                }
                DataTable localDt = new DataTable();
                //只取一条记录，以便得到表结构，如果一条都没有，那么会有什么结果？能够取出表结构。
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetStructInfo");
                localDt = db.GetTable(sql);

                //新增加的记录，在oracle中需要取到sequence编号
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetNewOrderDetId");
                DataTable dt = new DataTable();
                dt = db.GetTable(sql);
                if (dt.Rows.Count > 0)
                {
                    localID = dt.Rows[0][0].ToString();
                    dt.Reset();
                }
                if (string.IsNullOrEmpty(localID))
                {
                    return;
                }
                DataRow dr = localDt.NewRow();
                dr["ORDERDETID"] = DataHandle.EmptyString2DBNull(localID);
                dr["ACCOUNTINGCOST"] = DataHandle.EmptyString2DBNull(li.ACCOUNTINGCOST);
                dr["BACKDT"] = DataHandle.EmptyString2DBNull(li.BACKDT);
                dr["BACKMONEY"] = DataHandle.EmptyString2DBNull(li.BACKMONEY);
                dr["BREASON"] = DataHandle.EmptyString2DBNull(li.BREASON);
                dr["CARDRIGHTNUM"] = DataHandle.EmptyString2DBNull(li.CARDRIGHTNUM);
                dr["CLEARFEE"] = DataHandle.EmptyString2DBNull(li.CLEARFEE);
                dr["CONTACTID"] = DataHandle.EmptyString2DBNull(li.CONTACTID);
                dr["CRDT"] = DataHandle.EmptyString2DBNull(li.CRDT);
                dr["FBDT"] = DataHandle.EmptyString2DBNull(li.FBDT);
                dr["FEEDBACK"] = DataHandle.EmptyString2DBNull(li.FEEDBACK);
                dr["FREIGHT"] = DataHandle.EmptyString2DBNull(li.FREIGHT);
                dr["GOODSBACK"] = DataHandle.EmptyString2DBNull(li.GOODSBACK);
                dr["ISREFUND"] = DataHandle.EmptyString2DBNull(li.ISREFUND);
                dr["ORDERID"] = DataHandle.EmptyString2DBNull(li.ORDERID);
                dr["PAYMENT"] = DataHandle.EmptyString2DBNull(li.PAYMENT);
                dr["POSTFEE"] = DataHandle.EmptyString2DBNull(li.POSTFEE);
                dr["PRODBANKID"] = DataHandle.EmptyString2DBNull(li.PRODBANKID);
                dr["PRODDETID"] = DataHandle.EmptyString2DBNull(li.PRODDETID);
                dr["PRODNUM"] = DataHandle.EmptyString2DBNull(li.PRODNUM);
                dr["PRODUCTTYPE1"] = DataHandle.EmptyString2DBNull(li.PRODUCTTYPE1);
                dr["RECKONING"] = DataHandle.EmptyString2DBNull(li.RECKONING);
                dr["RECKONINGDT"] = DataHandle.EmptyString2DBNull(li.RECKONINGDT);
                dr["REFUNDDT"] = DataHandle.EmptyString2DBNull(li.REFUNDDT);
                dr["SOLDWITH"] = DataHandle.EmptyString2DBNull(li.SOLDWITH);
                dr["STATUS"] = DataHandle.EmptyString2DBNull(li.STATUS);
                dr["UPRICE"] = DataHandle.EmptyString2DBNull(li.UPRICE);

                localDt.Rows.Add(dr);
                outOrderDetDt.Merge(localDt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderDetData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderDetData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewOrderDetData" + ex.Message);
                throw;
            }
        }

        public void updateOrderDetData(SqlLib lib, IDb db, object obj, ref DataTable outOrderDetDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                OrderDetInfo li = new OrderDetInfo();
                ret = DataHandle.CompareObjectType(obj, li);
                if (ret)
                {
                    li = (OrderDetInfo)obj;
                }
                else
                {
                    return;
                }
                if (outOrderDetDt == null)
                {
                    throw new NullReferenceException("outOrderDerDt is null");
                }
                DataTable localDt = new DataTable();
                //根据Id更新一条数据信息
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetInfo");
                localDt = db.GetTable(sql);
                if (!string.IsNullOrEmpty(li.ORDERID))
                {
                    sql += " and ORDERDETID='" + li.ORDERDETID + "'";
                    localDt = db.GetTable(sql);
                    if (localDt.Rows.Count > 0)
                    {
                        DataRow dr = localDt.NewRow();
                        dr["ORDERDETID"] = DataHandle.EmptyString2DBNull(li.ORDERDETID);
                        dr["ACCOUNTINGCOST"] = DataHandle.EmptyString2DBNull(li.ACCOUNTINGCOST);
                        dr["BACKDT"] = DataHandle.EmptyString2DBNull(li.BACKDT);
                        dr["BACKMONEY"] = DataHandle.EmptyString2DBNull(li.BACKMONEY);
                        dr["BREASON"] = DataHandle.EmptyString2DBNull(li.BREASON);
                        dr["CARDRIGHTNUM"] = DataHandle.EmptyString2DBNull(li.CARDRIGHTNUM);
                        dr["CLEARFEE"] = DataHandle.EmptyString2DBNull(li.CLEARFEE);
                        dr["CONTACTID"] = DataHandle.EmptyString2DBNull(li.CONTACTID);
                        dr["CRDT"] = DataHandle.EmptyString2DBNull(li.CRDT);
                        dr["FBDT"] = DataHandle.EmptyString2DBNull(li.FBDT);
                        dr["FEEDBACK"] = DataHandle.EmptyString2DBNull(li.FEEDBACK);
                        dr["FREIGHT"] = DataHandle.EmptyString2DBNull(li.FREIGHT);
                        dr["GOODSBACK"] = DataHandle.EmptyString2DBNull(li.GOODSBACK);
                        dr["ISREFUND"] = DataHandle.EmptyString2DBNull(li.ISREFUND);
                        dr["ORDERID"] = DataHandle.EmptyString2DBNull(li.ORDERID);
                        dr["PAYMENT"] = DataHandle.EmptyString2DBNull(li.PAYMENT);
                        dr["POSTFEE"] = DataHandle.EmptyString2DBNull(li.POSTFEE);
                        dr["PRODBANKID"] = DataHandle.EmptyString2DBNull(li.PRODBANKID);
                        dr["PRODDETID"] = DataHandle.EmptyString2DBNull(li.PRODDETID);
                        dr["PRODNUM"] = DataHandle.EmptyString2DBNull(li.PRODNUM);
                        dr["PRODUCTTYPE1"] = DataHandle.EmptyString2DBNull(li.PRODUCTTYPE1);
                        dr["RECKONING"] = DataHandle.EmptyString2DBNull(li.RECKONING);
                        dr["RECKONINGDT"] = DataHandle.EmptyString2DBNull(li.RECKONINGDT);
                        dr["REFUNDDT"] = DataHandle.EmptyString2DBNull(li.REFUNDDT);
                        dr["SOLDWITH"] = DataHandle.EmptyString2DBNull(li.SOLDWITH);
                        dr["STATUS"] = DataHandle.EmptyString2DBNull(li.STATUS);
                        dr["UPRICE"] = DataHandle.EmptyString2DBNull(li.UPRICE);
                        dr.EndEdit();
                        outOrderDetDt.Merge(localDt, true);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
                throw;
            }

        }

        public void deleteOrderDetdata(SqlLib lib, IDb db, object obj, ref DataTable outOrderDetDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                OrderDetInfo OrderDetinfo = new OrderDetInfo();
                ret = DataHandle.CompareObjectType(obj, lib);
                if (ret)
                {
                    OrderDetinfo = (OrderDetInfo)obj;
                }
                else
                {
                    return;
                }
                if (outOrderDetDt == null)
                {
                    throw new NullReferenceException("outOrderDetInfo is null");
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetInfo");

                if (!string.IsNullOrEmpty(OrderDetinfo.ORDERDETID))
                {
                    sql += " and ORDERDETID='" + OrderDetinfo.ORDERDETID + "'";
                }
                else
                {
                    throw new NullReferenceException("保单详细信息不能为空");
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    localdt = db.GetTable(sql);
                }

                for (int i = 0; i < localdt.Rows.Count; i++)
                {
                    DataRow dr = localdt.Rows[i];
                    dr.Delete();
                }
                outOrderDetDt.Merge(localdt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
                throw;
            }
        }

        public void deleteAddOrderDetData(SqlLib lib, IDb db, object obj, ref DataTable outOrderDetDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                OrderDetInfo OrderDetinfo = new OrderDetInfo();
                ret = DataHandle.CompareObjectType(obj, OrderDetinfo);
                if (ret)
                {
                    OrderDetinfo = (OrderDetInfo)obj;
                }
                else
                {
                    return;
                }
                if (outOrderDetDt == null)
                {
                    throw new NullReferenceException("outOrderDetInfo is null");
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetInfo");

                if (!string.IsNullOrEmpty(OrderDetinfo.ORDERDETID))
                {
                    sql += " and ORDERDETID='" + OrderDetinfo.ORDERDETID + " '";
                }
                else
                {
                    throw new NullReferenceException("保单详细信息不能为空");
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    localdt = db.GetTable(sql);
                }

                for (int i = 0; i < localdt.Rows.Count; i++)
                {
                    DataRow dr = localdt.Rows[i];
                    dr.Delete();
                }
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteContractData" + ex.Message);
                throw;
            }
        }

        public bool updateOrderDetDataTable(SqlLib lib, IDb db, DataTable inDt)
        {
            bool ret = false;
            try
            {

                if (inDt.Rows.Count == 0)
                {
                    //没有记录，相当于这方法没有执行。
                    return true;
                }

                //更新OrderHist表
                //循环更新所有的。
                for (int i = 0; i < inDt.Rows.Count; i++)
                {
                    DataRow dr = inDt.Rows[i];

                    string localOrderid = "";

                    if (dr.RowState == DataRowState.Unchanged)
                    {
                        //do nothing.jump out the loop.
                        continue;
                    }
                    else
                        if (dr.RowState == DataRowState.Deleted)
                        {
                            //do nothing.
                        }
                        else
                        {
                            localOrderid = dr["orderDetid"].ToString();
                        }

                    string sql = lib.GetSql("SqlOrderDetInfo/OrderDetInfo", "GetOrderDetStructInfo");
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updateOrderDetDataTable sql={0}.", sql);

                    ret = db.Save(inDt, sql);
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updateOrderDetDataTable result={0}.", ret.ToString());
                    if (ret)
                    {
                        //return true.
                    }
                    else
                    {
                        db.Rollback();
                        localOrderid = "";
                        CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetDataTable" + db.Error.Message);
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetDataTable" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetDataTable" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetDataTable" + ex.Message);
                throw;
            }

            return ret;

        }

        public void addNewInsuranceUsrData(SqlLib lib, IDb db, object obj, ref DataTable outInsuranceUsrDt)
        {
            string sql = "";
            string localID = "";
            bool ret = false;
            try
            {
                InsuranceUsrInfo li = new InsuranceUsrInfo();
                ret = DataHandle.CompareObjectType(obj, li);
                if (ret)
                {
                    li = (InsuranceUsrInfo)obj;
                }
                else
                {
                    return;
                }
                if (outInsuranceUsrDt == null)
                {
                    throw new NullReferenceException("outInsuranceUsrDt is null");
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrStructInfo");
                localdt = db.GetTable(sql);

                sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetNewInsuranceUsrId");
                DataTable dt = new DataTable();
                dt = db.GetTable(sql);
                if (dt.Rows.Count > 0)
                {
                    localID = dt.Rows[0][0].ToString();
                    dt.Reset();
                }
                if (string.IsNullOrEmpty(localID))
                {
                    return;
                }
                DataRow dr = localdt.NewRow();
                dr["INSURANCE_USRID"] = DataHandle.EmptyString2DBNull(localID);
                dr["Proportion"] = DataHandle.EmptyString2DBNull(li.Proportion);
                dr["CRDT"] = DataHandle.EmptyString2DBNull(li.CRDT);
                dr["CRUSR"] = DataHandle.EmptyString2DBNull(li.CRUSR);
                dr["DSC"] = DataHandle.EmptyString2DBNull(li.DSC);
                dr["IDCARDNO"] = DataHandle.EmptyString2DBNull(li.IDCARDNO);
                dr["IDCARDTYPE"] = DataHandle.EmptyString2DBNull(li.IDCARDTYPE);
                dr["IDPERIOD"] = DataHandle.EmptyString2DBNull(li.IDPERIOD);
                dr["MDDT"] = DataHandle.EmptyString2DBNull(li.MDDT);
                dr["MDUSR"] = DataHandle.EmptyString2DBNull(li.MDUSR);
                dr["NAME"] = DataHandle.EmptyString2DBNull(li.NAME);
                dr["POST"] = DataHandle.EmptyString2DBNull(li.POST);
                dr["PROFESSION"] = DataHandle.EmptyString2DBNull(li.PROFESSION);
                dr["SEX"] = DataHandle.EmptyString2DBNull(li.SEX);
                localdt.Rows.Add(dr);
                outInsuranceUsrDt.Merge(localdt, true);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewInsuranceUsrData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewInsuranceUsrData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in addNewInsuranceUsrData" + ex.Message);
                throw;
            }
        }

        public void updateInsuranceUsrData(SqlLib lib, IDb db, object obj, ref DataTable outInsuranceUsrDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                InsuranceUsrInfo li = new InsuranceUsrInfo();
                ret = DataHandle.CompareObjectType(obj, li);
                if (ret)
                {
                    li = (InsuranceUsrInfo)obj;
                }
                else
                {
                    return;
                }
                if (outInsuranceUsrDt == null)
                {
                    throw new NullReferenceException("outInsuranceUsrDt is null");
                }
                DataTable localDt = new DataTable();
                //根据Id更新一条数据信息
                sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrInfo");
                localDt = db.GetTable(sql);
                if (!string.IsNullOrEmpty(li.INSURANCE_USRID))
                {
                    sql += " and INSURANCE_USRID='" + li.INSURANCE_USRID + "'";
                    localDt = db.GetTable(sql);
                    if (localDt.Rows.Count > 0)
                    {
                        DataRow dr = localDt.NewRow();
                        dr["INSURANCE_USRID"] = DataHandle.EmptyString2DBNull(li.INSURANCE_USRID);
                        dr["Proportion"] = DataHandle.EmptyString2DBNull(li.Proportion);
                        dr["CRDT"] = DataHandle.EmptyString2DBNull(li.CRDT);
                        dr["CRUSR"] = DataHandle.EmptyString2DBNull(li.CRUSR);
                        dr["DSC"] = DataHandle.EmptyString2DBNull(li.DSC);
                        dr["IDCARDNO"] = DataHandle.EmptyString2DBNull(li.IDCARDNO);
                        dr["IDCARDTYPE"] = DataHandle.EmptyString2DBNull(li.IDCARDTYPE);
                        dr["IDPERIOD"] = DataHandle.EmptyString2DBNull(li.IDPERIOD);
                        dr["MDDT"] = DataHandle.EmptyString2DBNull(li.MDDT);
                        dr["MDUSR"] = DataHandle.EmptyString2DBNull(li.MDUSR);
                        dr["NAME"] = DataHandle.EmptyString2DBNull(li.NAME);
                        dr["POST"] = DataHandle.EmptyString2DBNull(li.POST);
                        dr["PROFESSION"] = DataHandle.EmptyString2DBNull(li.PROFESSION);
                        dr["SEX"] = DataHandle.EmptyString2DBNull(li.SEX);
                        outInsuranceUsrDt.Merge(localDt, true);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updateOrderDetData" + ex.Message);
                throw;
            }
        }

        public void deleteInsuranceUsrData(SqlLib lib, IDb db, object obj, ref DataTable outInsuranceUsrDt)
        {
            string sql = "";
            bool ret = true;
            try
            {
                InsuranceUsrInfo InsuranceUsr = new InsuranceUsrInfo();
                ret = DataHandle.CompareObjectType(obj, InsuranceUsr);
                if (ret)
                {
                    InsuranceUsr = (InsuranceUsrInfo)obj;
                }
                else
                {
                    return;
                }
                if (outInsuranceUsrDt == null)
                {
                    throw new NullReferenceException("outInsuranceUsrDt is null");
                }
                DataTable localdt = new DataTable();
                sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrInfo");

                if (!string.IsNullOrEmpty(InsuranceUsr.INSURANCE_USRID))
                {
                    sql += " and INSURANCE_USRID='" + InsuranceUsr.INSURANCE_USRID + " '";
                }
                else
                {
                    throw new NullReferenceException("保单详细信息不能为空");
                }
                if (!string.IsNullOrEmpty(sql))
                {
                    localdt = db.GetTable(sql);
                }

                for (int i = 0; i < localdt.Rows.Count; i++)
                {
                    DataRow dr = localdt.Rows[i];
                    dr.Delete();
                }
                outInsuranceUsrDt.Merge(localdt);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in deleteInsuranceUsrData" + ex.Message);
                throw;
            }
        }

        public bool updataInsuranceUsrDataTable(SqlLib lib, IDb db, DataTable indt)
        {
            bool ret = false;
            try
            {

                if (indt.Rows.Count == 0)
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }

                //更新OrderHist表
                //循环更新所有的。
                for (int i = 0; i < indt.Rows.Count; i++)
                {
                    DataRow dr = indt.Rows[i];

                    string localOrderid = "";

                    if (dr.RowState == DataRowState.Unchanged)
                    {
                        //do nothing.jump out the loop.
                        continue;
                    }
                    else
                        if (dr.RowState == DataRowState.Deleted)
                        {
                            //do nothing.
                        }
                        else
                        {
                            localOrderid = dr["INSURANCE_USRID"].ToString();
                        }

                    string sql = lib.GetSql("SqlInsuranceUsrInfo/InsuranceUsrInfo", "GetInsuranceUsrStructInfo");
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updateOrderDetDataTable sql={0}.", sql);

                    ret = db.Save(indt, sql);
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "updataInsuranceUsrDataTable result={0}.", ret.ToString());
                    if (ret)
                    {
                        //return true.
                    }
                    else
                    {
                        db.Rollback();
                        localOrderid = "";
                        CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updataInsuranceUsrDataTable" + db.Error.Message);
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updataInsuranceUsrDataTable" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updataInsuranceUsrDataTable" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in updataInsuranceUsrDataTable" + ex.Message);
                throw;
            }

            return ret;

        }

        #endregion
    }

}