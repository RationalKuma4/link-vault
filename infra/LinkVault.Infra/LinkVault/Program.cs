using Amazon.CDK;
using LinkVault;
using LinkVault.Stacks;

var app = new App();

var serviceTags = new Dictionary<string, string>
{
    ["service"] = Settings.ServiceName,
    ["owner"] = Settings.ServiceOwner,
    ["environment"] = Settings.Environment
};

const string baseName = $"{Settings.ServiceName}-{Settings.Environment}-";

var dynamoStack = new DynamoStack(app, $"{baseName}dynamo", new StackProps
{
    StackName = $"{baseName}dynamo",
    Description = "DynamoDb stack",
    Tags = serviceTags
});

app.Synth();