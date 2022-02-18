# LUSID<sup>®</sup> Luminesce SDK C# (Preview)
![LUSID by Finbourne](https://content.finbourne.com/LUSID_repo.png)

This is the C# SDK (Preview) for the Luminesce application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

Luminesce is a SQL-based data virtualisation service (read/write data to multiple sources, including LUSID).

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

## Installation

The NuGet package for the FINBOURNE Luminesce SDK (Preview) can installed from https://www.nuget.org/packages/Finbourne.Luminesce.Sdk.Preview using the following:

```
$ dotnet add package Finbourne.Luminesce.Sdk.Preview
```

This C# SDK (Preview) supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Luminesce API Documentation](https://www.lusid.com/honeycomb/swagger/index.html). 

## Build Status 

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Luminesce.Sdk.Preview?color=blue) [![Build](https://github.com/finbourne/luminesce-sdk-csharp-preview/actions/workflows/build.yaml/badge.svg?branch=master)](https://github.com/finbourne/luminesce-sdk-csharp-preview/actions/workflows/build.yaml) |