using TUnit.Core;

namespace AD0001.Replication;

public class Tests
{
    [DataDrivenTest(null)]
    public async Task Test(string? value)
    {
        await Task.CompletedTask;
    }
}