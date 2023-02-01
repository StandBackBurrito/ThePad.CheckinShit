using ThePad.ChickenShit.Core.Interfaces;

namespace ThePad.ChickenShit.Infrastructure;

public class FakeEmailSender : IEmailSender
{
  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    return Task.CompletedTask;
  }
}
