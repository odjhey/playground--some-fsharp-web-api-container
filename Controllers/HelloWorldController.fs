namespace FSharpWebApi.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open FSharpWebApi

[<ApiController>]
[<Route("[controller]")>]
type HelloWorldController (logger : ILogger<HelloWorldController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        "hello world"
