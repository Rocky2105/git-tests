using System.Net;
using System.Net.Mail;

string fromEmail = "rocobros21@gmail.com";
string fromPassword = "zzkp tljs ofdd jkjh";

MailMessage message = new MailMessage()
{
    From = new MailAddress(fromEmail),
    Subject = "Test subject",
    Body = "Test body",
};
message.To.Add(new MailAddress("a20300699@ceti.mx"));

var smtpClient = new SmtpClient("smtp.gmail.com")
{
    Port=587,
    Credentials= new NetworkCredential(fromEmail, fromPassword),
    EnableSsl=true,
};

System.Console.WriteLine("Email enviado");

smtpClient.Send(message);
