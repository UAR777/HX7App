var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HX7App>("hx7app");

builder.Build().Run();
