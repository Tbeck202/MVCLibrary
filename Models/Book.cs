namespace MVCLibrary.Models
{
    /* 
     * Setting up Entity Framework
     * Create Model class for your data (in theis case, we have a Book class)
     * Tools -> NuGet Package Manager -> Package Manager Console
     * Then enter in console: 
     * 1 - Install-Package Microsoft.EntityFrameWorkCore.Design
     * 2 - Install-Package Microsoft.EntityFrameworkCore.SqlServer
     * Solution Explorer -> Controllers -> Add -> New Scaffolded Item
     * Choose MVC Controller with views, using Entity Framework
     * Choose your Model Class (in this case, "Book")
     * Use the + button to the right of Data Context Class selector to have EF build one for you
     * The Controller will be opened automatically, but there were also views and a Data/FooContext.cs file created.
     * A DB Connection String will be created in appsettings.json
     * DB context will also be created in Program.cs "builder.Services.AddDbContext...."
     * Note the "_context" variable in the Controller file built from the "New Scaffolded Item" step.
     * "_context" is basically how you interact with the DB.
     * Package Manager Console -> Enter: Add-Migration InitialCreate 
     *      This will create the database, based on your model (int this case "Book").
     * Migrations folder will be created, with a timestamped "..._InitialCreate.cs" file
     * Migrations/LibraryContextModelSnapshot.cs will also be created.
     * Package Manager Console -> Update-Database
     *      (this command runs the Up method from Migrations/..._InitialCreate.cs)
     * Create link to the Index method in BooksController. Views/Shared/_Layout.cshtml.
     *      <a .... asp-controller="Books" asp-action="Index">Books</a>
     *      
     * SEEDING THE DB
     * Models -> Add -> Class (in this case we called it "SeedData") -> Add
     * See Models/SeedData for all the things you need to set up in there.
     * Put this code in Program.cs
     *      using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }
     *
     * UPDATE THE DB
     * Add desired property to desired Model (in this case, we added "Author" to "Book")
     * Package Manager Console -> Add-Migration DescribeChangeMade
     *      (In this case we ran "Add-Migration AddedBookAuthor")
     * A new Migration file will be created
     * Package Manager Console -> Update-Database
     * Add new property display in relevant views (Index, create, Details, etc..)
     * Add new property to the "[Bind]()" arguments in the controller
     *      In this case we added "Author" to Create(), Edit(), Index() methods in BooksController 
     *      like this: [Bind("Id,Title,CallNumber,Author")]
     */
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CallNumber { get; set; }
        public string Author { get; set; }
    }
}
