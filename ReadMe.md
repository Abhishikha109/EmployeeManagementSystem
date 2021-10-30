To run the db container use

```docker-compose  -f docker-compose.yml up --build```

After tests are run db can be stopped using

```docker-compose  -f docker-compose.yml down ```


link for adding migrations: ``` https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx ```

dotnet ef migrations remove
dotnet ef migrations add MigrationOfEmployee
dotnet ef database update (if name of migrations is not mentioned, then by default it takes the latest added migrations)

AppDbContextModelSnapshot.cs :: this class has contains snapshot of all the migrations we create, like whatever changes we have done.