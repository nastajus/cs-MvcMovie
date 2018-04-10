## MVC web app

Followed the [Create an MVC web app](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?tabs=aspnetcore1x) from Microsoft, using `ASP.NET Core 1.x`. 

* Added controllers, views, models. 
* Worked with SQL Server LocalDB (sqlite).
* Razor & ASP (views).

#### Next step actionables:

* Search, validation
* Attempt using another RDBMS, like MySQL for example. 


#### Terminology encountered:

* [POCO](https://en.wikipedia.org/wiki/Plain_old_CLR_object)
* [CLR](https://en.wikipedia.org/wiki/Common_Language_Runtime)
* endpoints


#### Tools: 

* Visual Studio 2017
* ReSharper extension by JetBrains


#### Differences Observations Comparing with Nodejs
##### RESTful API comparison: `MvcMovie` against `[Wave Challenge](https://github.com/nastajus/wvchallenge-nodejs)`
###### << Nodejs / JavaScript / Express / Webstorm >> versus << C# / Visual Studio >>

* Disallowed editing code when running in Visual Studio.

* Uses underlying IIS Express system (native to Microsoft platforms).

* Model is defined [here](https://github.com/nastajus/cs-MvcMovie/blob/master/MvcMovie/Models/Movie.cs) in mere simple POCO, with **attributes (decorator function)** *(Those square brackets used above properties, etc)*

	[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
	public DateTime ReleaseDate { get; set; }
	public string Genre { get; set; }

* Yet [there](https://github.com/nastajus/wvchallenge-nodejs/blob/master/models/employee.js), extra properties **were nestable** in true JavaScript fashion. 

    name: {
      type: DataTypes.STRING,
	  unique: true
    },
    address: DataTypes.STRING

* Bulk of contents one folder deeper, e.g. `cs-MvcMovie\MvcMovie`.

* Database setup has handled internally within the IDE for VS (exemplifying Microsoft's all-in-solutioning theme), whereas with Nodejs you get nothing. At least you got nothing in the case of JetBrains, and I suspect is probably true for VS Code, Atom, and all the other competitors (which would be consistent with "the web's" diversified model, as in no vendor seems to take on universal responsibility for the entirity of the whole web stack tech web usually).

* To run concurrent IDE instances, in JetBrains simply opening another project asks you whether you want it in This window or a New window, whereas Microsoft replaces the current project as normal. (Multi-instances accomplished by separately open another instance of VS outside from Windows).


#### Actionables:

* To understand better concept of Solution / Project in VS.
