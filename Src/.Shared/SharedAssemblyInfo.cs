using System.Reflection;

// Not used and set to empty string for all assemblies
[assembly: AssemblyCulture("")]
[assembly: AssemblyTrademark("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif // DEBUG

[assembly: AssemblyCompany("Sonova")]
[assembly: AssemblyProduct("YourComponentName")]
[assembly: AssemblyCopyright("Copyright © Sonova 2015")]
