﻿using FluentAssertions;
using Paging.Extensions;

namespace Paging.Tests.UnitTests.Extensions.PagedList;

public class PaginatedWithPagerTests
{
	[Fact]
	public void Paginated()
	{
		// Act
		var pagedList = Lab.DataSources.IntegerLists.Items50.Paginate(Lab.DataSources.Pagers.PageNumberFirst);
		
		// Assert
		pagedList.PageNumber.Should().Be(1);
		pagedList.PageSize.Should().Be(10);
		pagedList.TotalItemCount.Should().Be(50);
		pagedList.Count.Should().Be(10);
		pagedList.IsLastPage.Should().BeFalse();
		pagedList.IsFirstPage.Should().BeTrue();
		pagedList.HasPreviousPage.Should().BeFalse();
		pagedList.HasNextPage.Should().BeTrue();
	}
}