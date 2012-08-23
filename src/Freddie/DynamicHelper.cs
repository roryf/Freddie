using Freddie.RequestProviders;

namespace Freddie
{
    internal class DynamicList : DynamicBase
    {
        internal DynamicList(Endpoint endpoint) : base(endpoint)
        {
            methods.Add("listUpdateMember", typeof(ListUpdateMemberRequestProvider));
            methods.Add("listStaticSegments", typeof(ListStaticSegmentsRequestProvider));
            methods.Add("listSubscribe", typeof(ListSubscribeRequestProvider));
            methods.Add("lists", typeof(ListsRequestProvider));
        }
    }

    internal class DynamicHelper : DynamicBase
    {
        internal DynamicHelper(Endpoint endpoint) : base(endpoint)
        {
            methods.Add("ping", typeof (PingRequestProvider));
            methods.Add("getAccountDetails", typeof(GetAccountDetailsRequestProvider));
        }
    }
}