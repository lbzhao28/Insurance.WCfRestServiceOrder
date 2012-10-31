using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Rayda.Data;
using Rayda.Common.Special;
using Rayda.Data.Special;
using System.Data;

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

                DataTable dtOrderHist = new DataTable();



                if (DTlistOrderInfo.Count > 0)
                {
                    foreach (OrderInfo li in DTlistOrderInfo)
                    {
                        //dataHandler.MapSingleObjDataTable(lib, db, li.DataState, li, addNewOrderHistData, updateOrderHistData, deleteOrderHistData, ref dtOrderHist);
                    }
                }
                else
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }


                //update datatable orderhist.
                //TODO: 提取出来，到数据层，做一个独立的方法.放到一个统一的地方。一个项目一个统一的地方.

                if (dtOrderHist.Rows.Count == 0)
                {
                    //没有记录，相当于这方法没有执行。
                    return ret;
                }

                //更新OrderHist表
                //循环更新所有的。
                for (int i = 0; i < dtOrderHist.Rows.Count; i++)
                {
                    DataRow dr = dtOrderHist.Rows[i];
                    string localRelationID = "";
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
                            localRelationID = dr["providerid"].ToString();
                        }

                    string relationid = localRelationID;
                    string sqlRelation = lib.GetSql("SqlPlace/PlaceProdInfo", "GetPlaceProdRelationInfo");
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "i8.place Update sql={0}.", sqlRelation);

                    db.BeginTransaction();
                    ret = db.Save(dtOrderHist, sqlRelation);
                    CTrace.WriteLine(CTrace.TraceLevel.Info, "i8.place Update Case={0}.", ret.ToString());
                    if (ret)
                    {
                        //return true.
                    }
                    else
                    {
                        db.Rollback();
                        localRelationID = "";
                    }
                }


                DataTable dtOrderDet = new DataTable();
            }
            catch (FormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (ArrayTypeMismatchException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                CTrace.WriteLine(CTrace.TraceLevel.Fail, "in OrderInfo DataTable Update" + ex.Message);
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

    }

}