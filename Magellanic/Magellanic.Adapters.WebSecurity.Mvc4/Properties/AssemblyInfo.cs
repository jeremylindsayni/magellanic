// ***********************************************************************
// Assembly         : Magellanic.Adapters.WebSecurity.Mvc4
// Author           : Jeremy Lindsay
// Created          : 20-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 28-Dec-2014
// ***********************************************************************
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Magellanic.Adapters.WebSecurity.Mvc4")]
[assembly: AssemblyDescription("This project is a simple wrapper for the static WebSecurity class (found in WebMatrix.WebData) in an Mvc4 project. This can be injected into your class using DI and simplifies unit testing classes that depend on WebMatrix.WebData.WebSecurity.")]

#if DEBUG
    #if NET_45_OR_GREATER
        [assembly: AssemblyConfiguration("Debug, .net 4.5")]
    #elif NET_4
        [assembly: AssemblyConfiguration("Debug, .net 4")]
    #endif
#else
    #if NET_45_OR_GREATER
        [assembly: AssemblyConfiguration("Release, .net 4.5")]
    #elif NET_4
        [assembly: AssemblyConfiguration("Release, .net 4")]
    #endif
#endif

[assembly: AssemblyCompany("Jeremy Lindsay, 2014")]
[assembly: AssemblyProduct("Magellanic.Adapters.WebSecurity.Mvc4")]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("2a12cb79-c9ec-4354-a81c-3557f31a5522")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("0.4.*")]
