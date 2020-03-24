﻿
using System.Collections.Generic;
using System.Net.Mail;
using EmailHelper.EmailMessage;
using EmailHelper.MiscClass;
using EmailHelper.Validation;

namespace EmailHelper.EmailSend
{
    public class SMTPEmailSend : IEmailSend
    {
        MailReturnValue result = new MailReturnValue();
        public SMTPEmailSend()
        {
                
        }
        public SMTPEmailSend(EmailSMTPProperties properties)
        {
            EmailProperties.GetInstance.SMTPMailPort = properties.SMTPMailPort;
            EmailProperties.GetInstance.SMTPMailHost = properties.SMTPMailHost;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail)
        {  
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail);
            if(!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail);

            result= ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail,toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail,toCC);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC,toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC,toBCC);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMails);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessage.GetInstance.CreateMessage(fromMail, mailSubject, mailBody, isBodyHTML, toMails);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }

        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail,emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC,emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC, List<EmailAttachment> emailAttachments)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC, toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC, toBCC,emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails, List<EmailAttachment> emailAttachments)
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
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMails,emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }

        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, List<EmailAttachment> emailAttachments, int sizeLimit)
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
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments, sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC, emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, string toMail, string toCC, string toBCC, List<EmailAttachment> emailAttachments, int sizeLimit)
        {
            result = ValidationSendMail.GetInstance.ValidateSendMail(fromMail, mailSubject, mailBody, toMail, toCC, toBCC);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            result = ValidationAtttachment.GetInstance.ValidateAttachment(emailAttachments, sizeLimit);
            if (!result.IsSuccessMail)
            {
                return result;
            }
            MailMessage mailMessage = (MailMessage)CreateSMTPMessageAttachment.GetInstance.CreateMessageWithAttachment(fromMail, mailSubject, mailBody, isBodyHTML, toMail, toCC, toBCC, emailAttachments);
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }
        public virtual MailReturnValue SendEmail(string fromMail, string mailSubject, string mailBody, bool isBodyHTML, EmailToList toMails, List<EmailAttachment> emailAttachments, int sizeLimit)
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
            result = ClientSMTP.GetInstance.SentMail(mailMessage);
            return result;
        }

    }
}
