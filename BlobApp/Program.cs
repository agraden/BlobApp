using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "";
string containerName = "scripts1";

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

// create container and specify access type
await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);

Console.WriteLine("Container created");