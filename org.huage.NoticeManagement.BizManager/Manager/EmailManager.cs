using org.huage.NoticeManagement.Entity.Manager;
using Microsoft.Extensions.Logging;
namespace org.huage.NoticeManagement.BizManager.Manager;

public class EmailManager : IEmailManager
{
    private readonly ILogger<EmailManager> _logger;
    
    
    public EmailManager(ILogger<EmailManager> logger)
    {
        _logger = logger;
    }
}