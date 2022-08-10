
Account acc1 = new Account { AccountNo = 111, Balance = 5000 };

acc1.alert += Notification.SendEmail;
//acc1.Subscribe(Notification.SendEmail);
Notification n = new Notification();
acc1.alert += n.SendSMS;
//acc1.Subscribe(n.SendSMS);
//acc1.alert("your account has been deposited $999999999999999");
acc1.alert -= Notification.SendEmail;
acc1.alert += Notification.SendEmail;
acc1.alert += n.WhatsApp;
acc1.Deposit(1000);

//acc1.Withdraw(1000);
Console.WriteLine($"Current Balance is {acc1.Balance}");

delegate void Alert(string msg);
class Account
{
    public event Alert alert = null;
    public int AccountNo { get; set; }
    public int Balance { get; set; }

    //public void Subscribe(Alert alert)
    //{
    //    this.alert += alert;
    //}
    //public void Unsubscribe(Alert alert)
    //{
    //    this.alert -= alert;
    //}

    public void Deposit(int amt)
    {


        Balance += amt;
        //Notification.SendEmail($"Deposited {amt} into account {AccountNo}");
        //Notification n = new Notification();
        //alert += n.SendSMS;
        if (alert != null)
            alert($"Deposited {amt} into account {AccountNo}");
    }
    public void Withdraw(int amt)
    {
        Balance -= amt;
        //Notification.SendEmail($"Withdrawn {amt} from account {AccountNo}");
        //Notification n = new Notification();
        //alert += n.SendSMS;
        if (alert != null)
            alert($"Withdrawn {amt} from account {AccountNo}");
    }
}
class Notification
{


    public void WhatsApp(string msg)
    {
        Console.WriteLine($"WhatsApp: {msg}");
    }
    public void SendSMS(string msg)
    {
        Console.WriteLine($"SMS: {msg}");
    }
    public static void SendEmail(string msg)
    {
        Console.WriteLine($"Mail: {msg}");

        //System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient();
        //smtpClient.Host = "smtp.gmail.com";
        //smtpClient.Port = 587;
        //smtpClient.Credentials = null;

        //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage("from-email", "to-email");
        //message.Subject = "subject";
        //message.Body = "MESSAGE BODY";
        ////message.CC = null;
        ////message.Bcc = null;
        //message.Attachments.Add(null);

        //smtpClient.Send(message);
    }
}