using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Rayda.Common;
using Rayda.Data;
using System.Data;
using Rayda.Data.Special;

namespace Rayda.Insurance.WcfRestServiceOrder
{
    public class OrderInfoHelper
    {

        /// <summary>
        /// Update ORM
        /// </summary>
        /// <param name="DTListOrderInfo">The DT list order info.</param>
        /// <returns>
        /// System.Boolean
        /// </returns>
        /// <author>
        /// Stone
        /// </author>
        /// <remarks>
        /// 2012/10/29 17:54 TUTU-PC
        /// </remarks>
        public bool Update(DataList<OrderInfo> DTListOrderInfo)
        {
            bool ret = true;

            try
            {
                dataHandler.updateDtHelper[] ArrayUpdateDtHelper ={new dataHandler.updateDtHelper(updateDataTableOrderInfo)
                                                                 };
                ret &= dataHandler.updateDataTable(DTListOrderInfo, ArrayUpdateDtHelper);

            }
            catch (FormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (TimeoutException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo Update" + ex.Message);
                throw;
            }
            return ret;
        }


        /// <summary>
        /// updateDataTableOrderInfo. ORM 2 Data Table.
        /// </summary>
        /// <param name="lib">The lib.</param>
        /// <param name="db">The db.</param>
        /// <param name="obj">The obj.</param>
        /// <returns>
        /// System.Boolean
        /// </returns>
        /// <author>
        /// Stone   
        /// </author>
        /// <remarks>
        /// 2012/10/29 17:54 TUTU-PC
        /// </remarks>
        private bool updateDataTableOrderInfo(SqlLib lib, IDb db, Object obj)
        {
            bool ret = false;

            try
            {
                DataList<OrderInfo> DTlistOrderInfo = new DataList<OrderInfo>();
                Type typeObj = obj.GetType();

                if (DTlistOrderInfo == null)
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }

                if (typeObj.Equals(DTlistOrderInfo.GetType()))
                {
                    //get the correct list.
                    DTlistOrderInfo = (DataList<OrderInfo>)obj;
                }
                else
                {
                    throw new ArrayTypeMismatchException("wrong object type!");
                }

                OrderInfoDB localOrderInfoDB = new OrderInfoDB();

                DataTable dtOrderHist = new DataTable();
                DataTable dtOrderDet = new DataTable();

                // 被保人
                DataTable dtinsurant = new DataTable();
                
                // 受益人
                DataTable dtbeneficiaries = new DataTable();
                
                // 被保人
                DataTable dtpolicyholder = new DataTable();



                //整合保险人的信息 最后在进行提交
                DataTable dtInsurance_usr = new DataTable();


                //将Data List的OrderInfo对象映射为多个DataTable.
                if (DTlistOrderInfo.Count > 0)
                {
                    foreach (OrderInfo li in DTlistOrderInfo)
                    {
                        dataHandler.MapSingleObjDataTable(lib, db, li.DataState, li, localOrderInfoDB.addNewOrderHistData, localOrderInfoDB.updateOrderHistData, localOrderInfoDB.deleteOrderHistData, ref dtOrderHist);

                        //如果有orderid,那么直接往下传，必须有。

                        //如果有过保单明细，那么需要先删除,以便后续操作.
                        if (!string.IsNullOrEmpty(li.ORDERID))
                        {
                            dataHandler.MapSingleObjDataTable(lib, db, CommonDefineData.DELETE_DATA, li, null, null, localOrderInfoDB.deleteOrderHistAllDetData, ref dtOrderDet);
                        }

                        foreach (OrderDetInfo liOrderDet in li.ORDERDETINFO)
                        {
                            if (li.DataState == CommonDefineData.INSERT_DATA)
                            {
                                liOrderDet.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else if (li.DataState == CommonDefineData.UPDATE_DATA)
                            {
                                liOrderDet.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else
                            {
                                liOrderDet.DataState = CommonDefineData.NOTDO_DATA;
                            }

                            dataHandler.MapSingleObjDataTable(lib, db, liOrderDet.DataState, liOrderDet, localOrderInfoDB.addNewOrderDetData, localOrderInfoDB.updateOrderDetData, localOrderInfoDB.deleteOrderDetdata, ref dtOrderDet);
                        }
                        if (li.DataState != CommonDefineData.DELETE_DATA)
                        {
                            foreach (DataRow localrow in dtOrderDet.Rows)
                            {
                                if (dtOrderHist != null && dtOrderHist.Rows.Count > 0)
                                {

                                    DataRow rowHist = dtOrderHist.Rows[0];
                                    if (rowHist.RowState != DataRowState.Deleted)
                                    {
                                        if (localrow.RowState != DataRowState.Deleted)
                                        {
                                            localrow.BeginEdit();
                                            localrow["ORDERID"] = rowHist["ORDERID"].ToString();
                                            localrow.EndEdit();
                                        }
                                    }

                                }

                            }
                        }



                        ///如果保险人信息不为空则需全部delete 一次 到下面在进行新增

                        if (!string.IsNullOrEmpty(li.ORDERID))
                        {

                            //如果有被保人信息 则首先需要删除保险人所有信息
                            if (li.Insurant_usr != null && !string.IsNullOrEmpty(li.Insurant_usr.INSURANCE_USRID))
                            {
                                dataHandler.MapSingleObjDataTable(lib, db, CommonDefineData.DELETE_DATA, li, null, null, localOrderInfoDB.deleteOrderHistAllInsurantData, ref dtinsurant);
                            }
                           
                        }

                        // 操作受益人信息
                        foreach (InsuranceUsrInfo liInUser in li.Lstbeneficiaries)
                        {

                            if (li.DataState == CommonDefineData.INSERT_DATA)
                            {
                                liInUser.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else if (li.DataState == CommonDefineData.UPDATE_DATA)
                            {
                                liInUser.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else
                            {
                                liInUser.DataState = CommonDefineData.NOTDO_DATA;
                            }
                            dataHandler.MapSingleObjDataTable(lib, db, liInUser.DataState.Trim(), liInUser, localOrderInfoDB.addNewInsuranceUsrData, localOrderInfoDB.updateInsuranceUsrData, localOrderInfoDB.deleteInsuranceUsrData, ref dtbeneficiaries);
                        }

                        //把受受益人编号信息需要写入到con_orderhist.
                        if (dtOrderHist != null && dtOrderHist.Rows.Count > 0)
                        {

                            // 定义变量  确定受益人是第几个
                            int beneficiariescount = 0;
                            

                            if (li.DataState != CommonDefineData.DELETE_DATA)
                            {
                                if (dtbeneficiaries != null && dtbeneficiaries.Rows.Count > 0)
                                {
                                    foreach (DataRow drbeneficiaries in dtbeneficiaries.Rows)
                                    {
                                        //DataRow drbeneficiaries = dtbeneficiaries.Rows[0];

                                        if (drbeneficiaries.RowState != DataRowState.Deleted)
                                        {
                                            DataRow localrow = dtOrderHist.Rows[0];
                                            {
                                                if (localrow.RowState != DataRowState.Deleted)
                                                {
                                                    beneficiariescount ++;
                                                    if (beneficiariescount == 1)
                                                    { 
                                                    localrow.BeginEdit();
                                                    localrow["beneficiaries"] = drbeneficiaries["insurance_usrid"];
                                                    localrow.EndEdit();
                                                    
                                                    }

                                                    if (beneficiariescount == 2)
                                                    {
                                                        localrow.BeginEdit();
                                                        localrow["beneficiaries2"] = drbeneficiaries["insurance_usrid"];
                                                        localrow.EndEdit();

                                                    }

                                                    if (beneficiariescount == 3)
                                                    {
                                                        localrow.BeginEdit();
                                                        localrow["beneficiaries3"] = drbeneficiaries["insurance_usrid"];
                                                        localrow.EndEdit();

                                                    }
                            
                            


                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    


                 

               



                        // 操作投保人信息

                        if (li.Policyholder_usr != null)
                        {

                            if (li.DataState == CommonDefineData.INSERT_DATA)
                            {
                                li.Policyholder_usr.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else if (li.DataState == CommonDefineData.UPDATE_DATA)
                            {
                                li.Policyholder_usr.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else
                            {
                                li.Policyholder_usr.DataState = CommonDefineData.NOTDO_DATA;
                            }
                            dataHandler.MapSingleObjDataTable(lib, db, li.Policyholder_usr.DataState, li.Policyholder_usr, localOrderInfoDB.addNewInsuranceUsrData, localOrderInfoDB.updateInsuranceUsrData, localOrderInfoDB.deleteInsuranceUsrData, ref dtpolicyholder);
                        }

                        //把投保人编号信息需要写入到con_orderhist.
                        if (dtOrderHist != null && dtOrderHist.Rows.Count > 0)
                        {
                            if (li.DataState != CommonDefineData.DELETE_DATA)
                            {
                                if (dtpolicyholder != null && dtpolicyholder.Rows.Count > 0)
                                {
                                    foreach (DataRow drpolicyholder in dtpolicyholder.Rows)
                                    {

                                        if (drpolicyholder.RowState != DataRowState.Deleted)
                                        {

                                            DataRow localrow = dtOrderHist.Rows[0];

                                            if (localrow.RowState != DataRowState.Deleted)
                                            {
                                                localrow.BeginEdit();
                                                localrow["policyholder"] = drpolicyholder["insurance_usrid"];

                                                if (li.Insurantrelation != null && li.Insurantrelation == "1")
                                                {
                                                    localrow["INSURANT"] = drpolicyholder["insurance_usrid"];
                                                }

                                                localrow.EndEdit();
                                            }

                                        }
                                    }

                                }
                            }
                        }




                        // 如果操作的保单与被保人的关系为本人, 将被保人保人的对象赋值为空，

                        if (li.Insurantrelation != null && li.Insurantrelation == "1")
                        {
                            li.Insurant_usr = null;
                        }
                        else
                        {
                            // do nothing
                        }

                        // 操作被保人信息 
                        if (li.Insurant_usr != null)
                        {
                            if (li.DataState == CommonDefineData.INSERT_DATA)
                            {
                                li.Insurant_usr.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else if (li.DataState == CommonDefineData.UPDATE_DATA)
                            {
                                li.Insurant_usr.DataState = CommonDefineData.INSERT_DATA;
                            }
                            else
                            {
                                li.Insurant_usr.DataState = CommonDefineData.NOTDO_DATA;
                            }

                            dataHandler.MapSingleObjDataTable(lib, db, li.Insurant_usr.DataState, li.Insurant_usr, localOrderInfoDB.addNewInsuranceUsrData, localOrderInfoDB.updateInsuranceUsrData, localOrderInfoDB.deleteInsuranceUsrData, ref dtinsurant);
                        }


                        if (li.DataState != CommonDefineData.DELETE_DATA)
                        {
                            //把被保人信息需要写入到con_orderhist.
                            if (dtOrderHist != null && dtOrderHist.Rows.Count > 0)
                            {
                                if (dtinsurant != null && dtinsurant.Rows.Count > 0)
                                {

                                    foreach (DataRow drInsurant in dtinsurant.Rows)
                                    {
                                        if (drInsurant.RowState != DataRowState.Deleted)
                                        {
                                            DataRow localrow = dtOrderHist.Rows[0];
                                            if (localrow.RowState != DataRowState.Deleted)
                                            {
                                                localrow.BeginEdit();

                                                localrow["INSURANT"] = drInsurant["insurance_usrid"].ToString();
                                                localrow.EndEdit();
                                            }
                                        }
                                    }
                                }

                            }
                        }



                    }

                }

                else
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }

                if (DTlistOrderInfo != null && DTlistOrderInfo.Count > 0)
                {
                    OrderInfo localOrderInfo = DTlistOrderInfo[0];


                    dtInsurance_usr.Merge(dtinsurant, true);
                    dtInsurance_usr.Merge(dtbeneficiaries, true);
                    dtInsurance_usr.Merge(dtpolicyholder, true);
                    // 主键约束 需要判断哪个表先删除
                    if (localOrderInfo.DataState == CommonDefineData.DELETE_DATA)
                    {
                        ////update datatable orderdet.
                        ret = localOrderInfoDB.updateOrderDetDataTable(lib, db, dtOrderDet);
                        //update datatable orderhist.
                        ret &= localOrderInfoDB.updateOrderHistDataTable(lib, db, dtOrderHist);
                        ret &= localOrderInfoDB.updataInsuranceUsrDataTable(lib, db, dtInsurance_usr);

                    }
                    else
                    {
                        ret = localOrderInfoDB.updataInsuranceUsrDataTable(lib, db, dtInsurance_usr);
                        ret &= localOrderInfoDB.updateOrderHistDataTable(lib, db, dtOrderHist);
                        ret &= localOrderInfoDB.updateOrderDetDataTable(lib, db, dtOrderDet);
                    }

                }


            }


            catch (FormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo  Update" + ex.Message);
            }
            catch (TimeoutException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (Exception ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
                throw;
            }

            return ret;
        }



        #region 关于订单的查询操作
       /// <summary>
        /// orderInfo 通过查询的条件查询 list 集合
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        private List<OrderInfo> LocalOrderInfoList(string queryString)
        {
            List<OrderInfo> localOrderInfolst = new List<OrderInfo>();
            OrderInfoDB localOrderInfo = new OrderInfoDB();
            localOrderInfolst = localOrderInfo.outOrderInfo(queryString);
            return localOrderInfolst;
        }


        /// <summary>
        /// 根据ordeid， 返回OrderInfo
        /// </summary>
        /// <param name="orderID">orderid</param>
        /// <returns>localOrderInfo</returns>
        public OrderInfo outOrderInfo(string orderID)
        {
            string swhere = "";
            OrderInfo localOrderInfo = new OrderInfo();
            if (!string.IsNullOrEmpty(orderID))
            {
                swhere = string.Format(" and orderid = '{0}'", orderID);
                List<OrderInfo> localOrderInfolst = LocalOrderInfoList(swhere);
                if (localOrderInfolst != null && localOrderInfolst.Count > 0)
                {
                    localOrderInfo = localOrderInfolst.FirstOrDefault(o => o.ORDERID == orderID);
                }
                else
                { 
                    // do nothing
                }
            }
            else
            { 
               // do nothing
            }
            return localOrderInfo;
        }



        /// <summary>
        /// Action：可以根据创建者和status 字段查询出 订单信息
        /// Author：Eric
        /// Date：2012/11/08
        /// </summary>
        /// <param name="crusr">crusr</param>
        /// <param name="status">status</param>
        /// <returns></returns>
        public List<OrderInfo> outOrderInfoList(string crusr, string status)
        {
            List<OrderInfo> localOrderInfolst = new List<OrderInfo>();

            string swhere = "";
            if (!string.IsNullOrEmpty(crusr))
            {            
                 swhere = string.Format(" and crusr = '{0}'",crusr);
         
            }
            if (!string.IsNullOrEmpty(status))
            {
                swhere =swhere + string.Format( " and status = '{0}'",status);
                  
            }
   
            localOrderInfolst = LocalOrderInfoList(swhere);
            return localOrderInfolst;
        }





        
        #endregion
 

    }
}