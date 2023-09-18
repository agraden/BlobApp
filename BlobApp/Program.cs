using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "";
string containerName = "scripts1";
string blobName = "scripts.sql";
string filePath = "C:\\temp\\script.sql";

// BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
BlobContainerClient blobServiceClient = new BlobContainerClient(connectionString, containerName);

// create container and specify access type
// await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);


// establish client to create blob
BlobClient blobClient = blobServiceClient.GetBlobClient(blobName);

await blobClient.UploadAsync(filePath, true);

Console.WriteLine("Uploaded the blob");