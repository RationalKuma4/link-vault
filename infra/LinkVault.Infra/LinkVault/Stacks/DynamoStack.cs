using Amazon.CDK;
using Amazon.CDK.AWS.DynamoDB;

namespace LinkVault.Stacks;

internal class DynamoStack : Stack
{
    public Table LinkVaultTable { get; }
    internal DynamoStack(Construct scope, string id, IStackProps? props = null)
        : base(scope, id, props)
    {
        LinkVaultTable = new Table(this, $"{Settings.ServiceName}-{Settings.Environment}-{Settings.TableName}", new TableProps
        {
            TableName = Settings.TableName,
            PartitionKey = new Amazon.CDK.AWS.DynamoDB.Attribute
            {
                Name = "id",
                Type = AttributeType.STRING
            },
            SortKey = new Amazon.CDK.AWS.DynamoDB.Attribute
            {
                Name = "category",
                Type = AttributeType.STRING
            },
            BillingMode = BillingMode.PAY_PER_REQUEST,
            RemovalPolicy = RemovalPolicy.DESTROY
        });
    }
}