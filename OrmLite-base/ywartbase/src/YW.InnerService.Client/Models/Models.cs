 
 
namespace YW.InnerService.Models
{
    using System;
    

    /// <summary>
    /// 
    /// </summary>
    public class ArtistCommentModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long UserId { get; set; }
    }

    /// <summary>
    /// 搜索参数
    /// </summary>
    public class ArtworkSearchModel
    {
        /// <summary>
        /// 关键词
        /// 
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// 最小价格
        /// 
        /// </summary>
        public int MinPrice { get; set; }
        /// <summary>
        /// 最大价格
        /// 
        /// </summary>
        public int MaxPrice { get; set; }
        /// <summary>
        /// 最小尺寸
        /// 
        /// </summary>
        public int MinSize { get; set; }
        /// <summary>
        /// 最大尺寸
        /// 
        /// </summary>
        public int MaxSize { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// 颜色
        /// 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 形状
        /// 
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        /// 展示空间
        /// 
        /// </summary>
        public string Space { get; set; }
        /// <summary>
        /// 分类
        /// 
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 风格
        /// 
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// 主题
        /// 
        /// </summary>
        public string Theme { get; set; }
        /// <summary>
        /// 是否简单呈现
        /// 
        /// </summary>
        public bool IsSimpleShow { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsOnlyNoSold { get; set; }
        /// <summary>
        /// 排序规则
        /// 
        /// </summary>
        public int SortKey { get; set; }
        /// <summary>
        /// 艺术品类型
        /// 可选枚举值:All,Original,Collection,Print
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 分销码
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// 是否藏艺术
        /// 
        /// </summary>
        public bool IsCollect { get; set; }
        /// <summary>
        /// 是否造诣
        /// 
        /// </summary>
        public bool IsZaoyi { get; set; }
        /// <summary>
        /// 搜索全部作品
        /// 
        /// </summary>
        public bool SearchAll { get; set; }
        /// <summary>
        /// 是否是艺博会商品
        /// 
        /// </summary>
        public bool IsArtFair { get; set; }
        /// <summary>
        /// 当前页码
        /// 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 每页的条数
        /// 
        /// </summary>
        public int PageSize { get; set; }
    }

    /// <summary>
    /// 艺术品实体model
    /// </summary>
    public class ArtworkDataModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long ArtistId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string CreateDate1 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string CreateDate2 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceContract { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceSale { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceDiscount { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AcademicCategory1 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AcademicCategory2 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Recommend { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long RecommendSysUserId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Introduction { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int ExpressType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ExpressAddress { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ExpressContacts { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ExpressPhone { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int StockTotal { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int StockSold { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int StockLock { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long SkuId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int StockFree { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int IsSold { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsLock { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string BelongsArea { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkAttr { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkMaterial { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkShape { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ImgMaterial { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgFilename { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgSizeThickness { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgSizeHeight { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgSizeWidth { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int MainimgWidth { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int MainimgHeight { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgC1 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgC2 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgC3 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgC4 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MainimgC5 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgC1v { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgC2v { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgC3v { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgC4v { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal MainimgC5v { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ShowSpace1 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ShowSpace2 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ShowSpace3 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ShowSpace4 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkStyle { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkSubject { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int Edition1 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int Edition2 { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool CanFramed { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsSimpleShow { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsCollect { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsNewRecommend { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsZaoyi { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsAudit { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int AuditStatus { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string RejectReason { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsAdopt { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsPutaway { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime PutawayTime { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsAgentReserve { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long AgentReserveUserId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsAuctionGoods { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceAuctionHammer { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceAuctionSold { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PartnerOrgName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsTest { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string SortKey { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long CreateSysUserId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long CountView { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int CountLike { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal SizeMin { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal SizeMax { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long AgentOrgId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime LockTimeout { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int CustomerSortKey { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string DecorationImgs { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal PriceSaleOld { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsArtFair { get; set; }
    }

    /// <summary>
    /// 画框实体
    /// </summary>
    public class ArtworkFrameModel
    {
        /// <summary>
        /// 画框
        /// 
        /// </summary>
        public FrameModel ArtworkFrame { get; set; }
        /// <summary>
        /// 卡纸描述
        /// 
        /// </summary>
        public FrameModel[] Paddings { get; set; }
    }

    /// <summary>
    /// 框架描述
    /// </summary>
    public class FrameModel
    {
        /// <summary>
        /// ID
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 名称
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 材料单价
        /// 
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 缩略图
        /// 
        /// </summary>
        public string ThumImg { get; set; }
        /// <summary>
        /// 样板图片
        /// 
        /// </summary>
        public string SampleImg { get; set; }
        /// <summary>
        /// 样板分辨率 像素/厘米
        /// 
        /// </summary>
        public decimal SampleResolution { get; set; }
        /// <summary>
        /// 左上角_top
        /// 
        /// </summary>
        public int A1Top { get; set; }
        /// <summary>
        /// 左上角_left
        /// 
        /// </summary>
        public int A1Left { get; set; }
        /// <summary>
        /// 左上角_width
        /// 
        /// </summary>
        public int A1Width { get; set; }
        /// <summary>
        /// 左上角_height
        /// 
        /// </summary>
        public int A1Height { get; set; }
        /// <summary>
        /// 左上角覆盖_x
        /// 
        /// </summary>
        public int A1CoverX { get; set; }
        /// <summary>
        /// 左上角覆盖_y
        /// 
        /// </summary>
        public int A1CoverY { get; set; }
        /// <summary>
        /// 右上角_top
        /// 
        /// </summary>
        public int A2Top { get; set; }
        /// <summary>
        /// 右上角_left
        /// 
        /// </summary>
        public int A2Left { get; set; }
        /// <summary>
        /// 右上角_width
        /// 
        /// </summary>
        public int A2Width { get; set; }
        /// <summary>
        /// 右上角_height
        /// 
        /// </summary>
        public int A2Height { get; set; }
        /// <summary>
        /// 右上角覆盖_x
        /// 
        /// </summary>
        public int A2CoverX { get; set; }
        /// <summary>
        /// 右上角覆盖_y
        /// 
        /// </summary>
        public int A2CoverY { get; set; }
        /// <summary>
        /// 右下角_top
        /// 
        /// </summary>
        public int A3Top { get; set; }
        /// <summary>
        /// 右下角_left
        /// 
        /// </summary>
        public int A3Left { get; set; }
        /// <summary>
        /// 右下角_width
        /// 
        /// </summary>
        public int A3Width { get; set; }
        /// <summary>
        /// 右下角_height
        /// 
        /// </summary>
        public int A3Height { get; set; }
        /// <summary>
        /// 右下角覆盖_x
        /// 
        /// </summary>
        public int A3CoverX { get; set; }
        /// <summary>
        /// 右下角覆盖_y
        /// 
        /// </summary>
        public int A3CoverY { get; set; }
        /// <summary>
        /// 左下角_top
        /// 
        /// </summary>
        public int A4Top { get; set; }
        /// <summary>
        /// 左下角_left
        /// 
        /// </summary>
        public int A4Left { get; set; }
        /// <summary>
        /// 左下角_width
        /// 
        /// </summary>
        public int A4Width { get; set; }
        /// <summary>
        /// 左下角_height
        /// 
        /// </summary>
        public int A4Height { get; set; }
        /// <summary>
        /// 左下角覆盖_x
        /// 
        /// </summary>
        public int A4CoverX { get; set; }
        /// <summary>
        /// 左下角覆盖_y
        /// 
        /// </summary>
        public int A4CoverY { get; set; }
        /// <summary>
        /// 上边_top
        /// 
        /// </summary>
        public int B1Top { get; set; }
        /// <summary>
        /// 上边_left
        /// 
        /// </summary>
        public int B1Left { get; set; }
        /// <summary>
        /// 上边_width
        /// 
        /// </summary>
        public int B1Width { get; set; }
        /// <summary>
        /// 上边_height
        /// 
        /// </summary>
        public int B1Height { get; set; }
        /// <summary>
        /// 左边渲染方式 0 拉伸 1 循环
        /// 
        /// </summary>
        public int B1RenderType { get; set; }
        /// <summary>
        /// 右边_top
        /// 
        /// </summary>
        public int B2Top { get; set; }
        /// <summary>
        /// 右边_left
        /// 
        /// </summary>
        public int B2Left { get; set; }
        /// <summary>
        /// 右边_width
        /// 
        /// </summary>
        public int B2Width { get; set; }
        /// <summary>
        /// 右边_height
        /// 
        /// </summary>
        public int B2Height { get; set; }
        /// <summary>
        /// 左边渲染方式 0 拉伸 1 循环
        /// 
        /// </summary>
        public int B2RenderType { get; set; }
        /// <summary>
        /// 下边_top
        /// 
        /// </summary>
        public int B3Top { get; set; }
        /// <summary>
        /// 下边_left
        /// 
        /// </summary>
        public int B3Left { get; set; }
        /// <summary>
        /// 下边_width
        /// 
        /// </summary>
        public int B3Width { get; set; }
        /// <summary>
        /// 下边_height
        /// 
        /// </summary>
        public int B3Height { get; set; }
        /// <summary>
        /// 左边渲染方式 0 拉伸 1 循环
        /// 
        /// </summary>
        public int B3RenderType { get; set; }
        /// <summary>
        /// 左边_top
        /// 
        /// </summary>
        public int B4Top { get; set; }
        /// <summary>
        /// 左边_left
        /// 
        /// </summary>
        public int B4Left { get; set; }
        /// <summary>
        /// 左边_width
        /// 
        /// </summary>
        public int B4Width { get; set; }
        /// <summary>
        /// 左边_height
        /// 
        /// </summary>
        public int B4Height { get; set; }
        /// <summary>
        /// 左边渲染方式 0 拉伸 1 循环
        /// 
        /// </summary>
        public int B4RenderType { get; set; }
    }

    /// <summary>
    /// 艺术品装裱相关费用
    /// </summary>
    public class ArtworkFramePriceModel
    {
        /// <summary>
        /// 画框费用
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// 物流费用
        /// 
        /// </summary>
        public decimal ExpressAmount { get; set; }
    }

    /// <summary>
    /// 保证金支付单创建参数实体
    /// </summary>
    public class DepositPayorderCreateModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppVer { get; set; }
        /// <summary>
        /// 客户端类型
        /// 可选枚举值:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// 用户的ip地址
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 要支付保证金的用户
        /// 
        /// </summary>
        public long UserId { get; set; }
    }

    /// <summary>
    /// 报价参数实体
    /// </summary>
    public class BidPriceModel
    {
        /// <summary>
        /// 最新报价
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 举牌用户
        /// 
        /// </summary>
        public long UserId { get; set; }
    }

    /// <summary>
    /// 专场评论
    /// </summary>
    public class AuctionsCommentModel
    {
        /// <summary>
        /// 评论用户ID
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 要评论的评论
        /// 
        /// </summary>
        public long CommentId { get; set; }
        /// <summary>
        /// 评论的内容
        /// 
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// 邮件发送参数实体
    /// </summary>
    public class EmailSendModel
    {
        /// <summary>
        /// 收件箱地址
        /// 
        /// </summary>
        public string[] ToEmails { get; set; }
        /// <summary>
        /// 邮件标题
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 邮件正文
        /// 
        /// </summary>
        public string Body { get; set; }
    }

    /// <summary>
    /// 主订单创建参数实体
    /// </summary>
    public class MainOrderCreateModel
    {
        /// <summary>
        /// 创建订单的用户
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 发票抬头
        /// 
        /// </summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// 企业税号
        /// 
        /// </summary>
        public string BusinessTax { get; set; }
        /// <summary>
        /// 用户客户端描述
        /// 
        /// </summary>
        public ClientInfo AppDesc { get; set; }
        /// <summary>
        /// 
        /// 可选枚举值:ArtworkOrder,PointOrder,RmbBuyVipOrder,AuctionDepositOrder,ArtworkPackageOrder
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 保证金订单参数
        /// 
        /// </summary>
        public AuctionDepositOrderCreateModel AuctionDepositParams { get; set; }
        /// <summary>
        /// 艺术品订单的参数
        /// 
        /// </summary>
        public ArtworkOrderCreateModel ArtworkOrderParams { get; set; }
        /// <summary>
        /// 套餐订单创建参数
        /// 
        /// </summary>
        public ArtworkPackageOrderCreateModel PackageOrderParams { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// 客户端类型
        /// 可选枚举值:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// app系统类型,仅在app调用时发送
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// app系统版本,仅在app调用时发送
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// app版本,仅在app调用时发送
        /// 
        /// </summary>
        public string AppVer { get; set; }
    }

    /// <summary>
    /// 拍卖保证金订单创建参数
    /// </summary>
    public class AuctionDepositOrderCreateModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long RoundId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ArtworkOrderCreateModel
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class ArtworkPackageOrderCreateModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long PackageId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public ArtworkGoodsItem[] Goods { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long AddressId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Remark { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ArtworkGoodsItem
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long ArtworkId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long EditionId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long FrameId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long PaddingId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ArtworkPackageOrderPreviewModel
    {
        /// <summary>
        /// 总运费
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// 装裱费用
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// 作品总价格
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 套餐优惠
        /// 
        /// </summary>
        public decimal PackageDiscountAmount { get; set; }
        /// <summary>
        /// 要购买的商品信息
        /// 
        /// </summary>
        public OrderPreviewItemViewModel[] Goods { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PackageName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PackageImgUrl { get; set; }
        /// <summary>
        /// 订单合计金额
        /// 
        /// </summary>
        public decimal Sum { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class OrderPreviewItemViewModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long ArtworkId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long ArtistId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtworkName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// 原价
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 优惠后价格
        /// 
        /// </summary>
        public decimal OriginalPrice { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Edition { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long EditionId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Padding { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long PaddingId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Frame { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long FrameId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ImgUrl { get; set; }
        /// <summary>
        /// 运费
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// 装裱费用
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// 优惠金额
        /// 
        /// </summary>
        public decimal DiscountAmount { get; set; }
        /// <summary>
        /// 活动ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// 是否是会员优品
        /// 
        /// </summary>
        public bool IsVipGood { get; set; }
        /// <summary>
        /// 是否可装裱
        /// 
        /// </summary>
        public bool IsCanMount { get; set; }
        /// <summary>
        /// 活动列表
        /// 
        /// </summary>
        public ADModel[] ADs { get; set; }
    }

    /// <summary>
    /// 广告实体
    /// </summary>
    public class ADModel
    {
        /// <summary>
        /// 广告logo图片连接
        /// 
        /// </summary>
        public string LogoUrl { get; set; }
        /// <summary>
        /// 活动标签
        /// 
        /// </summary>
        public string TagName { get; set; }
        /// <summary>
        /// 活动ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// 活动类型
        /// 
        /// </summary>
        public int ActivityType { get; set; }
        /// <summary>
        /// 广告内容
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 广告页面连接
        /// 
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 优惠券是否可用
        /// 
        /// </summary>
        public bool VoucherEnable { get; set; }
        /// <summary>
        /// 其他
        /// 
        /// </summary>
        public object Expand { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MpPayReqeustModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string appId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string nonceStr { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string package { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string signType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string timeStamp { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string paySign { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WechatPrepayOrderModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PrepayId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string NonceStr { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Package { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PartnerId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Timestamp { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Sign { get; set; }
    }

    /// <summary>
    /// 发送用户站内信实体
    /// </summary>
    public class UserMessageModel
    {
        /// <summary>
        /// 发件人ID
        /// 
        /// </summary>
        public long FromUserId { get; set; }
        /// <summary>
        /// 收件人ID
        /// 
        /// </summary>
        public long[] ToUserIds { get; set; }
        /// <summary>
        /// 发送给所有用户
        /// 
        /// </summary>
        public bool ToTotalUser { get; set; }
        /// <summary>
        /// 消息内容
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 消息类型1.站内用户信息2.系统通知
        /// 
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 消息紧急程度1.普通
        /// 
        /// </summary>
        public int Lv { get; set; }
        /// <summary>
        /// 消息指向的连接
        /// 
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 渠道类型 |站内信|APP推送|  只在系统消息时有效
        /// 
        /// </summary>
        public string ChannelType { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AppNotifyModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string SmsMessage { get; set; }
    }

    /// <summary>
    /// 创建积分订单接口参数实体
    /// </summary>
    public class CreateAccumulatePointsOrderParamModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long PointsGoodsId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long AddressId { get; set; }
        /// <summary>
        /// 用户客户端描述
        /// 
        /// </summary>
        public ClientInfo AppDesc { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Remark { get; set; }
    }

    /// <summary>
    /// 支付单创建参数
    /// </summary>
    public class PayOrderCreateModel
    {
        /// <summary>
        /// APP系统类型
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// app系统版本
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// 客户IP
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// app版本
        /// 
        /// </summary>
        public string AppVer { get; set; }
        /// <summary>
        /// 客户端类型
        /// 可选枚举值:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// 支付金额
        /// 
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// 支付超时时间
        /// 
        /// </summary>
        public DateTime PayTimeout { get; set; }
        /// <summary>
        /// 支付单类型 1 艺术品订单支付 2 拍卖保证金
        /// 
        /// </summary>
        public int PayorderType { get; set; }
    }

    /// <summary>
    /// 创建订单参数
    /// </summary>
    public class CreateOrderParamModel
    {
        /// <summary>
        /// 是否验证打折率
        /// 
        /// </summary>
        public bool IsValidateDiscountRate { get; set; }
        /// <summary>
        /// 拍品ID,拍卖订单时使用
        /// 
        /// </summary>
        public long GoodsId { get; set; }
        /// <summary>
        /// 客户端类型
        /// 可选枚举值:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// 使用艺网码的用户
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 艺网码集合
        /// 
        /// </summary>
        public string[] PromoCodes { get; set; }
        /// <summary>
        /// 要购买的商品数组
        /// 
        /// </summary>
        public GoodsParamModel[] Goods { get; set; }
        /// <summary>
        /// 要创建的订单类型
        /// 可选枚举值:Error,AuctionsOrder,ArtworkBuyOrder,DerivativeOrder
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 订单备注
        /// 
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 地址ID
        /// 
        /// </summary>
        public long AddressId { get; set; }
        /// <summary>
        /// app系统类型,仅在app调用时发送
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// app系统版本,仅在app调用时发送
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// app版本,仅在app调用时发送
        /// 
        /// </summary>
        public string AppVer { get; set; }
        /// <summary>
        /// 客户端IP
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// cps的cookieid
        /// 
        /// </summary>
        public long CpsCookieId { get; set; }
        /// <summary>
        /// 用户优惠券id
        /// 
        /// </summary>
        public long VoucherUserId { get; set; }
        /// <summary>
        /// 用户优惠券id数组
        /// 
        /// </summary>
        public long[] VoucherUserIds { get; set; }
        /// <summary>
        /// 用户运费券Id
        /// 
        /// </summary>
        public long FreightVoucherUserId { get; set; }
        /// <summary>
        /// 分销跟踪艺网码.
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// 发票抬头
        /// 
        /// </summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// 企业税号
        /// 
        /// </summary>
        public string BusinessTax { get; set; }
    }

    /// <summary>
    /// 商品参数实体
    /// </summary>
    public class GoodsParamModel
    {
        /// <summary>
        /// 活动ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// 艺术品ID
        /// 
        /// </summary>
        public long ArtworkId { get; set; }
        /// <summary>
        /// 版画ID
        /// 
        /// </summary>
        public long EditionId { get; set; }
        /// <summary>
        /// 画框ID
        /// 
        /// </summary>
        public long FrameId { get; set; }
        /// <summary>
        /// 衬纸ID
        /// 
        /// </summary>
        public long PaddingId { get; set; }
    }

    /// <summary>
    /// 订单预览实体
    /// </summary>
    public class OrderPreviewModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool Limit5Discount { get; set; }
        /// <summary>
        /// 作品总价格
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 优惠总金额(艺网码优惠与活动优惠之和)
        /// 
        /// </summary>
        public decimal DiscountAmout { get; set; }
        /// <summary>
        /// 会员优惠金额
        /// 
        /// </summary>
        public decimal VipDiscountAmount { get; set; }
        /// <summary>
        /// 艺网码优惠金额
        /// 
        /// </summary>
        public decimal CodeDiscountAmount { get; set; }
        /// <summary>
        /// 活动优惠金额
        /// 
        /// </summary>
        public decimal ActionDiscountAmount { get; set; }
        /// <summary>
        /// 优惠券优惠金额
        /// 
        /// </summary>
        public decimal VoucherAmount { get; set; }
        /// <summary>
        /// 运费券优惠金额
        /// 
        /// </summary>
        public decimal FreightVoucherAmount { get; set; }
        /// <summary>
        /// 礼品卡优惠金额
        /// 
        /// </summary>
        public decimal GiftCardAmount { get; set; }
        /// <summary>
        /// 订单合计金额
        /// 
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// 所有金额相加,不算折扣
        /// 
        /// </summary>
        public decimal TotalSumAmount { get; set; }
        /// <summary>
        /// 总运费
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// 装裱费用
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// 满赠的艺术品列表
        /// 
        /// </summary>
        public long[] ReachedGiftArtworks { get; set; }
        /// <summary>
        /// 满赠广告
        /// 
        /// </summary>
        public ADModel ReachedGiftAD { get; set; }
        /// <summary>
        /// 订单提示信息
        /// 
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 要购买的商品信息
        /// 
        /// </summary>
        public OrderPreviewItemViewModel[] Goods { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SpuCreateModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public long CategoryId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string SpuName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public SpuPropModel[] SpuProps { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public SkuModel[] Skus { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PcView { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MobileView { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string PcDetail { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string MobileDetail { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SpuPropModel
    {
        /// <summary>
        /// 
        /// 可选枚举值:Color,Size,Price,String,Weight,ImgUrl,UrlTag,SpecImgs,Value
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SkuModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public SkuPropModel[] Props { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public decimal Price { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SkuPropModel
    {
        /// <summary>
        /// 
        /// 可选枚举值:Color,Size,Price,String,Weight,ImgUrl,UrlTag,SpecImgs,Value
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string Value { get; set; }
    }

    /// <summary>
    /// 用户注册实体
    /// </summary>
    public class ResetPasswordModel
    {
        /// <summary>
        /// 注册手机号
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 用户密码
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 验证码
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// 设置手机号码参数实体
    /// </summary>
    public class SetPhoneNumberParamsModel
    {
        /// <summary>
        /// 要设置到的手机号码
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 验证码
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// 用户信息参数实体
    /// </summary>
    public class UserInfoParamModel
    {
        /// <summary>
        /// 用户昵称
        /// 
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 真实姓名
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// 可选枚举值:未设置,男,女
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 生日
        /// 
        /// </summary>
        public DateTime Birthday { get; set; }
    }

    /// <summary>
    /// 给批量用户发送优惠券
    /// </summary>
    public class UserSendVoucher
    {
        /// <summary>
        /// 用户的id集合
        /// 
        /// </summary>
        public long[] UserIds { get; set; }
        /// <summary>
        /// 要发送的优惠券
        /// 
        /// </summary>
        public long VoucherId { get; set; }
    }

    /// <summary>
    /// 用户注册实体
    /// </summary>
    public class UserRegModel
    {
        /// <summary>
        /// 账号渠道 0 艺网注册 1 微博登录 2 微信登录
        /// 
        /// </summary>
        public int RegType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// 客户端类型
        /// 可选枚举值:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string WeiboUid { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string WeiboName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string WeChatOpenId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string WeChatUnionId { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string WeChatName { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string FacebookId { get; set; }
        /// <summary>
        /// 对应的APPid
        /// 
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 对应的第三方平台
        /// 
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// 邮箱
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 分销艺网码
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// 注册手机号
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 用户密码
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 验证码
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// 用户信息实体
    /// </summary>
    public class UserInfoModel
    {
        /// <summary>
        /// 用户昵称
        /// 
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// 真实姓名
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// 可选枚举值:未设置,男,女
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 生日
        /// 
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 头像地址
        /// 
        /// </summary>
        public string HeaderImgUrl { get; set; }
        /// <summary>
        /// 手机号
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 是否是代理
        /// 
        /// </summary>
        public bool IsAgent { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsCompleted { get; set; }
        /// <summary>
        /// 
        /// 可选枚举值:系统繁忙,请求成功,获取accessToken时AppSecret错误或者accessToken无效,不合法的凭证类型,不合法的OpenID,不合法的媒体文件类型,不合法的文件类型,不合法的文件大小,不合法的媒体文件id,不合法的消息类型,不合法的图片文件大小,不合法的语音文件大小,不合法的视频文件大小,不合法的缩略图文件大小,不合法的appid,不合法的accessToken,不合法的菜单类型,不合法的按钮个数16,不合法的按钮个数17,不合法的按钮名字长度,不合法的按钮key长度,不合法的按钮url长度,不合法的菜单版本号,不合法的子菜单级数,不合法的子菜单按钮个数,不合法的子菜单按钮类型,不合法的子菜单按钮名字长度,不合法的子菜单按钮key长度,不合法的子菜单按钮url长度,不合法的自定义菜单使用用户,不合法的oauthCode,不合法的refreshToken,不合法的openid列表,不合法的openid列表长度,不合法的请求字符不能包含Unico格式uxxxx格式的字符,不合法的参数,非法的模版Id,不合法的请求格式,不合法的url长度,不合法的分组id,分组名字不合法,缺少accessToken参数,缺少appid参数,缺少refreshToken参数,缺少secret参数,缺少多媒体文件数据,缺少mediaId参数,缺少子菜单数据,缺少oauthcode,缺少openid,AccessToken超时,RefreshToken超时,OauthCode超时,需要get请求,需要post请求,需要https请求,需要接收者关注,需要好友关系,修改模版信息过于频繁,多媒体文件为空,Post的数据包为空,图文消息内容为空,文本消息内容为空,多媒体文件大小超过限制,消息内容超过限制,标题字段超过限制,描述字段超过限制,链接字段超过限制,图片链接字段超过限制,语音播放时间超过限制,图文消息超过限制,接口调用超过限制,创建菜单个数超过限制,回复时间超过限制,系统分组不允许修改,分组名字过长,分组数量超过上限,模板与行业冲突,不存在媒体数据,不存在的菜单版本,不存在的菜单数据,不存在的用户,解析JsonXml内容错误,Api功能未授权,用户未授权该api
        /// </summary>
        public string errcode { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string errmsg { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class JsApiTicket
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ticket { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsCompleted { get; set; }
        /// <summary>
        /// 
        /// 可选枚举值:系统繁忙,请求成功,获取accessToken时AppSecret错误或者accessToken无效,不合法的凭证类型,不合法的OpenID,不合法的媒体文件类型,不合法的文件类型,不合法的文件大小,不合法的媒体文件id,不合法的消息类型,不合法的图片文件大小,不合法的语音文件大小,不合法的视频文件大小,不合法的缩略图文件大小,不合法的appid,不合法的accessToken,不合法的菜单类型,不合法的按钮个数16,不合法的按钮个数17,不合法的按钮名字长度,不合法的按钮key长度,不合法的按钮url长度,不合法的菜单版本号,不合法的子菜单级数,不合法的子菜单按钮个数,不合法的子菜单按钮类型,不合法的子菜单按钮名字长度,不合法的子菜单按钮key长度,不合法的子菜单按钮url长度,不合法的自定义菜单使用用户,不合法的oauthCode,不合法的refreshToken,不合法的openid列表,不合法的openid列表长度,不合法的请求字符不能包含Unico格式uxxxx格式的字符,不合法的参数,非法的模版Id,不合法的请求格式,不合法的url长度,不合法的分组id,分组名字不合法,缺少accessToken参数,缺少appid参数,缺少refreshToken参数,缺少secret参数,缺少多媒体文件数据,缺少mediaId参数,缺少子菜单数据,缺少oauthcode,缺少openid,AccessToken超时,RefreshToken超时,OauthCode超时,需要get请求,需要post请求,需要https请求,需要接收者关注,需要好友关系,修改模版信息过于频繁,多媒体文件为空,Post的数据包为空,图文消息内容为空,文本消息内容为空,多媒体文件大小超过限制,消息内容超过限制,标题字段超过限制,描述字段超过限制,链接字段超过限制,图片链接字段超过限制,语音播放时间超过限制,图文消息超过限制,接口调用超过限制,创建菜单个数超过限制,回复时间超过限制,系统分组不允许修改,分组名字过长,分组数量超过上限,模板与行业冲突,不存在媒体数据,不存在的菜单版本,不存在的菜单数据,不存在的用户,解析JsonXml内容错误,Api功能未授权,用户未授权该api
        /// </summary>
        public string errcode { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string errmsg { get; set; }
    }


}