# Serverless-.NET
## Installation (copy & paste)

```bash
# clone solution
# create using the template
serverless create --template-url https://github.com/hoonio/serverless-dotnet --path serverlessDotnet
cd serverlessDotnet
# restore / install dotnet references described in csproj file
dotnet restore serverless.csproj

# install Lambda NET Mock Test Tool and Amazon Lambda Tools
# more details: https://github.com/aws/aws-lambda-dotnet/tree/master/Tools/LambdaTestTool

dotnet tool install -g Amazon.Lambda.Tools
dotnet tool install --global Amazon.Lambda.TestTool-6.0
dotnet tool list -g

# expected dotnet packages:
#
# Package Id                      Version      Commands
------------------------------------------------------------------------
#amazon.lambda.testtool-6.0      0.12.7       dotnet-lambda-test-tool-6.0
#amazon.lambda.tools             5.6.0        dotnet-lambda
```

**For VS Code Debugging:**

> ```bash
> code --install-extension ms-dotnettools.csharp
> ```

## Debug & Test locally

I followed this guideline: (Please read in case of issues)

[How to Debug .NET Core Lambda Functions Locally with the Serverless Framework](https://itnext.io/how-to-debug-net-core-lambda-functions-locally-with-the-serverless-framework-dd1670bc22e2)

## Open Visual Studio Code

```bash
# open Visual Studio Code
code .
```


## Build Package

Mac OS or Linux

```bash
./build.sh
```


## Deploy via Serverless Framework

```bash
serverless deploy
```

A cloudformation stack in AWS will be created in background containing all needed resources

#### After successful deployment you can see following output

<pre>
Service Information
service: myService
stage: dev
region: <b>us-east-1</b>
stack: myService-dev
resources: 10
api keys:
  None
endpoints:
  GET - <b>endpointUrl --> https://{api}.execute-api.us-east-1.amazonaws.com/dev/hello</b>
functions:
  hello: myService-dev-hello
layers:
  None

</pre>

## Test endpoint after deployment

Use the **endpointUrl** from up above.

```bash
curl https://{api}.execute-api.us-east-1.amazonaws.com/dev/hello
```

