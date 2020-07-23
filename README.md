# Alexa.NET.APL
Small helper library to allow Alexa.NET skills to work with APL

## Access to APL ViewPort Data within your skill
There are new `Display` and `Viewport` properties available within the request being sent to an APL enabled skill.
Rather than create a forced dependency for Alexa.NET - APL skills have an enhanced SkillRequest object with these new properties
Amazon information on Viewport information: https://developer.amazon.com/docs/alexa-presentation-language/apl-viewport-characteristics.html
Here's an example signature and opening line for a lambda function
```csharp
public Task<SkillResponse> FunctionHandler(APLSkillRequest input, ILambdaContext context)
var shape = input.Context.Viewport?.Shape;
```

## Add All APL Support
```csharp
    APLSupport.Add();
```

## Add support for APL Directives
```csharp
	RenderDocumentDirective.AddSupport();
	ExecuteCommandsDirective.AddSupport();
```

## Check APL support in a request / which version of APL is supported
```csharp
	skillRequest.APLSupported();
	var aplDocumentVersion = skillRequest.APLInterfaceDetails().Runtime.MaxVersion;
```

## If you already have a JSON Layout
If you've used the Alexa designer to generate your APL and just want to send it exactly as-is in the response, we recommend not using the strongly typed APLDocument and RenderDocumentDirective.
###If the APL is stored in the authoring tool - link directly
```csharp
var directive = new RenderDocumentDirective(new APLDocumentLink("doc://alexa/apl/documents/<document-name>"));
```

###If your APL is stored elsewhere
Instead we've contributed to the core Alexa.NET library to enable the JSONDirective type, which saves on the extra processing and complexity of converting to and from an object model for no added benefit.
```csharp
  var directive = new JsonDirective(RenderDocumentDirective.APLDirectiveType);
  directive.Properties.Add("document",aplDocumentJson);
```

## Create an audio document from scratch
As of v6 Alexa.NET.APL now supports APL for Audio
```csharp
var lyrics = new Speech { Content = "Row, row row your boat, gently down the stream. Merrily merrily merrily merrily life is but a dream" };
 skillResponse.Response.Directives.Add(new RenderDocumentDirective(new APLADocument
            {
                MainTemplate = new AudioLayout(
                    new Mixer
                    {
                        Items = new List<APLAComponent>{
                            lyrics,
                            new Sequencer
                            {
                                Items = new List<APLAComponent>{
                                new Silence{Duration = 1500},
                                lyrics
                                }
                            },
                            new Sequencer
                            {
                            Items = new List<APLAComponent>{
                            new Silence{Duration = 3000},
                        lyrics
                    }
            }
                    }
                    })
            }));
```

## Creating a Layout Document from scratch
Alexa.NET.APL has a set of APL components so that creating layouts is entirely within the C# object model
All properties are of Type `APLValue&lt;T&gt;` - which allows you to specify an absolute value or an APL data binding expression for each property
```csharp
  new Layout(
    new Container(
      new Text("APL in C#") {FontSize = "24dp", TextAlign = "Center"}, 
      new Image("https://example.com/image.jpg") {Width = 400, Height = 400}
	)
    { Direction = "row"});
```

## Data Binding / Expressions
If the component property is of type `APLValue<T>` that means you can data bind to it or use an expression instead
For example
```csharp
  component.When = APLValue.To<bool?>("${@viewportProfile == @hubLandscapeSmall}");
```

## Adding an AlexaHeader or Footer layout
Alexa.NET.APL has support for the custom Layouts provided by the Alexa team.
These need to be imported into a document before the layout can be used inside a document.
```csharp
var document = new APLDocument();
document.AddResponsiveDesign();

document.MainTemplate = new Layout(
    new AlexaFooter("Hint Text")
).AsMain();
```

## Sending a RenderDocument Directive
RenderDocument hooks into the same Alexa.NET directive mechanism that already exists, you just reference the layout, document token and any data sources you want to send along with it
```csharp
            var shape = input.Context.Viewport?.Shape;
            var response = ResponseBuilder.Tell($"Your viewport is {shape.ToString() ?? "Non existent"}");

            var directive = new RenderDocumentDirective
            {
                Token = "randomToken",
                Document = new APLDocument
                {
                    MainTemplate = new Layout(new[]
                    {
                        new Container(new APLComponent[]{
                            new Text("APL in C#"){FontSize = "24dp",TextAlign= "Center"},
                            new Image("https://images.example.com/photos/2143/lights-party-dancing-music.jpg?cs=srgb&dl=cheerful-club-concert-2143.jpg&fm=jpg"){Width = 400,Height=400}
                        }){Direction = "row"}
                    })
                }
            };

            response.Response.Directives.Add(directive);
```

## Receiving SendEvent Commands from your layout
Commands are supported within Alexa.NET.APL - to send events back from your layout to your skill you need the SendEvent Command:

https://developer.amazon.com/docs/alexa-presentation-language/apl-standard-commands.html#sendevent-command
```csharp
var wrapper = new TouchWrapper
{
   OnPress = new SendEvent
   {
     Arguments = new Dictionary<string, object> {{"sent", true}}
   }
};
```

To receive these events you need to add support for the UserEventRequest, which can be placed in your Lambda constructor
```csharp
new UserEventRequestHandler().AddToRequestConverter();
```
and then you treat them like any other request type, for example
```csharp
if (input.Request is UserEventRequest userEvent)
{
    var token = userEvent.Token;
    var argument = userEvent.Arguments["sent"];
}
```
Obviously your user may interact with your skill through voice means, at which point you need to be able to send commands down to your layout. This is done with the ExecuteCommands directive
```csharp
using Alexa.NET.APL.Commands;
...
var sendEvent = new ExecuteCommandsDirective("token",new []
{
    new SetPage
    {
        ComponentId="exampleId",
        Value=3
    }
});
```
