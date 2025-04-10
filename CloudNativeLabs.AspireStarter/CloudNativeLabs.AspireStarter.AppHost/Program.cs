var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CloudNativeLabs_AspireStarter_ApiService>("apiservice");

builder.AddProject<Projects.CloudNativeLabs_AspireStarter_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
