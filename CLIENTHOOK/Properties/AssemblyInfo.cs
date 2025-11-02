using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(ClientHook.BuildInfo.Description)]
[assembly: AssemblyDescription(ClientHook.BuildInfo.Description)]
[assembly: AssemblyCompany(ClientHook.BuildInfo.Company)]
[assembly: AssemblyProduct(ClientHook.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ClientHook.BuildInfo.Author)]
[assembly: AssemblyTrademark(ClientHook.BuildInfo.Company)]
[assembly: AssemblyVersion(ClientHook.BuildInfo.Version)]
[assembly: AssemblyFileVersion(ClientHook.BuildInfo.Version)]
[assembly: MelonInfo(typeof(ClientHook.ClientHook), ClientHook.BuildInfo.Name, ClientHook.BuildInfo.Version, ClientHook.BuildInfo.Author, ClientHook.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]