# NAVWebAppNetCore
#### ASP.NET Core app for consuming Dynamics NAV customer data using Connected Services.

* connects to NAV using Connected Services
* I've used [Unchase.OData.ConnectedService](http://ww.vsixgallery.com/extension/Unchase.OData.ConnectedService.afc46f39-8c64-4e14-85d0-af6c7c4291f3/) extension to consume OData

#### Repro steps:
* create project
	Spec: Net Core, MVC, Windows Authorisation

* add connected services
	choose Unchase Odata

* paste metadata URL
	 http://yourserver:7048/DynamicsNAV130/ODataV4/$metadata

* add controler
	MVC controller with read/write action 
