using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class BankAccountsController : ControllerBase
{
    private readonly ILogger<BankAccountsController> _logger;

    public BankAccountsController(ILogger<BankAccountsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBankAccounts")]
    public IEnumerable<BankAccount> Get()
    {
        return Enumerable.Range(1, 5)
                         .Select(index => new BankAccount("FirstOwner", 1000))
                         .ToArray();
    }
}
