using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Model;
using YW.Model.Entitys.YW2016;

namespace YW.Dal.Database.DAL.YW2016
{
    //public partial class AuthVerifyCodeDal : Base.CommandBase<Model.Entitys.YW2016.AuthVerifyCode>
    //{
    //    /// <summary>
    //    /// 校验验证码
    //    /// </summary>
    //    /// <param name="phone"></param>
    //    /// <param name="code"></param>
    //    /// <returns></returns>
    //    public ResultModel CheckCode(string phone, string code)
    //    {
    //        //1.获取有效的验证码
    //        var model = Single(m => m.Phone == phone && m.IsExpired == false && m.VerifyTimes <= 10);
    //        if (model == null)
    //        {
    //            return ResultModel.Failed("没有有效的验证码.请重新获取");
    //        }
    //        //2.验证码验证次数加1 
    //        UpdateAdd(() => new AuthVerifyCode { VerifyTimes = 1 }, m => m.Id == model.Id);
    //        return (model.VerifyCode == code) ? ResultModel.Ok() : ResultModel.Failed("验证码错误");
    //    }
    //    /// <summary>
    //    /// 校验验证码
    //    /// </summary>
    //    /// <param name="phone"></param>
    //    /// <param name="code"></param>
    //    /// <returns></returns>
    //    public ResultModel CheckCode(long userid, string code)
    //    {
    //        //1.获取有效的验证码
    //        var models = Where(m => m.UserId == userid && m.IsExpired == false && m.VerifyTimes <= 10 && m.EndTime > DateTime.Now);
    //        if (models == null || !models.Any())
    //        {
    //            return ResultModel.Failed("没有有效的验证码.请重新获取");
    //        }
    //        //2.验证码验证次数加1 
    //        UpdateAdd(() => new AuthVerifyCode { VerifyTimes = 1 }, m => models.Select(a => a.Id).Contains(m.Id));
    //        return models.Any(m => m.VerifyCode == code) ? ResultModel.Ok() : ResultModel.Failed("验证码错误");
    //    }
    //    /// <summary>
    //    /// 创建验证码
    //    /// </summary>
    //    /// <param name="phone"></param>
    //    /// <param name="code"></param>
    //    ///  <param name="requestIp">客户端请求的ip</param>
    //    /// <returns></returns>
    //    public ResultModel CreateCode(string phone, string requestIp,out string code)
    //    {
    //        if (Any(m => m.Phone == phone && m.CreateTime > DateTime.Now.AddSeconds(-60)))
    //        {
    //            code = "";
    //            return ResultModel.Failed("同一个手机号码一分钟内只能发送一条短信验证码.请稍后重试", Model.Enums.ResultCodeEnum.FreqOutOfLimit);
    //        }
    //        code = new Random().Next(0, 10000).ToString().PadLeft(4, '0');
    //        var codemodel = new AuthVerifyCode
    //        {
    //            VerifyCode = code,
    //            CreateTime = DateTime.Now,
    //            Email = "",
    //            Phone = phone,
    //            EndTime = DateTime.Now.AddMinutes(60),
    //            Ip=requestIp
    //        };
    //        Insert(codemodel);
    //        Update(new { IsExpired = true }, m => !m.IsExpired && m.Phone == phone && m.Id != codemodel.Id);
    //        return ResultModel.Ok();
    //    }
    //    /// <summary>
    //    /// 创建验证码
    //    /// </summary>
    //    /// <param name="userId"></param>
    //    /// <param name="code"></param>
    //    /// <returns></returns>
    //    public ResultModel CreateCode(long userId, out string code)
    //    {
    //        if (Any(m => m.UserId == userId && m.CreateTime > DateTime.Now.AddSeconds(-60)))
    //        {
    //            code = "";
    //            return ResultModel.Failed("同一个用户一分钟内只能发送一条验证码.请稍后重试", Model.Enums.ResultCodeEnum.FreqOutOfLimit);
    //        }
    //        code = new Random().Next(0, 10000).ToString().PadLeft(4, '0');
    //        var codemodel = new AuthVerifyCode
    //        {
    //            VerifyCode = code,
    //            CreateTime = DateTime.Now,
    //            Email = "",
    //            UserId = userId,
    //            EndTime = DateTime.Now.AddMinutes(60)
    //        };
    //        Insert(codemodel);
    //        Update(new { IsExpired = true }, m => !m.IsExpired && m.UserId == userId && m.Id != codemodel.Id);
    //        return ResultModel.Ok();
    //    }

    //}
}
