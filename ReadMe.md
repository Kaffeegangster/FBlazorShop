This is a port of Steve Sanderson's [Pizza Workshop](https://github.com/dotnet-presentations/blazor-workshop) for Blazor
by using F# and Bolero. It also shows an example on How to do CQRS with Event Sourcing using Akka Cluster Sharding. (See how orders are placed on server side)

* Live version working with Server-side blazor is here: https://fblazorshopfast.azurewebsites.net/
* Live version working with WASM is here: https://fblazorshop.azurewebsites.net/


![ScreenShot](FBlazor.png)
## Build & Run instructions:
- Requires .NET Core 3.1 SDK
- Clone the repository (if you choose to download zip, you may need to unblock .config/dotnet-tools.json on windows platform)
- Windows users can just run **run-server-64-bit.cmd** or **run-wasm-64-bit.cmd** depending on which version they want to run.
Then open your browser and browse **https://localhost:5001**.
- Visual studio or VS Code users should first execute one of the run commands above then they can just open the solution and start the FBlazorShop.Web project (better set it as StartUp project). By default the application runs on Server-side mode. If you want Web Assembly, just add WASM compilation constant to the FBlazorShop.Web project and rebuild.

- Linux users need to gather libSQLite.Interop.so and put it to the root folder and build manually (not tested)

