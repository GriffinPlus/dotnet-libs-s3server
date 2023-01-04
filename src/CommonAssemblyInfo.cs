using System.Reflection;

[assembly: AssemblyCompany("Griffin+")]
[assembly: AssemblyProduct("Griffin+ S3 Server")]
[assembly: AssemblyCopyright("Copyright (c) 2023 Sascha Falk and Contributors")]
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]
[assembly: AssemblyInformationalVersion("0.1.0-ci.2+Branch.master.Sha.ee85a3bcf7937dce1784c54e35756880454a5b28")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif