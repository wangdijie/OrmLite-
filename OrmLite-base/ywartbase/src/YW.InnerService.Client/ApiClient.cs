 
 

namespace YW.InnerService.Client
{
    using YW.InnerService.Apis;


#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释 
    public partial class ApiClient
    {
        private ArtistsApi _Artists;

        public ArtistsApi Artists 
        {
            get
            {
                return _Artists??(_Artists=new ArtistsApi());
            }
        }

        private ArtworksApi _Artworks;

        public ArtworksApi Artworks 
        {
            get
            {
                return _Artworks??(_Artworks=new ArtworksApi());
            }
        }

        private AuctionsApi _Auctions;

        public AuctionsApi Auctions 
        {
            get
            {
                return _Auctions??(_Auctions=new AuctionsApi());
            }
        }

        private EmailApi _Email;

        public EmailApi Email 
        {
            get
            {
                return _Email??(_Email=new EmailApi());
            }
        }

        private MainOrdersApi _MainOrders;

        public MainOrdersApi MainOrders 
        {
            get
            {
                return _MainOrders??(_MainOrders=new MainOrdersApi());
            }
        }

        private MainPaymentApi _MainPayment;

        public MainPaymentApi MainPayment 
        {
            get
            {
                return _MainPayment??(_MainPayment=new MainPaymentApi());
            }
        }

        private MessageApi _Message;

        public MessageApi Message 
        {
            get
            {
                return _Message??(_Message=new MessageApi());
            }
        }

        private OrdersApi _Orders;

        public OrdersApi Orders 
        {
            get
            {
                return _Orders??(_Orders=new OrdersApi());
            }
        }

        private PayordersApi _Payorders;

        public PayordersApi Payorders 
        {
            get
            {
                return _Payorders??(_Payorders=new PayordersApi());
            }
        }

        private SpuApi _Spu;

        public SpuApi Spu 
        {
            get
            {
                return _Spu??(_Spu=new SpuApi());
            }
        }

        private UsersApi _Users;

        public UsersApi Users 
        {
            get
            {
                return _Users??(_Users=new UsersApi());
            }
        }

        private WeChatApi _WeChat;

        public WeChatApi WeChat 
        {
            get
            {
                return _WeChat??(_WeChat=new WeChatApi());
            }
        }


    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}