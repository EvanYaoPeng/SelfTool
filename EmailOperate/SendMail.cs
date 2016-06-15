using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace CRSSendEmail
{
    /**/
    /// <summary>  
    /// 发送邮件的类  
    /// SendMail sendMail = new SendMail(接收人邮箱, 发送人邮箱, 正文内容, "标题", 发送人密码, "抄送人");
    ///sendMail.Send();
    /// </summary>  
    ///
    public class SendMail
    {

        private MailMessage mailMessage;

        private SmtpClient smtpClient;

        private string password;//发件人密码  

        /**/
        /// <summary>  
        /// 处审核后类的实例 
        /// </summary>  
        /// <param name="To">收件人地址</param>  
        /// <param name="From">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件的主题</param>  
        /// <param name="Password">发件人密码</param>  
        public SendMail(string To, string From, string Body, string Title, string Password, string cc)
        {

            mailMessage = new MailMessage();

            mailMessage.To.Add(To);

            mailMessage.From = new System.Net.Mail.MailAddress(From);

            mailMessage.Subject = Title;

            mailMessage.Body = Body;

            mailMessage.IsBodyHtml = true;

            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;

            mailMessage.Priority = System.Net.Mail.MailPriority.Normal;
            if (!string.IsNullOrEmpty(cc))
                mailMessage.CC.Add(cc);

            this.password = Password;

        }

        /**/
        /// <summary>  
        /// 添加附件  
        /// </summary>  
        public void Attachments(string Path)
        {

            string[] path = Path.Split(',');

            Attachment data;

            ContentDisposition disposition;

            for (int i = 0; i < path.Length; i++)
            {

                data = new Attachment(path[i], MediaTypeNames.Application.Octet);//实例化 附件  

                disposition = data.ContentDisposition;

                disposition.CreationDate = System.IO.File.GetCreationTime(path[i]);//获取 附件的创建日期  

                disposition.ModificationDate = System.IO.File.GetLastWriteTime(path[i]);// 获取附件的修改日期  

                disposition.ReadDate = System.IO.File.GetLastAccessTime(path[i]);//获取附 件的读取日期  

                mailMessage.Attachments.Add(data);//添加到附件中  

            }

        }

        /**/
        /// <summary>  
        /// 异步发送邮件  
        /// </summary>  
        /// <param name="CompletedMethod"></param>  

        public void SendAsync(SendCompletedEventHandler CompletedMethod)
        {

            if (mailMessage != null)
            {

                smtpClient = new SmtpClient();

                smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据  

                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                smtpClient.Host = "smtp." + mailMessage.From.Host;

                smtpClient.SendCompleted += new SendCompletedEventHandler(CompletedMethod);//注册异步发送邮件完成时的事件  

                smtpClient.SendAsync(mailMessage, mailMessage.Body);

            }

        }

        /**/
        /// <summary>  
        /// 发送邮件  
        /// </summary>  
        public void Send()
        {

            if (mailMessage != null)
            {

                smtpClient = new SmtpClient();

                smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据  

                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                //  smtpClient.Host = "smtp." + mailMessage.From.Host;
                smtpClient.Host = "mail." + mailMessage.From.Host;

                smtpClient.Send(mailMessage);
            }

        }

    }

}
