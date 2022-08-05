using Interfaces;

Console.WriteLine("------KPMG COMPANY------");
Console.WriteLine("PRUCHASING SOFTWARE LICESENCE OF TYPE IDbms");

List<IDbms> dbmslicesence = new List<IDbms>();
dbmslicesence.Add(new SqlServer(){ DbInstance = "express",SqlLanguage="SQL"});
dbmslicesence.Add(new SqlServer() { DbInstance = "developer", SqlLanguage = "SQL" });
dbmslicesence.Add(new MongoDb() { DbInstance = "express", SqlLanguage = "json" });
dbmslicesence.Add(new MongoDb() { DbInstance = "ultimate", SqlLanguage = "json+XML" });

foreach (var item in dbmslicesence)
{
    Console.WriteLine(item.LicenseKey);
    Console.WriteLine(item.SqlLanguage);
}