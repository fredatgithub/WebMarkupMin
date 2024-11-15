

   --------------------------------------------------------------------------------
           README file for Web Markup Minifier: ASP.NET Core 6+ v2.18.0 RC 1

   --------------------------------------------------------------------------------

           Copyright (c) 2013-2024 Andrey Taritsyn - http://www.taritsyn.ru


   ===========
   DESCRIPTION
   ===========
   WebMarkupMin.AspNetCore6 contains one Middleware for ASP.NET Core 6 and 7 -
   `WebMarkupMinMiddleware`.

   =============
   RELEASE NOTES
   =============
   1. Services required by WebMarkupMin are now conditionally registered using the
      `TryAdd` methods;
   2. Added a `AspNetCoreLogger` class, which is a wrapper around the standard
      ASP.NET Core logger;
   3. Added support for the ASP.NET Core 6.0.35.

   =============
   DOCUMENTATION
   =============
   See documentation on GitHub - https://github.com/Taritsyn/WebMarkupMin/wiki