using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Rayda.Common.Special;
using Rayda.Data.Special;
using System.IO;

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
        [WebGet(UriTemplate = "OrderInfo", ResponseFormat = WebMessageFormat.Json)]
        //所以要返回list.同时，使用查询字符串，支持复杂的查询。
        public List<OrderInfo> GetCollection()
        {
            CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/GET.");
            return new List<OrderInfo>() { new OrderInfo() { ORDERID = "007", CONTACTID = "007" } };
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

            CTrace.WriteLine(CTrace.TraceLevel.Debug, "OrderInfo/POST.");

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
                    //do nothing.
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
        [WebGet(UriTemplate = "OrderInfo/{Orderid}")]
        public OrderInfo Get(string orderid)
        {
            OrderInfo localOrderInfo = new OrderInfo();
            localOrderInfo.ORDERID = orderid;
            localOrderInfo.CONTACTID = "008";

            return localOrderInfo;
        }

        //PUT的实现,修改Order Info
        [WebInvoke(UriTemplate = "OrderInfo/{Orderid}", Method = "PUT")]
        public ReturnInfo Update(string orderid)
        {
            // TODO: Update the given instance of SampleItem in the collection
            throw new NotImplementedException();
        }

        [WebInvoke(UriTemplate = "OrderInfo/{Orderid}", Method = "DELETE")]
        public void Delete(string orderid)
        {
            // TODO: Remove the instance of SampleItem with the given id from the collection
            throw new NotImplementedException();
        }

        #endregion
    }
}
