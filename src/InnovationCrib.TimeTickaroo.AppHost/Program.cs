var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.InnovationCrib_TimeTickaroo_ApiService>("apiservice");

builder.AddProject<Projects.InnovationCrib_TimeTickaroo_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();