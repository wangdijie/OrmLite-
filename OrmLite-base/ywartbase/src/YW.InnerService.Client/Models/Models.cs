 
 
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
    /// ��������
    /// </summary>
    public class ArtworkSearchModel
    {
        /// <summary>
        /// �ؼ���
        /// 
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// ��С�۸�
        /// 
        /// </summary>
        public int MinPrice { get; set; }
        /// <summary>
        /// ���۸�
        /// 
        /// </summary>
        public int MaxPrice { get; set; }
        /// <summary>
        /// ��С�ߴ�
        /// 
        /// </summary>
        public int MinSize { get; set; }
        /// <summary>
        /// ���ߴ�
        /// 
        /// </summary>
        public int MaxSize { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// ��ɫ
        /// 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// ��״
        /// 
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        /// չʾ�ռ�
        /// 
        /// </summary>
        public string Space { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// ���
        /// 
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public string Theme { get; set; }
        /// <summary>
        /// �Ƿ�򵥳���
        /// 
        /// </summary>
        public bool IsSimpleShow { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool IsOnlyNoSold { get; set; }
        /// <summary>
        /// �������
        /// 
        /// </summary>
        public int SortKey { get; set; }
        /// <summary>
        /// ����Ʒ����
        /// ��ѡö��ֵ:All,Original,Collection,Print
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// ������
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// �Ƿ������
        /// 
        /// </summary>
        public bool IsCollect { get; set; }
        /// <summary>
        /// �Ƿ�����
        /// 
        /// </summary>
        public bool IsZaoyi { get; set; }
        /// <summary>
        /// ����ȫ����Ʒ
        /// 
        /// </summary>
        public bool SearchAll { get; set; }
        /// <summary>
        /// �Ƿ����ղ�����Ʒ
        /// 
        /// </summary>
        public bool IsArtFair { get; set; }
        /// <summary>
        /// ��ǰҳ��
        /// 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// ÿҳ������
        /// 
        /// </summary>
        public int PageSize { get; set; }
    }

    /// <summary>
    /// ����Ʒʵ��model
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
    /// ����ʵ��
    /// </summary>
    public class ArtworkFrameModel
    {
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public FrameModel ArtworkFrame { get; set; }
        /// <summary>
        /// ��ֽ����
        /// 
        /// </summary>
        public FrameModel[] Paddings { get; set; }
    }

    /// <summary>
    /// �������
    /// </summary>
    public class FrameModel
    {
        /// <summary>
        /// ID
        /// 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ���ϵ���
        /// 
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// ����ͼ
        /// 
        /// </summary>
        public string ThumImg { get; set; }
        /// <summary>
        /// ����ͼƬ
        /// 
        /// </summary>
        public string SampleImg { get; set; }
        /// <summary>
        /// ����ֱ��� ����/����
        /// 
        /// </summary>
        public decimal SampleResolution { get; set; }
        /// <summary>
        /// ���Ͻ�_top
        /// 
        /// </summary>
        public int A1Top { get; set; }
        /// <summary>
        /// ���Ͻ�_left
        /// 
        /// </summary>
        public int A1Left { get; set; }
        /// <summary>
        /// ���Ͻ�_width
        /// 
        /// </summary>
        public int A1Width { get; set; }
        /// <summary>
        /// ���Ͻ�_height
        /// 
        /// </summary>
        public int A1Height { get; set; }
        /// <summary>
        /// ���ϽǸ���_x
        /// 
        /// </summary>
        public int A1CoverX { get; set; }
        /// <summary>
        /// ���ϽǸ���_y
        /// 
        /// </summary>
        public int A1CoverY { get; set; }
        /// <summary>
        /// ���Ͻ�_top
        /// 
        /// </summary>
        public int A2Top { get; set; }
        /// <summary>
        /// ���Ͻ�_left
        /// 
        /// </summary>
        public int A2Left { get; set; }
        /// <summary>
        /// ���Ͻ�_width
        /// 
        /// </summary>
        public int A2Width { get; set; }
        /// <summary>
        /// ���Ͻ�_height
        /// 
        /// </summary>
        public int A2Height { get; set; }
        /// <summary>
        /// ���ϽǸ���_x
        /// 
        /// </summary>
        public int A2CoverX { get; set; }
        /// <summary>
        /// ���ϽǸ���_y
        /// 
        /// </summary>
        public int A2CoverY { get; set; }
        /// <summary>
        /// ���½�_top
        /// 
        /// </summary>
        public int A3Top { get; set; }
        /// <summary>
        /// ���½�_left
        /// 
        /// </summary>
        public int A3Left { get; set; }
        /// <summary>
        /// ���½�_width
        /// 
        /// </summary>
        public int A3Width { get; set; }
        /// <summary>
        /// ���½�_height
        /// 
        /// </summary>
        public int A3Height { get; set; }
        /// <summary>
        /// ���½Ǹ���_x
        /// 
        /// </summary>
        public int A3CoverX { get; set; }
        /// <summary>
        /// ���½Ǹ���_y
        /// 
        /// </summary>
        public int A3CoverY { get; set; }
        /// <summary>
        /// ���½�_top
        /// 
        /// </summary>
        public int A4Top { get; set; }
        /// <summary>
        /// ���½�_left
        /// 
        /// </summary>
        public int A4Left { get; set; }
        /// <summary>
        /// ���½�_width
        /// 
        /// </summary>
        public int A4Width { get; set; }
        /// <summary>
        /// ���½�_height
        /// 
        /// </summary>
        public int A4Height { get; set; }
        /// <summary>
        /// ���½Ǹ���_x
        /// 
        /// </summary>
        public int A4CoverX { get; set; }
        /// <summary>
        /// ���½Ǹ���_y
        /// 
        /// </summary>
        public int A4CoverY { get; set; }
        /// <summary>
        /// �ϱ�_top
        /// 
        /// </summary>
        public int B1Top { get; set; }
        /// <summary>
        /// �ϱ�_left
        /// 
        /// </summary>
        public int B1Left { get; set; }
        /// <summary>
        /// �ϱ�_width
        /// 
        /// </summary>
        public int B1Width { get; set; }
        /// <summary>
        /// �ϱ�_height
        /// 
        /// </summary>
        public int B1Height { get; set; }
        /// <summary>
        /// �����Ⱦ��ʽ 0 ���� 1 ѭ��
        /// 
        /// </summary>
        public int B1RenderType { get; set; }
        /// <summary>
        /// �ұ�_top
        /// 
        /// </summary>
        public int B2Top { get; set; }
        /// <summary>
        /// �ұ�_left
        /// 
        /// </summary>
        public int B2Left { get; set; }
        /// <summary>
        /// �ұ�_width
        /// 
        /// </summary>
        public int B2Width { get; set; }
        /// <summary>
        /// �ұ�_height
        /// 
        /// </summary>
        public int B2Height { get; set; }
        /// <summary>
        /// �����Ⱦ��ʽ 0 ���� 1 ѭ��
        /// 
        /// </summary>
        public int B2RenderType { get; set; }
        /// <summary>
        /// �±�_top
        /// 
        /// </summary>
        public int B3Top { get; set; }
        /// <summary>
        /// �±�_left
        /// 
        /// </summary>
        public int B3Left { get; set; }
        /// <summary>
        /// �±�_width
        /// 
        /// </summary>
        public int B3Width { get; set; }
        /// <summary>
        /// �±�_height
        /// 
        /// </summary>
        public int B3Height { get; set; }
        /// <summary>
        /// �����Ⱦ��ʽ 0 ���� 1 ѭ��
        /// 
        /// </summary>
        public int B3RenderType { get; set; }
        /// <summary>
        /// ���_top
        /// 
        /// </summary>
        public int B4Top { get; set; }
        /// <summary>
        /// ���_left
        /// 
        /// </summary>
        public int B4Left { get; set; }
        /// <summary>
        /// ���_width
        /// 
        /// </summary>
        public int B4Width { get; set; }
        /// <summary>
        /// ���_height
        /// 
        /// </summary>
        public int B4Height { get; set; }
        /// <summary>
        /// �����Ⱦ��ʽ 0 ���� 1 ѭ��
        /// 
        /// </summary>
        public int B4RenderType { get; set; }
    }

    /// <summary>
    /// ����Ʒװ����ط���
    /// </summary>
    public class ArtworkFramePriceModel
    {
        /// <summary>
        /// �������
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// ��������
        /// 
        /// </summary>
        public decimal ExpressAmount { get; set; }
    }

    /// <summary>
    /// ��֤��֧������������ʵ��
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
        /// �ͻ�������
        /// ��ѡö��ֵ:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// �û���ip��ַ
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// Ҫ֧����֤����û�
        /// 
        /// </summary>
        public long UserId { get; set; }
    }

    /// <summary>
    /// ���۲���ʵ��
    /// </summary>
    public class BidPriceModel
    {
        /// <summary>
        /// ���±���
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// �����û�
        /// 
        /// </summary>
        public long UserId { get; set; }
    }

    /// <summary>
    /// ר������
    /// </summary>
    public class AuctionsCommentModel
    {
        /// <summary>
        /// �����û�ID
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// Ҫ���۵�����
        /// 
        /// </summary>
        public long CommentId { get; set; }
        /// <summary>
        /// ���۵�����
        /// 
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// �ʼ����Ͳ���ʵ��
    /// </summary>
    public class EmailSendModel
    {
        /// <summary>
        /// �ռ����ַ
        /// 
        /// </summary>
        public string[] ToEmails { get; set; }
        /// <summary>
        /// �ʼ�����
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// �ʼ�����
        /// 
        /// </summary>
        public string Body { get; set; }
    }

    /// <summary>
    /// ��������������ʵ��
    /// </summary>
    public class MainOrderCreateModel
    {
        /// <summary>
        /// �����������û�
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// ��Ʊ̧ͷ
        /// 
        /// </summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// ��ҵ˰��
        /// 
        /// </summary>
        public string BusinessTax { get; set; }
        /// <summary>
        /// �û��ͻ�������
        /// 
        /// </summary>
        public ClientInfo AppDesc { get; set; }
        /// <summary>
        /// 
        /// ��ѡö��ֵ:ArtworkOrder,PointOrder,RmbBuyVipOrder,AuctionDepositOrder,ArtworkPackageOrder
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// ��֤�𶩵�����
        /// 
        /// </summary>
        public AuctionDepositOrderCreateModel AuctionDepositParams { get; set; }
        /// <summary>
        /// ����Ʒ�����Ĳ���
        /// 
        /// </summary>
        public ArtworkOrderCreateModel ArtworkOrderParams { get; set; }
        /// <summary>
        /// �ײͶ�����������
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
        /// �ͻ�������
        /// ��ѡö��ֵ:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// appϵͳ����,����app����ʱ����
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// appϵͳ�汾,����app����ʱ����
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// app�汾,����app����ʱ����
        /// 
        /// </summary>
        public string AppVer { get; set; }
    }

    /// <summary>
    /// ������֤�𶩵���������
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
        /// ���˷�
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// װ�ѷ���
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// ��Ʒ�ܼ۸�
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// �ײ��Ż�
        /// 
        /// </summary>
        public decimal PackageDiscountAmount { get; set; }
        /// <summary>
        /// Ҫ�������Ʒ��Ϣ
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
        /// �����ϼƽ��
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
        /// ԭ��
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// �Żݺ�۸�
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
        /// �˷�
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// װ�ѷ���
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// �Żݽ��
        /// 
        /// </summary>
        public decimal DiscountAmount { get; set; }
        /// <summary>
        /// �ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// �Ƿ��ǻ�Ա��Ʒ
        /// 
        /// </summary>
        public bool IsVipGood { get; set; }
        /// <summary>
        /// �Ƿ��װ��
        /// 
        /// </summary>
        public bool IsCanMount { get; set; }
        /// <summary>
        /// ��б�
        /// 
        /// </summary>
        public ADModel[] ADs { get; set; }
    }

    /// <summary>
    /// ���ʵ��
    /// </summary>
    public class ADModel
    {
        /// <summary>
        /// ���logoͼƬ����
        /// 
        /// </summary>
        public string LogoUrl { get; set; }
        /// <summary>
        /// ���ǩ
        /// 
        /// </summary>
        public string TagName { get; set; }
        /// <summary>
        /// �ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// �����
        /// 
        /// </summary>
        public int ActivityType { get; set; }
        /// <summary>
        /// �������
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// ���ҳ������
        /// 
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// �Ż�ȯ�Ƿ����
        /// 
        /// </summary>
        public bool VoucherEnable { get; set; }
        /// <summary>
        /// ����
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
    /// �����û�վ����ʵ��
    /// </summary>
    public class UserMessageModel
    {
        /// <summary>
        /// ������ID
        /// 
        /// </summary>
        public long FromUserId { get; set; }
        /// <summary>
        /// �ռ���ID
        /// 
        /// </summary>
        public long[] ToUserIds { get; set; }
        /// <summary>
        /// ���͸������û�
        /// 
        /// </summary>
        public bool ToTotalUser { get; set; }
        /// <summary>
        /// ��Ϣ����
        /// 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// ��Ϣ����1.վ���û���Ϣ2.ϵͳ֪ͨ
        /// 
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// ��Ϣ�����̶�1.��ͨ
        /// 
        /// </summary>
        public int Lv { get; set; }
        /// <summary>
        /// ��Ϣָ�������
        /// 
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// �������� |վ����|APP����|  ֻ��ϵͳ��Ϣʱ��Ч
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
    /// �������ֶ����ӿڲ���ʵ��
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
        /// �û��ͻ�������
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
    /// ֧������������
    /// </summary>
    public class PayOrderCreateModel
    {
        /// <summary>
        /// APPϵͳ����
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// appϵͳ�汾
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// �ͻ�IP
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// app�汾
        /// 
        /// </summary>
        public string AppVer { get; set; }
        /// <summary>
        /// �ͻ�������
        /// ��ѡö��ֵ:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// ֧�����
        /// 
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// ֧����ʱʱ��
        /// 
        /// </summary>
        public DateTime PayTimeout { get; set; }
        /// <summary>
        /// ֧�������� 1 ����Ʒ����֧�� 2 ������֤��
        /// 
        /// </summary>
        public int PayorderType { get; set; }
    }

    /// <summary>
    /// ������������
    /// </summary>
    public class CreateOrderParamModel
    {
        /// <summary>
        /// �Ƿ���֤������
        /// 
        /// </summary>
        public bool IsValidateDiscountRate { get; set; }
        /// <summary>
        /// ��ƷID,��������ʱʹ��
        /// 
        /// </summary>
        public long GoodsId { get; set; }
        /// <summary>
        /// �ͻ�������
        /// ��ѡö��ֵ:Unknown,PC,WAP,APP,WxMini,WxWAP
        /// </summary>
        public string ClientType { get; set; }
        /// <summary>
        /// ʹ����������û�
        /// 
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// �����뼯��
        /// 
        /// </summary>
        public string[] PromoCodes { get; set; }
        /// <summary>
        /// Ҫ�������Ʒ����
        /// 
        /// </summary>
        public GoodsParamModel[] Goods { get; set; }
        /// <summary>
        /// Ҫ�����Ķ�������
        /// ��ѡö��ֵ:Error,AuctionsOrder,ArtworkBuyOrder,DerivativeOrder
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// ������ע
        /// 
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// ��ַID
        /// 
        /// </summary>
        public long AddressId { get; set; }
        /// <summary>
        /// appϵͳ����,����app����ʱ����
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// appϵͳ�汾,����app����ʱ����
        /// 
        /// </summary>
        public string AppOsVer { get; set; }
        /// <summary>
        /// app�汾,����app����ʱ����
        /// 
        /// </summary>
        public string AppVer { get; set; }
        /// <summary>
        /// �ͻ���IP
        /// 
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// cps��cookieid
        /// 
        /// </summary>
        public long CpsCookieId { get; set; }
        /// <summary>
        /// �û��Ż�ȯid
        /// 
        /// </summary>
        public long VoucherUserId { get; set; }
        /// <summary>
        /// �û��Ż�ȯid����
        /// 
        /// </summary>
        public long[] VoucherUserIds { get; set; }
        /// <summary>
        /// �û��˷�ȯId
        /// 
        /// </summary>
        public long FreightVoucherUserId { get; set; }
        /// <summary>
        /// ��������������.
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// ��Ʊ̧ͷ
        /// 
        /// </summary>
        public string InvoiceTitle { get; set; }
        /// <summary>
        /// ��ҵ˰��
        /// 
        /// </summary>
        public string BusinessTax { get; set; }
    }

    /// <summary>
    /// ��Ʒ����ʵ��
    /// </summary>
    public class GoodsParamModel
    {
        /// <summary>
        /// �ID
        /// 
        /// </summary>
        public long ActivityId { get; set; }
        /// <summary>
        /// ����ƷID
        /// 
        /// </summary>
        public long ArtworkId { get; set; }
        /// <summary>
        /// �滭ID
        /// 
        /// </summary>
        public long EditionId { get; set; }
        /// <summary>
        /// ����ID
        /// 
        /// </summary>
        public long FrameId { get; set; }
        /// <summary>
        /// ��ֽID
        /// 
        /// </summary>
        public long PaddingId { get; set; }
    }

    /// <summary>
    /// ����Ԥ��ʵ��
    /// </summary>
    public class OrderPreviewModel
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        public bool Limit5Discount { get; set; }
        /// <summary>
        /// ��Ʒ�ܼ۸�
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// �Ż��ܽ��(�������Ż����Ż�֮��)
        /// 
        /// </summary>
        public decimal DiscountAmout { get; set; }
        /// <summary>
        /// ��Ա�Żݽ��
        /// 
        /// </summary>
        public decimal VipDiscountAmount { get; set; }
        /// <summary>
        /// �������Żݽ��
        /// 
        /// </summary>
        public decimal CodeDiscountAmount { get; set; }
        /// <summary>
        /// ��Żݽ��
        /// 
        /// </summary>
        public decimal ActionDiscountAmount { get; set; }
        /// <summary>
        /// �Ż�ȯ�Żݽ��
        /// 
        /// </summary>
        public decimal VoucherAmount { get; set; }
        /// <summary>
        /// �˷�ȯ�Żݽ��
        /// 
        /// </summary>
        public decimal FreightVoucherAmount { get; set; }
        /// <summary>
        /// ��Ʒ���Żݽ��
        /// 
        /// </summary>
        public decimal GiftCardAmount { get; set; }
        /// <summary>
        /// �����ϼƽ��
        /// 
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// ���н�����,�����ۿ�
        /// 
        /// </summary>
        public decimal TotalSumAmount { get; set; }
        /// <summary>
        /// ���˷�
        /// 
        /// </summary>
        public decimal Freight { get; set; }
        /// <summary>
        /// װ�ѷ���
        /// 
        /// </summary>
        public decimal FrameAmount { get; set; }
        /// <summary>
        /// ����������Ʒ�б�
        /// 
        /// </summary>
        public long[] ReachedGiftArtworks { get; set; }
        /// <summary>
        /// �������
        /// 
        /// </summary>
        public ADModel ReachedGiftAD { get; set; }
        /// <summary>
        /// ������ʾ��Ϣ
        /// 
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// Ҫ�������Ʒ��Ϣ
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
        /// ��ѡö��ֵ:Color,Size,Price,String,Weight,ImgUrl,UrlTag,SpecImgs,Value
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
        /// ��ѡö��ֵ:Color,Size,Price,String,Weight,ImgUrl,UrlTag,SpecImgs,Value
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
    /// �û�ע��ʵ��
    /// </summary>
    public class ResetPasswordModel
    {
        /// <summary>
        /// ע���ֻ���
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// �û�����
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// ��֤��
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// �����ֻ��������ʵ��
    /// </summary>
    public class SetPhoneNumberParamsModel
    {
        /// <summary>
        /// Ҫ���õ����ֻ�����
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// ��֤��
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// �û���Ϣ����ʵ��
    /// </summary>
    public class UserInfoParamModel
    {
        /// <summary>
        /// �û��ǳ�
        /// 
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// ��ʵ����
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �Ա�
        /// ��ѡö��ֵ:δ����,��,Ů
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public DateTime Birthday { get; set; }
    }

    /// <summary>
    /// �������û������Ż�ȯ
    /// </summary>
    public class UserSendVoucher
    {
        /// <summary>
        /// �û���id����
        /// 
        /// </summary>
        public long[] UserIds { get; set; }
        /// <summary>
        /// Ҫ���͵��Ż�ȯ
        /// 
        /// </summary>
        public long VoucherId { get; set; }
    }

    /// <summary>
    /// �û�ע��ʵ��
    /// </summary>
    public class UserRegModel
    {
        /// <summary>
        /// �˺����� 0 ����ע�� 1 ΢����¼ 2 ΢�ŵ�¼
        /// 
        /// </summary>
        public int RegType { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string AppOsType { get; set; }
        /// <summary>
        /// �ͻ�������
        /// ��ѡö��ֵ:Unknown,PC,WAP,APP,WxMini,WxWAP
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
        /// ��Ӧ��APPid
        /// 
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// ��Ӧ�ĵ�����ƽ̨
        /// 
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// ����������
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// ע���ֻ���
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// �û�����
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// ��֤��
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// �û���Ϣʵ��
    /// </summary>
    public class UserInfoModel
    {
        /// <summary>
        /// �û��ǳ�
        /// 
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// ��ʵ����
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �Ա�
        /// ��ѡö��ֵ:δ����,��,Ů
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// ����
        /// 
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// ͷ���ַ
        /// 
        /// </summary>
        public string HeaderImgUrl { get; set; }
        /// <summary>
        /// �ֻ���
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// �Ƿ��Ǵ���
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
        /// ��ѡö��ֵ:ϵͳ��æ,����ɹ�,��ȡaccessTokenʱAppSecret�������accessToken��Ч,���Ϸ���ƾ֤����,���Ϸ���OpenID,���Ϸ���ý���ļ�����,���Ϸ����ļ�����,���Ϸ����ļ���С,���Ϸ���ý���ļ�id,���Ϸ�����Ϣ����,���Ϸ���ͼƬ�ļ���С,���Ϸ��������ļ���С,���Ϸ�����Ƶ�ļ���С,���Ϸ�������ͼ�ļ���С,���Ϸ���appid,���Ϸ���accessToken,���Ϸ��Ĳ˵�����,���Ϸ��İ�ť����16,���Ϸ��İ�ť����17,���Ϸ��İ�ť���ֳ���,���Ϸ��İ�ťkey����,���Ϸ��İ�ťurl����,���Ϸ��Ĳ˵��汾��,���Ϸ����Ӳ˵�����,���Ϸ����Ӳ˵���ť����,���Ϸ����Ӳ˵���ť����,���Ϸ����Ӳ˵���ť���ֳ���,���Ϸ����Ӳ˵���ťkey����,���Ϸ����Ӳ˵���ťurl����,���Ϸ����Զ���˵�ʹ���û�,���Ϸ���oauthCode,���Ϸ���refreshToken,���Ϸ���openid�б�,���Ϸ���openid�б���,���Ϸ��������ַ����ܰ���Unico��ʽuxxxx��ʽ���ַ�,���Ϸ��Ĳ���,�Ƿ���ģ��Id,���Ϸ��������ʽ,���Ϸ���url����,���Ϸ��ķ���id,�������ֲ��Ϸ�,ȱ��accessToken����,ȱ��appid����,ȱ��refreshToken����,ȱ��secret����,ȱ�ٶ�ý���ļ�����,ȱ��mediaId����,ȱ���Ӳ˵�����,ȱ��oauthcode,ȱ��openid,AccessToken��ʱ,RefreshToken��ʱ,OauthCode��ʱ,��Ҫget����,��Ҫpost����,��Ҫhttps����,��Ҫ�����߹�ע,��Ҫ���ѹ�ϵ,�޸�ģ����Ϣ����Ƶ��,��ý���ļ�Ϊ��,Post�����ݰ�Ϊ��,ͼ����Ϣ����Ϊ��,�ı���Ϣ����Ϊ��,��ý���ļ���С��������,��Ϣ���ݳ�������,�����ֶγ�������,�����ֶγ�������,�����ֶγ�������,ͼƬ�����ֶγ�������,��������ʱ�䳬������,ͼ����Ϣ��������,�ӿڵ��ó�������,�����˵�������������,�ظ�ʱ�䳬������,ϵͳ���鲻�����޸�,�������ֹ���,����������������,ģ������ҵ��ͻ,������ý������,�����ڵĲ˵��汾,�����ڵĲ˵�����,�����ڵ��û�,����JsonXml���ݴ���,Api����δ��Ȩ,�û�δ��Ȩ��api
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
        /// ��ѡö��ֵ:ϵͳ��æ,����ɹ�,��ȡaccessTokenʱAppSecret�������accessToken��Ч,���Ϸ���ƾ֤����,���Ϸ���OpenID,���Ϸ���ý���ļ�����,���Ϸ����ļ�����,���Ϸ����ļ���С,���Ϸ���ý���ļ�id,���Ϸ�����Ϣ����,���Ϸ���ͼƬ�ļ���С,���Ϸ��������ļ���С,���Ϸ�����Ƶ�ļ���С,���Ϸ�������ͼ�ļ���С,���Ϸ���appid,���Ϸ���accessToken,���Ϸ��Ĳ˵�����,���Ϸ��İ�ť����16,���Ϸ��İ�ť����17,���Ϸ��İ�ť���ֳ���,���Ϸ��İ�ťkey����,���Ϸ��İ�ťurl����,���Ϸ��Ĳ˵��汾��,���Ϸ����Ӳ˵�����,���Ϸ����Ӳ˵���ť����,���Ϸ����Ӳ˵���ť����,���Ϸ����Ӳ˵���ť���ֳ���,���Ϸ����Ӳ˵���ťkey����,���Ϸ����Ӳ˵���ťurl����,���Ϸ����Զ���˵�ʹ���û�,���Ϸ���oauthCode,���Ϸ���refreshToken,���Ϸ���openid�б�,���Ϸ���openid�б���,���Ϸ��������ַ����ܰ���Unico��ʽuxxxx��ʽ���ַ�,���Ϸ��Ĳ���,�Ƿ���ģ��Id,���Ϸ��������ʽ,���Ϸ���url����,���Ϸ��ķ���id,�������ֲ��Ϸ�,ȱ��accessToken����,ȱ��appid����,ȱ��refreshToken����,ȱ��secret����,ȱ�ٶ�ý���ļ�����,ȱ��mediaId����,ȱ���Ӳ˵�����,ȱ��oauthcode,ȱ��openid,AccessToken��ʱ,RefreshToken��ʱ,OauthCode��ʱ,��Ҫget����,��Ҫpost����,��Ҫhttps����,��Ҫ�����߹�ע,��Ҫ���ѹ�ϵ,�޸�ģ����Ϣ����Ƶ��,��ý���ļ�Ϊ��,Post�����ݰ�Ϊ��,ͼ����Ϣ����Ϊ��,�ı���Ϣ����Ϊ��,��ý���ļ���С��������,��Ϣ���ݳ�������,�����ֶγ�������,�����ֶγ�������,�����ֶγ�������,ͼƬ�����ֶγ�������,��������ʱ�䳬������,ͼ����Ϣ��������,�ӿڵ��ó�������,�����˵�������������,�ظ�ʱ�䳬������,ϵͳ���鲻�����޸�,�������ֹ���,����������������,ģ������ҵ��ͻ,������ý������,�����ڵĲ˵��汾,�����ڵĲ˵�����,�����ڵ��û�,����JsonXml���ݴ���,Api����δ��Ȩ,�û�δ��Ȩ��api
        /// </summary>
        public string errcode { get; set; }
        /// <summary>
        /// 
        /// 
        /// </summary>
        public string errmsg { get; set; }
    }


}