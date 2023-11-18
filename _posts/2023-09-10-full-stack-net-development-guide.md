---

title: 'Full stack .NET Development Guide'
date: '2023-09-10T19:20:00+01:00'
author: Dara Oladapo
excerpt: "In this post, my goal is to give you a little bit of guide into how you can be a .NET Developer focused on C#.\n\nI have been a C# myself for a little over 10 years at the time of writing this post, so I can say I have a bit of 2-cents here and there to give. Let us dive right in, shall we?"

permalink: /2023/09/10/full-stack-net-development-guide-2/

categories:
    - 'Software Development'
---

## Intro

Many folks have been asking me why I remain a .NET Developer with all buzz and popularity around other ecosystems, languages, and frameworks especially among my peers. My answer to them is and has remained that .NET is a pretty solid ecosystem and well so far, have not failed me yet.

You might want to watch this [video from Scott Hanselman](https://www.youtube.com/watch?v=bEfBfBQq7EE&t=839s) where he explained what .NET, C# and F# is to understand some of the building blocks of .NET.

In this post, my goal is to give you a little bit of guide into how you can be a .NET Developer focused on C#.

I have been a C# myself for a little over 10 years at the time of writing this post, so I can say I have a bit of 2-cents here and there to give. Let us dive right in, shall we?

In a previous blog post, [I explained why I write C#](https://daraoladapo.com/why-i-write-c/) – you can read it up but I’ll repeat some of the points in here. Also, you can read up on [the C# Developer Path](https://daraoladapo.com/the-c-developer-path/).

## Understanding full stack

Full stack speaks of the entire system or application. It comprises of the front end (what users see) and the back end (what powers what users see). So most times when you hear folks speaks of a full stack developer, they mean someone who can write applications that users see (runs on the browser/users’ device), runs on the server (back-end services, also connecting them to external services) and databases.

There are numerous language options when considering going full stack. We will look at C# in this post and the many options available to you. One of the reasons I enjoy writing C# is the options are less confusing than others. Let us look first at C# as it concerns web technologies.

Before I begin digging deep: From .NET 5, .NET will become a converged name for .NET ecosystem. .NET 5 (and going forward) will be the cross-platform version of .NET). For those of you who know .NET Framework the one that only runs on Windows), it stops at version 4 and is now in maintenance mode. .NET Core started from .NET Core 1 then 2 then 3 then jumping to 5.

## Backend

When considering developing backend services with C#, your choices are ASP.NET Web Forms (sort of kinda old but still works – my opinion), ASP.NET MVC (.NET Framework) or ASP.NET Core (I will recommend this).

Why I would recommend you go with .NET Core is because it is cross platform – that means it run on Windows, MacOS and Linux and you can use any preferred coding editor that suits you and your style. It also gives you portability just in case you decide to switch or move in between machines.

You can find the official documentation for ASP.NET Core [here](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-3.1).

With ASP.NET Core, you can develop robust back end services on any major operating system with options of hosting on your choice operating system. Sweet part of this is that – IT IS OPEN SOURCE. The whole of .NET is – just in case you did not know. That means you can go ahead and contribute to make it better – even if it is just the docs.

If you decide to write your backend services in C#, you would hear of concepts like Entity Framework, Unit of Work, Repository Pattern, Controllers, Actions, Areas, Authentication, Authorization, Roles, Identity, REST, gRPC, MVC, etc.

## Frontend

Can I write frontend with C#? YES, YES and YES. Okay. That is a lot of YES-es. But for real, since forever (not like since start of time forever though) you could write front-end with C#. Using HTML, CSS, and JavaScript (jQuery made me fall in love).

But now .NET has got its own front-end framework called [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor). That means you can run **C# in your browser** and easily make your web application a PWA with just so little (or no) work.

Blazor (at the time of this post) has 2 flavours, server-side, and web-assembly (WASM).

Your options for C# with front-end are as follow: Web Forms, Razor Views/Pages, Blazor.

Backend + Frontend: Sweet thing with ASP.NET is that you can create your backend and frontend in the same project. You also have the option of using other frontend frameworks like Angular, React, Vue (you need to install the Visual Studio extension).

## Mobile

Writing mobile apps with C# is also very much possible – yes, native apps. You have various options with this.

You use Xamarin to achieve this purpose.

Xamarin.Android for building just android apps, Xamarin.iOS for building just iOS apps, Xamarin.Forms for building Android, iOS, and Windows (UWP) applications, and Xamarin.Mac for building MacOS apps – yup, you read that right. With some more spice, you can write apps for TVs and smart watches.

## Cloud

Yes, you can build cloud services with .NET. Some of your automation tools, and core cloud services are built with C#.

Want to get started at a beginner level? You can checkout Azure Serverless, Data Services, Real Time apps with Signal R.

Check out this [docs link](https://docs.microsoft.com/en-gb/dotnet/azure/#featured-content).

## AI and ML

Have you ever wanted to add machine learning to your apps? With ML.NET, it only takes you a few clicks and lines and codes.

ML.NET is an open-source, cross-platform, and free machine learning framework for .NET developers. That means you can do .NET machine learning on Windows, Linux and MacOS. Read more about getting starting with ML.NET [here](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet).

Another sweet part of the AI and ML capabilities in .NET is that you can use pre-made AI Services called [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) to quickly bootstraps your apps and services with AI services like facial recognition, speech to text, sentiment analysis, and a whole lot more.

There is also F# for Data Scient and ML – check it out [here](https://dotnet.microsoft.com/learn/languages/fsharp-hello-world-tutorial/intro).

I decided not to make this post super long, so I do not bore you. I hope it has been helpful to you. If you have questions or comments, please let me know in the comment below or reach out to me on [Twitter](hptts://twitter.com/daraoladapo) or [LinkedIn](https://linkedin.com/in/daraoladapo).