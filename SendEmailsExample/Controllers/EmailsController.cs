using Microsoft.AspNetCore.Mvc;
using SendEmailsExample.Services;

namespace SendEmailsExample.Controllers
{
    [Route("api/emails")]
    [ApiController]
    public class EmailsController: ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailsController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(string receptor, string subject, string body)
        {
            await emailService.SendEmail(receptor, subject, body);
            return Ok();
        }
    }
}
