namespace eu.sig.training.ch05.buildandsendmail.v1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
	}

    public class MailContent
    {
        public string Subject { get; set; }
        public string[] Messages { get; set; }

        public string AllMessages => Messages[0] + Messages[1] + Messages[2];
	}

    public class BuildAndSendMailParameters
    {
        public Person Receiver { get; set; }
        public MailContent MailContent { get; set; }

	}

    public class BuildAndSendMail
    {
        // tag::buildAndSendMail[]
        public void DoBuildAndSendMail(MailMan m, BuildAndSendMailParameters mailparams, MailFont font, string division)
        {
            // Format the email address
            string mId = $"{mailparams.Receiver.FirstName[0]}.{mailparams.Receiver.LastName.Substring(0, 7)}" +
                $"@{division.Substring(0, 5)}.compa.ny";
            // Format the message given the content type and raw message
            MailMessage mMessage = FormatMessage(font,
                mailparams.MailContent.AllMessages);
            // Send message
            m.Send(mId, mailparams.MailContent.Subject, mMessage);
        }
        // end::buildAndSendMail[]

        public MailMessage FormatMessage(MailFont font, string s)
        {
            return null;
        }

        public class MailMan
        {

            public void Send(string mId, string subject, MailMessage mMessage) { }

        }

        public class MailFont
        {

        }

        public class MailMessage
        {

        }

    }
}
