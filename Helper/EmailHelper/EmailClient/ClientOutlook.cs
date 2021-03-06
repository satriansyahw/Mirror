﻿using EmailHelper.MiscClass;
using System;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace EmailHelper.EmailClient
{
    public class ClientOutlook: IClientMail
    {
        MailReturnValue result = new MailReturnValue();
        private static ClientOutlook instance;
        public static ClientOutlook GetInstance
        {
            get
            {
                if (instance == null) instance = new ClientOutlook();
                return instance;
            }
        }
       
        public MailReturnValue SentMail(object mailMessage)
        {
            try
            {
                if (mailMessage == null)
                {
                    result = result.SetMailReturnValue(false, EmailProperties.GetInstance.WrongMailMessageNull);
                }
                result = result.SetMailReturnValue(true, string.Empty);
                Microsoft.Exchange.WebServices.Data.EmailMessage message = (Microsoft.Exchange.WebServices.Data.EmailMessage)mailMessage;
                message.SendAndSaveCopy();
                result = result.SetMailReturnValue(true, string.Empty);
            }
            catch (ArgumentNullException ex)
            {
                result = result.SetMailReturnValue(false, "ArgumentNullException : " + ex.Message);
                return result;
            }
            catch (ObjectDisposedException ex)
            {
                result = result.SetMailReturnValue(false, "ObjectDisposedException_" + ex.Message);
                return result;
            }
            catch (SmtpFailedRecipientsException ex)
            {
                result = result.SetMailReturnValue(false, "SmtpFailedRecipientsException  : " + ex.Message);
                return result;
            }
            catch (SmtpFailedRecipientException ex)
            {
                result = result.SetMailReturnValue(false, "SmtpFailedRecipientException : " + ex.Message);
                return result;
            }
            catch (SmtpException ex)
            {
                result = result.SetMailReturnValue(false, "SmtpException : " + ex.Message);
                return result;
            }
            catch (InvalidOperationException ex)
            {
                result = result.SetMailReturnValue(false, "InvalidOperationException : " + ex.Message);
                return result;
            }
            catch (Exception ex)
            {
                result = result.SetMailReturnValue(false, "Exception : " + ex.Message);
                return result;
            }
            return result;
        }

        public virtual async Task<MailReturnValue> SentMailAsync(object mailMessage)
        {

            await Task.Run(() =>
            {
                result = this.SentMail(mailMessage);
            });
            return result;
        }

        public void SentMailThread(object mailMessage)
        {
            Thread email = new Thread(delegate ()
            {
                this.SentMail(mailMessage);
            });
            email.IsBackground = true;
            email.Start();
        }
    }
}
