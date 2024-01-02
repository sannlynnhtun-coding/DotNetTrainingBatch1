https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-7.0

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); // add this line

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}); // add this line

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession(); // add this line

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
```


https://www.chartjs.org/docs/latest/getting-started/
https://www.chartjs.org/docs/latest/samples/information.html
https://www.chartjs.org/docs/latest/samples/utils.html

https://learn.microsoft.com/en-us/aspnet/core/mvc/views/partial?view=aspnetcore-8.0
```csharp
@await Html.PartialAsync("_PartialName.cshtml")
```

![Alt text](https://uxdworld.com/wp-content/uploads/2018/12/pagination-1.gif)

AsNoTracking = with (nolock)


https://github.com/reactiveui/refit
https://reactiveui.github.io/refit/
https://www.ezzylearning.net/wp-content/uploads/ASP.NET-Core-Service-Lifetime-Infographic.png
https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/
https://datatables.net/


![Alt text](https://www.ezzylearning.net/wp-content/uploads/ASP.NET-Core-Service-Lifetime-Infographic.png)

https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli
https://javabydeveloper.com/wp-content/uploads/2020/02/ORM-object-relational-mapping.png
https://stackoverflow.com/questions/74451415/asp-net-core-7-0-error-on-login-the-certificate-chain-was-issued-by-an-authorit

.NET     => https://www.nuget.org/
Frontend => https://www.npmjs.com/
Flutter  => https://pub.dev/
Java     => https://mvnrepository.com/

Pull
Commit (local commit)
Pull (server update or not?)

https://dillinger.io/

https://www.javatpoint.com/ado-net-tutorial
> ADO.NET is a module of .Net Framework which is used to establish connection between application and data sources. Data sources can be such as SQL Server and XML. ADO.NET consists of classes that can be used to connect, retrieve, insert and delete data.

https://www.microsoft.com/en-us/sql-server/sql-server-downloads

https://medium.com/@buttertechn/qa-testing-what-is-dev-sit-uat-prod-ac97965ce4f

DEV  � Development [Software developer]
SIT  � System Integration Test [Software developer and QA engineer]
UAT  � User Acceptance Test [Client]
PROD � Production [Public user]

https://www.dotnettricks.com/learn/mvc/viewdata-vs-viewbag-vs-tempdata-vs-session

https://www.ezzylearning.net/wp-content/uploads/ASP.NET-Core-Service-Lifetime-Infographic.png

<base href="/" />
https://localhost:3000/style.css
https://localhost:3000/blog/style.css
https://localhost:3000/user/style.css

<link href="~/style.css" rel="stylesheet" />

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs

```
dotnet dev-certs https --trust
```

ViewBag
ViewData
TempData

MVC

Model View Controller

> Controller [Server]
> View (model)
> cshtml (csharp cs, html)

Program.cs
https://www.flaticon.com/
https://www.w3schools.com/jsref/met_win_clearinterval.asp
https://datatables.net/examples/index
https://cf-assets.www.cloudflare.com/slt3lc6tev37/7Dy6rquZDDKSJoeS27Y6xc/4a671b7cc7894a475a94f0140981f5d9/what_is_a_cdn_distributed_server_map.png

```
download case

5 MB + project code
3 MB + js libary code
8 MB = total

1 MB = 1 sec
8 MB = 8 sec

cdn case

5 MB + project code
3 MB + cdn
8 MB = total

8 MB = 5 sec
```

https://fontawesome.com/icons
https://cdnjs.com/libraries/font-awesome
https://stackoverflow.com/questions/105034/how-do-i-create-a-guid-uuid
https://www.w3schools.com/jsref/jsref_findindex.asp
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/findIndex
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise

sweetalert [done]
https://sweetalert2.github.io/

notiflix [done]
https://notiflix.github.io/
Notify
Report
Confirm
Loading
Block

datatable
https://datatables.net/examples/index
https://datatables.net/
https://datatables.net/download/

ladda button
https://cdnjs.com/libraries/ladda-bootstrap
https://msurguy.github.io/ladda-bootstrap/
https://github.com/msurguy/ladda-bootstrap

datetime picker
https://fengyuanchen.github.io/datepicker/
https://github.com/fengyuanchen/datepicker/blob/master/README.md
https://github.com/fengyuanchen/datepicker/releases/tag/v1.0.10

radio
checkbox
https://bantikyan.github.io/icheck-bootstrap/
https://cdnjs.com/libraries/icheck-bootstrap
https://github.com/bantikyan/icheck-bootstrap
https://penguin-arts.com/how-to-check-if-a-checkbox-is-checked-using-icheck-library/

toast
https://apvarun.github.io/toastify-js/#
https://github.com/apvarun/toastify-js/blob/master/README.md

switch / toggle
dark mode
how to use theme

Model View Controller
MVC
Program.cs
=> home index
Layout
Main Layout
cshtml
Controller > Action > View (model)
default => no index => blog = blog/index
layout =>

// https://localhost:7007/Home/Index
Controller => Home => Class
Action => Index (Method)
View => return View

localhost:3000/api/blog
localhost:3000/api/user

127.0.0.1:3000/api/user

http method

- get - read
- post - create
- put - update
- patch - update
- delete - delete

http status code
200 - ok
404 - not found
500 - internal server error
400 - bad request
201 - created
401 - unauthorized

https://developer.mozilla.org/en-US/docs/Web/HTTP/Status

endpoint
domain url

ip address
port

restful api ? rest api

A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - The certificate chain was issued by an authority that is not trusted.)
https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn

EF Core Db Provider
https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli

Visual Studio 2022 Installation
https://docs.google.com/document/d/1EJUY9R0_s8BekTq_vN9N7OLmla71kSdG3AA7TTXkm6A/edit

Microsoft SQL Server 2022 Installation
https://docs.google.com/document/d/1RExSyOKaXB5hTbHZAz64tGJHv4cNz8ktvPcIn6iV298/edit

```sql
CREATE TABLE [dbo].[Tbl_Blog](
    [Blog_Id] [int] IDENTITY(1,1) NOT NULL,
    [Blog_Title] [nvarchar](50) NOT NULL,
    [Blog_Author] [nvarchar](50) NOT NULL,
    [Blog_Content] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED
(
    [Blog_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

```sh
- Console App

- Ado.Net (CRUD)
- Dapper  (CRUD)
- EF Entity Framework (Code First => Create Table, Database First => use in Code) (CRUD)
RepoDB

- Asp.Net Core Web Api (Rest Api)
    - EF
    - Dapper
    - Ado.Net
- Postman
- Html, Css, JavaScript, jQuer Plugins (SweetAlert, Notiflix, Date Picker, DataTable, iCheck, ladda button, Toast)
- Asp.Net Core MVC
    - EF
    - Dapper
    - Ado.Net
- Chart [ApexChart, ChartJs, HighCharts, CanvasJS]
- UI Design

Api Call [Console]
    HttpClient
    RestClient
    Refit
Api Call [MVC]
    HttpClient
    RestClient
    Refit
Minimal Api
Text Logging
Db Logging

SignalR - (Insert Data => UpdateChart, Chat Message)
Blazor CRUD [Server, WASM]
------------------------------------------------------
Deploy WASM
Deploy on IIS

Middleware For MVC

GraphQL
gRPC
```
