# NAVWebAppNetCore
#### ASP.NET Core app for consuming Dynamics NAV Customers table data using Connected Services.

* connects to NAV using Connected Services
* I've used [Unchase.OData.ConnectedService](http://ww.vsixgallery.com/extension/Unchase.OData.ConnectedService.afc46f39-8c64-4e14-85d0-af6c7c4291f3/) extension to consume OData

#### Repro steps:
* page Customer needs to be published in NAV as OData service
* create new Visual Studio project (specification: ASP.Net Core, MVC, Windows Authorization)
* add Connected Services and choose Unchase Odata
* paste metadata URL (http://yourserver:7048/DynamicsNAV130/ODataV4/$metadata)
* add controller (e.g. scaffolded MVC controller with read/write action)
* write code to query data from NAV (check *public ActionResult Index()* in NAVContentController.cs)
