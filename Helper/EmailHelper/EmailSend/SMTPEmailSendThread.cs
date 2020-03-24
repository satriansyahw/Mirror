using System.Collections.Generic;
using System.Net.Mail;
using EmailHelper.EmailMessage;
using EmailHelper.MiscClass;
using EmailHelper.Validation;

namespace EmailHelper.EmailSend
{
    public class SMTPEmailSendThread : IEmailSendThread
    {
        MailReturnValue result = new MailReturnValue();
        public SMTPEmailSendThread()
        {

        }
        public SMTPEmailSendThread(EmailSMTPProperties properties)
        {
            EmailProperties.GetInstance.SMTPMailPort = properties.SMTPMailPort;
            EmailProperties.GetInstance.SMTPMailHost = properties.SMTPMailHost;
        }
        public virtual MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail);
            if (!result.IsSuccessMail)
            {
                return result;                
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;

        }
        public virtual MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC, toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
               
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC, toBCC);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMails);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMails);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;

        }

        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody,toMail);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML,toMail, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toCC, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toCC,toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toCC,toBCC, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMails);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML,toMails, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }

        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments, sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments, sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toCC, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toCC, toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments, sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toCC, toBCC, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }
        public MailReturnValue SendEmailThread(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMails);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments,sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMails, emailAttachments);
            ClientSMTP.GetInstance.SentMailThread(mailMessage);
            return result;
        }


    }
}
