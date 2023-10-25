using AutoMapper.Internal;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services.Services.EmailService
{
    public partial class EmailService : IEmailService
    {
        private readonly IRepository<EmailConfig> _configRepository;
        public EmailService(IRepository<EmailConfig> configRepository) 
        {
            _configRepository = configRepository;
        }
        public async Task HandleSendMail(SendMailModel model)
        {
            try
            {
                var getMailConfig = await _configRepository.Table.Where(s=>s.ConfigId==model.ConfigId).FirstOrDefaultAsync();
                //var getMailTemplate = await _contextMailTemplate.GetByTemplateId(mailRequest.TemplateId);
                //if (getMailConfig == null || getMailTemplate == null)
                //    throw new NeptuneException("Mail Config or Mail Template not found");

                //var email = new MimeMessage();
                //email.Sender = MailboxAddress.Parse(getMailConfig.Sender);

                //foreach (var address in mailRequest.Receiver.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                //{
                //    email.To.Add(MailboxAddress.Parse(address));
                //}
                //email.Subject = ReplaceData(getMailTemplate.Subject, mailRequest.DataTemplate);


                //var builder = new BodyBuilder();
                //if (mailRequest.AttachmentBase64Strings != null && mailRequest.AttachmentBase64Strings.Count > 0)
                //{
                //    List<byte[]> attachmentByteArrays = mailRequest.AttachmentBase64Strings
                //                    .Select(base64String => Convert.FromBase64String(base64String))
                //                    .ToList();
                //    for (int i = 0; i < attachmentByteArrays.Count; i++)
                //    {
                //        byte[] byteArray = attachmentByteArrays[i];
                //        string filename = mailRequest.AttachmentFilenames[i];

                //        builder.Attachments.Add(filename, byteArray);
                //    }
                //}
                //if (mailRequest.MimeEntities != null && mailRequest.MimeEntities.Count > 0)
                //{
                //    foreach (var entity in mailRequest.MimeEntities)
                //    {
                //        builder.LinkedResources.Add(entity);
                //    }
                //}
                //if (mailRequest.IncludeLogo)
                //{
                //    var imagePartFooter = new MimePart(new ContentType("image", "png"))
                //    {
                //        ContentId = "logo_footer",
                //        Content = new MimeContent(new MemoryStream(Convert.FromBase64String(_setting.LogoBankFooter))),
                //    };
                //    var imagePartHeader = new MimePart(new ContentType("image", "png"))
                //    {
                //        ContentId = "logo_header",
                //        Content = new MimeContent(new MemoryStream(Convert.FromBase64String(_setting.LogoBankHeader))),
                //    };
                //    builder.LinkedResources.Add(imagePartFooter);
                //    builder.LinkedResources.Add(imagePartHeader);
                //}

                //builder.HtmlBody = ReplaceData(getMailTemplate.Body, mailRequest.DataTemplate);
                //email.Body = builder.ToMessageBody();
                //using var smtp = new SmtpClient();
                //smtp.Connect(getMailConfig.Host, getMailConfig.Port, getMailConfig.EnableTLS ? SecureSocketOptions.StartTls : SecureSocketOptions.StartTlsWhenAvailable);
                //smtp.Authenticate(getMailConfig.Sender, getMailConfig.Password);

                //await smtp.SendAsync(email);
                //smtp.Disconnect(true);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
