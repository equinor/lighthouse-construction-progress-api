using FluentAssertions;
using lighthouse_construction_progress_api.Application.WorkOrders.Queries;
using NUnit.Framework;

namespace lighthouse_construction_progress_api.Application.IntegrationTests.WorkOrders.Queries;

using static Testing;

public class GetWorkOrdersTests : TestBase
{
    [Test]
    public async Task ShouldReturnPriorityLevels()
    {
        var query = new GetWorkOrdersQuery();

        var result = await SendAsync(query);

        result.Should().NotBeNull();
    }

}
