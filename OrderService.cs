using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Rayda.Common;
using System.IO;
using Rayda.Common.Special;
using Rayda.Data.Special;

namespace Rayda.Insurance.WcfRestServiceOrder
{
    // Start the service and browse to http://<machine_name>:<port>/OrderService/help to view the service's generated help page
    //TODO: need this configuration.
    // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
    // a single instance of the service to process all calls.	
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class OrderService
    {
        //所有的GET都原生支持查询变量

        #region 对于 OrderInfo资源,实现GET/POST

        //GET的实现,返回一个List Order Info.
        [WebGet(UriTemplate = "OrderInfo?crusr={crusr}&status={status}", ResponseFormat = WebMessageFormat.Json)]
        //所以要返回list.同时，使用查询字符串，支持复杂的查询。
        public List<OrderInfo> GetCollection(string crusr,string status)
        {
            //CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/GET.");
            //return new List<OrderInfo>() { new OrderInfo() { ORDERID = "007", CONTACTID = "007" } };
            List<OrderInfo> localOrderInfo = new List<OrderInfo>();
            OrderInfoHelper localOrderInfoHelper = new OrderInfoHelper();
            localOrderInfo = localOrderInfoHelper.outOrderInfoList(crusr,status);
            return localOrderInfo;


        }

        //POST的实现,由服务器决定orderid,添加orderinfo
        [WebInvoke(UriTemplate = "OrderInfo", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public ReturnInfo Create(OrderInfo inOrderInfo)
        {
            ReturnInfo localReturnInfo = new ReturnInfo();

            localReturnInfo.RETURNFLAG = false;
            localReturnInfo.RETURNINFO = CommonDefineData.UNKNOWN_STATUS;

            var ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;

            CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/orderid/POST.");

            try
            {

                DataList<OrderInfo> localDLOrderInfo = new DataList<OrderInfo>();
                if (inOrderInfo != null)
                {
                    localDLOrderInfo.AddNewData(inOrderInfo);

                    //调用Domain进行add
                    OrderInfoHelper localOrderInfoHelper = new OrderInfoHelper();
                    bool ret = localOrderInfoHelper.Update(localDLOrderInfo);

                    if (ret)
                    {
                        localReturnInfo.RETURNFLAG = true;
                        localReturnInfo.RETURNINFO = CommonDefineData.SUCCESS_STATUS;
                    }
                }
                else
                {
                    return localReturnInfo;
                }


                if (localReturnInfo.RETURNFLAG)
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Created;
                }
                else
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                LogSystem.WebLogDebug(ex.Message);

                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
                localReturnInfo.RETURNFLAG = false;
                localReturnInfo.RETURNINFO = CommonDefineData.EXCEPTION_STATUS;
            }

            return localReturnInfo;
        }

        #endregion

        #region 对于 OrderInfo/{Orderid} 资源,实现GET/PUT/DELET

        //GET的实现,返回一条Order Info
        [WebGet(UriTemplate = "OrderInfo/{Orderid}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public OrderInfo Get(string orderid)
        {
            OrderInfo localorderInfo = new OrderInfo();
            if (!string.IsNullOrEmpty(orderid))
            {
                OrderInfoHelper localOrderInfoHelper = new OrderInfoHelper();
               localorderInfo= localOrderInfoHelper.outOrderInfo(orderid);
            }
            else
            { 
                // do nothing
            }
            return localorderInfo;

        }

        //PUT的实现,修改Order Info
        [WebInvoke(UriTemplate = "OrderInfo", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        public ReturnInfo Update(OrderInfo inOrderInfo)
        {
            ReturnInfo localReturnInfo = new ReturnInfo();

            localReturnInfo.RETURNFLAG = false;
            localReturnInfo.RETURNINFO = CommonDefineData.UNKNOWN_STATUS;

            var ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;

            CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/orderid/PUT.");

            try
            {

                DataList<OrderInfo> localDLOrderInfo = new DataList<OrderInfo>();
                if (inOrderInfo != null)
                {
                    localDLOrderInfo.AddModifiedData(inOrderInfo);

                    //调用Domain进行modify
                    OrderInfoHelper localOrderInfoHelper = new OrderInfoHelper();
                    bool ret = localOrderInfoHelper.Update(localDLOrderInfo);

                    if (ret)
                    {
                        localReturnInfo.RETURNFLAG = true;
                        localReturnInfo.RETURNINFO = CommonDefineData.SUCCESS_STATUS;
                    }
                }
                else
                {
                    return localReturnInfo;
                }


                if (localReturnInfo.RETURNFLAG)
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Created;
                }
                else
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                LogSystem.WebLogDebug(ex.Message);

                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
                localReturnInfo.RETURNFLAG = false;
                localReturnInfo.RETURNINFO = CommonDefineData.EXCEPTION_STATUS;
            }

            return localReturnInfo;
        }

        [WebInvoke(UriTemplate = "OrderInfo", Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public ReturnInfo Delete(OrderInfo inOrderInfo)
        {
            ReturnInfo localReturnInfo = new ReturnInfo();

            localReturnInfo.RETURNFLAG = false;
            localReturnInfo.RETURNINFO = CommonDefineData.UNKNOWN_STATUS;

            var ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;

            CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/orderid/DELETE.");

            try
            {

                DataList<OrderInfo> localDLOrderInfo = new DataList<OrderInfo>();
                if (inOrderInfo != null)
                {
                    localDLOrderInfo.AddDeletedData(inOrderInfo);

                    //调用Domain进行DELETE
                    OrderInfoHelper localOrderInfoHelper = new OrderInfoHelper();
                    bool ret = localOrderInfoHelper.Update(localDLOrderInfo);

                    if (ret)
                    {
                        localReturnInfo.RETURNFLAG = true;
                        localReturnInfo.RETURNINFO = CommonDefineData.SUCCESS_STATUS;
                    }
                }
                else
                {
                    return localReturnInfo;
                }


                if (localReturnInfo.RETURNFLAG)
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Created;
                }
                else
                {
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                LogSystem.WebLogDebug(ex.Message);

                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
                localReturnInfo.RETURNFLAG = false;
                localReturnInfo.RETURNINFO = CommonDefineData.EXCEPTION_STATUS;
            }

            return localReturnInfo;
        }

        #endregion
    }
}
