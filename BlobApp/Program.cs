using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "";
string containerName = "scripts1";
string blobName = "scripts.sql";
string filePath = "C:\\temp\\script.sql";

BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString, containerName);

// establish client to create blob
BlobClient blobClient = blobServiceClient.GetBlobClient(blobName);

await blobClient.UploadAsync(filePath, true);

Console.WriteLine("Uploaded the blob");