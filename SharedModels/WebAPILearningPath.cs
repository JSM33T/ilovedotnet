﻿namespace SharedModels;

public class WebAPILearningPath
{
    public readonly List<ContentMetaData> FullContents = new(12);

    public WebAPILearningPath()
    {
        FullContents =
        new(12)
        {
            new ContentMetaData
            {
                Order = 1,
                Title = "Importance of Status Code in Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/webapi-importance-of-status-code.png",
                ThumbnailUrl = "image/blogs/webapi/webapi-importance-of-status-code.png",
                ContentUrl = "blogs/webapi-importance-of-status-code",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2022, 3, 6, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 3, 6, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 2,
                Title = "Profiling Web API with Mini Profiler",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/profiling-webapi-with-mini-profiler.png",
                ThumbnailUrl = "image/blogs/webapi/profiling-webapi-with-mini-profiler.png",
                ContentUrl = "blogs/profiling-webapi-with-mini-profiler",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2022, 9, 18, 22, 30, 0),
                ModifiedOn = new DateTime(2022, 9, 18, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 3,
                Title = "Unit Testing Filters in ASP.NET Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/unit-testing-filters-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/unit-testing-filters-in-asp-net-webapi.png",
                ContentUrl = "blogs/unit-testing-filters-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 5, 28, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 5, 28, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 4,
                Title = "Unit Testing Middlewares in ASP.NET Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/unit-testing-middlewares-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/unit-testing-middlewares-in-asp-net-webapi.png",
                ContentUrl = "blogs/unit-testing-middlewares-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 6, 4, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 6, 4, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 5,
                Title = "Unit Testing Service Registrations in ASP.NET Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/unit-testing-service-registrations-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/unit-testing-service-registrations-in-asp-net-webapi.png",
                ContentUrl = "blogs/unit-testing-service-registrations-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 6, 11, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 6, 11, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 6,
                Title = "Unit Testing Controllers in ASP.NET Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/unit-testing-controllers-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/unit-testing-controllers-in-asp-net-webapi.png",
                ContentUrl = "blogs/unit-testing-controllers-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 6, 18, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 6, 18, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 7,
                Title = "Perform Background Workloads in Hosted Service using Channels in ASP.NET Web API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/perform-background-workloads-in-hosted-service-using-channels-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/perform-background-workloads-in-hosted-service-using-channels-in-asp-net-webapi.png",
                ContentUrl = "blogs/perform-background-workloads-in-hosted-service-using-channels-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 7, 9, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 7, 9, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 8,
                Title = "Functional testing your ASP.NET WEB API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/functional-testing-your-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/functional-testing-your-asp-net-webapi.png",
                ContentUrl = "blogs/functional-testing-your-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 7, 16, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 7, 16, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 9,
                Title = "Faking Dependencies in Functional testing in ASP.NET WEB API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/faking-dependencies-in-functional-testing-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/faking-dependencies-in-functional-testing-in-asp-net-webapi.png",
                ContentUrl = "blogs/faking-dependencies-in-functional-testing-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 7, 23, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 7, 23, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 10,
                Title = "Using WireMock.NET in Functional testing in ASP.NET WEB API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/using-wiremock-net-in-functional-testing-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/using-wiremock-net-in-functional-testing-in-asp-net-webapi.png",
                ContentUrl = "blogs/using-wiremock-net-in-functional-testing-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 7, 30, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 7, 30, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 11,
                Title = "Configuring Authentication in Functional testing in ASP.NET WEB API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/configuring-authentication-in-functional-testing-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/configuring-authentication-in-functional-testing-in-asp-net-webapi.png",
                ContentUrl = "blogs/configuring-authentication-in-functional-testing-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 8, 6, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 8, 6, 22, 30, 0)
            },
            new ContentMetaData
            {
                Order = 12,
                Title = "Unit Testing Hosted Services in ASP.NET WEB API",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/webapi/unit-testing-hosted-services-in-asp-net-webapi.png",
                ThumbnailUrl = "image/blogs/webapi/unit-testing-hosted-services-in-asp-net-webapi.png",
                ContentUrl = "blogs/unit-testing-hosted-services-in-asp-net-webapi",
                IconUrl = "image/icons/webapi.png",
                Type = "WebAPI",
                CreatedOn = new DateTime(2023, 8, 13, 22, 30, 0),
                ModifiedOn = new DateTime(2023, 8, 13, 22, 30, 0)
            }
        };
    }
}