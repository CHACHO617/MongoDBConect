using System;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        // Establecer la conexión con el servidor MongoDB
        var connectionString = "mongodb://localhost:27017"; // Puedes cambiar el puerto si es necesario
        var mongoClient = new MongoClient(connectionString);

        // Obtener o crear la base de datos
        var databaseName = "MiPrimeraBaseNOSQL";
        var database = mongoClient.GetDatabase(databaseName);

        // Obtener o crear la colección en la base de datos
        var collectionName = "MiColeccion";
        var collection = database.GetCollection<BsonDocument>(collectionName);

        // Ejemplo de inserción de un documento en la colección
        var document = new BsonDocument
        {
            { "Nombre", "Besnik" },
            { "Edad", 21 },
            { "Ciudad", "NY" }
        };

        collection.InsertOne(document);

        Console.WriteLine("Documento insertado correctamente.");

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}
